Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class administrator
    Private Sub administrator_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'StationPlusDataSet.SPLUS_USERS' table. You can move, or remove it, as needed.
        Me.SPLUS_USERSTableAdapter.Fill(Me.StationPlusDataSet.SPLUS_USERS)

    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Me.Hide()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("All Fields Must Be Filled", MsgBoxStyle.Critical)
        Else
            Dim con As New SqlConnection("Server=(local)\SQLExpress; Database =StationPlus; Integrated Security = true")
            Dim cmd As New SqlCommand
            Try
                con.Open()
                cmd.Connection = con


                If CheckBox1.Checked Then
                    cmd.CommandText = "insert into SPLUS_USERS([USERNAME],[USERPASS],[ISADMIN]) values (@USERNAME, @USERPASS, @ISADMIN)"
                    cmd.Parameters.AddWithValue("@USERNAME", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@USERPASS", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ISADMIN", 1)


                Else
                    cmd.CommandText = "insert into SPLUS_USERS([USERNAME],[USERPASS],[ISADMIN]) values (@USERNAME, @USERPASS, @ISADMIN)"
                    cmd.Parameters.AddWithValue("@USERNAME", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@USERPASS", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ISADMIN", 0)
                End If
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader())




                MsgBox("New User Succefully Created!", MsgBoxStyle.Exclamation)

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")

            End Try

        End If

        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)
        SPLUS_USERSTableAdapter.GetData()

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)
    End Sub
End Class