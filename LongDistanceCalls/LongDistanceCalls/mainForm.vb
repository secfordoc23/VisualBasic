'Project: LongDistanceCalls
'Me: mainForm.vb
'Date: 9/29/2015
'Author: Jason Welch
'Purpose: Display the calculated bill pased on number of minutes used and time call was made

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
        minutesTextBox.Text = ""
        totalLabel.Text = ""

        minutesTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const DAYTIME As Single = 0.07F
        Const EVENING As Single = 0.12F
        Const OFF_PEAK As Single = 0.05F
        Dim minutesUsed As Short
        Dim total As Decimal

        If Not Short.TryParse(minutesTextBox.Text, minutesUsed) Then
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If daytimeRadioButton.Checked = True Then
            total = CDec(minutesUsed * DAYTIME)
        ElseIf eveningRadioButton.Checked = True Then
            total = CDec(minutesUsed * EVENING)
        Else
            total = CDec(minutesUsed * OFF_PEAK)
        End If

        totalLabel.Text = total.ToString("C")

        clearButton.Focus()

    End Sub
End Class
