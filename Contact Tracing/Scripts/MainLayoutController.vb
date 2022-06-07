Module MainLayoutController
    ''' <summary>
    ''' Load the form from the panel from the MainLayout form
    ''' </summary>
    ''' <param name="Form">The form we want to show in the panel</param>
    ''' <param name="originalForm">The form that has the panel</param>
    Public Sub loadForm(Form As Form, originalForm As MainLayout)
        If (originalForm.mainPanel.Controls.Count > 0) Then
            originalForm.mainPanel.Controls.RemoveAt(0)
        End If
        Dim f As Form = Form
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        originalForm.mainPanel.Controls.Add(f)
        originalForm.mainPanel.Tag = f
        f.Show()
    End Sub
End Module
