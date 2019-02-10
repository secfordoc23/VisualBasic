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
        Me.rateCategoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.daytimeRadioButton = New System.Windows.Forms.RadioButton()
        Me.eveningRadioButton = New System.Windows.Forms.RadioButton()
        Me.offPeakRadioButton = New System.Windows.Forms.RadioButton()
        Me.minutesUsedLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.minutesTextBox = New System.Windows.Forms.TextBox()
        Me.totalChargesLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.rateCategoryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'rateCategoryGroupBox
        '
        Me.rateCategoryGroupBox.Controls.Add(Me.daytimeRadioButton)
        Me.rateCategoryGroupBox.Controls.Add(Me.eveningRadioButton)
        Me.rateCategoryGroupBox.Controls.Add(Me.offPeakRadioButton)
        Me.rateCategoryGroupBox.Location = New System.Drawing.Point(18, 18)
        Me.rateCategoryGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rateCategoryGroupBox.Name = "rateCategoryGroupBox"
        Me.rateCategoryGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rateCategoryGroupBox.Size = New System.Drawing.Size(367, 285)
        Me.rateCategoryGroupBox.TabIndex = 0
        Me.rateCategoryGroupBox.TabStop = False
        Me.rateCategoryGroupBox.Text = "&Rate Category"
        '
        'daytimeRadioButton
        '
        Me.daytimeRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.daytimeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daytimeRadioButton.Location = New System.Drawing.Point(44, 38)
        Me.daytimeRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.daytimeRadioButton.Name = "daytimeRadioButton"
        Me.daytimeRadioButton.Size = New System.Drawing.Size(282, 68)
        Me.daytimeRadioButton.TabIndex = 0
        Me.daytimeRadioButton.TabStop = True
        Me.daytimeRadioButton.Text = "&Daytime 6am - 5:59pm"
        Me.daytimeRadioButton.UseVisualStyleBackColor = True
        '
        'eveningRadioButton
        '
        Me.eveningRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.eveningRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eveningRadioButton.Location = New System.Drawing.Point(44, 115)
        Me.eveningRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eveningRadioButton.Name = "eveningRadioButton"
        Me.eveningRadioButton.Size = New System.Drawing.Size(282, 68)
        Me.eveningRadioButton.TabIndex = 1
        Me.eveningRadioButton.TabStop = True
        Me.eveningRadioButton.Text = "&Evening 6pm - 11:59pm"
        Me.eveningRadioButton.UseVisualStyleBackColor = True
        '
        'offPeakRadioButton
        '
        Me.offPeakRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.offPeakRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offPeakRadioButton.Location = New System.Drawing.Point(44, 192)
        Me.offPeakRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.offPeakRadioButton.Name = "offPeakRadioButton"
        Me.offPeakRadioButton.Size = New System.Drawing.Size(282, 62)
        Me.offPeakRadioButton.TabIndex = 2
        Me.offPeakRadioButton.TabStop = True
        Me.offPeakRadioButton.Text = "&Off-Peak 12am - 5:59am"
        Me.offPeakRadioButton.UseVisualStyleBackColor = True
        '
        'minutesUsedLabel
        '
        Me.minutesUsedLabel.AutoSize = True
        Me.minutesUsedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutesUsedLabel.Location = New System.Drawing.Point(400, 56)
        Me.minutesUsedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.minutesUsedLabel.Name = "minutesUsedLabel"
        Me.minutesUsedLabel.Size = New System.Drawing.Size(282, 20)
        Me.minutesUsedLabel.TabIndex = 1
        Me.minutesUsedLabel.Text = "Enter the number of minutes for a call: "
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(656, 248)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(530, 248)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(404, 248)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 3
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'minutesTextBox
        '
        Me.minutesTextBox.Location = New System.Drawing.Point(689, 53)
        Me.minutesTextBox.Name = "minutesTextBox"
        Me.minutesTextBox.Size = New System.Drawing.Size(100, 26)
        Me.minutesTextBox.TabIndex = 2
        Me.minutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalChargesLabel
        '
        Me.totalChargesLabel.AutoSize = True
        Me.totalChargesLabel.Location = New System.Drawing.Point(404, 110)
        Me.totalChargesLabel.Name = "totalChargesLabel"
        Me.totalChargesLabel.Size = New System.Drawing.Size(199, 20)
        Me.totalChargesLabel.TabIndex = 15
        Me.totalChargesLabel.Text = "Charges for minutes used: "
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.White
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(613, 110)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(79, 20)
        Me.totalLabel.TabIndex = 16
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 324)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.totalChargesLabel)
        Me.Controls.Add(Me.minutesTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.minutesUsedLabel)
        Me.Controls.Add(Me.rateCategoryGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Long Distance Calls"
        Me.rateCategoryGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rateCategoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents daytimeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents eveningRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents offPeakRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents minutesUsedLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents minutesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalChargesLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label

End Class
