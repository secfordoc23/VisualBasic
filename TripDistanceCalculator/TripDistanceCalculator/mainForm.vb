'Project: TripDistanceCalculator
'Me: mainForm.vb
'Date: 10/8/2015
'Author: Jason Welch
'Purpose: Display the distance per hour and total distance

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
        speedTextBox.Text = ""
        totalTimeTextBox.Text = ""
        distanceListBox.Items.Clear()

        speedTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim avgSpeed As Short = 0S
        Dim totalTime As Short = 0S
        Dim distance As Short = 0S
        Dim hour As Short = 0S

        If Not Short.TryParse(speedTextBox.Text, avgSpeed) Then
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If Not Short.TryParse(totalTimeTextBox.Text, totalTime) Then
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        distanceListBox.Items.Add("Hours" & vbTab & "Distance Traveled")
        distanceListBox.Items.Add("*********************************")

        For hour = 1 To totalTime
            distance = (hour * avgSpeed)
            distanceListBox.Items.Add(hour & vbTab & distance)

        Next hour
        distanceListBox.Items.Add("Total Distance: " & distance)

        clearButton.Focus()
    End Sub
End Class
