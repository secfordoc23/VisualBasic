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
        Me.oilLubeGroupBox = New System.Windows.Forms.GroupBox()
        Me.lubeJobCheckBox = New System.Windows.Forms.CheckBox()
        Me.oilChangeCheckBox = New System.Windows.Forms.CheckBox()
        Me.flushesGroupBox = New System.Windows.Forms.GroupBox()
        Me.transmissionCheckBox = New System.Windows.Forms.CheckBox()
        Me.radiatorCheckBox = New System.Windows.Forms.CheckBox()
        Me.miscGroupBox = New System.Windows.Forms.GroupBox()
        Me.tireCheckBox = New System.Windows.Forms.CheckBox()
        Me.mufflerCheckBox = New System.Windows.Forms.CheckBox()
        Me.inspectionCheckBox = New System.Windows.Forms.CheckBox()
        Me.partsAndlaborGroupBox = New System.Windows.Forms.GroupBox()
        Me.laborTextBox = New System.Windows.Forms.TextBox()
        Me.partsTextBox = New System.Windows.Forms.TextBox()
        Me.laborLabel = New System.Windows.Forms.Label()
        Me.partsLabel = New System.Windows.Forms.Label()
        Me.summaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.totalPartsLabel = New System.Windows.Forms.Label()
        Me.serviceLaborLabel = New System.Windows.Forms.Label()
        Me.serviceAndLaborLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.totalFeesLabel = New System.Windows.Forms.Label()
        Me.taxOnPartsLabel = New System.Windows.Forms.Label()
        Me.partsTotalLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.oilLubeGroupBox.SuspendLayout()
        Me.flushesGroupBox.SuspendLayout()
        Me.miscGroupBox.SuspendLayout()
        Me.partsAndlaborGroupBox.SuspendLayout()
        Me.summaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'oilLubeGroupBox
        '
        Me.oilLubeGroupBox.Controls.Add(Me.lubeJobCheckBox)
        Me.oilLubeGroupBox.Controls.Add(Me.oilChangeCheckBox)
        Me.oilLubeGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.oilLubeGroupBox.Name = "oilLubeGroupBox"
        Me.oilLubeGroupBox.Size = New System.Drawing.Size(241, 90)
        Me.oilLubeGroupBox.TabIndex = 0
        Me.oilLubeGroupBox.TabStop = False
        Me.oilLubeGroupBox.Text = "Oil and Lube"
        '
        'lubeJobCheckBox
        '
        Me.lubeJobCheckBox.AutoSize = True
        Me.lubeJobCheckBox.Location = New System.Drawing.Point(16, 56)
        Me.lubeJobCheckBox.Name = "lubeJobCheckBox"
        Me.lubeJobCheckBox.Size = New System.Drawing.Size(157, 24)
        Me.lubeJobCheckBox.TabIndex = 1
        Me.lubeJobCheckBox.Text = "Lube Job ($18.00)"
        Me.lubeJobCheckBox.UseVisualStyleBackColor = True
        '
        'oilChangeCheckBox
        '
        Me.oilChangeCheckBox.AutoSize = True
        Me.oilChangeCheckBox.Location = New System.Drawing.Point(16, 26)
        Me.oilChangeCheckBox.Name = "oilChangeCheckBox"
        Me.oilChangeCheckBox.Size = New System.Drawing.Size(169, 24)
        Me.oilChangeCheckBox.TabIndex = 0
        Me.oilChangeCheckBox.Text = "Oil Change ($26.00)"
        Me.oilChangeCheckBox.UseVisualStyleBackColor = True
        '
        'flushesGroupBox
        '
        Me.flushesGroupBox.Controls.Add(Me.transmissionCheckBox)
        Me.flushesGroupBox.Controls.Add(Me.radiatorCheckBox)
        Me.flushesGroupBox.Location = New System.Drawing.Point(260, 13)
        Me.flushesGroupBox.Name = "flushesGroupBox"
        Me.flushesGroupBox.Size = New System.Drawing.Size(294, 90)
        Me.flushesGroupBox.TabIndex = 1
        Me.flushesGroupBox.TabStop = False
        Me.flushesGroupBox.Text = "Flushes"
        '
        'transmissionCheckBox
        '
        Me.transmissionCheckBox.AutoSize = True
        Me.transmissionCheckBox.Location = New System.Drawing.Point(20, 55)
        Me.transmissionCheckBox.Name = "transmissionCheckBox"
        Me.transmissionCheckBox.Size = New System.Drawing.Size(227, 24)
        Me.transmissionCheckBox.TabIndex = 1
        Me.transmissionCheckBox.Text = "Transmission Flush ($80.00)"
        Me.transmissionCheckBox.UseVisualStyleBackColor = True
        '
        'radiatorCheckBox
        '
        Me.radiatorCheckBox.AutoSize = True
        Me.radiatorCheckBox.Location = New System.Drawing.Point(20, 27)
        Me.radiatorCheckBox.Name = "radiatorCheckBox"
        Me.radiatorCheckBox.Size = New System.Drawing.Size(190, 24)
        Me.radiatorCheckBox.TabIndex = 0
        Me.radiatorCheckBox.Text = "Radiator flush ($30.00)"
        Me.radiatorCheckBox.UseVisualStyleBackColor = True
        '
        'miscGroupBox
        '
        Me.miscGroupBox.Controls.Add(Me.tireCheckBox)
        Me.miscGroupBox.Controls.Add(Me.mufflerCheckBox)
        Me.miscGroupBox.Controls.Add(Me.inspectionCheckBox)
        Me.miscGroupBox.Location = New System.Drawing.Point(13, 109)
        Me.miscGroupBox.Name = "miscGroupBox"
        Me.miscGroupBox.Size = New System.Drawing.Size(241, 121)
        Me.miscGroupBox.TabIndex = 2
        Me.miscGroupBox.TabStop = False
        Me.miscGroupBox.Text = "Misc"
        '
        'tireCheckBox
        '
        Me.tireCheckBox.AutoSize = True
        Me.tireCheckBox.Location = New System.Drawing.Point(16, 85)
        Me.tireCheckBox.Name = "tireCheckBox"
        Me.tireCheckBox.Size = New System.Drawing.Size(182, 24)
        Me.tireCheckBox.TabIndex = 2
        Me.tireCheckBox.Text = "Tire Rotation ($20.00)"
        Me.tireCheckBox.UseVisualStyleBackColor = True
        '
        'mufflerCheckBox
        '
        Me.mufflerCheckBox.AutoSize = True
        Me.mufflerCheckBox.Location = New System.Drawing.Point(16, 55)
        Me.mufflerCheckBox.Name = "mufflerCheckBox"
        Me.mufflerCheckBox.Size = New System.Drawing.Size(212, 24)
        Me.mufflerCheckBox.TabIndex = 1
        Me.mufflerCheckBox.Text = "Replace Muffler ($100.00)"
        Me.mufflerCheckBox.UseVisualStyleBackColor = True
        '
        'inspectionCheckBox
        '
        Me.inspectionCheckBox.AutoSize = True
        Me.inspectionCheckBox.Location = New System.Drawing.Point(16, 25)
        Me.inspectionCheckBox.Name = "inspectionCheckBox"
        Me.inspectionCheckBox.Size = New System.Drawing.Size(165, 24)
        Me.inspectionCheckBox.TabIndex = 0
        Me.inspectionCheckBox.Text = "Inspection ($15.00)"
        Me.inspectionCheckBox.UseVisualStyleBackColor = True
        '
        'partsAndlaborGroupBox
        '
        Me.partsAndlaborGroupBox.Controls.Add(Me.laborTextBox)
        Me.partsAndlaborGroupBox.Controls.Add(Me.partsTextBox)
        Me.partsAndlaborGroupBox.Controls.Add(Me.laborLabel)
        Me.partsAndlaborGroupBox.Controls.Add(Me.partsLabel)
        Me.partsAndlaborGroupBox.Location = New System.Drawing.Point(260, 109)
        Me.partsAndlaborGroupBox.Name = "partsAndlaborGroupBox"
        Me.partsAndlaborGroupBox.Size = New System.Drawing.Size(294, 121)
        Me.partsAndlaborGroupBox.TabIndex = 3
        Me.partsAndlaborGroupBox.TabStop = False
        Me.partsAndlaborGroupBox.Text = "Parts and Labor"
        '
        'laborTextBox
        '
        Me.laborTextBox.Location = New System.Drawing.Point(84, 83)
        Me.laborTextBox.Name = "laborTextBox"
        Me.laborTextBox.Size = New System.Drawing.Size(100, 26)
        Me.laborTextBox.TabIndex = 3
        '
        'partsTextBox
        '
        Me.partsTextBox.Location = New System.Drawing.Point(84, 26)
        Me.partsTextBox.Name = "partsTextBox"
        Me.partsTextBox.Size = New System.Drawing.Size(100, 26)
        Me.partsTextBox.TabIndex = 1
        '
        'laborLabel
        '
        Me.laborLabel.AutoSize = True
        Me.laborLabel.Location = New System.Drawing.Point(16, 85)
        Me.laborLabel.Name = "laborLabel"
        Me.laborLabel.Size = New System.Drawing.Size(54, 20)
        Me.laborLabel.TabIndex = 2
        Me.laborLabel.Text = "Labor:"
        '
        'partsLabel
        '
        Me.partsLabel.AutoSize = True
        Me.partsLabel.Location = New System.Drawing.Point(20, 29)
        Me.partsLabel.Name = "partsLabel"
        Me.partsLabel.Size = New System.Drawing.Size(54, 20)
        Me.partsLabel.TabIndex = 0
        Me.partsLabel.Text = "Parts: "
        '
        'summaryGroupBox
        '
        Me.summaryGroupBox.Controls.Add(Me.totalPartsLabel)
        Me.summaryGroupBox.Controls.Add(Me.serviceLaborLabel)
        Me.summaryGroupBox.Controls.Add(Me.serviceAndLaborLabel)
        Me.summaryGroupBox.Controls.Add(Me.totalLabel)
        Me.summaryGroupBox.Controls.Add(Me.taxLabel)
        Me.summaryGroupBox.Controls.Add(Me.totalFeesLabel)
        Me.summaryGroupBox.Controls.Add(Me.taxOnPartsLabel)
        Me.summaryGroupBox.Controls.Add(Me.partsTotalLabel)
        Me.summaryGroupBox.Location = New System.Drawing.Point(13, 236)
        Me.summaryGroupBox.Name = "summaryGroupBox"
        Me.summaryGroupBox.Size = New System.Drawing.Size(541, 187)
        Me.summaryGroupBox.TabIndex = 4
        Me.summaryGroupBox.TabStop = False
        Me.summaryGroupBox.Text = "Summary"
        '
        'totalPartsLabel
        '
        Me.totalPartsLabel.BackColor = System.Drawing.Color.White
        Me.totalPartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalPartsLabel.Location = New System.Drawing.Point(267, 64)
        Me.totalPartsLabel.Name = "totalPartsLabel"
        Me.totalPartsLabel.Size = New System.Drawing.Size(100, 20)
        Me.totalPartsLabel.TabIndex = 9
        '
        'serviceLaborLabel
        '
        Me.serviceLaborLabel.BackColor = System.Drawing.Color.White
        Me.serviceLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.serviceLaborLabel.Location = New System.Drawing.Point(267, 33)
        Me.serviceLaborLabel.Name = "serviceLaborLabel"
        Me.serviceLaborLabel.Size = New System.Drawing.Size(100, 20)
        Me.serviceLaborLabel.TabIndex = 9
        '
        'serviceAndLaborLabel
        '
        Me.serviceAndLaborLabel.AutoSize = True
        Me.serviceAndLaborLabel.Location = New System.Drawing.Point(122, 33)
        Me.serviceAndLaborLabel.Name = "serviceAndLaborLabel"
        Me.serviceAndLaborLabel.Size = New System.Drawing.Size(139, 20)
        Me.serviceAndLaborLabel.TabIndex = 8
        Me.serviceAndLaborLabel.Text = "Service and labor: "
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.White
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(267, 131)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 20)
        Me.totalLabel.TabIndex = 9
        '
        'taxLabel
        '
        Me.taxLabel.BackColor = System.Drawing.Color.White
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.taxLabel.Location = New System.Drawing.Point(267, 95)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(100, 20)
        Me.taxLabel.TabIndex = 9
        '
        'totalFeesLabel
        '
        Me.totalFeesLabel.AutoSize = True
        Me.totalFeesLabel.Location = New System.Drawing.Point(172, 132)
        Me.totalFeesLabel.Name = "totalFeesLabel"
        Me.totalFeesLabel.Size = New System.Drawing.Size(92, 20)
        Me.totalFeesLabel.TabIndex = 8
        Me.totalFeesLabel.Text = "Total Fees: "
        '
        'taxOnPartsLabel
        '
        Me.taxOnPartsLabel.AutoSize = True
        Me.taxOnPartsLabel.Location = New System.Drawing.Point(147, 96)
        Me.taxOnPartsLabel.Name = "taxOnPartsLabel"
        Me.taxOnPartsLabel.Size = New System.Drawing.Size(114, 20)
        Me.taxOnPartsLabel.TabIndex = 8
        Me.taxOnPartsLabel.Text = "Tax (on parts): "
        '
        'partsTotalLabel
        '
        Me.partsTotalLabel.AutoSize = True
        Me.partsTotalLabel.Location = New System.Drawing.Point(207, 65)
        Me.partsTotalLabel.Name = "partsTotalLabel"
        Me.partsTotalLabel.Size = New System.Drawing.Size(54, 20)
        Me.partsTotalLabel.TabIndex = 8
        Me.partsTotalLabel.Text = "Parts: "
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(338, 429)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 55)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(212, 429)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 55)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(86, 429)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 55)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 509)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.summaryGroupBox)
        Me.Controls.Add(Me.partsAndlaborGroupBox)
        Me.Controls.Add(Me.miscGroupBox)
        Me.Controls.Add(Me.flushesGroupBox)
        Me.Controls.Add(Me.oilLubeGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.Text = "Joe's Automotive"
        Me.oilLubeGroupBox.ResumeLayout(False)
        Me.oilLubeGroupBox.PerformLayout()
        Me.flushesGroupBox.ResumeLayout(False)
        Me.flushesGroupBox.PerformLayout()
        Me.miscGroupBox.ResumeLayout(False)
        Me.miscGroupBox.PerformLayout()
        Me.partsAndlaborGroupBox.ResumeLayout(False)
        Me.partsAndlaborGroupBox.PerformLayout()
        Me.summaryGroupBox.ResumeLayout(False)
        Me.summaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents oilLubeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lubeJobCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents oilChangeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents flushesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents transmissionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents radiatorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents miscGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents tireCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents mufflerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents inspectionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents partsAndlaborGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents laborTextBox As System.Windows.Forms.TextBox
    Friend WithEvents partsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents laborLabel As System.Windows.Forms.Label
    Friend WithEvents partsLabel As System.Windows.Forms.Label
    Friend WithEvents summaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents totalPartsLabel As System.Windows.Forms.Label
    Friend WithEvents serviceLaborLabel As System.Windows.Forms.Label
    Friend WithEvents serviceAndLaborLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents totalFeesLabel As System.Windows.Forms.Label
    Friend WithEvents taxOnPartsLabel As System.Windows.Forms.Label
    Friend WithEvents partsTotalLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
