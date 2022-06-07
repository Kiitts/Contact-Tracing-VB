<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.addressInput = New System.Windows.Forms.TextBox()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.ageInput = New System.Windows.Forms.TextBox()
        Me.genderInput = New System.Windows.Forms.GroupBox()
        Me.genderFemale = New System.Windows.Forms.RadioButton()
        Me.genderMale = New System.Windows.Forms.RadioButton()
        Me.travelledInput = New System.Windows.Forms.GroupBox()
        Me.travelledNo = New System.Windows.Forms.RadioButton()
        Me.travelledYes = New System.Windows.Forms.RadioButton()
        Me.contactInput = New System.Windows.Forms.GroupBox()
        Me.contactNo = New System.Windows.Forms.RadioButton()
        Me.contactYes = New System.Windows.Forms.RadioButton()
        Me.sicknessInput = New System.Windows.Forms.GroupBox()
        Me.sicknessBreath = New System.Windows.Forms.CheckBox()
        Me.sicknessCold = New System.Windows.Forms.CheckBox()
        Me.sicknessFever = New System.Windows.Forms.CheckBox()
        Me.numberInput = New System.Windows.Forms.TextBox()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.emailInput = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.genderInput.SuspendLayout()
        Me.travelledInput.SuspendLayout()
        Me.contactInput.SuspendLayout()
        Me.sicknessInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.Location = New System.Drawing.Point(12, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(53, 17)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name:"
        '
        'nameInput
        '
        Me.nameInput.Location = New System.Drawing.Point(102, 6)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.PlaceholderText = "Juan G. Bonifacio"
        Me.nameInput.Size = New System.Drawing.Size(356, 23)
        Me.nameInput.TabIndex = 1
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.addressLabel.Location = New System.Drawing.Point(12, 39)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(80, 17)
        Me.addressLabel.TabIndex = 2
        Me.addressLabel.Text = "Address:"
        '
        'addressInput
        '
        Me.addressInput.Location = New System.Drawing.Point(102, 36)
        Me.addressInput.Name = "addressInput"
        Me.addressInput.PlaceholderText = "[Bldg#/House#] [Street] [Brgy]"
        Me.addressInput.Size = New System.Drawing.Size(356, 23)
        Me.addressInput.TabIndex = 3
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ageLabel.Location = New System.Drawing.Point(12, 69)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(44, 17)
        Me.ageLabel.TabIndex = 4
        Me.ageLabel.Text = "Age:"
        '
        'ageInput
        '
        Me.ageInput.Location = New System.Drawing.Point(102, 66)
        Me.ageInput.Name = "ageInput"
        Me.ageInput.PlaceholderText = "22"
        Me.ageInput.Size = New System.Drawing.Size(356, 23)
        Me.ageInput.TabIndex = 5
        '
        'genderInput
        '
        Me.genderInput.Controls.Add(Me.genderFemale)
        Me.genderInput.Controls.Add(Me.genderMale)
        Me.genderInput.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.genderInput.Location = New System.Drawing.Point(13, 99)
        Me.genderInput.Name = "genderInput"
        Me.genderInput.Size = New System.Drawing.Size(97, 81)
        Me.genderInput.TabIndex = 6
        Me.genderInput.TabStop = False
        Me.genderInput.Text = "Gender:"
        '
        'genderFemale
        '
        Me.genderFemale.AutoSize = True
        Me.genderFemale.Location = New System.Drawing.Point(6, 53)
        Me.genderFemale.Name = "genderFemale"
        Me.genderFemale.Size = New System.Drawing.Size(80, 21)
        Me.genderFemale.TabIndex = 1
        Me.genderFemale.TabStop = True
        Me.genderFemale.Text = "Female"
        Me.genderFemale.UseVisualStyleBackColor = True
        '
        'genderMale
        '
        Me.genderMale.AutoSize = True
        Me.genderMale.Location = New System.Drawing.Point(6, 25)
        Me.genderMale.Name = "genderMale"
        Me.genderMale.Size = New System.Drawing.Size(62, 21)
        Me.genderMale.TabIndex = 0
        Me.genderMale.TabStop = True
        Me.genderMale.Text = "Male"
        Me.genderMale.UseVisualStyleBackColor = True
        '
        'travelledInput
        '
        Me.travelledInput.Controls.Add(Me.travelledNo)
        Me.travelledInput.Controls.Add(Me.travelledYes)
        Me.travelledInput.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.travelledInput.Location = New System.Drawing.Point(13, 186)
        Me.travelledInput.Name = "travelledInput"
        Me.travelledInput.Size = New System.Drawing.Size(445, 96)
        Me.travelledInput.TabIndex = 7
        Me.travelledInput.TabStop = False
        Me.travelledInput.Text = "Have you traveled outside the country anytime from the last 2 months?"
        '
        'travelledNo
        '
        Me.travelledNo.AutoSize = True
        Me.travelledNo.Location = New System.Drawing.Point(6, 69)
        Me.travelledNo.Name = "travelledNo"
        Me.travelledNo.Size = New System.Drawing.Size(44, 21)
        Me.travelledNo.TabIndex = 1
        Me.travelledNo.TabStop = True
        Me.travelledNo.Text = "No"
        Me.travelledNo.UseVisualStyleBackColor = True
        '
        'travelledYes
        '
        Me.travelledYes.AutoSize = True
        Me.travelledYes.Location = New System.Drawing.Point(6, 42)
        Me.travelledYes.Name = "travelledYes"
        Me.travelledYes.Size = New System.Drawing.Size(53, 21)
        Me.travelledYes.TabIndex = 0
        Me.travelledYes.TabStop = True
        Me.travelledYes.Text = "Yes"
        Me.travelledYes.UseVisualStyleBackColor = True
        '
        'contactInput
        '
        Me.contactInput.Controls.Add(Me.contactNo)
        Me.contactInput.Controls.Add(Me.contactYes)
        Me.contactInput.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.contactInput.Location = New System.Drawing.Point(13, 288)
        Me.contactInput.Name = "contactInput"
        Me.contactInput.Size = New System.Drawing.Size(445, 110)
        Me.contactInput.TabIndex = 8
        Me.contactInput.TabStop = False
        Me.contactInput.Text = "Have you come into contact with anyone who has been positive for COVID-19 this la" &
    "st 2 months?"
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Location = New System.Drawing.Point(6, 83)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(44, 21)
        Me.contactNo.TabIndex = 1
        Me.contactNo.TabStop = True
        Me.contactNo.Text = "No"
        Me.contactNo.UseVisualStyleBackColor = True
        '
        'contactYes
        '
        Me.contactYes.AutoSize = True
        Me.contactYes.Location = New System.Drawing.Point(6, 56)
        Me.contactYes.Name = "contactYes"
        Me.contactYes.Size = New System.Drawing.Size(53, 21)
        Me.contactYes.TabIndex = 0
        Me.contactYes.TabStop = True
        Me.contactYes.Text = "Yes"
        Me.contactYes.UseVisualStyleBackColor = True
        '
        'sicknessInput
        '
        Me.sicknessInput.Controls.Add(Me.sicknessBreath)
        Me.sicknessInput.Controls.Add(Me.sicknessCold)
        Me.sicknessInput.Controls.Add(Me.sicknessFever)
        Me.sicknessInput.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sicknessInput.Location = New System.Drawing.Point(13, 404)
        Me.sicknessInput.Name = "sicknessInput"
        Me.sicknessInput.Size = New System.Drawing.Size(445, 137)
        Me.sicknessInput.TabIndex = 9
        Me.sicknessInput.TabStop = False
        Me.sicknessInput.Text = "Do you currently have any of the following conditions during this time? (Check al" &
    "l that apply):"
        '
        'sicknessBreath
        '
        Me.sicknessBreath.AutoSize = True
        Me.sicknessBreath.Location = New System.Drawing.Point(7, 112)
        Me.sicknessBreath.Name = "sicknessBreath"
        Me.sicknessBreath.Size = New System.Drawing.Size(207, 21)
        Me.sicknessBreath.TabIndex = 2
        Me.sicknessBreath.Text = "Breathing Difficulty"
        Me.sicknessBreath.UseVisualStyleBackColor = True
        '
        'sicknessCold
        '
        Me.sicknessCold.AutoSize = True
        Me.sicknessCold.Location = New System.Drawing.Point(7, 85)
        Me.sicknessCold.Name = "sicknessCold"
        Me.sicknessCold.Size = New System.Drawing.Size(63, 21)
        Me.sicknessCold.TabIndex = 1
        Me.sicknessCold.Text = "Cold"
        Me.sicknessCold.UseVisualStyleBackColor = True
        '
        'sicknessFever
        '
        Me.sicknessFever.AutoSize = True
        Me.sicknessFever.Location = New System.Drawing.Point(7, 58)
        Me.sicknessFever.Name = "sicknessFever"
        Me.sicknessFever.Size = New System.Drawing.Size(72, 21)
        Me.sicknessFever.TabIndex = 0
        Me.sicknessFever.Text = "Fever"
        Me.sicknessFever.UseVisualStyleBackColor = True
        '
        'numberInput
        '
        Me.numberInput.Location = New System.Drawing.Point(143, 547)
        Me.numberInput.Name = "numberInput"
        Me.numberInput.Size = New System.Drawing.Size(315, 23)
        Me.numberInput.TabIndex = 11
        '
        'numberLabel
        '
        Me.numberLabel.AutoSize = True
        Me.numberLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.numberLabel.Location = New System.Drawing.Point(12, 550)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(125, 17)
        Me.numberLabel.TabIndex = 10
        Me.numberLabel.Text = "Phone Number:"
        '
        'emailInput
        '
        Me.emailInput.Location = New System.Drawing.Point(143, 577)
        Me.emailInput.Name = "emailInput"
        Me.emailInput.PlaceholderText = "Optional"
        Me.emailInput.Size = New System.Drawing.Size(315, 23)
        Me.emailInput.TabIndex = 13
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.emailLabel.Location = New System.Drawing.Point(12, 580)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(134, 17)
        Me.emailLabel.TabIndex = 12
        Me.emailLabel.Text = "Email Address:"
        '
        'submitButton
        '
        Me.submitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.submitButton.ForeColor = System.Drawing.Color.White
        Me.submitButton.Location = New System.Drawing.Point(313, 641)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(145, 41)
        Me.submitButton.TabIndex = 14
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = False
        '
        'resetButton
        '
        Me.resetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.resetButton.ForeColor = System.Drawing.Color.White
        Me.resetButton.Location = New System.Drawing.Point(12, 656)
        Me.resetButton.Margin = New System.Windows.Forms.Padding(0)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(69, 26)
        Me.resetButton.TabIndex = 15
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = False
        '
        'messageLabel
        '
        Me.messageLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.messageLabel.ForeColor = System.Drawing.Color.Red
        Me.messageLabel.Location = New System.Drawing.Point(13, 603)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(445, 35)
        Me.messageLabel.TabIndex = 16
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(468, 698)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.emailInput)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.numberInput)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.sicknessInput)
        Me.Controls.Add(Me.contactInput)
        Me.Controls.Add(Me.travelledInput)
        Me.Controls.Add(Me.genderInput)
        Me.Controls.Add(Me.ageInput)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.addressInput)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.Text = "mainForm"
        Me.genderInput.ResumeLayout(False)
        Me.genderInput.PerformLayout()
        Me.travelledInput.ResumeLayout(False)
        Me.travelledInput.PerformLayout()
        Me.contactInput.ResumeLayout(False)
        Me.contactInput.PerformLayout()
        Me.sicknessInput.ResumeLayout(False)
        Me.sicknessInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents addressInput As TextBox
    Friend WithEvents ageLabel As Label
    Friend WithEvents ageInput As TextBox
    Friend WithEvents genderInput As GroupBox
    Friend WithEvents genderFemale As RadioButton
    Friend WithEvents genderMale As RadioButton
    Friend WithEvents travelledInput As GroupBox
    Friend WithEvents travelledNo As RadioButton
    Friend WithEvents travelledYes As RadioButton
    Friend WithEvents contactInput As GroupBox
    Friend WithEvents contactNo As RadioButton
    Friend WithEvents contactYes As RadioButton
    Friend WithEvents sicknessInput As GroupBox
    Friend WithEvents sicknessBreath As CheckBox
    Friend WithEvents sicknessCold As CheckBox
    Friend WithEvents sicknessFever As CheckBox
    Friend WithEvents numberInput As TextBox
    Friend WithEvents numberLabel As Label
    Friend WithEvents emailInput As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents messageLabel As Label
End Class
