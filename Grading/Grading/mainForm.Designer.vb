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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.grade1Label = New System.Windows.Forms.Label()
        Me.grade2Label = New System.Windows.Forms.Label()
        Me.grade3Label = New System.Windows.Forms.Label()
        Me.grade5Label = New System.Windows.Forms.Label()
        Me.grade4Label = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.letterGradeLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.grade1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.grade2ValueTextBox = New System.Windows.Forms.TextBox()
        Me.grade3ValueTextBox = New System.Windows.Forms.TextBox()
        Me.grade4ValueTextBox = New System.Windows.Forms.TextBox()
        Me.grade5ValueTextBox = New System.Windows.Forms.TextBox()
        Me.totalValueLabel = New System.Windows.Forms.Label()
        Me.averageValueLabel = New System.Windows.Forms.Label()
        Me.letterValueLabel = New System.Windows.Forms.Label()
        Me.displayListBox = New System.Windows.Forms.ListBox()
        Me.gradesLabel = New System.Windows.Forms.Label()
        Me.recordButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nameLabel.Location = New System.Drawing.Point(13, 13)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(134, 20)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "&Student Name: "
        '
        'grade1Label
        '
        Me.grade1Label.AutoSize = True
        Me.grade1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grade1Label.Location = New System.Drawing.Point(13, 71)
        Me.grade1Label.Name = "grade1Label"
        Me.grade1Label.Size = New System.Drawing.Size(89, 20)
        Me.grade1Label.TabIndex = 2
        Me.grade1Label.Text = "Grade#&1: "
        '
        'grade2Label
        '
        Me.grade2Label.AutoSize = True
        Me.grade2Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grade2Label.Location = New System.Drawing.Point(108, 71)
        Me.grade2Label.Name = "grade2Label"
        Me.grade2Label.Size = New System.Drawing.Size(89, 20)
        Me.grade2Label.TabIndex = 4
        Me.grade2Label.Text = "Grade#&2: "
        '
        'grade3Label
        '
        Me.grade3Label.AutoSize = True
        Me.grade3Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grade3Label.Location = New System.Drawing.Point(203, 71)
        Me.grade3Label.Name = "grade3Label"
        Me.grade3Label.Size = New System.Drawing.Size(89, 20)
        Me.grade3Label.TabIndex = 6
        Me.grade3Label.Text = "Grade#&3: "
        '
        'grade5Label
        '
        Me.grade5Label.AutoSize = True
        Me.grade5Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grade5Label.Location = New System.Drawing.Point(393, 71)
        Me.grade5Label.Name = "grade5Label"
        Me.grade5Label.Size = New System.Drawing.Size(89, 20)
        Me.grade5Label.TabIndex = 10
        Me.grade5Label.Text = "Grade#&5: "
        '
        'grade4Label
        '
        Me.grade4Label.AutoSize = True
        Me.grade4Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grade4Label.Location = New System.Drawing.Point(298, 71)
        Me.grade4Label.Name = "grade4Label"
        Me.grade4Label.Size = New System.Drawing.Size(89, 20)
        Me.grade4Label.TabIndex = 8
        Me.grade4Label.Text = "Grade#&4: "
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totalLabel.Location = New System.Drawing.Point(13, 186)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(59, 20)
        Me.totalLabel.TabIndex = 12
        Me.totalLabel.Text = "Total: "
        '
        'averageLabel
        '
        Me.averageLabel.AutoSize = True
        Me.averageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.averageLabel.Location = New System.Drawing.Point(108, 186)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(85, 20)
        Me.averageLabel.TabIndex = 14
        Me.averageLabel.Text = "Average: "
        '
        'letterGradeLabel
        '
        Me.letterGradeLabel.AutoSize = True
        Me.letterGradeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.letterGradeLabel.Location = New System.Drawing.Point(203, 186)
        Me.letterGradeLabel.Name = "letterGradeLabel"
        Me.letterGradeLabel.Size = New System.Drawing.Size(122, 20)
        Me.letterGradeLabel.TabIndex = 16
        Me.letterGradeLabel.Text = "Letter Grade: "
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(17, 37)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(130, 26)
        Me.nameTextBox.TabIndex = 1
        Me.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grade1ValueTextBox
        '
        Me.grade1ValueTextBox.Location = New System.Drawing.Point(17, 94)
        Me.grade1ValueTextBox.Name = "grade1ValueTextBox"
        Me.grade1ValueTextBox.Size = New System.Drawing.Size(85, 26)
        Me.grade1ValueTextBox.TabIndex = 3
        Me.grade1ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grade2ValueTextBox
        '
        Me.grade2ValueTextBox.Location = New System.Drawing.Point(112, 94)
        Me.grade2ValueTextBox.Name = "grade2ValueTextBox"
        Me.grade2ValueTextBox.Size = New System.Drawing.Size(85, 26)
        Me.grade2ValueTextBox.TabIndex = 5
        Me.grade2ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grade3ValueTextBox
        '
        Me.grade3ValueTextBox.Location = New System.Drawing.Point(207, 94)
        Me.grade3ValueTextBox.Name = "grade3ValueTextBox"
        Me.grade3ValueTextBox.Size = New System.Drawing.Size(85, 26)
        Me.grade3ValueTextBox.TabIndex = 7
        Me.grade3ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grade4ValueTextBox
        '
        Me.grade4ValueTextBox.Location = New System.Drawing.Point(302, 94)
        Me.grade4ValueTextBox.Name = "grade4ValueTextBox"
        Me.grade4ValueTextBox.Size = New System.Drawing.Size(85, 26)
        Me.grade4ValueTextBox.TabIndex = 9
        Me.grade4ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grade5ValueTextBox
        '
        Me.grade5ValueTextBox.Location = New System.Drawing.Point(397, 94)
        Me.grade5ValueTextBox.Name = "grade5ValueTextBox"
        Me.grade5ValueTextBox.Size = New System.Drawing.Size(85, 26)
        Me.grade5ValueTextBox.TabIndex = 11
        Me.grade5ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalValueLabel
        '
        Me.totalValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalValueLabel.Location = New System.Drawing.Point(17, 206)
        Me.totalValueLabel.Name = "totalValueLabel"
        Me.totalValueLabel.Size = New System.Drawing.Size(85, 29)
        Me.totalValueLabel.TabIndex = 13
        Me.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'averageValueLabel
        '
        Me.averageValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageValueLabel.Location = New System.Drawing.Point(112, 206)
        Me.averageValueLabel.Name = "averageValueLabel"
        Me.averageValueLabel.Size = New System.Drawing.Size(85, 29)
        Me.averageValueLabel.TabIndex = 15
        Me.averageValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'letterValueLabel
        '
        Me.letterValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.letterValueLabel.Location = New System.Drawing.Point(207, 206)
        Me.letterValueLabel.Name = "letterValueLabel"
        Me.letterValueLabel.Size = New System.Drawing.Size(85, 29)
        Me.letterValueLabel.TabIndex = 17
        Me.letterValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayListBox
        '
        Me.displayListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayListBox.FormattingEnabled = True
        Me.displayListBox.ItemHeight = 16
        Me.displayListBox.Location = New System.Drawing.Point(504, 37)
        Me.displayListBox.Name = "displayListBox"
        Me.displayListBox.Size = New System.Drawing.Size(212, 324)
        Me.displayListBox.TabIndex = 22
        '
        'gradesLabel
        '
        Me.gradesLabel.AutoSize = True
        Me.gradesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gradesLabel.Location = New System.Drawing.Point(500, 14)
        Me.gradesLabel.Name = "gradesLabel"
        Me.gradesLabel.Size = New System.Drawing.Size(78, 20)
        Me.gradesLabel.TabIndex = 21
        Me.gradesLabel.Text = "Grades: "
        '
        'recordButton
        '
        Me.recordButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.recordButton.Location = New System.Drawing.Point(17, 302)
        Me.recordButton.Name = "recordButton"
        Me.recordButton.Size = New System.Drawing.Size(114, 43)
        Me.recordButton.TabIndex = 18
        Me.recordButton.Text = "&Record"
        Me.recordButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearButton.Location = New System.Drawing.Point(137, 302)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(114, 43)
        Me.clearButton.TabIndex = 19
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.exitButton.Location = New System.Drawing.Point(257, 302)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(114, 43)
        Me.exitButton.TabIndex = 20
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.recordButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(728, 380)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.recordButton)
        Me.Controls.Add(Me.gradesLabel)
        Me.Controls.Add(Me.displayListBox)
        Me.Controls.Add(Me.letterValueLabel)
        Me.Controls.Add(Me.averageValueLabel)
        Me.Controls.Add(Me.totalValueLabel)
        Me.Controls.Add(Me.grade5ValueTextBox)
        Me.Controls.Add(Me.grade4ValueTextBox)
        Me.Controls.Add(Me.grade3ValueTextBox)
        Me.Controls.Add(Me.grade2ValueTextBox)
        Me.Controls.Add(Me.grade1ValueTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.letterGradeLabel)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.grade4Label)
        Me.Controls.Add(Me.grade5Label)
        Me.Controls.Add(Me.grade3Label)
        Me.Controls.Add(Me.grade2Label)
        Me.Controls.Add(Me.grade1Label)
        Me.Controls.Add(Me.nameLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents grade1Label As Label
    Friend WithEvents grade2Label As Label
    Friend WithEvents grade3Label As Label
    Friend WithEvents grade5Label As Label
    Friend WithEvents grade4Label As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents averageLabel As Label
    Friend WithEvents letterGradeLabel As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents grade1ValueTextBox As TextBox
    Friend WithEvents grade2ValueTextBox As TextBox
    Friend WithEvents grade3ValueTextBox As TextBox
    Friend WithEvents grade4ValueTextBox As TextBox
    Friend WithEvents grade5ValueTextBox As TextBox
    Friend WithEvents totalValueLabel As Label
    Friend WithEvents averageValueLabel As Label
    Friend WithEvents letterValueLabel As Label
    Friend WithEvents displayListBox As ListBox
    Friend WithEvents gradesLabel As Label
    Friend WithEvents recordButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
