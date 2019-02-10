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
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.numOneTextBox = New System.Windows.Forms.TextBox()
        Me.numTwoTextBox = New System.Windows.Forms.TextBox()
        Me.displayListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(14, 150)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(102, 40)
        Me.calculateButton.TabIndex = 0
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'numOneTextBox
        '
        Me.numOneTextBox.Location = New System.Drawing.Point(14, 12)
        Me.numOneTextBox.Name = "numOneTextBox"
        Me.numOneTextBox.Size = New System.Drawing.Size(100, 26)
        Me.numOneTextBox.TabIndex = 1
        Me.numOneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numTwoTextBox
        '
        Me.numTwoTextBox.Location = New System.Drawing.Point(14, 44)
        Me.numTwoTextBox.Name = "numTwoTextBox"
        Me.numTwoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.numTwoTextBox.TabIndex = 1
        Me.numTwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'displayListBox
        '
        Me.displayListBox.FormattingEnabled = True
        Me.displayListBox.ItemHeight = 20
        Me.displayListBox.Location = New System.Drawing.Point(142, 12)
        Me.displayListBox.Name = "displayListBox"
        Me.displayListBox.Size = New System.Drawing.Size(252, 124)
        Me.displayListBox.TabIndex = 2
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 202)
        Me.Controls.Add(Me.displayListBox)
        Me.Controls.Add(Me.numTwoTextBox)
        Me.Controls.Add(Me.numOneTextBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Procedures and Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents numOneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents numTwoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayListBox As System.Windows.Forms.ListBox

End Class
