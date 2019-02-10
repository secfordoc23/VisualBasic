'Program: KindergartenGradesAndAttendance
'Me: addDailyGradeForm.vb
'Date: 1/21/2019
'Author: Jason Welch
'Purpose: Form to Add a Students Daily Grade


Option Explicit On
Option Strict On

'===============================================
'==           addDailyGradeForm               ==
'===============================================
Public Class addDailyGradeForm
    Private dailyGradeShort() As Short = {4, 3, 2, 1, 0}

    '=====================================
    '==           addButton_Click       ==
    '=====================================
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        studentsDailyGradeShort(studentListBox.SelectedIndex, sessionNumberComboBox.SelectedIndex) = dailyGradeShort(dailyGradeComboBox.SelectedIndex)
        studentListBox.Items.Clear()
        dailyGradeComboBox.Items.Clear()
        sessionNumberComboBox.Items.Clear()
        Me.Close()
    End Sub
    '================================================
    '==           addDailyGradeForm_Activated      ==
    '================================================
    Private Sub addDailyGradeForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        updateDailyGradeCombobox()
        updateSessionNumberCombobox()
        updateStudentListbox()
    End Sub
    '================================================
    '==           updateDailyGradeCombobox         ==
    '================================================
    Private Sub updateDailyGradeCombobox()
        For Each gradeShort As Short In dailyGradeShort
            dailyGradeComboBox.Items.Add(gradeShort)
        Next gradeShort
        dailyGradeComboBox.SelectedIndex = 0
    End Sub
    '================================================
    '==           updateSessionNumberCombobox      ==
    '================================================
    Private Sub updateSessionNumberCombobox()
        For countShort As Short = 1 To sessionsShort
            sessionNumberComboBox.Items.Add(countShort)
        Next
        sessionNumberComboBox.SelectedIndex = 0
    End Sub
    '================================================
    '==           updateStudentListbox            ==
    '================================================
    Private Sub updateStudentListbox()
        For countShort As Short = 0 To (studentCountShort - 1S)
            studentListBox.Items.Add(studentsString(countShort, 2) & ", " & studentsString(countShort, 1))
        Next countShort
        studentListBox.SelectedIndex = 0
    End Sub
End Class
'=====================================
'==           NO CODE FOLLOWS       ==
'=====================================
