Imports System.ComponentModel
Imports System.Net.Http
Imports PackwizGUI.PackwizUtils.PackwizUtils
Imports PackwizGUI.PackwizUtils.PackwizCommands
Imports PackwizGUI.PackwizUtils
Imports DevExpress.XtraRichEdit.Model

Public Class PackwizEditor
    Public modsTable As New DataGridView
    Dim loadScreen As New LoadScreen
    Dim LoadedItems As DataGridViewRow()

    Dim AddNewModFrm As AddNewMod
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddNewModBtn.ItemClick
        AddNewModFrm = New AddNewMod
        AddNewModFrm.ShowDialog()
    End Sub

    Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs) Handles SelectFileBtn.Click
        Dim result = XtraOpenFileDialog1.ShowDialog()

        If result.Equals(DialogResult.OK) Then
            PackwizFileEdit.Text = XtraOpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SaveSettingsBtn.Click
        SaveSettings()
    End Sub

    Private Sub ReloadSettings()
        My.Settings.Reload()
        LoadSettings()
    End Sub

    Private Sub SaveSettings()
        My.Settings.PackwizFile = PackwizFileEdit.Text
        My.Settings.ProjectDirectory = ProjectDirectoryEdit.Text
        My.Settings.AdvancedMode = AdvancedModeToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub LoadSettings()
        PackwizFileEdit.Text = My.Settings.PackwizFile
        ProjectDirectoryEdit.Text = My.Settings.ProjectDirectory
        AdvancedModeToggle.Checked = My.Settings.AdvancedMode
    End Sub

    Private Sub PackwizEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True

        LoadSettings()

        modsTable = InitModsTable(My.Settings.AdvancedMode)

        PanelControl1.Controls.Add(modsTable)

        InitializeMods()
    End Sub

    Private Sub InitializeMods(Optional hideEditor = True)
        If Not BackgroundWorker1.IsBusy Then
            loadScreen.UseProgressBar()
            BackgroundWorker1.RunWorkerAsync()
            loadScreen.ShowDialog()
            Me.Visible = Not hideEditor
        End If
    End Sub

    Private Sub OpenProjectDirectoryFolder_Click(sender As Object, e As EventArgs) Handles OpenProjectDirectoryFolder.Click
        If XtraFolderBrowserDialog1.ShowDialog().Equals(DialogResult.OK) Then
            ProjectDirectoryEdit.Text = XtraFolderBrowserDialog1.SelectedPath
            WriteToFile(My.Settings.ProjectDirectory & My.Settings.ModIndexFileName, "")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        Dim installedMods = GetInstalledMods()
        Dim i As Integer = 0

        Dim client As New HttpClient

        Dim mods As New ArrayList()

        For Each item As String In installedMods
            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Exit For
            Else
                i += 1
                If item.Contains(".jar") Then
                    Dim tmp As New Dictionary(Of String, String) From {
                                        {"project_id", ""},
                                        {"project_type", ""},
                                        {"slug", My.Computer.FileSystem.GetName(item)},
                                        {"author", ""},
                                        {"title", My.Computer.FileSystem.GetName(item)},
                                        {"description", ""}
                    }
                    IndexMod(tmp)
                    mods.Add(tmp)
                Else
                    Dim fileReader = My.Computer.FileSystem.ReadAllText(item).Split(vbLf)

                    Dim proj_id As String

                    Try
                        proj_id = fileReader(11).Split(" = ")(1).Replace("""", "")
                    Catch ex As Exception
                        proj_id = fileReader(12).Split(" = ")(1).Replace("""", "")
                    End Try

                    If CheckIfModIsIndexed(proj_id) Then
                        Dim _mod As _Mod = GetIndexedMod(proj_id)
                        Dim tmp As New Dictionary(Of String, String) From {
                                        {"project_id", proj_id},
                                        {"project_type", "mod"},
                                        {"slug", _mod.Slug},
                                        {"author", _mod.Author},
                                        {"title", _mod.Title},
                                        {"description", _mod.Description}
                        }
                        mods.Add(tmp)
                    Else
                        Dim tmp As New Dictionary(Of String, String) From {
                            {"project_id", proj_id},
                            {"author", ""},
                            {"title", fileReader(0).Split(" = ")(1).Replace("""", "")}
                        }

                        Dim newMod = tmp.Concat(GetMissingModInfo(proj_id, client, IsNumeric(proj_id))).ToDictionary()

                        IndexMod(newMod)

                        mods.Add(newMod)
                    End If
                End If
                Debug.WriteLine(item)

                worker.ReportProgress(i / installedMods.Count * 100)

            End If
        Next

        e.Result = mods
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        loadScreen.progressBarControl.Position = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        AddNewMods(modsTable, e.Result)

        Me.Visible = True

        loadScreen.Close()

        ReDim LoadedItems(modsTable.Rows.Count)

        modsTable.Rows.CopyTo(LoadedItems, 0)
    End Sub

    Private Sub ResetModCache(sender As Object, e As EventArgs) Handles ResetModCacheButton.Click
        If MsgBox("Are you sure you want to reset the mod cache?", MsgBoxStyle.YesNo, "Confirm").Equals(MsgBoxResult.Yes) Then
            WriteToFile(My.Settings.ProjectDirectory & My.Settings.ModIndexFileName, "")
        End If

        If MsgBox("Do you want to reload the window?", MsgBoxStyle.YesNo, "Reload Window?").Equals(MsgBoxResult.Yes) Then
            ReloadMods()
        End If
    End Sub

    Private Sub RemoveMod_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RemoveMod.ItemClick
        For Each Item As DataGridViewRow In modsTable.SelectedRows()
            Debug.WriteLine($"Removing: {Item.Cells(1).Value}")
            PackwizCommands.RemoveMod(Item.Cells(1).Value)
            UnindexMod(Item.Cells(0).Value)
            modsTable.Rows.Remove(Item)
            modsTable.Refresh()
        Next
    End Sub

    Private Function GetRowBasedOnSlug(slug As String) As DataGridViewRow
        For Each item As DataGridViewRow In modsTable.Rows
            If item.Cells(1) Is slug Then
                Return item
            End If
        Next

        Return Nothing
    End Function

    Private Sub SearchEdit_EditValueChanged(sender As Object, e As EventArgs) Handles SearchEdit.EditValueChanged
        Dim i As Integer = 0

        Debug.WriteLine($"Total Number of Rows: {modsTable.Rows.Count}")

        For Each item As _Mod In GetIndexedMods()._Mod.Values
            'Dim rowIndex As Integer = modsTable.Rows.IndexOf(GetRowBasedOnSlug(item.Slug))

            Debug.WriteLine($"Row {i}: {item.Title.Contains(SearchEdit.EditValue.ToString())}")

            modsTable.Rows(i).Visible = item.Title.ToLower().Contains(SearchEdit.EditValue.ToString().ToLower())
            i += 1
        Next
    End Sub

    Public Sub ReloadMods()
        PanelControl1.Controls.Remove(modsTable)

        LoadSettings()

        modsTable = InitModsTable(My.Settings.AdvancedMode)

        PanelControl1.Controls.Add(modsTable)

        InitializeMods(False)
    End Sub

    Private Sub ReloadModsButton_Clicked(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReloadModsButton.ItemClick
        ReloadMods()
    End Sub
End Class