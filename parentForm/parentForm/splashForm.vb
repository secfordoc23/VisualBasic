'Program: parentForm
'Me: splashForm.vb
'Date: 2/10/2019
'Author: Jason Welch
'Purpose: Display a Splash screen for my program


Option Explicit On
Option Strict On

'=====================================
'==           splashForm            ==
'=====================================
Public Class splashForm

    '=====================================
    '==           splashTimer_Tick      ==
    '=====================================
    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        Me.Close()
        splashTimer.Enabled = False
    End Sub

End Class
'=====================================
'==           NO CODE FOLLOWS       ==
'=====================================