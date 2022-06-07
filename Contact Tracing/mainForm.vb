Imports Contact_Tracing.InputsController

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
End Class