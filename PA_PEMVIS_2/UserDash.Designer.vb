<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDash))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjukanSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAmbil = New System.Windows.Forms.Button()
        Me.lbStasiun = New System.Windows.Forms.Label()
        Me.lbPelanggan = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbPengembalian = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbPengambilan = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbKapasitasJarak = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbPaket = New System.Windows.Forms.Label()
        Me.lbTipeSepeda = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbTarif = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbKodeTransaksi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.statusBox3 = New System.Windows.Forms.Panel()
        Me.lbOnGoing = New System.Windows.Forms.Label()
        Me.statusBox2 = New System.Windows.Forms.Panel()
        Me.lbApproved = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CVX = New System.Windows.Forms.PictureBox()
        Me.VX = New System.Windows.Forms.PictureBox()
        Me.VR5 = New System.Windows.Forms.PictureBox()
        Me.statusBox1 = New System.Windows.Forms.Panel()
        Me.lbApplied = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSewa = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.statusBox3.SuspendLayout()
        Me.statusBox2.SuspendLayout()
        CType(Me.CVX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VR5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.InventarisToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1153, 28)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'InventarisToolStripMenuItem
        '
        Me.InventarisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjukanSewaToolStripMenuItem})
        Me.InventarisToolStripMenuItem.Name = "InventarisToolStripMenuItem"
        Me.InventarisToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.InventarisToolStripMenuItem.Text = "Penyewaan"
        '
        'AjukanSewaToolStripMenuItem
        '
        Me.AjukanSewaToolStripMenuItem.Name = "AjukanSewaToolStripMenuItem"
        Me.AjukanSewaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AjukanSewaToolStripMenuItem.Text = "Ajukan Sewa"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.btnAmbil)
        Me.Panel1.Controls.Add(Me.lbStasiun)
        Me.Panel1.Controls.Add(Me.lbPelanggan)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.lbPengembalian)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.lbPengambilan)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lbKapasitasJarak)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lbPaket)
        Me.Panel1.Controls.Add(Me.lbTipeSepeda)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbTarif)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbKodeTransaksi)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.statusBox3)
        Me.Panel1.Controls.Add(Me.statusBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CVX)
        Me.Panel1.Controls.Add(Me.VX)
        Me.Panel1.Controls.Add(Me.VR5)
        Me.Panel1.Controls.Add(Me.statusBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(15, 111)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1124, 372)
        Me.Panel1.TabIndex = 7
        '
        'btnAmbil
        '
        Me.btnAmbil.BackColor = System.Drawing.Color.Blue
        Me.btnAmbil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmbil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAmbil.Location = New System.Drawing.Point(471, 300)
        Me.btnAmbil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAmbil.Name = "btnAmbil"
        Me.btnAmbil.Size = New System.Drawing.Size(240, 38)
        Me.btnAmbil.TabIndex = 40
        Me.btnAmbil.Text = "Ambil Sepeda Listrikmu"
        Me.btnAmbil.UseVisualStyleBackColor = False
        '
        'lbStasiun
        '
        Me.lbStasiun.AutoSize = True
        Me.lbStasiun.Location = New System.Drawing.Point(828, 192)
        Me.lbStasiun.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStasiun.Name = "lbStasiun"
        Me.lbStasiun.Size = New System.Drawing.Size(55, 16)
        Me.lbStasiun.TabIndex = 39
        Me.lbStasiun.Text = "Label15"
        '
        'lbPelanggan
        '
        Me.lbPelanggan.AutoSize = True
        Me.lbPelanggan.Location = New System.Drawing.Point(337, 132)
        Me.lbPelanggan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPelanggan.Name = "lbPelanggan"
        Me.lbPelanggan.Size = New System.Drawing.Size(119, 16)
        Me.lbPelanggan.TabIndex = 38
        Me.lbPelanggan.Text = "Nama Pelanggan :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(337, 102)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 16)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Nama Pelanggan :"
        '
        'lbPengembalian
        '
        Me.lbPengembalian.AutoSize = True
        Me.lbPengembalian.Location = New System.Drawing.Point(620, 197)
        Me.lbPengembalian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPengembalian.Name = "lbPengembalian"
        Me.lbPengembalian.Size = New System.Drawing.Size(93, 16)
        Me.lbPengembalian.TabIndex = 36
        Me.lbPengembalian.Text = "YYYY/MM/DD"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(615, 165)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 16)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Tgl Pengembalian"
        '
        'lbPengambilan
        '
        Me.lbPengambilan.AutoSize = True
        Me.lbPengambilan.Location = New System.Drawing.Point(619, 133)
        Me.lbPengambilan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPengambilan.Name = "lbPengambilan"
        Me.lbPengambilan.Size = New System.Drawing.Size(93, 16)
        Me.lbPengambilan.TabIndex = 33
        Me.lbPengambilan.Text = "YYYY/MM/DD"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(615, 105)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 16)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Tgl Pengambilan"
        '
        'lbKapasitasJarak
        '
        Me.lbKapasitasJarak.AutoSize = True
        Me.lbKapasitasJarak.Location = New System.Drawing.Point(337, 258)
        Me.lbKapasitasJarak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbKapasitasJarak.Name = "lbKapasitasJarak"
        Me.lbKapasitasJarak.Size = New System.Drawing.Size(55, 16)
        Me.lbKapasitasJarak.TabIndex = 31
        Me.lbKapasitasJarak.Text = "Label17"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(437, 258)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 16)
        Me.Label16.TabIndex = 30
        '
        'lbPaket
        '
        Me.lbPaket.AutoSize = True
        Me.lbPaket.Location = New System.Drawing.Point(621, 260)
        Me.lbPaket.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPaket.Name = "lbPaket"
        Me.lbPaket.Size = New System.Drawing.Size(55, 16)
        Me.lbPaket.TabIndex = 29
        Me.lbPaket.Text = "Label15"
        '
        'lbTipeSepeda
        '
        Me.lbTipeSepeda.AutoSize = True
        Me.lbTipeSepeda.Location = New System.Drawing.Point(336, 198)
        Me.lbTipeSepeda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipeSepeda.Name = "lbTipeSepeda"
        Me.lbTipeSepeda.Size = New System.Drawing.Size(55, 16)
        Me.lbTipeSepeda.TabIndex = 27
        Me.lbTipeSepeda.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(823, 165)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Lokasi Stasiun :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(620, 231)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Paket :"
        '
        'lbTarif
        '
        Me.lbTarif.AutoSize = True
        Me.lbTarif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTarif.Location = New System.Drawing.Point(923, 274)
        Me.lbTarif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTarif.Name = "lbTarif"
        Me.lbTarif.Size = New System.Drawing.Size(108, 20)
        Me.lbTarif.TabIndex = 23
        Me.lbTarif.Text = "Rp. 000.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(917, 247)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Total Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 228)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Kapasitas, Jarak Tempuh :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(336, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Model Sepeda Listrik :"
        '
        'lbKodeTransaksi
        '
        Me.lbKodeTransaksi.AutoSize = True
        Me.lbKodeTransaksi.Location = New System.Drawing.Point(977, 105)
        Me.lbKodeTransaksi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbKodeTransaksi.Name = "lbKodeTransaksi"
        Me.lbKodeTransaksi.Size = New System.Drawing.Size(65, 16)
        Me.lbKodeTransaksi.TabIndex = 19
        Me.lbKodeTransaksi.Text = "KDTR001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(823, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Kode Transaksi :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(456, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Proses Peminjaman"
        '
        'statusBox3
        '
        Me.statusBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusBox3.Controls.Add(Me.lbOnGoing)
        Me.statusBox3.Location = New System.Drawing.Point(680, 44)
        Me.statusBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statusBox3.Name = "statusBox3"
        Me.statusBox3.Size = New System.Drawing.Size(219, 23)
        Me.statusBox3.TabIndex = 13
        '
        'lbOnGoing
        '
        Me.lbOnGoing.AutoSize = True
        Me.lbOnGoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOnGoing.Location = New System.Drawing.Point(76, 2)
        Me.lbOnGoing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOnGoing.Name = "lbOnGoing"
        Me.lbOnGoing.Size = New System.Drawing.Size(69, 17)
        Me.lbOnGoing.TabIndex = 1
        Me.lbOnGoing.Text = "On Going"
        '
        'statusBox2
        '
        Me.statusBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statusBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusBox2.Controls.Add(Me.lbApproved)
        Me.statusBox2.Location = New System.Drawing.Point(437, 44)
        Me.statusBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statusBox2.Name = "statusBox2"
        Me.statusBox2.Size = New System.Drawing.Size(237, 23)
        Me.statusBox2.TabIndex = 13
        '
        'lbApproved
        '
        Me.lbApproved.AutoSize = True
        Me.lbApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApproved.Location = New System.Drawing.Point(91, 1)
        Me.lbApproved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbApproved.Name = "lbApproved"
        Me.lbApproved.Size = New System.Drawing.Size(69, 17)
        Me.lbApproved.TabIndex = 2
        Me.lbApproved.Text = "Approved"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 11
        '
        'CVX
        '
        Me.CVX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CVX.Image = CType(resources.GetObject("CVX.Image"), System.Drawing.Image)
        Me.CVX.Location = New System.Drawing.Point(95, 103)
        Me.CVX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CVX.Name = "CVX"
        Me.CVX.Size = New System.Drawing.Size(175, 175)
        Me.CVX.TabIndex = 15
        Me.CVX.TabStop = False
        '
        'VX
        '
        Me.VX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VX.Image = CType(resources.GetObject("VX.Image"), System.Drawing.Image)
        Me.VX.Location = New System.Drawing.Point(95, 103)
        Me.VX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VX.Name = "VX"
        Me.VX.Size = New System.Drawing.Size(175, 175)
        Me.VX.TabIndex = 14
        Me.VX.TabStop = False
        '
        'VR5
        '
        Me.VR5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VR5.Image = CType(resources.GetObject("VR5.Image"), System.Drawing.Image)
        Me.VR5.Location = New System.Drawing.Point(95, 103)
        Me.VR5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VR5.Name = "VR5"
        Me.VR5.Size = New System.Drawing.Size(175, 175)
        Me.VR5.TabIndex = 13
        Me.VR5.TabStop = False
        '
        'statusBox1
        '
        Me.statusBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusBox1.Controls.Add(Me.lbApplied)
        Me.statusBox1.Location = New System.Drawing.Point(192, 44)
        Me.statusBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statusBox1.Name = "statusBox1"
        Me.statusBox1.Size = New System.Drawing.Size(241, 23)
        Me.statusBox1.TabIndex = 12
        '
        'lbApplied
        '
        Me.lbApplied.AutoSize = True
        Me.lbApplied.BackColor = System.Drawing.Color.Transparent
        Me.lbApplied.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApplied.Location = New System.Drawing.Point(89, 2)
        Me.lbApplied.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbApplied.Name = "lbApplied"
        Me.lbApplied.Size = New System.Drawing.Size(59, 17)
        Me.lbApplied.TabIndex = 0
        Me.lbApplied.Text = " Applied"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(469, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Londo Skuter Rent"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BackgroundImage = Global.PA_PEMVIS_2.My.Resources.Resources.ezgif_com_webp_to_jpg_converter
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btnSewa)
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1153, 505)
        Me.Panel2.TabIndex = 40
        '
        'btnSewa
        '
        Me.btnSewa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSewa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSewa.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnSewa.Location = New System.Drawing.Point(209, 375)
        Me.btnSewa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSewa.Name = "btnSewa"
        Me.btnSewa.Size = New System.Drawing.Size(196, 28)
        Me.btnSewa.TabIndex = 0
        Me.btnSewa.Text = "Mulai Menyewa"
        Me.btnSewa.UseVisualStyleBackColor = False
        '
        'UserDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 538)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UserDash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserDash"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.statusBox3.ResumeLayout(False)
        Me.statusBox3.PerformLayout()
        Me.statusBox2.ResumeLayout(False)
        Me.statusBox2.PerformLayout()
        CType(Me.CVX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VR5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusBox1.ResumeLayout(False)
        Me.statusBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjukanSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VR5 As PictureBox
    Friend WithEvents statusBox1 As Panel
    Friend WithEvents CVX As PictureBox
    Friend WithEvents VX As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents statusBox3 As Panel
    Friend WithEvents statusBox2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lbApproved As Label
    Friend WithEvents lbOnGoing As Label
    Friend WithEvents lbApplied As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbKodeTransaksi As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTarif As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbPengembalian As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbPengambilan As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbKapasitasJarak As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbPaket As Label
    Friend WithEvents lbTipeSepeda As Label
    Friend WithEvents lbPelanggan As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbStasiun As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSewa As Button
    Friend WithEvents btnAmbil As Button
End Class
