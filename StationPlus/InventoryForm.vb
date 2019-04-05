Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class InventoryForm
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        MainForm.Show()
        Me.Hide()
    End Sub
    Public Sub FilterData(valueToSearch As String, type As String)
        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        Dim searchQuery As String = "SELECT * From inventory WHERE (" & type & ") like '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        INVENTORYDataGridView1.DataSource = table





    End Sub

    Private Sub INVENTORYBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.INVENTORYBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)

    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StationPlusDataSet.INVENTORY' table. You can move, or remove it, as needed.
        RadioButton1.Checked = True
        Me.INVENTORYTableAdapter.Fill(Me.StationPlusDataSet.INVENTORY)
        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand


        Dim query As String = "SELECT COUNT (ITEM_ID) FROM INVENTORY"
        Dim query1 As String = "SELECT * FROM INVENTORY"
        cmd = New SqlCommand(query, con)
        cmd1 = New SqlCommand(query1, con)
        Try
            con.Open()

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label2.Text = myreader.GetValue(0) & " ITEMS"

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today

        ITEM_IDTextBox.ReadOnly = True
        ITEM_NAMETextBox.ReadOnly = True
        UNITTextBox.ReadOnly = True
        UNIT_PRICETextBox.ReadOnly = True
        INITIAL_STOCKTextBox.ReadOnly = True
        CURRENT_STOCKTextBox.ReadOnly = True

    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Me.INVENTORYBindingSource.MoveFirst()
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Me.INVENTORYBindingSource.MovePrevious()

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Me.INVENTORYBindingSource.MoveNext()

    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        Me.INVENTORYBindingSource.MoveLast()

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        ITEM_IDTextBox.ReadOnly = False
        ITEM_NAMETextBox.ReadOnly = False
        UNITTextBox.ReadOnly = False
        UNIT_PRICETextBox.ReadOnly = False
        INITIAL_STOCKTextBox.ReadOnly = False
        CURRENT_STOCKTextBox.ReadOnly = False
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        ITEM_IDTextBox.ReadOnly = False
        ITEM_NAMETextBox.ReadOnly = False
        UNITTextBox.ReadOnly = False
        UNIT_PRICETextBox.ReadOnly = False
        INITIAL_STOCKTextBox.ReadOnly = False
        CURRENT_STOCKTextBox.ReadOnly = False
        Try
            Me.INVENTORYBindingSource.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        Try
            Me.Validate()
            Me.INVENTORYBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ITEM_IDTextBox.ReadOnly = True
        ITEM_NAMETextBox.ReadOnly = True
        UNITTextBox.ReadOnly = True
        UNIT_PRICETextBox.ReadOnly = True
        INITIAL_STOCKTextBox.ReadOnly = True
        CURRENT_STOCKTextBox.ReadOnly = True
        MsgBox("Changes have been Saved", MsgBoxStyle.Information)
        Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand


        Dim query As String = "SELECT COUNT (ITEM_ID) FROM INVENTORY"
        Dim query1 As String = "SELECT * FROM INVENTORY"
        cmd = New SqlCommand(query, con)
        cmd1 = New SqlCommand(query1, con)
        Try
            con.Open()

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                Label2.Text = myreader.GetValue(0) & " ITEMS"

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If RadioButton1.Checked = True Then
            FilterData(TextBox1.Text, "item_id")

        ElseIf RadioButton2.Checked = True Then
            FilterData(TextBox1.Text, "item_name")

        ElseIf RadioButton3.Checked = True Then
            FilterData(TextBox1.Text, "initial_stock")
        ElseIf RadioButton4.Checked = True Then
            FilterData(TextBox1.Text, "current_stock")
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""
        INVENTORYDataGridView1.DataSource = INVENTORYBindingSource
        RadioButton1.Checked = True
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Try
            Me.INVENTORYBindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles FlatButton12.Click
        INVENTORYDataGridView.Sort(INVENTORYDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles FlatButton13.Click
        INVENTORYDataGridView.Sort(INVENTORYDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub FlatButton14_Click(sender As Object, e As EventArgs) Handles FlatButton14.Click
        INVENTORYDataGridView.Sort(INVENTORYDataGridView.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub FlatButton15_Click(sender As Object, e As EventArgs) Handles FlatButton15.Click
        INVENTORYDataGridView.Sort(INVENTORYDataGridView.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlatButton2_Click_1(sender As Object, e As EventArgs) Handles FlatButton2.Click
        TextBox1.Text = ""
        INVENTORYDataGridView1.DataSource = INVENTORYBindingSource
        RadioButton1.Checked = True
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            FilterData(TextBox1.Text, "ITEM_id")

        ElseIf RadioButton2.Checked = True Then
            FilterData(TextBox1.Text, "ITEM_NAME")

        ElseIf RadioButton3.Checked = True Then
            FilterData(TextBox1.Text, "UNIT_PRICE")
        ElseIf RadioButton4.Checked = True Then
            FilterData(TextBox1.Text, "CURRENT_STOCK")
        End If
    End Sub

    Private Sub FlatButton16_Click(sender As Object, e As EventArgs) Handles FlatButton16.Click
        INVENTORYDataGridView.Sort(INVENTORYDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class