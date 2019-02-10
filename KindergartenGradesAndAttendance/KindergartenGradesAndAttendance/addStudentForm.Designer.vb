<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addButton = New System.Windows.Forms.Button()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.parentNameLabel = New System.Windows.Forms.Label()
        Me.parentNameTextBox = New System.Windows.Forms.TextBox()
        Me.allergyComboBox = New System.Windows.Forms.ComboBox()
        Me.otherAllergyTextBox = New System.Windows.Forms.TextBox()
        Me.allergyGroupBox = New System.Windows.Forms.GroupBox()
        Me.studentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.contactGroupBox = New System.Windows.Forms.GroupBox()
        Me.phoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.allergyGroupBox.SuspendLayout()
        Me.studentInfoGroupBox.SuspendLayout()
        Me.contactGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.Location = New System.Drawing.Point(101, 280)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(177, 64)
        Me.addButton.TabIndex = 5
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLabel.Location = New System.Drawing.Point(10, 28)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(94, 20)
        Me.lastNameLabel.TabIndex = 1
        Me.lastNameLabel.Text = "Last Name: "
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameLabel.Location = New System.Drawing.Point(10, 60)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(94, 20)
        Me.firstNameLabel.TabIndex = 2
        Me.firstNameLabel.Text = "First Name: "
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameTextBox.Location = New System.Drawing.Point(200, 25)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(154, 26)
        Me.lastNameTextBox.TabIndex = 0
        Me.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameTextBox.Location = New System.Drawing.Point(200, 57)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(154, 26)
        Me.firstNameTextBox.TabIndex = 1
        Me.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'parentNameLabel
        '
        Me.parentNameLabel.AutoSize = True
        Me.parentNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentNameLabel.Location = New System.Drawing.Point(10, 31)
        Me.parentNameLabel.Name = "parentNameLabel"
        Me.parentNameLabel.Size = New System.Drawing.Size(121, 20)
        Me.parentNameLabel.TabIndex = 5
        Me.parentNameLabel.Text = "Parent's Name: "
        '
        'parentNameTextBox
        '
        Me.parentNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentNameTextBox.Location = New System.Drawing.Point(200, 28)
        Me.parentNameTextBox.Name = "parentNameTextBox"
        Me.parentNameTextBox.Size = New System.Drawing.Size(154, 26)
        Me.parentNameTextBox.TabIndex = 2
        Me.parentNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'allergyComboBox
        '
        Me.allergyComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allergyComboBox.FormattingEnabled = True
        Me.allergyComboBox.Location = New System.Drawing.Point(6, 19)
        Me.allergyComboBox.Name = "allergyComboBox"
        Me.allergyComboBox.Size = New System.Drawing.Size(154, 28)
        Me.allergyComboBox.TabIndex = 4
        '
        'otherAllergyTextBox
        '
        Me.otherAllergyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherAllergyTextBox.Location = New System.Drawing.Point(200, 19)
        Me.otherAllergyTextBox.Name = "otherAllergyTextBox"
        Me.otherAllergyTextBox.ReadOnly = True
        Me.otherAllergyTextBox.Size = New System.Drawing.Size(154, 26)
        Me.otherAllergyTextBox.TabIndex = 4
        Me.otherAllergyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'allergyGroupBox
        '
        Me.allergyGroupBox.Controls.Add(Me.allergyComboBox)
        Me.allergyGroupBox.Controls.Add(Me.otherAllergyTextBox)
        Me.allergyGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allergyGroupBox.Location = New System.Drawing.Point(12, 221)
        Me.allergyGroupBox.Name = "allergyGroupBox"
        Me.allergyGroupBox.Size = New System.Drawing.Size(360, 53)
        Me.allergyGroupBox.TabIndex = 9
        Me.allergyGroupBox.TabStop = False
        Me.allergyGroupBox.Text = "Allergies"
        '
        'studentInfoGroupBox
        '
        Me.studentInfoGroupBox.Controls.Add(Me.lastNameTextBox)
        Me.studentInfoGroupBox.Controls.Add(Me.lastNameLabel)
        Me.studentInfoGroupBox.Controls.Add(Me.firstNameLabel)
        Me.studentInfoGroupBox.Controls.Add(Me.firstNameTextBox)
        Me.studentInfoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInfoGroupBox.Location = New System.Drawing.Point(12, 13)
        Me.studentInfoGroupBox.Name = "studentInfoGroupBox"
        Me.studentInfoGroupBox.Size = New System.Drawing.Size(360, 95)
        Me.studentInfoGroupBox.TabIndex = 10
        Me.studentInfoGroupBox.TabStop = False
        Me.studentInfoGroupBox.Text = "Student Information"
        '
        'contactGroupBox
        '
        Me.contactGroupBox.Controls.Add(Me.phoneNumberLabel)
        Me.contactGroupBox.Controls.Add(Me.phoneNumberTextBox)
        Me.contactGroupBox.Controls.Add(Me.parentNameLabel)
        Me.contactGroupBox.Controls.Add(Me.parentNameTextBox)
        Me.contactGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactGroupBox.Location = New System.Drawing.Point(12, 115)
        Me.contactGroupBox.Name = "contactGroupBox"
        Me.contactGroupBox.Size = New System.Drawing.Size(360, 100)
        Me.contactGroupBox.TabIndex = 11
        Me.contactGroupBox.TabStop = False
        Me.contactGroupBox.Text = "Contact Information"
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(200, 60)
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(154, 26)
        Me.phoneNumberTextBox.TabIndex = 3
        Me.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumberLabel.Location = New System.Drawing.Point(10, 63)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(123, 20)
        Me.phoneNumberLabel.TabIndex = 7
        Me.phoneNumberLabel.Text = "Phone Number: "
        '
        'addStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 360)
        Me.Controls.Add(Me.contactGroupBox)
        Me.Controls.Add(Me.studentInfoGroupBox)
        Me.Controls.Add(Me.allergyGroupBox)
        Me.Controls.Add(Me.addButton)
        Me.Name = "addStudentForm"
        Me.Text = "Add a Student"
        Me.allergyGroupBox.ResumeLayout(False)
        Me.allergyGroupBox.PerformLayout()
        Me.studentInfoGroupBox.ResumeLayout(False)
        Me.studentInfoGroupBox.PerformLayout()
        Me.contactGroupBox.ResumeLayout(False)
        Me.contactGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addButton As Button
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents parentNameLabel As Label
    Friend WithEvents parentNameTextBox As TextBox
    Friend WithEvents allergyComboBox As ComboBox
    Friend WithEvents otherAllergyTextBox As TextBox
    Friend WithEvents allergyGroupBox As GroupBox
    Friend WithEvents studentInfoGroupBox As GroupBox
    Friend WithEvents contactGroupBox As GroupBox
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents phoneNumberTextBox As TextBox
End Class
