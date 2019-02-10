'Program: parentForm
'Me: readForm.vb
'Date: 2/10/2019
'Author: Jason Welch
'Purpose: Reads records from the specified file

Option Strict On
Option Explicit On
Imports System.IO

Public Class readForm
    Private m_inputStreamReader As StreamReader
    Private m_recordNumberShort As Short
    '==========================================================================================
    'Name: nextButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Reads the Next Record in a specified file
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        If m_inputStreamReader.Peek <> -1 Then
            With m_inputStreamReader
                recordValueLabel.Text = m_recordNumberShort.ToString()
                firstNameValueLabel.Text = .ReadLine
                middleNameValueLabel.Text = .ReadLine
                lastNameValueLabel.Text = .ReadLine
                empNumValueLabel.Text = .ReadLine
                deptValueLabel.Text = .ReadLine
                telephoneValueLabel.Text = .ReadLine
                extValueLabel.Text = .ReadLine
                emailValueLabel.Text = .ReadLine
            End With
            m_recordNumberShort += 1S
        Else
            MsgBox("End Of File!", MsgBoxStyle.Information)
            m_inputStreamReader.Close()
        End If
    End Sub
    '==========================================================================================
    'Name: readForm_Load
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Verifies that a specific file can be open for reading
    Private Sub readForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_inputStreamReader = File.OpenText(m_fileNameString)
        Catch ex As Exception
            MsgBox("Error Reading File!", MsgBoxStyle.Critical)
            Close()
        End Try
        m_recordNumberShort = 1
    End Sub
    '==========================================================================================
    'Name: exitButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
'================================== No Code Follows ===========================================