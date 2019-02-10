'Program: RaceResults
'Me: splashForm.vb
'Date: 8/27/2015
'Author: Jason Welch
'Purpose: Display a Splash screen for my program


Option Explicit On
Option Strict On

'==============================splashForm================================
Public Class splashForm

    '==============================splashTimer_Tick================================
    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        Me.Close()
        splashTimer.Enabled = False
    End Sub
End Class