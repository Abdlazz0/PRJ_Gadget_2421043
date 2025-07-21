Imports MySql.Data.MySqlClient
Public Class FMerk
    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO merk_2421043(marknama) VALUES ('" & txtnamamerk.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        Me.Dispose()
    End Sub

    Private Sub FMerk_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * FROM merk_2421043 ORDER BY merkid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "merk_2421043")
        dg.DataSource = ds.Tables("merk_2421043")
        kon.Close()
    End Sub
End Class