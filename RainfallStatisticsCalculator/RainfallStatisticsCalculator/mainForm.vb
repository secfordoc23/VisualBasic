'Project: RainfallStatisticscalculator
'Me: mainForm.vb
'Date: 10/8/2015
'Author: Jason Welch
'Purpose: Display the Calculated Total and Average rainfall of based on monthly data

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
        totalRainLabel.Text = ""
        avgRainLabel.Text = ""

        calculateButton.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const NUM_MONTHS As Short = 12S
        Dim totalRainfall As Single = 0.0F
        Dim monthlyRainfall As Single = 0.0F
        Dim avgRainfall As Single = 0.0F
        Dim index As Short = 0S

        For index = 1 To NUM_MONTHS
            Dim isValid As Boolean
            Dim input As String

            Do
                input = InputBox("Enter number of" & ControlChars.CrLf & "inches for the month: ", "Month " & index, "0")
                If Single.TryParse(input, monthlyRainfall) Then
                    isValid = True
                End If
            Loop Until isValid = True

            totalRainfall = totalRainfall + monthlyRainfall
        Next index

        avgRainfall = totalRainfall / NUM_MONTHS

        totalRainLabel.Text = totalRainfall.ToString()
        avgRainLabel.Text = avgRainfall.ToString()

        clearButton.Focus()
    End Sub
End Class
