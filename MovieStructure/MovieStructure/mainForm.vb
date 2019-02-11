'Program: MovieStructure
'Me: mainForm.vb
'Date: 2/10/2019
'Author: Jason Welch
'Purpose: A Program to Add a Movie to a list and display all stored movies.

Option Strict On
Option Explicit On


Imports System.ComponentModel

Public Class mainForm
    Private movieInfoList As New List(Of MovieInfo)
    '==========================================================================================
    'Name: mainForm_Load
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Loads Splashscreen
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        splashForm.ShowDialog()
    End Sub

    '==========================================================================================
    'Name: MovieInfo
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Object for holding Movie Info
    Structure MovieInfo
        Dim nameString As String
        Dim directorString As String
        Dim producerString As String
        Dim yearString As String
    End Structure

    '==========================================================================================
    'Name: exitButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    '==========================================================================================
    'Name: mainForm_Closing
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Gives user opportunity to not leave program
    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    '==========================================================================================
    'Name: addButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: adds a new movie to the movie list and updates the associated list box
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim movieToAddMovieInfo As MovieInfo
        With movieToAddMovieInfo
            .nameString = titleTextBox.Text
            .directorString = directorTextBox.Text
            .producerString = producerTextBox.Text
            .yearString = yearReleasedTextBox.Text
        End With

        movieInfoList.Add(movieToAddMovieInfo)

        movieListBox.Items.Clear()
        For Each addedMovieInfo As MovieInfo In movieInfoList
            movieListBox.Items.Add(addedMovieInfo.nameString)
        Next

        movieListBox.SelectedIndex = 0
    End Sub

    '==========================================================================================
    'Name: clearButton_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Clears textboxes
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        titleTextBox.Text = ""
        directorTextBox.Text = ""
        producerTextBox.Text = ""
        yearReleasedTextBox.Text = ""
    End Sub

    '==========================================================================================
    'Name: movieListBox_SelectedIndexChanged
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Displays the values set for the selected Movie
    Private Sub movieListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles movieListBox.SelectedIndexChanged
        movieInfoListBox.Items.Clear()
        Dim selectedMovieInfo As MovieInfo = movieInfoList.Item(movieListBox.SelectedIndex)

        With selectedMovieInfo
            movieInfoListBox.Items.Add("Title: " & .nameString)
            movieInfoListBox.Items.Add("Director: " & .directorString)
            movieInfoListBox.Items.Add("Producer: " & .producerString)
            movieInfoListBox.Items.Add("Year Released: " & .yearString)
        End With
    End Sub
End Class
'================================== No Code Follows ===========================================
