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
        Me.coffeeRadioButton = New System.Windows.Forms.RadioButton()
        Me.teaRadioButton = New System.Windows.Forms.RadioButton()
        Me.sodaRadioButton = New System.Windows.Forms.RadioButton()
        Me.mochaRadioButton = New System.Windows.Forms.RadioButton()
        Me.whipRadioButton = New System.Windows.Forms.RadioButton()
        Me.amerettoRadioButton = New System.Windows.Forms.RadioButton()
        Me.drinkGroupBox = New System.Windows.Forms.GroupBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.orderLabel = New System.Windows.Forms.Label()
        Me.drinkGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'coffeeRadioButton
        '
        Me.coffeeRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.coffeeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coffeeRadioButton.Location = New System.Drawing.Point(29, 25)
        Me.coffeeRadioButton.Name = "coffeeRadioButton"
        Me.coffeeRadioButton.Size = New System.Drawing.Size(102, 33)
        Me.coffeeRadioButton.TabIndex = 0
        Me.coffeeRadioButton.TabStop = True
        Me.coffeeRadioButton.Text = "Co&ffee"
        Me.coffeeRadioButton.UseVisualStyleBackColor = True
        '
        'teaRadioButton
        '
        Me.teaRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.teaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teaRadioButton.Location = New System.Drawing.Point(29, 64)
        Me.teaRadioButton.Name = "teaRadioButton"
        Me.teaRadioButton.Size = New System.Drawing.Size(102, 33)
        Me.teaRadioButton.TabIndex = 1
        Me.teaRadioButton.TabStop = True
        Me.teaRadioButton.Text = "&Tea"
        Me.teaRadioButton.UseVisualStyleBackColor = True
        '
        'sodaRadioButton
        '
        Me.sodaRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.sodaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sodaRadioButton.Location = New System.Drawing.Point(29, 103)
        Me.sodaRadioButton.Name = "sodaRadioButton"
        Me.sodaRadioButton.Size = New System.Drawing.Size(102, 33)
        Me.sodaRadioButton.TabIndex = 2
        Me.sodaRadioButton.TabStop = True
        Me.sodaRadioButton.Text = "&Soda"
        Me.sodaRadioButton.UseVisualStyleBackColor = True
        '
        'mochaRadioButton
        '
        Me.mochaRadioButton.AutoSize = True
        Me.mochaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mochaRadioButton.Location = New System.Drawing.Point(217, 41)
        Me.mochaRadioButton.Name = "mochaRadioButton"
        Me.mochaRadioButton.Size = New System.Drawing.Size(103, 33)
        Me.mochaRadioButton.TabIndex = 1
        Me.mochaRadioButton.TabStop = True
        Me.mochaRadioButton.Text = "&Mocha"
        Me.mochaRadioButton.UseVisualStyleBackColor = True
        '
        'whipRadioButton
        '
        Me.whipRadioButton.AutoSize = True
        Me.whipRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whipRadioButton.Location = New System.Drawing.Point(217, 80)
        Me.whipRadioButton.Name = "whipRadioButton"
        Me.whipRadioButton.Size = New System.Drawing.Size(164, 33)
        Me.whipRadioButton.TabIndex = 2
        Me.whipRadioButton.TabStop = True
        Me.whipRadioButton.Text = "&Whip Cream"
        Me.whipRadioButton.UseVisualStyleBackColor = True
        '
        'amerettoRadioButton
        '
        Me.amerettoRadioButton.AutoSize = True
        Me.amerettoRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amerettoRadioButton.Location = New System.Drawing.Point(217, 119)
        Me.amerettoRadioButton.Name = "amerettoRadioButton"
        Me.amerettoRadioButton.Size = New System.Drawing.Size(128, 33)
        Me.amerettoRadioButton.TabIndex = 3
        Me.amerettoRadioButton.TabStop = True
        Me.amerettoRadioButton.Text = "&Ameretto"
        Me.amerettoRadioButton.UseVisualStyleBackColor = True
        '
        'drinkGroupBox
        '
        Me.drinkGroupBox.Controls.Add(Me.coffeeRadioButton)
        Me.drinkGroupBox.Controls.Add(Me.teaRadioButton)
        Me.drinkGroupBox.Controls.Add(Me.sodaRadioButton)
        Me.drinkGroupBox.Location = New System.Drawing.Point(30, 16)
        Me.drinkGroupBox.Name = "drinkGroupBox"
        Me.drinkGroupBox.Size = New System.Drawing.Size(162, 157)
        Me.drinkGroupBox.TabIndex = 0
        Me.drinkGroupBox.TabStop = False
        Me.drinkGroupBox.Text = "&Drink"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(30, 280)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(156, 280)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(282, 280)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'orderLabel
        '
        Me.orderLabel.BackColor = System.Drawing.Color.White
        Me.orderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.orderLabel.Location = New System.Drawing.Point(30, 212)
        Me.orderLabel.Name = "orderLabel"
        Me.orderLabel.Size = New System.Drawing.Size(372, 31)
        Me.orderLabel.TabIndex = 3
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(436, 362)
        Me.Controls.Add(Me.orderLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.drinkGroupBox)
        Me.Controls.Add(Me.amerettoRadioButton)
        Me.Controls.Add(Me.whipRadioButton)
        Me.Controls.Add(Me.mochaRadioButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Java Jason's"
        Me.drinkGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents coffeeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents teaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sodaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents mochaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents whipRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents amerettoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents drinkGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents orderLabel As System.Windows.Forms.Label

End Class
