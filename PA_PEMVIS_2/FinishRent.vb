Imports MySql.Data.MySqlClient

Public Class FinishRent
    Private Sub Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        CVX.Hide()
        VX.Hide()
        VR5.Hide()
        getRentInfo()
    End Sub

    Private Sub getRentInfo()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("SELECT * FROM transaksi WHERE status = 'OnGoing'", CONN)
        RD = CMD.ExecuteReader
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("id_transaksi")
            row.Cells(1).Value = RD("id_pelanggan")
            row.Cells(2).Value = RD("id_sepeda")
            row.Cells(3).Value = RD("tgl_sewa_awal")
            row.Cells(4).Value = RD("tgl_sewa_akhir")
            row.Cells(5).Value = RD("tarif")
            row.Cells(6).Value = RD("paket")
            row.Cells(7).Value = RD("stasiun_sepeda")
            row.Cells(8).Value = RD("status")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Clear()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Rows.Count > 0 Then
            Dim dr As DataGridViewRow = DataGridView1.Rows(0)

            CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & dr.Cells(1).Value.ToString() & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            lbNama.Text = RD("nama_pelanggan").ToString()
            RD.Close()

            lbIDtransaksi.Text = dr.Cells(0).Value.ToString()
            lbKodeSepeda.Text = dr.Cells(2).Value.ToString()

            CMD = New MySqlCommand("SELECT * FROM sepeda_listrik WHERE kode_sepeda = '" & dr.Cells(2).Value.ToString() & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            lbTipeSepeda.Text = RD("tipe_sepeda").ToString()
            RD.Close()

            lbTglSewa.Text = dr.Cells(3).Value.ToString()
            lbTglKembali.Text = dr.Cells(4).Value.ToString()
            lbTarif.Text = dr.Cells(5).Value.ToString()
            lbPaket.Text = dr.Cells(6).Value.ToString()
            lbStasiun.Text = dr.Cells(7).Value.ToString()

            If lbTipeSepeda.Text = "Crosser VX" Then
                CVX.Show()
                VX.Hide()
                VR5.Hide()
                EM.Hide()
            ElseIf lbTipeSepeda.Text = "Varilux Pro" Then
                CVX.Hide()
                VX.Show()
                VR5.Hide()
                EM.Hide()
            ElseIf lbTipeSepeda.Text = "Ventura R5" Then
                CVX.Hide()
                VX.Hide()
                VR5.Show()
                EM.Hide()
            ElseIf lbTipeSepeda.Text = "Honda EM1" Then
                CVX.Hide()
                VX.Hide()
                VR5.Hide()
                EM.Show()
            End If
        End If
    End Sub

    Sub Clear()
        lbNama.Text = ""
        lbIDtransaksi.Text = ""
        lbKodeSepeda.Text = ""
        lbTipeSepeda.Text = ""
        lbTglSewa.Text = ""
        lbTglKembali.Text = ""
        lbTarif.Text = ""
        lbPaket.Text = ""
        lbStasiun.Text = ""
    End Sub

    Function getTarifSepeda() As Integer
        Dim tarif As Integer
        CMD = New MySqlCommand("SELECT tarif FROM sepeda_listrik WHERE kode_sepeda = '" & lbKodeSepeda.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        tarif = RD("tarif")
        RD.Close()
        Return tarif
    End Function

    Private Sub btnFinish_Click_1(sender As Object, e As EventArgs) Handles btnFinish.Click
        If txtDenda.Text = "" Then
            CMD = New MySqlCommand("UPDATE transaksi SET status = 'Done' WHERE id_transaksi = '" & lbIDtransaksi.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            CMD = New MySqlCommand("UPDATE sepeda_listrik SET status = 'tersedia' WHERE kode_sepeda = '" & lbKodeSepeda.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Sewa berhasil diselesaikan")
        ElseIf CInt(txtDenda.Text) > 0 Then
            Dim denda As Integer
            denda = (CInt(getTarifSepeda()) + 25000) * CInt(txtDenda.Text)
            CMD = New MySqlCommand("UPDATE transaksi SET status = 'Done' WHERE id_transaksi = '" & lbIDtransaksi.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            CMD = New MySqlCommand("UPDATE transaksi SET denda = '" & denda & "' WHERE id_transaksi = '" & lbIDtransaksi.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            CMD = New MySqlCommand("UPDATE sepeda_listrik SET status = 'tersedia' WHERE kode_sepeda = '" & lbKodeSepeda.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Sewa berhasil diselesaikan")
        Else
            MsgBox("Masukkan Data")
        End If
        Clear()
        getRentInfo()
    End Sub

End Class