<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadScreen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadScreen))
        peImage = New DevExpress.XtraEditors.PictureEdit()
        peLogo = New DevExpress.XtraEditors.PictureEdit()
        labelStatus = New DevExpress.XtraEditors.LabelControl()
        labelCopyright = New DevExpress.XtraEditors.LabelControl()
        progressBarControl = New DevExpress.XtraEditors.ProgressBarControl()
        mProgressBarControl = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        CType(peImage.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(peLogo.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(progressBarControl.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(mProgressBarControl.Properties, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' peImage
        ' 
        peImage.Dock = DockStyle.Top
        peImage.EditValue = resources.GetObject("peImage.EditValue")
        peImage.Location = New Point(1, 1)
        peImage.Margin = New Padding(4)
        peImage.Name = "peImage"
        peImage.Properties.AllowFocused = False
        peImage.Properties.Appearance.BackColor = Color.Transparent
        peImage.Properties.Appearance.Options.UseBackColor = True
        peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        peImage.Properties.ShowMenu = False
        peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        peImage.Size = New Size(523, 246)
        peImage.TabIndex = 14
        ' 
        ' peLogo
        ' 
        peLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        peLogo.EditValue = resources.GetObject("peLogo.EditValue")
        peLogo.Location = New Point(326, 329)
        peLogo.Margin = New Padding(4)
        peLogo.Name = "peLogo"
        peLogo.Properties.AllowFocused = False
        peLogo.Properties.Appearance.BackColor = Color.Transparent
        peLogo.Properties.Appearance.Options.UseBackColor = True
        peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        peLogo.Properties.ShowMenu = False
        peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        peLogo.Size = New Size(184, 59)
        peLogo.TabIndex = 13
        ' 
        ' labelStatus
        ' 
        labelStatus.Location = New Point(28, 265)
        labelStatus.Margin = New Padding(4, 4, 4, 1)
        labelStatus.Name = "labelStatus"
        labelStatus.Size = New Size(57, 16)
        labelStatus.TabIndex = 12
        labelStatus.Text = "Starting..."
        ' 
        ' labelCopyright
        ' 
        labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        labelCopyright.Location = New Point(28, 353)
        labelCopyright.Margin = New Padding(4)
        labelCopyright.Name = "labelCopyright"
        labelCopyright.Size = New Size(54, 16)
        labelCopyright.TabIndex = 11
        labelCopyright.Text = "Copyright"
        ' 
        ' progressBarControl
        ' 
        progressBarControl.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        progressBarControl.Location = New Point(28, 286)
        progressBarControl.Margin = New Padding(4)
        progressBarControl.Name = "progressBarControl"
        progressBarControl.Properties.ShowTitle = True
        progressBarControl.Properties.Step = 1
        progressBarControl.Size = New Size(469, 15)
        progressBarControl.TabIndex = 10
        progressBarControl.Visible = False
        ' 
        ' mProgressBarControl
        ' 
        mProgressBarControl.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        mProgressBarControl.EditValue = ""
        mProgressBarControl.Location = New Point(28, 286)
        mProgressBarControl.Margin = New Padding(4)
        mProgressBarControl.Name = "mProgressBarControl"
        mProgressBarControl.Properties.ShowTitle = True
        mProgressBarControl.Size = New Size(469, 15)
        mProgressBarControl.TabIndex = 15
        ' 
        ' LoadScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(525, 394)
        Controls.Add(peImage)
        Controls.Add(peLogo)
        Controls.Add(labelStatus)
        Controls.Add(labelCopyright)
        Controls.Add(progressBarControl)
        Controls.Add(mProgressBarControl)
        Margin = New Padding(4)
        Name = "LoadScreen"
        Padding = New Padding(1)
        Text = "LoadScreen"
        TopMost = True
        CType(peImage.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(peLogo.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(progressBarControl.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(mProgressBarControl.Properties, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents peImage As DevExpress.XtraEditors.PictureEdit
    Private WithEvents peLogo As DevExpress.XtraEditors.PictureEdit
    Private WithEvents labelStatus As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelCopyright As DevExpress.XtraEditors.LabelControl
    Friend WithEvents progressBarControl As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents mProgressBarControl As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class
