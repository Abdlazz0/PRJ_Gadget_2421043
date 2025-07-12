Imports MySql.Data.MySqlClient
Public Class Fuser
    Dim mnRandomNumber As Integer

    Function getRandomNumber(ByVal vnMinimumNumber As Integer, ByVal vnMaximumNumber As Integer)
        Randomize()
        getRandomNumber = CInt(Int((vnMaximumNumber - vnMinimumNumber + 1) * Rnd() + vnMinimumNumber))
    End Function

    Sub tampilanuser(ByVal sql As String, Optional ByVal parameters As List(Of MySqlParameter) = Nothing)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.Parameters.Clear()
        If parameters IsNot Nothing Then
            perintah.Parameters.AddRange(parameters.ToArray())
        End If
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "datauser")
        dg.DataSource = ds.Tables("datauser")
        kon.Close()
    End Sub

    Sub prosesuser(ByVal sql As String, ByVal parameters As List(Of MySqlParameter))
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.Parameters.Clear()
        perintah.Parameters.AddRange(parameters.ToArray())
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Sub ambillevel()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from level_2421043 order by levelid"
        cek = perintah.ExecuteReader
        While cek.Read
            cmblevel.Items.Add(cek.Item("levelid") & " - " & cek.Item("levelakses"))
        End While
        kon.Close()
    End Sub

    Sub aktif()
        txtuser.Enabled = True
        txtnama.Enabled = True

        txtuser.BackColor = Color.White
        txtnama.BackColor = Color.White
    End Sub

    Sub tidakaktif()
        txtuser.Enabled = False
        txtnama.Enabled = False

        txtuser.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
    End Sub

    Sub bersih()
        txtuser.Text = ""
        txtnama.Text = ""
    End Sub
    Sub setdg()
        dg.Columns(0).HeaderText = "User Name"
        dg.Columns(1).HeaderText = "Nama Lengkap"
        dg.Columns(2).HeaderText = "Level"
        dg.Columns(3).HeaderText = "Status Aktif"

        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 200
        dg.Columns(2).Width = 70
        dg.Columns(3).Width = 70
    End Sub

    Private Sub Fuser_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tidakaktif()
        cmdsimpan.Enabled = False
    End Sub

    Private Sub Fuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmblevel.Items.Clear()
        ambillevel()

        tampilanuser("SELECT username, userfullname, levelakses, useraktif " &
             "FROM user_2421043 JOIN level_2421043 ON userlevelid = levelid ORDER BY username")
        setdg()
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "TAMBAH" Then
            txtuser.Enabled = True
            txtuser.Focus()
            txtuser.BackColor = Color.White
        Else
            tidakaktif()
            cmdsimpan.Enabled = False
            bersih()
        End If
    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "SELECT user_2421043.*,levelakses " &
                "from user_2421043 join level_2421043 on userlevelid = levelid " &
                "where username='" & txtuser.Text & "'"

                cek = perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    txtnama.Text = cek.Item("userfullname")
                    cmblevel.Text = cek.Item("userlevelid") & " - " & cek.Item("levelakses")
                    Dim status As String
                    status = cek.Item("useraktif")
                    If status = "Y" Then
                        rbaktif.Checked = True
                    Else
                        rbblokir.Checked = True
                    End If
                    simpan = False
                    cmdsimpan.Text = "UPDATE"
                Else
                    simpan = True
                    cmdsimpan.Text = "SIMPAN"
                End If
                cek.Close()
                kon.Close()
                aktif()
                txtnama.Focus()
                cmdsimpan.Enabled = True
                cmdtambah.Text = "BATAL"
        End Select
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        Dim statususer, pass As String
        If rbaktif.Checked = True Then
            statususer = "Y"
        Else
            statususer = "N"
        End If

        mnRandomNumber = getRandomNumber(1, 10000)
        pass = mnRandomNumber

        If cmdsimpan.Text = "SIMPAN" Then
            prosesuser("INSERT INTO user_2421043 VALUES(@username, @userfullname, md5(@password), @userlevelid, @useraktif)",
                       New List(Of MySqlParameter) From {
                           New MySqlParameter("@username", txtuser.Text),
                           New MySqlParameter("@userfullname", txtnama.Text),
                           New MySqlParameter("@password", pass),
                           New MySqlParameter("@userlevelid", cmblevel.Text.Substring(0, 1)),
                           New MySqlParameter("@useraktif", statususer)
                       })
            MsgBox("Password Anda " & pass & "", MsgBoxStyle.Information, "Informasi")
        Else
            prosesuser("UPDATE user_2421043 Set userfullname=@userfullname, userlevelid=@userlevelid, useraktif=@useraktif WHERE username=@username",
                        New List(Of MySqlParameter) From {
                           New MySqlParameter("@username", txtuser.Text),
                           New MySqlParameter("@userfullname", txtnama.Text),
                           New MySqlParameter("@userlevelid", cmblevel.Text.Substring(0, 1)),
                           New MySqlParameter("@useraktif", statususer)
                       })
            MsgBox("Data user telah diupdate", MsgBoxStyle.Information, "Informasi")
        End If

        tampilanuser("SELECT username, userfullname, levelakses, useraktif " &
             "FROM user_2421043 JOIN level_2421043 ON userlevelid = levelid ORDER BY username")
        setdg()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Dim pass As String
        mnRandomNumber = getRandomNumber(1, 10000)
        pass = mnRandomNumber

        prosesuser("UPDATE user_2421043 SET userpass=md5(@password) WHERE username=@username",
                   New List(Of MySqlParameter) From {
                       New MySqlParameter("@username", txtuser.Text),
                       New MySqlParameter("@password", pass)
                   })
        bersih()
        MsgBox("Password Baru Anda " & pass & "", MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        tampilanuser("SELECT * FROM user_2421043 WHERE username=@username OR userfullname LIKE @fullname",
                 New List(Of MySqlParameter) From {
                     New MySqlParameter("@username", txtcari.Text),
                     New MySqlParameter("@fullname", "%" & txtcari.Text & "%")
                 })
    End Sub
End Class