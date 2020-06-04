Public Class Form5
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Try
            'Save details of FTP
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            objIniFile.WriteString("FTP host", "host", host_txt.Text)
            objIniFile.WriteString("FTP user", "user", user_txt.Text)
            objIniFile.WriteString("FTP password", "password", password_txt.Text)
            objIniFile.WriteString("FTP port", "port", port_txt.Text)
            MsgBox("FTP details saved!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Can't save details!")
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            host_txt.Text = objIniFile.GetString("FTP host", "host", "host")
            user_txt.Text = objIniFile.GetString("FTP user", "user", "user")
            password_txt.Text = objIniFile.GetString("FTP password", "password", "password")
            port_txt.Text = objIniFile.GetString("FTP port", "port", "21")
        Catch ex As Exception
            MsgBox("Load form Error.")
        End Try
    End Sub
End Class