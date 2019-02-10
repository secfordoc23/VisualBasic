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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.firstPlaceLabel = New System.Windows.Forms.Label()
        Me.secondPlaceLabel = New System.Windows.Forms.Label()
        Me.thirdPlaceLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.runner1NameTextBox = New System.Windows.Forms.TextBox()
        Me.runner2NameTextBox = New System.Windows.Forms.TextBox()
        Me.runner3NameTextBox = New System.Windows.Forms.TextBox()
        Me.runner2TimeTextBox = New System.Windows.Forms.TextBox()
        Me.runner1TimeTextBox = New System.Windows.Forms.TextBox()
        Me.runner3TimeTextBox = New System.Windows.Forms.TextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.resultsGroupBox = New System.Windows.Forms.GroupBox()
        Me.thirdPlaceNameLabel = New System.Windows.Forms.Label()
        Me.secondPlaceNameLabel = New System.Windows.Forms.Label()
        Me.firstPlaceNameLabel = New System.Windows.Forms.Label()
        Me.runner1Label = New System.Windows.Forms.Label()
        Me.runner2Label = New System.Windows.Forms.Label()
        Me.runner3Label = New System.Windows.Forms.Label()
        Me.resultsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(74, 36)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(368, 20)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Enter the three runners' names and finishing times."
        '
        'firstPlaceLabel
        '
        Me.firstPlaceLabel.AutoSize = True
        Me.firstPlaceLabel.Location = New System.Drawing.Point(25, 61)
        Me.firstPlaceLabel.Name = "firstPlaceLabel"
        Me.firstPlaceLabel.Size = New System.Drawing.Size(78, 20)
        Me.firstPlaceLabel.TabIndex = 0
        Me.firstPlaceLabel.Text = "1st Place:"
        '
        'secondPlaceLabel
        '
        Me.secondPlaceLabel.AutoSize = True
        Me.secondPlaceLabel.Location = New System.Drawing.Point(25, 101)
        Me.secondPlaceLabel.Name = "secondPlaceLabel"
        Me.secondPlaceLabel.Size = New System.Drawing.Size(83, 20)
        Me.secondPlaceLabel.TabIndex = 2
        Me.secondPlaceLabel.Text = "2nd Place:"
        '
        'thirdPlaceLabel
        '
        Me.thirdPlaceLabel.AutoSize = True
        Me.thirdPlaceLabel.Location = New System.Drawing.Point(25, 138)
        Me.thirdPlaceLabel.Name = "thirdPlaceLabel"
        Me.thirdPlaceLabel.Size = New System.Drawing.Size(79, 20)
        Me.thirdPlaceLabel.TabIndex = 4
        Me.thirdPlaceLabel.Text = "3rd Place:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(163, 87)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(55, 20)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(272, 87)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(204, 20)
        Me.timeLabel.TabIndex = 3
        Me.timeLabel.Text = "Finishing Time (in seconds):"
        '
        'runner1NameTextBox
        '
        Me.runner1NameTextBox.Location = New System.Drawing.Point(138, 113)
        Me.runner1NameTextBox.Name = "runner1NameTextBox"
        Me.runner1NameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.runner1NameTextBox.TabIndex = 1
        Me.runner1NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'runner2NameTextBox
        '
        Me.runner2NameTextBox.Location = New System.Drawing.Point(138, 153)
        Me.runner2NameTextBox.Name = "runner2NameTextBox"
        Me.runner2NameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.runner2NameTextBox.TabIndex = 4
        Me.runner2NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'runner3NameTextBox
        '
        Me.runner3NameTextBox.Location = New System.Drawing.Point(138, 190)
        Me.runner3NameTextBox.Name = "runner3NameTextBox"
        Me.runner3NameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.runner3NameTextBox.TabIndex = 7
        Me.runner3NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'runner2TimeTextBox
        '
        Me.runner2TimeTextBox.Location = New System.Drawing.Point(324, 153)
        Me.runner2TimeTextBox.Name = "runner2TimeTextBox"
        Me.runner2TimeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.runner2TimeTextBox.TabIndex = 5
        Me.runner2TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'runner1TimeTextBox
        '
        Me.runner1TimeTextBox.Location = New System.Drawing.Point(324, 113)
        Me.runner1TimeTextBox.Name = "runner1TimeTextBox"
        Me.runner1TimeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.runner1TimeTextBox.TabIndex = 2
        Me.runner1TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'runner3TimeTextBox
        '
        Me.runner3TimeTextBox.Location = New System.Drawing.Point(324, 190)
        Me.runner3TimeTextBox.Name = "runner3TimeTextBox"
        Me.runner3TimeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.runner3TimeTextBox.TabIndex = 8
        Me.runner3TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(322, 513)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(196, 513)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(69, 513)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 9
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resultsGroupBox
        '
        Me.resultsGroupBox.Controls.Add(Me.thirdPlaceNameLabel)
        Me.resultsGroupBox.Controls.Add(Me.secondPlaceNameLabel)
        Me.resultsGroupBox.Controls.Add(Me.firstPlaceNameLabel)
        Me.resultsGroupBox.Controls.Add(Me.firstPlaceLabel)
        Me.resultsGroupBox.Controls.Add(Me.secondPlaceLabel)
        Me.resultsGroupBox.Controls.Add(Me.thirdPlaceLabel)
        Me.resultsGroupBox.Location = New System.Drawing.Point(138, 248)
        Me.resultsGroupBox.Name = "resultsGroupBox"
        Me.resultsGroupBox.Size = New System.Drawing.Size(256, 212)
        Me.resultsGroupBox.TabIndex = 10
        Me.resultsGroupBox.TabStop = False
        Me.resultsGroupBox.Text = "Race Results"
        '
        'thirdPlaceNameLabel
        '
        Me.thirdPlaceNameLabel.BackColor = System.Drawing.Color.White
        Me.thirdPlaceNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.thirdPlaceNameLabel.Location = New System.Drawing.Point(109, 137)
        Me.thirdPlaceNameLabel.Name = "thirdPlaceNameLabel"
        Me.thirdPlaceNameLabel.Size = New System.Drawing.Size(106, 20)
        Me.thirdPlaceNameLabel.TabIndex = 5
        '
        'secondPlaceNameLabel
        '
        Me.secondPlaceNameLabel.BackColor = System.Drawing.Color.White
        Me.secondPlaceNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.secondPlaceNameLabel.Location = New System.Drawing.Point(109, 100)
        Me.secondPlaceNameLabel.Name = "secondPlaceNameLabel"
        Me.secondPlaceNameLabel.Size = New System.Drawing.Size(106, 20)
        Me.secondPlaceNameLabel.TabIndex = 3
        '
        'firstPlaceNameLabel
        '
        Me.firstPlaceNameLabel.BackColor = System.Drawing.Color.White
        Me.firstPlaceNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.firstPlaceNameLabel.Location = New System.Drawing.Point(109, 60)
        Me.firstPlaceNameLabel.Name = "firstPlaceNameLabel"
        Me.firstPlaceNameLabel.Size = New System.Drawing.Size(106, 20)
        Me.firstPlaceNameLabel.TabIndex = 1
        '
        'runner1Label
        '
        Me.runner1Label.AutoSize = True
        Me.runner1Label.Location = New System.Drawing.Point(48, 116)
        Me.runner1Label.Name = "runner1Label"
        Me.runner1Label.Size = New System.Drawing.Size(79, 20)
        Me.runner1Label.TabIndex = 0
        Me.runner1Label.Text = "Runner 1:"
        '
        'runner2Label
        '
        Me.runner2Label.AutoSize = True
        Me.runner2Label.Location = New System.Drawing.Point(48, 156)
        Me.runner2Label.Name = "runner2Label"
        Me.runner2Label.Size = New System.Drawing.Size(79, 20)
        Me.runner2Label.TabIndex = 3
        Me.runner2Label.Text = "Runner 2:"
        '
        'runner3Label
        '
        Me.runner3Label.AutoSize = True
        Me.runner3Label.Location = New System.Drawing.Point(48, 193)
        Me.runner3Label.Name = "runner3Label"
        Me.runner3Label.Size = New System.Drawing.Size(79, 20)
        Me.runner3Label.TabIndex = 6
        Me.runner3Label.Text = "Runner 3:"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 611)
        Me.Controls.Add(Me.runner3Label)
        Me.Controls.Add(Me.runner2Label)
        Me.Controls.Add(Me.runner1Label)
        Me.Controls.Add(Me.resultsGroupBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.runner3TimeTextBox)
        Me.Controls.Add(Me.runner3NameTextBox)
        Me.Controls.Add(Me.runner1TimeTextBox)
        Me.Controls.Add(Me.runner2TimeTextBox)
        Me.Controls.Add(Me.runner2NameTextBox)
        Me.Controls.Add(Me.runner1NameTextBox)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Race Results"
        Me.resultsGroupBox.ResumeLayout(False)
        Me.resultsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents firstPlaceLabel As System.Windows.Forms.Label
    Friend WithEvents secondPlaceLabel As System.Windows.Forms.Label
    Friend WithEvents thirdPlaceLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents runner1NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents runner2NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents runner3NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents runner2TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents runner1TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents runner3TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents resultsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents thirdPlaceNameLabel As System.Windows.Forms.Label
    Friend WithEvents secondPlaceNameLabel As System.Windows.Forms.Label
    Friend WithEvents firstPlaceNameLabel As System.Windows.Forms.Label
    Friend WithEvents runner1Label As System.Windows.Forms.Label
    Friend WithEvents runner2Label As System.Windows.Forms.Label
    Friend WithEvents runner3Label As System.Windows.Forms.Label

End Class
