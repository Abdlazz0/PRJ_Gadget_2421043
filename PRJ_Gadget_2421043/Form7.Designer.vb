<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMerk
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
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtnamamerk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(486, 19)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(159, 45)
        Me.cmdsimpan.TabIndex = 7
        Me.cmdsimpan.Text = "SIMPAN"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(17, 72)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(771, 359)
        Me.dg.TabIndex = 6
        '
        'txtnamamerk
        '
        Me.txtnamamerk.Location = New System.Drawing.Point(159, 19)
        Me.txtnamamerk.Name = "txtnamamerk"
        Me.txtnamamerk.Size = New System.Drawing.Size(306, 26)
        Me.txtnamamerk.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Merk"
        '
        'FMerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtnamamerk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FMerk"
        Me.Text = "TAMBAH MERK"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdsimpan As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtnamamerk As TextBox
    Friend WithEvents Label1 As Label
End Class
