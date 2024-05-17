Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class RentHistory

    Private Sub RentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDGView("")
    End Sub

    Sub LoadDGView(searchTerm As String)
        DataGridView1.Rows.Clear()
        Dim query As String
        If String.IsNullOrEmpty(searchTerm) Then
            query = "SELECT t.*, p.nama_pelanggan FROM transaksi t INNER JOIN pelanggan p ON t.id_pelanggan = p.username WHERE t.status = 'Done'"
        Else
            query = "SELECT t.*, p.nama_pelanggan FROM transaksi t INNER JOIN pelanggan p ON t.id_pelanggan = p.username WHERE t.status = 'Done' AND (p.nama_pelanggan LIKE @searchTerm OR t.id_sepeda LIKE @searchTerm OR t.paket LIKE @searchTerm)"
        End If

        CMD = New MySqlCommand(query, CONN)
        If Not String.IsNullOrEmpty(searchTerm) Then
            CMD.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
        End If

        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("nama_pelanggan")
            row.Cells(1).Value = RD("id_sepeda")
            row.Cells(2).Value = RD("lama_sewa")
            row.Cells(3).Value = RD("tgl_sewa_awal")
            row.Cells(4).Value = RD("tgl_sewa_akhir")
            row.Cells(5).Value = RD("paket")
            row.Cells(6).Value = RD("tarif")
            row.Cells(7).Value = RD("denda")
            row.Cells(8).Value = RD("stasiun_sepeda")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminDash.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtNama.Text = row.Cells(0).Value.ToString()
            txtJenSep.Text = row.Cells(1).Value.ToString()
            txtLama.Text = row.Cells(2).Value.ToString()
            txtTGLAwal.Text = row.Cells(3).Value.ToString()
            txtTGLAkhir.Text = row.Cells(4).Value.ToString()
            txtTambahan.Text = row.Cells(5).Value.ToString()
            txtTarif.Text = row.Cells(6).Value.ToString()
            txtStasiun.Text = row.Cells(7).Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        LoadDGView(txtCari.Text)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim yPos As Single = e.MarginBounds.Top
        Dim xPos As Single = e.MarginBounds.Left
        Dim columnWidth As Single = e.MarginBounds.Width / DataGridView1.ColumnCount
        Dim sf As New StringFormat()

        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        ' Print Header
        e.Graphics.DrawString("Rent History Report", headerFont, Brushes.Black, xPos, yPos)
        yPos += headerFont.GetHeight(e.Graphics) + 20

        ' Print Column Headers
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            Dim rect As New RectangleF(xPos, yPos, columnWidth, headerFont.GetHeight(e.Graphics) * 2)
            e.Graphics.DrawString(DataGridView1.Columns(i).HeaderText, headerFont, Brushes.Black, rect, sf)
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect))
            xPos += columnWidth
        Next
        yPos += headerFont.GetHeight(e.Graphics) * 2 + 5
        xPos = e.MarginBounds.Left

        ' Print Rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then ' Ensure not to print the new row placeholder
                For i As Integer = 0 To row.Cells.Count - 1
                    Dim rect As New RectangleF(xPos, yPos, columnWidth, font.GetHeight(e.Graphics))
                    e.Graphics.DrawString(row.Cells(i).Value.ToString(), font, Brushes.Black, rect, sf)
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect))
                    xPos += columnWidth
                Next
                yPos += font.GetHeight(e.Graphics)
                xPos = e.MarginBounds.Left
            End If
        Next
    End Sub
End Class
