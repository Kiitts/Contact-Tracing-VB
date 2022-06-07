Imports Contact_Tracing.MainLayoutController
Public Class MainLayout
    Private Sub MainLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainLayoutController.loadForm(mainForm, Me)
    End Sub
End Class