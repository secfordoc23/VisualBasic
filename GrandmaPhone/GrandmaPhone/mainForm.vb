'Project: GrandmaPhone
'Me: mainForm.vb
'Date: 11/11/2015
'Author: Jason Welch
'Purpose: To Display a list of phone numbers with ability to add and remove names

Option Explicit On
Option Strict On

'============================== mainForm ================================
Public Class mainForm
    Private nameList As New List(Of String)
    Private numbersList As New List(Of String)

    '======================================mainForm_FormClosing=====================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    '======================================mainForm_Load=====================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()

        nameList.Add("Ringo Star")
        nameList.Add("Paul M.")
        nameList.Add("George H.")
        nameList.Add("John Lennon")
        nameList.Add("Paul Simon")
        nameList.Add("Art Garfunkel")
        nameList.Add("Neil D.")
        nameList.Add("Donny O.")
        nameList.Add("Marie O.")
        nameList.Add("Ed Sullivan")

        numbersList.Add("555-1234")
        numbersList.Add("555-4321")
        numbersList.Add("555-3412")
        numbersList.Add("555-2341")
        numbersList.Add("555-0001")
        numbersList.Add("555-0010")
        numbersList.Add("555-0100")
        numbersList.Add("555-1000")
        numbersList.Add("555-1001")
        numbersList.Add("555-0110")

        updateListbox()
    End Sub

    '======================================namesListBox_SelectedIndexChanged=====================================
    Private Sub namesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles namesListBox.SelectedIndexChanged
        phoneNumberLabel.Text = numbersList(namesListBox.SelectedIndex)
    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '======================================addButton_Click=====================================
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim nameString As String
        Dim numberString As String

        nameString = InputBox("Enter Name: ", "Phone Contact")
        numberString = InputBox("Enter Phone number: ", "Phone Number")

        nameList.Add(nameString)
        numbersList.Add(numberString)

        updateListbox()
    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        If (MessageBox.Show("Do you want to remove " & nameList(namesListBox.SelectedIndex) & "?", "Remove Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then

        Else
            numbersList.Remove(numbersList(namesListBox.SelectedIndex))
            nameList.Remove(nameList(namesListBox.SelectedIndex))
        End If

        updateListbox()
    End Sub

    Private Sub updateListbox()
        namesListBox.Items.Clear()
        For Each updatedNameString As String In nameList
            namesListBox.Items.Add(updatedNameString)
        Next updatedNameString

        namesListBox.SelectedIndex = 0
    End Sub
End Class
