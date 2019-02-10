'Program: TestScoreAverage
'Me: mainForm.vb
'Date: 9/10/2015
'Author: Jason Welch
'Purpose: Calculate 5 test scores to find there average

Option Explicit On ' This means that variables need to be declared before use
Option Strict Off ' This means that I cannot implicitly change data types

'============================mainForm========================================
Public Class mainForm
    '============================exitButton_Click========================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    '============================mainForm_FormClosing========================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    '============================clearButton_Click========================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        score1TextBox.Text = "0"
        score2TextBox.Text = "0"
        score3TextBox.Text = "0"
        score4TextBox.Text = "0"
        score5TextBox.Text = "0"
        displayAverageLabel.Text = ""

        score1TextBox.Focus()
    End Sub

    '============================mainForm_Load========================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        splashForm.ShowDialog()
    End Sub

    '============================calculateButton_Click========================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim score1 As Short = 0S
        Dim score2 As Short = 0S
        Dim score3 As Short = 0S
        Dim score4 As Short = 0S
        Dim score5 As Short = 0S
        Dim sum As Single = 0.0F
        Dim average As Single = 0.0F


        Try
            score1 = CShort(score1TextBox.Text)
            score2 = CShort(score2TextBox.Text)
            score3 = CShort(score3TextBox.Text)
            score4 = CShort(score4TextBox.Text)
            score5 = CShort(score5TextBox.Text)

            sum = score1 + score2 + score3 + score4 + score5

            average = sum / 5.0F

        Catch ex As Exception
            MessageBox.Show("Enter a Number!", "Invalid Input!")
        End Try
        displayAverageLabel.Text = average.ToString()
        clearButton.Focus()
    End Sub
End Class
