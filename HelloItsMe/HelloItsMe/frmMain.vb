
'Program: Hello Its ME
'Me: frmMain.vb
'Date: 8/27/2015
'Author: Jason Welch
'Purpose: Display the work hello in several different languages

Option Explicit On ' This means that variables need to be declared before use
Option Strict Off ' This means that I cannot implicitly change data types

'=============================================================================
'==                     frmMain                                             ==
'=============================================================================
Public Class frmMain

    '=============================================================================
    '==                     btnExit_Click                                       ==
    '=============================================================================
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    '=============================================================================
    '==                     frmMain_FormClosing                                 ==
    '=============================================================================
    Private Sub frmMain_FormClosing(ByVal sender As Object, _
                    ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    '==============================================================================
    '==                     btnEnglish_Click                                     ==
    '==============================================================================
    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        lblDisplay.Text = "Hello!"
    End Sub

    '==============================================================================
    '==                     btnSpanish_Click                                     ==
    '==============================================================================
    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblDisplay.Text = "Hola!"
    End Sub

    '==============================================================================
    '==                     btnFrench_Click                                      ==
    '==============================================================================
    Private Sub btnFrench_Click(sender As Object, e As EventArgs) Handles btnFrench.Click
        lblDisplay.Text = "Bonjour!"
    End Sub

    '==============================================================================
    '==                     btnGerman_Click                                      ==
    '==============================================================================
    Private Sub btnGerman_Click(sender As Object, e As EventArgs) Handles btnGerman.Click
        lblDisplay.Text = "Hallo!"
    End Sub

    '==============================================================================
    '==                     frmMain_Load                                         ==
    '==============================================================================
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmSplash.ShowDialog()

    End Sub
End Class
