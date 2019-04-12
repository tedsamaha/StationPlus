Public Class RewardsForm


    Private Sub RewardsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REWARD_NAMETextBox.ReadOnly = True
        REWARD_DESCRIPTIONTextBox.ReadOnly = True
        POINTS_REQTextBox.ReadOnly = True
        'TODO: This line of code loads data into the 'StationPlusDataSet.REWARDS' table. You can move, or remove it, as needed.
        Me.REWARDSTableAdapter.Fill(Me.StationPlusDataSet.REWARDS)
        'TODO: This line of code loads data into the 'StationPlusDataSet.REWARDS' table. You can move, or remove it, as needed.
        FlatStatusBar1.Text = "You are currently Logged in as:  " + Form1.USERNAMETextBox.Text.ToUpper + "                           Current Date is: " + System.DateTime.Today

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub REWARDSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.REWARDSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        REWARD_NAMETextBox.ReadOnly = False
        REWARD_DESCRIPTIONTextBox.ReadOnly = False
        POINTS_REQTextBox.ReadOnly = False
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Me.REWARDSBindingSource.MoveFirst()
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Me.REWARDSBindingSource.MovePrevious()

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Me.REWARDSBindingSource.MoveNext()
    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        Me.REWARDSBindingSource.MoveLast()
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        REWARD_NAMETextBox.ReadOnly = False
        REWARD_DESCRIPTIONTextBox.ReadOnly = False
        POINTS_REQTextBox.ReadOnly = False

        Try
            Me.REWARDSBindingSource.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        Try
            Me.Validate()
            Me.REWARDSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        REWARD_NAMETextBox.ReadOnly = False
        REWARD_DESCRIPTIONTextBox.ReadOnly = False
        POINTS_REQTextBox.ReadOnly = False
        MsgBox("Changes have been Saved", MsgBoxStyle.Information)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class