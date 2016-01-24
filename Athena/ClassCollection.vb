Imports System.Net
Imports System.IO
Imports Ionic.Zip
Public Class Engine
    '' Status: In Production 24-01-2016 21.48
    ''' <summary>
    ''' The DateListGenerator is a method of returning a range of downloadable dates. It's meant to reduce the work of searching for and 
    ''' downloading invalid dates. ie: weekends, public holidays, non-tradeable dates in general.
    ''' The intent is to populate only those valid dates for selection.
    ''' </summary>
    ''' <param name="FromDate">Date from </param>
    ''' <param name="ToDate"></param>
    ''' <returns></returns>
    Public Function DateListGenerator(ByVal FromDate As Date, ByVal ToDate As Date)
        '' Objective : DateList Generator generates an array of weekday dates between the given from and to dates.
        '' Input : FromDate, ToDate as Dates
        '' Output : ArrayList of Dates - strongly typed.
        '' Status : Production
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim DateListArray As New List(Of Date)
        j = DateDiff(DateInterval.Day, FromDate, ToDate)
        If j = 0 Then
            DateListArray.Add(FromDate.Date)
        Else
            For i = 0 To j - 1
                If DateAdd(DateInterval.Day, i, FromDate).DayOfWeek = DayOfWeek.Saturday Or DateAdd(DateInterval.Day, i, FromDate).DayOfWeek = DayOfWeek.Sunday Then
                    '' Skip Saturdays and Sundays.
                Else
                    DateListArray.Add(DateAdd(DateInterval.Day, i, FromDate.Date))
                End If
            Next
        End If
        Return DateListArray
    End Function

    ' Done : Given a combination of Market Options return the URL from where to download or read the needed data.
    ' TO DO : Pay attention to the ability to read this from an INI file so as to extend this easily.

    Structure Task
        '' Defines the needed information that the engine class tracks to initiate, complete a successful download and deflate the received file.
        '' 0. This_Date = The date component of the associated downloaded file.
        Dim This_Date As Date
        '' 1. ServerURI_WFileName = The complete download path and file name
        Dim ServerURI_WFileName As String
        '' 2. ServerFile_NameOnly = Only the file name of the downloaded file. It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the full path and file name of the local file.
        Dim ServerFile_NameOnly As String
        '' 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
        Dim LocalDeflatedFile_NameOnly As String
        Dim MktBasedDownloadSubPath As String
    End Structure
    '' TaskList = This tracks the success or failure of each individual download.
    Dim TaskList As New List(Of Task)
    Dim cookieJar As CookieContainer

    Public Property LocalBasePathToDownload As String

    '' getURLFrom takes in a datearray  and returns a dictionary of filenames and urls from which to download individual files.
    Public Function createTaskList(ByVal MarketType As List(Of String), ByVal Dates() As Date)
        '' Status : In Production 09-08-2014 13.20
        For Each Market In MarketType
            For Each Individual_Day In Dates
                TaskList.Add(createSingleTask(Market, Individual_Day))
            Next
        Next
        Return TaskList
    End Function


    Private Function createSingleTask(ByVal MyMarketsType As String, MyDate As Date) As Task
        '' The NSE Equity URL is of the format http://www.nseindia.com/content/historical/EQUITIES/<YYYY>/<MMM>/cm<dd><MMM><YYYY>bhav.csv.zip
        '' for eg : http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip is a bhav copy for 31/Jul/2014
        '' MyMarketsType A string consisting of a limited choice of available Markets and Instruments.
        '' MyDate Any date which is not in the future.

        Dim ServerFile_NameOnly As String
        Dim ServerURI_WFileName As String
        Dim currentTask As New Task
        Select Case MyMarketsType
            Case "NSE - Equity"
                '' Status : In Production 09-08-2014 13.20
                '' This function takes in a datearray  and returns a dictionary of filenames and urls from which to download individual files. 
                '' The target URL is of the format http://www.nseindia.com/content/historical/EQUITIES/<YYYY>/<MMM>/cm<dd><MMM><yyyy>bhav.csv.zip
                '' for eg : http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip is a bhav copy for 31/Jul/2014
                ServerFile_NameOnly = "cm" & Format(MyDate, "dd").ToUpper.ToString & Format(MyDate, "MMM").ToUpper.ToString & Format(MyDate, "yyyy").ToUpper.ToString & "bhav.csv.zip"
                ServerURI_WFileName = "http://www.nseindia.com/content/historical/EQUITIES/" & MyDate.Year.ToString & "/" & Format(MyDate, "MMM").ToUpper.ToString & "/" & ServerFile_NameOnly

            Case "BSE - Equity"
                '' BSE India Bhav Copy http://www.bseindia.com/download/BhavCopy/Equity/EQ141015_CSV.ZIP
                '' BSE India Bhav Copy Prototype http://www.bseindia.com/download/BhavCopy/Equity/EQ<DD><MM><YY>_CSV.ZIP
                '' Derivatives http://www.bseindia.com/download/Bhavcopy/Derivative/bhavcopy18-08-14.zip
                '' Equities http://www.bseindia.com/download/BhavCopy/Equity/EQ180814_CSV.ZIP
                '' BSE India Bhav Copy http://www.bseindia.com/download/BhavCopy/Equity/EQ141015_CSV.ZIP

                ServerFile_NameOnly = "EQ" & Format(MyDate, "dd").ToUpper.ToString & Format(MyDate, "MM").ToUpper.ToString & Format(MyDate, "yy").ToUpper.ToString & "_CSV.zip"
                ServerURI_WFileName = "http://www.bseindia.com/download/BhavCopy/Equity/" & ServerFile_NameOnly

            Case Else
                Throw New InvalidCastException
        End Select

        '' 0. onDate = The date component of the associated downloaded file.
        currentTask.This_Date = MyDate.Date
        '' 1. ServerURI_WFileName = The complete download path and file name
        currentTask.ServerURI_WFileName = ServerURI_WFileName
        '' 2. ServerFile_NameOnly = Only the file name of the downloaded file. It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the 
        '' full path and file name of the local file.
        currentTask.ServerFile_NameOnly = ServerFile_NameOnly
        '' 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
        currentTask.LocalDeflatedFile_NameOnly = Format(MyDate, "yyyyMMdd") & ".csv"
        '' 4. MktBasedDownloadSubPath = The individual path to which each Market's file should be downloaded to.
        currentTask.MktBasedDownloadSubPath = MyMarketsType
        Return currentTask
    End Function





    Public Function DownloadTaskList(ByRef TaskList As List(Of Task)) As Boolean
        Dim DownloadLocation As String
        ''---------- This is the Synchronous downloader. Everything we do leads upto this.
        For Each Task In TaskList
            '' To Do : Task.Local_FileName is only the file name and not yet concatenated with fbdDownloadLocation.SelectedPath. 24-01-2016 13.27
            DownloadLocation = LocalBasePathToDownload & "\" & Task.MktBasedDownloadSubPath
            If DownloadAgent(Task) = True Then
                'TODO: This block is entered into when the file has been downloaded and deflated. Now Increment Progress of file download
                ''tsStatusText.Text = "Downloaded : " & i & "of " & UBound(My2dMapOfDateURLRemoteLocalFiles, 1)
            Else
                'TODO: Gracefully Handle the file download failure here.
            End If
        Next
        '' --------End of the Synchronous downloader region.
        Return True

    End Function
    ''ByVal strDwnldUri As String, ByVal strLocalFilePath As String, ByVal DeflatedFileName As String
    Private Function DownloadAgent(ByRef CurrentTask As Task) As Boolean
        'ISSUE : Although the Synchronous downloader works. It will freeze the UI. This is a known devil.
        Try
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            request = WebRequest.Create(CurrentTask.ServerURI_WFileName)
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
            '' DownloadWriter downloads and renames the expected ZIP from response into a localfile named DeflatedFileName
            '' Returns true if successful and false if not.
            If DownloadWriter(response, CurrentTask) = True Then
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
    '' ByRef response As HttpWebResponse, ByRef strLocalFilePathOnly As String, ByRef NewLocalFileName As String
    Private Function DownloadWriter(ByRef response As HttpWebResponse, ByRef CurrentTask As Task) As Boolean
        ' Take the HTTP Web response from Downloader.
        ' Unzip it to the destination folder.
        If response.ContentType = "application/zip" Or response.ContentType = "application/x-zip-compressed" Then
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
                Dim res As String = False
                '' A wrapper function to Ionic.Zip library is used here.
                res = ZipExtracttoFile(memStream, LocalBasePathToDownload & "\" & CurrentTask.MktBasedDownloadSubPath)
                Dim WhatIDownloaded As String = Replace(LocalBasePathToDownload & "\" & CurrentTask.MktBasedDownloadSubPath & "\" & res, ".zip", "")
                Dim WhatToRenameTo As String = CurrentTask.LocalDeflatedFile_NameOnly

                My.Computer.FileSystem.RenameFile(WhatIDownloaded, WhatToRenameTo)
            End Using
            DownloadWriter = True
        Else
            DownloadWriter = False
        End If
    End Function

    Private Function ZipExtracttoFile(strm As MemoryStream, strDestDir As String) As String
        Dim ExtractedFileName As String = vbEmpty
        Try
            Using zip As ZipFile = ZipFile.Read(strm)
                ''ExtractedFileName = zip.EntryFileNames.ToString
                zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently
                For Each e As ZipEntry In zip
                    e.Extract(strDestDir)
                    ExtractedFileName = e.FileName.ToString
                Next
            End Using
        Catch ex As Exception
            Debug.WriteLine("exception: {0}", ex.ToString)
            Return vbFalse
        End Try
        Return ExtractedFileName
    End Function


End Class



'' Headers to give the webclient
''GET /content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip HTTP/1.1
''--------------CLIENT-----------------------
''Accept: text/html, application/xhtml+xml, */*
''Accept-Language: en-IN
''User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko
''Accept-Encoding: gzip, deflate
''--------------CLIENT-----------------------
''--------------TRANSPORT--------------------
''Host: www.nseindia.com
''Connection: Keep-Alive
''--------------TRANSPORT--------------------
''--------------Cookies----------------------
''DNT: 1
''--------------Cookies--------------------