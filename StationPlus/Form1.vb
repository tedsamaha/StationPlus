Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Form1
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim connection As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        connection.Open()

        Dim dr As SqlClient.SqlDataReader

        Dim cmd As New SqlCommand("select * from [SPLUS_USERS] where Username = @username and Userpass = @userpass", connection)

        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = USERNAMETextBox.Text
        cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = USERPASSTextBox.Text
        dr = cmd.ExecuteReader


        If dr.Read Then
            MainForm.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Username or Password, Please Try again!", MsgBoxStyle.Exclamation)
        End If
        Try
            If dr("ISADMIN") = 1 Then
                MainForm.FlatButton1.Enabled = True
                MainForm.FlatButton6.Enabled = True
                MainForm.FlatButton9.Enabled = True
            Else
                MainForm.FlatButton1.Enabled = False
                MainForm.FlatButton1.BaseColor = Color.DarkGray
                MainForm.FlatButton6.Enabled = False
                MainForm.FlatButton6.BaseColor = Color.DarkGray
                MainForm.FlatButton9.Enabled = False
                MainForm.FlatButton9.BaseColor = Color.DarkGray
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click

    End Sub
End Class
