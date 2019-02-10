'Program: KindergartenGradesAndAttendance
'Me: splashForm.vb
'Date: 1/21/2019
'Author: Jason Welch
'Purpose: Form to Display Student Information


Option Explicit On
Option Strict On

'=====================================
'==           viewStudentForm       ==
'=====================================
Public Class viewStudentForm
    '===============================================
    '==           viewStudentForm_Activated       ==
    '===============================================
    Private Sub viewStudentForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        updateStudentListbox()
    End Sub
    '=====================================
    '==           closeButton_Click     ==
    '=====================================
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        studentListBox.Items.Clear()
        studentInformationListBox.Items.Clear()
        dailyGradeListBox.Items.Clear()
        Me.Close()
    End Sub
    '=======================================================
    '==           studentListBox_SelectedIndexChanged     ==
    '=======================================================
    Private Sub studentListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentListBox.SelectedIndexChanged
        updateDailyGradeListbox()
        calculateNumberOfAbsences()
        calculateGradeAverage()

        For countShort As Short = 0 To CShort(reportNamesString.Count)
            studentInformationListBox.Items.Add(reportNamesString(countShort) & ": " & studentsString(studentListBox.SelectedIndex, countShort))
        Next
    End Sub
    '=====================================
    '==           closeButton_Click     ==
    '=====================================
    Private Sub updateStudentListbox()
        For countShort As Short = 0 To (studentCountShort - 1S)
            studentListBox.Items.Add(studentsString(countShort, 2) & ", " & studentsString(countShort, 1))
        Next countShort

        studentListBox.SelectedIndex = 0
    End Sub
    '=========================================
    '==           calculateGradeAverage     ==
    '=========================================
    Private Sub calculateGradeAverage()
        Dim gradeAverageShort As Short = 0
        Dim totalShort As Short = 0
        For countShort As Short = 1 To sessionsShort
            totalShort += studentsDailyGradeShort(studentListBox.SelectedIndex, countShort - 1)
        Next
        studentsString(studentListBox.SelectedIndex, 6) = CDec(totalShort / sessionsShort).ToString()
    End Sub
    '=============================================
    '==           calculateNumberOfAbsences     ==
    '=============================================
    Private Sub calculateNumberOfAbsences()
        Dim absenceCount As Short = 0
        For countShort As Short = 1 To sessionsShort
            If (studentsDailyGradeShort(studentListBox.SelectedIndex, countShort - 1) = 0) Then
                absenceCount += 1S
            End If
        Next
        studentsString(studentListBox.SelectedIndex, 7) = absenceCount.ToString()
    End Sub
    '==========================================
    '==           updateDailyGradeListbox    ==
    '==========================================
    Private Sub updateDailyGradeListbox()
        For countShort As Short = 1 To sessionsShort
            dailyGradeListBox.Items.Add("Session " & countShort & ": " & studentsDailyGradeShort(studentListBox.SelectedIndex, countShort - 1))
        Next
    End Sub
End Class
'=====================================
'==           NO CODE FOLLOWS       ==
'=====================================