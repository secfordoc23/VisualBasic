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
        Me.components = New System.ComponentModel.Container()
        Me.pressButton = New System.Windows.Forms.Button()
        Me.displayListBox = New System.Windows.Forms.ListBox()
        Me.display2ListBox = New System.Windows.Forms.ListBox()
        Me.pressMeButton = New System.Windows.Forms.Button()
        Me.statusComboBox = New System.Windows.Forms.ComboBox()
        Me.timeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pressButton
        '
        Me.pressButton.Location = New System.Drawing.Point(35, 515)
        Me.pressButton.Name = "pressButton"
        Me.pressButton.Size = New System.Drawing.Size(165, 48)
        Me.pressButton.TabIndex = 0
        Me.pressButton.Text = "&Press"
        Me.pressButton.UseVisualStyleBackColor = True
        '
        'displayListBox
        '
        Me.displayListBox.FormattingEnabled = True
        Me.displayListBox.ItemHeight = 20
        Me.displayListBox.Location = New System.Drawing.Point(35, 54)
        Me.displayListBox.Name = "displayListBox"
        Me.displayListBox.Size = New System.Drawing.Size(165, 404)
        Me.displayListBox.TabIndex = 1
        '
        'display2ListBox
        '
        Me.display2ListBox.FormattingEnabled = True
        Me.display2ListBox.ItemHeight = 20
        Me.display2ListBox.Location = New System.Drawing.Point(227, 54)
        Me.display2ListBox.Name = "display2ListBox"
        Me.display2ListBox.Size = New System.Drawing.Size(165, 404)
        Me.display2ListBox.TabIndex = 1
        '
        'pressMeButton
        '
        Me.pressMeButton.Location = New System.Drawing.Point(227, 515)
        Me.pressMeButton.Name = "pressMeButton"
        Me.pressMeButton.Size = New System.Drawing.Size(165, 48)
        Me.pressMeButton.TabIndex = 2
        Me.pressMeButton.Text = "Press &Me"
        Me.pressMeButton.UseVisualStyleBackColor = True
        '
        'statusComboBox
        '
        Me.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusComboBox.FormattingEnabled = True
        Me.statusComboBox.Location = New System.Drawing.Point(428, 54)
        Me.statusComboBox.Name = "statusComboBox"
        Me.statusComboBox.Size = New System.Drawing.Size(178, 28)
        Me.statusComboBox.TabIndex = 3
        '
        'timeTimer
        '
        Me.timeTimer.Enabled = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(769, 596)
        Me.Controls.Add(Me.statusComboBox)
        Me.Controls.Add(Me.pressMeButton)
        Me.Controls.Add(Me.display2ListBox)
        Me.Controls.Add(Me.displayListBox)
        Me.Controls.Add(Me.pressButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play With Loops"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pressButton As System.Windows.Forms.Button
    Friend WithEvents displayListBox As System.Windows.Forms.ListBox
    Friend WithEvents display2ListBox As System.Windows.Forms.ListBox
    Friend WithEvents pressMeButton As System.Windows.Forms.Button
    Friend WithEvents statusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents timeTimer As System.Windows.Forms.Timer

End Class
