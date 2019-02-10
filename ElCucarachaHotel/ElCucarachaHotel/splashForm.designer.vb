<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashForm))
        Me.programTitleLabel = New System.Windows.Forms.Label()
        Me.javaPictureBox = New System.Windows.Forms.PictureBox()
        Me.copyRightLabe = New System.Windows.Forms.Label()
        Me.splashTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.javaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'programTitleLabel
        '
        Me.programTitleLabel.AutoSize = True
        Me.programTitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.programTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programTitleLabel.Location = New System.Drawing.Point(145, 108)
        Me.programTitleLabel.Name = "programTitleLabel"
        Me.programTitleLabel.Size = New System.Drawing.Size(315, 39)
        Me.programTitleLabel.TabIndex = 0
        Me.programTitleLabel.Text = "El Cucaracha Hotel"
        '
        'javaPictureBox
        '
        Me.javaPictureBox.Image = CType(resources.GetObject("javaPictureBox.Image"), System.Drawing.Image)
        Me.javaPictureBox.Location = New System.Drawing.Point(188, 150)
        Me.javaPictureBox.Name = "javaPictureBox"
        Me.javaPictureBox.Size = New System.Drawing.Size(242, 206)
        Me.javaPictureBox.TabIndex = 1
        Me.javaPictureBox.TabStop = False
        '
        'copyRightLabe
        '
        Me.copyRightLabe.AutoSize = True
        Me.copyRightLabe.Location = New System.Drawing.Point(247, 386)
        Me.copyRightLabe.Name = "copyRightLabe"
        Me.copyRightLabe.Size = New System.Drawing.Size(134, 20)
        Me.copyRightLabe.TabIndex = 2
        Me.copyRightLabe.Text = "(C) J. Welch 2015"
        '
        'splashTimer
        '
        Me.splashTimer.Enabled = True
        Me.splashTimer.Interval = 3000
        '
        'splashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(663, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.copyRightLabe)
        Me.Controls.Add(Me.javaPictureBox)
        Me.Controls.Add(Me.programTitleLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "splashForm"
        Me.ShowInTaskbar = False
        CType(Me.javaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents programTitleLabel As System.Windows.Forms.Label
    Friend WithEvents javaPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents copyRightLabe As System.Windows.Forms.Label
    Friend WithEvents splashTimer As System.Windows.Forms.Timer
End Class
