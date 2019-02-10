'Project: BarelyAviation
'Me: mainForm.vb
'Date: 11/4/2015
'Author: Jason Welch
'Purpose: To Dispaly a Seating chart for an airline

Option Explicit On
Option Strict On

'============================== mainForm ================================
Public Class mainForm
    Private passengersString(36, 1) As String
    Private destinationString() As String = {"Lickskillet, OH", "Toad Suck, AR", "Peculiar, MO", "Greasy, OK "}
    Private costDecimal() As Short = {250, 300, 100, 400}

    Private totalCostDecimal As Decimal
    Private soldCountShort As Short

    '======================================mainForm_FormClosing=====================================
    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    '============================== mainForm_Load ================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then

                thisControl.BackColor = Color.LightGreen

                thisControl.Text = "Seat" & ControlChars.CrLf & thisControl.Tag.ToString()

                seatToolTip.SetToolTip(thisControl, "Empty")

            End If

        Next thisControl

        For Each locationString As String In destinationString
            destinationComboBox.Items.Add(locationString)
        Next locationString

        destinationComboBox.SelectedIndex = 0
        clearTextboxes()
    End Sub

    '======================================exitButton_Click=====================================
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '======================================clearButton_Click=====================================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        Dim myCheckbox As CheckBox
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then

                thisControl.BackColor = Color.LightGreen

                thisControl.Text = "Seat" & ControlChars.CrLf & thisControl.Tag.ToString()

                seatToolTip.SetToolTip(thisControl, "Empty")
                If TypeOf thisControl Is CheckBox Then
                    myCheckbox = CType(thisControl, CheckBox)
                    myCheckbox.Checked = False
                End If
            End If

        Next thisControl

        destinationComboBox.SelectedIndex = 0

        totalCostDecimal = CDec((costDecimal(destinationComboBox.SelectedIndex) * 36) / 2)
        totalCostLabel.Text = totalCostDecimal.ToString("C")
        clearTextboxes()

        Array.Clear(passengersString, 0, passengersString.Length)

        seat1CheckBox.Focus()

    End Sub

    '============================== buySeat ================================
    Private Sub buySeat(sender As Object, e As EventArgs) Handles _
        seat1CheckBox.CheckedChanged, seat2CheckBox.CheckedChanged, seat3CheckBox.CheckedChanged, seat4CheckBox.CheckedChanged, seat5CheckBox.CheckedChanged, _
        seat6CheckBox.CheckedChanged, seat7CheckBox.CheckedChanged, seat8CheckBox.CheckedChanged, seat9CheckBox.CheckedChanged, seat10CheckBox.CheckedChanged, _
        seat11CheckBox.CheckedChanged, seat12CheckBox.CheckedChanged, seat13CheckBox.CheckedChanged, seat14CheckBox.CheckedChanged, seat15CheckBox.CheckedChanged, _
        seat16CheckBox.CheckedChanged, seat17CheckBox.CheckedChanged, seat18CheckBox.CheckedChanged, seat19CheckBox.CheckedChanged, seat20CheckBox.CheckedChanged, _
        seat21CheckBox.CheckedChanged, seat22CheckBox.CheckedChanged, seat23CheckBox.CheckedChanged, seat24CheckBox.CheckedChanged, seat25CheckBox.CheckedChanged, _
        seat26CheckBox.CheckedChanged, seat27CheckBox.CheckedChanged, seat28CheckBox.CheckedChanged, seat29CheckBox.CheckedChanged, seat30CheckBox.CheckedChanged, _
        seat31CheckBox.CheckedChanged, seat32CheckBox.CheckedChanged, seat33CheckBox.CheckedChanged, seat34CheckBox.CheckedChanged, seat35CheckBox.CheckedChanged, _
        seat36CheckBox.CheckedChanged

        Dim myControl As New CheckBox

        myControl = CType(CObj(sender), CheckBox)
        If (myControl.Checked) Then
            passengersString(CShort(myControl.Tag), 0) = InputBox("Enter Name:", "Passenger")
            passengersString(CShort(myControl.Tag), 1) = InputBox("Meal:" & ControlChars.CrLf & _
                                                          ControlChars.Tab & "Veggie, " & ControlChars.Tab & "Chicken" & ControlChars.CrLf & _
                                                          ControlChars.Tab & "Beef, " & ControlChars.Tab & "Fish", "Flight Menu")
            myControl.BackColor = Color.Red
            seatToolTip.SetToolTip(myControl, passengersString(CShort(myControl.Tag), 0) & passengersString(CShort(myControl.Tag), 1))
            soldCountShort = CShort(soldCountShort + 1)

            seatCost(True, CShort(myControl.Tag))

        Else
            myControl.BackColor = Color.LightGreen
            seatToolTip.SetToolTip(myControl, "Empty")
            soldCountShort = CShort(soldCountShort - 1)

            seatCost(False, CShort(myControl.Tag))
        End If

        soldCountLabel.Text = soldCountShort.ToString()
        grossTotal()
        netTotal()
    End Sub

    '============================== destinationComboBox_SelectedIndexChanged ================================
    Private Sub destinationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles destinationComboBox.SelectedIndexChanged

        Dim myCheckbox As CheckBox
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then

                thisControl.BackColor = Color.LightGreen

                thisControl.Text = "Seat" & ControlChars.CrLf & thisControl.Tag.ToString()

                seatToolTip.SetToolTip(thisControl, "Empty")
                If TypeOf thisControl Is CheckBox Then
                    myCheckbox = CType(thisControl, CheckBox)
                    myCheckbox.Checked = False
                End If
            End If

        Next thisControl

        totalCostDecimal = CDec((costDecimal(destinationComboBox.SelectedIndex) * 36) / 2)
        totalCostLabel.Text = totalCostDecimal.ToString("C")
        clearTextboxes()
        Array.Clear(passengersString, 0, passengersString.Length)

    End Sub

    '============================== clearTextboxes() ================================
    Private Sub clearTextboxes()
        soldCountShort = 0S
        soldCountLabel.Text = soldCountShort.ToString()
        economyLabel.Text = 0.ToString("C")
        businessLabel.Text = 0.ToString("C")
        firstLabel.Text = 0.ToString("C")
        grossLabel.Text = 0.ToString("C")
        netLabel.Text = 0.ToString("C")
    End Sub

    '============================== seatCost() ================================
    Private Sub seatCost(boxIsChecked As Boolean, seatNumber As Short)

        If boxIsChecked = True Then
            If seatNumber <= 4 Then
                firstLabel.Text = (CDec(firstLabel.Text) + (4 * costDecimal(destinationComboBox.SelectedIndex))).ToString("C")
            ElseIf seatNumber <= 12 Then
                businessLabel.Text = (CDec(businessLabel.Text) + (2 * costDecimal(destinationComboBox.SelectedIndex))).ToString("C")
            Else
                economyLabel.Text = (CDec(economyLabel.Text) + costDecimal(destinationComboBox.SelectedIndex)).ToString("C")
            End If
        Else
            If seatNumber <= 4 Then
                firstLabel.Text = (CDec(firstLabel.Text) - (4 * costDecimal(destinationComboBox.SelectedIndex))).ToString("C")
            ElseIf seatNumber <= 12 Then
                businessLabel.Text = (CDec(businessLabel.Text) - (2 * costDecimal(destinationComboBox.SelectedIndex))).ToString("C")
            Else
                economyLabel.Text = (CDec(economyLabel.Text) - costDecimal(destinationComboBox.SelectedIndex)).ToString("C")
            End If
        End If
    End Sub

    '============================== grossTotal() ================================
    Private Sub grossTotal()
        Dim grossTotalDecimal As Decimal

        grossTotalDecimal = CDec(firstLabel.Text) + CDec(businessLabel.Text) + CDec(economyLabel.Text)

        grossLabel.Text = grossTotalDecimal.ToString("C")

    End Sub

    '============================== netTotal() ================================
    Private Sub netTotal()
        Dim netTotalDecimal As Decimal

        netTotalDecimal = CDec(grossLabel.Text) - CDec(totalCostLabel.Text)

        netLabel.Text = netTotalDecimal.ToString("C")
    End Sub
End Class


' 9 Double
' 11 nothing
' 17 Double
' 18 nothing
'