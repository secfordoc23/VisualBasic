'Project: KindergartenGradesAndAttendance
'Me: mainForm.vb
'Date: 1/21/2019
'Author: Jason Welch
'Purpose: A program to Collect Kindergarten Students information and Display there daily grade


Option Explicit On
Option Strict On


Imports System.ComponentModel
'=====================================
'==           mainForm              ==
'=====================================
Public Class mainForm
    Private numberOfSessionsShort() As Short = {20, 21, 22, 23}

    '=====================================
    '==           mainForm_Load         ==
    '=====================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
        updateNumberOfSessionsCombobox()
        studentCountTextBox.Text = studentCountShort.ToString()
        openCountTextBox.Text = (calculateAvailablity(studentCountShort)).ToString()
    End Sub
    '=====================================
    '==           exitButton_Click      ==
    '=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    '=====================================
    '==           mainForm_Closing      ==
    '=====================================
    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    '=======================================
    '==           addStudentButton_Click  ==
    '=======================================
    Private Sub addStudentButton_Click(sender As Object, e As EventArgs) Handles addStudentButton.Click
        addStudentForm.ShowDialog()
    End Sub
    '=============================================
    '==           viewStudentsButton_Click      ==
    '=============================================
    Private Sub viewStudentsButton_Click(sender As Object, e As EventArgs) Handles viewStudentsButton.Click
        If (studentCountShort > 0) Then
            viewStudentForm.ShowDialog()
        Else
            MessageBox.Show("There currently are no students to view! ", "No Students", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

    End Sub
    '====================================================
    '==           updateNumberOfSessionsCombobox       ==
    '====================================================
    Private Sub updateNumberOfSessionsCombobox()
        For Each sessionShort As Short In numberOfSessionsShort
            numberOfSessionsComboBox.Items.Add(sessionShort)
        Next sessionShort
        numberOfSessionsComboBox.SelectedIndex = 0

    End Sub
    '====================================================
    '==           updateNumberOfSessionsCombobox       ==
    '====================================================
    Private Sub numberOfSessionsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numberOfSessionsComboBox.SelectedIndexChanged
        sessionsShort = numberOfSessionsShort(numberOfSessionsComboBox.SelectedIndex)
    End Sub
    '====================================================
    '==           printStudentReportButton_Click        ==
    '====================================================
    Private Sub printStudentReportButton_Click(sender As Object, e As EventArgs) Handles printStudentReportButton.Click
        MessageBox.Show("Currently this option has not been implemented yet! ", "Option Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
    '====================================================
    '==           addDailyGradeButton_Click            ==
    '====================================================
    Private Sub addDailyGradeButton_Click(sender As Object, e As EventArgs) Handles addDailyGradeButton.Click
        If (studentCountShort > 0) Then
            addDailyGradeForm.ShowDialog()
        Else
            MessageBox.Show("There currently are no students to add a daily grade! ", "No Students", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class
'=====================================
'==           NO CODE FOLLOWS       ==
'=====================================
