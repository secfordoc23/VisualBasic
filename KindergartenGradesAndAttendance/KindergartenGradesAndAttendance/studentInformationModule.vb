'Program: KindergartenGradesAndAttendance
'Me: studentInformationModule.vb
'Date: 1/21/2019
'Author: Jason Welch
'Purpose: Collection of Variables and Functions to be used between forms


Option Explicit On
Option Strict On

'===============================================
'==           studentInformationModule        ==
'===============================================
Module studentInformationModule
    Public reportNamesString() As String = {"Student Number", "First Name", "Last Name", "Parent's Name", "Contact Number", "Allergy", "Grade Average", "Number Of Absences"}
    Public studentsString(15, 8) As String
    Public studentsDailyGradeShort(15, 23) As Short
    Public sessionsShort As Short
    Public studentCountShort As Short = 0

    '=====================================
    '==           calculateAvailablity  ==
    '=====================================
    Public Function calculateAvailablity(ByVal studentCountShort As Short) As Short
        Dim availableCount As Short
        availableCount = CShort(15 - studentCountShort)
        Return availableCount
    End Function
    '=====================================
    '==           calculateGradeAverage ==
    '=====================================
    Public Function calculateGradeAverage(ByVal gradeList As List(Of Short)) As Decimal
        Dim gradeAverageDecimal As Decimal = CDec(0.0)
        Dim totalGradeShort As Short = CShort(0)

        For Each gradeShort As Short In gradeList
            totalGradeShort += CShort(gradeShort)
        Next gradeShort

        gradeAverageDecimal = CDec(totalGradeShort / gradeList.Count)

        Return gradeAverageDecimal
    End Function

End Module
'=====================================
'==           NO CODE FOLLOWS       ==
'=====================================
