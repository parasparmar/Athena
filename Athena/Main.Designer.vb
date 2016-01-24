<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.fbdDownloadLocation = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsStatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsprogressbar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.gbDownloadPath = New System.Windows.Forms.GroupBox()
        Me.tbDownloadLocation = New System.Windows.Forms.TextBox()
        Me.btnNewProfile = New System.Windows.Forms.Button()
        Me.gbChooseDates = New System.Windows.Forms.GroupBox()
        Me.clbFiles = New System.Windows.Forms.CheckedListBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.gbChooseMarkets = New System.Windows.Forms.GroupBox()
        Me.clbMarkets = New System.Windows.Forms.CheckedListBox()
        Me.lblDownloadData4Markets = New System.Windows.Forms.Label()
        Me.gbDataFormats = New System.Windows.Forms.GroupBox()
        Me.cbSQLCompact = New System.Windows.Forms.CheckBox()
        Me.cbSQLite = New System.Windows.Forms.CheckBox()
        Me.cbMetastock = New System.Windows.Forms.CheckBox()
        Me.cbExcel = New System.Windows.Forms.CheckBox()
        Me.cbTSV = New System.Windows.Forms.CheckBox()
        Me.cbCSV = New System.Windows.Forms.CheckBox()
        Me.lblConvertData2Formats = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.gbDownloadPath.SuspendLayout()
        Me.gbChooseDates.SuspendLayout()
        Me.gbChooseMarkets.SuspendLayout()
        Me.gbDataFormats.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDownload.Location = New System.Drawing.Point(12, 656)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(184, 25)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.Location = New System.Drawing.Point(200, 656)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(184, 25)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Cancel / Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatusText, Me.tsprogressbar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 695)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(536, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStatusText
        '
        Me.tsStatusText.Name = "tsStatusText"
        Me.tsStatusText.Size = New System.Drawing.Size(887, 17)
        Me.tsStatusText.Spring = True
        Me.tsStatusText.Text = "Ready..."
        Me.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsprogressbar1
        '
        Me.tsprogressbar1.Name = "tsprogressbar1"
        Me.tsprogressbar1.Size = New System.Drawing.Size(92, 16)
        '
        'gbDownloadPath
        '
        Me.gbDownloadPath.Controls.Add(Me.tbDownloadLocation)
        Me.gbDownloadPath.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDownloadPath.Location = New System.Drawing.Point(12, 14)
        Me.gbDownloadPath.Name = "gbDownloadPath"
        Me.gbDownloadPath.Size = New System.Drawing.Size(516, 96)
        Me.gbDownloadPath.TabIndex = 24
        Me.gbDownloadPath.TabStop = False
        Me.gbDownloadPath.Text = "Step 1 : Download Path..."
        '
        'tbDownloadLocation
        '
        Me.tbDownloadLocation.Location = New System.Drawing.Point(9, 24)
        Me.tbDownloadLocation.Name = "tbDownloadLocation"
        Me.tbDownloadLocation.Size = New System.Drawing.Size(501, 25)
        Me.tbDownloadLocation.TabIndex = 0
        '
        'btnNewProfile
        '
        Me.btnNewProfile.Location = New System.Drawing.Point(389, 656)
        Me.btnNewProfile.Name = "btnNewProfile"
        Me.btnNewProfile.Size = New System.Drawing.Size(139, 25)
        Me.btnNewProfile.TabIndex = 2
        Me.btnNewProfile.Text = "Save Settings"
        Me.btnNewProfile.UseVisualStyleBackColor = True
        '
        'gbChooseDates
        '
        Me.gbChooseDates.BackColor = System.Drawing.SystemColors.Control
        Me.gbChooseDates.Controls.Add(Me.clbFiles)
        Me.gbChooseDates.Controls.Add(Me.dtpFromDate)
        Me.gbChooseDates.Controls.Add(Me.lblToDate)
        Me.gbChooseDates.Controls.Add(Me.lblFromDate)
        Me.gbChooseDates.Controls.Add(Me.dtpToDate)
        Me.gbChooseDates.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbChooseDates.Location = New System.Drawing.Point(12, 116)
        Me.gbChooseDates.Name = "gbChooseDates"
        Me.gbChooseDates.Size = New System.Drawing.Size(516, 227)
        Me.gbChooseDates.TabIndex = 25
        Me.gbChooseDates.TabStop = False
        Me.gbChooseDates.Text = "Step 2: Choose Dates"
        '
        'clbFiles
        '
        Me.clbFiles.CheckOnClick = True
        Me.clbFiles.FormattingEnabled = True
        Me.clbFiles.Location = New System.Drawing.Point(9, 53)
        Me.clbFiles.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.clbFiles.MultiColumn = True
        Me.clbFiles.Name = "clbFiles"
        Me.clbFiles.Size = New System.Drawing.Size(501, 164)
        Me.clbFiles.TabIndex = 3
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(120, 22)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(145, 25)
        Me.dtpFromDate.TabIndex = 0
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(269, 26)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(91, 19)
        Me.lblToDate.TabIndex = 22
        Me.lblToDate.Text = "To This Date :"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(6, 26)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(113, 19)
        Me.lblFromDate.TabIndex = 21
        Me.lblFromDate.Text = "From This Date : "
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(365, 22)
        Me.dtpToDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(145, 25)
        Me.dtpToDate.TabIndex = 1
        '
        'gbChooseMarkets
        '
        Me.gbChooseMarkets.Controls.Add(Me.clbMarkets)
        Me.gbChooseMarkets.Controls.Add(Me.lblDownloadData4Markets)
        Me.gbChooseMarkets.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbChooseMarkets.Location = New System.Drawing.Point(12, 349)
        Me.gbChooseMarkets.Name = "gbChooseMarkets"
        Me.gbChooseMarkets.Size = New System.Drawing.Size(516, 194)
        Me.gbChooseMarkets.TabIndex = 33
        Me.gbChooseMarkets.TabStop = False
        Me.gbChooseMarkets.Text = "Step 3: Choose Markets to download"
        '
        'clbMarkets
        '
        Me.clbMarkets.CheckOnClick = True
        Me.clbMarkets.FormattingEnabled = True
        Me.clbMarkets.Items.AddRange(New Object() {"NSE - Equity", "BSE - Equity"})
        Me.clbMarkets.Location = New System.Drawing.Point(10, 43)
        Me.clbMarkets.MultiColumn = True
        Me.clbMarkets.Name = "clbMarkets"
        Me.clbMarkets.Size = New System.Drawing.Size(500, 144)
        Me.clbMarkets.TabIndex = 0
        '
        'lblDownloadData4Markets
        '
        Me.lblDownloadData4Markets.AutoSize = True
        Me.lblDownloadData4Markets.Location = New System.Drawing.Point(6, 21)
        Me.lblDownloadData4Markets.Name = "lblDownloadData4Markets"
        Me.lblDownloadData4Markets.Size = New System.Drawing.Size(217, 19)
        Me.lblDownloadData4Markets.TabIndex = 23
        Me.lblDownloadData4Markets.Text = "Download data for these Markets:"
        '
        'gbDataFormats
        '
        Me.gbDataFormats.Controls.Add(Me.cbSQLCompact)
        Me.gbDataFormats.Controls.Add(Me.cbSQLite)
        Me.gbDataFormats.Controls.Add(Me.cbMetastock)
        Me.gbDataFormats.Controls.Add(Me.cbExcel)
        Me.gbDataFormats.Controls.Add(Me.cbTSV)
        Me.gbDataFormats.Controls.Add(Me.cbCSV)
        Me.gbDataFormats.Controls.Add(Me.lblConvertData2Formats)
        Me.gbDataFormats.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDataFormats.Location = New System.Drawing.Point(12, 549)
        Me.gbDataFormats.Name = "gbDataFormats"
        Me.gbDataFormats.Size = New System.Drawing.Size(516, 101)
        Me.gbDataFormats.TabIndex = 27
        Me.gbDataFormats.TabStop = False
        Me.gbDataFormats.Text = "Step 4: Choose data formats to convert to..."
        '
        'cbSQLCompact
        '
        Me.cbSQLCompact.AutoSize = True
        Me.cbSQLCompact.Location = New System.Drawing.Point(348, 68)
        Me.cbSQLCompact.Name = "cbSQLCompact"
        Me.cbSQLCompact.Size = New System.Drawing.Size(154, 23)
        Me.cbSQLCompact.TabIndex = 5
        Me.cbSQLCompact.Text = "SQL Server Compact"
        Me.cbSQLCompact.UseVisualStyleBackColor = True
        '
        'cbSQLite
        '
        Me.cbSQLite.AutoSize = True
        Me.cbSQLite.Location = New System.Drawing.Point(348, 41)
        Me.cbSQLite.Name = "cbSQLite"
        Me.cbSQLite.Size = New System.Drawing.Size(75, 23)
        Me.cbSQLite.TabIndex = 2
        Me.cbSQLite.Text = "SQLLite"
        Me.cbSQLite.UseVisualStyleBackColor = True
        '
        'cbMetastock
        '
        Me.cbMetastock.AutoSize = True
        Me.cbMetastock.Location = New System.Drawing.Point(9, 41)
        Me.cbMetastock.Name = "cbMetastock"
        Me.cbMetastock.Size = New System.Drawing.Size(92, 23)
        Me.cbMetastock.TabIndex = 0
        Me.cbMetastock.Text = "Metastock"
        Me.cbMetastock.UseVisualStyleBackColor = True
        '
        'cbExcel
        '
        Me.cbExcel.AutoSize = True
        Me.cbExcel.Location = New System.Drawing.Point(192, 41)
        Me.cbExcel.Name = "cbExcel"
        Me.cbExcel.Size = New System.Drawing.Size(81, 23)
        Me.cbExcel.TabIndex = 1
        Me.cbExcel.Text = "MS Excel"
        Me.cbExcel.UseVisualStyleBackColor = True
        '
        'cbTSV
        '
        Me.cbTSV.AutoSize = True
        Me.cbTSV.Location = New System.Drawing.Point(192, 68)
        Me.cbTSV.Name = "cbTSV"
        Me.cbTSV.Size = New System.Drawing.Size(156, 23)
        Me.cbTSV.TabIndex = 4
        Me.cbTSV.Text = "Tab Seperated Values"
        Me.cbTSV.UseVisualStyleBackColor = True
        '
        'cbCSV
        '
        Me.cbCSV.AutoSize = True
        Me.cbCSV.Location = New System.Drawing.Point(9, 68)
        Me.cbCSV.Name = "cbCSV"
        Me.cbCSV.Size = New System.Drawing.Size(184, 23)
        Me.cbCSV.TabIndex = 3
        Me.cbCSV.Text = "Comma Seperated Values"
        Me.cbCSV.UseVisualStyleBackColor = True
        '
        'lblConvertData2Formats
        '
        Me.lblConvertData2Formats.AutoSize = True
        Me.lblConvertData2Formats.Location = New System.Drawing.Point(6, 21)
        Me.lblConvertData2Formats.Name = "lblConvertData2Formats"
        Me.lblConvertData2Formats.Size = New System.Drawing.Size(354, 19)
        Me.lblConvertData2Formats.TabIndex = 23
        Me.lblConvertData2Formats.Text = "Downloaded data should be converted to these formats:"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 717)
        Me.Controls.Add(Me.gbDataFormats)
        Me.Controls.Add(Me.gbChooseMarkets)
        Me.Controls.Add(Me.btnNewProfile)
        Me.Controls.Add(Me.gbChooseDates)
        Me.Controls.Add(Me.gbDownloadPath)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnReset)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormMain"
        Me.Text = "Athena"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbDownloadPath.ResumeLayout(False)
        Me.gbDownloadPath.PerformLayout()
        Me.gbChooseDates.ResumeLayout(False)
        Me.gbChooseDates.PerformLayout()
        Me.gbChooseMarkets.ResumeLayout(False)
        Me.gbChooseMarkets.PerformLayout()
        Me.gbDataFormats.ResumeLayout(False)
        Me.gbDataFormats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdDownloadLocation As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsStatusText As ToolStripStatusLabel
    Friend WithEvents tsprogressbar1 As ToolStripProgressBar
    Friend WithEvents btnNewProfile As Button
    Friend WithEvents gbDownloadPath As GroupBox
    Friend WithEvents tbDownloadLocation As TextBox
    Friend WithEvents gbChooseDates As GroupBox
    Friend WithEvents clbFiles As CheckedListBox
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents gbChooseMarkets As GroupBox
    Friend WithEvents clbMarkets As CheckedListBox
    Friend WithEvents lblDownloadData4Markets As Label
    Friend WithEvents gbDataFormats As GroupBox
    Friend WithEvents cbSQLCompact As CheckBox
    Friend WithEvents cbSQLite As CheckBox
    Friend WithEvents cbMetastock As CheckBox
    Friend WithEvents cbExcel As CheckBox
    Friend WithEvents cbTSV As CheckBox
    Friend WithEvents cbCSV As CheckBox
    Friend WithEvents lblConvertData2Formats As Label
End Class
