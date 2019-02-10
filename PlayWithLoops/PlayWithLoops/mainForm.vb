

Option Strict On
Option Explicit On

' ======================mainForm=============================
Public Class mainForm

    '==========================pressButton_Click================================
    Private Sub pressButton_Click(sender As Object, e As EventArgs) Handles pressButton.Click
        Dim number As Short = 0

        Do While number <= 10
            displayListBox.Items.Add("The Count is: " & number)
            number += 1S

        Loop
    End Sub

    Private Sub pressMeButton_Click(sender As Object, e As EventArgs) Handles pressMeButton.Click
        Dim row As Short = 0
        Dim column As Short = 0

        For row = 1 To 10
            For column = 1 To 10
                Dim product As Short = row * column
                display2ListBox.Items.Add(row & " X " & column & " = " & product)
            Next column
        Next row
    End Sub

    Private Sub mainForm_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Dim count As Short = 1S

        Do
            Dim name As String = InputBox("Enter a name: ")
            displayListBox.Items.Add(name)
            count += 1S

        Loop Until count > 3
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        statusComboBox.Items.Add("Alabama")
        statusComboBox.Items.Add("Alaska")
        statusComboBox.Items.Add("Arizona")
        statusComboBox.Items.Add("Arkansas")
        statusComboBox.SelectedIndex = 0


    End Sub

    Private Sub mainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.BackColor = Color.Azure
        pressMeButton.Visible = True
    End Sub

    Private Sub mainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Me.BackColor = Color.PeachPuff

    End Sub

    Private Sub pressMeButton_MouseHover(sender As Object, e As EventArgs) Handles pressMeButton.MouseHover
        'pressMeButton.Visible = False
    End Sub

    Private Sub statusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusComboBox.SelectedIndexChanged
        display2ListBox.Items.Clear()
        display2ListBox.Items.Add(statusComboBox.SelectedItem)

        Dim state As String = CStr(statusComboBox.SelectedItem)
        Me.Text = state
    End Sub

    Private Sub timeTimer_Tick(sender As Object, e As EventArgs) Handles timeTimer.Tick
        Me.Text = "Play Time " & FormatDateTime(Now(), DateFormat.LongTime)

    End Sub
End Class
