Imports MySql.Data.MySqlClient

Public Class UserDash
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Form1.Clear()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub UserDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        getRentInfo()
        Panel2.Show()
    End Sub

    Private Function getNama() As String
        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & CurrentUsername & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim nama = RD.Item("nama_pelanggan")
            RD.Close()
            Return nama
        End If
        Return ""
    End Function

    Private Sub AjukanSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjukanSewaToolStripMenuItem.Click
        ApplyRent.Show()
    End Sub

    Private Sub getRentInfo()
        Dim query As String = "SELECT t.*, p.*, s.* FROM transaksi t " &
                                  "JOIN pelanggan p ON t.id_pelanggan = p.username " &
                                  "JOIN sepeda_listrik s ON t.id_sepeda = s.kode_sepeda " &
                                  "WHERE t.id_pelanggan = @username AND t.status IN ('Applied', 'Approved', 'Ongoing')"
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@username", CurrentUsername)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Panel1.Show()
                    AjukanSewaToolStripMenuItem.Enabled = False
                    Dim tipe_sepeda As String = reader("id_sepeda").ToString()
                    Dim status As String = reader("status").ToString()
                    lbKodeTransaksi.Text = reader("id_transaksi").ToString()
                    lbPelanggan.Text = reader("nama_pelanggan").ToString()
                    lbTipeSepeda.Text = reader("tipe_sepeda").ToString()
                    Dim Kapasitas As String = reader("kapasitas_baterai").ToString()
                    Dim Jarak As String = reader("jarak_tempuh").ToString()
                    Dim KJ As String = Kapasitas & " watt untuk : " & Jarak & " km"
                    lbKapasitasJarak.Text = KJ
                    Dim tglSewaAwal As DateTime = reader.GetDateTime("tgl_sewa_awal")
                    lbPengambilan.Text = tglSewaAwal.ToString("dddd, dd MMMM yyyy")
                    Dim tglSewaAkhir As DateTime = reader.GetDateTime("tgl_sewa_akhir")
                    lbPengembalian.Text = tglSewaAkhir.ToString("dddd, dd MMMM yyyy")
                    lbPaket.Text = reader("paket").ToString()
                    lbStasiun.Text = reader("stasiun_sepeda").ToString()
                    Dim pembayaran As String = reader("tarif").ToString()
                    lbTarif.Text = "Rp. " & pembayaran

                    If status = "Applied" Then
                        statusBox1.BackColor = Color.Blue
                        statusBox2.BackColor = Color.LightGray
                        statusBox3.BackColor = Color.LightGray
                        btnAmbil.Hide()
                    ElseIf status = "Approved" Then
                        statusBox1.BackColor = Color.LightGray
                        statusBox2.BackColor = Color.Blue
                        statusBox3.BackColor = Color.LightGray
                        btnAmbil.Show()
                    ElseIf status = "OnGoing" Then
                        statusBox1.BackColor = Color.LightGray
                        statusBox2.BackColor = Color.LightGray
                        statusBox3.BackColor = Color.Blue
                        btnAmbil.Hide()
                    End If

                    Select Case tipe_sepeda
                        Case "Ventura R5"
                            VR5.Show()
                            VX.Hide()
                            CVX.Hide()
                        Case "Varilux Pro"
                            VR5.Hide()
                            VX.Show()
                            CVX.Hide()
                        Case "Crosser VX"
                            VR5.Hide()
                            VX.Hide()
                            CVX.Show()
                    End Select
                Else
                    AjukanSewaToolStripMenuItem.Enabled = True
                    Panel1.Hide()
                End If
            End Using
        End Using
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        koneksi()
        getRentInfo()
        Panel2.Show()
    End Sub

    Private Sub btnSewa_Click(sender As Object, e As EventArgs) Handles btnSewa.Click
        ApplyRent.Show()
        Me.Hide()
    End Sub

    Private Sub btnAmbil_Click(sender As Object, e As EventArgs) Handles btnAmbil.Click
        CMD = New MySqlCommand("UPDATE transaksi SET status = 'OnGoing' WHERE id_transaksi = '" & lbKodeTransaksi.Text & "'", CONN)
        CMD.ExecuteNonQuery()
        Dim id_sepeda As String = getIDSepeda()
        CMD = New MySqlCommand("UPDATE sepeda_listrik SET status = 'disewa' WHERE id_transaksi = '" & id_sepeda & "'", CONN)
        MsgBox("Sewa Anda telah berjalan")
        getRentInfo()
    End Sub

    Private Function getIDSepeda() As String
        CMD = New MySqlCommand("SELECT * FROM transaksi WHERE id_transaksi = '" & lbKodeTransaksi.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim id_sepeda = RD.Item("id_sepeda")
            RD.Close()
            Return id_sepeda
        End If
        Return ""
    End Function

End Class