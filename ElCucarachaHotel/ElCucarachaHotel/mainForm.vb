'Project: ElCucarachaHotel
'Me: mainForm.vb
'Date: 10/14/2015
'Author: Jason Welch
'Purpose: Display the hotel floor occupancy

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
        totalRoomAmountLabel.Text = ""
        overAllOccLabel.Text = ""


        displayListBox.Items.Clear()

        completeButton.Focus()

    End Sub
    '===============================completeButton_Click=========================================
    Private Sub completeButton_Click(sender As Object, e As EventArgs) Handles completeButton.Click
        Const FLOORS As Short = 8S
        Const ROOMS As Short = 30S
        Const TOTAL As Short = FLOORS * ROOMS
        Dim index As Short = 0S
        Dim totalRoomsOcc As Single = 0.0F 'accumulates total num rooms
        Dim overallPercentage As Single = 0.0F


        For index = 1 To FLOORS
            Dim occupied As Short
            Dim percentFloor As Single
            Dim input As String
            Dim isValid As Boolean

            Do
                input = InputBox("Enter number of " & ControlChars.CrLf & "rooms occupied: ", "Floor " & index, "0")
                If Short.TryParse(input, occupied) Then
                    isValid = True
                End If
            Loop Until isValid = True AndAlso occupied > -1 AndAlso occupied <= ROOMS
            percentFloor = CSng((occupied / ROOMS) * 100)

            totalRoomsOcc += occupied

            displayListBox.Items.Add("Floor " & index & " Rooms Occupied: " & occupied & " Occupancy Rate: " & percentFloor.ToString("N2") & "%")
        Next index

        overallPercentage = CSng((totalRoomsOcc / TOTAL) * 100)

        totalRoomAmountLabel.Text = totalRoomsOcc.ToString()
        overAllOccLabel.Text = overallPercentage.ToString("N2") & "%"

        clearButton.Focus()


    End Sub
End Class
