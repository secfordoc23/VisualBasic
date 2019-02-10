'Program: TestScoreAverage
'Me: splashForm.vb
'Date: 8/27/2015
'Author: Jason Welch
'Purpose: Display a Splash screen for my program

'=============================================================================
'==                         splashForm                                       ==
'=============================================================================
Option Explicit On ' This means that variables need to be declared before use
Option Strict Off ' This means that I cannot implicitly change data types

Public Class splashForm
    '=============================================================================
    '==                         tmrSplash_Tick                                  ==
    '=============================================================================
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        Me.Close()
        tmrSplash.Enabled = False

    End Sub
End Class