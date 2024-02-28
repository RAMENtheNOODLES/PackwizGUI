Imports System.ComponentModel
Imports DevExpress.XtraWizard
Imports PackwizGUI.PackwizUtils.PackwizCommands

Public Class InitializePackwizFrm
    Public PackwizEditor As PackwizEditor

    Private Sub UseLatestMinecraftVer_CheckedChanged(sender As Object, e As EventArgs) Handles UseLatestMinecraftVer.CheckedChanged
        MinecraftVersion.Enabled = Not UseLatestMinecraftVer.Checked
    End Sub

    Private Sub UseLatestModLoaderVersion_CheckedChanged(sender As Object, e As EventArgs) Handles UseLatestModLoaderVersion.CheckedChanged
        ModLoaderVersion.Enabled = Not UseLatestModLoaderVersion.Checked
    End Sub

    Private Sub WizardControl1_NextClick(sender As Object, e As WizardCommandButtonClickEventArgs) ' Handles WizardControl1.NextClick
        If Not WizardControl1.SelectedPageIndex.Equals(1) Then
            Return
        End If

        If Me.ValidateChildren() Then
            WizardControl1.SetNextPage()
        End If

    End Sub

    Private Sub TextBoxes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _
            Author.Validating,
            ModpackName.Validating,
            ModpackVersion.Validating,
            ModLoader.Validating,
            ModLoaderVersion.Validating,
            MinecraftVersion.Validating,
            ProjectDirectoryFileEdit.Validating,
            PackwizFileEdit.Validating

        Dim field = DirectCast(sender, DevExpress.XtraEditors.TextEdit)

        If String.IsNullOrWhiteSpace(field.Text) And field.Enabled Then
            field.SelectAll()

            e.Cancel = True
        End If

    End Sub

    Private Sub OpenProjectDirectoryFolder_Click(sender As Object, e As EventArgs) Handles OpenProjectDirectoryBtn.Click
        If XtraFolderBrowserDialog1.ShowDialog().Equals(DialogResult.OK) Then
            ProjectDirectoryFileEdit.Text = XtraFolderBrowserDialog1.SelectedPath
            PackwizUtils.WriteToFile(My.Settings.ProjectDirectory & My.Settings.ModIndexFileName, "")
        End If
    End Sub

    Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs) Handles OpenPackwizFileBtn.Click
        Dim result = XtraOpenFileDialog1.ShowDialog()

        If result.Equals(DialogResult.OK) Then
            PackwizFileEdit.Text = XtraOpenFileDialog1.FileName
        End If
    End Sub

    Public Sub LoadSettings()
        My.Settings.Reload()

        ProjectDirectoryFileEdit.Text = My.Settings.ProjectDirectory
        PackwizFileEdit.Text = My.Settings.PackwizFile.Replace("""", "")
    End Sub

    Private Sub WizardControl1_CancelClick(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub WizardControl1_FinishClick(sender As Object, e As CancelEventArgs) Handles WizardControl1.FinishClick
        My.Settings.ProjectDirectory = ProjectDirectoryFileEdit.Text
        My.Settings.PackwizFile = $"""{PackwizFileEdit.Text}"""
        My.Settings.Save()
        My.Settings.Reload()

        InitPackwiz(Author.Text, ModpackName.Text, ModpackVersion.Text,
                    ModLoader.Text, If(ModLoaderVersion.Enabled, ModLoaderVersion.Text, ""),
                    If(MinecraftVersion.Enabled, MinecraftVersion.Text, ""))
    End Sub

    Private Sub InitializePackwizFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub
End Class