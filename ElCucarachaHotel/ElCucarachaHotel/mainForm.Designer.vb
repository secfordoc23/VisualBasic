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
        Me.displayListBox = New System.Windows.Forms.ListBox()
        Me.floorLabel = New System.Windows.Forms.Label()
        Me.totalRoomsLabel = New System.Windows.Forms.Label()
        Me.overAllOccupancyLabel = New System.Windows.Forms.Label()
        Me.totalRoomAmountLabel = New System.Windows.Forms.Label()
        Me.overAllOccLabel = New System.Windows.Forms.Label()
        Me.completeButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'displayListBox
        '
        Me.displayListBox.FormattingEnabled = True
        Me.displayListBox.ItemHeight = 20
        Me.displayListBox.Location = New System.Drawing.Point(60, 52)
        Me.displayListBox.Name = "displayListBox"
        Me.displayListBox.Size = New System.Drawing.Size(403, 324)
        Me.displayListBox.TabIndex = 0
        '
        'floorLabel
        '
        Me.floorLabel.AutoSize = True
        Me.floorLabel.Location = New System.Drawing.Point(56, 29)
        Me.floorLabel.Name = "floorLabel"
        Me.floorLabel.Size = New System.Drawing.Size(171, 20)
        Me.floorLabel.TabIndex = 1
        Me.floorLabel.Text = "Floor Occupancy Data:"
        '
        'totalRoomsLabel
        '
        Me.totalRoomsLabel.AutoSize = True
        Me.totalRoomsLabel.Location = New System.Drawing.Point(94, 379)
        Me.totalRoomsLabel.Name = "totalRoomsLabel"
        Me.totalRoomsLabel.Size = New System.Drawing.Size(174, 20)
        Me.totalRoomsLabel.TabIndex = 1
        Me.totalRoomsLabel.Text = "Total Rooms Occupied:"
        '
        'overAllOccupancyLabel
        '
        Me.overAllOccupancyLabel.AutoSize = True
        Me.overAllOccupancyLabel.Location = New System.Drawing.Point(94, 409)
        Me.overAllOccupancyLabel.Name = "overAllOccupancyLabel"
        Me.overAllOccupancyLabel.Size = New System.Drawing.Size(183, 20)
        Me.overAllOccupancyLabel.TabIndex = 1
        Me.overAllOccupancyLabel.Text = "Overall Occupancy Rate:"
        '
        'totalRoomAmountLabel
        '
        Me.totalRoomAmountLabel.BackColor = System.Drawing.Color.White
        Me.totalRoomAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalRoomAmountLabel.Location = New System.Drawing.Point(293, 379)
        Me.totalRoomAmountLabel.Name = "totalRoomAmountLabel"
        Me.totalRoomAmountLabel.Size = New System.Drawing.Size(85, 20)
        Me.totalRoomAmountLabel.TabIndex = 1
        Me.totalRoomAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'overAllOccLabel
        '
        Me.overAllOccLabel.BackColor = System.Drawing.Color.White
        Me.overAllOccLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.overAllOccLabel.Location = New System.Drawing.Point(293, 409)
        Me.overAllOccLabel.Name = "overAllOccLabel"
        Me.overAllOccLabel.Size = New System.Drawing.Size(85, 20)
        Me.overAllOccLabel.TabIndex = 1
        Me.overAllOccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'completeButton
        '
        Me.completeButton.Location = New System.Drawing.Point(32, 472)
        Me.completeButton.Name = "completeButton"
        Me.completeButton.Size = New System.Drawing.Size(150, 41)
        Me.completeButton.TabIndex = 0
        Me.completeButton.Text = "&Complete Report"
        Me.completeButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(188, 472)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(150, 41)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(344, 472)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(150, 41)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.completeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(531, 546)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.completeButton)
        Me.Controls.Add(Me.overAllOccLabel)
        Me.Controls.Add(Me.totalRoomAmountLabel)
        Me.Controls.Add(Me.overAllOccupancyLabel)
        Me.Controls.Add(Me.totalRoomsLabel)
        Me.Controls.Add(Me.floorLabel)
        Me.Controls.Add(Me.displayListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "El Cucaracha Hotel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayListBox As System.Windows.Forms.ListBox
    Friend WithEvents floorLabel As System.Windows.Forms.Label
    Friend WithEvents totalRoomsLabel As System.Windows.Forms.Label
    Friend WithEvents overAllOccupancyLabel As System.Windows.Forms.Label
    Friend WithEvents totalRoomAmountLabel As System.Windows.Forms.Label
    Friend WithEvents overAllOccLabel As System.Windows.Forms.Label
    Friend WithEvents completeButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
