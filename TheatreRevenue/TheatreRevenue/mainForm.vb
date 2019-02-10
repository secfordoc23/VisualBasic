'Project: PizzaPi
'Me: mainForm.vb
'Date: 9/17/2015
'Author: Jason Welch
'Purpose: Display the Gross and Net Ticket sales.

Option Explicit On
Option Strict On

'==============================mainForm================================
Public Class mainForm

    '======================================mainForm_FormClosing=====================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    '======================================mainForm_Load=====================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load Splash Screen
        splashForm.ShowDialog()


    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        adultTicketPriceTextBox.Text = ""
        adultsTicketsSoldTextBox.Text = ""
        childTicketPriceTextBox.Text = ""
        childTicketsSoldTextBox.Text = ""
        grossAdultSalesLabel.Text = ""
        grossChildSalesLabel.Text = ""
        grossTotalLabel.Text = ""
        netAdultSalesLabel.Text = ""
        netChildSalesLabel.Text = ""
        netTotalLabel.Text = ""

        adultTicketPriceTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim adultPrice As Decimal
        Dim childPrice As Decimal
        Dim childTickets As Short
        Dim adultTickets As Short
        Dim adultGross As Decimal
        Dim childGross As Decimal
        Dim adultNet As Decimal
        Dim childNet As Decimal
        Dim grossTotal As Decimal
        Dim netTotal As Decimal
        Const THEATRE_COST As Single = 0.2F

        Try
            adultPrice = CDec(adultTicketPriceTextBox.Text)
            childPrice = CDec(childTicketPriceTextBox.Text)

            adultTickets = CShort(adultsTicketsSoldTextBox.Text)
            childTickets = CShort(childTicketsSoldTextBox.Text)

            adultGross = adultPrice * adultTickets
            childGross = childPrice * childTickets
            grossTotal = adultGross + childGross

            grossAdultSalesLabel.Text = adultGross.ToString("C")
            grossChildSalesLabel.Text = childGross.ToString("C")
            grossTotalLabel.Text = grossTotal.ToString("C")

            adultNet = CDec(adultGross * THEATRE_COST)
            childNet = CDec(childGross * THEATRE_COST)
            netTotal = childNet + adultNet

            netAdultSalesLabel.Text = adultNet.ToString("C")
            netChildSalesLabel.Text = childNet.ToString("C")
            netTotalLabel.Text = netTotal.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        clearButton.Focus()
    End Sub
End Class
