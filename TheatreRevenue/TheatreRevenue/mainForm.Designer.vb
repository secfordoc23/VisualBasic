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
        Me.adultTicketSaleLabel = New System.Windows.Forms.Label()
        Me.adultNetSaleLabel = New System.Windows.Forms.Label()
        Me.netTicketRevenueLabel = New System.Windows.Forms.Label()
        Me.childTicketPriceLabel = New System.Windows.Forms.Label()
        Me.adultTicketsSoldLabel = New System.Windows.Forms.Label()
        Me.childTicketsSoldLabel = New System.Windows.Forms.Label()
        Me.grossTicketRevenueLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.childNetSaleLabel = New System.Windows.Forms.Label()
        Me.netTotalSaleLabel = New System.Windows.Forms.Label()
        Me.adultGrossSaleLabel = New System.Windows.Forms.Label()
        Me.childGrossSaleLabel = New System.Windows.Forms.Label()
        Me.grossTotalSaleLabel = New System.Windows.Forms.Label()
        Me.adultTicketPriceLabel = New System.Windows.Forms.Label()
        Me.adultTicketPriceTextBox = New System.Windows.Forms.TextBox()
        Me.adultsTicketsSoldTextBox = New System.Windows.Forms.TextBox()
        Me.childTicketPriceTextBox = New System.Windows.Forms.TextBox()
        Me.childTicketsSoldTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.grossAdultSalesLabel = New System.Windows.Forms.Label()
        Me.grossChildSalesLabel = New System.Windows.Forms.Label()
        Me.grossTotalLabel = New System.Windows.Forms.Label()
        Me.netAdultSalesLabel = New System.Windows.Forms.Label()
        Me.netChildSalesLabel = New System.Windows.Forms.Label()
        Me.netTotalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'adultTicketSaleLabel
        '
        Me.adultTicketSaleLabel.AutoSize = True
        Me.adultTicketSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adultTicketSaleLabel.Location = New System.Drawing.Point(59, 9)
        Me.adultTicketSaleLabel.Name = "adultTicketSaleLabel"
        Me.adultTicketSaleLabel.Size = New System.Drawing.Size(136, 20)
        Me.adultTicketSaleLabel.TabIndex = 0
        Me.adultTicketSaleLabel.Text = "Adult Ticket Sales"
        '
        'adultNetSaleLabel
        '
        Me.adultNetSaleLabel.AutoSize = True
        Me.adultNetSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adultNetSaleLabel.Location = New System.Drawing.Point(352, 194)
        Me.adultNetSaleLabel.Name = "adultNetSaleLabel"
        Me.adultNetSaleLabel.Size = New System.Drawing.Size(139, 20)
        Me.adultNetSaleLabel.TabIndex = 0
        Me.adultNetSaleLabel.Text = "Adult Ticket Price: "
        '
        'netTicketRevenueLabel
        '
        Me.netTicketRevenueLabel.AutoSize = True
        Me.netTicketRevenueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netTicketRevenueLabel.Location = New System.Drawing.Point(428, 152)
        Me.netTicketRevenueLabel.Name = "netTicketRevenueLabel"
        Me.netTicketRevenueLabel.Size = New System.Drawing.Size(148, 20)
        Me.netTicketRevenueLabel.TabIndex = 0
        Me.netTicketRevenueLabel.Text = "Net Ticket Revenue"
        '
        'childTicketPriceLabel
        '
        Me.childTicketPriceLabel.AutoSize = True
        Me.childTicketPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childTicketPriceLabel.Location = New System.Drawing.Point(352, 46)
        Me.childTicketPriceLabel.Name = "childTicketPriceLabel"
        Me.childTicketPriceLabel.Size = New System.Drawing.Size(137, 20)
        Me.childTicketPriceLabel.TabIndex = 4
        Me.childTicketPriceLabel.Text = "Child Ticket Price: "
        '
        'adultTicketsSoldLabel
        '
        Me.adultTicketsSoldLabel.AutoSize = True
        Me.adultTicketsSoldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adultTicketsSoldLabel.Location = New System.Drawing.Point(12, 82)
        Me.adultTicketsSoldLabel.Name = "adultTicketsSoldLabel"
        Me.adultTicketsSoldLabel.Size = New System.Drawing.Size(103, 20)
        Me.adultTicketsSoldLabel.TabIndex = 2
        Me.adultTicketsSoldLabel.Text = "Tickets Sold: "
        '
        'childTicketsSoldLabel
        '
        Me.childTicketsSoldLabel.AutoSize = True
        Me.childTicketsSoldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childTicketsSoldLabel.Location = New System.Drawing.Point(352, 82)
        Me.childTicketsSoldLabel.Name = "childTicketsSoldLabel"
        Me.childTicketsSoldLabel.Size = New System.Drawing.Size(103, 20)
        Me.childTicketsSoldLabel.TabIndex = 6
        Me.childTicketsSoldLabel.Text = "Tickets Sold: "
        '
        'grossTicketRevenueLabel
        '
        Me.grossTicketRevenueLabel.AutoSize = True
        Me.grossTicketRevenueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grossTicketRevenueLabel.Location = New System.Drawing.Point(59, 152)
        Me.grossTicketRevenueLabel.Name = "grossTicketRevenueLabel"
        Me.grossTicketRevenueLabel.Size = New System.Drawing.Size(166, 20)
        Me.grossTicketRevenueLabel.TabIndex = 0
        Me.grossTicketRevenueLabel.Text = "Gross Ticket Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Child Ticket Sales "
        '
        'childNetSaleLabel
        '
        Me.childNetSaleLabel.AutoSize = True
        Me.childNetSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childNetSaleLabel.Location = New System.Drawing.Point(352, 232)
        Me.childNetSaleLabel.Name = "childNetSaleLabel"
        Me.childNetSaleLabel.Size = New System.Drawing.Size(137, 20)
        Me.childNetSaleLabel.TabIndex = 0
        Me.childNetSaleLabel.Text = "Child Ticket Price: "
        '
        'netTotalSaleLabel
        '
        Me.netTotalSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netTotalSaleLabel.Location = New System.Drawing.Point(352, 264)
        Me.netTotalSaleLabel.Name = "netTotalSaleLabel"
        Me.netTotalSaleLabel.Size = New System.Drawing.Size(162, 44)
        Me.netTotalSaleLabel.TabIndex = 0
        Me.netTotalSaleLabel.Text = "Total Net Revenue for Ticket Sales:"
        '
        'adultGrossSaleLabel
        '
        Me.adultGrossSaleLabel.AutoSize = True
        Me.adultGrossSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adultGrossSaleLabel.Location = New System.Drawing.Point(12, 194)
        Me.adultGrossSaleLabel.Name = "adultGrossSaleLabel"
        Me.adultGrossSaleLabel.Size = New System.Drawing.Size(144, 20)
        Me.adultGrossSaleLabel.TabIndex = 0
        Me.adultGrossSaleLabel.Text = "Adult Ticket Sales: "
        '
        'childGrossSaleLabel
        '
        Me.childGrossSaleLabel.AutoSize = True
        Me.childGrossSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childGrossSaleLabel.Location = New System.Drawing.Point(12, 232)
        Me.childGrossSaleLabel.Name = "childGrossSaleLabel"
        Me.childGrossSaleLabel.Size = New System.Drawing.Size(138, 20)
        Me.childGrossSaleLabel.TabIndex = 0
        Me.childGrossSaleLabel.Text = "Child Ticket Sales:"
        '
        'grossTotalSaleLabel
        '
        Me.grossTotalSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grossTotalSaleLabel.Location = New System.Drawing.Point(12, 264)
        Me.grossTotalSaleLabel.Name = "grossTotalSaleLabel"
        Me.grossTotalSaleLabel.Size = New System.Drawing.Size(161, 44)
        Me.grossTotalSaleLabel.TabIndex = 0
        Me.grossTotalSaleLabel.Text = "Total Gross Revenue for Ticket Sales: "
        '
        'adultTicketPriceLabel
        '
        Me.adultTicketPriceLabel.AutoSize = True
        Me.adultTicketPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adultTicketPriceLabel.Location = New System.Drawing.Point(12, 46)
        Me.adultTicketPriceLabel.Name = "adultTicketPriceLabel"
        Me.adultTicketPriceLabel.Size = New System.Drawing.Size(139, 20)
        Me.adultTicketPriceLabel.TabIndex = 0
        Me.adultTicketPriceLabel.Text = "Adult Ticket Price: "
        '
        'adultTicketPriceTextBox
        '
        Me.adultTicketPriceTextBox.Location = New System.Drawing.Point(157, 48)
        Me.adultTicketPriceTextBox.Name = "adultTicketPriceTextBox"
        Me.adultTicketPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.adultTicketPriceTextBox.TabIndex = 1
        Me.adultTicketPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'adultsTicketsSoldTextBox
        '
        Me.adultsTicketsSoldTextBox.Location = New System.Drawing.Point(157, 82)
        Me.adultsTicketsSoldTextBox.Name = "adultsTicketsSoldTextBox"
        Me.adultsTicketsSoldTextBox.Size = New System.Drawing.Size(100, 20)
        Me.adultsTicketsSoldTextBox.TabIndex = 3
        Me.adultsTicketsSoldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'childTicketPriceTextBox
        '
        Me.childTicketPriceTextBox.Location = New System.Drawing.Point(498, 48)
        Me.childTicketPriceTextBox.Name = "childTicketPriceTextBox"
        Me.childTicketPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.childTicketPriceTextBox.TabIndex = 5
        Me.childTicketPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'childTicketsSoldTextBox
        '
        Me.childTicketsSoldTextBox.Location = New System.Drawing.Point(498, 82)
        Me.childTicketsSoldTextBox.Name = "childTicketsSoldTextBox"
        Me.childTicketsSoldTextBox.Size = New System.Drawing.Size(100, 20)
        Me.childTicketsSoldTextBox.TabIndex = 7
        Me.childTicketsSoldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(31, 333)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(180, 50)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "&Calculate Ticket Revenue"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(284, 333)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(114, 50)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(458, 333)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(118, 50)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'grossAdultSalesLabel
        '
        Me.grossAdultSalesLabel.BackColor = System.Drawing.Color.White
        Me.grossAdultSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grossAdultSalesLabel.Location = New System.Drawing.Point(186, 195)
        Me.grossAdultSalesLabel.Name = "grossAdultSalesLabel"
        Me.grossAdultSalesLabel.Size = New System.Drawing.Size(99, 20)
        Me.grossAdultSalesLabel.TabIndex = 3
        Me.grossAdultSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grossChildSalesLabel
        '
        Me.grossChildSalesLabel.BackColor = System.Drawing.Color.White
        Me.grossChildSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grossChildSalesLabel.Location = New System.Drawing.Point(186, 233)
        Me.grossChildSalesLabel.Name = "grossChildSalesLabel"
        Me.grossChildSalesLabel.Size = New System.Drawing.Size(99, 20)
        Me.grossChildSalesLabel.TabIndex = 3
        Me.grossChildSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grossTotalLabel
        '
        Me.grossTotalLabel.BackColor = System.Drawing.Color.White
        Me.grossTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grossTotalLabel.Location = New System.Drawing.Point(186, 265)
        Me.grossTotalLabel.Name = "grossTotalLabel"
        Me.grossTotalLabel.Size = New System.Drawing.Size(99, 19)
        Me.grossTotalLabel.TabIndex = 3
        Me.grossTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'netAdultSalesLabel
        '
        Me.netAdultSalesLabel.BackColor = System.Drawing.Color.White
        Me.netAdultSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.netAdultSalesLabel.Location = New System.Drawing.Point(499, 195)
        Me.netAdultSalesLabel.Name = "netAdultSalesLabel"
        Me.netAdultSalesLabel.Size = New System.Drawing.Size(99, 20)
        Me.netAdultSalesLabel.TabIndex = 3
        Me.netAdultSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'netChildSalesLabel
        '
        Me.netChildSalesLabel.BackColor = System.Drawing.Color.White
        Me.netChildSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.netChildSalesLabel.Location = New System.Drawing.Point(499, 233)
        Me.netChildSalesLabel.Name = "netChildSalesLabel"
        Me.netChildSalesLabel.Size = New System.Drawing.Size(99, 20)
        Me.netChildSalesLabel.TabIndex = 3
        Me.netChildSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'netTotalLabel
        '
        Me.netTotalLabel.BackColor = System.Drawing.Color.White
        Me.netTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.netTotalLabel.Location = New System.Drawing.Point(499, 265)
        Me.netTotalLabel.Name = "netTotalLabel"
        Me.netTotalLabel.Size = New System.Drawing.Size(99, 19)
        Me.netTotalLabel.TabIndex = 3
        Me.netTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 407)
        Me.Controls.Add(Me.netTotalLabel)
        Me.Controls.Add(Me.grossTotalLabel)
        Me.Controls.Add(Me.netChildSalesLabel)
        Me.Controls.Add(Me.grossChildSalesLabel)
        Me.Controls.Add(Me.netAdultSalesLabel)
        Me.Controls.Add(Me.grossAdultSalesLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.childTicketsSoldTextBox)
        Me.Controls.Add(Me.childTicketPriceTextBox)
        Me.Controls.Add(Me.adultsTicketsSoldTextBox)
        Me.Controls.Add(Me.adultTicketPriceTextBox)
        Me.Controls.Add(Me.childTicketPriceLabel)
        Me.Controls.Add(Me.childTicketsSoldLabel)
        Me.Controls.Add(Me.adultTicketPriceLabel)
        Me.Controls.Add(Me.adultTicketsSoldLabel)
        Me.Controls.Add(Me.grossTotalSaleLabel)
        Me.Controls.Add(Me.netTotalSaleLabel)
        Me.Controls.Add(Me.childGrossSaleLabel)
        Me.Controls.Add(Me.childNetSaleLabel)
        Me.Controls.Add(Me.adultGrossSaleLabel)
        Me.Controls.Add(Me.adultNetSaleLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.netTicketRevenueLabel)
        Me.Controls.Add(Me.grossTicketRevenueLabel)
        Me.Controls.Add(Me.adultTicketSaleLabel)
        Me.Name = "mainForm"
        Me.Text = "Theatre Revenue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents adultTicketSaleLabel As System.Windows.Forms.Label
    Friend WithEvents adultNetSaleLabel As System.Windows.Forms.Label
    Friend WithEvents netTicketRevenueLabel As System.Windows.Forms.Label
    Friend WithEvents childTicketPriceLabel As System.Windows.Forms.Label
    Friend WithEvents adultTicketsSoldLabel As System.Windows.Forms.Label
    Friend WithEvents childTicketsSoldLabel As System.Windows.Forms.Label
    Friend WithEvents grossTicketRevenueLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents childNetSaleLabel As System.Windows.Forms.Label
    Friend WithEvents netTotalSaleLabel As System.Windows.Forms.Label
    Friend WithEvents adultGrossSaleLabel As System.Windows.Forms.Label
    Friend WithEvents childGrossSaleLabel As System.Windows.Forms.Label
    Friend WithEvents grossTotalSaleLabel As System.Windows.Forms.Label
    Friend WithEvents adultTicketPriceLabel As System.Windows.Forms.Label
    Friend WithEvents adultTicketPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents adultsTicketsSoldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents childTicketPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents childTicketsSoldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grossAdultSalesLabel As System.Windows.Forms.Label
    Friend WithEvents grossChildSalesLabel As System.Windows.Forms.Label
    Friend WithEvents grossTotalLabel As System.Windows.Forms.Label
    Friend WithEvents netAdultSalesLabel As System.Windows.Forms.Label
    Friend WithEvents netChildSalesLabel As System.Windows.Forms.Label
    Friend WithEvents netTotalLabel As System.Windows.Forms.Label

End Class
