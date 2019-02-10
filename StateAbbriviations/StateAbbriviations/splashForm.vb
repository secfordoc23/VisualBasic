'Program: Hello Its Me
'Me: frmSplash.vb
'Date: 8/27/2015
'Author: Jason Welch
'Purpose: Display a Splash screen for my program

'=============================================================================
'==                         frmSplash                                       ==
'=============================================================================
Public Class splashForm
    '=============================================================================
    '==                         tmrSplash_Tick                                  ==
    '=============================================================================
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        Me.Close()
        tmrSplash.Enabled = False

    End Sub
End Class