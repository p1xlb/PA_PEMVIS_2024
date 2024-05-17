<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentHistory))
        Me.tgl_sewa_awal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtTambahan = New System.Windows.Forms.TextBox()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.txtStasiun = New System.Windows.Forms.TextBox()
        Me.txtTGLAkhir = New System.Windows.Forms.TextBox()
        Me.txtTGLAwal = New System.Windows.Forms.TextBox()
        Me.txtLama = New System.Windows.Forms.TextBox()
        Me.txtJenSep = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.paket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.denda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stasiun_sepeda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tgl_sewa_akhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_sepeda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lama_sewa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tgl_sewa_awal
        '
        Me.tgl_sewa_awal.HeaderText = "Tanggal Pengambilan"
        Me.tgl_sewa_awal.MinimumWidth = 6
        Me.tgl_sewa_awal.Name = "tgl_sewa_awal"
        Me.tgl_sewa_awal.ReadOnly = True
        Me.tgl_sewa_awal.Width = 125
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.MediumPurple
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(636, 261)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 20)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Cari"
        '
        'txtCari
        '
        Me.txtCari.BackColor = System.Drawing.Color.MediumPurple
        Me.txtCari.Location = New System.Drawing.Point(688, 257)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(491, 22)
        Me.txtCari.TabIndex = 102
        '
        'txtTambahan
        '
        Me.txtTambahan.BackColor = System.Drawing.Color.MediumPurple
        Me.txtTambahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTambahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTambahan.Location = New System.Drawing.Point(732, 29)
        Me.txtTambahan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTambahan.Name = "txtTambahan"
        Me.txtTambahan.ReadOnly = True
        Me.txtTambahan.Size = New System.Drawing.Size(373, 26)
        Me.txtTambahan.TabIndex = 101
        '
        'txtTarif
        '
        Me.txtTarif.BackColor = System.Drawing.Color.MediumPurple
        Me.txtTarif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTarif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarif.Location = New System.Drawing.Point(732, 72)
        Me.txtTarif.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.ReadOnly = True
        Me.txtTarif.Size = New System.Drawing.Size(373, 26)
        Me.txtTarif.TabIndex = 100
        '
        'txtStasiun
        '
        Me.txtStasiun.BackColor = System.Drawing.Color.MediumPurple
        Me.txtStasiun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStasiun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStasiun.Location = New System.Drawing.Point(732, 123)
        Me.txtStasiun.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStasiun.Name = "txtStasiun"
        Me.txtStasiun.ReadOnly = True
        Me.txtStasiun.Size = New System.Drawing.Size(373, 26)
        Me.txtStasiun.TabIndex = 99
        '
        'txtTGLAkhir
        '
        Me.txtTGLAkhir.BackColor = System.Drawing.Color.MediumPurple
        Me.txtTGLAkhir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTGLAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTGLAkhir.Location = New System.Drawing.Point(234, 220)
        Me.txtTGLAkhir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTGLAkhir.Name = "txtTGLAkhir"
        Me.txtTGLAkhir.ReadOnly = True
        Me.txtTGLAkhir.Size = New System.Drawing.Size(373, 26)
        Me.txtTGLAkhir.TabIndex = 98
        '
        'txtTGLAwal
        '
        Me.txtTGLAwal.BackColor = System.Drawing.Color.MediumPurple
        Me.txtTGLAwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTGLAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTGLAwal.Location = New System.Drawing.Point(234, 170)
        Me.txtTGLAwal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTGLAwal.Name = "txtTGLAwal"
        Me.txtTGLAwal.ReadOnly = True
        Me.txtTGLAwal.Size = New System.Drawing.Size(373, 26)
        Me.txtTGLAwal.TabIndex = 97
        '
        'txtLama
        '
        Me.txtLama.BackColor = System.Drawing.Color.MediumPurple
        Me.txtLama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLama.Location = New System.Drawing.Point(234, 119)
        Me.txtLama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLama.Name = "txtLama"
        Me.txtLama.ReadOnly = True
        Me.txtLama.Size = New System.Drawing.Size(373, 26)
        Me.txtLama.TabIndex = 96
        '
        'txtJenSep
        '
        Me.txtJenSep.BackColor = System.Drawing.Color.MediumPurple
        Me.txtJenSep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJenSep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenSep.Location = New System.Drawing.Point(234, 74)
        Me.txtJenSep.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJenSep.Name = "txtJenSep"
        Me.txtJenSep.ReadOnly = True
        Me.txtJenSep.Size = New System.Drawing.Size(373, 26)
        Me.txtJenSep.TabIndex = 95
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.MediumPurple
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(234, 29)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(373, 26)
        Me.txtNama.TabIndex = 94
        '
        'paket
        '
        Me.paket.HeaderText = "Tambahan"
        Me.paket.MinimumWidth = 6
        Me.paket.Name = "paket"
        Me.paket.ReadOnly = True
        Me.paket.Width = 125
        '
        'tarif
        '
        Me.tarif.HeaderText = "Tarif"
        Me.tarif.MinimumWidth = 6
        Me.tarif.Name = "tarif"
        Me.tarif.ReadOnly = True
        Me.tarif.Width = 75
        '
        'denda
        '
        Me.denda.HeaderText = "Denda"
        Me.denda.MinimumWidth = 6
        Me.denda.Name = "denda"
        Me.denda.ReadOnly = True
        Me.denda.Width = 75
        '
        'stasiun_sepeda
        '
        Me.stasiun_sepeda.HeaderText = "Stasiun Sepeda"
        Me.stasiun_sepeda.MinimumWidth = 6
        Me.stasiun_sepeda.Name = "stasiun_sepeda"
        Me.stasiun_sepeda.ReadOnly = True
        Me.stasiun_sepeda.Width = 125
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnPrint.Location = New System.Drawing.Point(856, 197)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(172, 50)
        Me.btnPrint.TabIndex = 104
        Me.btnPrint.Text = "Cetak Laporan"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.MediumPurple
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(630, 127)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Denda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.MediumPurple
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(630, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Tarif"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MediumPurple
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(630, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Tambahan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumPurple
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 224)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 20)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Tanggal Pengembalian"
        '
        'tgl_sewa_akhir
        '
        Me.tgl_sewa_akhir.HeaderText = "Tanggal Pengembalian"
        Me.tgl_sewa_akhir.MinimumWidth = 6
        Me.tgl_sewa_akhir.Name = "tgl_sewa_akhir"
        Me.tgl_sewa_akhir.ReadOnly = True
        Me.tgl_sewa_akhir.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumPurple
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Tanggal Pengambilan"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumPurple
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Jenis Sepeda"
        '
        'id_sepeda
        '
        Me.id_sepeda.HeaderText = "Kode Sepeda"
        Me.id_sepeda.MinimumWidth = 6
        Me.id_sepeda.Name = "id_sepeda"
        Me.id_sepeda.ReadOnly = True
        Me.id_sepeda.Width = 90
        '
        'id_pelanggan
        '
        Me.id_pelanggan.HeaderText = "Pelanggan"
        Me.id_pelanggan.MinimumWidth = 6
        Me.id_pelanggan.Name = "id_pelanggan"
        Me.id_pelanggan.ReadOnly = True
        Me.id_pelanggan.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumPurple
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Nama"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnBack.Location = New System.Drawing.Point(1050, 197)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 50)
        Me.btnBack.TabIndex = 85
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumPurple
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Lama Sewa"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Thistle
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pelanggan, Me.id_sepeda, Me.lama_sewa, Me.tgl_sewa_awal, Me.tgl_sewa_akhir, Me.paket, Me.tarif, Me.denda, Me.stasiun_sepeda})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 307)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1160, 233)
        Me.DataGridView1.TabIndex = 84
        '
        'lama_sewa
        '
        Me.lama_sewa.HeaderText = "Lama Sewa"
        Me.lama_sewa.MinimumWidth = 6
        Me.lama_sewa.Name = "lama_sewa"
        Me.lama_sewa.ReadOnly = True
        Me.lama_sewa.Width = 54
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Location = New System.Drawing.Point(1, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1193, 562)
        Me.Panel1.TabIndex = 105
        '
        'RentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 554)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtTambahan)
        Me.Controls.Add(Me.txtTarif)
        Me.Controls.Add(Me.txtStasiun)
        Me.Controls.Add(Me.txtTGLAkhir)
        Me.Controls.Add(Me.txtTGLAwal)
        Me.Controls.Add(Me.txtLama)
        Me.Controls.Add(Me.txtJenSep)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RentHistory"
        Me.Text = "RentHistory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tgl_sewa_awal As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtTambahan As TextBox
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents txtStasiun As TextBox
    Friend WithEvents txtTGLAkhir As TextBox
    Friend WithEvents txtTGLAwal As TextBox
    Friend WithEvents txtLama As TextBox
    Friend WithEvents txtJenSep As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents paket As DataGridViewTextBoxColumn
    Friend WithEvents tarif As DataGridViewTextBoxColumn
    Friend WithEvents denda As DataGridViewTextBoxColumn
    Friend WithEvents stasiun_sepeda As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tgl_sewa_akhir As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents id_sepeda As DataGridViewTextBoxColumn
    Friend WithEvents id_pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lama_sewa As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
End Class
