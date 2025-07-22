Imports MySql.Data.MySqlClient
Public Class Fcaripelanggan
    Sub tampilplg(ByVal sql As String)
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pelanggan_2421043")
        dg.DataSource = ds.Tables("pelanggan_2421043")
        kon.Close()
    End Sub
    Sub setdg()
        dg.Columns(0).HeaderText = "ID Pelanggan"
        dg.Columns(1).HeaderText = "Nama Pelanggan"

        dg.Columns(0).Width = 140
        dg.Columns(1).Width = 300
    End Sub

    Private Sub Fcaripelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilplg("SELECT pelangganid, pelanggannama FROM pelanggan_2421043 ORDER BY pelangganid")
        setdg()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        tampilplg("SELECT pelangganid, pelanggannama FROM pelanggan_2421043 WHERE pelanggannama LIKE '%" & txtcari.Text & "%' ORDER BY pelangganid")
        setdg()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        FJual.txtpelangganid.Text = dg.Rows.Item(i).Cells(0).Value
        FJual.txtpelanggannama.Text = dg.Rows.Item(i).Cells(1).Value
        Me.Close()
    End Sub
End Class