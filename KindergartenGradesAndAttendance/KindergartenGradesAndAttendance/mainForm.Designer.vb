<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.addStudentButton = New System.Windows.Forms.Button()
        Me.viewStudentsButton = New System.Windows.Forms.Button()
        Me.addDailyGradeButton = New System.Windows.Forms.Button()
        Me.printStudentReportButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.optionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.enrollmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.numberOfSessionsComboBox = New System.Windows.Forms.ComboBox()
        Me.sessionCountLabel = New System.Windows.Forms.Label()
        Me.openCountLabel = New System.Windows.Forms.Label()
        Me.openCountTextBox = New System.Windows.Forms.TextBox()
        Me.studentCountTextBox = New System.Windows.Forms.TextBox()
        Me.studentCountLabel = New System.Windows.Forms.Label()
        Me.optionsGroupBox.SuspendLayout()
        Me.enrollmentGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'addStudentButton
        '
        Me.addStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStudentButton.Location = New System.Drawing.Point(6, 19)
        Me.addStudentButton.Name = "addStudentButton"
        Me.addStudentButton.Size = New System.Drawing.Size(195, 46)
        Me.addStudentButton.TabIndex = 0
        Me.addStudentButton.Text = "Add a Student"
        Me.addStudentButton.UseVisualStyleBackColor = True
        '
        'viewStudentsButton
        '
        Me.viewStudentsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewStudentsButton.Location = New System.Drawing.Point(6, 71)
        Me.viewStudentsButton.Name = "viewStudentsButton"
        Me.viewStudentsButton.Size = New System.Drawing.Size(195, 46)
        Me.viewStudentsButton.TabIndex = 1
        Me.viewStudentsButton.Text = "View Student(s)"
        Me.viewStudentsButton.UseVisualStyleBackColor = True
        '
        'addDailyGradeButton
        '
        Me.addDailyGradeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addDailyGradeButton.Location = New System.Drawing.Point(6, 123)
        Me.addDailyGradeButton.Name = "addDailyGradeButton"
        Me.addDailyGradeButton.Size = New System.Drawing.Size(195, 46)
        Me.addDailyGradeButton.TabIndex = 2
        Me.addDailyGradeButton.Text = "Add Daily Grade"
        Me.addDailyGradeButton.UseVisualStyleBackColor = True
        '
        'printStudentReportButton
        '
        Me.printStudentReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printStudentReportButton.Location = New System.Drawing.Point(6, 175)
        Me.printStudentReportButton.Name = "printStudentReportButton"
        Me.printStudentReportButton.Size = New System.Drawing.Size(195, 46)
        Me.printStudentReportButton.TabIndex = 3
        Me.printStudentReportButton.Text = "Print Student(s) Report"
        Me.printStudentReportButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(132, 434)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(99, 36)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'optionsGroupBox
        '
        Me.optionsGroupBox.Controls.Add(Me.addStudentButton)
        Me.optionsGroupBox.Controls.Add(Me.viewStudentsButton)
        Me.optionsGroupBox.Controls.Add(Me.printStudentReportButton)
        Me.optionsGroupBox.Controls.Add(Me.addDailyGradeButton)
        Me.optionsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionsGroupBox.Location = New System.Drawing.Point(79, 195)
        Me.optionsGroupBox.Name = "optionsGroupBox"
        Me.optionsGroupBox.Size = New System.Drawing.Size(208, 233)
        Me.optionsGroupBox.TabIndex = 0
        Me.optionsGroupBox.TabStop = False
        Me.optionsGroupBox.Text = "Options"
        '
        'enrollmentGroupBox
        '
        Me.enrollmentGroupBox.Controls.Add(Me.numberOfSessionsComboBox)
        Me.enrollmentGroupBox.Controls.Add(Me.sessionCountLabel)
        Me.enrollmentGroupBox.Controls.Add(Me.openCountLabel)
        Me.enrollmentGroupBox.Controls.Add(Me.openCountTextBox)
        Me.enrollmentGroupBox.Controls.Add(Me.studentCountTextBox)
        Me.enrollmentGroupBox.Controls.Add(Me.studentCountLabel)
        Me.enrollmentGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollmentGroupBox.Location = New System.Drawing.Point(18, 12)
        Me.enrollmentGroupBox.Name = "enrollmentGroupBox"
        Me.enrollmentGroupBox.Size = New System.Drawing.Size(336, 133)
        Me.enrollmentGroupBox.TabIndex = 6
        Me.enrollmentGroupBox.TabStop = False
        Me.enrollmentGroupBox.Text = "Enrollment Status"
        '
        'numberOfSessionsComboBox
        '
        Me.numberOfSessionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.numberOfSessionsComboBox.FormattingEnabled = True
        Me.numberOfSessionsComboBox.Location = New System.Drawing.Point(263, 96)
        Me.numberOfSessionsComboBox.Name = "numberOfSessionsComboBox"
        Me.numberOfSessionsComboBox.Size = New System.Drawing.Size(63, 28)
        Me.numberOfSessionsComboBox.TabIndex = 5
        '
        'sessionCountLabel
        '
        Me.sessionCountLabel.AutoSize = True
        Me.sessionCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionCountLabel.Location = New System.Drawing.Point(6, 99)
        Me.sessionCountLabel.Name = "sessionCountLabel"
        Me.sessionCountLabel.Size = New System.Drawing.Size(160, 20)
        Me.sessionCountLabel.TabIndex = 4
        Me.sessionCountLabel.Text = "Number of Sessions: "
        '
        'openCountLabel
        '
        Me.openCountLabel.AutoSize = True
        Me.openCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openCountLabel.Location = New System.Drawing.Point(5, 65)
        Me.openCountLabel.Name = "openCountLabel"
        Me.openCountLabel.Size = New System.Drawing.Size(163, 20)
        Me.openCountLabel.TabIndex = 3
        Me.openCountLabel.Text = "Number of Openings: "
        '
        'openCountTextBox
        '
        Me.openCountTextBox.Location = New System.Drawing.Point(263, 62)
        Me.openCountTextBox.Name = "openCountTextBox"
        Me.openCountTextBox.ReadOnly = True
        Me.openCountTextBox.Size = New System.Drawing.Size(63, 26)
        Me.openCountTextBox.TabIndex = 0
        Me.openCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'studentCountTextBox
        '
        Me.studentCountTextBox.Location = New System.Drawing.Point(263, 30)
        Me.studentCountTextBox.Name = "studentCountTextBox"
        Me.studentCountTextBox.ReadOnly = True
        Me.studentCountTextBox.Size = New System.Drawing.Size(63, 26)
        Me.studentCountTextBox.TabIndex = 0
        Me.studentCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'studentCountLabel
        '
        Me.studentCountLabel.AutoSize = True
        Me.studentCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentCountLabel.Location = New System.Drawing.Point(6, 33)
        Me.studentCountLabel.Name = "studentCountLabel"
        Me.studentCountLabel.Size = New System.Drawing.Size(217, 20)
        Me.studentCountLabel.TabIndex = 0
        Me.studentCountLabel.Text = "Current Number of Students: "
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 494)
        Me.Controls.Add(Me.enrollmentGroupBox)
        Me.Controls.Add(Me.optionsGroupBox)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "mainForm"
        Me.Text = "Kindergarten Grades and Attendance"
        Me.optionsGroupBox.ResumeLayout(False)
        Me.enrollmentGroupBox.ResumeLayout(False)
        Me.enrollmentGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addStudentButton As Button
    Friend WithEvents viewStudentsButton As Button
    Friend WithEvents addDailyGradeButton As Button
    Friend WithEvents printStudentReportButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents optionsGroupBox As GroupBox
    Friend WithEvents enrollmentGroupBox As GroupBox
    Friend WithEvents studentCountLabel As Label
    Friend WithEvents openCountLabel As Label
    Friend WithEvents openCountTextBox As TextBox
    Friend WithEvents studentCountTextBox As TextBox
    Friend WithEvents sessionCountLabel As Label
    Friend WithEvents numberOfSessionsComboBox As ComboBox
End Class
