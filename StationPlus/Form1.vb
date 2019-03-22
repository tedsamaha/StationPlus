Public Class Form1
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If USERNAMETextBox.Text = "" Or USERPASSTextBox.Text = "" Then
            MsgBox("Please Enter a valid username or password!", MsgBoxStyle.Exclamation)
        Else
            MainForm.Show()
            Me.Hide()
        End If


    End Sub
End Class
