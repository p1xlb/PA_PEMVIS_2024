﻿Imports MySql.Data.MySqlClient

Public Class Form1
    Public Sub Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub


    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & username & "' AND password = '" & password & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            SessionManager.CurrentUsername = username ' Set the session variable
            MsgBox("Login Berhasil")
            Me.Hide()
            UserDash.Show()
        ElseIf username = "Admin" And password = "Admin" Then
            RD.Close()
            SessionManager.CurrentUsername = username ' Set the session variable
            MsgBox("Login Berhasil")
            Me.Hide()
            AdminDash.Show()
        Else
            RD.Close()
            MsgBox("Login Gagal")
        End If
    End Sub

    Private Sub txtRegistrasi_Click(sender As Object, e As EventArgs) Handles txtRegistrasi.Click
        Me.Hide()
        Registrasi.Show()
    End Sub
End Class
