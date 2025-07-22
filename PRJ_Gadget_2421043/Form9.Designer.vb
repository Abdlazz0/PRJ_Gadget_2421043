<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FJual
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotqty = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltotbay = New System.Windows.Forms.Label()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.cmdtambahpelanggan = New System.Windows.Forms.Button()
        Me.cmdcaripelanggan = New System.Windows.Forms.Button()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.txtpelanggannama = New System.Windows.Forms.TextBox()
        Me.txtpelangganid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjualnofaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdcetak = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblterbilang = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtjumlahuang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lbltgl)
        Me.Panel1.Controls.Add(Me.cmdtambahpelanggan)
        Me.Panel1.Controls.Add(Me.cmdcaripelanggan)
        Me.Panel1.Controls.Add(Me.cmdbaru)
        Me.Panel1.Controls.Add(Me.txtpelanggannama)
        Me.Panel1.Controls.Add(Me.txtpelangganid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtjualnofaktur)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 176)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Me.lbltotqty)
        Me.GroupBox2.Location = New System.Drawing.Point(707, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 60)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity"
        '
        'lbltotqty
        '
        Me.lbltotqty.AutoSize = True
        Me.lbltotqty.BackColor = System.Drawing.SystemColors.Info
        Me.lbltotqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotqty.Location = New System.Drawing.Point(17, 26)
        Me.lbltotqty.Name = "lbltotqty"
        Me.lbltotqty.Size = New System.Drawing.Size(105, 29)
        Me.lbltotqty.TabIndex = 0
        Me.lbltotqty.Text = "lbltotqty"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.lbltotbay)
        Me.GroupBox1.Location = New System.Drawing.Point(707, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 92)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Bayar"
        '
        'lbltotbay
        '
        Me.lbltotbay.AutoSize = True
        Me.lbltotbay.BackColor = System.Drawing.SystemColors.Info
        Me.lbltotbay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotbay.Location = New System.Drawing.Point(17, 26)
        Me.lbltotbay.Name = "lbltotbay"
        Me.lbltotbay.Size = New System.Drawing.Size(131, 32)
        Me.lbltotbay.TabIndex = 0
        Me.lbltotbay.Text = "lbltotbay"
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.ForeColor = System.Drawing.Color.Red
        Me.lbltgl.Location = New System.Drawing.Point(422, 23)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(47, 20)
        Me.lbltgl.TabIndex = 3
        Me.lbltgl.Text = "lbltgl"
        '
        'cmdtambahpelanggan
        '
        Me.cmdtambahpelanggan.Location = New System.Drawing.Point(647, 70)
        Me.cmdtambahpelanggan.Name = "cmdtambahpelanggan"
        Me.cmdtambahpelanggan.Size = New System.Drawing.Size(44, 26)
        Me.cmdtambahpelanggan.TabIndex = 2
        Me.cmdtambahpelanggan.Text = "+"
        Me.cmdtambahpelanggan.UseVisualStyleBackColor = True
        '
        'cmdcaripelanggan
        '
        Me.cmdcaripelanggan.Location = New System.Drawing.Point(332, 62)
        Me.cmdcaripelanggan.Name = "cmdcaripelanggan"
        Me.cmdcaripelanggan.Size = New System.Drawing.Size(83, 34)
        Me.cmdcaripelanggan.TabIndex = 2
        Me.cmdcaripelanggan.Text = "....."
        Me.cmdcaripelanggan.UseVisualStyleBackColor = True
        '
        'cmdbaru
        '
        Me.cmdbaru.Location = New System.Drawing.Point(332, 16)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(84, 34)
        Me.cmdbaru.TabIndex = 2
        Me.cmdbaru.Text = "Baru"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'txtpelanggannama
        '
        Me.txtpelanggannama.Location = New System.Drawing.Point(426, 70)
        Me.txtpelanggannama.Name = "txtpelanggannama"
        Me.txtpelanggannama.Size = New System.Drawing.Size(215, 26)
        Me.txtpelanggannama.TabIndex = 1
        '
        'txtpelangganid
        '
        Me.txtpelangganid.Location = New System.Drawing.Point(110, 66)
        Me.txtpelangganid.Name = "txtpelangganid"
        Me.txtpelangganid.Size = New System.Drawing.Size(215, 26)
        Me.txtpelangganid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pelanggan"
        '
        'txtjualnofaktur
        '
        Me.txtjualnofaktur.Location = New System.Drawing.Point(110, 20)
        Me.txtjualnofaktur.Name = "txtjualnofaktur"
        Me.txtjualnofaktur.Size = New System.Drawing.Size(215, 26)
        Me.txtjualnofaktur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Faktur"
        '
        'cmdcetak
        '
        Me.cmdcetak.Location = New System.Drawing.Point(12, 549)
        Me.cmdcetak.Name = "cmdcetak"
        Me.cmdcetak.Size = New System.Drawing.Size(142, 34)
        Me.cmdcetak.TabIndex = 2
        Me.cmdcetak.Text = "Cetak Faktur"
        Me.cmdcetak.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.lblterbilang)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(976, 60)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Terbilang"
        '
        'lblterbilang
        '
        Me.lblterbilang.AutoSize = True
        Me.lblterbilang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblterbilang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterbilang.Location = New System.Drawing.Point(17, 26)
        Me.lblterbilang.Name = "lblterbilang"
        Me.lblterbilang.Size = New System.Drawing.Size(145, 29)
        Me.lblterbilang.TabIndex = 0
        Me.lblterbilang.Text = "lblterbilang"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dg)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(976, 283)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Terbilang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(361, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tekan tombol ESC untuk menghapus item produk"
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(10, 25)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(951, 222)
        Me.dg.TabIndex = 0
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(160, 549)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(142, 34)
        Me.cmdsimpan.TabIndex = 2
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(308, 549)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(142, 34)
        Me.cmdkeluar.TabIndex = 2
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(668, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Jumlah Uang"
        '
        'txtjumlahuang
        '
        Me.txtjumlahuang.Location = New System.Drawing.Point(788, 549)
        Me.txtjumlahuang.Name = "txtjumlahuang"
        Me.txtjumlahuang.Size = New System.Drawing.Size(200, 26)
        Me.txtjumlahuang.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(668, 582)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kembalian"
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(788, 581)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(200, 26)
        Me.txtkembali.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1002, 620)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdcetak)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtjumlahuang)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FJual"
        Me.Text = "ENTRI DATA PENJUALAN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdcaripelanggan As Button
    Friend WithEvents cmdcetak As Button
    Friend WithEvents txtpelangganid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjualnofaktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltgl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltotbay As Label
    Friend WithEvents cmdtambahpelanggan As Button
    Friend WithEvents txtpelanggannama As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbltotqty As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblterbilang As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtjumlahuang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents cmdbaru As Button
    Friend WithEvents Timer1 As Timer
End Class
