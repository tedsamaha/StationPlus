Public Class RewardsForm
    Private Sub REWARDSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.REWARDSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StationPlusDataSet)

    End Sub

    Private Sub RewardsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StationPlusDataSet.REWARDS' table. You can move, or remove it, as needed.
        Me.REWARDSTableAdapter.Fill(Me.StationPlusDataSet.REWARDS)

    End Sub
End Class