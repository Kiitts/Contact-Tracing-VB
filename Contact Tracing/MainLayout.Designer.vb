<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainLayout
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
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.formButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.titlePanel.SuspendLayout()
        Me.controlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(0, 0)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(629, 30)
        Me.titlePanel.TabIndex = 0
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titleLabel.Location = New System.Drawing.Point(181, 4)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(230, 21)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Contact Tracing Form"
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.controlPanel.Controls.Add(Me.formButton)
        Me.controlPanel.Controls.Add(Me.exitButton)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.controlPanel.Location = New System.Drawing.Point(0, 30)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(147, 514)
        Me.controlPanel.TabIndex = 1
        '
        'formButton
        '
        Me.formButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.formButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.formButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.formButton.ForeColor = System.Drawing.Color.White
        Me.formButton.Location = New System.Drawing.Point(6, 22)
        Me.formButton.Margin = New System.Windows.Forms.Padding(0)
        Me.formButton.Name = "formButton"
        Me.formButton.Size = New System.Drawing.Size(138, 37)
        Me.formButton.TabIndex = 1
        Me.formButton.Text = "Form"
        Me.formButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exitButton.ForeColor = System.Drawing.Color.White
        Me.exitButton.Location = New System.Drawing.Point(6, 465)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(138, 37)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "EXIT"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'mainPanel
        '
        Me.mainPanel.AutoScroll = True
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(147, 30)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(482, 514)
        Me.mainPanel.TabIndex = 2
        '
        'MainLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.titlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(631, 546)
        Me.MinimumSize = New System.Drawing.Size(631, 546)
        Me.Name = "MainLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        Me.controlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents controlPanel As Panel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents exitButton As Button
    Friend WithEvents formButton As Button
End Class
