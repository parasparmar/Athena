Option Explicit On
Imports System
Imports System.Net
Imports System.IO
Imports Ionic.Zip
Imports System.Threading
Imports System.Threading.Tasks

Public Class FormMain
    Dim clNSE As New NSE
    Dim FolderBrowserDialog As String
    Dim cookieJar As CookieContainer
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpToDate.Value = DateAdd(DateInterval.Day, -1, Today)
        dtpFromDate.Value = DateAdd(DateInterval.Day, -1, Today)
        tbStatusText.Text = "Download Range : " & DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value) - 1 & " days."
        pb1.Maximum = 100
        pb1.Minimum = 1
        pb1.Value = 1

    End Sub

    Private Sub btnSubmit_Click_1(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim i As Integer
        Dim r As Date
        r = dtpFromDate.Value
        clbFiles.Items.Clear()
        Dim j() As Date = Intervals()
        For i = 0 To j.GetUpperBound(0) - 1
            clbFiles.Items.Add(j(i), True)
        Next
        tbStatusText.Text = "Download Range : " & j.GetUpperBound(0) & " days. Weekends excluded."

    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        '' Reset From and To dates.
        dtpToDate.Value = DateAdd(DateInterval.Day, -1, Today)
        dtpFromDate.Value = DateAdd(DateInterval.Day, -1, Today)
        '' Reset clbFiles, cbExchange, cbdatatype
        clbFiles.Items.Clear()
        'cbExchange.SelectedIndex = -1
        'cbDataType.SelectedIndex = -1
        tbStatusText.Text = "Reset Activated."

    End Sub

    Private Sub dtpFromDate_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged
        If dtpFromDate.Value >= Today Then
            MsgBox("The Dates are invalid, " & vbCrLf & "If you'd like to, please try again.", MsgBoxStyle.Information)
            dtpFromDate.Value = DateAdd(DateInterval.Day, -1, Today)
        End If
        tbStatusText.Text = "From Date Set as : " & dtpFromDate.Value

        btnSubmit_Click_1(btnSubmit, New EventArgs) '' Fire the btnSubmit Click for the user's convenience.
    End Sub
    Private Sub dtpToDate_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpToDate.ValueChanged
        If dtpToDate.Value >= Today Then
            MsgBox("As this is an invalid selection, I've reset both these dates to yesterday." & vbCrLf & "If you'd like to, please try again.", MsgBoxStyle.Critical)
            dtpToDate.Value = DateAdd(DateInterval.Day, -1, Today)
        End If
        tbStatusText.Text = "To Date Set : " & dtpToDate.Value

        btnSubmit_Click_1(btnSubmit, New EventArgs) '' Fire the btnSubmit Click for the user's convenience.
    End Sub
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        btnDownload.Enabled = False
        '' btnDownload.Click fires off a chain of events
        '' 0. Request the user to select a folder (MyFolder) where the downloaded files will be kept
        '' 1. Collect the selected dates from clbFiles into an URLArray
        '' 2. Use the URLArray to form an associative array of date,URI,strLocalFileName
        '' 3. Download these files using an instance of the WebClient.DownloadFile Method
        '' 4. On Download completion open MyFolder and show it to the user.

        '' DONE : 0. Request the user to select a folder (MyFolder) where the downloaded files will be kept
        Dim MyFolder, strLocalFileName, strDwnldUri, NewLocalFileName As String
        fbdDownloadLocation.ShowNewFolderButton = True
        If (fbdDownloadLocation.ShowDialog() = Windows.Forms.DialogResult.OK) And clbFiles.Items.Count > 0 Then
            MyFolder = fbdDownloadLocation.SelectedPath
            '' MsgBox(MyFolder)
        Else
            MyFolder = My.Computer.FileSystem.CurrentDirectory
        End If
        '' IN PROGRESS : 1. Collect the selected dates from clbFiles into an URLArray
        Dim clNSE As New NSE
        '' DONE :  3. Download these files using an instance of the WebClient.DownloadFile Method
        '' DONE :  4. On Download completion open MyFolder and show it to the user.
        For i = 0 To clbFiles.CheckedItems.Count - 1
            Dim j As New DateTime
            j = CDate(clbFiles.CheckedItems(i))
            If j.DayOfWeek = DayOfWeek.Saturday Or j.DayOfWeek = DayOfWeek.Sunday Then
                '' Empty if block avoids generating download workload for weekends
            Else
                strDwnldUri = clNSE.EquityURL(CDate(clbFiles.CheckedItems(i)))
                strLocalFileName = MyFolder & "\" & clNSE.NSEEquityFileName(clbFiles.CheckedItems(i))
                NewLocalFileName = Format(clbFiles.CheckedItems(i), "yyyyMMdd") & ".csv"

                ''---------- This is the Synchronous downloader.
                If DownloaderSync(strDwnldUri, strLocalFileName, NewLocalFileName) = True Then
                    pb1.Value = CDec((i + 1) / clbFiles.CheckedItems.Count) * 100
                    tbStatusText.Text = pb1.Value.ToString & " %"

                Else
                    tbStatusText.Text = "Download FAILED for : " & Path.GetFileName(strLocalFileName)
                End If
                '' --------End of the Synchronous downloader region.

            End If
        Next
        btnDownload.Enabled = True

        tbStatusText.Text = pb1.Value.ToString & " %"
    End Sub

    Private Function Intervals() As Date()
        '' Status : In Production 09-08-2014 14.20
        Dim DatesToDownload As Date() = {dtpFromDate.Value}
        ReDim DatesToDownload(DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value))
        Dim i, j As Integer
        j = 0
        If dtpFromDate.Value = dtpToDate.Value Then '' Check for the same From and To dates.
            DatesToDownload(0) = dtpFromDate.Value '' Set this to From value only, Returning Array of dates has one member only.
        Else
            For i = 0 To DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value) - 1
                If DateAdd(DateInterval.Day, i, dtpFromDate.Value).DayOfWeek = DayOfWeek.Saturday _
                    Or DateAdd(DateInterval.Day, i, dtpFromDate.Value).DayOfWeek = DayOfWeek.Sunday Then
                    '' Empty if block avoids generating workload for weekends
                Else
                    DatesToDownload(j) = DateAdd(DateInterval.Day, i, dtpFromDate.Value)
                    j = j + 1 '' increase the count of dates to be filled
                End If
            Next
        End If
        ReDim Preserve DatesToDownload(j)
        Return DatesToDownload
    End Function


    Private Function DownloaderSync(ByRef strDwnldUri As String, ByRef strLocalFileName As String, ByRef NewLocalFileName As String) As Boolean
        ' ToDo: Check for Internet Connectivity
        ' Although the Synchronous downloader works. THe Async is better as it will not block the calling program.
        ' Allowing it to remain responsive.
        Try
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            request = WebRequest.Create(strDwnldUri)
            With request
                .UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko"
                .Accept = "text/html, application/xhtml+xml, */*"
                ''.Connection = "Keep-Alive"
                .Headers.Add("Accept-Language", "en-IN")
                .Headers.Add("Accept-Encoding", "gzip, deflate")
                .Headers.Add("DNT", "1")
                .CookieContainer = cookieJar
            End With
            ' Display the headers in the request
            ''Debug.WriteLine("Resulting Request Headers: " & request.Headers.Keys.Count.ToString())
            ''Debug.WriteLine(request.Headers.ToString())
            response = request.GetResponse()
            '' DownloadWriter downloads and renames the expected ZIP from response into a localfile named NewLocalFileName
            '' Returns true if successful and false if not.
            If DownloadWriter(response, strLocalFileName, NewLocalFileName) = True Then
                DownloaderSync = True
            Else
                DownloaderSync = False
            End If
            '' Tidy up the HTTPWebResponse
            response.Close()
        Catch ex As Exception
            DownloaderSync = False
            Exit Function
        End Try
        DownloaderSync = True
    End Function
    '' Created 25-09-2015, in production.
    Private Function DownloadWriter(ByRef response As HttpWebResponse, ByRef strLocalFileName As String, ByRef NewLocalFileName As String) As Boolean
        ' Take the HTTP Web response from Downloader.
        ' Unzip it to the destination folder.
        If response.ContentType = "application/zip" Then

            Dim intLen As Int32 = response.ContentLength

            Dim memStream As MemoryStream
            Using stmResponse As IO.Stream = response.GetResponseStream()

                Dim buffer = New Byte(intLen) {}

                Dim bytesRead As Integer = 0 '' 15-08-2014 23.33 This caused me a lot of headaches.
                '' Please make sure that the bytesread=0 stays
                Do
                    bytesRead += stmResponse.Read(buffer, bytesRead, intLen - bytesRead)
                Loop Until bytesRead = intLen
                memStream = New MemoryStream(buffer)
                Dim res As Boolean = False
                Dim ExtractedFileName As String
                ExtractedFileName = Path.GetDirectoryName(strLocalFileName)
                res = ZipExtracttoFile(memStream, ExtractedFileName)
                strLocalFileName = Replace(strLocalFileName, ".zip", "")
                If My.Computer.FileSystem.FileExists(ExtractedFileName & "\" & NewLocalFileName) Then
                    My.Computer.FileSystem.DeleteFile(ExtractedFileName & "\" & NewLocalFileName)
                    Debug.WriteLine("Deleted Existing File : " + NewLocalFileName)
                End If
                My.Computer.FileSystem.RenameFile(strLocalFileName, NewLocalFileName)
            End Using

            DownloadWriter = True
        Else
            tbStatusText.Text = "The downloaded content for " & Path.GetFileName(strLocalFileName) & "Is NOT a Zip file. It is a " + response.ContentType.ToString
            DownloadWriter = False
        End If
    End Function

    Private Function ZipExtracttoFile(strm As MemoryStream, strDestDir As String) As Boolean
        Try
            Using zip As ZipFile = ZipFile.Read(strm)
                zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently

                For Each e As ZipEntry In zip
                    e.Extract(strDestDir)
                Next
            End Using
        Catch ex As Exception
            Console.Error.WriteLine("exception: {0}", ex.ToString)
            Return False
        End Try
        Return True
    End Function
End Class









