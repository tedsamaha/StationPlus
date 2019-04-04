<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim USERPASSLabel As System.Windows.Forms.Label
        Dim USERNAMELabel As System.Windows.Forms.Label
        Me.FormSkin1 = New StationPlus.FormSkin()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatClose1 = New StationPlus.FlatClose()
        Me.FlatStatusBar1 = New StationPlus.FlatStatusBar()
        Me.FlatButton1 = New StationPlus.FlatButton()
        Me.USERPASSTextBox = New System.Windows.Forms.TextBox()
        Me.USERNAMETextBox = New System.Windows.Forms.TextBox()
        USERPASSLabel = New System.Windows.Forms.Label()
        USERNAMELabel = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USERPASSLabel
        '
        USERPASSLabel.AutoSize = True
        USERPASSLabel.BackColor = System.Drawing.Color.Transparent
        USERPASSLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USERPASSLabel.ForeColor = System.Drawing.Color.White
        USERPASSLabel.Location = New System.Drawing.Point(63, 274)
        USERPASSLabel.Name = "USERPASSLabel"
        USERPASSLabel.Size = New System.Drawing.Size(127, 28)
        USERPASSLabel.TabIndex = 7
        USERPASSLabel.Text = "PASSWORD:"
        '
        'USERNAMELabel
        '
        USERNAMELabel.AutoSize = True
        USERNAMELabel.BackColor = System.Drawing.Color.Transparent
        USERNAMELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USERNAMELabel.ForeColor = System.Drawing.Color.White
        USERNAMELabel.Location = New System.Drawing.Point(63, 225)
        USERNAMELabel.Name = "USERNAMELabel"
        USERNAMELabel.Size = New System.Drawing.Size(126, 28)
        USERNAMELabel.TabIndex = 5
        USERNAMELabel.Text = "USERNAME:"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(USERPASSLabel)
        Me.FormSkin1.Controls.Add(Me.USERPASSTextBox)
        Me.FormSkin1.Controls.Add(USERNAMELabel)
        Me.FormSkin1.Controls.Add(Me.USERNAMETextBox)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(642, 413)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "StationPlus - Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.StationPlus.My.Resources.Resources.STATION__login_image
        Me.PictureBox1.Location = New System.Drawing.Point(48, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(574, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(612, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 12
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 390)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(642, 23)
        Me.FlatStatusBar1.TabIndex = 11
        Me.FlatStatusBar1.Text = "Database Connection Succesfull"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(231, 331)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(181, 50)
        Me.FlatButton1.TabIndex = 10
        Me.FlatButton1.Text = "LOG IN"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'USERPASSTextBox
        '
        Me.USERPASSTextBox.Location = New System.Drawing.Point(202, 273)
        Me.USERPASSTextBox.Name = "USERPASSTextBox"
        Me.USERPASSTextBox.Size = New System.Drawing.Size(377, 34)
        Me.USERPASSTextBox.TabIndex = 8
        Me.USERPASSTextBox.UseSystemPasswordChar = True
        '
        'USERNAMETextBox
        '
        Me.USERNAMETextBox.Location = New System.Drawing.Point(202, 224)
        Me.USERNAMETextBox.Name = "USERNAMETextBox"
        Me.USERNAMETextBox.Size = New System.Drawing.Size(377, 34)
        Me.USERNAMETextBox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 413)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents USERPASSTextBox As TextBox
    Friend WithEvents USERNAMETextBox As TextBox
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents PictureBox1 As PictureBox
End Class
