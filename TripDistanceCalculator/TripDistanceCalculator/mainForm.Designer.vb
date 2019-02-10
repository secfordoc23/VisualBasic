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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.milesPerHourLabel = New System.Windows.Forms.Label()
        Me.lengthOfTimeLabel = New System.Windows.Forms.Label()
        Me.speedTextBox = New System.Windows.Forms.TextBox()
        Me.totalTimeTextBox = New System.Windows.Forms.TextBox()
        Me.distanceListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(278, 454)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(152, 454)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(26, 454)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'milesPerHourLabel
        '
        Me.milesPerHourLabel.AutoSize = True
        Me.milesPerHourLabel.Location = New System.Drawing.Point(13, 30)
        Me.milesPerHourLabel.Name = "milesPerHourLabel"
        Me.milesPerHourLabel.Size = New System.Drawing.Size(247, 20)
        Me.milesPerHourLabel.TabIndex = 0
        Me.milesPerHourLabel.Text = "Enter the average speed in MPH: "
        '
        'lengthOfTimeLabel
        '
        Me.lengthOfTimeLabel.AutoSize = True
        Me.lengthOfTimeLabel.Location = New System.Drawing.Point(13, 65)
        Me.lengthOfTimeLabel.Name = "lengthOfTimeLabel"
        Me.lengthOfTimeLabel.Size = New System.Drawing.Size(330, 20)
        Me.lengthOfTimeLabel.TabIndex = 2
        Me.lengthOfTimeLabel.Text = "Enter in the total number of hours for the trip: "
        '
        'speedTextBox
        '
        Me.speedTextBox.Location = New System.Drawing.Point(342, 27)
        Me.speedTextBox.Name = "speedTextBox"
        Me.speedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.speedTextBox.TabIndex = 1
        Me.speedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalTimeTextBox
        '
        Me.totalTimeTextBox.Location = New System.Drawing.Point(342, 62)
        Me.totalTimeTextBox.Name = "totalTimeTextBox"
        Me.totalTimeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.totalTimeTextBox.TabIndex = 3
        Me.totalTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'distanceListBox
        '
        Me.distanceListBox.FormattingEnabled = True
        Me.distanceListBox.ItemHeight = 20
        Me.distanceListBox.Location = New System.Drawing.Point(17, 109)
        Me.distanceListBox.Name = "distanceListBox"
        Me.distanceListBox.Size = New System.Drawing.Size(255, 324)
        Me.distanceListBox.TabIndex = 11
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 521)
        Me.Controls.Add(Me.distanceListBox)
        Me.Controls.Add(Me.totalTimeTextBox)
        Me.Controls.Add(Me.speedTextBox)
        Me.Controls.Add(Me.lengthOfTimeLabel)
        Me.Controls.Add(Me.milesPerHourLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Trip Distance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents milesPerHourLabel As System.Windows.Forms.Label
    Friend WithEvents lengthOfTimeLabel As System.Windows.Forms.Label
    Friend WithEvents speedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents distanceListBox As System.Windows.Forms.ListBox

End Class
