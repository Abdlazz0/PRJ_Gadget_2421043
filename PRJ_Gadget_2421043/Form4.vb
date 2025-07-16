Imports MySql.Data
Public Class Fgantipassword
    Private Sub cmdgantipassword_Click(sender As Object, e As EventArgs) Handles cmdgantipassword.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Semua field harus diisi", MsgBoxStyle.Critical, "Peringatan")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "SELECT * FROM user_2421043 where username='" &
                useraktif.ToString & "'and userpass=md5('" & TextBox1.Text & "')"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                If TextBox2.Text <> TextBox3.Text Then
                    MsgBox("Password baru tidak sama", MsgBoxStyle.Critical, "Peringatan")
                Else
                    cek.Close()
                    perintah.CommandText = "UPDATE user_2421043 SET userpass=md5('" &
                        TextBox2.Text & "') WHERE username='" & useraktif.ToString & "'"
                    perintah.ExecuteNonQuery()
                    MsgBox("Password berhasil diganti", MsgBoxStyle.Information, "Informasi")
                End If
            Else
                MsgBox("Password Sekarang salah", MsgBoxStyle.Critical, "Peringatan")
            End If
            kon.Close()
        End If
        Me.Dispose()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox2.Focus()
        End Select
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox3.Focus()
        End Select
    End Sub
End Class