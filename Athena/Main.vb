Option Explicit On
Imports System.Collections.Generic

Public Class FormMain

    Dim FolderBrowserDialog As String
    Dim MyFolder As String = vbEmpty
    Dim MyEngine As New Engine

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GUIUpdater(GUIStage.Initialization)
    End Sub

    Enum GUIStage
        PreviousSettings
        Initialization
        MarketChosen
        DatesToDownload
        DownloadsActivated
        ResetActivated
        SaveSettings
    End Enum
    Private Sub GUIUpdater(ByVal Stage As GUIStage)
        'TODO: Initialization, DestinationPath, DateRangeChosen, DatesToDownload, MarketChosen, DestinationFormatsChosen, DownloadsActivated, ResetActivated, SaveSettings. 


        Select Case Stage
            Case GUIStage.Initialization
                If My.Computer.Network.IsAvailable Then
                    tbDownloadLocation.Focus()
                    If Today.Hour >= 15 Then
                        dtpToDate.Value = Today
                    Else
                        dtpToDate.Value = Today.AddDays(-1)
                    End If
                    dtpFromDate.Value = dtpToDate.Value.AddDays(-1)
                    btnDownload.Enabled = False
                    btnReset.Enabled = True
                    tsprogressbar1.Minimum = 1
                    tsprogressbar1.Maximum = 100
                    tsprogressbar1.Value = 1
                    tsStatusText.Text = "Please select the Download(s) folder."
                Else
                    For Each c As Control In Me.Controls
                        c.Enabled = False
                        c.Visible = False
                    Next
                    StatusStrip1.Visible = True
                    StatusStrip1.Enabled = True
                    tsStatusText.Visible = True
                    tsStatusText.Enabled = True
                    tsStatusText.Text = "The Computer is offline. Please connect to a network to continue."

                End If

            Case GUIStage.MarketChosen
                btnDownload.Enabled = False
                btnReset.Enabled = True
                tsStatusText.Text = "Please choose the date range to download."

            Case GUIStage.DatesToDownload
                btnDownload.Enabled = True
                btnDownload.Text = "Downloads Enabled"
                btnReset.Enabled = True
                tsStatusText.Text = "Ready..."

            Case GUIStage.DownloadsActivated
                btnReset.Enabled = True

            Case GUIStage.ResetActivated
                tsStatusText.Text = "Reset Activated."
                tsprogressbar1.Value = 1
                tbDownloadLocation.Clear()

            Case Else
        End Select

    End Sub



    ' Stage 2 : Choose a valid dates for the download.
    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged, dtpToDate.ValueChanged

        If (dtpFromDate.Value < Today And dtpToDate.Value <= Today) Then
            If (Today.Hour) >= 15 Then
                dtpToDate.Value = Today
            Else
                dtpToDate.Value = Today.AddDays(-1)
            End If
            tsStatusText.Text = "Please choose a From date before today" & dtpToDate.Value
            GUIUpdater(GUIStage.DatesToDownload)
        End If
    End Sub



    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        '' Objective : btnDownload_Click event handling needs to take as ibpute GUI decisions and 
        '' download the same to the destination path.
        '' Input : Download Destination, From and To Dates
        '' Parameters : 
        '' Output : ArrayList of Dates - strongly typed.
        '' Status : Production
        '' Production : 19-10-2015 17.55

        'Done 1: Collect the selected dates from clbFiles into an MyDatesArray
        ''Dim MyDatesArray(clbFiles.CheckedItems.Count - 1) As Date
        ''For i = 0 To clbFiles.CheckedItems.Count - 1
        ''    MyDatesArray(i) = clbFiles.CheckedItems(i)
        ''Next

        'Done 2 :  Collect the selected markets from clbMarkets into a chosenMarketsArray
        ' initiated 21-01-2015 17.12 and resolved 22-01-2016 10.46
        Dim AllMyDates As New List(Of Date)
        AllMyDates = MyEngine.DateListGenerator(dtpFromDate.Value, dtpToDate.Value)
        '' DateList Generator gets an ArrayList of Weekday dates between the given from and to dates.

        Dim chosenMarketsArray As New List(Of String)
        For Each i In clbMarkets.CheckedItems
            chosenMarketsArray.Add(i.ToString)
        Next


        'Done 3: Check for Internet Connectivity
        If My.Computer.Network.IsAvailable Then
            '' Done 4. Download these files using an instance of the WebClient.DownloadFile Method one after the other

            MyEngine.DownloadTaskList(MyEngine.createTaskList(chosenMarketsArray, AllMyDates))

            '' Done 5. On Download completion open MyFolder and show it to the user
            Process.Start(“explorer”, tbDownloadLocation.Text.ToString)
        Else
            tsStatusText.Text = "Network is not available"
            End
        End If
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        '' Reset From and To dates.
        dtpFromDate.Value = DateAdd(DateInterval.Day, -1, Today)
        dtpToDate.Value = Today
        GUIUpdater(GUIStage.ResetActivated)
    End Sub




    ' Stage 1 : Choose a valid Download Path.
    Private Sub tbDownloadLocation_Click(sender As Object, e As EventArgs) Handles tbDownloadLocation.Click
        ' 0. Request the user to select a folder (MyFolder) where the downloaded files will be kept



        fbdDownloadLocation.ShowNewFolderButton = True
        If (fbdDownloadLocation.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            MyFolder = fbdDownloadLocation.SelectedPath
            MyEngine.LocalBasePathToDownload = MyFolder
            Dim folderExists As Boolean = My.Computer.FileSystem.DirectoryExists(MyFolder)
            If folderExists Then
                tbDownloadLocation.Text = MyFolder.ToString
                btnDownload.Enabled = True
            Else
                tbDownloadLocation.Text = "Please select the folder to download at."
            End If
        End If
        GUIUpdater(GUIStage.MarketChosen)
    End Sub


End Class









