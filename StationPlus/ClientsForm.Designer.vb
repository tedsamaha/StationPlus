<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientsForm
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
        Dim CLIENT_IDLabel As System.Windows.Forms.Label
        Dim CLIENT_FNLabel As System.Windows.Forms.Label
        Dim CLIENT_LNLabel As System.Windows.Forms.Label
        Dim MOBILELabel As System.Windows.Forms.Label
        Dim CORP_MOBILELabel As System.Windows.Forms.Label
        Dim WEBSITELabel As System.Windows.Forms.Label
        Dim C_ADDRESSLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientsForm))
        Me.StationPlusDataSet = New StationPlus.StationPlusDataSet()
        Me.CLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTSTableAdapter = New StationPlus.StationPlusDataSetTableAdapters.CLIENTSTableAdapter()
        Me.TableAdapterManager = New StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager()
        Me.FormSkin1 = New StationPlus.FormSkin()
        Me.CLIENT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CLIENT_FNTextBox = New System.Windows.Forms.TextBox()
        Me.CLIENT_LNTextBox = New System.Windows.Forms.TextBox()
        Me.MOBILETextBox = New System.Windows.Forms.TextBox()
        Me.CORP_MOBILETextBox = New System.Windows.Forms.TextBox()
        Me.WEBSITETextBox = New System.Windows.Forms.TextBox()
        Me.C_ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FlatButton12 = New StationPlus.FlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatButton11 = New StationPlus.FlatButton()
        Me.FlatButton10 = New StationPlus.FlatButton()
        Me.FlatButton8 = New StationPlus.FlatButton()
        Me.FlatButton7 = New StationPlus.FlatButton()
        Me.FlatButton9 = New StationPlus.FlatButton()
        Me.FlatButton4 = New StationPlus.FlatButton()
        Me.FlatButton5 = New StationPlus.FlatButton()
        Me.FlatButton6 = New StationPlus.FlatButton()
        Me.FlatStatusBar2 = New StationPlus.FlatStatusBar()
        Me.CLIENTSDataGridView = New System.Windows.Forms.DataGridView()
        Me.CLIENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTFNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTLNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOBILEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBSITEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatButton3 = New StationPlus.FlatButton()
        Me.FlatButton1 = New StationPlus.FlatButton()
        Me.FlatButton2 = New StationPlus.FlatButton()
        Me.FlatStatusBar1 = New StationPlus.FlatStatusBar()
        CLIENT_IDLabel = New System.Windows.Forms.Label()
        CLIENT_FNLabel = New System.Windows.Forms.Label()
        CLIENT_LNLabel = New System.Windows.Forms.Label()
        MOBILELabel = New System.Windows.Forms.Label()
        CORP_MOBILELabel = New System.Windows.Forms.Label()
        WEBSITELabel = New System.Windows.Forms.Label()
        C_ADDRESSLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CLIENTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StationPlusDataSet
        '
        Me.StationPlusDataSet.DataSetName = "StationPlusDataSet"
        Me.StationPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTSBindingSource
        '
        Me.CLIENTSBindingSource.DataMember = "CLIENTS"
        Me.CLIENTSBindingSource.DataSource = Me.StationPlusDataSet
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
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(CLIENT_IDLabel)
        Me.FormSkin1.Controls.Add(Me.CLIENT_IDTextBox)
        Me.FormSkin1.Controls.Add(CLIENT_FNLabel)
        Me.FormSkin1.Controls.Add(Me.CLIENT_FNTextBox)
        Me.FormSkin1.Controls.Add(CLIENT_LNLabel)
        Me.FormSkin1.Controls.Add(Me.CLIENT_LNTextBox)
        Me.FormSkin1.Controls.Add(MOBILELabel)
        Me.FormSkin1.Controls.Add(Me.MOBILETextBox)
        Me.FormSkin1.Controls.Add(CORP_MOBILELabel)
        Me.FormSkin1.Controls.Add(Me.CORP_MOBILETextBox)
        Me.FormSkin1.Controls.Add(WEBSITELabel)
        Me.FormSkin1.Controls.Add(Me.WEBSITETextBox)
        Me.FormSkin1.Controls.Add(C_ADDRESSLabel)
        Me.FormSkin1.Controls.Add(Me.C_ADDRESSTextBox)
        Me.FormSkin1.Controls.Add(EMAILLabel)
        Me.FormSkin1.Controls.Add(Me.EMAILTextBox)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.TextBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton12)
        Me.FormSkin1.Controls.Add(Me.Panel2)
        Me.FormSkin1.Controls.Add(Me.Panel1)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar2)
        Me.FormSkin1.Controls.Add(Me.CLIENTSDataGridView)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1100, 718)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Bois De Vie - Clients"
        '
        'CLIENT_IDLabel
        '
        CLIENT_IDLabel.AutoSize = True
        CLIENT_IDLabel.BackColor = System.Drawing.Color.Transparent
        CLIENT_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENT_IDLabel.ForeColor = System.Drawing.Color.White
        CLIENT_IDLabel.Location = New System.Drawing.Point(26, 71)
        CLIENT_IDLabel.Name = "CLIENT_IDLabel"
        CLIENT_IDLabel.Size = New System.Drawing.Size(107, 28)
        CLIENT_IDLabel.TabIndex = 46
        CLIENT_IDLabel.Text = "CLIENT ID:"
        '
        'CLIENT_IDTextBox
        '
        Me.CLIENT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CLIENT_ID", True))
        Me.CLIENT_IDTextBox.Location = New System.Drawing.Point(170, 68)
        Me.CLIENT_IDTextBox.Name = "CLIENT_IDTextBox"
        Me.CLIENT_IDTextBox.Size = New System.Drawing.Size(214, 34)
        Me.CLIENT_IDTextBox.TabIndex = 47
        '
        'CLIENT_FNLabel
        '
        CLIENT_FNLabel.AutoSize = True
        CLIENT_FNLabel.BackColor = System.Drawing.Color.Transparent
        CLIENT_FNLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENT_FNLabel.ForeColor = System.Drawing.Color.White
        CLIENT_FNLabel.Location = New System.Drawing.Point(26, 111)
        CLIENT_FNLabel.Name = "CLIENT_FNLabel"
        CLIENT_FNLabel.Size = New System.Drawing.Size(112, 28)
        CLIENT_FNLabel.TabIndex = 48
        CLIENT_FNLabel.Text = "CLIENT FN:"
        '
        'CLIENT_FNTextBox
        '
        Me.CLIENT_FNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CLIENT_FN", True))
        Me.CLIENT_FNTextBox.Location = New System.Drawing.Point(170, 108)
        Me.CLIENT_FNTextBox.Name = "CLIENT_FNTextBox"
        Me.CLIENT_FNTextBox.Size = New System.Drawing.Size(214, 34)
        Me.CLIENT_FNTextBox.TabIndex = 49
        '
        'CLIENT_LNLabel
        '
        CLIENT_LNLabel.AutoSize = True
        CLIENT_LNLabel.BackColor = System.Drawing.Color.Transparent
        CLIENT_LNLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENT_LNLabel.ForeColor = System.Drawing.Color.White
        CLIENT_LNLabel.Location = New System.Drawing.Point(26, 151)
        CLIENT_LNLabel.Name = "CLIENT_LNLabel"
        CLIENT_LNLabel.Size = New System.Drawing.Size(112, 28)
        CLIENT_LNLabel.TabIndex = 50
        CLIENT_LNLabel.Text = "CLIENT LN:"
        '
        'CLIENT_LNTextBox
        '
        Me.CLIENT_LNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CLIENT_LN", True))
        Me.CLIENT_LNTextBox.Location = New System.Drawing.Point(170, 148)
        Me.CLIENT_LNTextBox.Name = "CLIENT_LNTextBox"
        Me.CLIENT_LNTextBox.Size = New System.Drawing.Size(214, 34)
        Me.CLIENT_LNTextBox.TabIndex = 51
        '
        'MOBILELabel
        '
        MOBILELabel.AutoSize = True
        MOBILELabel.BackColor = System.Drawing.Color.Transparent
        MOBILELabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOBILELabel.ForeColor = System.Drawing.Color.White
        MOBILELabel.Location = New System.Drawing.Point(26, 191)
        MOBILELabel.Name = "MOBILELabel"
        MOBILELabel.Size = New System.Drawing.Size(88, 28)
        MOBILELabel.TabIndex = 52
        MOBILELabel.Text = "MOBILE:"
        '
        'MOBILETextBox
        '
        Me.MOBILETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "MOBILE", True))
        Me.MOBILETextBox.Location = New System.Drawing.Point(170, 188)
        Me.MOBILETextBox.Name = "MOBILETextBox"
        Me.MOBILETextBox.Size = New System.Drawing.Size(214, 34)
        Me.MOBILETextBox.TabIndex = 53
        '
        'CORP_MOBILELabel
        '
        CORP_MOBILELabel.AutoSize = True
        CORP_MOBILELabel.BackColor = System.Drawing.Color.Transparent
        CORP_MOBILELabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CORP_MOBILELabel.ForeColor = System.Drawing.Color.White
        CORP_MOBILELabel.Location = New System.Drawing.Point(396, 71)
        CORP_MOBILELabel.Name = "CORP_MOBILELabel"
        CORP_MOBILELabel.Size = New System.Drawing.Size(145, 28)
        CORP_MOBILELabel.TabIndex = 54
        CORP_MOBILELabel.Text = "CORP MOBILE:"
        '
        'CORP_MOBILETextBox
        '
        Me.CORP_MOBILETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "CORP_MOBILE", True))
        Me.CORP_MOBILETextBox.Location = New System.Drawing.Point(549, 68)
        Me.CORP_MOBILETextBox.Name = "CORP_MOBILETextBox"
        Me.CORP_MOBILETextBox.Size = New System.Drawing.Size(214, 34)
        Me.CORP_MOBILETextBox.TabIndex = 55
        '
        'WEBSITELabel
        '
        WEBSITELabel.AutoSize = True
        WEBSITELabel.BackColor = System.Drawing.Color.Transparent
        WEBSITELabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WEBSITELabel.ForeColor = System.Drawing.Color.White
        WEBSITELabel.Location = New System.Drawing.Point(396, 111)
        WEBSITELabel.Name = "WEBSITELabel"
        WEBSITELabel.Size = New System.Drawing.Size(96, 28)
        WEBSITELabel.TabIndex = 56
        WEBSITELabel.Text = "WEBSITE:"
        '
        'WEBSITETextBox
        '
        Me.WEBSITETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "WEBSITE", True))
        Me.WEBSITETextBox.Location = New System.Drawing.Point(549, 108)
        Me.WEBSITETextBox.Name = "WEBSITETextBox"
        Me.WEBSITETextBox.Size = New System.Drawing.Size(214, 34)
        Me.WEBSITETextBox.TabIndex = 57
        '
        'C_ADDRESSLabel
        '
        C_ADDRESSLabel.AutoSize = True
        C_ADDRESSLabel.BackColor = System.Drawing.Color.Transparent
        C_ADDRESSLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_ADDRESSLabel.ForeColor = System.Drawing.Color.White
        C_ADDRESSLabel.Location = New System.Drawing.Point(396, 151)
        C_ADDRESSLabel.Name = "C_ADDRESSLabel"
        C_ADDRESSLabel.Size = New System.Drawing.Size(102, 28)
        C_ADDRESSLabel.TabIndex = 58
        C_ADDRESSLabel.Text = "ADDRESS:"
        '
        'C_ADDRESSTextBox
        '
        Me.C_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "C_ADDRESS", True))
        Me.C_ADDRESSTextBox.Location = New System.Drawing.Point(549, 148)
        Me.C_ADDRESSTextBox.Name = "C_ADDRESSTextBox"
        Me.C_ADDRESSTextBox.Size = New System.Drawing.Size(214, 34)
        Me.C_ADDRESSTextBox.TabIndex = 59
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.BackColor = System.Drawing.Color.Transparent
        EMAILLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMAILLabel.ForeColor = System.Drawing.Color.White
        EMAILLabel.Location = New System.Drawing.Point(396, 191)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(74, 28)
        EMAILLabel.TabIndex = 60
        EMAILLabel.Text = "EMAIL:"
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTSBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(549, 188)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(214, 34)
        Me.EMAILTextBox.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 622)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Search / Filter:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 612)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(622, 34)
        Me.TextBox1.TabIndex = 45
        '
        'FlatButton12
        '
        Me.FlatButton12.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton12.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton12.Location = New System.Drawing.Point(12, 653)
        Me.FlatButton12.Name = "FlatButton12"
        Me.FlatButton12.Rounded = False
        Me.FlatButton12.Size = New System.Drawing.Size(751, 36)
        Me.FlatButton12.TabIndex = 44
        Me.FlatButton12.Text = "Reset Search"
        Me.FlatButton12.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(788, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 90)
        Me.Panel2.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "As of now you have:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatButton11)
        Me.Panel1.Controls.Add(Me.FlatButton10)
        Me.Panel1.Controls.Add(Me.FlatButton8)
        Me.Panel1.Controls.Add(Me.FlatButton7)
        Me.Panel1.Controls.Add(Me.FlatButton9)
        Me.Panel1.Controls.Add(Me.FlatButton4)
        Me.Panel1.Controls.Add(Me.FlatButton5)
        Me.Panel1.Controls.Add(Me.FlatButton6)
        Me.Panel1.Location = New System.Drawing.Point(788, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 213)
        Me.Panel1.TabIndex = 38
        '
        'FlatButton11
        '
        Me.FlatButton11.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton11.Location = New System.Drawing.Point(121, 162)
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
        Me.FlatButton10.Location = New System.Drawing.Point(27, 162)
        Me.FlatButton10.Name = "FlatButton10"
        Me.FlatButton10.Rounded = False
        Me.FlatButton10.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton10.TabIndex = 41
        Me.FlatButton10.Text = "Last"
        Me.FlatButton10.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton8.Location = New System.Drawing.Point(27, 116)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = False
        Me.FlatButton8.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton8.TabIndex = 40
        Me.FlatButton8.Text = ">"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton7
        '
        Me.FlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton7.Location = New System.Drawing.Point(27, 70)
        Me.FlatButton7.Name = "FlatButton7"
        Me.FlatButton7.Rounded = False
        Me.FlatButton7.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton7.TabIndex = 39
        Me.FlatButton7.Text = "<"
        Me.FlatButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton9
        '
        Me.FlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton9.Location = New System.Drawing.Point(27, 24)
        Me.FlatButton9.Name = "FlatButton9"
        Me.FlatButton9.Rounded = False
        Me.FlatButton9.Size = New System.Drawing.Size(67, 40)
        Me.FlatButton9.TabIndex = 38
        Me.FlatButton9.Text = "First"
        Me.FlatButton9.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(121, 24)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(143, 40)
        Me.FlatButton4.TabIndex = 33
        Me.FlatButton4.Text = "Edit"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(121, 70)
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
        Me.FlatButton6.Location = New System.Drawing.Point(121, 116)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(143, 40)
        Me.FlatButton6.TabIndex = 35
        Me.FlatButton6.Text = "Delete"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStatusBar2
        '
        Me.FlatStatusBar2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar2.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar2.Location = New System.Drawing.Point(0, 695)
        Me.FlatStatusBar2.Name = "FlatStatusBar2"
        Me.FlatStatusBar2.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar2.ShowTimeDate = False
        Me.FlatStatusBar2.Size = New System.Drawing.Size(1100, 23)
        Me.FlatStatusBar2.TabIndex = 0
        Me.FlatStatusBar2.Text = "FlatStatusBar2"
        Me.FlatStatusBar2.TextColor = System.Drawing.Color.White
        '
        'CLIENTSDataGridView
        '
        Me.CLIENTSDataGridView.AllowUserToAddRows = False
        Me.CLIENTSDataGridView.AllowUserToDeleteRows = False
        Me.CLIENTSDataGridView.AllowUserToOrderColumns = True
        Me.CLIENTSDataGridView.AutoGenerateColumns = False
        Me.CLIENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENTSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTIDDataGridViewTextBoxColumn, Me.CLIENTFNDataGridViewTextBoxColumn, Me.CLIENTLNDataGridViewTextBoxColumn, Me.MOBILEDataGridViewTextBoxColumn, Me.WEBSITEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn})
        Me.CLIENTSDataGridView.DataSource = Me.CLIENTSBindingSource
        Me.CLIENTSDataGridView.Location = New System.Drawing.Point(17, 241)
        Me.CLIENTSDataGridView.Name = "CLIENTSDataGridView"
        Me.CLIENTSDataGridView.ReadOnly = True
        Me.CLIENTSDataGridView.RowTemplate.Height = 24
        Me.CLIENTSDataGridView.Size = New System.Drawing.Size(746, 367)
        Me.CLIENTSDataGridView.TabIndex = 32
        '
        'CLIENTIDDataGridViewTextBoxColumn
        '
        Me.CLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID"
        Me.CLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID"
        Me.CLIENTIDDataGridViewTextBoxColumn.Name = "CLIENTIDDataGridViewTextBoxColumn"
        Me.CLIENTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIENTFNDataGridViewTextBoxColumn
        '
        Me.CLIENTFNDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_FN"
        Me.CLIENTFNDataGridViewTextBoxColumn.HeaderText = "CLIENT_FN"
        Me.CLIENTFNDataGridViewTextBoxColumn.Name = "CLIENTFNDataGridViewTextBoxColumn"
        Me.CLIENTFNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIENTLNDataGridViewTextBoxColumn
        '
        Me.CLIENTLNDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_LN"
        Me.CLIENTLNDataGridViewTextBoxColumn.HeaderText = "CLIENT_LN"
        Me.CLIENTLNDataGridViewTextBoxColumn.Name = "CLIENTLNDataGridViewTextBoxColumn"
        Me.CLIENTLNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MOBILEDataGridViewTextBoxColumn
        '
        Me.MOBILEDataGridViewTextBoxColumn.DataPropertyName = "MOBILE"
        Me.MOBILEDataGridViewTextBoxColumn.HeaderText = "MOBILE"
        Me.MOBILEDataGridViewTextBoxColumn.Name = "MOBILEDataGridViewTextBoxColumn"
        Me.MOBILEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WEBSITEDataGridViewTextBoxColumn
        '
        Me.WEBSITEDataGridViewTextBoxColumn.DataPropertyName = "WEBSITE"
        Me.WEBSITEDataGridViewTextBoxColumn.HeaderText = "WEBSITE"
        Me.WEBSITEDataGridViewTextBoxColumn.Name = "WEBSITEDataGridViewTextBoxColumn"
        Me.WEBSITEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(869, 10)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(153, 32)
        Me.FlatButton3.TabIndex = 13
        Me.FlatButton3.Text = "Back To Main"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(1054, 12)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(26, 26)
        Me.FlatButton1.TabIndex = 12
        Me.FlatButton1.Text = "x"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Red
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(1026, 12)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(30, 25)
        Me.FlatButton2.TabIndex = 12
        Me.FlatButton2.Text = "X"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 658)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(1068, 23)
        Me.FlatStatusBar1.TabIndex = 13
        Me.FlatStatusBar1.Text = "FlatStatusBar1"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'ClientsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 718)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClientsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bois De Vie - Clients"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.CLIENTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents StationPlusDataSet As StationPlusDataSet
    Friend WithEvents CLIENTSBindingSource As BindingSource
    Friend WithEvents CLIENTSTableAdapter As StationPlusDataSetTableAdapters.CLIENTSTableAdapter
    Friend WithEvents TableAdapterManager As StationPlusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents FlatStatusBar2 As FlatStatusBar
    Friend WithEvents FlatButton6 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatButton10 As FlatButton
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents FlatButton9 As FlatButton
    Friend WithEvents FlatButton11 As FlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FlatButton12 As FlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents CLIENTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTFNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTLNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOBILEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WEBSITEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENT_IDTextBox As TextBox
    Friend WithEvents CLIENT_FNTextBox As TextBox
    Friend WithEvents CLIENT_LNTextBox As TextBox
    Friend WithEvents MOBILETextBox As TextBox
    Friend WithEvents CORP_MOBILETextBox As TextBox
    Friend WithEvents WEBSITETextBox As TextBox
    Friend WithEvents C_ADDRESSTextBox As TextBox
    Friend WithEvents EMAILTextBox As TextBox
End Class
