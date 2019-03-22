Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class CustomSQLForm
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        MainForm.Show()
        Me.Hide()

    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim DataConnection As New SqlConnection
        DataConnection.ConnectionString = ("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        DataConnection.Open()
        Dim cmd As New SqlCommand
        cmd.Connection = DataConnection
        cmd.CommandText = TextBox1.Text
        Try
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim dt As New DataTable
            dt.Load(rdr)
            rdr.Close()
            DataGridView1.DataSource = dt
            DataConnection.Close()
            Me.Text = dt.Rows.Count & " rows"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        TextBox1.Clear()

    End Sub
End Class