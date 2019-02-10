' Comments

Option Explicit On
Option Strict On

' =====================mainForm=======================
Public Class mainForm

    ' =====================calculateButton_Click=======================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim message = String.Empty

        If coffeeRadioButton.Checked = True Then
            message = "Coffee "

        ElseIf teaRadioButton.Checked = True Then
            message = "Tea "

        Else
            message = "Soda "
        End If

        If mochaRadioButton.Checked = True Then
            message = message & "add Mocha"
        End If

        If whipRadioButton.Checked = True Then
            message = message & "add Whipped Cream"
        End If

        If amerettoRadioButton.Checked = True Then
            message = message & "add Ameretto"
        End If

        orderLabel.Text = message

    End Sub
End Class
