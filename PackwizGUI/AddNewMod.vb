Imports System.Net.Http
Imports PackwizGUI.PackwizUtils.PackwizUtils
Imports PackwizGUI.PackwizUtils.PackwizCommands

Public Class AddNewMod
    Private Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    ReadOnly client As HttpClient = New HttpClient()
    Dim modsTable As New DataGridView

    Dim totalPages As Integer = 1
    Dim currentPage As Integer = 1

    Private Sub SearchForModBtn_Click(sender As Object, e As EventArgs) Handles SearchForModBtn.Click
        RefreshMods(modsTable, client, ModNameEdit.Text, ModsShownEdit.Text)
    End Sub

    Private Sub AddNewMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modsTable = InitModsTable(True)

        PanelControl1.Controls.Add(modsTable)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles InstallModButton.Click
        For Each Item As DataGridViewRow In modsTable.SelectedRows()
            Logger.Debug($"Downloading: {Item.Cells(0).Value}")
            AddMod(Item.Cells(0).Value, Item.Cells(5).Value IsNot "curseforge")
            PackwizUtils.PackwizUtils.AddNewMod(PackwizEditor.modsTable, Item.Cells(0).Value, Item.Cells(1).Value, Item.Cells(2).Value, Item.Cells(3).Value, Item.Cells(4).Value, Item.Cells(5).Value)
        Next
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        currentPage = Math.Clamp(currentPage - 1, 1, totalPages)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        currentPage = Math.Clamp(currentPage + 1, 1, totalPages)
    End Sub
End Class