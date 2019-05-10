<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKitapBilgi
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSatistami = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYayinevi = New System.Windows.Forms.TextBox()
        Me.nudBaski = New System.Windows.Forms.NumericUpDown()
        Me.nudSayfa = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtYazar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKitapAd = New System.Windows.Forms.TextBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnDuzelt = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.dgrListe = New System.Windows.Forms.DataGridView()
        Me.kitapid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitapad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yazar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yayinevi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sayfa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Baskı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satistami = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblListeToplam = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtArama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudBaski, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSayfa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSatistami)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtYayinevi)
        Me.GroupBox1.Controls.Add(Me.nudBaski)
        Me.GroupBox1.Controls.Add(Me.nudSayfa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtYazar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKitapAd)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(613, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bilgiler"
        '
        'chkSatistami
        '
        Me.chkSatistami.AutoSize = True
        Me.chkSatistami.Checked = True
        Me.chkSatistami.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSatistami.ForeColor = System.Drawing.Color.Green
        Me.chkSatistami.Location = New System.Drawing.Point(392, 84)
        Me.chkSatistami.Name = "chkSatistami"
        Me.chkSatistami.Size = New System.Drawing.Size(107, 19)
        Me.chkSatistami.TabIndex = 5
        Me.chkSatistami.Text = "Kitap Satışta"
        Me.chkSatistami.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Yayınevi"
        '
        'txtYayinevi
        '
        Me.txtYayinevi.Location = New System.Drawing.Point(92, 85)
        Me.txtYayinevi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinevi.MaxLength = 50
        Me.txtYayinevi.Name = "txtYayinevi"
        Me.txtYayinevi.Size = New System.Drawing.Size(192, 21)
        Me.txtYayinevi.TabIndex = 2
        '
        'nudBaski
        '
        Me.nudBaski.Location = New System.Drawing.Point(392, 54)
        Me.nudBaski.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudBaski.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBaski.Name = "nudBaski"
        Me.nudBaski.Size = New System.Drawing.Size(192, 21)
        Me.nudBaski.TabIndex = 4
        Me.nudBaski.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSayfa
        '
        Me.nudSayfa.Location = New System.Drawing.Point(392, 27)
        Me.nudSayfa.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudSayfa.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSayfa.Name = "nudSayfa"
        Me.nudSayfa.Size = New System.Drawing.Size(192, 21)
        Me.nudSayfa.TabIndex = 3
        Me.nudSayfa.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Baskı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sayfa Sayısı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Yazar"
        '
        'txtYazar
        '
        Me.txtYazar.Location = New System.Drawing.Point(92, 56)
        Me.txtYazar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYazar.MaxLength = 50
        Me.txtYazar.Name = "txtYazar"
        Me.txtYazar.Size = New System.Drawing.Size(192, 21)
        Me.txtYazar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kitabın Adı"
        '
        'txtKitapAd
        '
        Me.txtKitapAd.Location = New System.Drawing.Point(92, 27)
        Me.txtKitapAd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKitapAd.MaxLength = 50
        Me.txtKitapAd.Name = "txtKitapAd"
        Me.txtKitapAd.Size = New System.Drawing.Size(192, 21)
        Me.txtKitapAd.TabIndex = 0
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(636, 21)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(117, 58)
        Me.btnKaydet.TabIndex = 6
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'btnDuzelt
        '
        Me.btnDuzelt.Location = New System.Drawing.Point(636, 85)
        Me.btnDuzelt.Name = "btnDuzelt"
        Me.btnDuzelt.Size = New System.Drawing.Size(117, 58)
        Me.btnDuzelt.TabIndex = 7
        Me.btnDuzelt.Text = "Düzelt"
        Me.btnDuzelt.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(636, 149)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(117, 58)
        Me.btnSil.TabIndex = 8
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(636, 213)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(117, 58)
        Me.btnTemizle.TabIndex = 9
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = True
        '
        'dgrListe
        '
        Me.dgrListe.AllowUserToAddRows = False
        Me.dgrListe.AllowUserToDeleteRows = False
        Me.dgrListe.AllowUserToOrderColumns = True
        Me.dgrListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kitapid, Me.kitapad, Me.yazar, Me.yayinevi, Me.sayfa, Me.Baskı, Me.satistami})
        Me.dgrListe.Location = New System.Drawing.Point(16, 142)
        Me.dgrListe.Name = "dgrListe"
        Me.dgrListe.Size = New System.Drawing.Size(613, 301)
        Me.dgrListe.TabIndex = 10
        '
        'kitapid
        '
        Me.kitapid.DataPropertyName = "kitapid"
        Me.kitapid.HeaderText = "kitapid"
        Me.kitapid.Name = "kitapid"
        Me.kitapid.Visible = False
        '
        'kitapad
        '
        Me.kitapad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.kitapad.DataPropertyName = "kitapad"
        Me.kitapad.HeaderText = "Kitap Adı"
        Me.kitapad.Name = "kitapad"
        Me.kitapad.Width = 89
        '
        'yazar
        '
        Me.yazar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.yazar.DataPropertyName = "yazar"
        Me.yazar.HeaderText = "Yazar"
        Me.yazar.Name = "yazar"
        Me.yazar.Width = 68
        '
        'yayinevi
        '
        Me.yayinevi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.yayinevi.DataPropertyName = "yayinevi"
        Me.yayinevi.HeaderText = "Yayınevi"
        Me.yayinevi.Name = "yayinevi"
        Me.yayinevi.Width = 84
        '
        'sayfa
        '
        Me.sayfa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.sayfa.DataPropertyName = "sayfa"
        Me.sayfa.HeaderText = "Sayfa Sayısı"
        Me.sayfa.Name = "sayfa"
        Me.sayfa.Width = 109
        '
        'Baskı
        '
        Me.Baskı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Baskı.DataPropertyName = "baski"
        Me.Baskı.HeaderText = "Baskı"
        Me.Baskı.Name = "Baskı"
        '
        'satistami
        '
        Me.satistami.DataPropertyName = "satistami"
        Me.satistami.HeaderText = "satistami"
        Me.satistami.Name = "satistami"
        Me.satistami.Visible = False
        '
        'lblListeToplam
        '
        Me.lblListeToplam.Location = New System.Drawing.Point(16, 446)
        Me.lblListeToplam.Name = "lblListeToplam"
        Me.lblListeToplam.Size = New System.Drawing.Size(613, 18)
        Me.lblListeToplam.TabIndex = 11
        Me.lblListeToplam.Text = "XXXX"
        Me.lblListeToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtArama)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 468)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(613, 78)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bilgiler"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Aranacak Değer"
        '
        'txtArama
        '
        Me.txtArama.Location = New System.Drawing.Point(125, 24)
        Me.txtArama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArama.MaxLength = 50
        Me.txtArama.Name = "txtArama"
        Me.txtArama.Size = New System.Drawing.Size(192, 21)
        Me.txtArama.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Kitap adına göre arama yapabilirsiniz."
        '
        'frmKitapBilgi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 630)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblListeToplam)
        Me.Controls.Add(Me.dgrListe)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzelt)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmKitapBilgi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kitap Listesi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudBaski, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSayfa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkSatistami As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtYayinevi As TextBox
    Friend WithEvents nudBaski As NumericUpDown
    Friend WithEvents nudSayfa As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYazar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKitapAd As TextBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnDuzelt As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnTemizle As Button
    Friend WithEvents dgrListe As DataGridView
    Friend WithEvents kitapid As DataGridViewTextBoxColumn
    Friend WithEvents kitapad As DataGridViewTextBoxColumn
    Friend WithEvents yazar As DataGridViewTextBoxColumn
    Friend WithEvents yayinevi As DataGridViewTextBoxColumn
    Friend WithEvents sayfa As DataGridViewTextBoxColumn
    Friend WithEvents Baskı As DataGridViewTextBoxColumn
    Friend WithEvents satistami As DataGridViewTextBoxColumn
    Friend WithEvents lblListeToplam As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtArama As TextBox
    Friend WithEvents Label6 As Label
End Class
