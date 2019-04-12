<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoyaltyForm
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
        Dim CLIENT_IDLabel As System.Windows.Forms.Label
        Dim CLIENT_FNLabel As System.Windows.Forms.Label
        Dim CLIENT_LNLabel As System.Windows.Forms.Label
        Dim MOBILELabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.FormSkin1 = New StationPlus.FormSkin()
        Me.FlatButton4 = New StationPlus.FlatButton()
        Me.FlatButton2 = New StationPlus.FlatButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CLIENTSComboBox = New System.Windows.Forms.ComboBox()
        Me.CLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationPlusDataSet = New StationPlus.StationPlusDataSet()
        Me.FlatStatusBar1 = New StationPlus.FlatStatusBar()
        Me.FlatButton3 = New StationPlus.FlatButton()
        Me.FlatButton1 = New StationPlus.FlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EMAILLabel1 = New System.Windows.Forms.Label()
        Me.CLIENT_IDLabel1 = New System.Windows.Forms.Label()
        Me.MOBILELabel1 = New System.Windows.Forms.Label()
        Me.CLIENT_FNLabel1 = New System.Windows.Forms.Label()
        Me.CLIENT_LNLabel1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CLIENTSTableAdapter = New StationPlus.StationPlusDataSetTableAdapters.CLIENTSTableAdapter()
        Me.TableAdapterManager = New StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager()
        CLIENT_IDLabel = New System.Windows.Forms.Label()
        CLIENT_FNLabel = New System.Windows.Forms.Label()
        CLIENT_LNLabel = New System.Windows.Forms.Label()
        MOBILELabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLIENT_IDLabel
        '
        CLIENT_IDLabel.AutoSize = True
        CLIENT_IDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENT_IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        CLIENT_IDLabel.Location = New System.Drawing.Point(194, 25)
        CLIENT_IDLabel.Name = "CLIENT_IDLabel"
        CLIENT_IDLabel.Size = New System.Drawing.Size(111, 28)
        CLIENT_IDLabel.TabIndex = 55
        CLIENT_IDLabel.Text = "CLIENT ID:"
        '
        'CLIENT_FNLabel
        '
        CLIENT_FNLabel.AutoSize = True
        CLIENT_FNLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENT_FNLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        CLIENT_FNLabel.Location = New System.Drawing.Point(194, 90)
        CLIENT_FNLabel.Name = "CLIENT_FNLabel"
        CLIENT_FNLabel.Size = New System.Drawing.Size(73, 28)
        CLIENT_FNLabel.TabIndex = 57
        CLIENT_FNLabel.Text = "Name:"
        '
        'CLIENT_LNLabel
        '
        CLIENT_LNLabel.AutoSize = True
        CLIENT_LNLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENT_LNLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        CLIENT_LNLabel.Location = New System.Drawing.Point(194, 127)
        CLIENT_LNLabel.Name = "CLIENT_LNLabel"
        CLIENT_LNLabel.Size = New System.Drawing.Size(117, 28)
        CLIENT_LNLabel.TabIndex = 59
        CLIENT_LNLabel.Text = "Last Name:"
        '
        'MOBILELabel
        '
        MOBILELabel.AutoSize = True
        MOBILELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOBILELabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        MOBILELabel.Location = New System.Drawing.Point(440, 85)
        MOBILELabel.Name = "MOBILELabel"
        MOBILELabel.Size = New System.Drawing.Size(91, 28)
        MOBILELabel.TabIndex = 61
        MOBILELabel.Text = "MOBILE:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMAILLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        EMAILLabel.Location = New System.Drawing.Point(440, 127)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(77, 28)
        EMAILLabel.TabIndex = 63
        EMAILLabel.Text = "EMAIL:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Label2.Location = New System.Drawing.Point(303, 169)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(109, 32)
        Label2.TabIndex = 66
        Label2.Text = "POINTS:"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.DataGridView1)
        Me.FormSkin1.Controls.Add(Me.GroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.Panel3)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(820, 662)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Station Plus - Loyalty Program"
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(414, 442)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(386, 32)
        Me.FlatButton4.TabIndex = 70
        Me.FlatButton4.Text = "Export Loyalty Card"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(22, 442)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(386, 32)
        Me.FlatButton2.TabIndex = 69
        Me.FlatButton2.Text = "Show Available Rewards"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 483)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(778, 150)
        Me.DataGridView1.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CLIENTSComboBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(22, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 100)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Your Customer"
        '
        'CLIENTSComboBox
        '
        Me.CLIENTSComboBox.DataSource = Me.CLIENTSBindingSource
        Me.CLIENTSComboBox.DisplayMember = "CLIENT_FN"
        Me.CLIENTSComboBox.FormattingEnabled = True
        Me.CLIENTSComboBox.Location = New System.Drawing.Point(8, 43)
        Me.CLIENTSComboBox.Name = "CLIENTSComboBox"
        Me.CLIENTSComboBox.Size = New System.Drawing.Size(763, 36)
        Me.CLIENTSComboBox.TabIndex = 55
        Me.CLIENTSComboBox.ValueMember = "CLIENT_ID"
        '
        'CLIENTSBindingSource
        '
        Me.CLIENTSBindingSource.DataMember = "CLIENTS"
        Me.CLIENTSBindingSource.DataSource = Me.StationPlusDataSet
        '
        'StationPlusDataSet
        '
        Me.StationPlusDataSet.DataSetName = "StationPlusDataSet"
        Me.StationPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 639)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(820, 23)
        Me.FlatStatusBar1.TabIndex = 55
        Me.FlatStatusBar1.Text = "FlatStatusBar1"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(590, 10)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(153, 32)
        Me.FlatButton3.TabIndex = 19
        Me.FlatButton3.Text = "Back To Main"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(774, 12)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(26, 26)
        Me.FlatButton1.TabIndex = 18
        Me.FlatButton1.Text = "x"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(3, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(814, 276)
        Me.Panel3.TabIndex = 71
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(CLIENT_IDLabel)
        Me.Panel1.Controls.Add(Me.EMAILLabel1)
        Me.Panel1.Controls.Add(EMAILLabel)
        Me.Panel1.Controls.Add(Me.CLIENT_IDLabel1)
        Me.Panel1.Controls.Add(Me.MOBILELabel1)
        Me.Panel1.Controls.Add(CLIENT_FNLabel)
        Me.Panel1.Controls.Add(MOBILELabel)
        Me.Panel1.Controls.Add(Me.CLIENT_FNLabel1)
        Me.Panel1.Controls.Add(Me.CLIENT_LNLabel1)
        Me.Panel1.Controls.Add(CLIENT_LNLabel)
        Me.Panel1.Location = New System.Drawing.Point(19, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 212)
        Me.Panel1.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(418, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Label4"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.StationPlus.My.Resources.Resources.avatar
        Me.PictureBox1.Location = New System.Drawing.Point(13, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'EMAILLabel1
        '
        Me.EMAILLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "EMAIL", True))
        Me.EMAILLabel1.ForeColor = System.Drawing.Color.White
        Me.EMAILLabel1.Location = New System.Drawing.Point(546, 127)
        Me.EMAILLabel1.Name = "EMAILLabel1"
        Me.EMAILLabel1.Size = New System.Drawing.Size(225, 23)
        Me.EMAILLabel1.TabIndex = 64
        Me.EMAILLabel1.Text = "Label1"
        '
        'CLIENT_IDLabel1
        '
        Me.CLIENT_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CLIENT_ID", True))
        Me.CLIENT_IDLabel1.ForeColor = System.Drawing.Color.White
        Me.CLIENT_IDLabel1.Location = New System.Drawing.Point(194, 53)
        Me.CLIENT_IDLabel1.Name = "CLIENT_IDLabel1"
        Me.CLIENT_IDLabel1.Size = New System.Drawing.Size(100, 31)
        Me.CLIENT_IDLabel1.TabIndex = 56
        Me.CLIENT_IDLabel1.Text = "Label1"
        '
        'MOBILELabel1
        '
        Me.MOBILELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "MOBILE", True))
        Me.MOBILELabel1.ForeColor = System.Drawing.Color.White
        Me.MOBILELabel1.Location = New System.Drawing.Point(546, 85)
        Me.MOBILELabel1.Name = "MOBILELabel1"
        Me.MOBILELabel1.Size = New System.Drawing.Size(225, 23)
        Me.MOBILELabel1.TabIndex = 62
        Me.MOBILELabel1.Text = "Label1"
        '
        'CLIENT_FNLabel1
        '
        Me.CLIENT_FNLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CLIENT_FN", True))
        Me.CLIENT_FNLabel1.ForeColor = System.Drawing.Color.White
        Me.CLIENT_FNLabel1.Location = New System.Drawing.Point(321, 90)
        Me.CLIENT_FNLabel1.Name = "CLIENT_FNLabel1"
        Me.CLIENT_FNLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CLIENT_FNLabel1.TabIndex = 58
        Me.CLIENT_FNLabel1.Text = "Label1"
        '
        'CLIENT_LNLabel1
        '
        Me.CLIENT_LNLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CLIENT_LN", True))
        Me.CLIENT_LNLabel1.ForeColor = System.Drawing.Color.White
        Me.CLIENT_LNLabel1.Location = New System.Drawing.Point(321, 127)
        Me.CLIENT_LNLabel1.Name = "CLIENT_LNLabel1"
        Me.CLIENT_LNLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CLIENT_LNLabel1.TabIndex = 60
        Me.CLIENT_LNLabel1.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(19, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 48)
        Me.Panel2.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(240, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 38)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "LOYALTY CARD"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StationPlus.My.Resources.Resources.STATION__logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, -20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(234, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'CLIENTSTableAdapter
        '
        Me.CLIENTSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTSTableAdapter = Me.CLIENTSTableAdapter
        Me.TableAdapterManager.INVENTORYTableAdapter = Nothing
        Me.TableAdapterManager.POINTSTableAdapter = Nothing
        Me.TableAdapterManager.REWARDSTableAdapter = Nothing
        Me.TableAdapterManager.SPLUS_USERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoyaltyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 662)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoyaltyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Plus - Loyalty Program"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents StationPlusDataSet As StationPlusDataSet
    Friend WithEvents CLIENTSBindingSource As BindingSource
    Friend WithEvents CLIENTSTableAdapter As StationPlusDataSetTableAdapters.CLIENTSTableAdapter
    Friend WithEvents TableAdapterManager As StationPlusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CLIENTSComboBox As ComboBox
    Friend WithEvents CLIENT_IDLabel1 As Label
    Friend WithEvents CLIENT_FNLabel1 As Label
    Friend WithEvents CLIENT_LNLabel1 As Label
    Friend WithEvents MOBILELabel1 As Label
    Friend WithEvents EMAILLabel1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents Panel3 As Panel
End Class
