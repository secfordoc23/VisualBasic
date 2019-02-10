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
        Me.namesListBox = New System.Windows.Forms.ListBox()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.selectLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'namesListBox
        '
        Me.namesListBox.FormattingEnabled = True
        Me.namesListBox.ItemHeight = 20
        Me.namesListBox.Location = New System.Drawing.Point(13, 44)
        Me.namesListBox.Name = "namesListBox"
        Me.namesListBox.Size = New System.Drawing.Size(244, 124)
        Me.namesListBox.TabIndex = 1
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(12, 183)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(123, 20)
        Me.phoneLabel.TabIndex = 1
        Me.phoneLabel.Text = "Phone Number: "
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(139, 310)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.BackColor = System.Drawing.Color.White
        Me.phoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.phoneNumberLabel.Location = New System.Drawing.Point(148, 180)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(109, 27)
        Me.phoneNumberLabel.TabIndex = 42
        Me.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(139, 236)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(120, 55)
        Me.removeButton.TabIndex = 3
        Me.removeButton.Text = "&Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(13, 236)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(120, 55)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'selectLabel
        '
        Me.selectLabel.AutoSize = True
        Me.selectLabel.Location = New System.Drawing.Point(12, 21)
        Me.selectLabel.Name = "selectLabel"
        Me.selectLabel.Size = New System.Drawing.Size(117, 20)
        Me.selectLabel.TabIndex = 0
        Me.selectLabel.Text = "&Select a Name:"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 377)
        Me.Controls.Add(Me.selectLabel)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.namesListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Grandma Phone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents namesListBox As System.Windows.Forms.ListBox
    Friend WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents phoneNumberLabel As System.Windows.Forms.Label
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents selectLabel As System.Windows.Forms.Label

End Class
