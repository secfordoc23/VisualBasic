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
        Me.numberOfBooksPurchasedLabel = New System.Windows.Forms.Label()
        Me.totalPointsLabel = New System.Windows.Forms.Label()
        Me.numBooksTextBox = New System.Windows.Forms.TextBox()
        Me.totalPointsEarnedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(275, 319)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(149, 319)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(23, 319)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'numberOfBooksPurchasedLabel
        '
        Me.numberOfBooksPurchasedLabel.AutoSize = True
        Me.numberOfBooksPurchasedLabel.Location = New System.Drawing.Point(19, 68)
        Me.numberOfBooksPurchasedLabel.Name = "numberOfBooksPurchasedLabel"
        Me.numberOfBooksPurchasedLabel.Size = New System.Drawing.Size(329, 20)
        Me.numberOfBooksPurchasedLabel.TabIndex = 0
        Me.numberOfBooksPurchasedLabel.Text = "Enter the Total Number of Books Purchased: "
        '
        'totalPointsLabel
        '
        Me.totalPointsLabel.BackColor = System.Drawing.Color.White
        Me.totalPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalPointsLabel.Location = New System.Drawing.Point(257, 122)
        Me.totalPointsLabel.Name = "totalPointsLabel"
        Me.totalPointsLabel.Size = New System.Drawing.Size(79, 20)
        Me.totalPointsLabel.TabIndex = 17
        Me.totalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'numBooksTextBox
        '
        Me.numBooksTextBox.Location = New System.Drawing.Point(354, 65)
        Me.numBooksTextBox.Name = "numBooksTextBox"
        Me.numBooksTextBox.Size = New System.Drawing.Size(79, 26)
        Me.numBooksTextBox.TabIndex = 1
        Me.numBooksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalPointsEarnedLabel
        '
        Me.totalPointsEarnedLabel.AutoSize = True
        Me.totalPointsEarnedLabel.Location = New System.Drawing.Point(19, 122)
        Me.totalPointsEarnedLabel.Name = "totalPointsEarnedLabel"
        Me.totalPointsEarnedLabel.Size = New System.Drawing.Size(232, 20)
        Me.totalPointsEarnedLabel.TabIndex = 9
        Me.totalPointsEarnedLabel.Text = "Your total book club points are: "
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 403)
        Me.Controls.Add(Me.numBooksTextBox)
        Me.Controls.Add(Me.totalPointsLabel)
        Me.Controls.Add(Me.totalPointsEarnedLabel)
        Me.Controls.Add(Me.numberOfBooksPurchasedLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Book Club Points"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents numberOfBooksPurchasedLabel As System.Windows.Forms.Label
    Friend WithEvents totalPointsLabel As System.Windows.Forms.Label
    Friend WithEvents numBooksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalPointsEarnedLabel As System.Windows.Forms.Label

End Class
