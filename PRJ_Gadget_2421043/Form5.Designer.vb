<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProduk
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
        Me.txtprodukid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtproduknama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbkategori = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbmerk = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprodukstok = New System.Windows.Forms.TextBox()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdcarikategori = New System.Windows.Forms.Button()
        Me.cmdcarimerk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Produk"
        '
        'txtprodukid
        '
        Me.txtprodukid.Location = New System.Drawing.Point(205, 37)
        Me.txtprodukid.Name = "txtprodukid"
        Me.txtprodukid.Size = New System.Drawing.Size(148, 26)
        Me.txtprodukid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'txtproduknama
        '
        Me.txtproduknama.Location = New System.Drawing.Point(205, 70)
        Me.txtproduknama.Name = "txtproduknama"
        Me.txtproduknama.Size = New System.Drawing.Size(319, 26)
        Me.txtproduknama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kategori"
        '
        'cmbkategori
        '
        Me.cmbkategori.FormattingEnabled = True
        Me.cmbkategori.Location = New System.Drawing.Point(205, 108)
        Me.cmbkategori.Name = "cmbkategori"
        Me.cmbkategori.Size = New System.Drawing.Size(247, 28)
        Me.cmbkategori.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Merk"
        '
        'cmbmerk
        '
        Me.cmbmerk.FormattingEnabled = True
        Me.cmbmerk.Location = New System.Drawing.Point(205, 154)
        Me.cmbmerk.Name = "cmbmerk"
        Me.cmbmerk.Size = New System.Drawing.Size(247, 28)
        Me.cmbmerk.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Stok"
        '
        'txtprodukstok
        '
        Me.txtprodukstok.Location = New System.Drawing.Point(205, 198)
        Me.txtprodukstok.Name = "txtprodukstok"
        Me.txtprodukstok.Size = New System.Drawing.Size(77, 26)
        Me.txtprodukstok.TabIndex = 1
        '
        'cmdtambah
        '
        Me.cmdtambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtambah.Location = New System.Drawing.Point(40, 235)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(102, 38)
        Me.cmdtambah.TabIndex = 3
        Me.cmdtambah.Text = "TAMBAH"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(148, 235)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(102, 38)
        Me.cmdsimpan.TabIndex = 3
        Me.cmdsimpan.Text = "SIMPAN"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhapus.Location = New System.Drawing.Point(256, 235)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(102, 38)
        Me.cmdhapus.TabIndex = 3
        Me.cmdhapus.Text = "HAPUS"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(364, 235)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(102, 38)
        Me.cmdkeluar.TabIndex = 3
        Me.cmdkeluar.Text = "KELUAR"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdcarikategori
        '
        Me.cmdcarikategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcarikategori.Location = New System.Drawing.Point(458, 102)
        Me.cmdcarikategori.Name = "cmdcarikategori"
        Me.cmdcarikategori.Size = New System.Drawing.Size(66, 38)
        Me.cmdcarikategori.TabIndex = 3
        Me.cmdcarikategori.Text = "+"
        Me.cmdcarikategori.UseVisualStyleBackColor = True
        '
        'cmdcarimerk
        '
        Me.cmdcarimerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcarimerk.Location = New System.Drawing.Point(458, 148)
        Me.cmdcarimerk.Name = "cmdcarimerk"
        Me.cmdcarimerk.Size = New System.Drawing.Size(66, 38)
        Me.cmdcarimerk.TabIndex = 3
        Me.cmdcarimerk.Text = "+"
        Me.cmdcarimerk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cari Kode / Nama Produk"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(40, 312)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(484, 26)
        Me.txtcari.TabIndex = 1
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(40, 355)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(713, 217)
        Me.dg.TabIndex = 4
        '
        'FProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 608)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cmdcarimerk)
        Me.Controls.Add(Me.cmdcarikategori)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.cmbmerk)
        Me.Controls.Add(Me.cmbkategori)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtproduknama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprodukstok)
        Me.Controls.Add(Me.txtprodukid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FProduk"
        Me.Text = "DATA PRODUK"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtprodukid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtproduknama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbkategori As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbmerk As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprodukstok As TextBox
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdcarikategori As Button
    Friend WithEvents cmdcarimerk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents dg As DataGridView
End Class
