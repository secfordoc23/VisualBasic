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
        Me.numPenniesComboBox = New System.Windows.Forms.ComboBox()
        Me.numDaysComboBox = New System.Windows.Forms.ComboBox()
        Me.displayListBox = New System.Windows.Forms.ListBox()
        Me.numberOfDaysLabel = New System.Windows.Forms.Label()
        Me.penniesPerDayLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.displayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'numPenniesComboBox
        '
        Me.numPenniesComboBox.FormattingEnabled = True
        Me.numPenniesComboBox.Location = New System.Drawing.Point(12, 51)
        Me.numPenniesComboBox.Name = "numPenniesComboBox"
        Me.numPenniesComboBox.Size = New System.Drawing.Size(121, 28)
        Me.numPenniesComboBox.TabIndex = 0
        '
        'numDaysComboBox
        '
        Me.numDaysComboBox.FormattingEnabled = True
        Me.numDaysComboBox.Location = New System.Drawing.Point(12, 117)
        Me.numDaysComboBox.Name = "numDaysComboBox"
        Me.numDaysComboBox.Size = New System.Drawing.Size(121, 28)
        Me.numDaysComboBox.TabIndex = 1
        '
        'displayListBox
        '
        Me.displayListBox.FormattingEnabled = True
        Me.displayListBox.ItemHeight = 20
        Me.displayListBox.Location = New System.Drawing.Point(26, 186)
        Me.displayListBox.Name = "displayListBox"
        Me.displayListBox.Size = New System.Drawing.Size(344, 244)
        Me.displayListBox.TabIndex = 2
        '
        'numberOfDaysLabel
        '
        Me.numberOfDaysLabel.AutoSize = True
        Me.numberOfDaysLabel.Location = New System.Drawing.Point(8, 94)
        Me.numberOfDaysLabel.Name = "numberOfDaysLabel"
        Me.numberOfDaysLabel.Size = New System.Drawing.Size(264, 20)
        Me.numberOfDaysLabel.TabIndex = 3
        Me.numberOfDaysLabel.Text = "Select the number of Days Worked: "
        '
        'penniesPerDayLabel
        '
        Me.penniesPerDayLabel.AutoSize = True
        Me.penniesPerDayLabel.Location = New System.Drawing.Point(8, 28)
        Me.penniesPerDayLabel.Name = "penniesPerDayLabel"
        Me.penniesPerDayLabel.Size = New System.Drawing.Size(257, 20)
        Me.penniesPerDayLabel.TabIndex = 3
        Me.penniesPerDayLabel.Text = "Select Number of Pennies per day: "
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(261, 449)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(135, 449)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(9, 449)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'displayLabel
        '
        Me.displayLabel.AutoSize = True
        Me.displayLabel.Location = New System.Drawing.Point(22, 163)
        Me.displayLabel.Name = "displayLabel"
        Me.displayLabel.Size = New System.Drawing.Size(129, 20)
        Me.displayLabel.TabIndex = 10
        Me.displayLabel.Text = "Amount Per Day:"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 535)
        Me.Controls.Add(Me.displayLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.penniesPerDayLabel)
        Me.Controls.Add(Me.numberOfDaysLabel)
        Me.Controls.Add(Me.displayListBox)
        Me.Controls.Add(Me.numDaysComboBox)
        Me.Controls.Add(Me.numPenniesComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Pennies for Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numPenniesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents numDaysComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents displayListBox As System.Windows.Forms.ListBox
    Friend WithEvents numberOfDaysLabel As System.Windows.Forms.Label
    Friend WithEvents penniesPerDayLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents displayLabel As System.Windows.Forms.Label

End Class
