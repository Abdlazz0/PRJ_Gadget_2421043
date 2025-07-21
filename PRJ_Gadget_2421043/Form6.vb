Imports MySql.Data.MySqlClient
Public Class FKategori
    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO kategori_2421043 (kategorinama) VALUES ('" & txtnamakategori.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        Me.Dispose()
    End Sub

    Private Sub FKategori_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * FROM kategori_2421043 order by kategoriid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "kategori_2421043")
        dg.DataSource = ds.Tables("kategori_2421043")
        kon.Close()
    End Sub
End Class