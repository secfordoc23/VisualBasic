'Project: BookClubPoints
'Me: mainForm.vb
'Date: 9/29/2015
'Author: Jason Welch
'Purpose: Display the number of points based on number of books entered

Option Explicit On
Option Strict On

'==============================mainForm================================\
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
        numBooksTextBox.Text = ""
        totalPointsLabel.Text = ""

        numBooksTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '======================================calculateButton_Click=====================================

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const NO_BOOKS As Short = 0S
        Const ONE_BOOK As Short = 5S
        Const TWO_BOOKS As Short = 15S
        Const THREE_BOOKS As Short = 30S
        Const FOUR_OR_GREATER As Short = 60S
        Dim numBooks As Short = 0S

        If Not Short.TryParse(numBooksTextBox.Text, numBooks) Then
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Select Case numBooks
            Case 1
                totalPointsLabel.Text = ONE_BOOK.ToString()
            Case 2
                totalPointsLabel.Text = TWO_BOOKS.ToString()
            Case 3
                totalPointsLabel.Text = THREE_BOOKS.ToString()
            Case Is > 4
                totalPointsLabel.Text = FOUR_OR_GREATER.ToString()
            Case Else
                totalPointsLabel.Text = NO_BOOKS.ToString()
        End Select

        clearButton.Focus()

    End Sub
End Class
