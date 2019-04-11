Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class MainForm
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        administrator.Show()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome back " + Form1.USERNAMETextBox.Text.ToUpper + ", Here's what you can check:"
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper
        Label3.Text = DateTime.Now.ToString("dddd") + " " + System.DateTime.Now.ToString("MMMM dd yyyy")
        Dim con As SqlConnection = New SqlConnection("Data Source=(local)\SQLExpress;Initial Catalog=StationPlus;Integrated Security=True")
        Dim cmd As SqlCommand
        Dim query As String = "SELECT COUNT(CLIENT_ID) FROM CLIENTS"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label4.Text = myreader.GetValue(0) & " Clients"

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Dim query2 As String = "SELECT COUNT(REWARD_ID) FROM REWARDS"
        cmd = New SqlCommand(query2, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label5.Text = myreader.GetValue(0) & " Rewards to choose from"

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Dim query3 As String = "SELECT COUNT(ITEM_ID) FROM INVENTORY"
        cmd = New SqlCommand(query3, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label6.Text = myreader.GetValue(0) & " Items in your inventory"

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Dim query4 As String = "Select CLIENT_FN from CLIENTS,POINTS
                                WHERE CLIENTS.CLIENT_ID = POINTS.CLIENT_ID
                                AND  POINTS = (select max(POINTS) from POINTS)"
        cmd = New SqlCommand(query4, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label9.Text = "Name: " & myreader.GetValue(0)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()


        Dim query5 As String = "Select spendings from CLIENTS,POINTS
                                WHERE CLIENTS.CLIENT_ID = POINTS.CLIENT_ID
                                AND  POINTS = (select max(POINTS) from POINTS)"
        cmd = New SqlCommand(query5, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label8.Text = "Spending: " & myreader.GetValue(0) & " USD"

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Dim query6 As String = "Select POINTS from CLIENTS,POINTS
                                WHERE CLIENTS.CLIENT_ID = POINTS.CLIENT_ID
                                AND  POINTS = (select max(POINTS) from POINTS)"
        cmd = New SqlCommand(query6, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label7.Text = "Points: " & myreader.GetValue(0)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        AboutForm.Show()

    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        CustomSQLForm.Show()

    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        ClientsForm.Show()
        Me.Hide()

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        InventoryForm.Show()
        Me.Hide()

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        RewardsForm.Show()
        Me.Hide()

    End Sub
End Class