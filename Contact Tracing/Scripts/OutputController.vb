Imports Contact_Tracing.mainForm
Imports System.IO
Imports Contact_Tracing.InputsController

Module OutputController
    Public genderRadio = New RadioButton() {mainForm.genderMale, mainForm.genderFemale}
    Public travelledRadio = New RadioButton() {mainForm.travelledYes, mainForm.travelledNo}
    Public contactRadio = New RadioButton() {mainForm.contactYes, mainForm.contactNo}
    Public checkboxes = New CheckBox() _
        {mainForm.sicknessBreath, mainForm.sicknessCold, mainForm.sicknessFever}
    Public Sub FormToText()
        Dim form As StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter("SubmittedForms.txt", True)
        form.WriteLine($"Date & Time Submitted: {DateTime.Now.ToString()}")
        form.WriteLine($"Name: {mainForm.nameInput.Text}")
        form.WriteLine($"Address: {mainForm.addressInput.Text}")
        form.WriteLine($"Age: {mainForm.ageInput.Text}")
        For Each gender As RadioButton In genderRadio
            If gender.Checked Then
                form.WriteLine($"Gender: {gender.Text}")
            End If
        Next
        For Each travelled As RadioButton In travelledRadio
            If travelled.Checked Then
                form.WriteLine($"Travelled: {travelled.Text}")
            End If
        Next
        For Each contact As RadioButton In contactRadio
            If contact.Checked Then
                form.WriteLine($"Have Contact: {contact.Text}")
            End If
        Next
        form.Write("Sickness:")
        For Each check As CheckBox In checkboxes
            If check.Checked Then
                form.Write($" {check.Text};")
            End If
        Next
        form.WriteLine()
        form.WriteLine($"Phone Number: {mainForm.numberInput.Text}")
        form.WriteLine($"Email Address: {mainForm.emailInput.Text}")
        form.WriteLine($"{vbCrLf}")
        form.Close()
        ResetInputs()
    End Sub
End Module
