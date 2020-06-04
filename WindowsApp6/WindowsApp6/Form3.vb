Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form3
    Public fileNames As New List(Of String)
    Public con As SqlConnection
    Public cmd As New SqlCommand


    Public Sub getFilesNames()
        'get all of the files names from the complete work orders
        Dim returnStr As String = ""
        Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
        Dim host = objIniFile.GetString("FTP host", "host", "host")
        Dim port = objIniFile.GetString("FTP port", "port", "21")

        'Create Request To Upload File
        Dim request = DirectCast(WebRequest.Create("ftp://" + host + ":" + port + "/History Log/*"), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.ListDirectory

        'Specify Username & Password
        Dim user = objIniFile.GetString("FTP user", "user", "user")
        Dim password = objIniFile.GetString("FTP password", "password", "password")
        request.Credentials = New NetworkCredential(user, password)

        Dim sw As New StringWriter

        Try
            'File Unavailable error when getting response below.
            Dim response As WebResponse = request.GetResponse
            Dim responseStream As Stream = response.GetResponseStream
            Dim ch As Integer
            ch = responseStream.ReadByte()
            While (ch <> -1)
                Console.Write(ch)
                returnStr += Convert.ToChar(ch)
                ch = responseStream.ReadByte()
            End While

            responseStream.Close()
            response.Close()

            fileNames = (returnStr.Split(vbLf)).ToList
            For i = 0 To fileNames.Count - 1
                fileNames(i) = Replace(fileNames(i), vbCr, "")
            Next

            Dim j = 0
            While j < fileNames.Count
                If fileNames(j) Is Nothing Then
                    fileNames.RemoveAt(j)
                Else
                    j += 1
                End If
            End While
        Catch ex As Exception
            MsgBox("Problem with FTP connection!")
            Form1.Show()
            Me.Close()
        End Try
    End Sub

    Public Sub DownloadFromFTP(fileName As String, destinationFile As String)
        Try
            ' Get the object used to communicate with the server.
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            Dim host = objIniFile.GetString("FTP host", "host", "host")
            Dim user = objIniFile.GetString("FTP user", "user", "user")
            Dim password = objIniFile.GetString("FTP password", "password", "password")

            'Request for download file
            Dim request = DirectCast(WebRequest.Create("ftp://" + host + "/History Log/" + fileName), FtpWebRequest)
            request.Credentials = New NetworkCredential(user, password)
            request.Method = WebRequestMethods.Ftp.DownloadFile
            Dim responseStream As Stream = request.GetResponse().GetResponseStream()

            Dim outputfFilePath = destinationFile & "\" & fileName
            Dim output As Stream = File.Create(outputfFilePath)
            Dim byteIn = 1
            Dim buffer(1023) As Byte

            Do Until byteIn < 1
                byteIn = responseStream.Read(buffer, 0, 1024)
                If byteIn > 0 Then
                    output.Write(buffer, 0, byteIn)
                End If
            Loop

            output.Close()
            responseStream.Close()

            'DeleteFileFromFTP(fileName)
            MsgBox("Download Complete!")
        Catch ex As Exception
            MsgBox("Download file from FTP Error!")
        End Try
    End Sub
    Public Sub UploadToFTP(fileName As String, text As String)
        Try
            ' Get the object used to communicate with the server.
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            Dim host = objIniFile.GetString("FTP host", "host", "host")

            'Create Request To Upload File
            Dim request = DirectCast(WebRequest.Create("ftp://" + host + "/Work Orders/" + fileName), FtpWebRequest)

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
        Catch ex As Exception
            MsgBox("Upload file to FTP Error!")
        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Try
            Form1.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("back problem..")
        End Try
    End Sub

    Private Sub search_pic_Click(sender As Object, e As EventArgs) Handles search_pic.Click
        Try
            'Search by filter 
            Dim filtered_files_name As New List(Of String)
            Dim search_txt = Me.search_txt.Text
            Select Case detailsBy_cmb.SelectedItem
                Case "Node ID"
                    For Each file_name In fileNames
                        Dim splited_file_name = file_name.Split("_")
                        Dim nodeID = Convert.ToInt32(splited_file_name(1))
                        If nodeID.ToString.StartsWith(search_txt) Then
                            filtered_files_name.Add(file_name)
                        End If
                    Next
                Case "Date\Time"
                    Dim help_str As String = ""
                    If search_txt.Contains("/") Then     'Search Date
                        Dim split_search_txt = search_txt.Split("/")
                        For i = 0 To split_search_txt.Length - 1
                            If split_search_txt(i).Length < 2 Then
                                split_search_txt(i) = "0" + split_search_txt(i)
                            End If
                        Next
                        help_str = String.Join("", split_search_txt)

                        For Each file_name In fileNames
                            Dim splited_file_name = file_name.Split("_")
                            If splited_file_name(2).Contains(help_str) Then
                                filtered_files_name.Add(file_name)
                            End If
                        Next

                    ElseIf search_txt.Contains(":") Then      'Search Time
                        Dim split_search_txt = search_txt.Split(":")
                        For i = 0 To split_search_txt.Length - 1
                            If split_search_txt(i).Length < 2 Then
                                split_search_txt(i) = "0" + split_search_txt(i)
                            End If
                            help_str = String.Join("", split_search_txt)
                        Next

                        For Each file_name In fileNames
                            Dim splited_file_name = file_name.Split("_")
                            If splited_file_name(3).Contains(help_str) Then
                                filtered_files_name.Add(file_name)
                            End If
                        Next

                    Else  'One of them
                        help_str = search_txt
                        For Each file_name In fileNames
                            Dim splited_file_name = file_name.Split("_")
                            If (splited_file_name(2) + " " + splited_file_name(3)).Contains(help_str) Then
                                filtered_files_name.Add(file_name)
                            End If
                        Next
                    End If

                Case "Meter SN"
                    For Each file_name In fileNames
                        If file_name.StartsWith(search_txt) Then
                            filtered_files_name.Add(file_name)
                        End If
                    Next

            End Select

            DataGridView1.Rows.Clear()
            Dim splited As String()
            For Each file_name In filtered_files_name
                If file_name IsNot Nothing Then
                    splited = file_name.Split("_")
                    splited(3) = splited(3).Replace(".csv", "")

                    Dim _date As String() = {splited(2).Substring(0, 2), splited(2).Substring(2, 2), splited(2).Substring(4, 2)}
                    Dim _time As String() = {splited(3).Substring(0, 2), splited(3).Substring(2, 2), splited(3).Substring(4, 2)}
                    Dim _dateStr = _date(0) + "/" + _date(1) + "/" + _date(2)
                    Dim _timeStr = _time(0) + ":" + _time(1) + ":" + _time(2)
                    Dim meterSN = splited(0)
                    Dim nodeID = Convert.ToInt32(splited(1))
                    DataGridView1.Rows.Add(New String() {nodeID.ToString, _dateStr + "  " + _timeStr, meterSN})
                End If
            Next
        Catch ex As Exception
            MsgBox("Error in search by filter!")
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            search_txt.Text = "Search"
            search_txt.ForeColor = Color.Gray

            detailsBy_cmb.Items.Add("Node ID")
            detailsBy_cmb.Items.Add("Date\Time")
            detailsBy_cmb.Items.Add("Meter SN")
            detailsBy_cmb.SelectedIndex = 0

            getFilesNames()

            Dim splited As String()
            For Each file_name In fileNames
                If file_name IsNot Nothing Then
                    splited = file_name.Split("_")
                    splited(3) = splited(3).Replace(".csv", "")

                    Dim _date As String() = {splited(2).Substring(0, 2), splited(2).Substring(2, 2), splited(2).Substring(4, 2)}
                    Dim _time As String() = {splited(3).Substring(0, 2), splited(3).Substring(2, 2), splited(3).Substring(4, 2)}
                    Dim _dateStr = _date(0) + "/" + _date(1) + "/" + _date(2)
                    Dim _timeStr = _time(0) + ":" + _time(1) + ":" + _time(2)
                    Dim meterSN = splited(0)
                    Dim nodeID = Convert.ToInt32(splited(1))
                    DataGridView1.Rows.Add(New String() {nodeID.ToString, _dateStr + "  " + _timeStr, meterSN})
                End If
            Next
        Catch ex As Exception
            MsgBox("Problem with load form..")
        End Try
    End Sub

    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Form1.Show()
        Catch ex As Exception
            MsgBox("Closing form Error..")
        End Try
    End Sub

    Private Sub importLog_btn_Click(sender As Object, e As EventArgs) Handles importLog_btn.Click  'Import History Log button click
        Try
            'Insert History Log to MCM
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            Dim host = objIniFile.GetString("FTP host", "host", "host")
            Dim user = objIniFile.GetString("FTP user", "user", "user")
            Dim password = objIniFile.GetString("FTP password", "password", "password")
            Dim text_file As String

            Using web_client As New System.Net.WebClient
                web_client.Credentials = New System.Net.NetworkCredential(user, password)
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    Dim file_name = fileNames(row.Index)
                    text_file = web_client.DownloadString("ftp://" + host + "/History Log/" + file_name) 'get text of csv file
                    Dim lines() As String = text_file.Trim.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries) 'split to lines

                    'Open SQL connection 
                    Dim server_name As String

                    If objIniFile.GetString("Server", "name", "(none)") = "(none)" Then
                        server_name = InputBox("Enter SQL server name:", "InputBox", "(local)\sqlExpress")
                        objIniFile.WriteString("Server", "name", server_name)
                    Else
                        server_name = objIniFile.GetString("Server", "name", "(local)\sqlExpress")
                    End If

                    Dim connectionString As String =
                        "Data Source=" + server_name + ";Initial Catalog=MCM;User ID=kmcmp;Password=kp2010mcm"
                    con = New SqlConnection(connectionString)
                    con.Open()

                    'Read each line in file and insert to the DB
                    For i = lines.Count - 1 To 1 Step -1
                        Dim data = lines(i).Split(",")
                        Dim _dateTime = data(1).TrimStart.Split(" ")
                        Dim _hour = _dateTime(1).Split(":")

                        If Convert.ToInt16(_hour(1)) > 31 Then
                            Dim h = Convert.ToInt16(_hour(0))
                            h += 1
                            If h = 24 Then
                                _hour(0) = "00"
                            Else
                                _hour(0) = h.ToString
                            End If
                        End If

                        _hour(1) = "00"
                        _hour(2) = "00"
                        _dateTime(1) = String.Join(":", _hour)

                        Dim _date = _dateTime(0).Split("/")
                        _dateTime(0) = _date(2) & _date(0) & _date(1)

                        data(1) = String.Join(" ", _dateTime)
                        InsertToSQL(data(1), data(3).TrimStart, data(2).TrimStart)

                    Next

                    'Close SQL connection 
                    con.Close()

                    fileNames.RemoveAt(row.Index)
                    DataGridView1.Rows.Remove(row)
                Next
            End Using
        Catch ex As Exception
            MsgBox("Problem with insert History Log to SQL!")
        End Try
    End Sub

    Private Sub InsertToSQL(ByVal _dateTime As String, ByVal Trans_Address As String, ByVal Message As String)
        Try
            Dim commandText As String
            If Message.Equals("TAMPER") = True Then
                commandText = "EXEC sp_IncomSignals 4, '" + _dateTime + "',1,'0', '" + Trans_Address + "', 7,163, 3, '0', 1, 1, 0, '0', 0,'-1'"
            Else
                Dim number = Convert.ToDouble(Message)
                commandText = "EXEC sp_IncomSignals 4, '" + _dateTime + "',1,'0','" + Trans_Address + "', 4," + number.ToString + ", 3, '0', 1, 1, 0, '0', 0,'-1'"
            End If
            Console.WriteLine(commandText)
            cmd.Connection = con
            cmd.CommandText = commandText
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Insert to SQL Error!")
        End Try
    End Sub
End Class