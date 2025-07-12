Imports MySql.Data.MySqlClient
Public Class FLogin
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * FROM user_2421043 " &
            " WHERE username='" & txtusername.Text & "' " &
            "AND userpass=MD5('" & txtpassword.Text & "')"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            Dim level As String
            level = cek.Item("userlevelid")
            useraktif = txtusername.Text

            If level = "1" Then
                FMenu.SETTINGToolStripMenuItem.Visible = True
            Else
                FMenu.SETTINGToolStripMenuItem.Visible = False
            End If
            FMenu.ToolStripStatusLabel2.Text = txtusername.Text
            FMenu.Show()
            Me.Hide()
        Else
            MsgBox("Username atau Password salah", MsgBoxStyle.Critical, "Peringatan")
        End If
        kon.Close()
    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        End
    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpassword.Focus()
        End Select
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmdlogin.Focus()
        End Select
    End Sub
End Class
