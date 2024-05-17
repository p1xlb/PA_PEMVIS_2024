<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplyRent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplyRent))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipeSepeda = New System.Windows.Forms.TextBox()
        Me.chHelm = New System.Windows.Forms.CheckBox()
        Me.chExtraBatt = New System.Windows.Forms.CheckBox()
        Me.lbTotalTarif = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbStasiun = New System.Windows.Forms.ComboBox()
        Me.dtpPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.dtpPengambilan = New System.Windows.Forms.DateTimePicker()
        Me.btnAjukan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjukanSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 411)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Crosser VX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ventura R5"
        '
        'txtTipeSepeda
        '
        Me.txtTipeSepeda.Location = New System.Drawing.Point(115, 34)
        Me.txtTipeSepeda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipeSepeda.Name = "txtTipeSepeda"
        Me.txtTipeSepeda.Size = New System.Drawing.Size(198, 20)
        Me.txtTipeSepeda.TabIndex = 1
        '
        'chHelm
        '
        Me.chHelm.AutoSize = True
        Me.chHelm.Location = New System.Drawing.Point(115, 165)
        Me.chHelm.Margin = New System.Windows.Forms.Padding(2)
        Me.chHelm.Name = "chHelm"
        Me.chHelm.Size = New System.Drawing.Size(50, 17)
        Me.chHelm.TabIndex = 3
        Me.chHelm.Text = "Helm"
        Me.chHelm.UseVisualStyleBackColor = True
        '
        'chExtraBatt
        '
        Me.chExtraBatt.AutoSize = True
        Me.chExtraBatt.Location = New System.Drawing.Point(165, 165)
        Me.chExtraBatt.Margin = New System.Windows.Forms.Padding(2)
        Me.chExtraBatt.Name = "chExtraBatt"
        Me.chExtraBatt.Size = New System.Drawing.Size(92, 17)
        Me.chExtraBatt.TabIndex = 4
        Me.chExtraBatt.Text = "Ekstra Baterai"
        Me.chExtraBatt.UseVisualStyleBackColor = True
        '
        'lbTotalTarif
        '
        Me.lbTotalTarif.AutoSize = True
        Me.lbTotalTarif.Location = New System.Drawing.Point(139, 196)
        Me.lbTotalTarif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalTarif.Name = "lbTotalTarif"
        Me.lbTotalTarif.Size = New System.Drawing.Size(13, 13)
        Me.lbTotalTarif.TabIndex = 5
        Me.lbTotalTarif.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cbStasiun)
        Me.Panel2.Controls.Add(Me.dtpPengembalian)
        Me.Panel2.Controls.Add(Me.dtpPengambilan)
        Me.Panel2.Controls.Add(Me.btnAjukan)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtTipeSepeda)
        Me.Panel2.Controls.Add(Me.lbTotalTarif)
        Me.Panel2.Controls.Add(Me.chExtraBatt)
        Me.Panel2.Controls.Add(Me.chHelm)
        Me.Panel2.Location = New System.Drawing.Point(11, 22)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 398)
        Me.Panel2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Lokasi Stasiun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tgl Pengembalian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tgl Pengambilan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tipe Sepeda"
        '
        'cbStasiun
        '
        Me.cbStasiun.FormattingEnabled = True
        Me.cbStasiun.Items.AddRange(New Object() {"BPN101 - Jln Jendral Sudirman, Balikpapan Utara", "SMD101 - Sempaja Utara", "SMD102 - Samarinda Kota"})
        Me.cbStasiun.Location = New System.Drawing.Point(111, 124)
        Me.cbStasiun.Margin = New System.Windows.Forms.Padding(2)
        Me.cbStasiun.Name = "cbStasiun"
        Me.cbStasiun.Size = New System.Drawing.Size(202, 21)
        Me.cbStasiun.TabIndex = 17
        '
        'dtpPengembalian
        '
        Me.dtpPengembalian.Location = New System.Drawing.Point(113, 96)
        Me.dtpPengembalian.Name = "dtpPengembalian"
        Me.dtpPengembalian.Size = New System.Drawing.Size(200, 20)
        Me.dtpPengembalian.TabIndex = 10
        '
        'dtpPengambilan
        '
        Me.dtpPengambilan.Location = New System.Drawing.Point(113, 66)
        Me.dtpPengambilan.Name = "dtpPengambilan"
        Me.dtpPengambilan.Size = New System.Drawing.Size(200, 20)
        Me.dtpPengambilan.TabIndex = 9
        '
        'btnAjukan
        '
        Me.btnAjukan.Location = New System.Drawing.Point(93, 233)
        Me.btnAjukan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAjukan.Name = "btnAjukan"
        Me.btnAjukan.Size = New System.Drawing.Size(153, 19)
        Me.btnAjukan.TabIndex = 8
        Me.btnAjukan.Text = "Ajukan Penyewaan"
        Me.btnAjukan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rp. "
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(789, -1)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(56, 19)
        Me.btnKembali.TabIndex = 6
        Me.btnKembali.Text = "Back"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.InventarisToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 24)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'InventarisToolStripMenuItem
        '
        Me.InventarisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjukanSewaToolStripMenuItem, Me.RiwayatSewaToolStripMenuItem})
        Me.InventarisToolStripMenuItem.Name = "InventarisToolStripMenuItem"
        Me.InventarisToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.InventarisToolStripMenuItem.Text = "Penyewaan"
        '
        'AjukanSewaToolStripMenuItem
        '
        Me.AjukanSewaToolStripMenuItem.Name = "AjukanSewaToolStripMenuItem"
        Me.AjukanSewaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AjukanSewaToolStripMenuItem.Text = "Ajukan Sewa"
        '
        'RiwayatSewaToolStripMenuItem
        '
        Me.RiwayatSewaToolStripMenuItem.Name = "RiwayatSewaToolStripMenuItem"
        Me.RiwayatSewaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RiwayatSewaToolStripMenuItem.Text = "Riwayat Sewa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Varilux Pro"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(374, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(162, 176)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(194, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 176)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 176)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ApplyRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 435)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ApplyRent"
        Me.Text = "ApplyRent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipeSepeda As TextBox
    Friend WithEvents chHelm As CheckBox
    Friend WithEvents chExtraBatt As CheckBox
    Friend WithEvents lbTotalTarif As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAjukan As Button
    Friend WithEvents dtpPengembalian As DateTimePicker
    Friend WithEvents dtpPengambilan As DateTimePicker
    Friend WithEvents cbStasiun As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjukanSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiwayatSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
End Class
