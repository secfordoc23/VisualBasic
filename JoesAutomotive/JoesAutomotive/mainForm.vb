'Project: JoesAutomotive
'Me: mainForm.vb
'Date: 10/21/2015
'Author: Jason Welch
'Purpose: Display the calculated charges after a visit to Joes Automotive

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
        ' splashForm.ShowDialog()

    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        ClearFees()
        ClearOther()
        ClearMisc()
        ClearFlushes()
        ClearOilLube()

        calculateButton.Focus()

    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
    '======================================calculateButton_Click=====================================

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim laborDecimal As Decimal = 0D
        Dim partsDecimal As Decimal = 0D
        Dim totalLaborDecimal As Decimal = 0D

        If Not Decimal.TryParse(laborTextBox.Text, laborDecimal) Then
            MessageBox.Show("Please input a number for parts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If laborDecimal < 0 Then
            MessageBox.Show("Please input a positive number for parts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        totalLaborDecimal = CDec(totalLaborDecimal + (laborDecimal * 20.0))

        If Not Decimal.TryParse(partsTextBox.Text, partsDecimal) Then
            MessageBox.Show("Please input a number for parts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If partsDecimal < 0 Then
            MessageBox.Show("Please input a positive number for parts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        serviceLaborLabel.Text = totalLaborDecimal.ToString("C")
        totalPartsLabel.Text = partsDecimal.ToString("C")

        taxLabel.Text = TaxCharges().ToString("C")
        totalLabel.Text = TotalCharges().ToString("C")

        clearButton.Focus()
    End Sub

    '======================================OilLubeCharges=====================================
    Private Function OilLubeCharges() As Decimal
        Dim oilLubeTotalDecimal As Decimal = 0D

        If oilChangeCheckBox.Checked Then
            oilLubeTotalDecimal = CDec(oilLubeTotalDecimal + 26.0)
        End If

        If lubeJobCheckBox.Checked Then
            oilLubeTotalDecimal = CDec(oilLubeTotalDecimal + 18.0)
        End If

        Return oilLubeTotalDecimal

    End Function

    '======================================FlushCharges=====================================
    Private Function FlushCharges() As Decimal
        Dim flushTotalDecimal As Decimal = 0D

        If radiatorCheckBox.Checked Then
            flushTotalDecimal = CDec(flushTotalDecimal + 30.0)
        End If

        If transmissionCheckBox.Checked Then
            flushTotalDecimal = CDec(flushTotalDecimal + 80.0)
        End If

        Return flushTotalDecimal

    End Function

    '======================================MiscCharges=====================================
    Private Function MiscCharges() As Decimal
        Dim miscTotalDecimal As Decimal = 0D

        If inspectionCheckBox.Checked Then
            miscTotalDecimal = CDec(miscTotalDecimal + 15.0)
        End If

        If mufflerCheckBox.Checked Then
            miscTotalDecimal = CDec(miscTotalDecimal + 100.0)
        End If

        If tireCheckBox.Checked Then
            miscTotalDecimal = CDec(miscTotalDecimal + 20.0)
        End If

        Return miscTotalDecimal

    End Function

    '======================================OtherCharges=====================================
    Private Function OtherCharges() As Decimal
        Dim totalLaborDecimal As Decimal = 0D
        Dim laborDecimal As Decimal = 0D
        Dim partsDecimal As Decimal = 0D

        If Not Decimal.TryParse(laborTextBox.Text, laborDecimal) Then
            MessageBox.Show("Please input a number for parts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If laborDecimal < 0 Then
            MessageBox.Show("Please input a positive number for parts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        totalLaborDecimal = CDec(totalLaborDecimal + (laborDecimal * 20.0))

        If Not Decimal.TryParse(partsTextBox.Text, partsDecimal) Then
            MessageBox.Show("Please input a number for parts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If partsDecimal < 0 Then
            MessageBox.Show("Please input a positive number for parts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        totalLaborDecimal = CDec(totalLaborDecimal + partsDecimal)

        Return totalLaborDecimal
    End Function

    '======================================TaxCharges=====================================
    Private Function TaxCharges() As Decimal
        Dim taxTotalDecimal As Decimal = 0D
        Dim partsDecimal As Decimal = 0D

        If Not Decimal.TryParse(partsTextBox.Text, partsDecimal) Then
            MessageBox.Show("Please input a number for parts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If partsDecimal < 0 Then
            MessageBox.Show("Please input a positive number for parts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        taxTotalDecimal = CDec(partsDecimal * 0.06)

        Return taxTotalDecimal
    End Function

    '======================================TotalCharges=====================================
    Private Function TotalCharges() As Decimal
        Dim totalDecimal As Decimal = 0D

        totalDecimal = totalDecimal + OilLubeCharges()
        totalDecimal = totalDecimal + FlushCharges()
        totalDecimal = totalDecimal + MiscCharges()
        totalDecimal = totalDecimal + OtherCharges()
        totalDecimal = totalDecimal + TaxCharges()

        Return totalDecimal
    End Function

    '======================================ClearOilLube=====================================
    Private Sub ClearOilLube()
        oilChangeCheckBox.Checked = False
        lubeJobCheckBox.Checked = False
    End Sub

    '======================================ClearFlushes=====================================
    Private Sub ClearFlushes()
        radiatorCheckBox.Checked = False
        transmissionCheckBox.Checked = False
    End Sub

    '======================================ClearMisc=====================================
    Private Sub ClearMisc()
        inspectionCheckBox.Checked = False
        mufflerCheckBox.Checked = False
        tireCheckBox.Checked = False
    End Sub

    '======================================ClearOther=====================================
    Private Sub ClearOther()
        partsTextBox.Text = ""
        laborTextBox.Text = ""
    End Sub

    '======================================ClearFees=====================================
    Private Sub ClearFees()
        serviceLaborLabel.Text = ""
        totalPartsLabel.Text = ""
        taxLabel.Text = ""
        totalLabel.Text = ""
    End Sub
End Class
