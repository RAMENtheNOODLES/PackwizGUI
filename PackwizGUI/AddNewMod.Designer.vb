<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewMod
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewMod))
        ModNameEdit = New DevExpress.XtraEditors.TextEdit()
        SearchForModBtn = New DevExpress.XtraEditors.SimpleButton()
        PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        InstallModButton = New DevExpress.XtraEditors.SimpleButton()
        CType(ModNameEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(PanelControl1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ModNameEdit
        ' 
        ModNameEdit.Location = New Point(12, 12)
        ModNameEdit.Name = "ModNameEdit"
        ModNameEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        ModNameEdit.Properties.MaskSettings.Set("mask", ".+")
        ModNameEdit.Size = New Size(156, 34)
        ModNameEdit.TabIndex = 0
        ModNameEdit.ToolTip = "Name of the Mod you want to add"
        ' 
        ' SearchForModBtn
        ' 
        SearchForModBtn.ImageOptions.SvgImage = CType(resources.GetObject("SearchForModBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        SearchForModBtn.Location = New Point(174, 10)
        SearchForModBtn.Name = "SearchForModBtn"
        SearchForModBtn.Size = New Size(118, 36)
        SearchForModBtn.TabIndex = 1
        SearchForModBtn.Text = "Search"
        ' 
        ' PanelControl1
        ' 
        PanelControl1.Location = New Point(12, 52)
        PanelControl1.Name = "PanelControl1"
        PanelControl1.Size = New Size(1313, 543)
        PanelControl1.TabIndex = 2
        ' 
        ' InstallModButton
        ' 
        InstallModButton.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        InstallModButton.Location = New Point(298, 10)
        InstallModButton.Name = "InstallModButton"
        InstallModButton.Size = New Size(118, 36)
        InstallModButton.TabIndex = 3
        InstallModButton.Text = "Install Mod"
        ' 
        ' AddNewMod
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1337, 603)
        Controls.Add(InstallModButton)
        Controls.Add(PanelControl1)
        Controls.Add(SearchForModBtn)
        Controls.Add(ModNameEdit)
        Name = "AddNewMod"
        Text = "AddNewMod"
        CType(ModNameEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(PanelControl1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ModNameEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchForModBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents InstallModButton As DevExpress.XtraEditors.SimpleButton
End Class
