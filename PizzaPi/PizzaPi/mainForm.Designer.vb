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
        Me.pizzaDiameterLabel = New System.Windows.Forms.Label()
        Me.pizzaDiameterTextBox = New System.Windows.Forms.TextBox()
        Me.numSlicesLabel = New System.Windows.Forms.Label()
        Me.displayNumberSlicesLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pizzaDiameterLabel
        '
        Me.pizzaDiameterLabel.AutoSize = True
        Me.pizzaDiameterLabel.Location = New System.Drawing.Point(28, 33)
        Me.pizzaDiameterLabel.Name = "pizzaDiameterLabel"
        Me.pizzaDiameterLabel.Size = New System.Drawing.Size(133, 20)
        Me.pizzaDiameterLabel.TabIndex = 0
        Me.pizzaDiameterLabel.Text = "Enter Pizza Size: "
        '
        'pizzaDiameterTextBox
        '
        Me.pizzaDiameterTextBox.Location = New System.Drawing.Point(167, 30)
        Me.pizzaDiameterTextBox.Name = "pizzaDiameterTextBox"
        Me.pizzaDiameterTextBox.Size = New System.Drawing.Size(100, 26)
        Me.pizzaDiameterTextBox.TabIndex = 1
        Me.pizzaDiameterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numSlicesLabel
        '
        Me.numSlicesLabel.AutoSize = True
        Me.numSlicesLabel.Location = New System.Drawing.Point(28, 107)
        Me.numSlicesLabel.Name = "numSlicesLabel"
        Me.numSlicesLabel.Size = New System.Drawing.Size(137, 20)
        Me.numSlicesLabel.TabIndex = 2
        Me.numSlicesLabel.Text = "Number of Slices: "
        '
        'displayNumberSlicesLabel
        '
        Me.displayNumberSlicesLabel.BackColor = System.Drawing.Color.White
        Me.displayNumberSlicesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.displayNumberSlicesLabel.Location = New System.Drawing.Point(167, 106)
        Me.displayNumberSlicesLabel.Name = "displayNumberSlicesLabel"
        Me.displayNumberSlicesLabel.Size = New System.Drawing.Size(100, 20)
        Me.displayNumberSlicesLabel.TabIndex = 3
        Me.displayNumberSlicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(32, 184)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(100, 35)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(167, 184)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 35)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(307, 184)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 35)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 272)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.displayNumberSlicesLabel)
        Me.Controls.Add(Me.numSlicesLabel)
        Me.Controls.Add(Me.pizzaDiameterTextBox)
        Me.Controls.Add(Me.pizzaDiameterLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Pizza Pi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pizzaDiameterLabel As System.Windows.Forms.Label
    Friend WithEvents pizzaDiameterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents numSlicesLabel As System.Windows.Forms.Label
    Friend WithEvents displayNumberSlicesLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
