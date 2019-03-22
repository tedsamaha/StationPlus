Public Class MainForm
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome back " + Form1.USERNAMETextBox.Text.ToUpper + ", Here's what you can check:"
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper
        Label3.Text = DateTime.Now.ToString("dddd") + " " + System.DateTime.Now.ToString("MMMM dd yyyy")
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        AboutForm.Show()

    End Sub
End Class