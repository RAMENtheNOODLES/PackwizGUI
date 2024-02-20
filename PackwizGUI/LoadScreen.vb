Public Class LoadScreen
    Sub New()
        InitializeComponent()
        Me.labelCopyright.Text = "Copyright © 2024-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Public Sub UseProgressBar()
        progressBarControl.Visible = True
        mProgressBarControl.Visible = False
        labelStatus.Text = "Loading..."
    End Sub
End Class
