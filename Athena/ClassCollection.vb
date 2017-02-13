Imports System.Net
Imports System.IO
Imports Ionic.Zip
Public Class Engine
    ''' <summary>
    ''' Given a FromDate less than or equal to the ToDate, DateListGenerator is a method of returning a range of downloadable dates. 
    ''' The intent is to populate only those valid dates for selection.
    ''' </summary>
    ''' <remarks>
    ''' It's meant to reduce the work of searching for and 
    ''' downloading invalid dates. ie: weekends, public holidays, non-tradeable dates in general.
    ''' </remarks>
    ''' <param name="FromDate">Date from </param>
    ''' <param name="ToDate"></param>
    ''' <returns>ArrayList of Dates</returns>
    ''' <status>In Production 24-01-2016 21.48</status>
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



    ''' <summary>
    ''' Task is a data structure that tracks information, Defines the needed information that the engine class tracks to initiate, complete a successful download and deflate the received file. 
    ''' </summary>
    Structure Task
        '' 0. This_Date = The date component of the associated downloaded file.
        Dim This_Date As Date
        '' 1. ServerURI_WFileName = The complete download path and file name
        Dim ServerURI_WFileName As String
        '' 2. ServerFile_NameOnly = Only the file name of the downloaded file. It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the full path and file name of the local file.
        Dim ServerFile_NameOnly As String
        '' 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
        Dim LocalDeflatedFile_NameOnly As String
        '' 4. MktBasedDownloadSubPath = Needed to segregate the Deflated(unzipped) file into a folder represented by it's Market.
        Dim MktBasedDownloadSubPath As String

    End Structure
    '' TaskList = This tracks the success or failure of each individual download.
    Private TaskList As New List(Of Task)
    Private cookieJar As CookieContainer
    Public Property LocalBasePathToDownload As String

    '' getURLFrom takes in a datearray  and returns a dictionary of filenames and urls from which to download individual files.
    Public Function createTaskList(ByVal MarketType As List(Of String), ByVal DateList As List(Of Date))
        '' Status : In Production 09-08-2014 13.20
        For Each Market In MarketType
            For Each Individual_Day In DateList
                TaskList.Add(createTask(Market, Individual_Day))
            Next
        Next
        Return TaskList
    End Function


    Private Function createTask(ByVal MyMarketsType As String, MyDate As Date) As Task
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
            Case "AMFII - Mutual Funds"

                '' Main URL : http://www.amfiindia.com/nav-history-download
                ''GET /DownloadNAVHistoryReport_Po.aspx?mf=9&frmdt=01-Jan-1960&todt=25-Jan-2016 HTTP/1.1
                ''Host:           portal.amfiindia.com
                ''                User-Agent: Mozilla/ 5.0(Windows NT 10.0; WOW64; rv: 43.0) Gecko/20100101 Firefox/43.0
                ''Accept:         Text/ html, Application / xhtml + Xml, Application / Xml;q=0.9,*/*;q=0.8
                ''Accept-Language: en-US, en;q=0.5
                ''Accept-Encoding: gzip, deflate
                ''DNT: 1
                ''Referer:        http : //www.amfiindia.com/nav-history-download
                ''Cookie:         __utma = 57940026.105457447.1448689042.1448981552.1453695335.6; __utmz=57940026.1448689042.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); __utmb=57940026.4.10.1453695335; __utmt=1; __utmc=57940026
                ''Connection:     keep-alive
                ''--------------- RESPONSE HEADERS---------------
                '' URL : http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?mf=9&frmdt=01-Jan-1960&todt=25-Jan-2016
                ''                HTTP/ 1.1 200 OK
                ''Cache-Control: no-Cache
                ''Pragma:         no-Cache
                ''Content-Type: Text/ plain
                ''Expires: -1
                ''Vary:           Accept-Encoding
                ''Server:         Microsoft-IIS / 8.5
                ''Set-Cookie: ASP.NET_SessionId = qgdwxu45dgbw4pnhrohc0c45; path=/; HttpOnly
                ''Content-Disposition: inline; filename=NAVHistoryReport250116.txt
                ''X-AspNet - Version:  2.0.50727
                ''X-Powered - By: ASP.NET
                ''                Date : Mon, 25 Jan 2016 04: 17:41 GMT
                ''Content-Length:  93076579
                ''--------------- RESPONSE BODY---------------
                ''HTTP/ 1.1 200 OK
                ''Cache-Control: no-Cache
                ''Pragma:         no-Cache
                ''Content-Type: Text/ plain
                ''Expires: -1
                ''Vary:           Accept-Encoding
                ''Server:         Microsoft-IIS / 8.5
                ''Set-Cookie: ASP.NET_SessionId = qgdwxu45dgbw4pnhrohc0c45; path=/; HttpOnly
                ''Content-Disposition: inline; filename=NAVHistoryReport250116.txt
                ''X-AspNet - Version:  2.0.50727
                ''X-Powered - By: ASP.NET
                ''Date : Mon, 25 Jan 2016 04: 17:41 GMT
                ''Content-Length:  93076579

                ''<select Class="select" id="NavDownMFName" name="NavDownMFName" onchange="return LoadNavHistoryDownload(&#39;0&#39;);"><option value="">--Select Mutual Fund--</option>
                ''<option value = "39" > ABN  AMRO Mutual Fund</Option>
                ''<option value = "50" > AEGON Mutual Fund</Option>
                ''<option value = "1" > Alliance Capital Mutual Fund</Option>
                ''<option value = "53" > Axis Mutual Fund</Option>
                ''<option value = "4" > Baroda Pioneer Mutual Fund</Option>
                ''<option value = "36" > Benchmark Mutual Fund</Option>
                ''<option value = "3" > Birla Sun Life Mutual Fund</Option>
                ''<option value = "59" > BNP Paribas Mutual Fund</Option>
                ''<option value = "46" > BOI AXA Mutual Fund</Option>
                ''<option value = "32" > Canara Robeco Mutual Fund</Option>
                ''<option value = "60" > Daiwa Mutual Fund</Option>
                ''<option value = "31" > DBS Chola Mutual Fund</Option>
                ''<option value = "38" > Deutsche Mutual Fund</Option>
                ''<option value = "58" > DHFL Pramerica Mutual Fund</Option>
                ''<option value = "6" > DSP BlackRock Mutual Fund</Option>
                ''<option value = "47" > Edelweiss Mutual Fund</Option>
                ''<option value = "13" > Escorts Mutual Fund</Option>
                ''<option value = "40" > Fidelity Mutual Fund</Option>
                ''<option value = "51" > Fortis Mutual Fund</Option>
                ''<option value = "27" > Franklin Templeton Mutual Fund</Option>
                ''<option value = "8" > GIC Mutual Fund</Option>
                ''<option value = "49" > Goldman Sachs Mutual Fund</Option>
                ''<option value = "9" > HDFC Mutual Fund</Option>
                ''<option value = "37" > HSBC Mutual Fund</Option>
                ''<option value = "20" > ICICI Prudential Mutual Fund</Option>
                ''<option value = "57" > IDBI Mutual Fund</Option>
                ''<option value = "48" > IDFC Mutual Fund</Option>
                ''<option value = "68" > IIFCL Mutual Fund (IDF)</Option>
                ''<option value = "62" > IIFL Mutual Fund</Option>
                ''<option value = "11" > IL&amp;F S Mutual Fund</Option>
                ''<option value = "65" > IL&amp;FS Mutual Fund (IDF)</Option>
                ''<option value = "63" > Indiabulls Mutual Fund</Option>
                ''<option value = "14" > ING Mutual Fund</Option>
                ''<option value = "16" > JM Financial Mutual Fund</Option>
                ''<option value = "43" > JPMorgan Mutual Fund</Option>
                ''<option value = "17" > Kotak Mahindra Mutual Fund</Option>
                ''<option value = "56" > L&amp;T Mutual Fund</Option>
                ''<option value = "18" > LIC NOMURA Mutual Fund</Option>
                ''<option value = "45" > Mirae Asset Mutual Fund</Option>
                ''<option value = "19" > Morgan Stanley Mutual Fund</Option>
                ''<option value = "55" > Motilal Oswal Mutual Fund</Option>
                ''<option value = "54" > Peerless Mutual Fund</Option>
                ''<option value = "44" > PineBridge Mutual Fund</Option>
                ''<option value = "34" > PNB Mutual Fund</Option>
                ''<option value = "64" > PPFAS Mutual Fund</Option>
                ''<option value = "10" > PRINCIPAL Mutual Fund</Option>
                ''<option value = "41" > Quantum Mutual Fund</Option>
                ''<option value = "21" > Reliance Mutual Fund</Option>
                ''<option value = "42" > Religare Invesco Mutual Fund</Option>
                ''<option value = "35" > Sahara Mutual Fund</Option>
                ''<option value = "22" > SBI Mutual Fund</Option>
                ''<option value = "52" > Shinsei Mutual Fund</Option>
                ''<option value = "67" > Shriram Mutual Fund</Option>
                ''<option value = "66" > SREI Mutual Fund (IDF)</Option>
                ''<option value = "2" > Standard Chartered Mutual Fund</Option>
                ''<option value = "24" > SUN F&amp;C Mutual Fund</Option>
                ''<option value = "33" > Sundaram Mutual Fund</Option>
                ''<option value = "25" > Tata Mutual Fund</Option>
                ''<option value = "26" > Taurus Mutual Fund</Option>
                ''<option value = "61" > Union KBC Mutual Fund</Option>
                ''<option value = "28" > UTI Mutual Fund</Option>
                ''<option value = "29" > Zurich India Mutual Fund</Option>
                ''</select>                 


                'ServerFile_NameOnly = "NAVHistoryReport" & Format(MyDate, "ddmmyy") & ".txt"
                'ServerURI_WFileName = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?mf=9&frmdt=" & Format(MyDate, "dd-MMM-YYYY") & "&todt=" & Format(MyDate, "dd-MMM-YYYY")






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
        Dim ExtractedFileName As String
        Try
            Using zip As ZipFile = ZipFile.Read(strm)
                ExtractedFileName = zip.EntryFileNames.ToString
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