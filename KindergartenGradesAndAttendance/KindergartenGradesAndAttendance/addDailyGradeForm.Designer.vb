<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDailyGradeForm
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
        Me.strudentLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.sessionNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.dailyGradeComboBox = New System.Windows.Forms.ComboBox()
        Me.sessionNumberLabel = New System.Windows.Forms.Label()
        Me.dailyGradeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'studentListBox
        '
        Me.studentListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentListBox.FormattingEnabled = True
        Me.studentListBox.ItemHeight = 20
        Me.studentListBox.Location = New System.Drawing.Point(13, 47)
        Me.studentListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studentListBox.Name = "studentListBox"
        Me.studentListBox.Size = New System.Drawing.Size(217, 264)
        Me.studentListBox.TabIndex = 0
        Me.studentListBox.Tag = "1"
        '
        'strudentLabel
        '
        Me.strudentLabel.AutoSize = True
        Me.strudentLabel.Location = New System.Drawing.Point(12, 22)
        Me.strudentLabel.Name = "strudentLabel"
        Me.strudentLabel.Size = New System.Drawing.Size(119, 20)
        Me.strudentLabel.TabIndex = 1
        Me.strudentLabel.Text = "Select Student:"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(260, 263)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(157, 48)
        Me.addButton.TabIndex = 2
        Me.addButton.Tag = "4"
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'sessionNumberComboBox
        '
        Me.sessionNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sessionNumberComboBox.FormattingEnabled = True
        Me.sessionNumberComboBox.Location = New System.Drawing.Point(260, 47)
        Me.sessionNumberComboBox.Name = "sessionNumberComboBox"
        Me.sessionNumberComboBox.Size = New System.Drawing.Size(157, 28)
        Me.sessionNumberComboBox.TabIndex = 3
        Me.sessionNumberComboBox.Tag = "2"
        '
        'dailyGradeComboBox
        '
        Me.dailyGradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dailyGradeComboBox.FormattingEnabled = True
        Me.dailyGradeComboBox.Location = New System.Drawing.Point(260, 119)
        Me.dailyGradeComboBox.Name = "dailyGradeComboBox"
        Me.dailyGradeComboBox.Size = New System.Drawing.Size(157, 28)
        Me.dailyGradeComboBox.TabIndex = 4
        Me.dailyGradeComboBox.Tag = "3"
        '
        'sessionNumberLabel
        '
        Me.sessionNumberLabel.AutoSize = True
        Me.sessionNumberLabel.Location = New System.Drawing.Point(256, 22)
        Me.sessionNumberLabel.Name = "sessionNumberLabel"
        Me.sessionNumberLabel.Size = New System.Drawing.Size(130, 20)
        Me.sessionNumberLabel.TabIndex = 5
        Me.sessionNumberLabel.Text = "Session Number:"
        '
        'dailyGradeLabel
        '
        Me.dailyGradeLabel.AutoSize = True
        Me.dailyGradeLabel.Location = New System.Drawing.Point(256, 96)
        Me.dailyGradeLabel.Name = "dailyGradeLabel"
        Me.dailyGradeLabel.Size = New System.Drawing.Size(96, 20)
        Me.dailyGradeLabel.TabIndex = 6
        Me.dailyGradeLabel.Text = "Daily Grade:"
        '
        'addDailyGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 354)
        Me.Controls.Add(Me.dailyGradeLabel)
        Me.Controls.Add(Me.sessionNumberLabel)
        Me.Controls.Add(Me.dailyGradeComboBox)
        Me.Controls.Add(Me.sessionNumberComboBox)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.strudentLabel)
        Me.Controls.Add(Me.studentListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "addDailyGradeForm"
        Me.Text = "Add Daily Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentListBox As ListBox
    Friend WithEvents strudentLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents sessionNumberComboBox As ComboBox
    Friend WithEvents dailyGradeComboBox As ComboBox
    Friend WithEvents sessionNumberLabel As Label
    Friend WithEvents dailyGradeLabel As Label
End Class
