'Program: Grading
'Me: splashForm.vb
'Date: 1/24/2019
'Author: Jason Welch
'Purpose: A Splash screen to introduce the program

Option Strict On
Option Explicit On

Public Class splashForm
    '==========================================================================================
    'Name: splashTimer_Tick
    'Date: 1/24/2019
    'Author: Jason Welch
    'Purpose: A timer to display the splash screen for a time and then return to the main form.
    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        Me.Close()
        splashTimer.Enabled = False
    End Sub
    '==========================================================================================
End Class