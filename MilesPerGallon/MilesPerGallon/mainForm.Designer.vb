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
        Me.gallonsOfGasLabel = New System.Windows.Forms.Label()
        Me.gallonOfGasTextBox = New System.Windows.Forms.TextBox()
        Me.milesPerTankLabel = New System.Windows.Forms.Label()
        Me.milesPerTankTextBox = New System.Windows.Forms.TextBox()
        Me.milesPerGallonLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.mpgLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gallonsOfGasLabel
        '
        Me.gallonsOfGasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gallonsOfGasLabel.Location = New System.Drawing.Point(42, 71)
        Me.gallonsOfGasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gallonsOfGasLabel.Name = "gallonsOfGasLabel"
        Me.gallonsOfGasLabel.Size = New System.Drawing.Size(198, 44)
        Me.gallonsOfGasLabel.TabIndex = 0
        Me.gallonsOfGasLabel.Text = "Gallons of gas the car can hold: "
        '
        'gallonOfGasTextBox
        '
        Me.gallonOfGasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gallonOfGasTextBox.Location = New System.Drawing.Point(266, 89)
        Me.gallonOfGasTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gallonOfGasTextBox.Name = "gallonOfGasTextBox"
        Me.gallonOfGasTextBox.Size = New System.Drawing.Size(68, 26)
        Me.gallonOfGasTextBox.TabIndex = 1
        Me.gallonOfGasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'milesPerTankLabel
        '
        Me.milesPerTankLabel.Location = New System.Drawing.Point(42, 135)
        Me.milesPerTankLabel.Name = "milesPerTankLabel"
        Me.milesPerTankLabel.Size = New System.Drawing.Size(198, 53)
        Me.milesPerTankLabel.TabIndex = 2
        Me.milesPerTankLabel.Text = "Number of miles it can be driven on a full tank: "
        '
        'milesPerTankTextBox
        '
        Me.milesPerTankTextBox.Location = New System.Drawing.Point(266, 152)
        Me.milesPerTankTextBox.Name = "milesPerTankTextBox"
        Me.milesPerTankTextBox.Size = New System.Drawing.Size(68, 26)
        Me.milesPerTankTextBox.TabIndex = 3
        Me.milesPerTankTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'milesPerGallonLabel
        '
        Me.milesPerGallonLabel.AutoSize = True
        Me.milesPerGallonLabel.Location = New System.Drawing.Point(42, 218)
        Me.milesPerGallonLabel.Name = "milesPerGallonLabel"
        Me.milesPerGallonLabel.Size = New System.Drawing.Size(131, 20)
        Me.milesPerGallonLabel.TabIndex = 4
        Me.milesPerGallonLabel.Text = "Miles Per Gallon: "
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(43, 291)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(129, 63)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate MPG"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(178, 291)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(129, 63)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(313, 291)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(129, 63)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mpgLabel
        '
        Me.mpgLabel.BackColor = System.Drawing.Color.White
        Me.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mpgLabel.Location = New System.Drawing.Point(266, 218)
        Me.mpgLabel.Name = "mpgLabel"
        Me.mpgLabel.Size = New System.Drawing.Size(68, 21)
        Me.mpgLabel.TabIndex = 9
        Me.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 405)
        Me.Controls.Add(Me.mpgLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.milesPerGallonLabel)
        Me.Controls.Add(Me.milesPerTankTextBox)
        Me.Controls.Add(Me.milesPerTankLabel)
        Me.Controls.Add(Me.gallonOfGasTextBox)
        Me.Controls.Add(Me.gallonsOfGasLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Miles Per Gallon: "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gallonsOfGasLabel As System.Windows.Forms.Label
    Friend WithEvents gallonOfGasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents milesPerTankLabel As System.Windows.Forms.Label
    Friend WithEvents milesPerTankTextBox As System.Windows.Forms.TextBox
    Friend WithEvents milesPerGallonLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents mpgLabel As System.Windows.Forms.Label

End Class
