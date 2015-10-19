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
        Me.clbFiles = New System.Windows.Forms.CheckedListBox()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsStatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsprogressbar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDownloadPath = New System.Windows.Forms.GroupBox()
        Me.tbDownloadLocation = New System.Windows.Forms.TextBox()
        Me.gbChooseDates = New System.Windows.Forms.GroupBox()
        Me.lblConvertData2Formats = New System.Windows.Forms.Label()
        Me.gbDataFormats = New System.Windows.Forms.GroupBox()
        Me.cbSQLCompact = New System.Windows.Forms.CheckBox()
        Me.cbSQLite = New System.Windows.Forms.CheckBox()
        Me.cbMetastock = New System.Windows.Forms.CheckBox()
        Me.cbExcel = New System.Windows.Forms.CheckBox()
        Me.cbTSV = New System.Windows.Forms.CheckBox()
        Me.cbCSV = New System.Windows.Forms.CheckBox()
        Me.gbChooseMarkets = New System.Windows.Forms.GroupBox()
        Me.clbMarkets = New System.Windows.Forms.CheckedListBox()
        Me.lblDownloadData4Markets = New System.Windows.Forms.Label()
        Me.cbProfiles = New System.Windows.Forms.ComboBox()
        Me.gbProfiles = New System.Windows.Forms.GroupBox()
        Me.rbRegularly = New System.Windows.Forms.RadioButton()
        Me.rbOneOff = New System.Windows.Forms.RadioButton()
        Me.btnUpdtProfile = New System.Windows.Forms.Button()
        Me.btnNewProfile = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.gbDownloadPath.SuspendLayout()
        Me.gbChooseDates.SuspendLayout()
        Me.gbDataFormats.SuspendLayout()
        Me.gbChooseMarkets.SuspendLayout()
        Me.gbProfiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'clbFiles
        '
        Me.clbFiles.CheckOnClick = True
        Me.clbFiles.FormattingEnabled = True
        Me.clbFiles.Location = New System.Drawing.Point(9, 53)
        Me.clbFiles.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.clbFiles.MultiColumn = True
        Me.clbFiles.Name = "clbFiles"
        Me.clbFiles.Size = New System.Drawing.Size(501, 144)
        Me.clbFiles.TabIndex = 9
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDownload.Location = New System.Drawing.Point(12, 693)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(184, 25)
        Me.btnDownload.TabIndex = 18
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.Location = New System.Drawing.Point(200, 693)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(184, 25)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Cancel / Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(365, 22)
        Me.dtpToDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(145, 25)
        Me.dtpToDate.TabIndex = 15
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(120, 22)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(145, 25)
        Me.dtpFromDate.TabIndex = 14
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(18, 26)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(113, 19)
        Me.lblFromDate.TabIndex = 21
        Me.lblFromDate.Text = "From This Date : "
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(273, 26)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(91, 19)
        Me.lblToDate.TabIndex = 22
        Me.lblToDate.Text = "To This Date :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatusText, Me.tsprogressbar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 730)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStatusText
        '
        Me.tsStatusText.Name = "tsStatusText"
        Me.tsStatusText.Size = New System.Drawing.Size(431, 17)
        Me.tsStatusText.Spring = True
        Me.tsStatusText.Text = "Ready..."
        Me.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsprogressbar1
        '
        Me.tsprogressbar1.Name = "tsprogressbar1"
        Me.tsprogressbar1.Size = New System.Drawing.Size(92, 16)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 22
        '
        'gbDownloadPath
        '
        Me.gbDownloadPath.Controls.Add(Me.tbDownloadLocation)
        Me.gbDownloadPath.Controls.Add(Me.Label3)
        Me.gbDownloadPath.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDownloadPath.Location = New System.Drawing.Point(12, 12)
        Me.gbDownloadPath.Name = "gbDownloadPath"
        Me.gbDownloadPath.Size = New System.Drawing.Size(516, 65)
        Me.gbDownloadPath.TabIndex = 23
        Me.gbDownloadPath.TabStop = False
        Me.gbDownloadPath.Text = "Step 1 : Download Path..."
        '
        'tbDownloadLocation
        '
        Me.tbDownloadLocation.Location = New System.Drawing.Point(9, 24)
        Me.tbDownloadLocation.Name = "tbDownloadLocation"
        Me.tbDownloadLocation.Size = New System.Drawing.Size(501, 25)
        Me.tbDownloadLocation.TabIndex = 24
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
        Me.gbChooseDates.Location = New System.Drawing.Point(12, 83)
        Me.gbChooseDates.Name = "gbChooseDates"
        Me.gbChooseDates.Size = New System.Drawing.Size(516, 210)
        Me.gbChooseDates.TabIndex = 24
        Me.gbChooseDates.TabStop = False
        Me.gbChooseDates.Text = "Step 2: Choose Dates"
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
        Me.gbDataFormats.Location = New System.Drawing.Point(12, 499)
        Me.gbDataFormats.Name = "gbDataFormats"
        Me.gbDataFormats.Size = New System.Drawing.Size(516, 101)
        Me.gbDataFormats.TabIndex = 24
        Me.gbDataFormats.TabStop = False
        Me.gbDataFormats.Text = "Step 4: Choose data formats to convert to..."
        '
        'cbSQLCompact
        '
        Me.cbSQLCompact.AutoSize = True
        Me.cbSQLCompact.Location = New System.Drawing.Point(348, 68)
        Me.cbSQLCompact.Name = "cbSQLCompact"
        Me.cbSQLCompact.Size = New System.Drawing.Size(154, 23)
        Me.cbSQLCompact.TabIndex = 30
        Me.cbSQLCompact.Text = "SQL Server Compact"
        Me.cbSQLCompact.UseVisualStyleBackColor = True
        '
        'cbSQLite
        '
        Me.cbSQLite.AutoSize = True
        Me.cbSQLite.Location = New System.Drawing.Point(348, 41)
        Me.cbSQLite.Name = "cbSQLite"
        Me.cbSQLite.Size = New System.Drawing.Size(75, 23)
        Me.cbSQLite.TabIndex = 29
        Me.cbSQLite.Text = "SQLLite"
        Me.cbSQLite.UseVisualStyleBackColor = True
        '
        'cbMetastock
        '
        Me.cbMetastock.AutoSize = True
        Me.cbMetastock.Location = New System.Drawing.Point(9, 41)
        Me.cbMetastock.Name = "cbMetastock"
        Me.cbMetastock.Size = New System.Drawing.Size(92, 23)
        Me.cbMetastock.TabIndex = 28
        Me.cbMetastock.Text = "Metastock"
        Me.cbMetastock.UseVisualStyleBackColor = True
        '
        'cbExcel
        '
        Me.cbExcel.AutoSize = True
        Me.cbExcel.Location = New System.Drawing.Point(192, 41)
        Me.cbExcel.Name = "cbExcel"
        Me.cbExcel.Size = New System.Drawing.Size(81, 23)
        Me.cbExcel.TabIndex = 27
        Me.cbExcel.Text = "MS Excel"
        Me.cbExcel.UseVisualStyleBackColor = True
        '
        'cbTSV
        '
        Me.cbTSV.AutoSize = True
        Me.cbTSV.Location = New System.Drawing.Point(192, 68)
        Me.cbTSV.Name = "cbTSV"
        Me.cbTSV.Size = New System.Drawing.Size(156, 23)
        Me.cbTSV.TabIndex = 26
        Me.cbTSV.Text = "Tab Seperated Values"
        Me.cbTSV.UseVisualStyleBackColor = True
        '
        'cbCSV
        '
        Me.cbCSV.AutoSize = True
        Me.cbCSV.Location = New System.Drawing.Point(9, 68)
        Me.cbCSV.Name = "cbCSV"
        Me.cbCSV.Size = New System.Drawing.Size(184, 23)
        Me.cbCSV.TabIndex = 25
        Me.cbCSV.Text = "Comma Seperated Values"
        Me.cbCSV.UseVisualStyleBackColor = True
        '
        'gbChooseMarkets
        '
        Me.gbChooseMarkets.Controls.Add(Me.clbMarkets)
        Me.gbChooseMarkets.Controls.Add(Me.lblDownloadData4Markets)
        Me.gbChooseMarkets.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbChooseMarkets.Location = New System.Drawing.Point(12, 299)
        Me.gbChooseMarkets.Name = "gbChooseMarkets"
        Me.gbChooseMarkets.Size = New System.Drawing.Size(516, 194)
        Me.gbChooseMarkets.TabIndex = 31
        Me.gbChooseMarkets.TabStop = False
        Me.gbChooseMarkets.Text = "Step 3: Choose Markets to download"
        '
        'clbMarkets
        '
        Me.clbMarkets.CheckOnClick = True
        Me.clbMarkets.FormattingEnabled = True
        Me.clbMarkets.Items.AddRange(New Object() {"NSE - Equity", "NSE - F&O", "NSE - Indices", "NSE - ETFs", "BSE - Equity", "BSE - F&O", "BSE - Indices", "BSE - ETFs"})
        Me.clbMarkets.Location = New System.Drawing.Point(9, 42)
        Me.clbMarkets.MultiColumn = True
        Me.clbMarkets.Name = "clbMarkets"
        Me.clbMarkets.Size = New System.Drawing.Size(501, 144)
        Me.clbMarkets.TabIndex = 24
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
        'cbProfiles
        '
        Me.cbProfiles.FormattingEnabled = True
        Me.cbProfiles.Location = New System.Drawing.Point(9, 25)
        Me.cbProfiles.Name = "cbProfiles"
        Me.cbProfiles.Size = New System.Drawing.Size(256, 25)
        Me.cbProfiles.TabIndex = 25
        '
        'gbProfiles
        '
        Me.gbProfiles.Controls.Add(Me.rbRegularly)
        Me.gbProfiles.Controls.Add(Me.rbOneOff)
        Me.gbProfiles.Controls.Add(Me.btnUpdtProfile)
        Me.gbProfiles.Controls.Add(Me.btnNewProfile)
        Me.gbProfiles.Controls.Add(Me.cbProfiles)
        Me.gbProfiles.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProfiles.Location = New System.Drawing.Point(12, 603)
        Me.gbProfiles.Name = "gbProfiles"
        Me.gbProfiles.Size = New System.Drawing.Size(516, 84)
        Me.gbProfiles.TabIndex = 26
        Me.gbProfiles.TabStop = False
        Me.gbProfiles.Text = "Optional : Save Settings as a Profile."
        '
        'rbRegularly
        '
        Me.rbRegularly.AutoSize = True
        Me.rbRegularly.Location = New System.Drawing.Point(18, 54)
        Me.rbRegularly.Name = "rbRegularly"
        Me.rbRegularly.Size = New System.Drawing.Size(128, 23)
        Me.rbRegularly.TabIndex = 30
        Me.rbRegularly.TabStop = True
        Me.rbRegularly.Text = "Do this regularly"
        Me.rbRegularly.UseVisualStyleBackColor = True
        '
        'rbOneOff
        '
        Me.rbOneOff.AutoSize = True
        Me.rbOneOff.Location = New System.Drawing.Point(146, 54)
        Me.rbOneOff.Name = "rbOneOff"
        Me.rbOneOff.Size = New System.Drawing.Size(223, 23)
        Me.rbOneOff.TabIndex = 29
        Me.rbOneOff.TabStop = True
        Me.rbOneOff.Text = "This is just a ONE Off download."
        Me.rbOneOff.UseVisualStyleBackColor = True
        '
        'btnUpdtProfile
        '
        Me.btnUpdtProfile.Location = New System.Drawing.Point(271, 24)
        Me.btnUpdtProfile.Name = "btnUpdtProfile"
        Me.btnUpdtProfile.Size = New System.Drawing.Size(113, 25)
        Me.btnUpdtProfile.TabIndex = 27
        Me.btnUpdtProfile.Text = "Update Current"
        Me.btnUpdtProfile.UseVisualStyleBackColor = True
        '
        'btnNewProfile
        '
        Me.btnNewProfile.Location = New System.Drawing.Point(390, 24)
        Me.btnNewProfile.Name = "btnNewProfile"
        Me.btnNewProfile.Size = New System.Drawing.Size(113, 25)
        Me.btnNewProfile.TabIndex = 26
        Me.btnNewProfile.Text = "Save New..."
        Me.btnNewProfile.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 752)
        Me.Controls.Add(Me.gbChooseMarkets)
        Me.Controls.Add(Me.gbProfiles)
        Me.Controls.Add(Me.gbChooseDates)
        Me.Controls.Add(Me.gbDataFormats)
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
        Me.gbDataFormats.ResumeLayout(False)
        Me.gbDataFormats.PerformLayout()
        Me.gbChooseMarkets.ResumeLayout(False)
        Me.gbChooseMarkets.PerformLayout()
        Me.gbProfiles.ResumeLayout(False)
        Me.gbProfiles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdDownloadLocation As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents clbFiles As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFromDate As Label
    Friend WithEvents lblToDate As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsStatusText As ToolStripStatusLabel
    Friend WithEvents tsprogressbar1 As ToolStripProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents gbDownloadPath As GroupBox
    Friend WithEvents tbDownloadLocation As TextBox
    Friend WithEvents gbChooseDates As GroupBox
    Friend WithEvents gbDataFormats As GroupBox
    Friend WithEvents lblConvertData2Formats As Label
    Friend WithEvents cbSQLCompact As CheckBox
    Friend WithEvents cbSQLite As CheckBox
    Friend WithEvents cbMetastock As CheckBox
    Friend WithEvents cbExcel As CheckBox
    Friend WithEvents cbTSV As CheckBox
    Friend WithEvents cbCSV As CheckBox
    Friend WithEvents gbChooseMarkets As GroupBox
    Friend WithEvents lblDownloadData4Markets As Label
    Friend WithEvents clbMarkets As CheckedListBox
    Friend WithEvents cbProfiles As ComboBox
    Friend WithEvents gbProfiles As GroupBox
    Friend WithEvents btnUpdtProfile As Button
    Friend WithEvents btnNewProfile As Button
    Friend WithEvents rbRegularly As RadioButton
    Friend WithEvents rbOneOff As RadioButton
End Class
