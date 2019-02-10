'Program: KindergartenGradesAndAttendance
'Me: addStudentForm.vb
'Date: 1/21/2019
'Author: Jason Welch
'Purpose: Collect a New Students Information


Option Explicit On
Option Strict On

'=====================================
'==           addStudentForm        ==
'=====================================
Public Class addStudentForm
    Private allergyList As New List(Of String)

    '=====================================
    '==           addButton_Click       ==
    '=====================================
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        studentCountShort += CShort(1)
        studentsString(studentCountShort - 1S, 0) = studentCountShort.ToString
        studentsString(studentCountShort - 1S, 1) = firstNameTextBox.Text
        studentsString(studentCountShort - 1S, 2) = lastNameTextBox.Text
        studentsString(studentCountShort - 1S, 3) = parentNameTextBox.Text
        studentsString(studentCountShort - 1S, 4) = phoneNumberTextBox.Text

        If (allergyList(allergyComboBox.SelectedIndex).Equals("Other")) Then
            studentsString(studentCountShort - 1S, 5) = otherAllergyTextBox.Text
        Else
            studentsString(studentCountShort - 1S, 5) = allergyList(allergyComboBox.SelectedIndex)
        End If
        studentsString(studentCountShort - 1S, 6) = "0"
        studentsString(studentCountShort - 1S, 7) = "0"

        mainForm.studentCountTextBox.Text = studentCountShort.ToString()
        mainForm.openCountTextBox.Text = (calculateAvailablity(studentCountShort)).ToString()
        Me.Close()
    End Sub
    '=====================================
    '==           updateComboBox()      ==
    '=====================================
    Private Sub updateComboBox()
        allergyComboBox.Items.Clear()

        For Each allergyString As String In allergyList
            allergyComboBox.Items.Add(allergyString)
        Next allergyString
        allergyComboBox.SelectedIndex = 0

    End Sub
    '==========================================================
    '==           allergyComboBox_SelectedIndexChanged       ==
    '==========================================================
    Private Sub allergyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles allergyComboBox.SelectedIndexChanged
        If (allergyList(allergyComboBox.SelectedIndex).Equals("Other")) Then
            otherAllergyTextBox.ReadOnly = False
        Else
            otherAllergyTextBox.ReadOnly = True
        End If

    End Sub
    '=============================================
    '==           addStudentForm_Activated      ==
    '=============================================
    Private Sub addStudentForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        allergyList.Add("Bees")
        allergyList.Add("Peanuts")
        allergyList.Add("Dairy")
        allergyList.Add("Asthma")
        allergyList.Add("Other")

        updateComboBox()
        lastNameTextBox.Select()
    End Sub
End Class
'=====================================
'==           NO CODE FOLLOWS       ==
'=====================================