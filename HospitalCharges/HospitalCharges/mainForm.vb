'Project: Hospital Charges
'Me: mainForm.vb
'Date: 10/21/2015
'Author: Jason Welch
'Purpose: Display the calculated charges of a hospital stay

Option Explicit On
Option Strict On

'==============================mainForm================================\
Public Class mainForm
    'Variable Declaration
    Private lengthOfStayInteger As Integer
    Private medsDecimal As Decimal
    Private surgicalDecimal As Decimal
    Private labFeesDecimal As Decimal
    Private physicalDecimal As Decimal

    '======================================mainForm_FormClosing=====================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    '======================================mainForm_Load=====================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load Splash Screen
        ' splashForm.ShowDialog()

    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        stayTextBox.Text = ""
        medsTextBox.Text = ""
        surgicalTextBox.Text = ""
        labFeesTextBox.Text = ""
        physicalTextBox.Text = ""
        totalLabel.Text = ""

        calculateButton.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim stayChargesDecimal As Decimal = 0D
        Dim miscChargesDecimal As Decimal = 0D
        Dim totalDecimal As Decimal = 0D

        If ValidateInputFields() Then
            stayChargesDecimal = CalcStayCharges()
            miscChargesDecimal = CalcMiscCharges()
            totalDecimal = CalcTotalCharges(stayChargesDecimal, miscChargesDecimal)
            totalLabel.Text = totalDecimal.ToString("C")
        End If
    End Sub

    '======================================CalcStayCharges=====================================
    Private Function CalcStayCharges() As Decimal
        Dim chargesDecimal As Decimal = 0D
        Const AMOUNT_PER_HOUR_DECIMAL As Decimal = 350D

        chargesDecimal = lengthOfStayInteger * AMOUNT_PER_HOUR_DECIMAL

        Return chargesDecimal
    End Function

    '======================================CalcMiscCharges=====================================
    Private Function CalcMiscCharges() As Decimal
        Dim miscTotalDecimal As Decimal = 0D

        miscTotalDecimal = medsDecimal + surgicalDecimal + labFeesDecimal + physicalDecimal

        Return miscTotalDecimal
    End Function

    '======================================CalcMiscCharges=====================================
    Private Function CalcTotalCharges(stayTotalDecimal As Decimal, miscTotalDecimal As Decimal) As Decimal
        Dim totalDecimal As Decimal = 0D

        totalDecimal = stayTotalDecimal + miscTotalDecimal

        Return totalDecimal
    End Function

    '======================================ValidateInputFields=====================================
    Private Function ValidateInputFields() As Boolean
        If Not Integer.TryParse(stayTextBox.Text, lengthOfStayInteger) Then
            MessageBox.Show("Please input a number for length of stay!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Decimal.TryParse(medsTextBox.Text, medsDecimal) Then
            MessageBox.Show("Please input a number for Medications!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Decimal.TryParse(surgicalTextBox.Text, surgicalDecimal) Then
            MessageBox.Show("Please input a number for Surgical!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Decimal.TryParse(labFeesTextBox.Text, labFeesDecimal) Then
            MessageBox.Show("Please input a number fpr Lab Fees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Decimal.TryParse(physicalTextBox.Text, physicalDecimal) Then
            MessageBox.Show("Please input a number for Physical!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If lengthOfStayInteger < 0 Then
            MessageBox.Show("Please input a positive number for length of stay!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf medsDecimal < 0 Then
            MessageBox.Show("Please input a positive number for Medications!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf surgicalDecimal < 0 Then
            MessageBox.Show("Please input a positive number for Surgical!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf labFeesDecimal < 0 Then
            MessageBox.Show("Please input a positive number fpr Lab Fees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf physicalDecimal < 0 Then
            MessageBox.Show("Please input a positive number for Physical!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function
End Class
