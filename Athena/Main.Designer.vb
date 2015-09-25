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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.tbStatusText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'clbFiles
        '
        Me.clbFiles.CheckOnClick = True
        Me.clbFiles.FormattingEnabled = True
        Me.clbFiles.Location = New System.Drawing.Point(11, 170)
        Me.clbFiles.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.clbFiles.MultiColumn = True
        Me.clbFiles.Name = "clbFiles"
        Me.clbFiles.Size = New System.Drawing.Size(373, 504)
        Me.clbFiles.TabIndex = 9
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(11, 139)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(373, 28)
        Me.btnDownload.TabIndex = 18
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.Location = New System.Drawing.Point(199, 44)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(186, 27)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Window
        Me.btnSubmit.Location = New System.Drawing.Point(11, 44)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(184, 27)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Dates Selection"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(201, 13)
        Me.dtpToDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(184, 25)
        Me.dtpToDate.TabIndex = 15
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(11, 13)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(184, 25)
        Me.dtpFromDate.TabIndex = 14
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(11, 110)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(373, 25)
        Me.pb1.TabIndex = 19
        '
        'tbStatusText
        '
        Me.tbStatusText.BackColor = System.Drawing.SystemColors.Control
        Me.tbStatusText.Location = New System.Drawing.Point(11, 78)
        Me.tbStatusText.Name = "tbStatusText"
        Me.tbStatusText.Size = New System.Drawing.Size(373, 25)
        Me.tbStatusText.TabIndex = 20
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 711)
        Me.Controls.Add(Me.tbStatusText)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.clbFiles)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormMain"
        Me.Text = "Athena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdDownloadLocation As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents clbFiles As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents tbStatusText As System.Windows.Forms.TextBox
End Class
