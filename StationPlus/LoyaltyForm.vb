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
        'TODO: This line of code loads data into the 'StationPlusDataSet.CLIENTS' table. You can move, or remove it, as needed.
        Me.CLIENTSTableAdapter.Fill(Me.StationPlusDataSet.CLIENTS)
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today
    End Sub

    Private Sub CLIENTSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)

    End Sub
End Class