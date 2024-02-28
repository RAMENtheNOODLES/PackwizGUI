<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitializePackwizFrm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InitializePackwizFrm))
        WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
        WizardPage1 = New DevExpress.XtraWizard.WizardPage()
        LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Author = New DevExpress.XtraEditors.TextEdit()
        ModpackName = New DevExpress.XtraEditors.TextEdit()
        ModpackVersion = New DevExpress.XtraEditors.TextEdit()
        MinecraftVersion = New DevExpress.XtraEditors.TextEdit()
        UseLatestMinecraftVer = New DevExpress.XtraEditors.CheckEdit()
        ModLoader = New DevExpress.XtraEditors.ComboBoxEdit()
        ModLoaderVersion = New DevExpress.XtraEditors.TextEdit()
        UseLatestModLoaderVersion = New DevExpress.XtraEditors.CheckEdit()
        ProjectDirectoryFileEdit = New DevExpress.XtraEditors.TextEdit()
        PackwizFileEdit = New DevExpress.XtraEditors.TextEdit()
        OpenProjectDirectoryBtn = New DevExpress.XtraEditors.SimpleButton()
        OpenPackwizFileBtn = New DevExpress.XtraEditors.SimpleButton()
        Root = New DevExpress.XtraLayout.LayoutControlGroup()
        LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        XtraFolderBrowserDialog1 = New DevExpress.XtraEditors.XtraFolderBrowserDialog(components)
        XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(components)
        CType(WizardControl1, ComponentModel.ISupportInitialize).BeginInit()
        WizardControl1.SuspendLayout()
        WizardPage1.SuspendLayout()
        CType(LayoutControl1, ComponentModel.ISupportInitialize).BeginInit()
        LayoutControl1.SuspendLayout()
        CType(Author.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(ModpackName.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(ModpackVersion.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(MinecraftVersion.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(UseLatestMinecraftVer.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(ModLoader.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(ModLoaderVersion.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(UseLatestModLoaderVersion.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProjectDirectoryFileEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(PackwizFileEdit.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(Root, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem2, ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleLabelItem1, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmptySpaceItem1, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmptySpaceItem2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem3, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem4, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem5, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem6, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem7, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem8, ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleSeparator1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem9, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem10, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem11, ComponentModel.ISupportInitialize).BeginInit()
        CType(LayoutControlItem12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WizardControl1
        ' 
        WizardControl1.Controls.Add(WelcomeWizardPage1)
        WizardControl1.Controls.Add(WizardPage1)
        WizardControl1.Controls.Add(CompletionWizardPage1)
        WizardControl1.Dock = DockStyle.Fill
        WizardControl1.Name = "WizardControl1"
        WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {WelcomeWizardPage1, WizardPage1, CompletionWizardPage1})
        WizardControl1.Size = New Size(677, 426)
        WizardControl1.Text = "Packwiz Initialization"
        ' 
        ' WelcomeWizardPage1
        ' 
        WelcomeWizardPage1.IntroductionText = "This wizard will walk you through the steps required to initialize Packwiz!"
        WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        WelcomeWizardPage1.Size = New Size(460, 271)
        WelcomeWizardPage1.Text = "Welcome to the Packwiz Initialization Wizard!"
        ' 
        ' WizardPage1
        ' 
        WizardPage1.Controls.Add(LayoutControl1)
        WizardPage1.Name = "WizardPage1"
        WizardPage1.Size = New Size(645, 283)
        WizardPage1.Text = "First Steps"
        ' 
        ' LayoutControl1
        ' 
        LayoutControl1.Controls.Add(Author)
        LayoutControl1.Controls.Add(ModpackName)
        LayoutControl1.Controls.Add(ModpackVersion)
        LayoutControl1.Controls.Add(MinecraftVersion)
        LayoutControl1.Controls.Add(UseLatestMinecraftVer)
        LayoutControl1.Controls.Add(ModLoader)
        LayoutControl1.Controls.Add(ModLoaderVersion)
        LayoutControl1.Controls.Add(UseLatestModLoaderVersion)
        LayoutControl1.Controls.Add(ProjectDirectoryFileEdit)
        LayoutControl1.Controls.Add(PackwizFileEdit)
        LayoutControl1.Controls.Add(OpenProjectDirectoryBtn)
        LayoutControl1.Controls.Add(OpenPackwizFileBtn)
        LayoutControl1.Dock = DockStyle.Fill
        LayoutControl1.Location = New Point(0, 0)
        LayoutControl1.Name = "LayoutControl1"
        LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New Rectangle(955, 180, 650, 400)
        LayoutControl1.Root = Root
        LayoutControl1.Size = New Size(645, 283)
        LayoutControl1.TabIndex = 0
        LayoutControl1.Text = "LayoutControl1"
        ' 
        ' Author
        ' 
        Author.Location = New Point(133, 35)
        Author.Name = "Author"
        Author.Size = New Size(479, 28)
        Author.StyleController = LayoutControl1
        Author.TabIndex = 0
        ' 
        ' ModpackName
        ' 
        ModpackName.Location = New Point(133, 69)
        ModpackName.Name = "ModpackName"
        ModpackName.Size = New Size(479, 28)
        ModpackName.StyleController = LayoutControl1
        ModpackName.TabIndex = 2
        ' 
        ' ModpackVersion
        ' 
        ModpackVersion.Location = New Point(133, 103)
        ModpackVersion.Name = "ModpackVersion"
        ModpackVersion.Size = New Size(479, 28)
        ModpackVersion.StyleController = LayoutControl1
        ModpackVersion.TabIndex = 3
        ' 
        ' MinecraftVersion
        ' 
        MinecraftVersion.Location = New Point(133, 137)
        MinecraftVersion.Name = "MinecraftVersion"
        MinecraftVersion.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        MinecraftVersion.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        MinecraftVersion.Properties.MaskSettings.Set("mask", "[0-9]\.[0-9]{1,2}\.[0-9]")
        MinecraftVersion.Size = New Size(178, 28)
        MinecraftVersion.StyleController = LayoutControl1
        MinecraftVersion.TabIndex = 4
        ' 
        ' UseLatestMinecraftVer
        ' 
        UseLatestMinecraftVer.Location = New Point(317, 137)
        UseLatestMinecraftVer.Name = "UseLatestMinecraftVer"
        UseLatestMinecraftVer.Properties.Caption = "Use Latest"
        UseLatestMinecraftVer.Size = New Size(295, 22)
        UseLatestMinecraftVer.StyleController = LayoutControl1
        UseLatestMinecraftVer.TabIndex = 5
        ' 
        ' ModLoader
        ' 
        ModLoader.Location = New Point(133, 171)
        ModLoader.Name = "ModLoader"
        ModLoader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        ModLoader.Properties.Items.AddRange(New Object() {"fabric", "forge", "liteloader", "neoforge", "quilt"})
        ModLoader.Properties.Sorted = True
        ModLoader.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        ModLoader.Size = New Size(479, 28)
        ModLoader.StyleController = LayoutControl1
        ModLoader.TabIndex = 6
        ' 
        ' ModLoaderVersion
        ' 
        ModLoaderVersion.Location = New Point(133, 205)
        ModLoaderVersion.Name = "ModLoaderVersion"
        ModLoaderVersion.Size = New Size(178, 28)
        ModLoaderVersion.StyleController = LayoutControl1
        ModLoaderVersion.TabIndex = 7
        ' 
        ' UseLatestModLoaderVersion
        ' 
        UseLatestModLoaderVersion.Location = New Point(317, 205)
        UseLatestModLoaderVersion.Name = "UseLatestModLoaderVersion"
        UseLatestModLoaderVersion.Properties.Caption = "Use Latest"
        UseLatestModLoaderVersion.Size = New Size(295, 22)
        UseLatestModLoaderVersion.StyleController = LayoutControl1
        UseLatestModLoaderVersion.TabIndex = 8
        ' 
        ' ProjectDirectoryFileEdit
        ' 
        ProjectDirectoryFileEdit.Location = New Point(133, 239)
        ProjectDirectoryFileEdit.Name = "ProjectDirectoryFileEdit"
        ProjectDirectoryFileEdit.Size = New Size(433, 28)
        ProjectDirectoryFileEdit.StyleController = LayoutControl1
        ProjectDirectoryFileEdit.TabIndex = 9
        ' 
        ' PackwizFileEdit
        ' 
        PackwizFileEdit.Location = New Point(133, 283)
        PackwizFileEdit.Name = "PackwizFileEdit"
        PackwizFileEdit.Size = New Size(433, 28)
        PackwizFileEdit.StyleController = LayoutControl1
        PackwizFileEdit.TabIndex = 10
        ' 
        ' OpenProjectDirectoryBtn
        ' 
        OpenProjectDirectoryBtn.ImageOptions.SvgImage = CType(resources.GetObject("OpenProjectDirectoryBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        OpenProjectDirectoryBtn.Location = New Point(572, 239)
        OpenProjectDirectoryBtn.Name = "OpenProjectDirectoryBtn"
        OpenProjectDirectoryBtn.Size = New Size(40, 38)
        OpenProjectDirectoryBtn.StyleController = LayoutControl1
        OpenProjectDirectoryBtn.TabIndex = 11
        ' 
        ' OpenPackwizFileBtn
        ' 
        OpenPackwizFileBtn.ImageOptions.SvgImage = CType(resources.GetObject("OpenPackwizFileBtn.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        OpenPackwizFileBtn.Location = New Point(572, 283)
        OpenPackwizFileBtn.Name = "OpenPackwizFileBtn"
        OpenPackwizFileBtn.Size = New Size(40, 38)
        OpenPackwizFileBtn.StyleController = LayoutControl1
        OpenPackwizFileBtn.TabIndex = 12
        ' 
        ' Root
        ' 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
        Root.GroupBordersVisible = False
        Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {LayoutControlItem1, LayoutControlItem2, SimpleLabelItem1, EmptySpaceItem1, EmptySpaceItem2, LayoutControlItem3, LayoutControlItem4, LayoutControlItem5, LayoutControlItem6, LayoutControlItem7, LayoutControlItem8, SimpleSeparator1, LayoutControlItem9, LayoutControlItem10, LayoutControlItem11, LayoutControlItem12})
        Root.Name = "Root"
        Root.Size = New Size(628, 338)
        Root.TextVisible = False
        ' 
        ' LayoutControlItem1
        ' 
        LayoutControlItem1.Control = Author
        LayoutControlItem1.Location = New Point(0, 19)
        LayoutControlItem1.Name = "LayoutControlItem1"
        LayoutControlItem1.Size = New Size(602, 34)
        LayoutControlItem1.Text = "Author"
        LayoutControlItem1.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem2
        ' 
        LayoutControlItem2.Control = ModpackName
        LayoutControlItem2.Location = New Point(0, 53)
        LayoutControlItem2.Name = "LayoutControlItem2"
        LayoutControlItem2.Size = New Size(602, 34)
        LayoutControlItem2.Text = "Modpack Name"
        LayoutControlItem2.TextSize = New Size(101, 13)
        ' 
        ' SimpleLabelItem1
        ' 
        SimpleLabelItem1.AllowHotTrack = False
        SimpleLabelItem1.Location = New Point(201, 0)
        SimpleLabelItem1.Name = "SimpleLabelItem1"
        SimpleLabelItem1.Size = New Size(200, 19)
        SimpleLabelItem1.Text = "Modpack Information"
        SimpleLabelItem1.TextSize = New Size(101, 13)
        ' 
        ' EmptySpaceItem1
        ' 
        EmptySpaceItem1.AllowHotTrack = False
        EmptySpaceItem1.Location = New Point(0, 0)
        EmptySpaceItem1.Name = "EmptySpaceItem1"
        EmptySpaceItem1.Size = New Size(201, 19)
        EmptySpaceItem1.TextSize = New Size(0, 0)
        ' 
        ' EmptySpaceItem2
        ' 
        EmptySpaceItem2.AllowHotTrack = False
        EmptySpaceItem2.Location = New Point(401, 0)
        EmptySpaceItem2.Name = "EmptySpaceItem2"
        EmptySpaceItem2.Size = New Size(201, 19)
        EmptySpaceItem2.TextSize = New Size(0, 0)
        ' 
        ' LayoutControlItem3
        ' 
        LayoutControlItem3.Control = ModpackVersion
        LayoutControlItem3.Location = New Point(0, 87)
        LayoutControlItem3.Name = "LayoutControlItem3"
        LayoutControlItem3.Size = New Size(602, 34)
        LayoutControlItem3.Text = "Modpack Version"
        LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        LayoutControlItem3.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem4
        ' 
        LayoutControlItem4.Control = MinecraftVersion
        LayoutControlItem4.Location = New Point(0, 121)
        LayoutControlItem4.Name = "LayoutControlItem4"
        LayoutControlItem4.Size = New Size(301, 34)
        LayoutControlItem4.Text = "Minecraft Version"
        LayoutControlItem4.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem5
        ' 
        LayoutControlItem5.Control = UseLatestMinecraftVer
        LayoutControlItem5.Location = New Point(301, 121)
        LayoutControlItem5.Name = "LayoutControlItem5"
        LayoutControlItem5.Size = New Size(301, 34)
        LayoutControlItem5.TextSize = New Size(0, 0)
        LayoutControlItem5.TextVisible = False
        ' 
        ' LayoutControlItem6
        ' 
        LayoutControlItem6.Control = ModLoader
        LayoutControlItem6.Location = New Point(0, 155)
        LayoutControlItem6.Name = "LayoutControlItem6"
        LayoutControlItem6.Size = New Size(602, 34)
        LayoutControlItem6.Text = "Mod Loader"
        LayoutControlItem6.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem7
        ' 
        LayoutControlItem7.Control = ModLoaderVersion
        LayoutControlItem7.Location = New Point(0, 189)
        LayoutControlItem7.Name = "LayoutControlItem7"
        LayoutControlItem7.Size = New Size(301, 34)
        LayoutControlItem7.Text = "Mod Loader Version"
        LayoutControlItem7.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem8
        ' 
        LayoutControlItem8.Control = UseLatestModLoaderVersion
        LayoutControlItem8.Location = New Point(301, 189)
        LayoutControlItem8.Name = "LayoutControlItem8"
        LayoutControlItem8.Size = New Size(301, 34)
        LayoutControlItem8.TextSize = New Size(0, 0)
        LayoutControlItem8.TextVisible = False
        ' 
        ' SimpleSeparator1
        ' 
        SimpleSeparator1.AllowHotTrack = False
        SimpleSeparator1.Location = New Point(0, 311)
        SimpleSeparator1.Name = "SimpleSeparator1"
        SimpleSeparator1.Size = New Size(602, 1)
        ' 
        ' LayoutControlItem9
        ' 
        LayoutControlItem9.Control = ProjectDirectoryFileEdit
        LayoutControlItem9.Location = New Point(0, 223)
        LayoutControlItem9.Name = "LayoutControlItem9"
        LayoutControlItem9.Size = New Size(556, 44)
        LayoutControlItem9.Text = "Project Directory"
        LayoutControlItem9.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem10
        ' 
        LayoutControlItem10.Control = PackwizFileEdit
        LayoutControlItem10.Location = New Point(0, 267)
        LayoutControlItem10.Name = "LayoutControlItem10"
        LayoutControlItem10.Size = New Size(556, 44)
        LayoutControlItem10.Text = "Packwiz File"
        LayoutControlItem10.TextSize = New Size(101, 13)
        ' 
        ' LayoutControlItem11
        ' 
        LayoutControlItem11.Control = OpenProjectDirectoryBtn
        LayoutControlItem11.Location = New Point(556, 223)
        LayoutControlItem11.Name = "LayoutControlItem11"
        LayoutControlItem11.Size = New Size(46, 44)
        LayoutControlItem11.TextSize = New Size(0, 0)
        LayoutControlItem11.TextVisible = False
        ' 
        ' LayoutControlItem12
        ' 
        LayoutControlItem12.Control = OpenPackwizFileBtn
        LayoutControlItem12.Location = New Point(556, 267)
        LayoutControlItem12.Name = "LayoutControlItem12"
        LayoutControlItem12.Size = New Size(46, 44)
        LayoutControlItem12.TextSize = New Size(0, 0)
        LayoutControlItem12.TextVisible = False
        ' 
        ' CompletionWizardPage1
        ' 
        CompletionWizardPage1.Name = "CompletionWizardPage1"
        CompletionWizardPage1.Size = New Size(460, 294)
        ' 
        ' XtraFolderBrowserDialog1
        ' 
        XtraFolderBrowserDialog1.Description = "Packwiz Project Directory"
        XtraFolderBrowserDialog1.Title = "Choose Project Directory"
        ' 
        ' XtraOpenFileDialog1
        ' 
        XtraOpenFileDialog1.DefaultExt = "exe"
        XtraOpenFileDialog1.Filter = "Executable Files (*.exe)|*.exe"
        XtraOpenFileDialog1.RestoreDirectory = True
        XtraOpenFileDialog1.Title = "Select Packwiz Executable"
        ' 
        ' InitializePackwizFrm
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 426)
        Controls.Add(WizardControl1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "InitializePackwizFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Initialize Packwiz"
        TopMost = True
        CType(WizardControl1, ComponentModel.ISupportInitialize).EndInit()
        WizardControl1.ResumeLayout(False)
        WizardPage1.ResumeLayout(False)
        CType(LayoutControl1, ComponentModel.ISupportInitialize).EndInit()
        LayoutControl1.ResumeLayout(False)
        CType(Author.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(ModpackName.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(ModpackVersion.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(MinecraftVersion.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(UseLatestMinecraftVer.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(ModLoader.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(ModLoaderVersion.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(UseLatestModLoaderVersion.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(ProjectDirectoryFileEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(PackwizFileEdit.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(Root, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem1, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem2, ComponentModel.ISupportInitialize).EndInit()
        CType(SimpleLabelItem1, ComponentModel.ISupportInitialize).EndInit()
        CType(EmptySpaceItem1, ComponentModel.ISupportInitialize).EndInit()
        CType(EmptySpaceItem2, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem3, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem4, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem5, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem6, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem7, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem8, ComponentModel.ISupportInitialize).EndInit()
        CType(SimpleSeparator1, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem9, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem10, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem11, ComponentModel.ISupportInitialize).EndInit()
        CType(LayoutControlItem12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Author As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModpackName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ModpackVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents MinecraftVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UseLatestMinecraftVer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ModLoader As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ModLoaderVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UseLatestModLoaderVersion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ProjectDirectoryFileEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PackwizFileEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OpenProjectDirectoryBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OpenPackwizFileBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraFolderBrowserDialog1 As DevExpress.XtraEditors.XtraFolderBrowserDialog
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog

End Class
