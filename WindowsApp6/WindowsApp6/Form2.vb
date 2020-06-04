Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Form2
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
        Dim request = DirectCast(WebRequest.Create("ftp://" + host + ":" + port + "/Complete Work Orders/*"), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.ListDirectory

        'Specify Username & Password
        Dim user = objIniFile.GetString("FTP user", "user", "user")
        Dim password = objIniFile.GetString("FTP password", "password", "password")
        request.Credentials = New NetworkCredential(user, password)

        Dim sw As New StringWriter

        'File Unavailable error when getting response below.
        Try
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
    Public Sub DeleteFileFromFTP(fileName As String)
        ' Get the object used to communicate with the server.
        Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
        Dim host = objIniFile.GetString("FTP host", "host", "host")
        Dim port = objIniFile.GetString("FTP port", "port", "21")

        Dim user = objIniFile.GetString("FTP user", "user", "user")
        Dim password = objIniFile.GetString("FTP password", "password", "password")

        'Request for download file
        Dim request = DirectCast(WebRequest.Create("ftp://" + host + ":" + port + "/Complete Work Orders/" + fileName), FtpWebRequest)
        request.Credentials = New NetworkCredential(user, password)
        request.Method = WebRequestMethods.Ftp.DeleteFile
        Dim response = request.GetResponse()

        response.Close()
    End Sub
    Public Sub DownloadFromFTP(fileName As String, destinationFile As String)
        Try
            ' Get the object used to communicate with the server.
            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            Dim host = objIniFile.GetString("FTP host", "host", "host")
            Dim port = objIniFile.GetString("FTP port", "port", "21")

            Dim user = objIniFile.GetString("FTP user", "user", "user")
            Dim password = objIniFile.GetString("FTP password", "password", "password")

            'Request for download file
            Dim request = DirectCast(WebRequest.Create("ftp://" + host + ":" + port + "/Complete Work Orders/" + fileName), FtpWebRequest)
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

            DeleteFileFromFTP(fileName)
            MsgBox("Download Complete!")
        Catch ex As Exception
            MsgBox("Download file from FTP Error!")
        End Try
    End Sub
    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Try
            Form1.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Problem with back..")
        End Try
    End Sub
    Private Sub search_pic_Click(sender As Object, e As EventArgs) Handles search_pic.Click
        Try
            'Search by filter 
            Dim filtered_files_name As New List(Of String)
            Dim search_txt = Me.search_txt.Text
            Select Case detailsBy_cmb.SelectedItem
                Case "Work Order Number"
                    For Each file_name In fileNames
                        If file_name.StartsWith("WO_" + search_txt) Then
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

                Case "Complete"
                    If search_txt.Contains("/") Then
                        Dim splited_search_txt = search_txt.Split("/")
                        For Each file_name In fileNames
                            Dim splited_file_name = file_name.Split("_")
                            splited_file_name(5) = splited_file_name(5).Replace(".txt", "")
                            If splited_file_name(4).Equals(splited_search_txt(0)) And splited_file_name(5).Equals(splited_search_txt(1)) Then
                                filtered_files_name.Add(file_name)
                            End If
                        Next

                    Else
                        For Each file_name In fileNames
                            Dim splited_file_name = file_name.Split("_")
                            If (splited_file_name(4) + " " + splited_file_name(5)).Contains(search_txt) Then
                                filtered_files_name.Add(file_name)
                            End If
                        Next
                    End If

            End Select

            DataGridView1.Rows.Clear()
            Dim splited As String()
            For Each file_name In filtered_files_name
                If file_name IsNot Nothing Then
                    splited = file_name.Split("_")
                    Dim _date As String() = {splited(2).Substring(0, 2), splited(2).Substring(2, 2), splited(2).Substring(4, 2)}
                    Dim _time As String() = {splited(3).Substring(0, 2), splited(3).Substring(2, 2), splited(3).Substring(4, 2)}
                    Dim _dateStr = _date(0) + "/" + _date(1) + "/" + _date(2)
                    Dim _timeStr = _time(0) + ":" + _time(1) + ":" + _time(2)
                    splited(5) = splited(5).Replace(".txt", "")
                    DataGridView1.Rows.Add(New String() {splited(1), _dateStr + "  " + _timeStr, splited(4) + "/" + splited(5)})
                End If
            Next
        Catch ex As Exception
            MsgBox("Error in search by filter!")
        End Try
    End Sub
    Private Sub search_txt_GotFocus(sender As Object, e As EventArgs) Handles search_txt.GotFocus
        If search_txt.Text = "Search" Then
            search_txt.Text = ""
            search_txt.ForeColor = Color.Black
        End If
    End Sub
    Private Sub search_txt_LostFocus(sender As Object, e As EventArgs) Handles search_txt.LostFocus
        If search_txt.Text = "" Then
            search_txt.Text = "Search"
            search_txt.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            search_txt.Text = "Search"
            search_txt.ForeColor = Color.Gray

            detailsBy_cmb.Items.Add("Work Order Number")
            detailsBy_cmb.Items.Add("Date\Time")
            detailsBy_cmb.Items.Add("Complete")
            detailsBy_cmb.SelectedIndex = 0

            Try
                getFilesNames()
            Catch ex As Exception
                MsgBox("Problem with FTP connection!")
            End Try


            Dim splited As String()
                For Each file_name In fileNames
                    If file_name IsNot Nothing Then
                        splited = file_name.Split("_")
                        Dim _date As String() = {splited(2).Substring(0, 2), splited(2).Substring(2, 2), splited(2).Substring(4, 2)}
                        Dim _time As String() = {splited(3).Substring(0, 2), splited(3).Substring(2, 2), splited(3).Substring(4, 2)}
                        Dim _dateStr = _date(0) + "/" + _date(1) + "/" + _date(2)
                        Dim _timeStr = _time(0) + ":" + _time(1) + ":" + _time(2)
                        splited(5) = splited(5).Replace(".txt", "")
                        DataGridView1.Rows.Add(New String() {splited(1), _dateStr + "  " + _timeStr, splited(4) + "/" + splited(5)})
                    End If
                Next

            Catch ex As Exception
                MsgBox("Error in load form!")
        End Try
    End Sub

    Private Sub importWorkOrder_btn_Click(sender As Object, e As EventArgs) Handles importWorkOrder_btn.Click    'Import Work Order button click

        Try
            'Insert Work Order to MCM 

            Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\GeneralOptions.ini")
            Dim host = objIniFile.GetString("FTP host", "host", "host")
            Dim port = objIniFile.GetString("FTP port", "port", "21")

            Dim user = objIniFile.GetString("FTP user", "user", "user")
            Dim password = objIniFile.GetString("FTP password", "password", "password")
            Dim text_file As String

            Using web_client As New System.Net.WebClient
                web_client.Credentials = New System.Net.NetworkCredential(user, password)
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    Dim file_name = fileNames(row.Index)
                    text_file = web_client.DownloadString("ftp://" + host + ":" + port + "/Complete Work Orders/" + file_name) 'get text of file
                    Dim lines() As String = text_file.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries) 'split to lines

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
                    For i = 0 To lines.Count - 1
                        Dim data = lines(i).Split(",")
                        InsertToSQL(data(1), data(0), data(7), data(8), data(4), data(5))
                    Next

                    'Close SQL connection 
                    con.Close()

                    fileNames.RemoveAt(row.Index)
                    DataGridView1.Rows.Remove(row)
                Next
            End Using
        Catch ex As Exception
            MsgBox("Problem with insert Work Order to SQL!")
        End Try
    End Sub

    Private Sub InsertToSQL(ByVal Account_Number As String, ByVal Address As String, ByVal Lat As String, ByVal Lon As String,
                            ByVal Node_ID As String, ByVal MeterSN As String)
        Try

            Dim commandText As String = " declare @CustomerID bigint " &
                                    " declare @CustomerMTUID bigint " &
                                    " declare @CustomerMeterID bigint " &
                                     " SELECT @CustomerID = MAX(CustomerID) + 1 FROM CustomerDetails " &
                                     " SELECT @CustomerMeterID = MAX(CustomerMeterID) + 1 FROM CustomerMeter " &
                                     " SELECT @CustomerMTUID = MAX(CustomerMTUID) + 1 FROM CustomerMTU " &
                                     " IF @CustomerID IS NULL  SET @CustomerID = 1 IF @CustomerMeterID IS NULL  SET @CustomerMeterID = 1  " &
                                " BEGIN TRAN " &
                                " If Not EXISTS (SELECT * FROM CustomerMTU WHERE MTUaddress = '" + Account_Number + "') " &
                                " BEGIN " &
                                " INSERT CustomerDetails(CustomerID, CustomerNumber, CustomerTypesID, Address, Cycle, DefinitionDate, LastUpdate,  FreeColumn3, FreeColumn4, FreeColumn5, Freeze, Flagged) " &
                                                " VALUES (@CustomerID, '" + Account_Number + "', 1, '" + Address + "', 1, GETDATE(), GETDATE(), 0, 0, 0, 0, 0)" &
                                " INSERT CustomerMTU (CustomerID, MTUreceiver, MTUsystem, MTUaddress, InstallDate, CustomerMeterID, Latitude, Longitude) " &
                                                " VALUES (@CustomerID, '1', '0', '" + Node_ID + "', GETDATE(), @CustomerMeterID, '" + Lat + "', '" + Lon + "')" &
                                " INSERT CustomerMeter(CustomerMeterID, CustomerID, MeterSN, MeterTypeID, IrrigationMeter, FireLine, Vacant, Minimum, Maximum, Critical, MeterLocation) " &
                                                " VALUES (@CustomerMeterID, @CustomerID, '" + MeterSN + "', 0, 0, 0, 0, 0, 10, 10, 1) " &
                                " END " &
                                " COMMIT TRAN"


            cmd.Connection = con
            cmd.CommandText = commandText
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Insert to SQL Error!")
        End Try
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Form1.Show()
        Catch ex As Exception
            MsgBox("Closing form Error!")
        End Try
    End Sub
End Class