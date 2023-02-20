Public Class frmlogin


    Private password As Integer

    Private Sub btHelp_Click(sender As Object, e As EventArgs) Handles btHelp.Click
        MsgBox("Password : 123456")
    End Sub

    Private Sub btLI_Click(sender As Object, e As EventArgs) Handles btLI.Click
        frmDetails.Show()
    End Sub
End Class