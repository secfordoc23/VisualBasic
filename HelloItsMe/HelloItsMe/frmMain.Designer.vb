<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnFrench = New System.Windows.Forms.Button()
        Me.btnGerman = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnglish
        '
        Me.btnEnglish.BackColor = System.Drawing.Color.GreenYellow
        Me.btnEnglish.Location = New System.Drawing.Point(49, 37)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(189, 46)
        Me.btnEnglish.TabIndex = 0
        Me.btnEnglish.Text = "&English"
        Me.btnEnglish.UseVisualStyleBackColor = False
        '
        'btnSpanish
        '
        Me.btnSpanish.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSpanish.Location = New System.Drawing.Point(49, 105)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(189, 46)
        Me.btnSpanish.TabIndex = 1
        Me.btnSpanish.Text = "&Spanish"
        Me.btnSpanish.UseVisualStyleBackColor = False
        '
        'btnFrench
        '
        Me.btnFrench.BackColor = System.Drawing.Color.GreenYellow
        Me.btnFrench.Location = New System.Drawing.Point(49, 173)
        Me.btnFrench.Name = "btnFrench"
        Me.btnFrench.Size = New System.Drawing.Size(189, 46)
        Me.btnFrench.TabIndex = 2
        Me.btnFrench.Text = "&French"
        Me.btnFrench.UseVisualStyleBackColor = False
        '
        'btnGerman
        '
        Me.btnGerman.BackColor = System.Drawing.Color.GreenYellow
        Me.btnGerman.Location = New System.Drawing.Point(49, 241)
        Me.btnGerman.Name = "btnGerman"
        Me.btnGerman.Size = New System.Drawing.Size(189, 46)
        Me.btnGerman.TabIndex = 3
        Me.btnGerman.Text = "&German"
        Me.btnGerman.UseVisualStyleBackColor = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisplay.Location = New System.Drawing.Point(308, 101)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(290, 46)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.Location = New System.Drawing.Point(49, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(189, 46)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(626, 392)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnGerman)
        Me.Controls.Add(Me.btnFrench)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnEnglish)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Hello It's Me"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnglish As System.Windows.Forms.Button
    Friend WithEvents btnSpanish As System.Windows.Forms.Button
    Friend WithEvents btnFrench As System.Windows.Forms.Button
    Friend WithEvents btnGerman As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
