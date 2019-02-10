Option Strict On
Option Explicit On
Imports System.ComponentModel
Imports System.IO

Public Class parentForm
    '==========================================================================================
    'Name: ShowChild1ToolStripMenuItem_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Shows the entryForm
    Private Sub addRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addRecordToolStripMenuItem.Click
        entryForm.Show()
        entryForm.MdiParent = Me
    End Sub
    '==========================================================================================
    'Name: ShowChild2ToolStripMenuItem_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Shows the readForm
    Private Sub readRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles readRecordToolStripMenuItem.Click
        readForm.Show()
        readForm.MdiParent = Me
    End Sub
    '==========================================================================================
    'Name: ExitToolStripMenuItem_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If entryForm.IsMdiChild = True Then
            entryForm.Close()
        End If
        If readForm.IsMdiChild = True Then
            readForm.Close()
        End If
        Close()
    End Sub
    '==========================================================================================
    'Name: parentForm_Load
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Loads Splashscreen and asks for a file name
    Private Sub parentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim createFileMsgBoxResult As MsgBoxResult
        Dim outputStreamWriter As StreamWriter
        splashForm.ShowDialog()
        Do
            m_fileNameString = InputBox("Enter the Name of the File: ", "Input Needed")
            Try
                If Not File.Exists(m_fileNameString) Then
                    createFileMsgBoxResult = MsgBox("Do you want to create a new file?", MsgBoxStyle.YesNoCancel, "File Not Found!")
                    If createFileMsgBoxResult = MsgBoxResult.Yes Then
                        outputStreamWriter = File.CreateText(m_fileNameString)
                        outputStreamWriter.Close()
                    ElseIf createFileMsgBoxResult = MsgBoxResult.Cancel Then
                        Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error Accessing File!", MsgBoxStyle.Critical)
            End Try
        Loop Until File.Exists(m_fileNameString) Or createFileMsgBoxResult = MsgBoxResult.Cancel

    End Sub
    '==========================================================================================
    'Name: parentForm_Closing
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Gives user opportunity to not leave program
    Private Sub parentForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
End Class
'================================== No Code Follows ===========================================
