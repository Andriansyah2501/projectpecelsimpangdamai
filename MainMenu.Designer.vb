<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.statuskirim = New System.Windows.Forms.ComboBox()
        Me.cmbminuman = New System.Windows.Forms.ComboBox()
        Me.cmbmakanan = New System.Windows.Forms.ComboBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.txtnopelanggan = New System.Windows.Forms.TextBox()
        Me.dttbeli = New System.Windows.Forms.DateTimePicker()
        Me.hrgmakan = New System.Windows.Forms.TextBox()
        Me.hrgminum = New System.Windows.Forms.TextBox()
        Me.cmbnamakasir = New System.Windows.Forms.ComboBox()
        Me.lbltotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblongkir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldisc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(310, 38)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(553, 276)
        Me.dg.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PECEL LELE SIMPANG DAMAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMOR PELANGGAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TANGGAL PEMBELIAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga Makanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Harga Minuman"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nama Kasir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(94, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.statuskirim)
        Me.GroupBox1.Controls.Add(Me.cmbminuman)
        Me.GroupBox1.Controls.Add(Me.cmbmakanan)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 70)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU PESANAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Pengantaran"
        '
        'statuskirim
        '
        Me.statuskirim.FormattingEnabled = True
        Me.statuskirim.Items.AddRange(New Object() {"Pengantaran", "Makan di Tempat"})
        Me.statuskirim.Location = New System.Drawing.Point(133, 43)
        Me.statuskirim.Name = "statuskirim"
        Me.statuskirim.Size = New System.Drawing.Size(121, 21)
        Me.statuskirim.TabIndex = 1
        '
        'cmbminuman
        '
        Me.cmbminuman.FormattingEnabled = True
        Me.cmbminuman.Items.AddRange(New Object() {"Teh Obeng ", "Teh Pahit", "Teh Tarik", "Air Putih"})
        Me.cmbminuman.Location = New System.Drawing.Point(133, 19)
        Me.cmbminuman.Name = "cmbminuman"
        Me.cmbminuman.Size = New System.Drawing.Size(121, 21)
        Me.cmbminuman.TabIndex = 0
        '
        'cmbmakanan
        '
        Me.cmbmakanan.FormattingEnabled = True
        Me.cmbmakanan.Items.AddRange(New Object() {"Pecel Lele", "Ayam Penyet", "Nasi Goreng", "Nasi Uduk"})
        Me.cmbmakanan.Location = New System.Drawing.Point(6, 19)
        Me.cmbmakanan.Name = "cmbmakanan"
        Me.cmbmakanan.Size = New System.Drawing.Size(121, 21)
        Me.cmbmakanan.TabIndex = 0
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(178, 326)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 29)
        Me.btnhitung.TabIndex = 4
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(305, 320)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 48)
        Me.btnsimpan.TabIndex = 4
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(386, 320)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 48)
        Me.btnupdate.TabIndex = 4
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(467, 320)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 48)
        Me.btnhapus.TabIndex = 4
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(787, 359)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(67, 32)
        Me.btnkeluar.TabIndex = 4
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'txtnopelanggan
        '
        Me.txtnopelanggan.Location = New System.Drawing.Point(136, 35)
        Me.txtnopelanggan.Name = "txtnopelanggan"
        Me.txtnopelanggan.Size = New System.Drawing.Size(168, 20)
        Me.txtnopelanggan.TabIndex = 5
        '
        'dttbeli
        '
        Me.dttbeli.Location = New System.Drawing.Point(136, 60)
        Me.dttbeli.Name = "dttbeli"
        Me.dttbeli.Size = New System.Drawing.Size(168, 20)
        Me.dttbeli.TabIndex = 6
        '
        'hrgmakan
        '
        Me.hrgmakan.Enabled = False
        Me.hrgmakan.Location = New System.Drawing.Point(136, 164)
        Me.hrgmakan.Name = "hrgmakan"
        Me.hrgmakan.Size = New System.Drawing.Size(118, 20)
        Me.hrgmakan.TabIndex = 7
        '
        'hrgminum
        '
        Me.hrgminum.Enabled = False
        Me.hrgminum.Location = New System.Drawing.Point(136, 188)
        Me.hrgminum.Name = "hrgminum"
        Me.hrgminum.Size = New System.Drawing.Size(118, 20)
        Me.hrgminum.TabIndex = 7
        '
        'cmbnamakasir
        '
        Me.cmbnamakasir.FormattingEnabled = True
        Me.cmbnamakasir.Items.AddRange(New Object() {"Andrian Syah", "Maranti Nainggolan", "Dea Syaputri", "Hani Khairiyah", "Kevin Antoni"})
        Me.cmbnamakasir.Location = New System.Drawing.Point(135, 237)
        Me.cmbnamakasir.Name = "cmbnamakasir"
        Me.cmbnamakasir.Size = New System.Drawing.Size(118, 21)
        Me.cmbnamakasir.TabIndex = 8
        '
        'lbltotal
        '
        Me.lbltotal.Enabled = False
        Me.lbltotal.Location = New System.Drawing.Point(136, 300)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(118, 20)
        Me.lbltotal.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(16, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ongkir"
        '
        'lblongkir
        '
        Me.lblongkir.Location = New System.Drawing.Point(136, 211)
        Me.lblongkir.Name = "lblongkir"
        Me.lblongkir.Size = New System.Drawing.Size(118, 20)
        Me.lblongkir.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(80, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Discount"
        '
        'lbldisc
        '
        Me.lbldisc.Location = New System.Drawing.Point(136, 274)
        Me.lbldisc.Name = "lbldisc"
        Me.lbldisc.Size = New System.Drawing.Size(35, 20)
        Me.lbldisc.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "%"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 394)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbldisc)
        Me.Controls.Add(Me.lblongkir)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.cmbnamakasir)
        Me.Controls.Add(Me.hrgminum)
        Me.Controls.Add(Me.hrgmakan)
        Me.Controls.Add(Me.dttbeli)
        Me.Controls.Add(Me.txtnopelanggan)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pecel Lele Simpang Damai Apps"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents txtnopelanggan As System.Windows.Forms.TextBox
    Friend WithEvents dttbeli As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbminuman As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmakanan As System.Windows.Forms.ComboBox
    Friend WithEvents hrgmakan As System.Windows.Forms.TextBox
    Friend WithEvents hrgminum As System.Windows.Forms.TextBox
    Friend WithEvents cmbnamakasir As System.Windows.Forms.ComboBox
    Friend WithEvents lbltotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblongkir As System.Windows.Forms.TextBox
    Friend WithEvents statuskirim As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbldisc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
