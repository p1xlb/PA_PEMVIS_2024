<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManager))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbStasiun = New System.Windows.Forms.ComboBox()
        Me.dtpPerawatan = New System.Windows.Forms.DateTimePicker()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJarak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBaterai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenID = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.EM = New System.Windows.Forms.PictureBox()
        Me.CVX = New System.Windows.Forms.PictureBox()
        Me.VX = New System.Windows.Forms.PictureBox()
        Me.VR5 = New System.Windows.Forms.PictureBox()
        Me.cbTipeSepeda = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtKodeSepeda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnTersedia = New System.Windows.Forms.RadioButton()
        Me.rbtnDisewa = New System.Windows.Forms.RadioButton()
        Me.rbtnDiperbaiki = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.EM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CVX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VR5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kapasitas Baterai"
        '
        'Column5
        '
        Me.Column5.FillWeight = 104.4832!
        Me.Column5.HeaderText = "Jarak Tempuh"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FillWeight = 104.4832!
        Me.Column6.HeaderText = "tarif (/hari)"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 104.4832!
        Me.Column7.HeaderText = "Status"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 104.4832!
        Me.Column8.HeaderText = "Tanggal Perawatan Terakhir"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.FillWeight = 104.4832!
        Me.Column9.HeaderText = "ID Stasiun"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.FillWeight = 109.4985!
        Me.Edit.HeaderText = "Edit"
        Me.Edit.MinimumWidth = 6
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'Update
        '
        Me.Update.FillWeight = 89.2389!
        Me.Update.HeaderText = "Update"
        Me.Update.MinimumWidth = 6
        Me.Update.Name = "Update"
        Me.Update.ReadOnly = True
        Me.Update.Text = "Update"
        Me.Update.UseColumnTextForButtonValue = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 104.4832!
        Me.Column4.HeaderText = "Kapasitas Baterai ( /watt)"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Delete
        '
        Me.Delete.FillWeight = 60.9137!
        Me.Delete.HeaderText = "Delete"
        Me.Delete.MinimumWidth = 6
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(413, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID Stasiun"
        '
        'cbStasiun
        '
        Me.cbStasiun.FormattingEnabled = True
        Me.cbStasiun.Items.AddRange(New Object() {"BPN101 - Jln Jendral Sudirman, Balikpapan Utara", "SMD101 - Sempaja Utara", "SMD102 - Samarinda Kota"})
        Me.cbStasiun.Location = New System.Drawing.Point(412, 276)
        Me.cbStasiun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbStasiun.Name = "cbStasiun"
        Me.cbStasiun.Size = New System.Drawing.Size(283, 26)
        Me.cbStasiun.TabIndex = 16
        '
        'dtpPerawatan
        '
        Me.dtpPerawatan.CustomFormat = "yyyy-MM-dd"
        Me.dtpPerawatan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPerawatan.Location = New System.Drawing.Point(413, 220)
        Me.dtpPerawatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpPerawatan.MaxDate = New Date(3000, 5, 10, 0, 0, 0, 0)
        Me.dtpPerawatan.MinDate = New Date(2024, 5, 10, 0, 0, 0, 0)
        Me.dtpPerawatan.Name = "dtpPerawatan"
        Me.dtpPerawatan.Size = New System.Drawing.Size(297, 24)
        Me.dtpPerawatan.TabIndex = 15
        Me.dtpPerawatan.Value = New Date(2024, 5, 10, 0, 0, 0, 0)
        '
        'txtTarif
        '
        Me.txtTarif.Location = New System.Drawing.Point(412, 86)
        Me.txtTarif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.Size = New System.Drawing.Size(272, 24)
        Me.txtTarif.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(409, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tarif"
        '
        'txtJarak
        '
        Me.txtJarak.Location = New System.Drawing.Point(52, 265)
        Me.txtJarak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJarak.Name = "txtJarak"
        Me.txtJarak.Size = New System.Drawing.Size(272, 24)
        Me.txtJarak.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jarak Tempuh"
        '
        'txtBaterai
        '
        Me.txtBaterai.Location = New System.Drawing.Point(52, 204)
        Me.txtBaterai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBaterai.Name = "txtBaterai"
        Me.txtBaterai.Size = New System.Drawing.Size(272, 24)
        Me.txtBaterai.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipe Sepeda"
        '
        'Column2
        '
        Me.Column2.FillWeight = 104.4832!
        Me.Column2.HeaderText = "Tipe Sepeda"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btnGenID
        '
        Me.btnGenID.BackColor = System.Drawing.Color.DarkCyan
        Me.btnGenID.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnGenID.Location = New System.Drawing.Point(253, 81)
        Me.btnGenID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(72, 36)
        Me.btnGenID.TabIndex = 43
        Me.btnGenID.Text = "Gen ID"
        Me.btnGenID.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.EM)
        Me.Panel1.Controls.Add(Me.CVX)
        Me.Panel1.Controls.Add(Me.VX)
        Me.Panel1.Controls.Add(Me.VR5)
        Me.Panel1.Controls.Add(Me.btnGenID)
        Me.Panel1.Controls.Add(Me.cbTipeSepeda)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.txtKodeSepeda)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cbStasiun)
        Me.Panel1.Controls.Add(Me.dtpPerawatan)
        Me.Panel1.Controls.Add(Me.txtTarif)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtJarak)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtBaterai)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 699)
        Me.Panel1.TabIndex = 36
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnBack.Location = New System.Drawing.Point(889, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 42)
        Me.btnBack.TabIndex = 82
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'EM
        '
        Me.EM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EM.Image = CType(resources.GetObject("EM.Image"), System.Drawing.Image)
        Me.EM.Location = New System.Drawing.Point(769, 97)
        Me.EM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EM.Name = "EM"
        Me.EM.Size = New System.Drawing.Size(220, 218)
        Me.EM.TabIndex = 81
        Me.EM.TabStop = False
        '
        'CVX
        '
        Me.CVX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CVX.Image = CType(resources.GetObject("CVX.Image"), System.Drawing.Image)
        Me.CVX.Location = New System.Drawing.Point(769, 97)
        Me.CVX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CVX.Name = "CVX"
        Me.CVX.Size = New System.Drawing.Size(220, 218)
        Me.CVX.TabIndex = 80
        Me.CVX.TabStop = False
        '
        'VX
        '
        Me.VX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VX.Image = CType(resources.GetObject("VX.Image"), System.Drawing.Image)
        Me.VX.Location = New System.Drawing.Point(769, 97)
        Me.VX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VX.Name = "VX"
        Me.VX.Size = New System.Drawing.Size(220, 218)
        Me.VX.TabIndex = 79
        Me.VX.TabStop = False
        '
        'VR5
        '
        Me.VR5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VR5.Image = CType(resources.GetObject("VR5.Image"), System.Drawing.Image)
        Me.VR5.Location = New System.Drawing.Point(769, 97)
        Me.VR5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VR5.Name = "VR5"
        Me.VR5.Size = New System.Drawing.Size(220, 218)
        Me.VR5.TabIndex = 78
        Me.VR5.TabStop = False
        '
        'cbTipeSepeda
        '
        Me.cbTipeSepeda.FormattingEnabled = True
        Me.cbTipeSepeda.Items.AddRange(New Object() {"Ventura R5", "Varilux Pro", "Crosser VX", "Honda EM1"})
        Me.cbTipeSepeda.Location = New System.Drawing.Point(52, 145)
        Me.cbTipeSepeda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTipeSepeda.Name = "cbTipeSepeda"
        Me.cbTipeSepeda.Size = New System.Drawing.Size(272, 26)
        Me.cbTipeSepeda.TabIndex = 42
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnReset.Location = New System.Drawing.Point(411, 314)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(131, 33)
        Me.btnReset.TabIndex = 41
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtKodeSepeda
        '
        Me.txtKodeSepeda.Location = New System.Drawing.Point(52, 86)
        Me.txtKodeSepeda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodeSepeda.Name = "txtKodeSepeda"
        Me.txtKodeSepeda.Size = New System.Drawing.Size(181, 24)
        Me.txtKodeSepeda.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Kode Sepeda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnTersedia)
        Me.GroupBox1.Controls.Add(Me.rbtnDisewa)
        Me.GroupBox1.Controls.Add(Me.rbtnDiperbaiki)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(411, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(301, 66)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status :"
        '
        'rbtnTersedia
        '
        Me.rbtnTersedia.AutoSize = True
        Me.rbtnTersedia.Location = New System.Drawing.Point(11, 30)
        Me.rbtnTersedia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnTersedia.Name = "rbtnTersedia"
        Me.rbtnTersedia.Size = New System.Drawing.Size(94, 22)
        Me.rbtnTersedia.TabIndex = 12
        Me.rbtnTersedia.TabStop = True
        Me.rbtnTersedia.Text = "Tersedia"
        Me.rbtnTersedia.UseVisualStyleBackColor = True
        '
        'rbtnDisewa
        '
        Me.rbtnDisewa.AutoSize = True
        Me.rbtnDisewa.Location = New System.Drawing.Point(111, 30)
        Me.rbtnDisewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnDisewa.Name = "rbtnDisewa"
        Me.rbtnDisewa.Size = New System.Drawing.Size(84, 22)
        Me.rbtnDisewa.TabIndex = 13
        Me.rbtnDisewa.TabStop = True
        Me.rbtnDisewa.Text = "Disewa"
        Me.rbtnDisewa.UseVisualStyleBackColor = True
        '
        'rbtnDiperbaiki
        '
        Me.rbtnDiperbaiki.AutoSize = True
        Me.rbtnDiperbaiki.Location = New System.Drawing.Point(201, 30)
        Me.rbtnDiperbaiki.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnDiperbaiki.Name = "rbtnDiperbaiki"
        Me.rbtnDiperbaiki.Size = New System.Drawing.Size(104, 22)
        Me.rbtnDiperbaiki.TabIndex = 14
        Me.rbtnDiperbaiki.TabStop = True
        Me.rbtnDiperbaiki.Text = "Diperbaiki"
        Me.rbtnDiperbaiki.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.Location = New System.Drawing.Point(561, 314)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 33)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "Add Data"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Perbaikan Terakhir"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Edit, Me.Update, Me.Delete})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 402)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 297)
        Me.DataGridView1.TabIndex = 35
        '
        'Column1
        '
        Me.Column1.FillWeight = 104.4832!
        Me.Column1.HeaderText = "Kode Sepeda"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'InventoryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 702)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InventoryManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryManager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CVX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VR5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Update As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents cbStasiun As ComboBox
    Friend WithEvents dtpPerawatan As DateTimePicker
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJarak As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBaterai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnGenID As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents EM As PictureBox
    Friend WithEvents CVX As PictureBox
    Friend WithEvents VX As PictureBox
    Friend WithEvents VR5 As PictureBox
    Friend WithEvents cbTipeSepeda As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtKodeSepeda As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnTersedia As RadioButton
    Friend WithEvents rbtnDisewa As RadioButton
    Friend WithEvents rbtnDiperbaiki As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
