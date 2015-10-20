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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.fbdDownloadLocation = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsStatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsprogressbar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.gbDownloadPath = New System.Windows.Forms.GroupBox()
        Me.tbDownloadLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.gbDownloadPath.SuspendLayout()
        Me.gbChooseDates.SuspendLayout()
        Me.gbChooseMarkets.SuspendLayout()
        Me.gbDataFormats.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDownload.Location = New System.Drawing.Point(12, 656)
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
        Me.btnReset.Location = New System.Drawing.Point(200, 656)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(184, 25)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Cancel / Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatusText, Me.tsprogressbar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 689)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(543, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStatusText
        '
        Me.tsStatusText.Name = "tsStatusText"
        Me.tsStatusText.Size = New System.Drawing.Size(434, 17)
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
        Me.gbDownloadPath.Controls.Add(Me.Label3)
        Me.gbDownloadPath.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDownloadPath.Location = New System.Drawing.Point(12, 45)
        Me.gbDownloadPath.Name = "gbDownloadPath"
        Me.gbDownloadPath.Size = New System.Drawing.Size(516, 65)
        Me.gbDownloadPath.TabIndex = 24
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 22
        '
        'btnNewProfile
        '
        Me.btnNewProfile.Location = New System.Drawing.Point(389, 656)
        Me.btnNewProfile.Name = "btnNewProfile"
        Me.btnNewProfile.Size = New System.Drawing.Size(139, 25)
        Me.btnNewProfile.TabIndex = 26
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
        Me.clbFiles.TabIndex = 9
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(120, 22)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(145, 25)
        Me.dtpFromDate.TabIndex = 14
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
        Me.dtpToDate.TabIndex = 15
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
        'lblConvertData2Formats
        '
        Me.lblConvertData2Formats.AutoSize = True
        Me.lblConvertData2Formats.Location = New System.Drawing.Point(6, 21)
        Me.lblConvertData2Formats.Name = "lblConvertData2Formats"
        Me.lblConvertData2Formats.Size = New System.Drawing.Size(354, 19)
        Me.lblConvertData2Formats.TabIndex = 23
        Me.lblConvertData2Formats.Text = "Downloaded data should be converted to these formats:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(543, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 711)
        Me.Controls.Add(Me.gbDataFormats)
        Me.Controls.Add(Me.gbChooseMarkets)
        Me.Controls.Add(Me.btnNewProfile)
        Me.Controls.Add(Me.gbChooseDates)
        Me.Controls.Add(Me.gbDownloadPath)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnReset)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Label3 As Label
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
