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
        Me.addButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.directorTextBox = New System.Windows.Forms.TextBox()
        Me.producerTextBox = New System.Windows.Forms.TextBox()
        Me.yearReleasedTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.yearReleasedLabel = New System.Windows.Forms.Label()
        Me.producerLabel = New System.Windows.Forms.Label()
        Me.directorLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.movieInfoListBox = New System.Windows.Forms.ListBox()
        Me.movieListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(16, 331)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(106, 39)
        Me.addButton.TabIndex = 8
        Me.addButton.Text = "&Add Movie"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(128, 331)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(106, 39)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(788, 408)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(106, 39)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(16, 49)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(218, 26)
        Me.titleTextBox.TabIndex = 1
        '
        'directorTextBox
        '
        Me.directorTextBox.Location = New System.Drawing.Point(16, 124)
        Me.directorTextBox.Name = "directorTextBox"
        Me.directorTextBox.Size = New System.Drawing.Size(218, 26)
        Me.directorTextBox.TabIndex = 3
        '
        'producerTextBox
        '
        Me.producerTextBox.Location = New System.Drawing.Point(16, 200)
        Me.producerTextBox.Name = "producerTextBox"
        Me.producerTextBox.Size = New System.Drawing.Size(218, 26)
        Me.producerTextBox.TabIndex = 5
        '
        'yearReleasedTextBox
        '
        Me.yearReleasedTextBox.Location = New System.Drawing.Point(16, 277)
        Me.yearReleasedTextBox.Name = "yearReleasedTextBox"
        Me.yearReleasedTextBox.Size = New System.Drawing.Size(218, 26)
        Me.yearReleasedTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.yearReleasedLabel)
        Me.GroupBox1.Controls.Add(Me.producerLabel)
        Me.GroupBox1.Controls.Add(Me.directorLabel)
        Me.GroupBox1.Controls.Add(Me.titleLabel)
        Me.GroupBox1.Controls.Add(Me.titleTextBox)
        Me.GroupBox1.Controls.Add(Me.yearReleasedTextBox)
        Me.GroupBox1.Controls.Add(Me.addButton)
        Me.GroupBox1.Controls.Add(Me.producerTextBox)
        Me.GroupBox1.Controls.Add(Me.clearButton)
        Me.GroupBox1.Controls.Add(Me.directorTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add A Movie"
        '
        'yearReleasedLabel
        '
        Me.yearReleasedLabel.AutoSize = True
        Me.yearReleasedLabel.Location = New System.Drawing.Point(12, 254)
        Me.yearReleasedLabel.Name = "yearReleasedLabel"
        Me.yearReleasedLabel.Size = New System.Drawing.Size(196, 20)
        Me.yearReleasedLabel.TabIndex = 6
        Me.yearReleasedLabel.Text = "Year Movie was Released:"
        '
        'producerLabel
        '
        Me.producerLabel.AutoSize = True
        Me.producerLabel.Location = New System.Drawing.Point(12, 177)
        Me.producerLabel.Name = "producerLabel"
        Me.producerLabel.Size = New System.Drawing.Size(77, 20)
        Me.producerLabel.TabIndex = 4
        Me.producerLabel.Text = "Producer:"
        '
        'directorLabel
        '
        Me.directorLabel.AutoSize = True
        Me.directorLabel.Location = New System.Drawing.Point(12, 101)
        Me.directorLabel.Name = "directorLabel"
        Me.directorLabel.Size = New System.Drawing.Size(69, 20)
        Me.directorLabel.TabIndex = 2
        Me.directorLabel.Text = "Director:"
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(12, 26)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(42, 20)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Title:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.movieInfoListBox)
        Me.GroupBox2.Controls.Add(Me.movieListBox)
        Me.GroupBox2.Location = New System.Drawing.Point(295, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 389)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Available Movies"
        '
        'movieInfoListBox
        '
        Me.movieInfoListBox.FormattingEnabled = True
        Me.movieInfoListBox.ItemHeight = 20
        Me.movieInfoListBox.Location = New System.Drawing.Point(264, 25)
        Me.movieInfoListBox.Name = "movieInfoListBox"
        Me.movieInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.movieInfoListBox.Size = New System.Drawing.Size(318, 344)
        Me.movieInfoListBox.TabIndex = 1
        '
        'movieListBox
        '
        Me.movieListBox.FormattingEnabled = True
        Me.movieListBox.ItemHeight = 20
        Me.movieListBox.Location = New System.Drawing.Point(15, 25)
        Me.movieListBox.Name = "movieListBox"
        Me.movieListBox.Size = New System.Drawing.Size(230, 344)
        Me.movieListBox.TabIndex = 0
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 458)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Movie Info Recorder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents directorTextBox As TextBox
    Friend WithEvents producerTextBox As TextBox
    Friend WithEvents yearReleasedTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents yearReleasedLabel As Label
    Friend WithEvents producerLabel As Label
    Friend WithEvents directorLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents movieInfoListBox As ListBox
    Friend WithEvents movieListBox As ListBox
End Class
