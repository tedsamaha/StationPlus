<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RewardsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim REWARD_IDLabel As System.Windows.Forms.Label
        Dim REWARD_NAMELabel As System.Windows.Forms.Label
        Dim REWARD_DESCRIPTIONLabel As System.Windows.Forms.Label
        Dim POINTS_REQLabel As System.Windows.Forms.Label
        Me.StationPlusDataSet = New StationPlus.StationPlusDataSet()
        Me.REWARDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REWARDSTableAdapter = New StationPlus.StationPlusDataSetTableAdapters.REWARDSTableAdapter()
        Me.TableAdapterManager = New StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager()
        Me.FormSkin1 = New StationPlus.FormSkin()
        Me.FlatButton11 = New StationPlus.FlatButton()
        Me.FlatButton10 = New StationPlus.FlatButton()
        Me.FlatStatusBar1 = New StationPlus.FlatStatusBar()
        Me.FlatButton8 = New StationPlus.FlatButton()
        Me.FlatButton7 = New StationPlus.FlatButton()
        Me.REWARD_IDLabel1 = New System.Windows.Forms.Label()
        Me.FlatButton9 = New StationPlus.FlatButton()
        Me.FlatButton4 = New StationPlus.FlatButton()
        Me.REWARD_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.FlatButton5 = New StationPlus.FlatButton()
        Me.FlatButton6 = New StationPlus.FlatButton()
        Me.REWARD_DESCRIPTIONTextBox = New System.Windows.Forms.TextBox()
        Me.POINTS_REQTextBox = New System.Windows.Forms.TextBox()
        Me.REWARDSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatButton3 = New StationPlus.FlatButton()
        Me.FlatButton1 = New StationPlus.FlatButton()
        REWARD_IDLabel = New System.Windows.Forms.Label()
        REWARD_NAMELabel = New System.Windows.Forms.Label()
        REWARD_DESCRIPTIONLabel = New System.Windows.Forms.Label()
        POINTS_REQLabel = New System.Windows.Forms.Label()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REWARDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        CType(Me.REWARDSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StationPlusDataSet
        '
        Me.StationPlusDataSet.DataSetName = "StationPlusDataSet"
        Me.StationPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REWARDSBindingSource
        '
        Me.REWARDSBindingSource.DataMember = "REWARDS"
        Me.REWARDSBindingSource.DataSource = Me.StationPlusDataSet
        '
        'REWARDSTableAdapter
        '
        Me.REWARDSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYTableAdapter = Nothing
        Me.TableAdapterManager.POINTSTableAdapter = Nothing
        Me.TableAdapterManager.REWARDSTableAdapter = Me.REWARDSTableAdapter
        Me.TableAdapterManager.SPLUS_USERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton11)
        Me.FormSkin1.Controls.Add(Me.FlatButton10)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatButton8)
        Me.FormSkin1.Controls.Add(REWARD_IDLabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton7)
        Me.FormSkin1.Controls.Add(Me.REWARD_IDLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatButton9)
        Me.FormSkin1.Controls.Add(REWARD_NAMELabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.REWARD_NAMETextBox)
        Me.FormSkin1.Controls.Add(Me.FlatButton5)
        Me.FormSkin1.Controls.Add(Me.FlatButton6)
        Me.FormSkin1.Controls.Add(REWARD_DESCRIPTIONLabel)
        Me.FormSkin1.Controls.Add(Me.REWARD_DESCRIPTIONTextBox)
        Me.FormSkin1.Controls.Add(POINTS_REQLabel)
        Me.FormSkin1.Controls.Add(Me.POINTS_REQTextBox)
        Me.FormSkin1.Controls.Add(Me.REWARDSDataGridView)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(866, 501)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Station Plus - Rewards"
        '
        'FlatButton11
        '
        Me.FlatButton11.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton11.Location = New System.Drawing.Point(695, 214)
        Me.FlatButton11.Name = "FlatButton11"
        Me.FlatButton11.Rounded = False
        Me.FlatButton11.Size = New System.Drawing.Size(143, 40)
        Me.FlatButton11.TabIndex = 42
        Me.FlatButton11.Text = "Save"
        Me.FlatButton11.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton10
        '
        Me.FlatButton10.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton10.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton10.Location = New System.Drawing.Point(601, 214)
        Me.FlatButton10.Name = "FlatButton10"
        Me.FlatButton10.Rounded = False
        Me.FlatButton10.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton10.TabIndex = 41
        Me.FlatButton10.Text = "Last"
        Me.FlatButton10.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 478)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(866, 23)
        Me.FlatStatusBar1.TabIndex = 54
        Me.FlatStatusBar1.Text = "FlatStatusBar1"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton8.Location = New System.Drawing.Point(601, 168)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = False
        Me.FlatButton8.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton8.TabIndex = 40
        Me.FlatButton8.Text = ">"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'REWARD_IDLabel
        '
        REWARD_IDLabel.AutoSize = True
        REWARD_IDLabel.BackColor = System.Drawing.Color.Transparent
        REWARD_IDLabel.ForeColor = System.Drawing.Color.White
        REWARD_IDLabel.Location = New System.Drawing.Point(17, 100)
        REWARD_IDLabel.Name = "REWARD_IDLabel"
        REWARD_IDLabel.Size = New System.Drawing.Size(119, 28)
        REWARD_IDLabel.TabIndex = 17
        REWARD_IDLabel.Text = "REWARD ID:"
        '
        'FlatButton7
        '
        Me.FlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton7.Location = New System.Drawing.Point(601, 122)
        Me.FlatButton7.Name = "FlatButton7"
        Me.FlatButton7.Rounded = False
        Me.FlatButton7.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton7.TabIndex = 39
        Me.FlatButton7.Text = "<"
        Me.FlatButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'REWARD_IDLabel1
        '
        Me.REWARD_IDLabel1.BackColor = System.Drawing.Color.Transparent
        Me.REWARD_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REWARDSBindingSource, "REWARD_ID", True))
        Me.REWARD_IDLabel1.Location = New System.Drawing.Point(271, 94)
        Me.REWARD_IDLabel1.Name = "REWARD_IDLabel1"
        Me.REWARD_IDLabel1.Size = New System.Drawing.Size(310, 34)
        Me.REWARD_IDLabel1.TabIndex = 18
        Me.REWARD_IDLabel1.Text = "Label1"
        '
        'FlatButton9
        '
        Me.FlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton9.Location = New System.Drawing.Point(601, 76)
        Me.FlatButton9.Name = "FlatButton9"
        Me.FlatButton9.Rounded = False
        Me.FlatButton9.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton9.TabIndex = 38
        Me.FlatButton9.Text = "First"
        Me.FlatButton9.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'REWARD_NAMELabel
        '
        REWARD_NAMELabel.AutoSize = True
        REWARD_NAMELabel.BackColor = System.Drawing.Color.Transparent
        REWARD_NAMELabel.ForeColor = System.Drawing.Color.White
        REWARD_NAMELabel.Location = New System.Drawing.Point(17, 134)
        REWARD_NAMELabel.Name = "REWARD_NAMELabel"
        REWARD_NAMELabel.Size = New System.Drawing.Size(156, 28)
        REWARD_NAMELabel.TabIndex = 19
        REWARD_NAMELabel.Text = "REWARD NAME:"
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(695, 76)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(143, 40)
        Me.FlatButton4.TabIndex = 33
        Me.FlatButton4.Text = "Edit"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'REWARD_NAMETextBox
        '
        Me.REWARD_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REWARDSBindingSource, "REWARD_NAME", True))
        Me.REWARD_NAMETextBox.Location = New System.Drawing.Point(271, 134)
        Me.REWARD_NAMETextBox.Name = "REWARD_NAMETextBox"
        Me.REWARD_NAMETextBox.Size = New System.Drawing.Size(310, 34)
        Me.REWARD_NAMETextBox.TabIndex = 20
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(695, 122)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(143, 39)
        Me.FlatButton5.TabIndex = 34
        Me.FlatButton5.Text = "Add"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton6.Location = New System.Drawing.Point(695, 168)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(143, 40)
        Me.FlatButton6.TabIndex = 35
        Me.FlatButton6.Text = "Delete"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'REWARD_DESCRIPTIONLabel
        '
        REWARD_DESCRIPTIONLabel.AutoSize = True
        REWARD_DESCRIPTIONLabel.BackColor = System.Drawing.Color.Transparent
        REWARD_DESCRIPTIONLabel.ForeColor = System.Drawing.Color.White
        REWARD_DESCRIPTIONLabel.Location = New System.Drawing.Point(17, 174)
        REWARD_DESCRIPTIONLabel.Name = "REWARD_DESCRIPTIONLabel"
        REWARD_DESCRIPTIONLabel.Size = New System.Drawing.Size(220, 28)
        REWARD_DESCRIPTIONLabel.TabIndex = 21
        REWARD_DESCRIPTIONLabel.Text = "REWARD DESCRIPTION:"
        '
        'REWARD_DESCRIPTIONTextBox
        '
        Me.REWARD_DESCRIPTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REWARDSBindingSource, "REWARD_DESCRIPTION", True))
        Me.REWARD_DESCRIPTIONTextBox.Location = New System.Drawing.Point(271, 174)
        Me.REWARD_DESCRIPTIONTextBox.Name = "REWARD_DESCRIPTIONTextBox"
        Me.REWARD_DESCRIPTIONTextBox.Size = New System.Drawing.Size(310, 34)
        Me.REWARD_DESCRIPTIONTextBox.TabIndex = 22
        '
        'POINTS_REQLabel
        '
        POINTS_REQLabel.AutoSize = True
        POINTS_REQLabel.BackColor = System.Drawing.Color.Transparent
        POINTS_REQLabel.ForeColor = System.Drawing.Color.White
        POINTS_REQLabel.Location = New System.Drawing.Point(17, 214)
        POINTS_REQLabel.Name = "POINTS_REQLabel"
        POINTS_REQLabel.Size = New System.Drawing.Size(180, 28)
        POINTS_REQLabel.TabIndex = 23
        POINTS_REQLabel.Text = "POINTS REQUIRED:"
        '
        'POINTS_REQTextBox
        '
        Me.POINTS_REQTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REWARDSBindingSource, "POINTS_REQ", True))
        Me.POINTS_REQTextBox.Location = New System.Drawing.Point(271, 214)
        Me.POINTS_REQTextBox.Name = "POINTS_REQTextBox"
        Me.POINTS_REQTextBox.Size = New System.Drawing.Size(310, 34)
        Me.POINTS_REQTextBox.TabIndex = 24
        '
        'REWARDSDataGridView
        '
        Me.REWARDSDataGridView.AllowUserToAddRows = False
        Me.REWARDSDataGridView.AllowUserToDeleteRows = False
        Me.REWARDSDataGridView.AutoGenerateColumns = False
        Me.REWARDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.REWARDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REWARDSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.REWARDSDataGridView.DataSource = Me.REWARDSBindingSource
        Me.REWARDSDataGridView.Location = New System.Drawing.Point(12, 280)
        Me.REWARDSDataGridView.Name = "REWARDSDataGridView"
        Me.REWARDSDataGridView.ReadOnly = True
        Me.REWARDSDataGridView.RowTemplate.Height = 24
        Me.REWARDSDataGridView.Size = New System.Drawing.Size(834, 185)
        Me.REWARDSDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "REWARD_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "REWARD NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "REWARD_DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "POINTS_REQ"
        Me.DataGridViewTextBoxColumn4.HeaderText = "POINTS REQUIRED"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(627, 12)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(153, 32)
        Me.FlatButton3.TabIndex = 17
        Me.FlatButton3.Text = "Back To Main"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(812, 14)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(26, 26)
        Me.FlatButton1.TabIndex = 16
        Me.FlatButton1.Text = "x"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RewardsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 501)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RewardsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Plus - Rewards"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REWARDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.REWARDSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StationPlusDataSet As StationPlusDataSet
    Friend WithEvents REWARDSBindingSource As BindingSource
    Friend WithEvents REWARDSTableAdapter As StationPlusDataSetTableAdapters.REWARDSTableAdapter
    Friend WithEvents TableAdapterManager As StationPlusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REWARDSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents REWARDSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents REWARDSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents POINTS_REQTextBox As TextBox
    Friend WithEvents REWARD_DESCRIPTIONTextBox As TextBox
    Friend WithEvents REWARD_NAMETextBox As TextBox
    Friend WithEvents REWARD_IDLabel1 As Label
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents FlatButton11 As FlatButton
    Friend WithEvents FlatButton10 As FlatButton
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents FlatButton9 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
End Class
