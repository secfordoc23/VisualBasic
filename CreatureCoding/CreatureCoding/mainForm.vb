'Project: CreatureCoding
'Me: mainForm.vb
'Date: 10/29/2015
'Author: Jason Welch
'Purpose: Display the creature code based on which creature is selected from a listbox

Option Explicit On
Option Strict On

'==============================mainForm================================
Public Class mainForm
    Private creatureString() As String = {"Blood Donors", "Shape Shifter", "Ghost", "Witch", "Warlock", "Chimaera", "Zombie", "Japanese (Godzilla, Mothra, Gamera)", "Vampires"}
    Private codesShort() As Short = {100, 200, 300, 400, 500, 600, 700, 800, 900}

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

        For Each elementString As String In creatureString
            creatureListBox.Items.Add(elementString)
        Next elementString

    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        codeLabel.Text = ""

        creatureListBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub creatureListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles creatureListBox.SelectedIndexChanged
        codeLabel.Text = codesShort(creatureListBox.SelectedIndex).ToString()

    End Sub
End Class
