Imports System.ComponentModel

Public Class Form1
    Private Sub importWO_btn_Click(sender As Object, e As EventArgs) Handles importWO_btn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub importLog_btn_Click(sender As Object, e As EventArgs) Handles importLog_btn.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub createWO_btn_Click(sender As Object, e As EventArgs) Handles createWO_btn.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Ftp_pic_Click(sender As Object, e As EventArgs) Handles Ftp_pic.Click
        Form5.Show()
    End Sub

End Class
