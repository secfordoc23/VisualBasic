'Program: MilesPerGallon
'Me: mainForm.vb
'Date: 9/9/2015
'Author: Jason Welch
'Purpose: Calculate and Display the Miles per gallon

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

    '============================calculateButton_Click========================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim gallons As Single = 0S
        Dim milesPerTank As Single = 0S
        Dim milesPerGallon As Single = 0.0F
        Try
            gallons = CSng(gallonOfGasTextBox.Text)
            milesPerTank = CSng(milesPerTankTextBox.Text)
            milesPerGallon = milesPerTank / gallons
        Catch ex As Exception
            MessageBox.Show("Enter a Number!", "Invalid Input!")
        End Try


        mpgLabel.Text = milesPerGallon.ToString()
        clearButton.Focus()
    End Sub

    '============================clearButton_Click========================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        gallonOfGasTextBox.Text = "0"
        milesPerTankTextBox.Text = "0"
        mpgLabel.Text = ""

        gallonOfGasTextBox.Focus()
    End Sub

    '============================mainForm_Load========================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        splashForm.ShowDialog()
    End Sub
End Class
