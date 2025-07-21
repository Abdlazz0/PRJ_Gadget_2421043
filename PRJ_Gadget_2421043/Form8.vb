Imports MySql.Data.MySqlClient
Public Class FPelanggan
    Dim sql As String
    Sub tampilpelanggan(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pelanggan_2421043")
        dg.DataSource = (ds.Tables("pelanggan_2421043"))
        kon.Close()
    End Sub
    Sub prosespelanggan(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub setdg()
        dg.Columns(0).HeaderText = "ID Pelanggan"
        dg.Columns(1).HeaderText = "Nama Pelanggan"
        dg.Columns(2).HeaderText = "Alamat"
        dg.Columns(3).HeaderText = "No HP"
        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 200
        dg.Columns(2).Width = 250
        dg.Columns(3).Width = 120
    End Sub
    Sub tidakaktif()
        txtidpelanggan.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtnohp.Enabled = False

        txtidpelanggan.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
        txtalamat.BackColor = Color.Gray
        txtnohp.BackColor = Color.Gray
    End Sub
    Sub aktif()
        txtidpelanggan.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txtnohp.Enabled = True

        txtidpelanggan.BackColor = Color.White
        txtnama.BackColor = Color.White
        txtalamat.BackColor = Color.White
        txtnohp.BackColor = Color.White
    End Sub

    Private Sub FPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampilpelanggan("SELECT pelangganid, pelanggannama, pelangganalamat, pelanggannohp " &
                        "FROM pelanggan_2421043 ORDER BY pelangganid")
        setdg()
        cmdsimpan.Enabled = False
    End Sub

    Sub bersih()
        txtidpelanggan.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txtnohp.Text = ""
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "TAMBAH" Then
            cmdtambah.Text = "BATAL"
            txtidpelanggan.Enabled = True
            txtidpelanggan.BackColor = Color.White
            txtidpelanggan.Focus()
            bersih()
        Else
            cmdtambah.Text = "TAMBAH"
            tidakaktif()
            bersih()
        End If
        cmdsimpan.Text = "SIMPAN"
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        prosespelanggan("DELETE FROM pelanggan_2421043 WHERE pelangganid='" & txtidpelanggan.Text & "'")
        tampilpelanggan("SELECT pelangganid, pelanggannama, pelangganalamat, pelanggannohp " &
                        "FROM pelanggan_2421043 ORDER BY pelangganid")
        setdg()
        cmdtambah_Click(e, AcceptButton)
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        If cmdsimpan.Text = "SIMPAN" Then
            prosespelanggan("INSERT INTO pelanggan_2421043 VALUES ('" & txtidpelanggan.Text & "', '" &
                                    txtnama.Text & "', '" & txtalamat.Text & "', '" & txtnohp.Text & "')")
        Else
            prosespelanggan("UPDATE pelanggan_2421043 SET pelanggannama='" & txtnama.Text & "', " &
                                    "pelangganalamat='" & txtalamat.Text & "', pelanggannohp='" & txtnohp.Text & "' " &
                                    "WHERE pelangganid='" & txtidpelanggan.Text & "'")
        End If
        tampilpelanggan("SELECT pelangganid, pelanggannama, pelangganalamat, pelanggannohp " &
                        "FROM pelanggan_2421043 ORDER BY pelangganid")
        setdg()
        bersih()
        tidakaktif()
        cmdtambah.Enabled = True
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
        FMenu.Show()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        tampilpelanggan("SELECT pelangganid, pelanggannama, pelangganalamat, pelanggannohp " &
                        "FROM pelanggan_2421043 WHERE pelangganid LIKE '%" & txtcari.Text & "%' " &
                        "OR pelanggannama LIKE '%" & txtcari.Text & "%' " &
                        "OR pelangganalamat LIKE '%" & txtcari.Text & "%' " &
                        "OR pelanggannohp LIKE '%" & txtcari.Text & "%'")
        setdg()
    End Sub

    Private Sub txtidpelanggan_Keypress(sender As Object, e As KeyPressEventArgs) Handles txtidpelanggan.KeyPress
        If e.KeyChar = Chr(13) Then
            txtidpelanggan.Text = UCase(txtidpelanggan.Text)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "SELECT * FROM pelanggan_2421043 WHERE pelangganid='" & txtidpelanggan.Text & "'"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                txtidpelanggan.Enabled = False
                txtnama.Text = cek.Item("pelanggannama")
                txtalamat.Text = cek.Item("pelangganalamat")
                txtnohp.Text = cek.Item("pelanggannohp")
                cmdsimpan.Text = "UPDATE"
            Else
                cmdsimpan.Text = "SIMPAN"
            End If
            cek.Close()
            kon.Close()
            aktif()
            txtnama.Focus()
            cmdsimpan.Enabled = True
        End If
    End Sub
End Class