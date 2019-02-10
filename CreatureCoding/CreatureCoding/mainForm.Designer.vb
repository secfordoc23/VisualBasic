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
        Me.creatureListBox = New System.Windows.Forms.ListBox()
        Me.codeLabel = New System.Windows.Forms.Label()
        Me.creatureCodeLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.creatureLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'creatureListBox
        '
        Me.creatureListBox.FormattingEnabled = True
        Me.creatureListBox.ItemHeight = 20
        Me.creatureListBox.Location = New System.Drawing.Point(15, 47)
        Me.creatureListBox.Name = "creatureListBox"
        Me.creatureListBox.Size = New System.Drawing.Size(372, 204)
        Me.creatureListBox.TabIndex = 1
        '
        'codeLabel
        '
        Me.codeLabel.BackColor = System.Drawing.Color.White
        Me.codeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.codeLabel.Location = New System.Drawing.Point(214, 289)
        Me.codeLabel.Name = "codeLabel"
        Me.codeLabel.Size = New System.Drawing.Size(77, 27)
        Me.codeLabel.TabIndex = 1
        Me.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'creatureCodeLabel
        '
        Me.creatureCodeLabel.AutoSize = True
        Me.creatureCodeLabel.Location = New System.Drawing.Point(68, 290)
        Me.creatureCodeLabel.Name = "creatureCodeLabel"
        Me.creatureCodeLabel.Size = New System.Drawing.Size(117, 20)
        Me.creatureCodeLabel.TabIndex = 2
        Me.creatureCodeLabel.Text = "Creature Code:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(267, 346)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(16, 346)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'creatureLabel
        '
        Me.creatureLabel.AutoSize = True
        Me.creatureLabel.Location = New System.Drawing.Point(12, 9)
        Me.creatureLabel.Name = "creatureLabel"
        Me.creatureLabel.Size = New System.Drawing.Size(279, 20)
        Me.creatureLabel.TabIndex = 0
        Me.creatureLabel.Text = "&Select a Creature to Display the Code:"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 417)
        Me.Controls.Add(Me.creatureLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.creatureCodeLabel)
        Me.Controls.Add(Me.codeLabel)
        Me.Controls.Add(Me.creatureListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Creature Coding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents creatureListBox As System.Windows.Forms.ListBox
    Friend WithEvents codeLabel As System.Windows.Forms.Label
    Friend WithEvents creatureCodeLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents creatureLabel As System.Windows.Forms.Label

End Class
