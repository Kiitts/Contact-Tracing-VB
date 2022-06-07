Module InputsController
    ''' <summary>
    ''' Validate the digit input check if the key pressed is allowed
    ''' and only handle the input if it isn't allowed
    ''' </summary>
    ''' <param name="length">This is the length of the digit allowed</param>
    ''' <param name="input">This is the TextBox object you'll validate</param>
    Public Sub ValidateDigitInput(input As TextBox, length As Integer, e As KeyPressEventArgs)
        If (Not (e.KeyChar = ControlChars.Back Or
            (Char.IsDigit(e.KeyChar) And input.TextLength < length))) Then
            e.Handled = True
        End If
    End Sub
End Module
