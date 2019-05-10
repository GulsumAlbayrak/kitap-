<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKitapsatis
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArama = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblListeToplam = New System.Windows.Forms.Label()
        Me.dgrListe = New System.Windows.Forms.DataGridView()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudMiktar = New System.Windows.Forms.NumericUpDown()
        Me.nudsatisFiyati = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpsatisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblToplamTutarX = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblYayineviX = New System.Windows.Forms.Label()
        Me.lblYazarX = New System.Windows.Forms.Label()
        Me.cmbKitapAd = New System.Windows.Forms.ComboBox()
        Me.satisid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitapad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yazar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yayinevi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satismiktari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satisfiyati = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toplamtutar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satistarihi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgrListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudsatisFiyati, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Kitap adına göre arama yapabilirsiniz."
        '
        'txtArama
        '
        Me.txtArama.Location = New System.Drawing.Point(125, 24)
        Me.txtArama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArama.MaxLength = 50
        Me.txtArama.Name = "txtArama"
        Me.txtArama.Size = New System.Drawing.Size(192, 20)
        Me.txtArama.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtArama)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 467)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(613, 78)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bilgiler"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Aranacak Değer"
        '
        'lblListeToplam
        '
        Me.lblListeToplam.Location = New System.Drawing.Point(13, 445)
        Me.lblListeToplam.Name = "lblListeToplam"
        Me.lblListeToplam.Size = New System.Drawing.Size(721, 18)
        Me.lblListeToplam.TabIndex = 19
        Me.lblListeToplam.Text = "XXXX"
        Me.lblListeToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrListe
        '
        Me.dgrListe.AllowUserToAddRows = False
        Me.dgrListe.AllowUserToDeleteRows = False
        Me.dgrListe.AllowUserToOrderColumns = True
        Me.dgrListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.satisid, Me.kitapad, Me.yazar, Me.yayinevi, Me.satismiktari, Me.satisfiyati, Me.toplamtutar, Me.satistarihi})
        Me.dgrListe.Location = New System.Drawing.Point(13, 164)
        Me.dgrListe.Name = "dgrListe"
        Me.dgrListe.Size = New System.Drawing.Size(721, 278)
        Me.dgrListe.TabIndex = 18
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(633, 84)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(117, 58)
        Me.btnSil.TabIndex = 16
        Me.btnSil.Text = "Satışı İptal Et"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(633, 20)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(117, 58)
        Me.btnKaydet.TabIndex = 14
        Me.btnKaydet.Text = "Satış Yap"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Yayınevi"
        '
        'nudMiktar
        '
        Me.nudMiktar.Location = New System.Drawing.Point(392, 54)
        Me.nudMiktar.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudMiktar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMiktar.Name = "nudMiktar"
        Me.nudMiktar.Size = New System.Drawing.Size(192, 20)
        Me.nudMiktar.TabIndex = 4
        Me.nudMiktar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudsatisFiyati
        '
        Me.nudsatisFiyati.DecimalPlaces = 2
        Me.nudsatisFiyati.Location = New System.Drawing.Point(392, 27)
        Me.nudsatisFiyati.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudsatisFiyati.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudsatisFiyati.Name = "nudsatisFiyati"
        Me.nudsatisFiyati.Size = New System.Drawing.Size(192, 20)
        Me.nudsatisFiyati.TabIndex = 3
        Me.nudsatisFiyati.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Miktar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Satış Fiyatı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Yazar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kitabın Adı"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpsatisTarihi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblToplamTutarX)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblYayineviX)
        Me.GroupBox1.Controls.Add(Me.lblYazarX)
        Me.GroupBox1.Controls.Add(Me.cmbKitapAd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudMiktar)
        Me.GroupBox1.Controls.Add(Me.nudsatisFiyati)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(613, 144)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bilgiler"
        '
        'dtpsatisTarihi
        '
        Me.dtpsatisTarihi.CustomFormat = "yyyy-MM-dd"
        Me.dtpsatisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsatisTarihi.Location = New System.Drawing.Point(392, 105)
        Me.dtpsatisTarihi.Name = "dtpsatisTarihi"
        Me.dtpsatisTarihi.Size = New System.Drawing.Size(192, 20)
        Me.dtpsatisTarihi.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 112)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Satış Tarihi"
        '
        'lblToplamTutarX
        '
        Me.lblToplamTutarX.AutoSize = True
        Me.lblToplamTutarX.Location = New System.Drawing.Point(389, 85)
        Me.lblToplamTutarX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToplamTutarX.Name = "lblToplamTutarX"
        Me.lblToplamTutarX.Size = New System.Drawing.Size(0, 13)
        Me.lblToplamTutarX.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Toplam Tutar"
        '
        'lblYayineviX
        '
        Me.lblYayineviX.AutoSize = True
        Me.lblYayineviX.Location = New System.Drawing.Point(87, 85)
        Me.lblYayineviX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayineviX.Name = "lblYayineviX"
        Me.lblYayineviX.Size = New System.Drawing.Size(0, 13)
        Me.lblYayineviX.TabIndex = 14
        '
        'lblYazarX
        '
        Me.lblYazarX.AutoSize = True
        Me.lblYazarX.Location = New System.Drawing.Point(87, 56)
        Me.lblYazarX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarX.Name = "lblYazarX"
        Me.lblYazarX.Size = New System.Drawing.Size(0, 13)
        Me.lblYazarX.TabIndex = 13
        '
        'cmbKitapAd
        '
        Me.cmbKitapAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKitapAd.FormattingEnabled = True
        Me.cmbKitapAd.Location = New System.Drawing.Point(90, 25)
        Me.cmbKitapAd.Name = "cmbKitapAd"
        Me.cmbKitapAd.Size = New System.Drawing.Size(176, 21)
        Me.cmbKitapAd.TabIndex = 12
        '
        'satisid
        '
        Me.satisid.DataPropertyName = "satisid"
        Me.satisid.HeaderText = "satisid"
        Me.satisid.Name = "satisid"
        Me.satisid.Visible = False
        '
        'kitapad
        '
        Me.kitapad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.kitapad.DataPropertyName = "kitapad"
        Me.kitapad.HeaderText = "Kitap"
        Me.kitapad.Name = "kitapad"
        Me.kitapad.Width = 56
        '
        'yazar
        '
        Me.yazar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.yazar.DataPropertyName = "yazar"
        Me.yazar.HeaderText = "Yazar"
        Me.yazar.Name = "yazar"
        Me.yazar.Width = 59
        '
        'yayinevi
        '
        Me.yayinevi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.yayinevi.DataPropertyName = "yayinevi"
        Me.yayinevi.HeaderText = "Yayınevi"
        Me.yayinevi.Name = "yayinevi"
        Me.yayinevi.Width = 72
        '
        'satismiktari
        '
        Me.satismiktari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.satismiktari.DataPropertyName = "satismiktari"
        Me.satismiktari.HeaderText = "Miktar"
        Me.satismiktari.Name = "satismiktari"
        Me.satismiktari.Width = 61
        '
        'satisfiyati
        '
        Me.satisfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.satisfiyati.DataPropertyName = "satisfiyati"
        Me.satisfiyati.HeaderText = "Satış Fiyatı"
        Me.satisfiyati.Name = "satisfiyati"
        Me.satisfiyati.Width = 82
        '
        'toplamtutar
        '
        Me.toplamtutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.toplamtutar.DataPropertyName = "toplamtutar"
        Me.toplamtutar.HeaderText = "Toplam Tutar"
        Me.toplamtutar.Name = "toplamtutar"
        Me.toplamtutar.Width = 95
        '
        'satistarihi
        '
        Me.satistarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.satistarihi.DataPropertyName = "satistarihi"
        Me.satistarihi.HeaderText = "Tarih"
        Me.satistarihi.Name = "satistarihi"
        '
        'frmKitapsatis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblListeToplam)
        Me.Controls.Add(Me.dgrListe)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmKitapsatis"
        Me.Text = "Satış İşlemleri"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgrListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudsatisFiyati, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtArama As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblListeToplam As Label
    Friend WithEvents dgrListe As DataGridView
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents nudMiktar As NumericUpDown
    Friend WithEvents nudsatisFiyati As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbKitapAd As ComboBox
    Friend WithEvents lblYayineviX As Label
    Friend WithEvents lblYazarX As Label
    Friend WithEvents lblToplamTutarX As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpsatisTarihi As DateTimePicker
    Friend WithEvents satisid As DataGridViewTextBoxColumn
    Friend WithEvents kitapad As DataGridViewTextBoxColumn
    Friend WithEvents yazar As DataGridViewTextBoxColumn
    Friend WithEvents yayinevi As DataGridViewTextBoxColumn
    Friend WithEvents satismiktari As DataGridViewTextBoxColumn
    Friend WithEvents satisfiyati As DataGridViewTextBoxColumn
    Friend WithEvents toplamtutar As DataGridViewTextBoxColumn
    Friend WithEvents satistarihi As DataGridViewTextBoxColumn
End Class
