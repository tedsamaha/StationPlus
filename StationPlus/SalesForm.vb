Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Imports System.Data.DataTable
Public Class SalesForm
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        MainForm.Show()
        Me.Close()

    End Sub

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StationPlusDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.StationPlusDataSet.INVENTORY)
        'TODO: This line of code loads data into the 'StationPlusDataSet.CLIENTS' table. You can move, or remove it, as needed.
        Me.CLIENTSTableAdapter.Fill(Me.StationPlusDataSet.CLIENTS)
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        FlatButton6.Hide()
        Panel5.Hide()
        Panel6.Hide()
        FlatButton6.Enabled = True
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        ClientsForm.Show()

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Label6.Text = "Date: " & DateTime.Now.ToString("yyyy/MM/dd")
        Label5.Text = "Time: " & DateTime.Now.ToString("HH:mm:ss")
        Label2.Text = "INVOICE #"
        Label9.Text = DateTime.Now.ToString("yyMMss") + CInt(Math.Ceiling(Rnd() * 200)) + 1

        Dim con As SqlConnection = New SqlConnection("Data Source=(local)\SQLExpress;Initial Catalog=StationPlus;Integrated Security=True")
        Dim query As String = "SELECT CLIENT_ID FROM CLIENTS
            WHERE CLIENT_FN = @VALUE"
        Dim query1 As String = "SELECT CLIENT_FN + ' ' + CLIENT_LN FROM CLIENTS
            WHERE CLIENT_FN = @VALUE"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = ComboBox1.Text
        Dim cmd1 As New SqlCommand(query1, con)
        cmd1.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = ComboBox1.Text

        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label7.Text = myreader.GetValue(0)


            End If
            myreader.Close()

            Try
                Dim myreader2 As SqlDataReader = cmd1.ExecuteReader()
                If myreader2.Read() Then
                    Label8.Text = myreader2.GetValue(0)
                End If


            Catch ex As Exception

            End Try
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Panel3.Show()
        Panel2.Show()
        Panel4.Show()
        Panel6.Show()
        FlatButton6.Show()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Me.Close()
        MainForm.Show()


    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        DataGridView3.Rows.Clear()
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Panel3.Hide()
        Panel2.Hide()
        FlatButton6.Enabled = True
        Panel5.Hide()
        Panel6.Hide()
        Panel4.Hide()
        FlatButton6.Hide()


    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(local)\SQLExpress;Initial Catalog=StationPlus;Integrated Security=True")
        Dim totalRowCount As Integer = DataGridView3.Rows.Count - (If(DataGridView3.AllowUserToAddRows, 1, 0))
        Try
            If totalRowCount = 0 Then

                MsgBox("You have not added any items")
            Else



                Dim command As New SqlCommand("SET IDENTITY_INSERT ORDER_H ON; INSERT INTO ORDER_H(ORDER_ID,CLIENT_ID,ORDER_DATE,ORDER_TIME) VALUES (@AUTOID,@ID,@DATE,@TIME)", con)

                If MsgBox("Are you sure you want to proceed the transaction cannot be reverted", MsgBoxStyle.YesNo, "StationPlus - Warning") = MsgBoxResult.Yes Then

                    command.Parameters.Add("@AUTOID", SqlDbType.Int).Value = Label9.Text
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Label7.Text
                    command.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy/MM/dd")
                    command.Parameters.Add("@TIME", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss")


                    con.Open()
                    If command.ExecuteNonQuery() Then
                        ' execute command
                    End If



                Else
                    command.Cancel()

                    MsgBox("Transaction canceled")
                    DataGridView3.Rows.Clear()
                    Label5.Text = ""
                    Label6.Text = ""
                    Label7.Text = ""
                    Label8.Text = ""
                    Label9.Text = ""
                    Panel4.Hide()
                    Panel5.Hide()
                    Panel6.Hide()
                    FlatButton6.Hide()
                End If
                Try



                    Dim command1 As New SqlCommand("INSERT INTO ORDER_B VALUES (@ID1, @AUTOID1, @QUANTITY,@ITEM_ID,'')", con)






                    For i As Integer = 0 To DataGridView3.Rows.Count
                        command1.Parameters.Clear()

                        command1.Parameters.Add("@ID1", SqlDbType.Int).Value = DataGridView3.Rows(i).Cells(0).Value.ToString
                        command1.Parameters.Add("AUTOID1", SqlDbType.Int).Value = DataGridView3.Rows(i).Cells(1).Value
                        command1.Parameters.Add("@ITEM_ID", SqlDbType.Int).Value = DataGridView3.Rows(i).Cells(2).Value
                        command1.Parameters.Add("@QUANTITY", SqlDbType.Float).Value = DataGridView3.Rows(i).Cells(4).Value.ToString


                        command1.ExecuteNonQuery()


                    Next

                Catch ex As Exception

                End Try
                FlatButton6.Enabled = False


                con.Close()
                Panel5.Show()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim cmd As SqlCommand
        Dim query As String = "SELECT TOTAL_PRICE FROM ORDER_H WHERE ORDER_ID=" & Label9.Text
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label11.Text = "$" & myreader.GetValue(0) & " USD"

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter Quantity")
        Else
            DataGridView3.Rows.Add(Label9.Text + DataGridView3.RowCount, Label9.Text, ComboBox2.SelectedValue, ComboBox2.Text, TextBox1.Text)
        End If

        TextBox1.Text = "1"
        ComboBox2.SelectedValue = 1



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = TextBox1.Text + 1

        End If
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = TextBox1.Text - 1

        End If
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        DataGridView3.Rows.Clear()


    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        If DataGridView3.SelectedRows.Count > 0 Then

            DataGridView3.Rows.Remove(DataGridView3.SelectedRows(0))
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles FlatButton12.Click
        DataGridView3.Rows.Clear()
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Panel3.Hide()
        Panel2.Hide()

        Panel5.Hide()
        Panel6.Hide()
        Panel4.Hide()
        FlatButton6.Hide()
    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles FlatButton13.Click
        If MsgBox("Order has been completed, Would you like to make another transaction", MsgBoxStyle.YesNo, "StationPlus - Warning") = MsgBoxResult.Yes Then
            Me.Controls.Clear()
            InitializeComponent()
            SalesForm_Load(e, e)
        Else
            Me.Close()
            MainForm.Show()


        End If

    End Sub
End Class