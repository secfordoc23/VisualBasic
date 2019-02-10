Option Strict On
Option Explicit On
'Program: Grading
'Me: mainForm.vb
'Date: 1/24/2019
'Author: Jason Welch
'Purpose: A Program to enter 5 students' names and 5 grades per student, along with a total, average, and letter grade.

Imports System.ComponentModel

Public Class mainForm
    Private a_StudentNamesString() As String = {"Student One", "Student Two", "Student Three", "Student Four", "Student Five"}
    Private a_studentGradesSingle(,) As Single = {{0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}}
    '==========================================================================================
    'Name: mainForm_Load
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Loads project and activates the splash form
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        splashForm.ShowDialog()
        populateDisplayListBox()
        displayListBox.SelectedIndex = 0
    End Sub
    '==========================================================================================
    'Name: exitButton_Click
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: mainForm_Closing
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Gives user opportunity to not leave program
    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
    '==========================================================================================
    'Name: recordButton_Click
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Record the students' names and grades to an array
    Private Sub recordButton_Click(sender As Object, e As EventArgs) Handles recordButton.Click
        Dim currentIndexShort As Short = CShort(displayListBox.SelectedIndex)

        a_StudentNamesString(currentIndexShort) = nameTextBox.Text
        Try
            If CSng(grade1ValueTextBox.Text) > -1S AndAlso CSng(grade1ValueTextBox.Text) < 101S Then
                a_studentGradesSingle(currentIndexShort, 0) = CSng(grade1ValueTextBox.Text)
            End If
            If CSng(grade2ValueTextBox.Text) > -1S AndAlso CSng(grade2ValueTextBox.Text) < 101S Then
                a_studentGradesSingle(currentIndexShort, 1) = CSng(grade2ValueTextBox.Text)
            End If
            If CSng(grade3ValueTextBox.Text) > -1S AndAlso CSng(grade3ValueTextBox.Text) < 101S Then
                a_studentGradesSingle(currentIndexShort, 2) = CSng(grade3ValueTextBox.Text)
            End If
            If CSng(grade4ValueTextBox.Text) > -1S AndAlso CSng(grade4ValueTextBox.Text) < 101S Then
                a_studentGradesSingle(currentIndexShort, 3) = CSng(grade4ValueTextBox.Text)
            End If
            If CSng(grade5ValueTextBox.Text) > -1S AndAlso CSng(grade5ValueTextBox.Text) < 101S Then
                a_studentGradesSingle(currentIndexShort, 4) = CSng(grade5ValueTextBox.Text)
            End If
            populateValueLabels()
            populateDisplayListbox()
            displayListBox.SelectedIndex = currentIndexShort
        Catch ex As Exception
            MsgBox("Error")
            grade1ValueTextBox.Focus()
        End Try

    End Sub
    '==========================================================================================
    'Name: populateDisplayListBox
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Show the Students' names and grades
    Private Sub populateDisplayListbox()
        displayListBox.Items.Clear()
        For rowShort As Short = 0 To CShort(a_StudentNamesString.Count - 1)
            Dim entryString As String = ""
            entryString = a_StudentNamesString(rowShort) & " = "
            For colShort As Short = 0S To 4S
                entryString &= a_studentGradesSingle(rowShort, colShort).ToString & ", "
            Next colShort
            displayListBox.Items.Add(entryString)
        Next rowShort
    End Sub
    '==========================================================================================
    'Name: populateTextboxes
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Updates Textboxes based on Selected Index of Listbox
    Private Sub populateTextboxes()
        nameTextBox.Text = a_StudentNamesString(displayListBox.SelectedIndex)
        grade1ValueTextBox.Text = a_studentGradesSingle(displayListBox.SelectedIndex, 0).ToString()
        grade2ValueTextBox.Text = a_studentGradesSingle(displayListBox.SelectedIndex, 1).ToString()
        grade3ValueTextBox.Text = a_studentGradesSingle(displayListBox.SelectedIndex, 2).ToString()
        grade4ValueTextBox.Text = a_studentGradesSingle(displayListBox.SelectedIndex, 3).ToString()
        grade5ValueTextBox.Text = a_studentGradesSingle(displayListBox.SelectedIndex, 4).ToString()
    End Sub
    '==========================================================================================
    'Name: populateValueLabels
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Updates Value Labels 
    Private Sub populateValueLabels()
        Dim gradeTotalShort As Short = 0
        Dim gradeAverageDecimal As Decimal = 0.0D

        gradeTotalShort = calculateGradeTotal()
        gradeAverageDecimal = calculateGradeAverage(gradeTotalShort)

        totalValueLabel.Text = gradeTotalShort.ToString()
        averageValueLabel.Text = gradeAverageDecimal.ToString()
        letterValueLabel.Text = calculateLetterGrade(gradeAverageDecimal)
    End Sub
    '==========================================================================================
    'Name: displayListBox_SelectedIndexChanged
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Populate Labels and Texboxes on Selected index change 
    Private Sub displayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles displayListBox.SelectedIndexChanged
        populateValueLabels()
        populateTextboxes()
    End Sub
    '==========================================================================================
    'Name: calculateGradeTotal
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Calculate Grade Total
    Private Function calculateGradeTotal() As Short
        Dim totalGradeShort As Short = 0S

        For countShort As Short = 0 To CShort(a_studentGradesSingle.GetLength(0) - 1)
            totalGradeShort += CShort(a_studentGradesSingle(displayListBox.SelectedIndex, countShort))
        Next countShort

        Return totalGradeShort
    End Function
    '==========================================================================================
    'Name: calculateGradeAverage
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Calculate Grade Average Given a grade total
    Private Function calculateGradeAverage(ByVal gradeTotalShort As Short) As Decimal
        Dim gradeAverageDecimal As Decimal = 0.0D

        gradeAverageDecimal = CDec(gradeTotalShort / a_studentGradesSingle.GetLength(0))

        Return gradeAverageDecimal
    End Function

    '==========================================================================================
    'Name: calculateGradeAverage
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Calculate Letter Grade Given an Average grade
    Private Function calculateLetterGrade(ByVal gradeAverageDecimal As Decimal) As String
        Dim letterGradeString As String = ""
        If gradeAverageDecimal <= 100 AndAlso gradeAverageDecimal >= 90 Then
            letterGradeString = "A"
        ElseIf gradeAverageDecimal <= 89 AndAlso gradeAverageDecimal >= 80 Then
            letterGradeString = "B"
        ElseIf gradeAverageDecimal <= 79 AndAlso gradeAverageDecimal >= 70 Then
            letterGradeString = "C"
        ElseIf gradeAverageDecimal <= 69 AndAlso gradeAverageDecimal >= 60 Then
            letterGradeString = "D"
        Else
            letterGradeString = "F"
        End If

        Return letterGradeString
    End Function
    '==========================================================================================
    'Name: clearButton_Click
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: Clears all textboxes and labels
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Text = ""
        grade1ValueTextBox.Text = "0"
        grade2ValueTextBox.Text = "0"
        grade3ValueTextBox.Text = "0"
        grade4ValueTextBox.Text = "0"
        grade5ValueTextBox.Text = "0"

        totalValueLabel.Text = ""
        averageValueLabel.Text = ""
        letterValueLabel.Text = ""
    End Sub
End Class
'================================== No Code Follows ===========================================
