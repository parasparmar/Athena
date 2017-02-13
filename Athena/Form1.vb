'' Athena is a HR Workflow manager designed to 

Public Class frmMain
    Private Class Athena
        '' checks if this is an exit / aos / clearance type of job run
        Public Property MailType As String = "clearance"

    End Class
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mcDates_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mcDates.DateChanged
        lblFromDate.Text = "From Date : " & e.Start.ToShortDateString
        lblToDate.Text = "To Date : " & e.End.ToShortDateString
    End Sub
End Class

