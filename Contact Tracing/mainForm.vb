Public Class mainForm

    ''' <summary>
    ''' Validate the digit input check if the key pressed is allowed
    ''' and only handle the input if it isn't allowed
    ''' </summary>
    ''' <param name="length">This is the length of the digit allowed</param>
    ''' <param name="input">This is the TextBox object you'll validate</param>
    Private Sub ValidateDigitInput(input As TextBox, length As Integer, e As KeyPressEventArgs)
        If (Not (e.KeyChar = ControlChars.Back Or
            (Char.IsDigit(e.KeyChar) And input.TextLength < length))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub OnPressed(sender As Object, e As KeyPressEventArgs) Handles ageInput.KeyPress, numberInput.KeyPress
        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        ' If the event sender is ageInput validate input with validation length of only 2
        If (txtBox.Name = "ageInput") Then
            ValidateDigitInput(txtBox, 2, e)
            ' Else if numberInput validate input with validation length of 11
        Else
            ValidateDigitInput(txtBox, 11, e)
        End If
    End Sub
End Class