'Project: InternetServiceProvider
'Me: mainForm.vb
'Date: 9/23/2015
'Author: Jason Welch
'Purpose: Display the calculated bill for based on selected Internet Package and hours used

Option Explicit On
Option Strict On

'==============================mainForm================================
Public Class mainForm

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
        hoursUsedTextBox.Text = ""
        totalLabel.Text = ""

        nonProfitCheckBox.Checked = False

        hoursUsedTextBox.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '======================================calculateButton_Click=====================================
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const DISCOUNT As Single = 0.2F
        Const PACKAGE_A_HOURS As Short = 10
        Const PACKAGE_B_HOURS As Short = 20
        Const PACKAGE_A_COST As Decimal = CDec(9.95)
        Const PACKAGE_B_COST As Decimal = CDec(14.95)
        Const PACKAGE_C_COST As Decimal = CDec(19.95)
        Const PACKAGE_A_ADDITIONAL As Decimal = CDec(2)
        Const PACKAGE_B_ADDITIONAL As Decimal = CDec(1)
        Dim hoursUsed As Short
        Dim totalAmount As Decimal

        If Not Short.TryParse(hoursUsedTextBox.Text, hoursUsed) Then
            MessageBox.Show("Please input a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If packageARadioButton.Checked = True Then
            If nonProfitCheckBox.Checked = True Then
                If hoursUsed > PACKAGE_A_HOURS Then
                    totalAmount = CDec((PACKAGE_A_COST - (PACKAGE_A_COST * DISCOUNT)) + (PACKAGE_A_ADDITIONAL * (hoursUsed - PACKAGE_A_HOURS)))
                Else
                    totalAmount = CDec(PACKAGE_A_COST - (PACKAGE_A_COST * DISCOUNT))
                End If
            Else
                If hoursUsed > PACKAGE_A_HOURS Then
                    totalAmount = CDec(PACKAGE_A_COST + (PACKAGE_A_ADDITIONAL * (hoursUsed - PACKAGE_A_HOURS)))
                Else
                    totalAmount = PACKAGE_A_COST
                End If
            End If
        ElseIf packageBRadioButton.Checked = True Then
            If nonProfitCheckBox.Checked = True Then
                If hoursUsed > PACKAGE_B_HOURS Then
                    totalAmount = CDec((PACKAGE_B_COST - (PACKAGE_B_COST * DISCOUNT)) + (PACKAGE_B_ADDITIONAL * (hoursUsed - PACKAGE_B_HOURS)))
                Else
                    totalAmount = CDec(PACKAGE_B_COST - (PACKAGE_B_COST * DISCOUNT))
                End If
            Else
                If hoursUsed > PACKAGE_B_HOURS Then
                    totalAmount = CDec(PACKAGE_B_COST + (PACKAGE_B_ADDITIONAL * (hoursUsed - PACKAGE_B_HOURS)))
                Else
                    totalAmount = PACKAGE_B_COST
                End If
            End If
        Else
            If nonProfitCheckBox.Checked = True Then
                totalAmount = CDec(PACKAGE_C_COST - (PACKAGE_C_COST * DISCOUNT))
            Else
                totalAmount = PACKAGE_C_COST
            End If
        End If

        totalLabel.Text = totalAmount.ToString("C")

        clearButton.Focus()

    End Sub
End Class
