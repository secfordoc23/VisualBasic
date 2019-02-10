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
        Me.displayLabel = New System.Windows.Forms.Label()
        Me.virginiaButton = New System.Windows.Forms.Button()
        Me.northCarolinaButton = New System.Windows.Forms.Button()
        Me.southCarolinaButton = New System.Windows.Forms.Button()
        Me.georgiaButton = New System.Windows.Forms.Button()
        Me.alabamaButton = New System.Windows.Forms.Button()
        Me.floridaButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'displayLabel
        '
        Me.displayLabel.BackColor = System.Drawing.Color.White
        Me.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayLabel.Location = New System.Drawing.Point(248, 208)
        Me.displayLabel.Name = "displayLabel"
        Me.displayLabel.Size = New System.Drawing.Size(96, 52)
        Me.displayLabel.TabIndex = 0
        Me.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'virginiaButton
        '
        Me.virginiaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virginiaButton.Location = New System.Drawing.Point(12, 30)
        Me.virginiaButton.Name = "virginiaButton"
        Me.virginiaButton.Size = New System.Drawing.Size(146, 65)
        Me.virginiaButton.TabIndex = 1
        Me.virginiaButton.Text = "Virginia"
        Me.virginiaButton.UseVisualStyleBackColor = True
        '
        'northCarolinaButton
        '
        Me.northCarolinaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.northCarolinaButton.Location = New System.Drawing.Point(12, 101)
        Me.northCarolinaButton.Name = "northCarolinaButton"
        Me.northCarolinaButton.Size = New System.Drawing.Size(146, 65)
        Me.northCarolinaButton.TabIndex = 2
        Me.northCarolinaButton.Text = "North Carolina"
        Me.northCarolinaButton.UseVisualStyleBackColor = True
        '
        'southCarolinaButton
        '
        Me.southCarolinaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.southCarolinaButton.Location = New System.Drawing.Point(12, 172)
        Me.southCarolinaButton.Name = "southCarolinaButton"
        Me.southCarolinaButton.Size = New System.Drawing.Size(146, 65)
        Me.southCarolinaButton.TabIndex = 3
        Me.southCarolinaButton.Text = "South Carolina"
        Me.southCarolinaButton.UseVisualStyleBackColor = True
        '
        'georgiaButton
        '
        Me.georgiaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.georgiaButton.Location = New System.Drawing.Point(12, 243)
        Me.georgiaButton.Name = "georgiaButton"
        Me.georgiaButton.Size = New System.Drawing.Size(146, 65)
        Me.georgiaButton.TabIndex = 4
        Me.georgiaButton.Text = "Georgia"
        Me.georgiaButton.UseVisualStyleBackColor = True
        '
        'alabamaButton
        '
        Me.alabamaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alabamaButton.Location = New System.Drawing.Point(12, 314)
        Me.alabamaButton.Name = "alabamaButton"
        Me.alabamaButton.Size = New System.Drawing.Size(146, 65)
        Me.alabamaButton.TabIndex = 5
        Me.alabamaButton.Text = "Alabama"
        Me.alabamaButton.UseVisualStyleBackColor = True
        '
        'floridaButton
        '
        Me.floridaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.floridaButton.Location = New System.Drawing.Point(12, 385)
        Me.floridaButton.Name = "floridaButton"
        Me.floridaButton.Size = New System.Drawing.Size(146, 65)
        Me.floridaButton.TabIndex = 6
        Me.floridaButton.Text = "Florida"
        Me.floridaButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(294, 482)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(146, 65)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 559)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.floridaButton)
        Me.Controls.Add(Me.alabamaButton)
        Me.Controls.Add(Me.georgiaButton)
        Me.Controls.Add(Me.southCarolinaButton)
        Me.Controls.Add(Me.northCarolinaButton)
        Me.Controls.Add(Me.virginiaButton)
        Me.Controls.Add(Me.displayLabel)
        Me.Name = "mainForm"
        Me.Text = "State Abbriviations"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents displayLabel As System.Windows.Forms.Label
    Friend WithEvents virginiaButton As System.Windows.Forms.Button
    Friend WithEvents northCarolinaButton As System.Windows.Forms.Button
    Friend WithEvents southCarolinaButton As System.Windows.Forms.Button
    Friend WithEvents georgiaButton As System.Windows.Forms.Button
    Friend WithEvents alabamaButton As System.Windows.Forms.Button
    Friend WithEvents floridaButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
