<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entryForm
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
        Me.employeeGroupBox = New System.Windows.Forms.GroupBox()
        Me.departmentComboBox = New System.Windows.Forms.ComboBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.saveRecordButton = New System.Windows.Forms.Button()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.extTextBox = New System.Windows.Forms.TextBox()
        Me.telephoneTextBox = New System.Windows.Forms.TextBox()
        Me.employeeNumberTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.middleNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.extLabel = New System.Windows.Forms.Label()
        Me.telephoneLabel = New System.Windows.Forms.Label()
        Me.departmentLabel = New System.Windows.Forms.Label()
        Me.employeeNumberLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.middelNameLabel = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.employeeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'employeeGroupBox
        '
        Me.employeeGroupBox.Controls.Add(Me.departmentComboBox)
        Me.employeeGroupBox.Controls.Add(Me.exitButton)
        Me.employeeGroupBox.Controls.Add(Me.clearButton)
        Me.employeeGroupBox.Controls.Add(Me.saveRecordButton)
        Me.employeeGroupBox.Controls.Add(Me.emailTextBox)
        Me.employeeGroupBox.Controls.Add(Me.extTextBox)
        Me.employeeGroupBox.Controls.Add(Me.telephoneTextBox)
        Me.employeeGroupBox.Controls.Add(Me.employeeNumberTextBox)
        Me.employeeGroupBox.Controls.Add(Me.lastNameTextBox)
        Me.employeeGroupBox.Controls.Add(Me.middleNameTextBox)
        Me.employeeGroupBox.Controls.Add(Me.firstNameTextBox)
        Me.employeeGroupBox.Controls.Add(Me.emailLabel)
        Me.employeeGroupBox.Controls.Add(Me.extLabel)
        Me.employeeGroupBox.Controls.Add(Me.telephoneLabel)
        Me.employeeGroupBox.Controls.Add(Me.departmentLabel)
        Me.employeeGroupBox.Controls.Add(Me.employeeNumberLabel)
        Me.employeeGroupBox.Controls.Add(Me.lastNameLabel)
        Me.employeeGroupBox.Controls.Add(Me.middelNameLabel)
        Me.employeeGroupBox.Controls.Add(Me.firstNameLabel)
        Me.employeeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeGroupBox.Location = New System.Drawing.Point(20, 16)
        Me.employeeGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.employeeGroupBox.Name = "employeeGroupBox"
        Me.employeeGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.employeeGroupBox.Size = New System.Drawing.Size(388, 438)
        Me.employeeGroupBox.TabIndex = 0
        Me.employeeGroupBox.TabStop = False
        Me.employeeGroupBox.Text = "Enter Employee Data"
        '
        'departmentComboBox
        '
        Me.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departmentComboBox.FormattingEnabled = True
        Me.departmentComboBox.Items.AddRange(New Object() {"IT", "Sales", "Marketing"})
        Me.departmentComboBox.Location = New System.Drawing.Point(155, 186)
        Me.departmentComboBox.Name = "departmentComboBox"
        Me.departmentComboBox.Size = New System.Drawing.Size(100, 24)
        Me.departmentComboBox.TabIndex = 19
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
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(155, 373)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 43)
        Me.clearButton.TabIndex = 17
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'saveRecordButton
        '
        Me.saveRecordButton.Location = New System.Drawing.Point(49, 373)
        Me.saveRecordButton.Name = "saveRecordButton"
        Me.saveRecordButton.Size = New System.Drawing.Size(100, 43)
        Me.saveRecordButton.TabIndex = 16
        Me.saveRecordButton.Text = "&Save Record"
        Me.saveRecordButton.UseVisualStyleBackColor = True
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(155, 306)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.emailTextBox.TabIndex = 15
        '
        'extTextBox
        '
        Me.extTextBox.Location = New System.Drawing.Point(155, 266)
        Me.extTextBox.Name = "extTextBox"
        Me.extTextBox.Size = New System.Drawing.Size(100, 22)
        Me.extTextBox.TabIndex = 13
        '
        'telephoneTextBox
        '
        Me.telephoneTextBox.Location = New System.Drawing.Point(155, 226)
        Me.telephoneTextBox.Name = "telephoneTextBox"
        Me.telephoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.telephoneTextBox.TabIndex = 11
        '
        'employeeNumberTextBox
        '
        Me.employeeNumberTextBox.Location = New System.Drawing.Point(155, 146)
        Me.employeeNumberTextBox.Name = "employeeNumberTextBox"
        Me.employeeNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.employeeNumberTextBox.TabIndex = 7
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(155, 106)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.lastNameTextBox.TabIndex = 5
        '
        'middleNameTextBox
        '
        Me.middleNameTextBox.Location = New System.Drawing.Point(155, 66)
        Me.middleNameTextBox.Name = "middleNameTextBox"
        Me.middleNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.middleNameTextBox.TabIndex = 3
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(155, 26)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.firstNameTextBox.TabIndex = 1
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.emailLabel.Location = New System.Drawing.Point(97, 309)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(52, 16)
        Me.emailLabel.TabIndex = 14
        Me.emailLabel.Text = "E-&mail"
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
        Me.extLabel.Text = "Exte&nsion:"
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
        Me.telephoneLabel.Text = "&Telephone:"
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
        Me.departmentLabel.Text = "&Departmemt:"
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
        Me.employeeNumberLabel.Text = "&Employee Number: "
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
        Me.lastNameLabel.Text = "&Last Name: "
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
        Me.middelNameLabel.Text = "&Middle Name: "
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
        Me.firstNameLabel.Text = "&First Name: "
        Me.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'entryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 478)
        Me.Controls.Add(Me.employeeGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "entryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Employee Entry"
        Me.employeeGroupBox.ResumeLayout(False)
        Me.employeeGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents employeeGroupBox As GroupBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents extLabel As Label
    Friend WithEvents telephoneLabel As Label
    Friend WithEvents departmentLabel As Label
    Friend WithEvents employeeNumberLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents middelNameLabel As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents extTextBox As TextBox
    Friend WithEvents telephoneTextBox As TextBox
    Friend WithEvents employeeNumberTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents middleNameTextBox As TextBox
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents saveRecordButton As Button
    Friend WithEvents departmentComboBox As ComboBox
End Class
