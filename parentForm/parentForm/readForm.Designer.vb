<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class readForm
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.extLabel = New System.Windows.Forms.Label()
        Me.telephoneLabel = New System.Windows.Forms.Label()
        Me.departmentLabel = New System.Windows.Forms.Label()
        Me.employeeNumberLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.middelNameLabel = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.employeeGroupBox = New System.Windows.Forms.GroupBox()
        Me.emailValueLabel = New System.Windows.Forms.Label()
        Me.extValueLabel = New System.Windows.Forms.Label()
        Me.telephoneValueLabel = New System.Windows.Forms.Label()
        Me.deptValueLabel = New System.Windows.Forms.Label()
        Me.empNumValueLabel = New System.Windows.Forms.Label()
        Me.lastNameValueLabel = New System.Windows.Forms.Label()
        Me.middleNameValueLabel = New System.Windows.Forms.Label()
        Me.firstNameValueLabel = New System.Windows.Forms.Label()
        Me.recordLabel = New System.Windows.Forms.Label()
        Me.recordValueLabel = New System.Windows.Forms.Label()
        Me.employeeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(261, 373)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 43)
        Me.exitButton.TabIndex = 18
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(49, 373)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(100, 43)
        Me.nextButton.TabIndex = 16
        Me.nextButton.Text = "&Next Record"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.emailLabel.Location = New System.Drawing.Point(97, 309)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(52, 16)
        Me.emailLabel.TabIndex = 14
        Me.emailLabel.Text = "E-mail"
        Me.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'extLabel
        '
        Me.extLabel.AutoSize = True
        Me.extLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.extLabel.Location = New System.Drawing.Point(70, 269)
        Me.extLabel.Name = "extLabel"
        Me.extLabel.Size = New System.Drawing.Size(79, 16)
        Me.extLabel.TabIndex = 12
        Me.extLabel.Text = "Extension:"
        Me.extLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'telephoneLabel
        '
        Me.telephoneLabel.AutoSize = True
        Me.telephoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.telephoneLabel.Location = New System.Drawing.Point(62, 229)
        Me.telephoneLabel.Name = "telephoneLabel"
        Me.telephoneLabel.Size = New System.Drawing.Size(87, 16)
        Me.telephoneLabel.TabIndex = 10
        Me.telephoneLabel.Text = "Telephone:"
        Me.telephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'departmentLabel
        '
        Me.departmentLabel.AutoSize = True
        Me.departmentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.departmentLabel.Location = New System.Drawing.Point(53, 189)
        Me.departmentLabel.Name = "departmentLabel"
        Me.departmentLabel.Size = New System.Drawing.Size(96, 16)
        Me.departmentLabel.TabIndex = 8
        Me.departmentLabel.Text = "Departmemt:"
        Me.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'employeeNumberLabel
        '
        Me.employeeNumberLabel.AutoSize = True
        Me.employeeNumberLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.employeeNumberLabel.Location = New System.Drawing.Point(5, 149)
        Me.employeeNumberLabel.Name = "employeeNumberLabel"
        Me.employeeNumberLabel.Size = New System.Drawing.Size(144, 16)
        Me.employeeNumberLabel.TabIndex = 6
        Me.employeeNumberLabel.Text = "Employee Number: "
        Me.employeeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lastNameLabel.Location = New System.Drawing.Point(59, 109)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(90, 16)
        Me.lastNameLabel.TabIndex = 4
        Me.lastNameLabel.Text = "Last Name: "
        Me.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'middelNameLabel
        '
        Me.middelNameLabel.AutoSize = True
        Me.middelNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.middelNameLabel.Location = New System.Drawing.Point(41, 69)
        Me.middelNameLabel.Name = "middelNameLabel"
        Me.middelNameLabel.Size = New System.Drawing.Size(108, 16)
        Me.middelNameLabel.TabIndex = 2
        Me.middelNameLabel.Text = "Middle Name: "
        Me.middelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.firstNameLabel.Location = New System.Drawing.Point(58, 29)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(91, 16)
        Me.firstNameLabel.TabIndex = 0
        Me.firstNameLabel.Text = "First Name: "
        Me.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'employeeGroupBox
        '
        Me.employeeGroupBox.Controls.Add(Me.emailValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.extValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.telephoneValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.deptValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.empNumValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.lastNameValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.middleNameValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.firstNameValueLabel)
        Me.employeeGroupBox.Controls.Add(Me.exitButton)
        Me.employeeGroupBox.Controls.Add(Me.nextButton)
        Me.employeeGroupBox.Controls.Add(Me.emailLabel)
        Me.employeeGroupBox.Controls.Add(Me.extLabel)
        Me.employeeGroupBox.Controls.Add(Me.telephoneLabel)
        Me.employeeGroupBox.Controls.Add(Me.departmentLabel)
        Me.employeeGroupBox.Controls.Add(Me.employeeNumberLabel)
        Me.employeeGroupBox.Controls.Add(Me.lastNameLabel)
        Me.employeeGroupBox.Controls.Add(Me.middelNameLabel)
        Me.employeeGroupBox.Controls.Add(Me.firstNameLabel)
        Me.employeeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeGroupBox.Location = New System.Drawing.Point(24, 47)
        Me.employeeGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.employeeGroupBox.Name = "employeeGroupBox"
        Me.employeeGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.employeeGroupBox.Size = New System.Drawing.Size(388, 438)
        Me.employeeGroupBox.TabIndex = 1
        Me.employeeGroupBox.TabStop = False
        Me.employeeGroupBox.Text = "Employee Data"
        '
        'emailValueLabel
        '
        Me.emailValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.emailValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.emailValueLabel.Location = New System.Drawing.Point(155, 309)
        Me.emailValueLabel.Name = "emailValueLabel"
        Me.emailValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.emailValueLabel.TabIndex = 26
        '
        'extValueLabel
        '
        Me.extValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.extValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.extValueLabel.Location = New System.Drawing.Point(155, 269)
        Me.extValueLabel.Name = "extValueLabel"
        Me.extValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.extValueLabel.TabIndex = 25
        '
        'telephoneValueLabel
        '
        Me.telephoneValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.telephoneValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.telephoneValueLabel.Location = New System.Drawing.Point(155, 229)
        Me.telephoneValueLabel.Name = "telephoneValueLabel"
        Me.telephoneValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.telephoneValueLabel.TabIndex = 24
        '
        'deptValueLabel
        '
        Me.deptValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.deptValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.deptValueLabel.Location = New System.Drawing.Point(155, 188)
        Me.deptValueLabel.Name = "deptValueLabel"
        Me.deptValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.deptValueLabel.TabIndex = 23
        '
        'empNumValueLabel
        '
        Me.empNumValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.empNumValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.empNumValueLabel.Location = New System.Drawing.Point(155, 149)
        Me.empNumValueLabel.Name = "empNumValueLabel"
        Me.empNumValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.empNumValueLabel.TabIndex = 22
        '
        'lastNameValueLabel
        '
        Me.lastNameValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.lastNameValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lastNameValueLabel.Location = New System.Drawing.Point(155, 109)
        Me.lastNameValueLabel.Name = "lastNameValueLabel"
        Me.lastNameValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.lastNameValueLabel.TabIndex = 21
        '
        'middleNameValueLabel
        '
        Me.middleNameValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.middleNameValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.middleNameValueLabel.Location = New System.Drawing.Point(155, 69)
        Me.middleNameValueLabel.Name = "middleNameValueLabel"
        Me.middleNameValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.middleNameValueLabel.TabIndex = 20
        '
        'firstNameValueLabel
        '
        Me.firstNameValueLabel.BackColor = System.Drawing.SystemColors.Window
        Me.firstNameValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.firstNameValueLabel.Location = New System.Drawing.Point(155, 29)
        Me.firstNameValueLabel.Name = "firstNameValueLabel"
        Me.firstNameValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.firstNameValueLabel.TabIndex = 19
        '
        'recordLabel
        '
        Me.recordLabel.AutoSize = True
        Me.recordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordLabel.Location = New System.Drawing.Point(48, 18)
        Me.recordLabel.Name = "recordLabel"
        Me.recordLabel.Size = New System.Drawing.Size(125, 16)
        Me.recordLabel.TabIndex = 2
        Me.recordLabel.Text = "Record Number: "
        '
        'recordValueLabel
        '
        Me.recordValueLabel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.recordValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recordValueLabel.Location = New System.Drawing.Point(179, 18)
        Me.recordValueLabel.Name = "recordValueLabel"
        Me.recordValueLabel.Size = New System.Drawing.Size(100, 16)
        Me.recordValueLabel.TabIndex = 3
        '
        'readForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 498)
        Me.Controls.Add(Me.recordValueLabel)
        Me.Controls.Add(Me.recordLabel)
        Me.Controls.Add(Me.employeeGroupBox)
        Me.Name = "readForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Employee Records"
        Me.employeeGroupBox.ResumeLayout(False)
        Me.employeeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents emailLabel As Label
    Friend WithEvents extLabel As Label
    Friend WithEvents telephoneLabel As Label
    Friend WithEvents departmentLabel As Label
    Friend WithEvents employeeNumberLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents middelNameLabel As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents employeeGroupBox As GroupBox
    Friend WithEvents emailValueLabel As Label
    Friend WithEvents extValueLabel As Label
    Friend WithEvents telephoneValueLabel As Label
    Friend WithEvents deptValueLabel As Label
    Friend WithEvents empNumValueLabel As Label
    Friend WithEvents lastNameValueLabel As Label
    Friend WithEvents middleNameValueLabel As Label
    Friend WithEvents firstNameValueLabel As Label
    Friend WithEvents recordLabel As Label
    Friend WithEvents recordValueLabel As Label
End Class
