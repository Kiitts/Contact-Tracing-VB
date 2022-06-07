Imports Contact_Tracing.mainForm

Module InputsController
    Public radios = New RadioButton() _
        {mainForm.genderMale, mainForm.genderFemale,
        mainForm.travelledYes, mainForm.travelledNo, mainForm.contactYes,
        mainForm.contactNo}
    Public checkboxes = New CheckBox() _
        {mainForm.sicknessBreath, mainForm.sicknessCold, mainForm.sicknessFever}
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

    Public Function CheckForInputs() As String
        If (mainForm.nameInput.Text = "") Then
            Return "Name"
        End If
        If (mainForm.addressInput.Text = "") Then
            Return "Address"
        End If
        If (mainForm.ageInput.Text = "") Then
            Return "Age"
        End If
        If (Not mainForm.genderMale.Checked And
            Not mainForm.genderFemale.Checked) Then
            Return "Gender"
        End If
        If (Not mainForm.travelledYes.Checked And
            Not mainForm.travelledNo.Checked) Then
            Return "if you have travelled"
        End If
        If (Not mainForm.contactYes.Checked And
            Not mainForm.contactNo.Checked) Then
            Return "if you have contacted a covid patient"
        End If
        If (mainForm.numberInput.Text = "") Then
            Return "Phone Number"
        End If
        Return Nothing
    End Function

    Public Sub ResetInputs()
        mainForm.nameInput.Text = ""
        mainForm.addressInput.Text = ""
        mainForm.ageInput.Text = ""
        For Each radio As RadioButton In radios
            radio.Checked = False
        Next
        For Each checkBox As CheckBox In checkboxes
            checkBox.Checked = False
        Next
        mainForm.numberInput.Text = ""
        mainForm.emailInput.Text = ""
        mainForm.messageLabel.Text = ""
    End Sub
End Module
