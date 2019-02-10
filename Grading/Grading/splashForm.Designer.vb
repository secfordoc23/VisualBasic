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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.captionLabel = New System.Windows.Forms.Label()
        Me.splashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(280, 78)
        Me.titleLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(126, 33)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Grading"
        '
        'captionLabel
        '
        Me.captionLabel.AutoSize = True
        Me.captionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captionLabel.Location = New System.Drawing.Point(283, 349)
        Me.captionLabel.Name = "captionLabel"
        Me.captionLabel.Size = New System.Drawing.Size(134, 16)
        Me.captionLabel.TabIndex = 2
        Me.captionLabel.Text = "(C2019 )Jason Welch"
        '
        'splashTimer
        '
        Me.splashTimer.Enabled = True
        Me.splashTimer.Interval = 2000
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.InitialImage = Global.Grading.My.Resources.Resources.grading2
        Me.logoPictureBox.Location = New System.Drawing.Point(218, 129)
        Me.logoPictureBox.Margin = New System.Windows.Forms.Padding(5)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(253, 206)
        Me.logoPictureBox.TabIndex = 0
        Me.logoPictureBox.TabStop = False
        '
        'splashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.captionLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "splashForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents captionLabel As Label
    Friend WithEvents splashTimer As Timer
End Class
