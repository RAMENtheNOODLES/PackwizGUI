Imports System.ComponentModel
Imports System.Net.Http
Imports PackwizGUI.PackwizUtils.Utils
Imports PackwizGUI.PackwizUtils.PackwizCommands
Imports PackwizGUI.PackwizUtils
Imports DevExpress.XtraGrid

Public Class PackwizEditor
    Private Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Public modsTable As GridControl
    Public view As Views.Grid.GridView
    Public modsList As New BindingList(Of _Mod)

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

        Dim tmp As List(Of Object) = InitModsTableDevExpress(modsList, My.Settings.AdvancedMode)
        modsTable = tmp(0)
        view = tmp(1)

        PanelControl1.Controls.Add(modsTable)

        If My.Settings.PackwizFile Is "" Or My.Settings.ProjectDirectory Is "" Then
            Return
        End If

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
                Dim CurrentMod As Dictionary(Of String, String) = ModFileToDictionary(item, False)

                Dim proj_id As String = CurrentMod("project_id")

                If CheckIfModIsIndexed(proj_id) Then
                    Dim _mod As _Mod = GetIndexedMod(proj_id)
                    mods.Add(ModDictionaryBuilder(proj_id, "mod", _mod.Slug, _mod.Author, _mod.Title, _mod.Description))
                Else
                    Dim NewMod As Dictionary(Of String, String) = ModFileToDictionary(item)
                    IndexMod(NewMod)

                    mods.Add(NewMod)
                End If
                Logger.Debug(item)

                worker.ReportProgress(i / installedMods.Count * 100)

            End If
        Next

        e.Result = mods
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        loadScreen.progressBarControl.Position = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        AddNewMods(modsList, e.Result)

        Me.Visible = True

        loadScreen.Close()

        view.BestFitColumns()
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
        For Each Item As Integer In view.GetSelectedRows()
            Dim row As _Mod = view.GetRow(Item)
            Logger.Debug($"Removing: {row.Slug}")
            PackwizCommands.RemoveMod(row.Slug)
            UnindexMod(row.ModID)
            modsList.Remove(row)
        Next
        modsTable.RefreshDataSource()
        view.BestFitColumns()
    End Sub

    Public Sub ReloadMods()
        PanelControl1.Controls.Remove(modsTable)

        LoadSettings()

        modsList.Clear()

        Dim tmp As List(Of Object) = InitModsTableDevExpress(modsList, My.Settings.AdvancedMode)
        modsTable = tmp(0)
        view = tmp(1)

        PanelControl1.Controls.Add(modsTable)

        InitializeMods(False)

        view.BestFitColumns()
    End Sub

    Private Sub ReloadModsButton_Clicked(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReloadModsButton.ItemClick
        ReloadMods()
    End Sub

    Private Sub UpdateModButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UpdateModButton.ItemClick
        For Each Item As Integer In view.GetSelectedRows()
            Dim row As _Mod = view.GetRow(Item)
            Logger.Debug($"Updating: {row.Slug}")
            UpdateMods(row.Slug)
        Next
    End Sub

    Private Sub UpdateAllModsButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UpdateAllModsButton.ItemClick
        UpdateAllMods()
    End Sub

    Private Sub PackwizEditor_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        NLog.LogManager.Shutdown()
    End Sub

    Private Sub PackwizEditor_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        view.BestFitColumns()
    End Sub
End Class