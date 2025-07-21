<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKategori
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
        Me.txtnamakategori = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Kategori"
        '
        'txtnamakategori
        '
        Me.txtnamakategori.Location = New System.Drawing.Point(159, 26)
        Me.txtnamakategori.Name = "txtnamakategori"
        Me.txtnamakategori.Size = New System.Drawing.Size(306, 26)
        Me.txtnamakategori.TabIndex = 1
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(17, 79)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(771, 359)
        Me.dg.TabIndex = 2
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(486, 26)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(159, 45)
        Me.cmdsimpan.TabIndex = 3
        Me.cmdsimpan.Text = "SIMPAN"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'FKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtnamakategori)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FKategori"
        Me.Text = "TAMBAH KATEGORI"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnamakategori As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents cmdsimpan As Button
End Class
