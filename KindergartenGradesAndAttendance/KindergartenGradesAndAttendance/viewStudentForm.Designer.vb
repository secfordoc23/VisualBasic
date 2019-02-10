<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewStudentForm
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
        Me.studentListBox = New System.Windows.Forms.ListBox()
        Me.studentInformationListBox = New System.Windows.Forms.ListBox()
        Me.dailyGradeListBox = New System.Windows.Forms.ListBox()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.studentListLabel = New System.Windows.Forms.Label()
        Me.studentInformationLabel = New System.Windows.Forms.Label()
        Me.dailyGradesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'studentListBox
        '
        Me.studentListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentListBox.FormattingEnabled = True
        Me.studentListBox.ItemHeight = 20
        Me.studentListBox.Location = New System.Drawing.Point(12, 49)
        Me.studentListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studentListBox.Name = "studentListBox"
        Me.studentListBox.Size = New System.Drawing.Size(186, 444)
        Me.studentListBox.TabIndex = 1
        '
        'studentInformationListBox
        '
        Me.studentInformationListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInformationListBox.FormattingEnabled = True
        Me.studentInformationListBox.ItemHeight = 20
        Me.studentInformationListBox.Location = New System.Drawing.Point(218, 49)
        Me.studentInformationListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studentInformationListBox.Name = "studentInformationListBox"
        Me.studentInformationListBox.Size = New System.Drawing.Size(407, 244)
        Me.studentInformationListBox.TabIndex = 0
        '
        'dailyGradeListBox
        '
        Me.dailyGradeListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyGradeListBox.FormattingEnabled = True
        Me.dailyGradeListBox.ItemHeight = 20
        Me.dailyGradeListBox.Location = New System.Drawing.Point(642, 49)
        Me.dailyGradeListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dailyGradeListBox.Name = "dailyGradeListBox"
        Me.dailyGradeListBox.Size = New System.Drawing.Size(186, 444)
        Me.dailyGradeListBox.TabIndex = 0
        '
        'closeButton
        '
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(342, 425)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(158, 68)
        Me.closeButton.TabIndex = 2
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'studentListLabel
        '
        Me.studentListLabel.AutoSize = True
        Me.studentListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentListLabel.Location = New System.Drawing.Point(8, 24)
        Me.studentListLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.studentListLabel.Name = "studentListLabel"
        Me.studentListLabel.Size = New System.Drawing.Size(78, 20)
        Me.studentListLabel.TabIndex = 4
        Me.studentListLabel.Text = "Students:"
        '
        'studentInformationLabel
        '
        Me.studentInformationLabel.AutoSize = True
        Me.studentInformationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInformationLabel.Location = New System.Drawing.Point(214, 24)
        Me.studentInformationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.studentInformationLabel.Name = "studentInformationLabel"
        Me.studentInformationLabel.Size = New System.Drawing.Size(155, 20)
        Me.studentInformationLabel.TabIndex = 5
        Me.studentInformationLabel.Text = "Student Information:"
        '
        'dailyGradesLabel
        '
        Me.dailyGradesLabel.AutoSize = True
        Me.dailyGradesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyGradesLabel.Location = New System.Drawing.Point(638, 24)
        Me.dailyGradesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dailyGradesLabel.Name = "dailyGradesLabel"
        Me.dailyGradesLabel.Size = New System.Drawing.Size(104, 20)
        Me.dailyGradesLabel.TabIndex = 6
        Me.dailyGradesLabel.Text = "Daily Grades:"
        '
        'viewStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 503)
        Me.Controls.Add(Me.dailyGradesLabel)
        Me.Controls.Add(Me.studentInformationLabel)
        Me.Controls.Add(Me.studentListLabel)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.dailyGradeListBox)
        Me.Controls.Add(Me.studentInformationListBox)
        Me.Controls.Add(Me.studentListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "viewStudentForm"
        Me.Text = "View Student Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentListBox As ListBox
    Friend WithEvents studentInformationListBox As ListBox
    Friend WithEvents dailyGradeListBox As ListBox
    Friend WithEvents closeButton As Button
    Friend WithEvents studentListLabel As Label
    Friend WithEvents studentInformationLabel As Label
    Friend WithEvents dailyGradesLabel As Label
End Class
