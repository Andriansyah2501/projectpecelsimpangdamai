Imports MySql.Data.MySqlClient
Public Class MainMenu
    Dim strkon As String = "server=localhost;uid=root;database=uts"
    Dim koneksi As New MySqlConnection(strkon)
    Dim Perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Dim hargamakanan, hargaminuman, ongkir, namakasir, total, disc, totbay
    Private Sub cmbmakanan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmakanan.SelectedIndexChanged
        Select Case cmbmakanan.SelectedIndex
            Case 0
                hargamakanan = 28000
            Case 1
                hargamakanan = 25000
            Case 2
                hargamakanan = 28000
            Case 3
                hargamakanan = 30000
        End Select
        hrgmakan.Text = Format(hargamakanan, "Rp ###,###,##")
    End Sub

    Private Sub cmbminuman_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbminuman.SelectedIndexChanged
        Select Case cmbminuman.SelectedIndex
            Case 0
                hargaminuman = 8000
            Case 1
                hargaminuman = 9000
            Case 2
                hargaminuman = 9000
            Case 3
                hargaminuman = 2000
        End Select
        hrgminum.Text = Format(hargaminuman, "Rp ###,###,##")
    End Sub


    Private Sub cmbnamakasir_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnamakasir.SelectedIndexChanged
        Select Case cmbnamakasir.SelectedIndex

            Case 0
                namakasir = "Andrian Syah"
            Case 1
                namakasir = "Maranti Nainggolan"
            Case 2
                namakasir = "Dea Syaputri"
            Case 3
                namakasir = "Hani Khairiyah"
            Case 4
                namakasir = "Kevin Antoni"

        End Select
    End Sub

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        total = Val(hargamakanan) + Val(hargaminuman) + Val(lblongkir.Text)
        disc = total * Val(lbldisc.Text) / 100
        totbay = total - disc
        lbltotal.Text = Format(totbay, "Rp ###,###,##")
        MsgBox("Total yang harus dibayar : " + lbltotal.Text, MsgBoxStyle.Information, "Pembayaran")


    End Sub


    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        koneksi.Open()
        Perintah.Connection = koneksi
        Perintah.CommandType = CommandType.Text
        Perintah.CommandText = "insert into penjualan values" & _
        " ('" & txtnopelanggan.Text & "' , '" & Format(dttbeli.Value, "yyyy-MM-dd") & "' , " & _
        " '" & cmbmakanan.Text & "', '" & cmbminuman.Text & "' , '" & statuskirim.Text & "','" & hargamakanan & "','" & hargaminuman & "' , " & _
        " '" & lblongkir.Text & "' , '" & namakasir & "','" & lbldisc.Text & "','" & total & "' ) "
        Perintah.ExecuteNonQuery()
        MsgBox("DATA BERHASIL DISIMPAN ", MsgBoxStyle.Information, " informasi")
        tampil()
        bersih()
    End Sub


    Sub tampil()
        koneksi.Close()
        koneksi.Open()
        Perintah.Connection = koneksi
        Perintah.CommandType = CommandType.Text
        Perintah.CommandText = "select * from penjualan "
        mda.SelectCommand = Perintah
        ds.Tables.Clear()
        mda.Fill(ds, "penjualan")
        dg.DataSource = ds.Tables("penjualan")
        koneksi.Close()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        hidup()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dim Keluar As String
        Keluar = MsgBox("Yakin keluar?", vbQuestion + vbYesNo, "Informasi")
        If Keluar = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        koneksi.Open()
        Perintah.Connection = koneksi
        Perintah.CommandType = CommandType.Text
        Perintah.CommandText = "delete from penjualan where nopelanggan='" &
        txtnopelanggan.Text & "'"
        Perintah.ExecuteNonQuery()
        koneksi.Close()
        MsgBox("DATA ANDA BERHASIL DIHAPUS", MsgBoxStyle.Information, " HAPUS")
        tampil()
        bersih()
        hidup()
    End Sub


    Private Sub txtnopelanggan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnopelanggan.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                koneksi.Open()
                Perintah.Connection = koneksi
                Perintah.CommandType = CommandType.Text
                Perintah.CommandText = "select * from penjualan " & _
                " where nopelanggan='" & txtnopelanggan.Text & "'"
                cek = Perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    dttbeli.Value = cek.Item("tanggalbeli")
                    txtnopelanggan.Text = cek.Item("nopelanggan")
                    cmbmakanan.Text = cek.Item("makanan")
                    cmbminuman.Text = cek.Item("minuman")
                    statuskirim.Text = cek.Item("pengantaran")
                    hrgmakan.Text = cek.Item("hargamakanan")
                    hrgminum.Text = cek.Item("hargaminuman")
                    cmbnamakasir.Text = cek.Item("namakasir")
                    lblongkir.Text = cek.Item("ongkir")
                    lbldisc.Text = cek.Item("discount")
                    lbltotal.Text = cek.Item("total")
                End If
                koneksi.Close()
                mati()
        End Select
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        koneksi.Open()
        Perintah.Connection = koneksi
        Perintah.CommandType = CommandType.Text
        Perintah.CommandText = "update penjualan set tanggalbeli='" &
        Format(dttbeli.Value, "yyyy-MM-dd") & "', " & _
        " makanan='" & cmbmakanan.Text & "', minuman='" &
        cmbminuman.Text & "', pengantaran= '" & statuskirim.Text & "', hargamakanan='" & hargamakanan & "',hargaminuman='" & hargaminuman & "', " & _
        " ongkir='" & lblongkir.Text & "' ,namakasir='" & namakasir & "', discount='" & lbldisc.Text & "' , total='" & totbay & "'  where nopelanggan='" & txtnopelanggan.Text & "'"
        Perintah.ExecuteNonQuery()
        koneksi.Close()
        MsgBox("DATA BERHASIL DI UPDATE", MsgBoxStyle.Information, "informasi")
        tampil()
        bersih()
        hidup()
    End Sub

    Sub bersih()
        txtnopelanggan.Text = ""
        cmbmakanan.Text = ""
        cmbminuman.Text = ""
        statuskirim.Text = ""
        hrgmakan.Text = ""
        hrgminum.Text = ""
        lblongkir.Text = ""
        cmbnamakasir.Text = ""
        lbldisc.Text = ""
        lbltotal.Text = ""

    End Sub

    Sub mati()
        statuskirim.Enabled = False
        cmbnamakasir.Enabled = False

    End Sub


    Sub hidup()
        statuskirim.Enabled = True
        cmbnamakasir.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bersih()
        hidup()
    End Sub
End Class


