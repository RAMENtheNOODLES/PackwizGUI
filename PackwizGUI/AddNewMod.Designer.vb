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
        PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        NextButton = New DevExpress.XtraEditors.SimpleButton()
        LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        PreviousButton = New DevExpress.XtraEditors.SimpleButton()
        ModsShownEdit = New DevExpress.XtraEditors.TextEdit()
        InstallModButton = New DevExpress.XtraEditors.SimpleButton()
        PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(ModNameEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(PanelControl1, ComponentModel.ISupportInitialize).BeginInit()
        PanelControl1.SuspendLayout()
        CType(PanelControl3, ComponentModel.ISupportInitialize).BeginInit()
        PanelControl3.SuspendLayout()
        CType(ModsShownEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(PanelControl2, ComponentModel.ISupportInitialize).BeginInit()
        PanelControl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ModNameEdit
        ' 
        ModNameEdit.Location = New Point(5, 5)
        ModNameEdit.Margin = New Padding(3, 2, 3, 2)
        ModNameEdit.Name = "ModNameEdit"
        ModNameEdit.Size = New Size(134, 28)
        ModNameEdit.TabIndex = 0
        ModNameEdit.ToolTip = "Name of the Mod you want to add"
        ' 
        ' SearchForModBtn
        ' 
        SearchForModBtn.ImageOptions.SvgImage = CType(resources.GetObject("SearchForModBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        SearchForModBtn.Location = New Point(145, 4)
        SearchForModBtn.Margin = New Padding(3, 2, 3, 2)
        SearchForModBtn.Name = "SearchForModBtn"
        SearchForModBtn.Size = New Size(101, 29)
        SearchForModBtn.TabIndex = 1
        SearchForModBtn.Text = "Search"
        ' 
        ' PanelControl1
        ' 
        PanelControl1.Controls.Add(PanelControl3)
        PanelControl1.Dock = DockStyle.Fill
        PanelControl1.Location = New Point(0, 38)
        PanelControl1.Margin = New Padding(3, 2, 3, 2)
        PanelControl1.Name = "PanelControl1"
        PanelControl1.Size = New Size(1146, 444)
        PanelControl1.TabIndex = 2
        ' 
        ' PanelControl3
        ' 
        PanelControl3.Controls.Add(NextButton)
        PanelControl3.Controls.Add(LabelControl2)
        PanelControl3.Controls.Add(LabelControl1)
        PanelControl3.Controls.Add(PreviousButton)
        PanelControl3.Controls.Add(ModsShownEdit)
        PanelControl3.Dock = DockStyle.Bottom
        PanelControl3.Location = New Point(2, 404)
        PanelControl3.Name = "PanelControl3"
        PanelControl3.Size = New Size(1142, 38)
        PanelControl3.TabIndex = 9
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Point(211, 6)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(40, 23)
        NextButton.TabIndex = 8
        NextButton.Text = "Next"
        ' 
        ' LabelControl2
        ' 
        LabelControl2.Location = New Point(162, 11)
        LabelControl2.Name = "LabelControl2"
        LabelControl2.Size = New Size(43, 13)
        LabelControl2.TabIndex = 7
        LabelControl2.Text = "Page 0/0"
        ' 
        ' LabelControl1
        ' 
        LabelControl1.Location = New Point(5, 11)
        LabelControl1.Margin = New Padding(3, 2, 3, 2)
        LabelControl1.Name = "LabelControl1"
        LabelControl1.Size = New Size(60, 13)
        LabelControl1.TabIndex = 4
        LabelControl1.Text = "Mods Shown"
        ' 
        ' PreviousButton
        ' 
        PreviousButton.Location = New Point(116, 6)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(40, 23)
        PreviousButton.TabIndex = 6
        PreviousButton.Text = "Prev"
        ' 
        ' ModsShownEdit
        ' 
        ModsShownEdit.EditValue = "50"
        ModsShownEdit.Location = New Point(71, 4)
        ModsShownEdit.Margin = New Padding(3, 2, 3, 2)
        ModsShownEdit.Name = "ModsShownEdit"
        ModsShownEdit.Properties.Appearance.Options.UseTextOptions = True
        ModsShownEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        ModsShownEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        ModsShownEdit.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        ModsShownEdit.Properties.MaskSettings.Set("mask", "([1-9][0-9]?)|(100)")
        ModsShownEdit.Properties.NullValuePrompt = "Any # 1-100"
        ModsShownEdit.Size = New Size(39, 28)
        ModsShownEdit.TabIndex = 5
        ' 
        ' InstallModButton
        ' 
        InstallModButton.ImageOptions.SvgImage = CType(resources.GetObject("InstallModButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        InstallModButton.Location = New Point(252, 4)
        InstallModButton.Margin = New Padding(3, 2, 3, 2)
        InstallModButton.Name = "InstallModButton"
        InstallModButton.Size = New Size(101, 29)
        InstallModButton.TabIndex = 3
        InstallModButton.Text = "Install Mod"
        ' 
        ' PanelControl2
        ' 
        PanelControl2.Controls.Add(InstallModButton)
        PanelControl2.Controls.Add(SearchForModBtn)
        PanelControl2.Controls.Add(ModNameEdit)
        PanelControl2.Dock = DockStyle.Top
        PanelControl2.Location = New Point(0, 0)
        PanelControl2.Name = "PanelControl2"
        PanelControl2.Size = New Size(1146, 38)
        PanelControl2.TabIndex = 8
        ' 
        ' AddNewMod
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1146, 482)
        Controls.Add(PanelControl1)
        Controls.Add(PanelControl2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "AddNewMod"
        Text = "AddNewMod"
        CType(ModNameEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(PanelControl1, ComponentModel.ISupportInitialize).EndInit()
        PanelControl1.ResumeLayout(False)
        CType(PanelControl3, ComponentModel.ISupportInitialize).EndInit()
        PanelControl3.ResumeLayout(False)
        PanelControl3.PerformLayout()
        CType(ModsShownEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(PanelControl2, ComponentModel.ISupportInitialize).EndInit()
        PanelControl2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ModNameEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchForModBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents InstallModButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModsShownEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PreviousButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents NextButton As DevExpress.XtraEditors.SimpleButton
End Class
