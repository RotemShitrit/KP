Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form4
    Public dt As New DataTable("vCustomerDetails")
    Public con As SqlConnection
    Public cmd As New SqlCommand
    Dim WOnumber As Integer
    Dim numberOfAcc = 0

    Public Sub MakeDirectory()
        Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
        Dim host = objIniFile.GetString("FTP host", "host", "host")
        Dim port = objIniFile.GetString("FTP port", "port", "21")

        Dim request As FtpWebRequest = CType(FtpWebRequest.Create("ftp://" + host + ":" + port + "/Work Orders"), FtpWebRequest)
        Dim username = objIniFile.GetString("FTP user", "user", "user")
        Dim password = objIniFile.GetString("FTP password", "password", "password")

        request.Credentials = New NetworkCredential(username, password)
        request.Method = WebRequestMethods.Ftp.MakeDirectory

        Try
            Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                ' Folder created
            End Using
        Catch ex As WebException
            Exit Sub
        End Try
    End Sub

    Public Sub UploadToFTP(fileName As String, text As String)
        'Create Work Orders Folder
        Try
            MakeDirectory()
        Catch ex As Exception
            MsgBox("Make Directory in FTP Error!")
        End Try

        ' Get the object used to communicate with the server.
        Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
        Dim host = objIniFile.GetString("FTP host", "host", "host")
        Dim port = objIniFile.GetString("FTP port", "port", "21")

        'Create Request To Upload File
        Dim request = DirectCast(WebRequest.Create("ftp://" + host + ":" + port + "/Work Orders/" + fileName), FtpWebRequest)

        'Specify Username & Password
        Dim user = objIniFile.GetString("FTP user", "user", "user")
        Dim password = objIniFile.GetString("FTP password", "password", "password")
        request.Credentials = New NetworkCredential(user, password)

        'Start Upload Process
        request.Method = WebRequestMethods.Ftp.UploadFile

        'Locate File And Store It In Byte Array'
        Dim btfile() As Byte = Encoding.ASCII.GetBytes(text)

        'Get File
        Dim strFile = request.GetRequestStream()

        'Upload Each Byte
        strFile.Write(btfile, 0, btfile.Length)

        'Close
        strFile.Close()

        'Free Memory
        strFile.Dispose()
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Try
            Form1.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Back Error..")
        End Try
    End Sub

    Private Sub right_btn_Click(sender As Object, e As EventArgs) Handles right_btn.Click
        Try
            For Each drr As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView3.Rows.Add(New String() {drr.Cells(0).Value, drr.Cells(1).Value, drr.Cells(2).Value})
                numberOfAcc += 1
            Next
            numberOfAcc_label.Text = "Number of accounts: " + numberOfAcc.ToString
        Catch ex As Exception
            MsgBox("Not added!")
        End Try
    End Sub

    Private Sub left_btn_Click(sender As Object, e As EventArgs) Handles left_btn.Click
        Try
            For Each row As DataGridViewRow In DataGridView3.SelectedRows
                DataGridView3.Rows.Remove(row)
                numberOfAcc -= 1
            Next
            numberOfAcc_label.Text = "Number of accounts: " + numberOfAcc.ToString
        Catch ex As Exception
            MsgBox("Not removed!")
        End Try
    End Sub

    Private Sub createWorkOrder_btn_Click(sender As Object, e As EventArgs) Handles createWorkOrder_btn.Click
        Try
            'Create Work Order and increase the number of Work Order

            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            Dim fileName = "WO_" + WOnumber.ToString + "_" +
                            DateTime.Now.ToString("MMddyy") + "_" +
                            DateTime.Now.ToString("hhmmss") + "_0_" + numberOfAcc.ToString + ".txt"

            Dim text = ""
            For Each row As DataGridViewRow In DataGridView3.Rows
                text = text + row.Cells(1).Value + "," + row.Cells(0).Value + "," + row.Cells(2).Value + ",,,,,," + vbCrLf
            Next

            Try
                UploadToFTP(fileName, text)
                MsgBox("Work Order Created!")

                WOnumber += 1
                objIniFile.WriteString("WorkOrderNumber", "count", WOnumber)

                workOrderNumber_label.Text = "Work Order Number: " + WOnumber.ToString
                numberOfAcc = 0
                numberOfAcc_label.Text = "Number of accounts: " + numberOfAcc.ToString
                DataGridView3.Rows.Clear()
            Catch ex As Exception
                MsgBox("Upload to FTP Error!")
            End Try

        Catch ex As Exception
                MsgBox("Problem in create Work Order")
        End Try
    End Sub

    Private Sub search_pic_Click(sender As Object, e As EventArgs) Handles search_pic.Click
        Try
            'Search by filter in SQL table
            Dim filter As String
            Select Case detailsBy_cmb.SelectedItem
                Case "Account Number"
                    filter = "CustomerNumber"
                Case "Address"
                    filter = "Address"
                Case "Meter SN"
                    filter = "MeterSn"
            End Select

            Dim SQL_query =
                "SELECT CustomerNumber,Address,MeterSn FROM vCustomerDetails WHERE " + filter + " LIKE '%" + search_txt.Text + "%';"

            dt.Clear()
            Try
                Dim myAdapter As New SqlDataAdapter(SQL_query, con)
                myAdapter.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox("Problem with fill Adapter in search by filter.")
            End Try
        Catch ex As Exception
            MsgBox("Problem in search by filter.")
        End Try
    End Sub

    Private Sub search_txt_GotFocus(sender As Object, e As EventArgs) Handles search_txt.GotFocus
        Try
            If search_txt.Text = "Search" Then
                search_txt.Text = ""
                search_txt.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Private Sub search_txt_LostFocus(sender As Object, e As EventArgs) Handles search_txt.LostFocus
        Try
            If search_txt.Text = "" Then
                search_txt.Text = "Search"
                search_txt.ForeColor = Color.Gray
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            search_txt.Text = "Search"
            search_txt.ForeColor = Color.Gray

            detailsBy_cmb.Items.Add("Account Number")
            detailsBy_cmb.Items.Add("Address")
            detailsBy_cmb.Items.Add("Meter SN")
            detailsBy_cmb.SelectedIndex = 0

            Dim server_name As String
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")

            If objIniFile.GetString("Server", "name", "(none)") = "(none)" Then
                server_name = InputBox("Enter SQL server name:", "InputBox", "(local)\sqlExpress")
                objIniFile.WriteString("Server", "name", server_name)
            Else
                server_name = objIniFile.GetString("Server", "name", "(local)\sqlExpress")
            End If

            'Connect to SQL 
            Dim connectionString As String =
               "Data Source=" + server_name + ";Initial Catalog=MCM;User ID=kmcmp;Password=kp2010mcm"
            con = New SqlConnection(connectionString)
            con.Open()

            dt.Clear()
            Try
                Dim myAdapter As New SqlDataAdapter("SELECT CustomerNumber,Address,MeterSn FROM vCustomerDetails;", con)
                myAdapter.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox("Problem with fill Adapter.")
            End Try

            'Serialy Counter for work order numbers
            If objIniFile.GetString("WorkOrderNumber", "count", "(none)") = "(none)" Then
                WOnumber = 1
                objIniFile.WriteString("WorkOrderNumber", "count", WOnumber)
            Else
                WOnumber = objIniFile.GetString("WorkOrderNumber", "count", WOnumber)
            End If
            workOrderNumber_label.Text = "Work Order Number: " + WOnumber.ToString
        Catch ex As Exception
            MsgBox("Connecting to SQL Error!")
        End Try
    End Sub

    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Form1.Show()
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
    End Sub
End Class