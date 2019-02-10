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
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.score1Label = New System.Windows.Forms.Label()
        Me.score2Label = New System.Windows.Forms.Label()
        Me.score3Label = New System.Windows.Forms.Label()
        Me.score4Label = New System.Windows.Forms.Label()
        Me.score5Label = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.displayAverageLabel = New System.Windows.Forms.Label()
        Me.score1TextBox = New System.Windows.Forms.TextBox()
        Me.score2TextBox = New System.Windows.Forms.TextBox()
        Me.score4TextBox = New System.Windows.Forms.TextBox()
        Me.score5TextBox = New System.Windows.Forms.TextBox()
        Me.score3TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(45, 304)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(113, 54)
        Me.calculateButton.TabIndex = 10
        Me.calculateButton.Text = "&Caculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(190, 304)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(113, 54)
        Me.clearButton.TabIndex = 11
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(335, 304)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(113, 54)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'score1Label
        '
        Me.score1Label.AutoSize = True
        Me.score1Label.Location = New System.Drawing.Point(41, 43)
        Me.score1Label.Name = "score1Label"
        Me.score1Label.Size = New System.Drawing.Size(103, 20)
        Me.score1Label.TabIndex = 0
        Me.score1Label.Text = "Test Score 1:"
        '
        'score2Label
        '
        Me.score2Label.AutoSize = True
        Me.score2Label.Location = New System.Drawing.Point(41, 75)
        Me.score2Label.Name = "score2Label"
        Me.score2Label.Size = New System.Drawing.Size(103, 20)
        Me.score2Label.TabIndex = 2
        Me.score2Label.Text = "Test Score 2:"
        '
        'score3Label
        '
        Me.score3Label.AutoSize = True
        Me.score3Label.Location = New System.Drawing.Point(41, 111)
        Me.score3Label.Name = "score3Label"
        Me.score3Label.Size = New System.Drawing.Size(103, 20)
        Me.score3Label.TabIndex = 4
        Me.score3Label.Text = "Test Score 3:"
        '
        'score4Label
        '
        Me.score4Label.AutoSize = True
        Me.score4Label.Location = New System.Drawing.Point(41, 149)
        Me.score4Label.Name = "score4Label"
        Me.score4Label.Size = New System.Drawing.Size(103, 20)
        Me.score4Label.TabIndex = 6
        Me.score4Label.Text = "Test Score 4:"
        '
        'score5Label
        '
        Me.score5Label.AutoSize = True
        Me.score5Label.Location = New System.Drawing.Point(41, 186)
        Me.score5Label.Name = "score5Label"
        Me.score5Label.Size = New System.Drawing.Size(103, 20)
        Me.score5Label.TabIndex = 8
        Me.score5Label.Text = "Test Score 5:"
        '
        'averageLabel
        '
        Me.averageLabel.AutoSize = True
        Me.averageLabel.Location = New System.Drawing.Point(41, 229)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(76, 20)
        Me.averageLabel.TabIndex = 1
        Me.averageLabel.Text = "Average: "
        '
        'displayAverageLabel
        '
        Me.displayAverageLabel.BackColor = System.Drawing.Color.White
        Me.displayAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.displayAverageLabel.Location = New System.Drawing.Point(173, 229)
        Me.displayAverageLabel.Name = "displayAverageLabel"
        Me.displayAverageLabel.Size = New System.Drawing.Size(74, 20)
        Me.displayAverageLabel.TabIndex = 1
        Me.displayAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'score1TextBox
        '
        Me.score1TextBox.Location = New System.Drawing.Point(173, 40)
        Me.score1TextBox.Name = "score1TextBox"
        Me.score1TextBox.Size = New System.Drawing.Size(74, 26)
        Me.score1TextBox.TabIndex = 1
        Me.score1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'score2TextBox
        '
        Me.score2TextBox.Location = New System.Drawing.Point(173, 72)
        Me.score2TextBox.Name = "score2TextBox"
        Me.score2TextBox.Size = New System.Drawing.Size(74, 26)
        Me.score2TextBox.TabIndex = 3
        Me.score2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'score4TextBox
        '
        Me.score4TextBox.Location = New System.Drawing.Point(173, 146)
        Me.score4TextBox.Name = "score4TextBox"
        Me.score4TextBox.Size = New System.Drawing.Size(74, 26)
        Me.score4TextBox.TabIndex = 7
        Me.score4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'score5TextBox
        '
        Me.score5TextBox.Location = New System.Drawing.Point(173, 183)
        Me.score5TextBox.Name = "score5TextBox"
        Me.score5TextBox.Size = New System.Drawing.Size(74, 26)
        Me.score5TextBox.TabIndex = 9
        Me.score5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'score3TextBox
        '
        Me.score3TextBox.Location = New System.Drawing.Point(173, 108)
        Me.score3TextBox.Name = "score3TextBox"
        Me.score3TextBox.Size = New System.Drawing.Size(74, 26)
        Me.score3TextBox.TabIndex = 5
        Me.score3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 435)
        Me.Controls.Add(Me.score5TextBox)
        Me.Controls.Add(Me.score3TextBox)
        Me.Controls.Add(Me.score4TextBox)
        Me.Controls.Add(Me.score2TextBox)
        Me.Controls.Add(Me.score1TextBox)
        Me.Controls.Add(Me.displayAverageLabel)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.score5Label)
        Me.Controls.Add(Me.score4Label)
        Me.Controls.Add(Me.score3Label)
        Me.Controls.Add(Me.score2Label)
        Me.Controls.Add(Me.score1Label)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Test Score Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents score1Label As System.Windows.Forms.Label
    Friend WithEvents score2Label As System.Windows.Forms.Label
    Friend WithEvents score3Label As System.Windows.Forms.Label
    Friend WithEvents score4Label As System.Windows.Forms.Label
    Friend WithEvents score5Label As System.Windows.Forms.Label
    Friend WithEvents averageLabel As System.Windows.Forms.Label
    Friend WithEvents displayAverageLabel As System.Windows.Forms.Label
    Friend WithEvents score1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents score2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents score4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents score5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents score3TextBox As System.Windows.Forms.TextBox

End Class
