
'Program: StateAbbriviations
'Me: mainForm.vb
'Date: 9/2/2015
'Author: Jason Welch
'Purpose: Display the State Abbriviations when the States button is clicked

Option Explicit On ' This means that variables need to be declared before use
Option Strict Off ' This means that I cannot implicitly change data types

'============================mainForm========================================
Public Class mainForm
    '============================mainForm_FormClosing========================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    '============================Form_Load========================================
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    '============================exitButton_Click========================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    '============================virginiaButton_Click========================================
    Private Sub virginiaButton_Click(sender As Object, e As EventArgs) Handles virginiaButton.Click
        displayLabel.Text = "VA"
    End Sub

    '============================northCarolinaButton_Click========================================
    Private Sub northCarolinaButton_Click(sender As Object, e As EventArgs) Handles northCarolinaButton.Click
        displayLabel.Text = "NC"
    End Sub

    '============================southCarolinaButton_Click========================================
    Private Sub southCarolinaButton_Click(sender As Object, e As EventArgs) Handles southCarolinaButton.Click
        displayLabel.Text = "SC"
    End Sub

    '============================georgiaButton_Click========================================
    Private Sub georgiaButton_Click(sender As Object, e As EventArgs) Handles georgiaButton.Click
        displayLabel.Text = "GA"
    End Sub

    '============================alabamaButton_Click========================================
    Private Sub alabamaButton_Click(sender As Object, e As EventArgs) Handles alabamaButton.Click
        displayLabel.Text = "AL"
    End Sub

    '============================floridaButton_Click========================================
    Private Sub floridaButton_Click(sender As Object, e As EventArgs) Handles floridaButton.Click
        displayLabel.Text = "FL"
    End Sub
End Class
