<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(382, 198)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(175, 31)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "Hello It's Me"
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Location = New System.Drawing.Point(361, 460)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(175, 24)
        Me.lblCopyRight.TabIndex = 1
        Me.lblCopyRight.Text = "(C) J. Welch 2015"
        '
        'tmrSplash
        '
        Me.tmrSplash.Enabled = True
        Me.tmrSplash.Interval = 3000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.ClientSize = New System.Drawing.Size(914, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.lblLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblCopyRight As System.Windows.Forms.Label
    Friend WithEvents tmrSplash As System.Windows.Forms.Timer
End Class
