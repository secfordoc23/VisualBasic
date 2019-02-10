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
        Me.packageGroupBox = New System.Windows.Forms.GroupBox()
        Me.packageARadioButton = New System.Windows.Forms.RadioButton()
        Me.packageBRadioButton = New System.Windows.Forms.RadioButton()
        Me.packageCRadioButton = New System.Windows.Forms.RadioButton()
        Me.hoursLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.hoursUsedTextBox = New System.Windows.Forms.TextBox()
        Me.nonProfitCheckBox = New System.Windows.Forms.CheckBox()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.packageGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'packageGroupBox
        '
        Me.packageGroupBox.Controls.Add(Me.packageARadioButton)
        Me.packageGroupBox.Controls.Add(Me.packageBRadioButton)
        Me.packageGroupBox.Controls.Add(Me.packageCRadioButton)
        Me.packageGroupBox.Location = New System.Drawing.Point(26, 31)
        Me.packageGroupBox.Name = "packageGroupBox"
        Me.packageGroupBox.Size = New System.Drawing.Size(212, 196)
        Me.packageGroupBox.TabIndex = 0
        Me.packageGroupBox.TabStop = False
        Me.packageGroupBox.Text = "&Package"
        '
        'packageARadioButton
        '
        Me.packageARadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.packageARadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packageARadioButton.Location = New System.Drawing.Point(29, 25)
        Me.packageARadioButton.Name = "packageARadioButton"
        Me.packageARadioButton.Size = New System.Drawing.Size(147, 44)
        Me.packageARadioButton.TabIndex = 0
        Me.packageARadioButton.TabStop = True
        Me.packageARadioButton.Text = "Package &A"
        Me.packageARadioButton.UseVisualStyleBackColor = True
        '
        'packageBRadioButton
        '
        Me.packageBRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.packageBRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packageBRadioButton.Location = New System.Drawing.Point(29, 75)
        Me.packageBRadioButton.Name = "packageBRadioButton"
        Me.packageBRadioButton.Size = New System.Drawing.Size(147, 44)
        Me.packageBRadioButton.TabIndex = 1
        Me.packageBRadioButton.TabStop = True
        Me.packageBRadioButton.Text = "Package &B"
        Me.packageBRadioButton.UseVisualStyleBackColor = True
        '
        'packageCRadioButton
        '
        Me.packageCRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.packageCRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packageCRadioButton.Location = New System.Drawing.Point(29, 125)
        Me.packageCRadioButton.Name = "packageCRadioButton"
        Me.packageCRadioButton.Size = New System.Drawing.Size(147, 40)
        Me.packageCRadioButton.TabIndex = 2
        Me.packageCRadioButton.TabStop = True
        Me.packageCRadioButton.Text = "&Package C"
        Me.packageCRadioButton.UseVisualStyleBackColor = True
        '
        'hoursLabel
        '
        Me.hoursLabel.AutoSize = True
        Me.hoursLabel.Location = New System.Drawing.Point(244, 121)
        Me.hoursLabel.Name = "hoursLabel"
        Me.hoursLabel.Size = New System.Drawing.Size(250, 20)
        Me.hoursLabel.TabIndex = 2
        Me.hoursLabel.Text = "Enter the Number of Hours Used: "
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(354, 269)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(228, 269)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(102, 269)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'hoursUsedTextBox
        '
        Me.hoursUsedTextBox.Location = New System.Drawing.Point(500, 118)
        Me.hoursUsedTextBox.Name = "hoursUsedTextBox"
        Me.hoursUsedTextBox.Size = New System.Drawing.Size(106, 26)
        Me.hoursUsedTextBox.TabIndex = 3
        Me.hoursUsedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nonProfitCheckBox
        '
        Me.nonProfitCheckBox.AutoSize = True
        Me.nonProfitCheckBox.Location = New System.Drawing.Point(248, 76)
        Me.nonProfitCheckBox.Name = "nonProfitCheckBox"
        Me.nonProfitCheckBox.Size = New System.Drawing.Size(182, 24)
        Me.nonProfitCheckBox.TabIndex = 1
        Me.nonProfitCheckBox.Text = "NonProfit Orginization"
        Me.nonProfitCheckBox.UseVisualStyleBackColor = True
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Location = New System.Drawing.Point(244, 169)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(103, 20)
        Me.AmountDueLabel.TabIndex = 12
        Me.AmountDueLabel.Text = "Amount Due:"
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.White
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(353, 169)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(96, 20)
        Me.totalLabel.TabIndex = 12
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 345)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.AmountDueLabel)
        Me.Controls.Add(Me.nonProfitCheckBox)
        Me.Controls.Add(Me.hoursUsedTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.hoursLabel)
        Me.Controls.Add(Me.packageGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Internet Service Provider"
        Me.packageGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents packageGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents packageARadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents packageBRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents packageCRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hoursLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents hoursUsedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nonProfitCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AmountDueLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label

End Class
