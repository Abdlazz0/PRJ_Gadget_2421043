<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fuser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cmblevel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbaktif = New System.Windows.Forms.RadioButton()
        Me.rbblokir = New System.Windows.Forms.RadioButton()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(233, 23)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(244, 26)
        Me.txtuser.TabIndex = 3
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(233, 62)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(434, 26)
        Me.txtnama.TabIndex = 4
        '
        'cmblevel
        '
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Items.AddRange(New Object() {"Admin", "Kasir"})
        Me.cmblevel.Location = New System.Drawing.Point(233, 102)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(244, 28)
        Me.cmblevel.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status"
        '
        'rbaktif
        '
        Me.rbaktif.AutoSize = True
        Me.rbaktif.Location = New System.Drawing.Point(233, 142)
        Me.rbaktif.Name = "rbaktif"
        Me.rbaktif.Size = New System.Drawing.Size(66, 24)
        Me.rbaktif.TabIndex = 7
        Me.rbaktif.TabStop = True
        Me.rbaktif.Text = "Aktif"
        Me.rbaktif.UseVisualStyleBackColor = True
        '
        'rbblokir
        '
        Me.rbblokir.AutoSize = True
        Me.rbblokir.Location = New System.Drawing.Point(319, 144)
        Me.rbblokir.Name = "rbblokir"
        Me.rbblokir.Size = New System.Drawing.Size(108, 24)
        Me.rbblokir.TabIndex = 8
        Me.rbblokir.TabStop = True
        Me.rbblokir.Text = "Tidak Aktif"
        Me.rbblokir.UseVisualStyleBackColor = True
        '
        'cmdreset
        '
        Me.cmdreset.Location = New System.Drawing.Point(523, 144)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(231, 35)
        Me.cmdreset.TabIndex = 9
        Me.cmdreset.Text = "Reset Password"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'cmdtambah
        '
        Me.cmdtambah.Location = New System.Drawing.Point(18, 188)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(123, 35)
        Me.cmdtambah.TabIndex = 10
        Me.cmdtambah.Text = "TAMBAH"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(147, 188)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(123, 35)
        Me.cmdsimpan.TabIndex = 11
        Me.cmdsimpan.Text = "SIMPAN"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(276, 188)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(123, 35)
        Me.cmdkeluar.TabIndex = 12
        Me.cmdkeluar.Text = "KELUAR"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(405, 192)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(349, 26)
        Me.txtcari.TabIndex = 13
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(18, 230)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(736, 208)
        Me.dg.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 27)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Isi dan Tekan Enter"
        '
        'Fuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.rbblokir)
        Me.Controls.Add(Me.rbaktif)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmblevel)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fuser"
        Me.Text = "Data User"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents cmblevel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbaktif As RadioButton
    Friend WithEvents rbblokir As RadioButton
    Friend WithEvents cmdreset As Button
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label5 As Label
End Class
