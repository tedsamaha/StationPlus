Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
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
        Label9.Text = DateTime.Now.ToString("yyMMss") & CInt(Math.Ceiling(Rnd() * 200)) + 1

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

        FlatButton6.Show()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Me.Close()
        MainForm.Show()


    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        DataGridView1.Rows.Clear()
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Panel5.Hide()

        Panel4.Hide()
        FlatButton6.Hide()


    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=(local)\SQLExpress;Initial Catalog=StationPlus;Integrated Security=True")
        Dim totalRowCount As Integer = DataGridView1.Rows.Count - (If(DataGridView1.AllowUserToAddRows, 1, 0))
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
                    Dim IDCMD As New SqlCommand("SELECT ORDER_ID FROM ")


                Else
                    Command.Cancel()

                    MsgBox("Transaction canceled")
                    DataGridView1.Rows.Clear()
                    Label5.Text = ""
                    Label6.Text = ""
                    Label7.Text = ""
                    Label8.Text = ""
                    Label9.Text = ""
                    Panel4.Hide()
                    Panel5.Hide()

                    FlatButton6.Hide()
                End If
                Try



                    Dim command1 As New SqlCommand("INSERT INTO ORDER_B VALUES (@ID, @AUTOID, @QUANTITY,@ITEM_ID,(SELECT SUM (UNIT_PRICE) *@QUANTITY FROM INVENTORY WHERE ITEM_ID = @ITEM_ID))", con)






                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        command1.Parameters.Add("@ID", SqlDbType.Int).Value = Label9.Text + i
                        command1.Parameters.Add("@QUANTITY", SqlDbType.Float).Value = DataGridView1.Rows(i).Cells(1).Value
                        command1.Parameters.Add("@ITEM_ID", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(0).Value
                        command1.Parameters.Add("AUTOID", SqlDbType.Int).Value = Label9.Text

                        If command1.ExecuteNonQuery() Then
                            MsgBox("Order Complete")
                        End If
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Panel5.Show()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class