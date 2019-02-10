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
        Me.totalRainLabel = New System.Windows.Forms.Label()
        Me.totalRainfallLabel = New System.Windows.Forms.Label()
        Me.averageRainfallLabel = New System.Windows.Forms.Label()
        Me.avgRainLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(284, 173)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(158, 173)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(32, 173)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 1
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'totalRainLabel
        '
        Me.totalRainLabel.BackColor = System.Drawing.Color.White
        Me.totalRainLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalRainLabel.Location = New System.Drawing.Point(158, 72)
        Me.totalRainLabel.Name = "totalRainLabel"
        Me.totalRainLabel.Size = New System.Drawing.Size(79, 20)
        Me.totalRainLabel.TabIndex = 19
        Me.totalRainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalRainfallLabel
        '
        Me.totalRainfallLabel.AutoSize = True
        Me.totalRainfallLabel.Location = New System.Drawing.Point(23, 72)
        Me.totalRainfallLabel.Name = "totalRainfallLabel"
        Me.totalRainfallLabel.Size = New System.Drawing.Size(105, 20)
        Me.totalRainfallLabel.TabIndex = 18
        Me.totalRainfallLabel.Text = "Total Rainfall:"
        '
        'averageRainfallLabel
        '
        Me.averageRainfallLabel.AutoSize = True
        Me.averageRainfallLabel.Location = New System.Drawing.Point(23, 116)
        Me.averageRainfallLabel.Name = "averageRainfallLabel"
        Me.averageRainfallLabel.Size = New System.Drawing.Size(129, 20)
        Me.averageRainfallLabel.TabIndex = 18
        Me.averageRainfallLabel.Text = "Average Rainfall:"
        '
        'avgRainLabel
        '
        Me.avgRainLabel.BackColor = System.Drawing.Color.White
        Me.avgRainLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avgRainLabel.Location = New System.Drawing.Point(158, 116)
        Me.avgRainLabel.Name = "avgRainLabel"
        Me.avgRainLabel.Size = New System.Drawing.Size(79, 20)
        Me.avgRainLabel.TabIndex = 19
        Me.avgRainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 255)
        Me.Controls.Add(Me.avgRainLabel)
        Me.Controls.Add(Me.totalRainLabel)
        Me.Controls.Add(Me.averageRainfallLabel)
        Me.Controls.Add(Me.totalRainfallLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Rainfall Statistics Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents totalRainLabel As System.Windows.Forms.Label
    Friend WithEvents totalRainfallLabel As System.Windows.Forms.Label
    Friend WithEvents averageRainfallLabel As System.Windows.Forms.Label
    Friend WithEvents avgRainLabel As System.Windows.Forms.Label

End Class
