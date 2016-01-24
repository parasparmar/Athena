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
            MyEngine.LocalBasePathToDownload = MyFolder
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
    Private Sub dtpToDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpToDate.ValueChanged
        clbFilesUpdater() '' Sub runs and populates the checked list box with a list of dates to download.
    End Sub

    Private Sub clbFilesUpdater()
        clbFiles.Items.Clear()
        Dim AllMyDates As New List(Of Date)
        AllMyDates = MyEngine.DateListGenerator(dtpFromDate.Value, dtpToDate.Value)
        '' DateList Generator gets an ArrayList of Weekday dates between the given from and to dates.
        For Each Mydate In AllMyDates
            clbFiles.Items.Add(Mydate, True) '' Added items will be Selected by default.
        Next
        GUIUpdater(GUIStage.DatesToDownload)
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        '' Objective : btnDownload_Click event handling needs to take as ibpute GUI decisions and 
        '' download the same to the destination path.
        '' Input : Download Destination, From and To Dates
        '' Parameters : 
        '' Output : ArrayList of Dates - strongly typed.
        '' Status : Production
        '' Production : 19-10-2015 17.55


        Dim MyDatesArray(clbFiles.CheckedItems.Count - 1) As Date
        'Done 1: Collect the selected dates from clbFiles into an MyDatesArray

        For i = 0 To clbFiles.CheckedItems.Count - 1
            MyDatesArray(i) = clbFiles.CheckedItems(i)
        Next

        'To Do :  Collect the selected markets from clbMarkets into an chosenMarketsArray
        Dim chosenMarketsArray As New List(Of String)
        '' Need to work on this. Insight : 4 is BSE Equity but is outside the bounds of clbMarkets.SelectedIndices which is limited to 2 
        '' ie: 0 and 1
        '' 21-01-2015 17.12 and resolved
        For Each i In clbMarkets.CheckedItems
            chosenMarketsArray.Add(i.ToString) '' resolved 22-01-2016 10.46
        Next


        'Done 3: Check for Internet Connectivity

        If My.Computer.Network.IsAvailable Then
            ' Done 4. Download these files using an instance of the WebClient.DownloadFile Method one after the other
            MyEngine.DownloadTaskList(MyEngine.createTaskList(chosenMarketsArray, MyDatesArray))
            ' Done 4. On Download completion open MyFolder and show it to the user
            Process.Start(“explorer”, tbDownloadLocation.Text.ToString)
        Else
            Debug.WriteLine("Network is not available")
            End
        End If
    End Sub





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









