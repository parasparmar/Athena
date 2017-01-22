<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.mcDates = New System.Windows.Forms.MonthCalendar()
        Me.ckbExits = New System.Windows.Forms.CheckBox()
        Me.ckbAOS = New System.Windows.Forms.CheckBox()
        Me.ckbClearance = New System.Windows.Forms.CheckBox()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(185, 177)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(86, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'mcDates
        '
        Me.mcDates.Location = New System.Drawing.Point(185, 11)
        Me.mcDates.MaxSelectionCount = 360
        Me.mcDates.Name = "mcDates"
        Me.mcDates.TabIndex = 1
        '
        'ckbExits
        '
        Me.ckbExits.AutoSize = True
        Me.ckbExits.Location = New System.Drawing.Point(12, 15)
        Me.ckbExits.Name = "ckbExits"
        Me.ckbExits.Size = New System.Drawing.Size(48, 17)
        Me.ckbExits.TabIndex = 2
        Me.ckbExits.Text = "Exits"
        Me.ckbExits.UseVisualStyleBackColor = True
        '
        'ckbAOS
        '
        Me.ckbAOS.AutoSize = True
        Me.ckbAOS.Location = New System.Drawing.Point(12, 38)
        Me.ckbAOS.Name = "ckbAOS"
        Me.ckbAOS.Size = New System.Drawing.Size(48, 17)
        Me.ckbAOS.TabIndex = 3
        Me.ckbAOS.Text = "AOS"
        Me.ckbAOS.UseVisualStyleBackColor = True
        '
        'ckbClearance
        '
        Me.ckbClearance.AutoSize = True
        Me.ckbClearance.Location = New System.Drawing.Point(12, 61)
        Me.ckbClearance.Name = "ckbClearance"
        Me.ckbClearance.Size = New System.Drawing.Size(74, 17)
        Me.ckbClearance.TabIndex = 4
        Me.ckbClearance.Text = "Clearance"
        Me.ckbClearance.UseVisualStyleBackColor = True
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(9, 86)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(65, 13)
        Me.lblFromDate.TabIndex = 5
        Me.lblFromDate.Text = "From Date : "
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(19, 103)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(55, 13)
        Me.lblToDate.TabIndex = 6
        Me.lblToDate.Text = "To Date : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 212)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.ckbClearance)
        Me.Controls.Add(Me.ckbAOS)
        Me.Controls.Add(Me.ckbExits)
        Me.Controls.Add(Me.mcDates)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Athena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents mcDates As System.Windows.Forms.MonthCalendar
    Friend WithEvents ckbExits As System.Windows.Forms.CheckBox
    Friend WithEvents ckbAOS As System.Windows.Forms.CheckBox
    Friend WithEvents ckbClearance As System.Windows.Forms.CheckBox
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
