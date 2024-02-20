Imports System.Net.Http
Imports PackwizGUI.PackwizUtils.PackwizUtils
Imports PackwizGUI.PackwizUtils.PackwizCommands

Public Class AddNewMod
    ReadOnly client As HttpClient = New HttpClient()
    Dim modsTable As New DataGridView

    Private Sub SearchForModBtn_Click(sender As Object, e As EventArgs) Handles SearchForModBtn.Click
        RefreshMods(modsTable, client, ModNameEdit.Text)
    End Sub

    Private Sub AddNewMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modsTable = InitModsTable(True)

        PanelControl1.Controls.Add(modsTable)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles InstallModButton.Click
        For Each Item As DataGridViewRow In modsTable.SelectedRows()
            Debug.WriteLine($"Downloading: {Item.Cells(0).Value}")
            AddMod(Item.Cells(0).Value)
            PackwizUtils.PackwizUtils.AddNewMod(PackwizEditor.modsTable, Item.Cells(0).Value, Item.Cells(1).Value, Item.Cells(2).Value, Item.Cells(3).Value, Item.Cells(4).Value)
        Next
    End Sub
End Class