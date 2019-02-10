'Project: RaceResults
'Me: mainForm.vb
'Date: 9/23/2015
'Author: Jason Welch
'Purpose: Display the Winners of a Race

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
        runner1NameTextBox.Text = ""
        runner2NameTextBox.Text = ""
        runner3NameTextBox.Text = ""
        runner1TimeTextBox.Text = ""
        runner2TimeTextBox.Text = ""
        runner3TimeTextBox.Text = ""
        firstPlaceNameLabel.Text = ""
        secondPlaceNameLabel.Text = ""
        thirdPlaceNameLabel.Text = ""


        runner1NameTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim runnerOneTime As Short
        Dim runnerTwoTime As Short
        Dim runnerThreeTime As Short

        Try
            runnerOneTime = CShort(runner1TimeTextBox.Text)
            runnerTwoTime = CShort(runner2TimeTextBox.Text)
            runnerThreeTime = CShort(runner3TimeTextBox.Text)

            If runnerOneTime < runnerTwoTime And runnerOneTime < runnerThreeTime Then
                firstPlaceNameLabel.Text = runner1NameTextBox.Text
                If runnerTwoTime < runnerThreeTime Then
                    secondPlaceNameLabel.Text = runner2NameTextBox.Text
                    thirdPlaceNameLabel.Text = runner3NameTextBox.Text
                Else
                    secondPlaceNameLabel.Text = runner3NameTextBox.Text
                    thirdPlaceNameLabel.Text = runner2NameTextBox.Text
                End If

            ElseIf runnerTwoTime < runnerOneTime And runnerTwoTime < runnerThreeTime Then
                firstPlaceNameLabel.Text = runner2NameTextBox.Text
                If runnerOneTime < runnerThreeTime Then
                    secondPlaceNameLabel.Text = runner1NameTextBox.Text
                    thirdPlaceNameLabel.Text = runner3NameTextBox.Text
                Else
                    secondPlaceNameLabel.Text = runner3NameTextBox.Text
                    thirdPlaceNameLabel.Text = runner1NameTextBox.Text
                End If

            Else
                firstPlaceNameLabel.Text = runner3NameTextBox.Text
                If runnerOneTime < runnerTwoTime Then
                    secondPlaceNameLabel.Text = runner1NameTextBox.Text
                    thirdPlaceNameLabel.Text = runner2NameTextBox.Text
                Else
                    secondPlaceNameLabel.Text = runner2NameTextBox.Text
                    thirdPlaceNameLabel.Text = runner1NameTextBox.Text
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Please input a Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
