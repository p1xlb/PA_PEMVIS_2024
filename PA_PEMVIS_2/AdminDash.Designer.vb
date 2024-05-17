<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDash
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenInventarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPersetujuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPenyewaanBerjalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListRiwayatPenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 417)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(367, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 45)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(249, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(389, 79)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Londo Skuter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA_PEMVIS_2.My.Resources.Resources.ezgif_com_webp_to_jpg_converter
        Me.PictureBox1.Location = New System.Drawing.Point(0, 180)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Indigo
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarisToolStripMenuItem, Me.PenyewaanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarisToolStripMenuItem
        '
        Me.InventarisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManajemenInventarisToolStripMenuItem})
        Me.InventarisToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InventarisToolStripMenuItem.Name = "InventarisToolStripMenuItem"
        Me.InventarisToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.InventarisToolStripMenuItem.Text = "Inventaris"
        '
        'ManajemenInventarisToolStripMenuItem
        '
        Me.ManajemenInventarisToolStripMenuItem.BackColor = System.Drawing.Color.Thistle
        Me.ManajemenInventarisToolStripMenuItem.Name = "ManajemenInventarisToolStripMenuItem"
        Me.ManajemenInventarisToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.ManajemenInventarisToolStripMenuItem.Text = "Manajemen Inventaris"
        '
        'PenyewaanToolStripMenuItem
        '
        Me.PenyewaanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListPersetujuanToolStripMenuItem, Me.ListPenyewaanBerjalanToolStripMenuItem, Me.ListRiwayatPenyewaanToolStripMenuItem})
        Me.PenyewaanToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PenyewaanToolStripMenuItem.Name = "PenyewaanToolStripMenuItem"
        Me.PenyewaanToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.PenyewaanToolStripMenuItem.Text = "Penyewaan"
        '
        'ListPersetujuanToolStripMenuItem
        '
        Me.ListPersetujuanToolStripMenuItem.BackColor = System.Drawing.Color.Thistle
        Me.ListPersetujuanToolStripMenuItem.Name = "ListPersetujuanToolStripMenuItem"
        Me.ListPersetujuanToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ListPersetujuanToolStripMenuItem.Text = "List Persetujuan"
        '
        'ListPenyewaanBerjalanToolStripMenuItem
        '
        Me.ListPenyewaanBerjalanToolStripMenuItem.BackColor = System.Drawing.Color.Thistle
        Me.ListPenyewaanBerjalanToolStripMenuItem.Name = "ListPenyewaanBerjalanToolStripMenuItem"
        Me.ListPenyewaanBerjalanToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ListPenyewaanBerjalanToolStripMenuItem.Text = "List Penyewaan Berjalan"
        '
        'ListRiwayatPenyewaanToolStripMenuItem
        '
        Me.ListRiwayatPenyewaanToolStripMenuItem.BackColor = System.Drawing.Color.Thistle
        Me.ListRiwayatPenyewaanToolStripMenuItem.Name = "ListRiwayatPenyewaanToolStripMenuItem"
        Me.ListRiwayatPenyewaanToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ListRiwayatPenyewaanToolStripMenuItem.Text = "List Riwayat Penyewaan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'AdminDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminDash"
        Me.Text = "AdminDash"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenInventarisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenyewaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPersetujuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPenyewaanBerjalanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListRiwayatPenyewaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
End Class
