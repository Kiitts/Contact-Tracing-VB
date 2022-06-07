Imports Contact_Tracing.MainLayoutController
Public Class MainLayout
    Public Pos As Point ''' reference to the point of mouse
    ''' <summary>
    ''' load the mainForm in startup in the panel
    ''' </summary>
    Private Sub MainLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainLayoutController.loadForm(mainForm, Me)
    End Sub

    ''' <summary>
    ''' make the form movable by the mouse by dragging and release the top bar/title bar.
    ''' </summary>
    Private Sub titlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles titlePanel.MouseMove, titleLabel.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class