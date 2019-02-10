'Project: PizzaPi
'Me: mainForm.vb
'Date: 9/17/2015
'Author: Jason Welch
'Purpose: Display Number of Slices for a given size of pizza

Option Explicit On
Option Strict On

'==============================mainForm================================
Public Class mainForm
    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim pizzaSize As Short
        Dim numberOfSlices As Short
        Dim areaOfPizza As Single = 0.0F
        Const PI As Single = 3.14159F
        Const AREA_PER_SLICE As Single = 14.125F

        Try
            pizzaSize = CShort(pizzaDiameterTextBox.Text)
            areaOfPizza = CSng(PI * (pizzaSize / 2) ^ 2)
            numberOfSlices = CShort(areaOfPizza / AREA_PER_SLICE)

        Catch ex As Exception
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        displayNumberSlicesLabel.Text = numberOfSlices.ToString()

        clearButton.Focus()

    End Sub

    '======================================mainForm_FormClosing=====================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    '======================================mainForm_Load=====================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load Splash Screen
        splashForm.ShowDialog()


    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        pizzaDiameterTextBox.Text = ""
        displayNumberSlicesLabel.Text = ""

        pizzaDiameterTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
End Class
