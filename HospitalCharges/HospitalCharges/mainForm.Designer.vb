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
        Me.hospitalInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.stayLabel = New System.Windows.Forms.Label()
        Me.medsLabel = New System.Windows.Forms.Label()
        Me.surgicalLabel = New System.Windows.Forms.Label()
        Me.labFeesLabel = New System.Windows.Forms.Label()
        Me.physicalLabel = New System.Windows.Forms.Label()
        Me.stayTextBox = New System.Windows.Forms.TextBox()
        Me.medsTextBox = New System.Windows.Forms.TextBox()
        Me.surgicalTextBox = New System.Windows.Forms.TextBox()
        Me.labFeesTextBox = New System.Windows.Forms.TextBox()
        Me.physicalTextBox = New System.Windows.Forms.TextBox()
        Me.hospitalInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'hospitalInfoGroupBox
        '
        Me.hospitalInfoGroupBox.Controls.Add(Me.physicalTextBox)
        Me.hospitalInfoGroupBox.Controls.Add(Me.labFeesTextBox)
        Me.hospitalInfoGroupBox.Controls.Add(Me.surgicalTextBox)
        Me.hospitalInfoGroupBox.Controls.Add(Me.medsTextBox)
        Me.hospitalInfoGroupBox.Controls.Add(Me.stayTextBox)
        Me.hospitalInfoGroupBox.Controls.Add(Me.physicalLabel)
        Me.hospitalInfoGroupBox.Controls.Add(Me.labFeesLabel)
        Me.hospitalInfoGroupBox.Controls.Add(Me.surgicalLabel)
        Me.hospitalInfoGroupBox.Controls.Add(Me.medsLabel)
        Me.hospitalInfoGroupBox.Controls.Add(Me.stayLabel)
        Me.hospitalInfoGroupBox.Location = New System.Drawing.Point(48, 30)
        Me.hospitalInfoGroupBox.Name = "hospitalInfoGroupBox"
        Me.hospitalInfoGroupBox.Size = New System.Drawing.Size(324, 232)
        Me.hospitalInfoGroupBox.TabIndex = 0
        Me.hospitalInfoGroupBox.TabStop = False
        Me.hospitalInfoGroupBox.Text = "Hospital Stay Information"
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.White
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(256, 277)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 20)
        Me.totalLabel.TabIndex = 3
        '
        'totalCostLabel
        '
        Me.totalCostLabel.AutoSize = True
        Me.totalCostLabel.Location = New System.Drawing.Point(85, 278)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(89, 20)
        Me.totalCostLabel.TabIndex = 2
        Me.totalCostLabel.Text = "Total Cost: "
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(278, 330)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(152, 330)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(26, 330)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 1
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'stayLabel
        '
        Me.stayLabel.AutoSize = True
        Me.stayLabel.Location = New System.Drawing.Point(37, 41)
        Me.stayLabel.Name = "stayLabel"
        Me.stayLabel.Size = New System.Drawing.Size(164, 20)
        Me.stayLabel.TabIndex = 0
        Me.stayLabel.Text = "Length of &Stay(days): "
        '
        'medsLabel
        '
        Me.medsLabel.AutoSize = True
        Me.medsLabel.Location = New System.Drawing.Point(37, 73)
        Me.medsLabel.Name = "medsLabel"
        Me.medsLabel.Size = New System.Drawing.Size(90, 20)
        Me.medsLabel.TabIndex = 2
        Me.medsLabel.Text = "&Medication:"
        '
        'surgicalLabel
        '
        Me.surgicalLabel.AutoSize = True
        Me.surgicalLabel.Location = New System.Drawing.Point(37, 108)
        Me.surgicalLabel.Name = "surgicalLabel"
        Me.surgicalLabel.Size = New System.Drawing.Size(138, 20)
        Me.surgicalLabel.TabIndex = 4
        Me.surgicalLabel.Text = "S&urgical Charges: "
        '
        'labFeesLabel
        '
        Me.labFeesLabel.AutoSize = True
        Me.labFeesLabel.Location = New System.Drawing.Point(37, 144)
        Me.labFeesLabel.Name = "labFeesLabel"
        Me.labFeesLabel.Size = New System.Drawing.Size(80, 20)
        Me.labFeesLabel.TabIndex = 6
        Me.labFeesLabel.Text = "Lab &Fees:"
        '
        'physicalLabel
        '
        Me.physicalLabel.AutoSize = True
        Me.physicalLabel.Location = New System.Drawing.Point(37, 180)
        Me.physicalLabel.Name = "physicalLabel"
        Me.physicalLabel.Size = New System.Drawing.Size(70, 20)
        Me.physicalLabel.TabIndex = 8
        Me.physicalLabel.Text = "&Physical:"
        '
        'stayTextBox
        '
        Me.stayTextBox.Location = New System.Drawing.Point(208, 40)
        Me.stayTextBox.Name = "stayTextBox"
        Me.stayTextBox.Size = New System.Drawing.Size(100, 26)
        Me.stayTextBox.TabIndex = 1
        Me.stayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'medsTextBox
        '
        Me.medsTextBox.Location = New System.Drawing.Point(208, 70)
        Me.medsTextBox.Name = "medsTextBox"
        Me.medsTextBox.Size = New System.Drawing.Size(100, 26)
        Me.medsTextBox.TabIndex = 3
        Me.medsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'surgicalTextBox
        '
        Me.surgicalTextBox.Location = New System.Drawing.Point(208, 105)
        Me.surgicalTextBox.Name = "surgicalTextBox"
        Me.surgicalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.surgicalTextBox.TabIndex = 5
        Me.surgicalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labFeesTextBox
        '
        Me.labFeesTextBox.Location = New System.Drawing.Point(208, 141)
        Me.labFeesTextBox.Name = "labFeesTextBox"
        Me.labFeesTextBox.Size = New System.Drawing.Size(100, 26)
        Me.labFeesTextBox.TabIndex = 7
        Me.labFeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'physicalTextBox
        '
        Me.physicalTextBox.Location = New System.Drawing.Point(208, 177)
        Me.physicalTextBox.Name = "physicalTextBox"
        Me.physicalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.physicalTextBox.TabIndex = 9
        Me.physicalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 424)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.hospitalInfoGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Hospital Charges"
        Me.hospitalInfoGroupBox.ResumeLayout(False)
        Me.hospitalInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hospitalInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents physicalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents labFeesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents surgicalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents medsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents physicalLabel As System.Windows.Forms.Label
    Friend WithEvents labFeesLabel As System.Windows.Forms.Label
    Friend WithEvents surgicalLabel As System.Windows.Forms.Label
    Friend WithEvents medsLabel As System.Windows.Forms.Label
    Friend WithEvents stayLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalCostLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
