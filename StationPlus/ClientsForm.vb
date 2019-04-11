Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class ClientsForm


    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
    Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =STATIONPLUS; Integrated Security = true")
    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "SELECT * From CLIENTS WHERE (CLIENT_FN + CLIENT_LN) like '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        CLIENTSDataGridView.DataSource = table





    End Sub

    Private Sub ClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STATIONPLUSDataSet.CLIENTS' table. You can move, or remove it, as needed.
        Me.CLIENTSTableAdapter.Fill(Me.StationPlusDataSet.CLIENTS)




        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =STATIONPLUS; Integrated Security = true")
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand


        Dim query As String = "SELECT COUNT (CLIENT_ID) FROM CLIENTS"
        Dim query1 As String = "SELECT * FROM CLIENTS"
        cmd = New SqlCommand(query, con)
        cmd1 = New SqlCommand(query1, con)
        Try
            con.Open()

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label2.Text = myreader.GetValue(0) & " Clients"

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try


        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "           " + System.DateTime.Today
        FlatStatusBar2.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today


        CLIENT_FNTextBox1.ReadOnly = True

        CLIENT_LNTextBox1.ReadOnly = True
        MOBILETextBox1.ReadOnly = True
        C_ADDRESSTextBox1.ReadOnly = True
        CORP_MOBILETextBox1.ReadOnly = True
        WEBSITETextBox1.ReadOnly = True
        EMAILTextBox1.ReadOnly = True


    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try
            Me.Validate()
            Me.CLIENTSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        MainForm.Show()
        Me.Hide()

    End Sub

    Private Sub CLIENTSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)

    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Me.CLIENTSBindingSource.MoveFirst()

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Me.CLIENTSBindingSource.MoveNext()

    End Sub

    Private Sub FlatButton7_Click_1(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Me.CLIENTSBindingSource.MovePrevious()

    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        Me.CLIENTSBindingSource.MoveLast()

    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        Try
            Me.Validate()
            Me.CLIENTSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CLIENT_FNTextBox1.ReadOnly = True

        CLIENT_LNTextBox1.ReadOnly = True
        MOBILETextBox1.ReadOnly = True
        C_ADDRESSTextBox1.ReadOnly = True
        CORP_MOBILETextBox1.ReadOnly = True
        EMAILTextBox1.ReadOnly = True
        WEBSITETextBox1.ReadOnly = True

        MsgBox("Changes have been Saved", MsgBoxStyle.Information)

        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =STATIONPLUS; Integrated Security = true")
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand


        Dim query As String = "SELECT COUNT (CLIENT_ID) FROM CLIENTS"
        Dim query1 As String = "SELECT * FROM CLIENTS"
        cmd = New SqlCommand(query, con)
        cmd1 = New SqlCommand(query1, con)
        Try
            con.Open()

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label2.Text = myreader.GetValue(0) & " Clients"

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click

        Try
            Me.CLIENTSBindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        CLIENT_FNTextBox1.ReadOnly = False

        CLIENT_LNTextBox1.ReadOnly = False
        MOBILETextBox1.ReadOnly = False
        C_ADDRESSTextBox1.ReadOnly = False
        CORP_MOBILETextBox1.ReadOnly = False
        EMAILTextBox1.ReadOnly = False
        WEBSITETextBox1.ReadOnly = False

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        CLIENT_FNTextBox1.ReadOnly = False

        CLIENT_LNTextBox1.ReadOnly = False
        MOBILETextBox1.ReadOnly = False
        C_ADDRESSTextBox1.ReadOnly = False
        CORP_MOBILETextBox1.ReadOnly = False
        EMAILTextBox1.ReadOnly = False
        WEBSITETextBox1.ReadOnly = False

        Try
            Me.CLIENTSBindingSource.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub JOB_TITLETextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CLIENT_IDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MOBILETextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MOBILETextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub CORP_MOBILETextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles FlatButton12.Click
        TextBox1.Text = ""

        CLIENTSDataGridView.DataSource = CLIENTSBindingSource
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FilterData(TextBox1.Text)
    End Sub

    Private Sub CLIENTSDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CLIENTSDataGridView.CellContentClick

    End Sub

    Private Sub CORP_MOBILETextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class