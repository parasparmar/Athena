﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tbDownloadLocation = New System.Windows.Forms.TextBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.clbMarkets = New System.Windows.Forms.CheckedListBox()
        Me.lblDownloadData4Markets = New System.Windows.Forms.Label()
        Me.ofdSettings = New System.Windows.Forms.OpenFileDialog()
        Me.lblDownloadPath = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.tbCsvPath = New System.Windows.Forms.TextBox()
        Me.tbCustomPath = New System.Windows.Forms.TextBox()
        Me.tbExcelPath = New System.Windows.Forms.TextBox()
        Me.tbMetastockPath = New System.Windows.Forms.TextBox()
        Me.tbCustomDelimiter = New System.Windows.Forms.TextBox()
        Me.tsProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.Location = New System.Drawing.Point(233, 149)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(119, 25)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(95, 149)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(121, 25)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatusText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 330)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(362, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStatusText
        '
        Me.tsStatusText.Name = "tsStatusText"
        Me.tsStatusText.Size = New System.Drawing.Size(402, 17)
        Me.tsStatusText.Spring = True
        Me.tsStatusText.Text = "Ready..."
        Me.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDownloadLocation
        '
        Me.tbDownloadLocation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDownloadLocation.Location = New System.Drawing.Point(95, 12)
        Me.tbDownloadLocation.Multiline = True
        Me.tbDownloadLocation.Name = "tbDownloadLocation"
        Me.tbDownloadLocation.Size = New System.Drawing.Size(257, 25)
        Me.tbDownloadLocation.TabIndex = 0
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(95, 121)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(121, 22)
        Me.dtpFromDate.TabIndex = 0
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.Location = New System.Drawing.Point(53, 128)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(36, 13)
        Me.lblFromDate.TabIndex = 21
        Me.lblFromDate.Text = "Dates"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Location = New System.Drawing.Point(233, 121)
        Me.dtpToDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(119, 22)
        Me.dtpToDate.TabIndex = 1
        '
        'clbMarkets
        '
        Me.clbMarkets.CheckOnClick = True
        Me.clbMarkets.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbMarkets.FormattingEnabled = True
        Me.clbMarkets.Items.AddRange(New Object() {"NSE - Equity", "BSE - Equity", "AMFII - Mutual Funds"})
        Me.clbMarkets.Location = New System.Drawing.Point(95, 43)
        Me.clbMarkets.Name = "clbMarkets"
        Me.clbMarkets.Size = New System.Drawing.Size(257, 72)
        Me.clbMarkets.TabIndex = 0
        '
        'lblDownloadData4Markets
        '
        Me.lblDownloadData4Markets.AutoSize = True
        Me.lblDownloadData4Markets.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloadData4Markets.Location = New System.Drawing.Point(41, 43)
        Me.lblDownloadData4Markets.Name = "lblDownloadData4Markets"
        Me.lblDownloadData4Markets.Size = New System.Drawing.Size(48, 13)
        Me.lblDownloadData4Markets.TabIndex = 23
        Me.lblDownloadData4Markets.Text = "Markets"
        '
        'ofdSettings
        '
        Me.ofdSettings.FileName = "ofdSettings"
        '
        'lblDownloadPath
        '
        Me.lblDownloadPath.AutoSize = True
        Me.lblDownloadPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloadPath.Location = New System.Drawing.Point(2, 15)
        Me.lblDownloadPath.Name = "lblDownloadPath"
        Me.lblDownloadPath.Size = New System.Drawing.Size(87, 13)
        Me.lblDownloadPath.TabIndex = 36
        Me.lblDownloadPath.Text = "Download Path"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(64, 182)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "CSV"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(59, 241)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox2.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox2.TabIndex = 38
        Me.CheckBox2.Text = "Excel"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(31, 272)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox3.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox3.TabIndex = 39
        Me.CheckBox3.Text = "Metastock"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(45, 210)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox4.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox4.TabIndex = 40
        Me.CheckBox4.Text = "Custom"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'tbCsvPath
        '
        Me.tbCsvPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCsvPath.Location = New System.Drawing.Point(116, 180)
        Me.tbCsvPath.Name = "tbCsvPath"
        Me.tbCsvPath.Size = New System.Drawing.Size(236, 22)
        Me.tbCsvPath.TabIndex = 41
        '
        'tbCustomPath
        '
        Me.tbCustomPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomPath.Location = New System.Drawing.Point(168, 208)
        Me.tbCustomPath.Name = "tbCustomPath"
        Me.tbCustomPath.Size = New System.Drawing.Size(184, 22)
        Me.tbCustomPath.TabIndex = 42
        '
        'tbExcelPath
        '
        Me.tbExcelPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExcelPath.Location = New System.Drawing.Point(116, 239)
        Me.tbExcelPath.Name = "tbExcelPath"
        Me.tbExcelPath.Size = New System.Drawing.Size(236, 22)
        Me.tbExcelPath.TabIndex = 43
        '
        'tbMetastockPath
        '
        Me.tbMetastockPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMetastockPath.Location = New System.Drawing.Point(116, 270)
        Me.tbMetastockPath.Name = "tbMetastockPath"
        Me.tbMetastockPath.Size = New System.Drawing.Size(236, 22)
        Me.tbMetastockPath.TabIndex = 44
        '
        'tbCustomDelimiter
        '
        Me.tbCustomDelimiter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomDelimiter.Location = New System.Drawing.Point(116, 208)
        Me.tbCustomDelimiter.Name = "tbCustomDelimiter"
        Me.tbCustomDelimiter.Size = New System.Drawing.Size(46, 22)
        Me.tbCustomDelimiter.TabIndex = 45
        '
        'tsProgressBar1
        '
        Me.tsProgressBar1.Location = New System.Drawing.Point(116, 298)
        Me.tsProgressBar1.Name = "tsProgressBar1"
        Me.tsProgressBar1.Size = New System.Drawing.Size(236, 22)
        Me.tsProgressBar1.TabIndex = 46
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 352)
        Me.Controls.Add(Me.tsProgressBar1)
        Me.Controls.Add(Me.tbCustomDelimiter)
        Me.Controls.Add(Me.tbMetastockPath)
        Me.Controls.Add(Me.tbExcelPath)
        Me.Controls.Add(Me.tbCustomPath)
        Me.Controls.Add(Me.tbCsvPath)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblDownloadPath)
        Me.Controls.Add(Me.tbDownloadLocation)
        Me.Controls.Add(Me.clbMarkets)
        Me.Controls.Add(Me.lblDownloadData4Markets)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnDownload)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormMain"
        Me.Text = "Athena"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdDownloadLocation As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsStatusText As ToolStripStatusLabel
    Friend WithEvents tbDownloadLocation As TextBox
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents lblFromDate As Label
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents clbMarkets As CheckedListBox
    Friend WithEvents lblDownloadData4Markets As Label
    Friend WithEvents ofdSettings As OpenFileDialog
    Friend WithEvents lblDownloadPath As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents tbCsvPath As TextBox
    Friend WithEvents tbCustomPath As TextBox
    Friend WithEvents tbExcelPath As TextBox
    Friend WithEvents tbMetastockPath As TextBox
    Friend WithEvents tbCustomDelimiter As TextBox
    Friend WithEvents tsProgressBar1 As ProgressBar
End Class
