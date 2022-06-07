Imports Contact_Tracing.InputsController
Imports Contact_Tracing.OutputController


Public Class mainForm
    Private Sub OnPressed(sender As Object, e As KeyPressEventArgs) Handles ageInput.KeyPress, numberInput.KeyPress
        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        If (txtBox.Name = "ageInput") Then
            ' If the event sender is ageInput validate input with validation length of only 2
            InputsController.ValidateDigitInput(txtBox, 2, e)
        Else
            ' Else if numberInput validate input with validation length of 11
            InputsController.ValidateDigitInput(txtBox, 11, e)
        End If
    End Sub


    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' Check for failed input or validation or required input first
        ' before submitting or creating text file
        Dim failedInput As String = CheckForInputs()
        If failedInput IsNot Nothing Then
            messageLabel.Text = $"Please input/select properly your {failedInput}."
            Exit Sub
        End If
        FormToText()
        messageLabel.Text = "Your form has been submitted."
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        ResetInputs()
    End Sub
End Class