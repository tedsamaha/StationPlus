<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Dim ITEM_IDLabel As System.Windows.Forms.Label
        Dim ITEM_NAMELabel As System.Windows.Forms.Label
        Dim UNITLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim INITIAL_STOCKLabel As System.Windows.Forms.Label
        Dim CURRENT_STOCKLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.FormSkin1 = New StationPlus.FormSkin()
        Me.ITEM_IDLabel2 = New System.Windows.Forms.Label()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationPlusDataSet = New StationPlus.StationPlusDataSet()
        Me.ITEM_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.UNITTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.INITIAL_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.CURRENT_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.INVENTORYDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatButton2 = New StationPlus.FlatButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlatStatusBar1 = New StationPlus.FlatStatusBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlatButton16 = New StationPlus.FlatButton()
        Me.FlatButton15 = New StationPlus.FlatButton()
        Me.FlatButton14 = New StationPlus.FlatButton()
        Me.FlatButton13 = New StationPlus.FlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.INVENTORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.ITEMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INITIALSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENTSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatButton11 = New StationPlus.FlatButton()
        Me.FlatButton10 = New StationPlus.FlatButton()
        Me.FlatButton8 = New StationPlus.FlatButton()
        Me.FlatButton7 = New StationPlus.FlatButton()
        Me.FlatButton9 = New StationPlus.FlatButton()
        Me.FlatButton4 = New StationPlus.FlatButton()
        Me.FlatButton5 = New StationPlus.FlatButton()
        Me.FlatButton6 = New StationPlus.FlatButton()
        Me.FlatButton3 = New StationPlus.FlatButton()
        Me.FlatButton1 = New StationPlus.FlatButton()
        Me.INVENTORYTableAdapter = New StationPlus.StationPlusDataSetTableAdapters.INVENTORYTableAdapter()
        Me.TableAdapterManager = New StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager()
        ITEM_IDLabel = New System.Windows.Forms.Label()
        ITEM_NAMELabel = New System.Windows.Forms.Label()
        UNITLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        INITIAL_STOCKLabel = New System.Windows.Forms.Label()
        CURRENT_STOCKLabel = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.INVENTORYDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.INVENTORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ITEM_IDLabel
        '
        ITEM_IDLabel.AutoSize = True
        ITEM_IDLabel.BackColor = System.Drawing.Color.Transparent
        ITEM_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ITEM_IDLabel.ForeColor = System.Drawing.Color.White
        ITEM_IDLabel.Location = New System.Drawing.Point(17, 76)
        ITEM_IDLabel.Name = "ITEM_IDLabel"
        ITEM_IDLabel.Size = New System.Drawing.Size(88, 28)
        ITEM_IDLabel.TabIndex = 39
        ITEM_IDLabel.Text = "ITEM ID:"
        '
        'ITEM_NAMELabel
        '
        ITEM_NAMELabel.AutoSize = True
        ITEM_NAMELabel.BackColor = System.Drawing.Color.Transparent
        ITEM_NAMELabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ITEM_NAMELabel.ForeColor = System.Drawing.Color.White
        ITEM_NAMELabel.Location = New System.Drawing.Point(17, 116)
        ITEM_NAMELabel.Name = "ITEM_NAMELabel"
        ITEM_NAMELabel.Size = New System.Drawing.Size(124, 28)
        ITEM_NAMELabel.TabIndex = 41
        ITEM_NAMELabel.Text = "ITEM NAME:"
        '
        'UNITLabel
        '
        UNITLabel.AutoSize = True
        UNITLabel.BackColor = System.Drawing.Color.Transparent
        UNITLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UNITLabel.ForeColor = System.Drawing.Color.White
        UNITLabel.Location = New System.Drawing.Point(17, 156)
        UNITLabel.Name = "UNITLabel"
        UNITLabel.Size = New System.Drawing.Size(63, 28)
        UNITLabel.TabIndex = 43
        UNITLabel.Text = "UNIT:"
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.BackColor = System.Drawing.Color.Transparent
        UNIT_PRICELabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UNIT_PRICELabel.ForeColor = System.Drawing.Color.White
        UNIT_PRICELabel.Location = New System.Drawing.Point(383, 76)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(121, 28)
        UNIT_PRICELabel.TabIndex = 45
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'INITIAL_STOCKLabel
        '
        INITIAL_STOCKLabel.AutoSize = True
        INITIAL_STOCKLabel.BackColor = System.Drawing.Color.Transparent
        INITIAL_STOCKLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        INITIAL_STOCKLabel.ForeColor = System.Drawing.Color.White
        INITIAL_STOCKLabel.Location = New System.Drawing.Point(383, 116)
        INITIAL_STOCKLabel.Name = "INITIAL_STOCKLabel"
        INITIAL_STOCKLabel.Size = New System.Drawing.Size(150, 28)
        INITIAL_STOCKLabel.TabIndex = 47
        INITIAL_STOCKLabel.Text = "INITIAL STOCK:"
        '
        'CURRENT_STOCKLabel
        '
        CURRENT_STOCKLabel.AutoSize = True
        CURRENT_STOCKLabel.BackColor = System.Drawing.Color.Transparent
        CURRENT_STOCKLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CURRENT_STOCKLabel.ForeColor = System.Drawing.Color.White
        CURRENT_STOCKLabel.Location = New System.Drawing.Point(383, 156)
        CURRENT_STOCKLabel.Name = "CURRENT_STOCKLabel"
        CURRENT_STOCKLabel.Size = New System.Drawing.Size(169, 28)
        CURRENT_STOCKLabel.TabIndex = 49
        CURRENT_STOCKLabel.Text = "CURRENT STOCK:"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.ITEM_IDLabel2)
        Me.FormSkin1.Controls.Add(Me.ITEM_NAMETextBox)
        Me.FormSkin1.Controls.Add(Me.UNITTextBox)
        Me.FormSkin1.Controls.Add(Me.UNIT_PRICETextBox)
        Me.FormSkin1.Controls.Add(Me.INITIAL_STOCKTextBox)
        Me.FormSkin1.Controls.Add(Me.CURRENT_STOCKTextBox)
        Me.FormSkin1.Controls.Add(Me.Panel4)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.Panel3)
        Me.FormSkin1.Controls.Add(Me.Panel2)
        Me.FormSkin1.Controls.Add(Me.INVENTORYDataGridView)
        Me.FormSkin1.Controls.Add(ITEM_IDLabel)
        Me.FormSkin1.Controls.Add(ITEM_NAMELabel)
        Me.FormSkin1.Controls.Add(UNITLabel)
        Me.FormSkin1.Controls.Add(UNIT_PRICELabel)
        Me.FormSkin1.Controls.Add(INITIAL_STOCKLabel)
        Me.FormSkin1.Controls.Add(CURRENT_STOCKLabel)
        Me.FormSkin1.Controls.Add(Me.Panel1)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1110, 1012)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "StationPlus - Inventory"
        '
        'ITEM_IDLabel2
        '
        Me.ITEM_IDLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ITEM_IDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ITEM_IDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVENTORYBindingSource, "ITEM_ID", True))
        Me.ITEM_IDLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.ITEM_IDLabel2.Location = New System.Drawing.Point(145, 68)
        Me.ITEM_IDLabel2.Name = "ITEM_IDLabel2"
        Me.ITEM_IDLabel2.Size = New System.Drawing.Size(220, 36)
        Me.ITEM_IDLabel2.TabIndex = 55
        Me.ITEM_IDLabel2.Text = "Label5"
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.StationPlusDataSet
        '
        'StationPlusDataSet
        '
        Me.StationPlusDataSet.DataSetName = "StationPlusDataSet"
        Me.StationPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ITEM_NAMETextBox
        '
        Me.ITEM_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVENTORYBindingSource, "ITEM_NAME", True))
        Me.ITEM_NAMETextBox.Location = New System.Drawing.Point(145, 113)
        Me.ITEM_NAMETextBox.Name = "ITEM_NAMETextBox"
        Me.ITEM_NAMETextBox.Size = New System.Drawing.Size(220, 34)
        Me.ITEM_NAMETextBox.TabIndex = 57
        '
        'UNITTextBox
        '
        Me.UNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVENTORYBindingSource, "UNIT", True))
        Me.UNITTextBox.Location = New System.Drawing.Point(145, 153)
        Me.UNITTextBox.Name = "UNITTextBox"
        Me.UNITTextBox.Size = New System.Drawing.Size(220, 34)
        Me.UNITTextBox.TabIndex = 59
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVENTORYBindingSource, "UNIT_PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(560, 76)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(221, 34)
        Me.UNIT_PRICETextBox.TabIndex = 61
        '
        'INITIAL_STOCKTextBox
        '
        Me.INITIAL_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVENTORYBindingSource, "INITIAL_STOCK", True))
        Me.INITIAL_STOCKTextBox.Location = New System.Drawing.Point(560, 116)
        Me.INITIAL_STOCKTextBox.Name = "INITIAL_STOCKTextBox"
        Me.INITIAL_STOCKTextBox.Size = New System.Drawing.Size(221, 34)
        Me.INITIAL_STOCKTextBox.TabIndex = 63
        '
        'CURRENT_STOCKTextBox
        '
        Me.CURRENT_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVENTORYBindingSource, "CURRENT_STOCK", True))
        Me.CURRENT_STOCKTextBox.Location = New System.Drawing.Point(560, 156)
        Me.CURRENT_STOCKTextBox.Name = "CURRENT_STOCKTextBox"
        Me.CURRENT_STOCKTextBox.Size = New System.Drawing.Size(221, 34)
        Me.CURRENT_STOCKTextBox.TabIndex = 65
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel4.Controls.Add(Me.INVENTORYDataGridView1)
        Me.Panel4.Controls.Add(Me.FlatButton2)
        Me.Panel4.Controls.Add(Me.RadioButton4)
        Me.Panel4.Controls.Add(Me.RadioButton3)
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(14, 525)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1072, 331)
        Me.Panel4.TabIndex = 54
        '
        'INVENTORYDataGridView1
        '
        Me.INVENTORYDataGridView1.AllowUserToAddRows = False
        Me.INVENTORYDataGridView1.AllowUserToDeleteRows = False
        Me.INVENTORYDataGridView1.AllowUserToOrderColumns = True
        Me.INVENTORYDataGridView1.AutoGenerateColumns = False
        Me.INVENTORYDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.INVENTORYDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INVENTORYDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.INVENTORYDataGridView1.DataSource = Me.INVENTORYBindingSource
        Me.INVENTORYDataGridView1.Location = New System.Drawing.Point(17, 141)
        Me.INVENTORYDataGridView1.Name = "INVENTORYDataGridView1"
        Me.INVENTORYDataGridView1.ReadOnly = True
        Me.INVENTORYDataGridView1.RowTemplate.Height = 24
        Me.INVENTORYDataGridView1.Size = New System.Drawing.Size(1046, 176)
        Me.INVENTORYDataGridView1.TabIndex = 8
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ITEM_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ITEM_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ITEM_NAME"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ITEM_NAME"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UNIT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UNIT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UNIT_PRICE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "UNIT_PRICE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "INITIAL_STOCK"
        Me.DataGridViewTextBoxColumn11.HeaderText = "INITIAL_STOCK"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CURRENT_STOCK"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CURRENT_STOCK"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(916, 54)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(147, 34)
        Me.FlatButton2.TabIndex = 8
        Me.FlatButton2.Text = "Reset Search"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(464, 103)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(182, 32)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "CURRENT STOCK"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(339, 103)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(83, 32)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "PRICE"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(160, 103)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(137, 32)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ITEM NAME"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(18, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 32)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ITEM ID"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(892, 34)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Custom Search:"
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 989)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(1110, 23)
        Me.FlatStatusBar1.TabIndex = 53
        Me.FlatStatusBar1.Text = "FlatStatusBar1"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.FlatButton16)
        Me.Panel3.Controls.Add(Me.FlatButton15)
        Me.Panel3.Controls.Add(Me.FlatButton14)
        Me.Panel3.Controls.Add(Me.FlatButton13)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(802, 388)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 131)
        Me.Panel3.TabIndex = 52
        '
        'FlatButton16
        '
        Me.FlatButton16.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton16.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton16.Location = New System.Drawing.Point(25, 49)
        Me.FlatButton16.Name = "FlatButton16"
        Me.FlatButton16.Rounded = False
        Me.FlatButton16.Size = New System.Drawing.Size(106, 28)
        Me.FlatButton16.TabIndex = 6
        Me.FlatButton16.Text = "Default"
        Me.FlatButton16.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton15
        '
        Me.FlatButton15.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton15.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton15.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton15.Location = New System.Drawing.Point(152, 87)
        Me.FlatButton15.Name = "FlatButton15"
        Me.FlatButton15.Rounded = False
        Me.FlatButton15.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton15.TabIndex = 5
        Me.FlatButton15.Text = "CURRENT STOCK"
        Me.FlatButton15.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton14
        '
        Me.FlatButton14.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton14.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton14.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton14.Location = New System.Drawing.Point(25, 87)
        Me.FlatButton14.Name = "FlatButton14"
        Me.FlatButton14.Rounded = False
        Me.FlatButton14.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton14.TabIndex = 4
        Me.FlatButton14.Text = "UNIT PRICE"
        Me.FlatButton14.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton13
        '
        Me.FlatButton13.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton13.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton13.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton13.Location = New System.Drawing.Point(152, 45)
        Me.FlatButton13.Name = "FlatButton13"
        Me.FlatButton13.Rounded = False
        Me.FlatButton13.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton13.TabIndex = 3
        Me.FlatButton13.Text = "ITEM NAME"
        Me.FlatButton13.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Order By:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(802, 292)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 90)
        Me.Panel2.TabIndex = 51
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
        'INVENTORYDataGridView
        '
        Me.INVENTORYDataGridView.AllowUserToAddRows = False
        Me.INVENTORYDataGridView.AllowUserToOrderColumns = True
        Me.INVENTORYDataGridView.AutoGenerateColumns = False
        Me.INVENTORYDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.INVENTORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INVENTORYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMNAMEDataGridViewTextBoxColumn, Me.UNITDataGridViewTextBoxColumn, Me.UNITPRICEDataGridViewTextBoxColumn, Me.INITIALSTOCKDataGridViewTextBoxColumn, Me.CURRENTSTOCKDataGridViewTextBoxColumn})
        Me.INVENTORYDataGridView.DataSource = Me.INVENTORYBindingSource
        Me.INVENTORYDataGridView.Location = New System.Drawing.Point(12, 213)
        Me.INVENTORYDataGridView.Name = "INVENTORYDataGridView"
        Me.INVENTORYDataGridView.ReadOnly = True
        Me.INVENTORYDataGridView.RowTemplate.Height = 24
        Me.INVENTORYDataGridView.Size = New System.Drawing.Size(769, 306)
        Me.INVENTORYDataGridView.TabIndex = 50
        '
        'ITEMNAMEDataGridViewTextBoxColumn
        '
        Me.ITEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_NAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.Name = "ITEMNAMEDataGridViewTextBoxColumn"
        Me.ITEMNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UNITDataGridViewTextBoxColumn
        '
        Me.UNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT"
        Me.UNITDataGridViewTextBoxColumn.HeaderText = "UNIT"
        Me.UNITDataGridViewTextBoxColumn.Name = "UNITDataGridViewTextBoxColumn"
        Me.UNITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UNITPRICEDataGridViewTextBoxColumn
        '
        Me.UNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.HeaderText = "PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.Name = "UNITPRICEDataGridViewTextBoxColumn"
        Me.UNITPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INITIALSTOCKDataGridViewTextBoxColumn
        '
        Me.INITIALSTOCKDataGridViewTextBoxColumn.DataPropertyName = "INITIAL_STOCK"
        Me.INITIALSTOCKDataGridViewTextBoxColumn.HeaderText = "INITIAL STOCK"
        Me.INITIALSTOCKDataGridViewTextBoxColumn.Name = "INITIALSTOCKDataGridViewTextBoxColumn"
        Me.INITIALSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CURRENTSTOCKDataGridViewTextBoxColumn
        '
        Me.CURRENTSTOCKDataGridViewTextBoxColumn.DataPropertyName = "CURRENT_STOCK"
        Me.CURRENTSTOCKDataGridViewTextBoxColumn.HeaderText = "CURRENT STOCK"
        Me.CURRENTSTOCKDataGridViewTextBoxColumn.Name = "CURRENTSTOCKDataGridViewTextBoxColumn"
        Me.CURRENTSTOCKDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.Panel1.Location = New System.Drawing.Point(802, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 213)
        Me.Panel1.TabIndex = 39
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
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(879, 7)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(153, 32)
        Me.FlatButton3.TabIndex = 15
        Me.FlatButton3.Text = "Back To Main"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(1064, 9)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(26, 26)
        Me.FlatButton1.TabIndex = 14
        Me.FlatButton1.Text = "x"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYTableAdapter = Me.INVENTORYTableAdapter
        Me.TableAdapterManager.POINTSTableAdapter = Nothing
        Me.TableAdapterManager.REWARDSTableAdapter = Nothing
        Me.TableAdapterManager.SPLUS_USERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StationPlus.StationPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 1012)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StationPlus - Inventory"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationPlusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.INVENTORYDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.INVENTORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatButton11 As FlatButton
    Friend WithEvents FlatButton10 As FlatButton
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents FlatButton9 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
    Friend WithEvents StationPlusDataSet As StationPlusDataSet
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As StationPlusDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents TableAdapterManager As StationPlusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents INVENTORYDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents FlatButton15 As FlatButton
    Friend WithEvents FlatButton14 As FlatButton
    Friend WithEvents FlatButton13 As FlatButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents INVENTORYDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents FlatButton16 As FlatButton
    Friend WithEvents ITEM_IDLabel2 As Label
    Friend WithEvents ITEM_NAMETextBox As TextBox
    Friend WithEvents UNITTextBox As TextBox
    Friend WithEvents UNIT_PRICETextBox As TextBox
    Friend WithEvents INITIAL_STOCKTextBox As TextBox
    Friend WithEvents CURRENT_STOCKTextBox As TextBox
    Friend WithEvents ITEMNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INITIALSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CURRENTSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
