Option Explicit On
Imports System.Net
Imports System.IO
Imports Ionic.Zip
Imports System.Collections.Generic

Public Class FormMain

    Dim FolderBrowserDialog As String
    Dim cookieJar As CookieContainer
    Dim MyFolder As String = vbEmpty

    Enum GUIStage
        Initialization
        DestinationPath
        'DateRangeChosen
        DatesToDownload
        MarketChosen
        DestinationFormatsChosen
        DownloadsActivated
        ResetActivated
        SaveSettings
    End Enum

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GUIUpdater(GUIStage.Initialization)
    End Sub

    Private Sub GUIUpdater(ByVal Stage As GUIStage)
        'TODO: Initialization, DestinationPath, DateRangeChosen, DatesToDownload, MarketChosen, DestinationFormatsChosen, DownloadsActivated, ResetActivated, SaveSettings. 


        Select Case Stage
            Case GUIStage.Initialization
                gbChooseDates.Visible = False
                gbChooseMarkets.Visible = False
                gbDataFormats.Visible = False
                btnDownload.Enabled = False
                btnReset.Enabled = False
                btnNewProfile.Enabled = False
                tsprogressbar1.Minimum = 1
                tsprogressbar1.Maximum = 100
                tsprogressbar1.Value = 1
                tsStatusText.Text = "Please select a folder to download data at."

            Case GUIStage.DestinationPath
                gbChooseDates.Visible = True
                gbChooseMarkets.Visible = False
                gbDataFormats.Visible = False
                btnDownload.Enabled = False
                btnReset.Enabled = False
                btnNewProfile.Enabled = False
                tsStatusText.Text = "Please select the dates to download data for."

            'Case GUIStage.DateRangeChosen
            Case GUIStage.DatesToDownload
                gbChooseMarkets.Visible = True
                gbDataFormats.Visible = False
                btnDownload.Enabled = False
                btnReset.Enabled = False
                btnNewProfile.Enabled = False
                tsStatusText.Text = "Please select the type of Stock Market data to download."

            Case GUIStage.MarketChosen
                gbDataFormats.Visible = True
                btnDownload.Enabled = False
                btnReset.Enabled = False
                btnNewProfile.Enabled = False
                tsStatusText.Text = "Please choose the format to convert your Stock Market data."

            Case GUIStage.DestinationFormatsChosen
                btnDownload.Enabled = True
                btnReset.Enabled = False
                btnNewProfile.Enabled = True
                tsStatusText.Text = "Athena's ready to download Stock Market data."

            Case GUIStage.DownloadsActivated
                btnReset.Enabled = True
                btnNewProfile.Enabled = True

            Case GUIStage.ResetActivated

            Case GUIStage.SaveSettings
            Case Else
        End Select

    End Sub

    ' Stage 1 : Choose a valid Download Path.
    Private Sub tbDownloadLocation_Click(sender As Object, e As EventArgs) Handles tbDownloadLocation.Click
        ' 0. Request the user to select a folder (MyFolder) where the downloaded files will be kept
        fbdDownloadLocation.ShowNewFolderButton = True
        If (fbdDownloadLocation.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            MyFolder = fbdDownloadLocation.SelectedPath
            Dim folderExists As Boolean = My.Computer.FileSystem.DirectoryExists(MyFolder)
            If folderExists Then
                tbDownloadLocation.Text = MyFolder.ToString
                btnDownload.Enabled = True
            Else
                tbDownloadLocation.Text = "Please select the folder to download at."
            End If
        End If
        GUIUpdater(GUIStage.DestinationPath)
    End Sub

    ' Stage 2 : Choose a valid dates for the download.
    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged
        clbFilesUpdater() '' Sub runs and populates the checked list box with a list of dates to download.
    End Sub
    Private Sub dtpToDate_ValueChanged(sender As Object, e As EventArgs)
        clbFilesUpdater() '' Sub runs and populates the checked list box with a list of dates to download.
    End Sub

    Private Sub clbFilesUpdater()
        clbFiles.Items.Clear()
        Dim MyDates As Date()
        MyDates = DateListGenerator(dtpFromDate.Value, dtpToDate.Value) '' DateList Generator gets an array of weekday dates between the given from and to dates.
        For Each Mydate In MyDates
            clbFiles.Items.Add(Mydate, True) '' Added items will be Selected by default.
        Next
        GUIUpdater(GUIStage.DatesToDownload)
    End Sub


    Private Function DateListGenerator(ByVal FromDate As Date, ByVal ToDate As Date) As Date()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim DateListArray As New List(Of Date)
        j = DateDiff(DateInterval.Day, FromDate, ToDate)
        If j = 0 Then
            DateListArray.add(FromDate)
        Else
            For i = 0 To j - 1
                If DateAdd(DateInterval.Day, i, FromDate).DayOfWeek = DayOfWeek.Saturday Or DateAdd(DateInterval.Day, i, FromDate).DayOfWeek = DayOfWeek.Sunday Then
                    '' Skip Saturdays and Sundays.
                Else
                    DateListArray.Add(DateAdd(DateInterval.Day, i, FromDate))
                End If
            Next
        End If
        Return DateListArray.ToArray
    End Function

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        '' Production : 19-10-2015 17.55

        Dim clNSE As New URLTransformer
        Dim MyFileNameandURL2DArray(clbFiles.SelectedItems.Count, 3) As String
        Dim MyDatesArray(clbFiles.CheckedItems.Count) As Date
        'Done 1: Collect the selected dates from clbFiles into an MyDatesArray

        For i = 0 To clbFiles.CheckedItems.Count - 1
            MyDatesArray(i) = clbFiles.CheckedItems(i)
        Next
        ' Done 2: Use the MyDatesArray to receive a 2DArray of Server and LocalFileNames and the URI to download from
        MyFileNameandURL2DArray = clNSE.URLFromOptions(MyDatesArray)
        'Done 3: Check for Internet Connectivity

        If My.Computer.Network.IsAvailable Then

            ' Done 4. Download these files using an instance of the WebClient.DownloadFile Method one after the other

            For i = 0 To UBound(MyFileNameandURL2DArray, 1) - 1
                ''---------- This is the Synchronous downloader.
                If DownloadAgent(MyFileNameandURL2DArray(i, 1).ToString, tbDownloadLocation.Text.ToString & "\" & MyFileNameandURL2DArray(i, 2).ToString, MyFileNameandURL2DArray(i, 3).ToString) = True Then
                    'TODO: Increment Progress of file download
                    If i >= 1 And i <= UBound(MyFileNameandURL2DArray, 1) - 1 Then
                        tsprogressbar1.Value = 100 * (i / (UBound(MyFileNameandURL2DArray, 1) - 1))
                        ''tsStatusText.Text = "Downloaded : " & i & "of " & UBound(MyFileNameandURL2DArray, 1)
                    End If
                End If
            Next
            '' --------End of the Synchronous downloader region.
            tsStatusText.Text = "Downloaded all " & UBound(MyFileNameandURL2DArray, 1) & " Files"
            ' Done 4. On Download completion open MyFolder and show it to the user
            Process.Start(“explorer”, tbDownloadLocation.Text.ToString)
        Else
            Debug.WriteLine("Network is not available")
            End
        End If
    End Sub


    Private Function DownloadAgent(ByVal strDwnldUri As String, ByVal strLocalFileName As String, ByVal NewLocalFileName As String) As Boolean

        'ISSUE : Although the Synchronous downloader works. It will freeze the UI. This is a known devil.

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
            response = request.GetResponse()
            '' DownloadWriter downloads and renames the expected ZIP from response into a localfile named NewLocalFileName
            '' Returns true if successful and false if not.
            If DownloadWriter(response, strLocalFileName, NewLocalFileName) = True Then
                DownloadAgent = True
            Else
                DownloadAgent = False
            End If
            '' Tidy up the HTTPWebResponse
            response.Close()
        Catch ex As Exception
            DownloadAgent = False
            Exit Function
        End Try
        DownloadAgent = True
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
                res = ZipExtracttoFile(memStream, ExtractedFileName) '' A wrapper function to Ionic.Zip library is used here.
                strLocalFileName = Replace(strLocalFileName, ".zip", "")
                If My.Computer.FileSystem.FileExists(ExtractedFileName & "\" & NewLocalFileName) Then
                    My.Computer.FileSystem.DeleteFile(ExtractedFileName & "\" & NewLocalFileName)
                    Debug.WriteLine("Deleted Existing File : " + NewLocalFileName)
                End If
                My.Computer.FileSystem.RenameFile(strLocalFileName, NewLocalFileName)
            End Using
            DownloadWriter = True
        Else
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
            Debug.WriteLine("exception: {0}", ex.ToString)
            Return False
        End Try
        Return True
    End Function


    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        '' Reset From and To dates.
        dtpFromDate.Value = DateAdd(DateInterval.Day, -1, Today)
        dtpToDate.Value = Today
        clbFiles.Items.Clear()
        tsStatusText.Text = "Reset Activated."
        tsprogressbar1.Value = 1
    End Sub

    Private Sub clbMarkets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbMarkets.SelectedIndexChanged
        GUIUpdater(GUIStage.MarketChosen)
    End Sub

    Private Sub gbDataFormats_Enter(sender As Object, e As EventArgs) Handles gbDataFormats.Enter
        GUIUpdater(GUIStage.DestinationFormatsChosen)
    End Sub
End Class









