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
        Me.steveJobsButton = New System.Windows.Forms.Button()
        Me.billGatesButton = New System.Windows.Forms.Button()
        Me.dennisRitchieButton = New System.Windows.Forms.Button()
        Me.kenThompsonButton = New System.Windows.Forms.Button()
        Me.linusTorvaldsButton = New System.Windows.Forms.Button()
        Me.richardStallmanButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.displayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'steveJobsButton
        '
        Me.steveJobsButton.Location = New System.Drawing.Point(37, 39)
        Me.steveJobsButton.Name = "steveJobsButton"
        Me.steveJobsButton.Size = New System.Drawing.Size(174, 52)
        Me.steveJobsButton.TabIndex = 0
        Me.steveJobsButton.Text = "Steve Jobs"
        Me.steveJobsButton.UseVisualStyleBackColor = True
        '
        'billGatesButton
        '
        Me.billGatesButton.Location = New System.Drawing.Point(37, 97)
        Me.billGatesButton.Name = "billGatesButton"
        Me.billGatesButton.Size = New System.Drawing.Size(174, 52)
        Me.billGatesButton.TabIndex = 1
        Me.billGatesButton.Text = "Bill Gates"
        Me.billGatesButton.UseVisualStyleBackColor = True
        '
        'dennisRitchieButton
        '
        Me.dennisRitchieButton.Location = New System.Drawing.Point(37, 155)
        Me.dennisRitchieButton.Name = "dennisRitchieButton"
        Me.dennisRitchieButton.Size = New System.Drawing.Size(174, 52)
        Me.dennisRitchieButton.TabIndex = 2
        Me.dennisRitchieButton.Text = "Dennis Ritchie"
        Me.dennisRitchieButton.UseVisualStyleBackColor = True
        '
        'kenThompsonButton
        '
        Me.kenThompsonButton.Location = New System.Drawing.Point(37, 213)
        Me.kenThompsonButton.Name = "kenThompsonButton"
        Me.kenThompsonButton.Size = New System.Drawing.Size(174, 52)
        Me.kenThompsonButton.TabIndex = 3
        Me.kenThompsonButton.Text = "Ken Thompson"
        Me.kenThompsonButton.UseVisualStyleBackColor = True
        '
        'linusTorvaldsButton
        '
        Me.linusTorvaldsButton.Location = New System.Drawing.Point(37, 271)
        Me.linusTorvaldsButton.Name = "linusTorvaldsButton"
        Me.linusTorvaldsButton.Size = New System.Drawing.Size(174, 52)
        Me.linusTorvaldsButton.TabIndex = 4
        Me.linusTorvaldsButton.Text = "Linus Torvalds"
        Me.linusTorvaldsButton.UseVisualStyleBackColor = True
        '
        'richardStallmanButton
        '
        Me.richardStallmanButton.Location = New System.Drawing.Point(37, 329)
        Me.richardStallmanButton.Name = "richardStallmanButton"
        Me.richardStallmanButton.Size = New System.Drawing.Size(174, 52)
        Me.richardStallmanButton.TabIndex = 5
        Me.richardStallmanButton.Text = "Richard Stallman"
        Me.richardStallmanButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(37, 475)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(174, 52)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'displayLabel
        '
        Me.displayLabel.BackColor = System.Drawing.Color.White
        Me.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayLabel.Location = New System.Drawing.Point(276, 215)
        Me.displayLabel.Name = "displayLabel"
        Me.displayLabel.Size = New System.Drawing.Size(202, 50)
        Me.displayLabel.TabIndex = 7
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 564)
        Me.Controls.Add(Me.displayLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.richardStallmanButton)
        Me.Controls.Add(Me.linusTorvaldsButton)
        Me.Controls.Add(Me.kenThompsonButton)
        Me.Controls.Add(Me.dennisRitchieButton)
        Me.Controls.Add(Me.billGatesButton)
        Me.Controls.Add(Me.steveJobsButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Phone Contact Display"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents steveJobsButton As System.Windows.Forms.Button
    Friend WithEvents billGatesButton As System.Windows.Forms.Button
    Friend WithEvents dennisRitchieButton As System.Windows.Forms.Button
    Friend WithEvents kenThompsonButton As System.Windows.Forms.Button
    Friend WithEvents linusTorvaldsButton As System.Windows.Forms.Button
    Friend WithEvents richardStallmanButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents displayLabel As System.Windows.Forms.Label

End Class
