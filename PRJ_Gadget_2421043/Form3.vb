Imports MySql.Data.MySqlClient
Public Class Fuser
    Dim mnRandomNumber As Integer

    Function getRandomNumber(ByVal vnMinimumNumber As Integer, ByVal vnMaximumNumber As Integer)
        Randomize()
        getRandomNumber = CInt(Int((vnMaximumNumber - vnMinimumNumber + 1) * Rnd() + vnMinimumNumber))
    End Function

    Sub tampilanuser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "datauser")
        dg.DataSource = ds.Tables("datauser")
        kon.Close()
    End Sub

    Sub prosesuser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Sub ambillevel()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from level order by levelid"
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

        tampilanuser("SELECT username,userfullname,levelakses,useraktif" &
                     "FROM USER JOIN LEVEL ON userlevelid=levelid order by username")
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


End Class