Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from user where username = '" _
                & .txtUsername.Text & "' and password = ('" _
                & .txtPassword.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                Me.Hide()
                Landing_Page.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub lnkUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUser.LinkClicked
        Dim filePath As String = "C:\Users\paul\Documents\3rd yr 2nd sem\edp\EDP\user manual\user manual.pdf"

        If File.Exists(filePath) Then
            Process.Start(filePath)
        Else
            MessageBox.Show("File not found")
        End If
    End Sub

End Class
