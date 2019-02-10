'Program: PhoneContactDisplay
'Me: mainForm.vb
'Date: 9/2/2015
'Author: Jason Welch
'Purpose: Display the phone number of clicked contact from list

Option Explicit On ' This means that variables need to be declared before use
Option Strict Off ' This means that I cannot implicitly change data types

'============================mainForm========================================
Public Class mainForm

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    '============================mainForm_FormClosing========================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    '============================exitButton_Click========================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub steveJobsButton_Click(sender As Object, e As EventArgs) Handles steveJobsButton.Click
        displayLabel.Text = "555-1234"
    End Sub

    Private Sub billGatesButton_Click(sender As Object, e As EventArgs) Handles billGatesButton.Click
        displayLabel.Text = "555-5678"
    End Sub

    Private Sub dennisRitchieButton_Click(sender As Object, e As EventArgs) Handles dennisRitchieButton.Click
        displayLabel.Text = "555-9123"
    End Sub

    Private Sub kenThompsonButton_Click(sender As Object, e As EventArgs) Handles kenThompsonButton.Click
        displayLabel.Text = "555-4567"
    End Sub

    Private Sub linusTorvaldsButton_Click(sender As Object, e As EventArgs) Handles linusTorvaldsButton.Click
        displayLabel.Text = "555-8912"
    End Sub

    Private Sub richardStallmanButton_Click(sender As Object, e As EventArgs) Handles richardStallmanButton.Click
        displayLabel.Text = "555-3456"
    End Sub
End Class
