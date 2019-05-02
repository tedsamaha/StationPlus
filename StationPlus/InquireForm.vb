Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Imports System.Data.DataTable
Public Class InquireForm
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Close()
        MainForm.Show()

    End Sub

    Private Sub FlatButton14_Click(sender As Object, e As EventArgs) Handles FlatButton14.Click

        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub InquireForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StationPlusDataSet.CLIENTS' table. You can move, or remove it, as needed.
        Me.CLIENTSTableAdapter.Fill(Me.StationPlusDataSet.CLIENTS)
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Label1.Text = ""
        Label2.Text = "Search"
        Label3.Text = ""
        Panel4.Hide()
        Panel5.Hide()
        RadioButton3.Checked = True

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Label2.Text = "Date Search"
        Label1.Text = "Showing Result For : " & DateTimePicker1.Value.ToString("yyyy-MM-dd")

        Try
            Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
            Dim query As String = "SELECT * FROM ORDER_H WHERE ORDER_DATE = '" & DateTimePicker1.Value & "'"

            Dim cmd As New SqlCommand(query, con)



            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label3.Text = "Search Returned : " & DataGridView1.RowCount & " Records"
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Label2.Text = "Client Search"
        Label1.Text = "Showing Result For : " & ComboBox1.Text

        Try
            Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
            Dim query As String = "  SELECT CLIENT_FN + ' ' + CLIENT_LN AS Name, ORDER_ID,ORDER_DATE,TOTAL_PRICE FROM ORDER_H,CLIENTS
  WHERE ORDER_H.CLIENT_ID = CLIENTS.CLIENT_ID
  AND CLIENT_FN = '" & ComboBox1.Text & "'"

            Dim cmd As New SqlCommand(query, con)



            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label3.Text = "Search Returned : " & DataGridView1.RowCount & " Records"
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click


        Panel4.Hide()
        Panel5.Hide()
        Label1.Text = ""
        Label2.Text = "Search"
        Label3.Text = ""
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Panel5.Hide()

        Panel4.Show()
        Label1.Text = ""
        Label2.Text = "Search"
        Label3.Text = ""
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        If TextBox1.Text <> "" Then
            Label2.Text = "Price Search"

            If RadioButton1.Checked = True Then
                Label1.Text = "Showing Result higher than : " & TextBox1.Text
                Try

                    Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
                    Dim query As String = " SELECT * FROM ORDER_H WHERE TOTAL_PRICE >= '" & TextBox1.Text & "'"

                    Dim cmd As New SqlCommand(query, con)



                    Dim adapter As New SqlDataAdapter(cmd)

                    Dim table As New DataTable

                    adapter.Fill(table)

                    DataGridView1.DataSource = table
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf RadioButton2.Checked = True Then
                Label1.Text = "Showing Result lower than : " & TextBox1.Text
                Try
                    Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
                    Dim query As String = " SELECT * FROM ORDER_H WHERE TOTAL_PRICE <= '" & TextBox1.Text & "'"

                    Dim cmd As New SqlCommand(query, con)



                    Dim adapter As New SqlDataAdapter(cmd)

                    Dim table As New DataTable

                    adapter.Fill(table)

                    DataGridView1.DataSource = table
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else

                Label1.Text = "Showing Result for : " & TextBox1.Text
                Try

                    Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
                    Dim query As String = " SELECT * FROM ORDER_H WHERE TOTAL_PRICE = '" & TextBox1.Text & "'"

                    Dim cmd As New SqlCommand(query, con)



                    Dim adapter As New SqlDataAdapter(cmd)

                    Dim table As New DataTable

                    adapter.Fill(table)

                    DataGridView1.DataSource = table
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

            Label3.Text = "Search Returned : " & DataGridView1.RowCount & " Records"
        Else
            MsgBox("Please enter a value")
        End If

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Panel4.Show()
        Panel5.Show()


        Label1.Text = ""
        Label2.Text = "Search"
        Label3.Text = ""
    End Sub
End Class