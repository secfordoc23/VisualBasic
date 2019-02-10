Option Explicit On
Option Strict On

Public Class mainForm
    'Private numOneShort As Short = 0S
    'Private numTwoShort As Short = 0S
    'Private sumShort As Short = 0S

    '=======================calculateButton_Click======================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim numOneShort As Short = 0S
        Dim numTwoShort As Short = 0S
        Dim sumShort As Short = 0S
        Dim numThreeShort As Short = 10S
        Dim productShort As Short = 0S

        numOneShort = CShort(numOneTextBox.Text)
        numTwoShort = CShort(numTwoTextBox.Text)

        addNumbers(numOneShort, numTwoShort, sumShort) ' 

        productShort = multiplyNumbers(numOneShort, numTwoShort)

        displayListBox.Items.Add(numOneShort & " + " & numTwoShort & " = " & sumShort)
        displayListBox.Items.Add(numOneShort & " * " & numTwoShort & " = " & productShort)

    End Sub

    '==================addNumbers()
    Private Sub addNumbers(ByVal numOneShort As Short, ByVal numTwoShort As Short, ByRef sumShort As Short, Optional ByVal numThreeShort As Short = 0S)
        sumShort = numOneShort + numTwoShort + numThreeShort
    End Sub

    '==================multiplyNumbers()
    Private Function multiplyNumbers(ByRef numOneShort As Short, ByRef numTwoShort As Short) As Short
        'multiplyNumbers = numOneShort * numTwoShort
        'Return multiplyNumbers

        Dim productShort As Short
        productShort = numOneShort * numTwoShort
        Return productShort

        'Return numOneShort * numTwoShort
    End Function
End Class
