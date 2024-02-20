﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PackwizEditor
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PackwizEditor))
        AddNewModBtn = New DevExpress.XtraBars.BarButtonItem()
        SettingsHeader = New DevExpress.XtraBars.BarHeaderItem()
        Bar4 = New DevExpress.XtraBars.Bar()
        TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        SettingsPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        AdvancedModeToggle = New DevExpress.XtraEditors.CheckEdit()
        RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        RemoveMod = New DevExpress.XtraBars.BarButtonItem()
        BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        SearchEdit = New DevExpress.XtraBars.BarEditItem()
        RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        ReloadModsButton = New DevExpress.XtraBars.BarButtonItem()
        RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        RepositoryItemBreadCrumbEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit()
        RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        ResetModCacheButton = New DevExpress.XtraEditors.SimpleButton()
        OpenProjectDirectoryFolder = New DevExpress.XtraEditors.SimpleButton()
        ProjectDirectoryEdit = New DevExpress.XtraEditors.TextEdit()
        LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        SaveSettingsBtn = New DevExpress.XtraEditors.SimpleButton()
        SelectFileBtn = New DevExpress.XtraEditors.SimpleButton()
        LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        PackwizFileEdit = New DevExpress.XtraEditors.TextEdit()
        TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        SidePanel1 = New DevExpress.XtraEditors.SidePanel()
        XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(components)
        XtraFolderBrowserDialog1 = New DevExpress.XtraEditors.XtraFolderBrowserDialog(components)
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(TabPane1, ComponentModel.ISupportInitialize).BeginInit()
        TabPane1.SuspendLayout()
        SettingsPage.SuspendLayout()
        CType(AdvancedModeToggle.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(RibbonControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RepositoryItemLookUpEdit1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RepositoryItemTextEdit1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RepositoryItemBreadCrumbEdit1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProjectDirectoryEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(PackwizFileEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        TabNavigationPage1.SuspendLayout()
        CType(PanelControl1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AddNewModBtn
        ' 
        AddNewModBtn.Caption = "Add New Mod"
        AddNewModBtn.Hint = "Add New Mod"
        AddNewModBtn.Id = 0
        AddNewModBtn.ImageOptions.SvgImage = CType(resources.GetObject("AddNewModBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        AddNewModBtn.Name = "AddNewModBtn"
        AddNewModBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        ' 
        ' SettingsHeader
        ' 
        SettingsHeader.Caption = "Settings"
        SettingsHeader.Id = 1
        SettingsHeader.Name = "SettingsHeader"
        ' 
        ' Bar4
        ' 
        Bar4.BarName = "Custom 5"
        Bar4.DockCol = 0
        Bar4.DockRow = 2
        Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Bar4.Text = "Custom 5"
        ' 
        ' TabPane1
        ' 
        TabPane1.Controls.Add(SettingsPage)
        TabPane1.Controls.Add(TabNavigationPage1)
        TabPane1.Dock = DockStyle.Fill
        TabPane1.Location = New Point(0, 242)
        TabPane1.Margin = New Padding(4, 2, 4, 2)
        TabPane1.Name = "TabPane1"
        TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {TabNavigationPage1, SettingsPage})
        TabPane1.RegularSize = New Size(1208, 307)
        TabPane1.SelectedPage = TabNavigationPage1
        TabPane1.Size = New Size(1208, 307)
        TabPane1.TabIndex = 14
        TabPane1.Text = "TabPane1"
        ' 
        ' SettingsPage
        ' 
        SettingsPage.Caption = "Settings"
        SettingsPage.Controls.Add(AdvancedModeToggle)
        SettingsPage.Controls.Add(ResetModCacheButton)
        SettingsPage.Controls.Add(OpenProjectDirectoryFolder)
        SettingsPage.Controls.Add(ProjectDirectoryEdit)
        SettingsPage.Controls.Add(LabelControl2)
        SettingsPage.Controls.Add(SaveSettingsBtn)
        SettingsPage.Controls.Add(SelectFileBtn)
        SettingsPage.Controls.Add(LabelControl1)
        SettingsPage.Controls.Add(PackwizFileEdit)
        SettingsPage.Margin = New Padding(4, 2, 4, 2)
        SettingsPage.Name = "SettingsPage"
        SettingsPage.Size = New Size(1208, 256)
        ' 
        ' AdvancedModeToggle
        ' 
        AdvancedModeToggle.Location = New Point(113, 82)
        AdvancedModeToggle.MenuManager = RibbonControl1
        AdvancedModeToggle.Name = "AdvancedModeToggle"
        AdvancedModeToggle.Properties.Caption = "Advanced Mode"
        AdvancedModeToggle.Size = New Size(156, 26)
        AdvancedModeToggle.TabIndex = 8
        ' 
        ' RibbonControl1
        ' 
        RibbonControl1.ExpandCollapseItem.Id = 0
        RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {RibbonControl1.ExpandCollapseItem, RibbonControl1.SearchEditItem, AddNewModBtn, SettingsHeader, RemoveMod, BarEditItem1, SearchEdit, ReloadModsButton})
        RibbonControl1.Location = New Point(0, 0)
        RibbonControl1.Margin = New Padding(4, 2, 4, 2)
        RibbonControl1.MaxItemId = 4
        RibbonControl1.Name = "RibbonControl1"
        RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {RibbonPage1})
        RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {RepositoryItemBreadCrumbEdit1, RepositoryItemLookUpEdit1, RepositoryItemTextEdit1})
        RibbonControl1.Size = New Size(1208, 242)
        RibbonControl1.StatusBar = RibbonStatusBar1
        ' 
        ' RemoveMod
        ' 
        RemoveMod.Caption = "Remove Mod"
        RemoveMod.Hint = "Remove Mod(s)"
        RemoveMod.Id = 5
        RemoveMod.ImageOptions.SvgImage = CType(resources.GetObject("RemoveMod.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        RemoveMod.Name = "RemoveMod"
        RemoveMod.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        ' 
        ' BarEditItem1
        ' 
        BarEditItem1.Caption = "BarEditItem1"
        BarEditItem1.Edit = RepositoryItemLookUpEdit1
        BarEditItem1.Id = 1
        BarEditItem1.Name = "BarEditItem1"
        ' 
        ' RepositoryItemLookUpEdit1
        ' 
        RepositoryItemLookUpEdit1.AutoHeight = False
        RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        ' 
        ' SearchEdit
        ' 
        SearchEdit.Caption = "Search"
        SearchEdit.Edit = RepositoryItemTextEdit1
        SearchEdit.Id = 2
        SearchEdit.Name = "SearchEdit"
        ' 
        ' RepositoryItemTextEdit1
        ' 
        RepositoryItemTextEdit1.AutoHeight = False
        RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        ' 
        ' ReloadModsButton
        ' 
        ReloadModsButton.Caption = "Reload Mods"
        ReloadModsButton.Hint = "Reload The Mods Table"
        ReloadModsButton.Id = 3
        ReloadModsButton.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ReloadModsButton.Name = "ReloadModsButton"
        ReloadModsButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        ' 
        ' RibbonPage1
        ' 
        RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {RibbonPageGroup1})
        RibbonPage1.Name = "RibbonPage1"
        ' 
        ' RibbonPageGroup1
        ' 
        RibbonPageGroup1.ItemLinks.Add(AddNewModBtn)
        RibbonPageGroup1.ItemLinks.Add(RemoveMod)
        RibbonPageGroup1.ItemLinks.Add(ReloadModsButton)
        RibbonPageGroup1.Name = "RibbonPageGroup1"
        RibbonPageGroup1.Text = "Tools"
        ' 
        ' RepositoryItemBreadCrumbEdit1
        ' 
        RepositoryItemBreadCrumbEdit1.AutoHeight = False
        RepositoryItemBreadCrumbEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        RepositoryItemBreadCrumbEdit1.Name = "RepositoryItemBreadCrumbEdit1"
        ' 
        ' RibbonStatusBar1
        ' 
        RibbonStatusBar1.ItemLinks.Add(SearchEdit)
        RibbonStatusBar1.Location = New Point(0, 549)
        RibbonStatusBar1.Margin = New Padding(4, 2, 4, 2)
        RibbonStatusBar1.Name = "RibbonStatusBar1"
        RibbonStatusBar1.Ribbon = RibbonControl1
        RibbonStatusBar1.Size = New Size(1208, 45)
        ' 
        ' ResetModCacheButton
        ' 
        ResetModCacheButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ResetModCacheButton.ImageOptions.SvgImage = CType(resources.GetObject("ResetModCacheButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ResetModCacheButton.Location = New Point(999, 144)
        ResetModCacheButton.Margin = New Padding(4, 2, 4, 2)
        ResetModCacheButton.Name = "ResetModCacheButton"
        ResetModCacheButton.Size = New Size(197, 36)
        ResetModCacheButton.TabIndex = 7
        ResetModCacheButton.Text = "Reset Mod Cache"
        ' 
        ' OpenProjectDirectoryFolder
        ' 
        OpenProjectDirectoryFolder.ImageOptions.SvgImage = CType(resources.GetObject("OpenProjectDirectoryFolder.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        OpenProjectDirectoryFolder.Location = New Point(275, 41)
        OpenProjectDirectoryFolder.Margin = New Padding(4, 2, 4, 2)
        OpenProjectDirectoryFolder.Name = "OpenProjectDirectoryFolder"
        OpenProjectDirectoryFolder.Size = New Size(46, 36)
        OpenProjectDirectoryFolder.TabIndex = 6
        ' 
        ' ProjectDirectoryEdit
        ' 
        ProjectDirectoryEdit.Location = New Point(113, 43)
        ProjectDirectoryEdit.Margin = New Padding(4, 2, 4, 2)
        ProjectDirectoryEdit.Name = "ProjectDirectoryEdit"
        ProjectDirectoryEdit.Size = New Size(156, 34)
        ProjectDirectoryEdit.TabIndex = 5
        ' 
        ' LabelControl2
        ' 
        LabelControl2.Location = New Point(12, 52)
        LabelControl2.Margin = New Padding(4, 2, 4, 2)
        LabelControl2.Name = "LabelControl2"
        LabelControl2.Size = New Size(95, 16)
        LabelControl2.TabIndex = 4
        LabelControl2.Text = "Project Directory"
        ' 
        ' SaveSettingsBtn
        ' 
        SaveSettingsBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SaveSettingsBtn.ImageOptions.SvgImage = CType(resources.GetObject("SaveSettingsBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        SaveSettingsBtn.Location = New Point(999, 192)
        SaveSettingsBtn.Margin = New Padding(4, 2, 4, 2)
        SaveSettingsBtn.Name = "SaveSettingsBtn"
        SaveSettingsBtn.Size = New Size(197, 36)
        SaveSettingsBtn.TabIndex = 3
        SaveSettingsBtn.Text = "Save Settings"
        ' 
        ' SelectFileBtn
        ' 
        SelectFileBtn.ImageOptions.SvgImage = CType(resources.GetObject("SelectFileBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        SelectFileBtn.Location = New Point(275, 4)
        SelectFileBtn.Margin = New Padding(4, 2, 4, 2)
        SelectFileBtn.Name = "SelectFileBtn"
        SelectFileBtn.Size = New Size(46, 36)
        SelectFileBtn.TabIndex = 2
        ' 
        ' LabelControl1
        ' 
        LabelControl1.Location = New Point(12, 12)
        LabelControl1.Margin = New Padding(4, 2, 4, 2)
        LabelControl1.Name = "LabelControl1"
        LabelControl1.Size = New Size(69, 16)
        LabelControl1.TabIndex = 1
        LabelControl1.Text = "Packwiz File"
        ' 
        ' PackwizFileEdit
        ' 
        PackwizFileEdit.Location = New Point(113, 5)
        PackwizFileEdit.Margin = New Padding(4, 2, 4, 2)
        PackwizFileEdit.Name = "PackwizFileEdit"
        PackwizFileEdit.Size = New Size(156, 34)
        PackwizFileEdit.TabIndex = 0
        ' 
        ' TabNavigationPage1
        ' 
        TabNavigationPage1.Caption = "Mod Page"
        TabNavigationPage1.Controls.Add(PanelControl1)
        TabNavigationPage1.Margin = New Padding(4, 2, 4, 2)
        TabNavigationPage1.Name = "TabNavigationPage1"
        TabNavigationPage1.Size = New Size(1208, 256)
        ' 
        ' PanelControl1
        ' 
        PanelControl1.Dock = DockStyle.Fill
        PanelControl1.Location = New Point(0, 0)
        PanelControl1.Margin = New Padding(4, 2, 4, 2)
        PanelControl1.Name = "PanelControl1"
        PanelControl1.Size = New Size(1208, 256)
        PanelControl1.TabIndex = 0
        ' 
        ' SidePanel1
        ' 
        SidePanel1.Dock = DockStyle.Right
        SidePanel1.Location = New Point(1114, 0)
        SidePanel1.Name = "SidePanel1"
        SidePanel1.Size = New Size(94, 450)
        SidePanel1.TabIndex = 0
        SidePanel1.Text = "SidePanel1"
        ' 
        ' XtraOpenFileDialog1
        ' 
        XtraOpenFileDialog1.DefaultExt = "exe"
        XtraOpenFileDialog1.Filter = "Executable Files (*.exe)|*.exe"
        XtraOpenFileDialog1.RestoreDirectory = True
        XtraOpenFileDialog1.Title = "Select Packwiz Executable"
        ' 
        ' XtraFolderBrowserDialog1
        ' 
        XtraFolderBrowserDialog1.Description = "Packwiz Project Directory"
        XtraFolderBrowserDialog1.Title = "Choose Project Directory"
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' PackwizEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1208, 594)
        Controls.Add(TabPane1)
        Controls.Add(RibbonStatusBar1)
        Controls.Add(RibbonControl1)
        Margin = New Padding(4)
        Name = "PackwizEditor"
        Ribbon = RibbonControl1
        StatusBar = RibbonStatusBar1
        Text = "PackwizEditor"
        CType(TabPane1, ComponentModel.ISupportInitialize).EndInit()
        TabPane1.ResumeLayout(False)
        SettingsPage.ResumeLayout(False)
        SettingsPage.PerformLayout()
        CType(AdvancedModeToggle.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(RibbonControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(RepositoryItemLookUpEdit1, ComponentModel.ISupportInitialize).EndInit()
        CType(RepositoryItemTextEdit1, ComponentModel.ISupportInitialize).EndInit()
        CType(RepositoryItemBreadCrumbEdit1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProjectDirectoryEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(PackwizFileEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        TabNavigationPage1.ResumeLayout(False)
        CType(PanelControl1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()


    End Sub
    Friend WithEvents AddNewModBtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SettingsHeader As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents ModsPage As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents SidePanel1 As DevExpress.XtraEditors.SidePanel
    Friend WithEvents SettingsPage As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents SelectFileBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PackwizFileEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SaveSettingsBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenProjectDirectoryFolder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProjectDirectoryEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraFolderBrowserDialog1 As DevExpress.XtraEditors.XtraFolderBrowserDialog
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ResetModCacheButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RemoveMod As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemBreadCrumbEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SearchEdit As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ReloadModsButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AdvancedModeToggle As DevExpress.XtraEditors.CheckEdit
    'Friend WithEvents ModsPage As DevExpress.XtraBars.Navigation.TabNavigationPage

End Class
