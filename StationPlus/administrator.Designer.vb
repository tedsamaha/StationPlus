<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrator))
        Me.FormSkin1 = New StationPlus.FormSkin()
        Me.SPLUS_USERSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPLUS_USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationPlusDataSet = New StationPlus.StationPlusDataSet()
        Me.FlatButton3 = New StationPlus.FlatButton()
        Me.FlatButton2 = New StationPlus.FlatButton()
        Me.FlatLabel2 = New StationPlus.FlatLabel()
        Me.FlatLabel1 = New StationPlus.FlatLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatButton1 = New StationPlus.FlatButton()
        Me.FlatLabel4 = New StationPlus.FlatLabel()
        Me.FlatLabel3 = New StationPlus.FlatLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BDV_USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPLUS_USERSTableAdapter = New StationPlus.StationPlusDataSetTableAdapters.SPLUS_USERSTableAdapter()
        Me.TableAdapterManager = New StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager()
        Me.FormSkin1.SuspendLayout()
        CType(Me.SPLUS_USERSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPLUS_USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BDV_USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.SPLUS_USERSDataGridView)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.GroupBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(460, 531)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "StationPlus - Admin Control Pannel"
        '
        'SPLUS_USERSDataGridView
        '
        Me.SPLUS_USERSDataGridView.AutoGenerateColumns = False
        Me.SPLUS_USERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SPLUS_USERSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SPLUS_USERSDataGridView.DataSource = Me.SPLUS_USERSBindingSource
        Me.SPLUS_USERSDataGridView.Location = New System.Drawing.Point(16, 264)
        Me.SPLUS_USERSDataGridView.Name = "SPLUS_USERSDataGridView"
        Me.SPLUS_USERSDataGridView.RowTemplate.Height = 24
        Me.SPLUS_USERSDataGridView.Size = New System.Drawing.Size(427, 220)
        Me.SPLUS_USERSDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "USERNAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "USERNAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "USERPASS"
        Me.DataGridViewTextBoxColumn2.HeaderText = "USERPASS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ISADMIN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ISADMIN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'SPLUS_USERSBindingSource
        '
        Me.SPLUS_USERSBindingSource.DataMember = "SPLUS_USERS"
        Me.SPLUS_USERSBindingSource.DataSource = Me.StationPlusDataSet
        '
        'StationPlusDataSet
        '
        Me.StationPlusDataSet.DataSetName = "StationPlusDataSet"
        Me.StationPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.Red
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(428, 6)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(26, 26)
        Me.FlatButton3.TabIndex = 24
        Me.FlatButton3.Text = "x"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(339, 499)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(106, 25)
        Me.FlatButton2.TabIndex = 23
        Me.FlatButton2.Text = "Commit"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(12, 230)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(164, 19)
        Me.FlatLabel2.TabIndex = 14
        Me.FlatLabel2.Text = "CURRENT SYSTEM USERS"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(5, 500)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(332, 19)
        Me.FlatLabel1.TabIndex = 13
        Me.FlatLabel1.Text = "*TIP: You can delete entries by pressing the 'DEL' key"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.FlatButton1)
        Me.GroupBox1.Controls.Add(Me.FlatLabel4)
        Me.GroupBox1.Controls.Add(Me.FlatLabel3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 160)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add User:"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(301, 116)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton1.TabIndex = 22
        Me.FlatButton1.Text = "Save"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(13, 84)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(70, 19)
        Me.FlatLabel4.TabIndex = 21
        Me.FlatLabel4.Text = "Password:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(13, 44)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(74, 19)
        Me.FlatLabel3.TabIndex = 15
        Me.FlatLabel3.Text = "Username:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(314, 34)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 34)
        Me.TextBox1.TabIndex = 19
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(17, 116)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(209, 32)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Grant Administartor"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BDV_USERSBindingSource
        '
        Me.BDV_USERSBindingSource.DataMember = "BDV_USERS"
        '
        'SPLUS_USERSTableAdapter
        '
        Me.SPLUS_USERSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYTableAdapter = Nothing
        Me.TableAdapterManager.POINTSTableAdapter = Nothing
        Me.TableAdapterManager.REWARDSTableAdapter = Nothing
        Me.TableAdapterManager.SPLUS_USERSTableAdapter = Me.SPLUS_USERSTableAdapter
        Me.TableAdapterManager.UpdateOrder = StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 531)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "administrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StationPlus - Administartor"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.SPLUS_USERSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPLUS_USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BDV_USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents BDV_USERSBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents StationPlusDataSet As StationPlusDataSet
    Friend WithEvents SPLUS_USERSBindingSource As BindingSource
    Friend WithEvents SPLUS_USERSTableAdapter As StationPlusDataSetTableAdapters.SPLUS_USERSTableAdapter
    Friend WithEvents TableAdapterManager As StationPlusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SPLUS_USERSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
