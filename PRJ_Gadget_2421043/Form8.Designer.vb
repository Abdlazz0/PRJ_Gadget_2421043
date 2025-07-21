<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPelanggan
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtidpelanggan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(59, 295)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(713, 217)
        Me.dg.TabIndex = 23
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(383, 175)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(102, 38)
        Me.cmdkeluar.TabIndex = 19
        Me.cmdkeluar.Text = "KELUAR"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhapus.Location = New System.Drawing.Point(275, 175)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(102, 38)
        Me.cmdhapus.TabIndex = 18
        Me.cmdhapus.Text = "HAPUS"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(167, 175)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(102, 38)
        Me.cmdsimpan.TabIndex = 22
        Me.cmdsimpan.Text = "SIMPAN"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdtambah
        '
        Me.cmdtambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtambah.Location = New System.Drawing.Point(59, 175)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(102, 38)
        Me.cmdtambah.TabIndex = 17
        Me.cmdtambah.Text = "TAMBAH"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(59, 252)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(484, 26)
        Me.txtcari.TabIndex = 11
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(224, 60)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(319, 26)
        Me.txtnama.TabIndex = 12
        '
        'txtidpelanggan
        '
        Me.txtidpelanggan.Location = New System.Drawing.Point(224, 27)
        Me.txtidpelanggan.Name = "txtidpelanggan"
        Me.txtidpelanggan.Size = New System.Drawing.Size(148, 26)
        Me.txtidpelanggan.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cari Kode / Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(224, 92)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(503, 26)
        Me.txtalamat.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. Hp"
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(224, 124)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(153, 26)
        Me.txtnohp.TabIndex = 12
        '
        'FPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 536)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtidpelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPelanggan"
        Me.Text = "DATA PELANGGAN"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg As DataGridView
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdtambah As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtidpelanggan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnohp As TextBox
End Class
