Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class LoyaltyForm
    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoyaltyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StationPlusDataSet.POINTS' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'StationPlusDataSet.CLIENTS' table. You can move, or remove it, as needed.
        Me.CLIENTSTableAdapter.Fill(Me.StationPlusDataSet.CLIENTS)
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today
        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        Dim cmd As SqlCommand


        Dim query As String = "select POINTS from POINTS Where points.CLIENT_ID = @VALUE"


        cmd = New SqlCommand(query, con)
        cmd.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = CLIENTSComboBox.SelectedValue

        Try
            con.Open()

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label4.Text = myreader.GetValue(0)
            End If
            myreader.Close()
            con.Close()


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub CLIENTSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)

    End Sub

    Private Sub CLIENTSComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CLIENTSComboBox.SelectedIndexChanged

        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        Dim cmd As SqlCommand


        Dim query As String = "select POINTS from POINTS Where points.CLIENT_ID = @VALUE"


        cmd = New SqlCommand(query, con)
        cmd.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = CLIENTSComboBox.SelectedValue

        Try
            con.Open()

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label4.Text = myreader.GetValue(0)
            End If
            myreader.Close()
            con.Close()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click

        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        Dim query As String = "SELECT POINTS.POINTS AS 'CURRENT POINTS',REWARD_NAME AS 'REWARD' ,REWARD_DESCRIPTION AS 'DESCRIPTION'
, POINTS_REQ AS 'REQUIRED POINTS' FROM REWARDS,POINTS,CLIENTS
WHERE  POINTS.POINTS > REWARDS.POINTS_REQ
AND CLIENTS.CLIENT_ID = POINTS.CLIENT_ID
AND CLIENTS.CLIENT_ID = @VALUE"

        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = CLIENTSComboBox.SelectedValue

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub
End Class