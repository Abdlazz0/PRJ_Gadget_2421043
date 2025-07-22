Imports MySql.Data.MySqlClient
Public Class FJual
    Dim i, no As Integer
    Dim totsel, kembali As Double
    Function terbilang(ByVal n As Double) As String
        Dim satuan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima",
                                  "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}
        Select Case n
            Case 0 To 11
                terbilang = " " + satuan(Fix(n))
            Case 12 To 19
                terbilang = terbilang(n Mod 10) + " Belas"
            Case 20 To 99
                terbilang = terbilang(Fix(n / 10)) + "puluh" + terbilang(n Mod 10)
            Case 100 To 199
                terbilang = "Seratus" + terbilang(n Mod 100)
            Case 200 To 999
                terbilang = terbilang(Fix(n / 100)) + " Ratus" + terbilang(n Mod 100)
            Case 1000 To 1999
                terbilang = "Seribu" + terbilang(n Mod 1000)
            Case 2000 To 999999
                terbilang = terbilang(Fix(n / 1000)) + " Ribu" + terbilang(n Mod 1000)
            Case 1000000 To 999999999
                terbilang = terbilang(Fix(n / 1000000)) + " Juta" + terbilang(n Mod 1000000)
            Case 1000000000 To 999999999999
                terbilang = terbilang(Fix(n / 1000000000)) + " Miliar" + terbilang(n Mod 1000000000)
            Case 1000000000000 To 999999999999999
                terbilang = terbilang(Fix(n / 1000000000000)) + " Triliun" + terbilang(n Mod 1000000000000)
            Case Else
                terbilang = terbilang(Fix(n / 1000000000000)) + " Triliun" + terbilang(n Mod 1000000000000)
        End Select
    End Function

    Sub tidakaktif()
        txtjualnofaktur.Enabled = False
        txtpelangganid.Enabled = False
        txtpelanggannama.Enabled = False
        txtjumlahuang.Enabled = False
        txtkembali.Enabled = False

        txtjualnofaktur.BackColor = Color.Gray
        txtpelangganid.BackColor = Color.Gray
        txtpelanggannama.BackColor = Color.Gray
        txtjumlahuang.BackColor = Color.Gray
        txtkembali.BackColor = Color.Gray
        cmdcetak.Enabled = False
        cmdsimpan.Enabled = False
        dg.Enabled = False
    End Sub
    Sub aktif()
        txtjualnofaktur.Enabled = True
        txtpelangganid.Enabled = True
        txtpelanggannama.Enabled = True
        txtjumlahuang.Enabled = True
        txtkembali.Enabled = True

        txtjualnofaktur.BackColor = Color.White
        txtpelangganid.BackColor = Color.White
        txtpelanggannama.BackColor = Color.White
        txtjumlahuang.BackColor = Color.White
        txtkembali.BackColor = Color.White
        cmdcetak.Enabled = True
        cmdsimpan.Enabled = True
        dg.Enabled = True
    End Sub
    Sub bersih()
        txtjualnofaktur.Text = ""
        txtpelangganid.Text = ""
        txtpelanggannama.Text = ""
        txtjumlahuang.Text = ""
        txtkembali.Text = ""
        lbltgl.Text = ""
        lblterbilang.Text = ""
        lbltotbay.Text = ""
        lbltotqty.Text = ""
    End Sub

    Sub buatkolom()
        dg.Columns.Add("kode", "Kode Produk")
        dg.Columns.Add("nama Produk", "Nama Produk")
        dg.Columns.Add("imei", "No. IMEI")
        dg.Columns.Add("qty", "Quantity")
        dg.Columns.Add("harga", "Harga")
        dg.Columns.Add("subtotal", "Sub Total (Rp)")

        dg.Columns(0).Width = 120
        dg.Columns(1).Width = 350
        dg.Columns(2).Width = 150
        dg.Columns(3).Width = 75
        dg.Columns(4).Width = 120
        dg.Columns(5).Width = 150

        dg.Columns(5).DefaultCellStyle.Format = "Rp ###,###,###"

        dg.Columns(1).ReadOnly = True
        dg.Columns(5).ReadOnly = True
    End Sub
    Sub hitungtotal()
        Dim total As Double
        Dim i As Integer
        For i = 0 To dg.Rows.Count - 1
            total = total + dg.Rows(i).Cells(5).Value
        Next
        lbltotbay.Text = Format(total, "Rp ###,###,###")
        lblterbilang.Text = UCase(terbilang(total)) + " Rupiah"
        totsel = total
    End Sub
    Sub hitungtotqty()
        Dim i As Integer
        Dim totqty As Double
        For i = 0 To dg.Rows.Count - 1
            totqty = totqty + dg.Rows(i).Cells(3).Value
        Next
        lbltotqty.Text = totqty
    End Sub


    Sub simpantransaksi()
        For i = 0 To dg.RowCount - 1
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "INSERT INTO jual_2421043 (jualnofaktur,jualtgl, " &
                                    "jualpelangganid, jualprodukid,jualimei,jualharga,jualqty, " &
                                    "jualuserinput) VALUES ('" & txtjualnofaktur.Text & "',now(), " &
                                    " '" & txtpelangganid.Text & "', '" & dg.Rows.Item(i).Cells(0).Value & "', " &
                                    "'" & dg.Rows.Item(i).Cells(2).Value & "', " & dg.Rows.Item(i).Cells(4).Value & ", " &
                                    dg.Rows.Item(i).Cells(3).Value & ", '" & useraktif & "')"
            perintah.ExecuteNonQuery()
            kon.Close()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        Next
    End Sub
    Sub buatfaktur()
        Dim kode, kodebaru, tgl As String
        Dim no As Integer
        tgl = Format(Now, "ddMMyyyy")
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT jualnofaktur FROM jual_2421043 " &
            "order by jualnofaktur desc limit 1"
        cek = perintah.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("jualnofaktur")
            no = Val(Microsoft.VisualBasic.Mid(kode, 3, 4))
            no = no + 1
            kodebaru = "SALES-" + Format(no, "0000") + tgl
            txtjualnofaktur.Text = kodebaru
        Else
            txtjualnofaktur.Text = "SALES-0001" + tgl
        End If
        cek.Close()
        kon.Close()
    End Sub

    Private Sub FJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buatkolom()
        totsel = 0
        tidakaktif()
        bersih()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltgl.Text = Format(Now, "dd MMMM yyyy") & " - " & Format(Now, "HH:mm:ss")
    End Sub
    Private Sub dg_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEndEdit
        If e.ColumnIndex = 0 Then
            i = dg.CurrentRow.Index
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "SELECT * FROM produk_2421043 " &
                " WHERE produkid = '" & dg.Rows(i).Cells(0).Value & "'"
            cek = perintah.ExecuteReader()
            cek.Read()
            If cek.HasRows Then
                'menampilkan data pada kolom di datagrid
                dg.Rows(i).Cells(1).Value = cek.Item("produknama") 'cara pertama
                dg.CurrentRow.Cells(3).Value = 1 'cara kedua
            Else
                MsgBox("Data Barang Tidak Ada", MsgBoxStyle.Exclamation, "Informasi")
            End If
            cek.Close()
            kon.Close()
        End If
        If e.ColumnIndex = 4 Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "SELECT * FROM produk_2421043 " &
                " WHERE produkid = '" & dg.Rows(i).Cells(0).Value & "'"
            cek = perintah.ExecuteReader()
            cek.Read()
            If cek.HasRows Then
                Dim stok As Integer
                stok = cek.Item("produkstok")
                If stok < dg.CurrentRow.Cells(3).Value Then
                    MsgBox("Stok tidak mencukupi", MsgBoxStyle.Exclamation, "Informasi")
                End If
            End If
            cek.Close()
            kon.Close()
        End If
        If e.ColumnIndex = 4 Then
            dg.CurrentRow.Cells(5).Value = dg.CurrentRow.Cells(3).Value * dg.CurrentRow.Cells(4).Value
            Call hitungtotal()
            Call hitungtotqty()
        End If
    End Sub


    Private Sub dg_Keypress(sender As Object, e As KeyPressEventArgs) Handles dg.KeyPress
        If e.KeyChar = Chr(27) Then
            dg.Rows.RemoveAt(dg.CurrentRow.Index)
            Call hitungtotal()
            Call hitungtotqty()
        End If
        If (InStr("RTAB", e.KeyChar) = 0) And (e.KeyChar <> Chr(8)) Then
            e.KeyChar = Chr(0)
        Else
            MsgBox("Input Anda salah", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Private Sub cmdbaru_Click(sender As Object, e As EventArgs) Handles cmdbaru.Click
        Call buatfaktur()
        dg.Rows.Clear()
        aktif()
    End Sub

    Private Sub cmdcaripelanggan_Click(sender As Object, e As EventArgs) Handles cmdcaripelanggan.Click
        Fcaripelanggan.Show()
    End Sub
    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        Call simpantransaksi()
        bersih()
        tidakaktif()
        cmdcetak.Enabled = True
        dg.Rows.Clear()
    End Sub
    Private Sub txtjumlahuang_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahuang.TextChanged
        kembali = Val(txtjumlahuang.Text) - totsel
        txtkembali.Text = Format(kembali, "Rp ###,###,###")
        txtjumlahuang.Text = Format(Val(txtjumlahuang.Text), "###,###,###")
    End Sub

    Private Sub cmdtambahpelanggan_Click(sender As Object, e As EventArgs) Handles cmdtambahpelanggan.Click
        FPelanggan.Show()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
        FMenu.Show()
    End Sub

    Private Sub txtpelangganid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpelangganid.KeyPress
        If e.KeyChar = Chr(13) Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "SELECT * FROM pelanggan_2421043 " &
                " WHERE pelangganid = '" & txtpelangganid.Text & "'"
            cek = perintah.ExecuteReader()
            cek.Read()
            If cek.HasRows Then
                txtpelanggannama.Text = cek.Item("pelanggannama")
            Else
                MsgBox("Data Pelanggan Tidak Ada", MsgBoxStyle.Exclamation, "Informasi")
                txtpelangganid.Text = ""
                txtpelanggannama.Text = ""
            End If
            kon.Close()
        End If
    End Sub

End Class