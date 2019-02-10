'Project: DiceSimulator
'Me: mainForm.vb
'Date: 10/14/2015
'Author: Jason Welch
'Purpose: Display the simulated roll of 100 dice and there number counts

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
        twoLabel.Text = ""
        threeLabel.Text = ""
        fourLabel.Text = ""
        fiveLabel.Text = ""
        sixLabel.Text = ""
        sevenLabel.Text = ""
        eightLabel.Text = ""
        nineLabel.Text = ""
        tenLabel.Text = ""
        elevenLabel.Text = ""
        twelveLabel.Text = ""

        displayListBox.Items.Clear()

        calculateButton.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim index As Short = 0S
        Dim rand As New Random
        Dim diceRollOneShort As Short
        Dim diceRollTwoShort As Short
        Dim rollTotalShort As Short
        Dim twoCounter As Short = 0S
        Dim threeCounter As Short = 0S
        Dim fourCounter As Short = 0S
        Dim fiveCounter As Short = 0S
        Dim sixCounter As Short = 0S
        Dim sevenCounter As Short = 0S
        Dim eightCounter As Short = 0S
        Dim nineCounter As Short = 0S
        Dim tenCounter As Short = 0S
        Dim elevenCounter As Short = 0S
        Dim twelveCounter As Short = 0S


        For index = 1 To 100
            diceRollOneShort = CShort(rand.Next(6) + 1)
            diceRollTwoShort = CShort(rand.Next(6) + 1)

            rollTotalShort = diceRollOneShort + diceRollTwoShort

            Select Case rollTotalShort
                Case 2
                    twoCounter += 1S
                Case 3
                    threeCounter += 1S
                Case 4
                    fourCounter += 1S
                Case 5
                    fiveCounter += 1S
                Case 6
                    sixCounter += 1S
                Case 7
                    sevenCounter += 1S
                Case 8
                    eightCounter += 1S
                Case 9
                    nineCounter += 1S
                Case 10
                    tenCounter += 1S
                Case 11
                    elevenCounter += 1S
                Case 12
                    twelveCounter += 1S
            End Select

            displayListBox.Items.Add(diceRollOneShort & " + " & diceRollTwoShort & " = " & rollTotalShort)

        Next index

        twoLabel.Text = twoCounter.ToString()
        threeLabel.Text = threeCounter.ToString()
        fourLabel.Text = fourCounter.ToString()
        fiveLabel.Text = fiveCounter.ToString()
        sixLabel.Text = sixCounter.ToString()
        sevenLabel.Text = sevenCounter.ToString()
        eightLabel.Text = eightCounter.ToString()
        nineLabel.Text = nineCounter.ToString()
        tenLabel.Text = tenCounter.ToString()
        elevenLabel.Text = elevenCounter.ToString()
        twelveLabel.Text = twelveCounter.ToString()

        clearButton.Focus()

    End Sub
End Class
