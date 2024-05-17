
Imports MySql.Data.MySqlClient

Public Class ApplyRent
    Dim options As New List(Of String)
    Private CONN_STRING As String = "server=localhost;user id=root;password=;database=sewaspd"
    Private CONN As MySqlConnection

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SetBikeType("Ventura R5")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SetBikeType("Varilux Pro")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SetBikeType("Crosser VX")
    End Sub

    Private Sub SetBikeType(type As String)
        Panel1.Hide()
        txtTipeSepeda.Text = type
        txtTipeSepeda.Enabled = False
        Panel2.Show()
    End Sub

    Private Sub ApplyRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Clear()
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Private Sub chHelm_CheckedChanged(sender As Object, e As EventArgs) Handles chHelm.CheckedChanged
        UpdateTotalTarif(chHelm.Checked, 20000)
    End Sub

    Private Sub chExtraBatt_CheckedChanged(sender As Object, e As EventArgs) Handles chExtraBatt.CheckedChanged
        UpdateTotalTarif(chExtraBatt.Checked, 35000)
    End Sub

    Private Sub UpdateTotalTarif(checked As Boolean, amount As Integer)
        Dim tarif As Integer = Integer.Parse(lbTotalTarif.Text.Replace("Rp. ", ""))
        If checked Then
            tarif += amount
        Else
            tarif -= amount
        End If
        lbTotalTarif.Text = "Rp. " & tarif.ToString()
    End Sub

    Private Sub Clear()
        txtTipeSepeda.Clear()
        chHelm.Checked = False
        chExtraBatt.Checked = False
        lbTotalTarif.Text = "Rp. 0"
    End Sub

    Private Sub btnAjukan_Click(sender As Object, e As EventArgs) Handles btnAjukan.Click
        Dim tgl_sewa_awal As DateTime = dtpPengambilan.Value.Date
        Dim tgl_sewa_akhir As DateTime = dtpPengembalian.Value.Date
        Dim tipe_sepeda As String = txtTipeSepeda.Text
        Dim durasi_sewa As TimeSpan = tgl_sewa_akhir.Subtract(tgl_sewa_awal)
        Dim lama_sewa As Integer = durasi_sewa.Days
        Dim total_tarif As Integer = Integer.Parse(lbTotalTarif.Text.Replace("Rp. ", ""))
        Dim stasiun_sepeda As String = cbStasiun.Text

        If tgl_sewa_awal = tgl_sewa_akhir Then
            MsgBox("Tanggal pengambilan dan pengembalian tidak boleh sama", MsgBoxStyle.Critical, "Error")
            lbTotalTarif.Text = "Rp. 0"
            Return
        Else
            Try
                Dim id_transaksi As Integer = GenerateID()

                If chHelm.Checked Then options.Add("helm")
                If chExtraBatt.Checked Then options.Add("extra batt")

                Dim paket As String = String.Join(", ", options)
                Dim status As String = "Applied"

                Using conn As New MySqlConnection(CONN_STRING)
                    conn.Open()
                    Dim id_sepeda As String = GetAvailableBike(conn, tipe_sepeda)
                    If id_sepeda Is Nothing Then
                        MsgBox("Tidak ada sepeda yang tersedia untuk tipe tersebut", MsgBoxStyle.Information, "Info")
                        Exit Sub
                    End If

                    InsertTransaction(conn, id_transaksi, CurrentUsername, id_sepeda, paket, lama_sewa, tgl_sewa_awal, tgl_sewa_akhir, total_tarif, status)
                    UpdateBikeStatus(conn, id_sepeda)

                End Using

                MsgBox("Pengajuan sewa berhasil", MsgBoxStyle.Information, "Success")
                Clear()
                Panel2.Hide()
                Panel1.Show()
                UserDash.AjukanSewaToolStripMenuItem.Enabled = False
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Function GetAvailableBike(conn As MySqlConnection, tipe_sepeda As String) As String
        Dim queryGetBike = "SELECT kode_sepeda FROM sepeda_listrik WHERE tipe_sepeda = @tipe_sepeda AND status = 'tersedia' LIMIT 1"
        Using cmdGetBike As New MySqlCommand(queryGetBike, conn)
            cmdGetBike.Parameters.AddWithValue("@tipe_sepeda", tipe_sepeda)
            Using reader = cmdGetBike.ExecuteReader()
                If reader.Read() Then
                    Return reader("kode_sepeda").ToString()
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Private Sub InsertTransaction(conn As MySqlConnection, id_transaksi As Integer, username As String, id_sepeda As String, paket As String, lama_sewa As Integer, tgl_sewa_awal As DateTime, tgl_sewa_akhir As DateTime, total_tarif As Integer, status As String)
        Dim queryInsertTransaction = "INSERT INTO transaksi (id_transaksi,id_pelanggan,id_sepeda,paket,lama_sewa,tgl_sewa_awal,tgl_sewa_akhir,tarif,stasiun_sepeda,status) VALUES (@id_transaksi, @id_pelanggan,@id_sepeda,@paket,@lama_sewa,@tgl_sewa_awal,@tgl_sewa_akhir,@tarif,@stasiun_sepeda,@status)"
        Using cmdInsertTransaction As New MySqlCommand(queryInsertTransaction, conn)
            cmdInsertTransaction.Parameters.AddWithValue("@id_transaksi", id_transaksi)
            cmdInsertTransaction.Parameters.AddWithValue("@id_pelanggan", username)
            cmdInsertTransaction.Parameters.AddWithValue("@id_sepeda", id_sepeda)
            cmdInsertTransaction.Parameters.AddWithValue("@paket", paket)
            cmdInsertTransaction.Parameters.AddWithValue("@lama_sewa", lama_sewa)
            cmdInsertTransaction.Parameters.AddWithValue("@tgl_sewa_awal", tgl_sewa_awal)
            cmdInsertTransaction.Parameters.AddWithValue("@tgl_sewa_akhir", tgl_sewa_akhir)
            cmdInsertTransaction.Parameters.AddWithValue("@tarif", total_tarif)
            cmdInsertTransaction.Parameters.AddWithValue("@stasiun_sepeda", cbStasiun.Text)
            cmdInsertTransaction.Parameters.AddWithValue("@status", status)
            cmdInsertTransaction.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub UpdateBikeStatus(conn As MySqlConnection, id_sepeda As String)
        Dim queryUpdateBikeStatus = "UPDATE sepeda_listrik SET status = 'disewa' WHERE kode_sepeda = @id_sepeda"
        Using cmdUpdateBikeStatus As New MySqlCommand(queryUpdateBikeStatus, conn)
            cmdUpdateBikeStatus.Parameters.AddWithValue("@id_sepeda", id_sepeda)
            cmdUpdateBikeStatus.ExecuteNonQuery()
        End Using
    End Sub

    Private Function GenerateID() As Integer
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                conn.Open()
                Dim query = "SELECT COUNT(*) FROM transaksi"
                Using cmd As New MySqlCommand(query, conn)
                    Dim count = CInt(cmd.ExecuteScalar())
                    Return count + 1
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return 1
        End Try
    End Function

    Private Sub dtpPengambilan_ValueChanged(sender As Object, e As EventArgs) Handles dtpPengambilan.ValueChanged
        UpdateTarif()
    End Sub

    Private Sub dtpPengembalian_ValueChanged(sender As Object, e As EventArgs) Handles dtpPengembalian.ValueChanged
        UpdateTarif()
    End Sub

    Private Sub UpdateTarif()
        Dim tgl_sewa_awal As DateTime = dtpPengambilan.Value.Date
        Dim tgl_sewa_akhir As DateTime = dtpPengembalian.Value.Date
        Dim durasi_sewa As TimeSpan = tgl_sewa_akhir.Subtract(tgl_sewa_awal)
        Dim lama_sewa As Integer = durasi_sewa.Days

        If lama_sewa = 0 Then
            lbTotalTarif.Text = "Rp. 0"
        Else
            Dim tarif As Integer
            Select Case txtTipeSepeda.Text
                Case "Ventura R5"
                    tarif = 50000 * lama_sewa
                Case "Varilux Pro"
                    tarif = 65000 * lama_sewa
                Case "Crosser VX"
                    tarif = 80000 * lama_sewa
                Case Else
                    tarif = 0
            End Select
            lbTotalTarif.Text = "Rp. " & tarif.ToString()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Close()
        UserDash.Show()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Panel2.Hide()
        Panel1.Show()

    End Sub
End Class

