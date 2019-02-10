'Project: PenniesForPay
'Me: mainForm.vb
'Date: 10/8/2015
'Author: Jason Welch
'Purpose: Display the total of pennies per day

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
        Dim index As Single = 0.0F

        For index = 0.01 To 0.1 Step 0.1
            numPenniesComboBox.Items.Add(index)
        Next index

        For index = 1 To 31
            numDaysComboBox.Items.Add(index)
        Next index

        numPenniesComboBox.SelectedIndex = 0
        numDaysComboBox.SelectedIndex = 0
    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        numPenniesComboBox.SelectedIndex = 0
        numDaysComboBox.SelectedIndex = 0
        displayListBox.Items.Clear()

        numPenniesComboBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim numDays As Short = 0S
        Dim pennies As Single = 0.0F
        Dim index As Short = 0S
        Dim total As Single = 0.0F

        numDays = CShort(numDaysComboBox.SelectedItem)
        pennies = CSng(numPenniesComboBox.SelectedItem)

        total = pennies

        displayListBox.Items.Add("Day" & vbTab & "Total")

        For index = 1 To numDays
            displayListBox.Items.Add(index & vbTab & total)

            total = total * 2
        Next index

        clearButton.Focus()
    End Sub
End Class
