Public Class Form1
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        MsgBox(txtFirstName.Text & " " & txtLastName.Text)

        frmDisplayInfo.lblLastName.Text = txtLastName.Text
        frmDisplayInfo.lblFirstName.Text = txtFirstName.Text
        frmDisplayInfo.Show()
        Form2.Show()
    End Sub
End Class
