'Program: parentForm
'Me: readForm.vb
'Date: 2/10/2019
'Author: Jason Welch
'Purpose: Writes records to the specified file

Option Strict On
Option Explicit On
Imports System.IO

Public Class entryForm
    '==========================================================================================
    'Name: saveRecordButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Writes a Record to a specified file
    Private Sub saveRecordButton_Click(sender As Object, e As EventArgs) Handles saveRecordButton.Click
        Try
            Dim outputFile As StreamWriter
            outputFile = File.AppendText(m_fileNameString)
            With outputFile
                .WriteLine(firstNameTextBox.Text)
                .WriteLine(middleNameTextBox.Text)
                .WriteLine(lastNameTextBox.Text)
                .WriteLine(employeeNumberTextBox.Text)
                .WriteLine(departmentComboBox.Text)
                .WriteLine(telephoneTextBox.Text)
                .WriteLine(extTextBox.Text)
                .WriteLine(emailTextBox.Text)
                .Close()
            End With
            MsgBox("Record Added!", MsgBoxStyle.Information, "Sucess")
        Catch ex As Exception
            MsgBox("Error writing to File!", MsgBoxStyle.Critical, "Failed")
        End Try
    End Sub
    '==========================================================================================
    'Name: exitButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: clearButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Clears textboxes
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        firstNameTextBox.Text = ""
        middleNameTextBox.Text = ""
        lastNameTextBox.Text = ""
        employeeNumberTextBox.Text = ""
        departmentComboBox.Text = ""
        telephoneTextBox.Text = ""
        extTextBox.Text = ""
        emailTextBox.Text = ""
    End Sub
End Class
'================================== No Code Follows ===========================================