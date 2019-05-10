<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKitapStok
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
        Me.dgrListe = New System.Windows.Forms.DataGridView()
        Me.kitapid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitapad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yazar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yayinevi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.miktar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtArama = New System.Windows.Forms.TextBox()
        CType(Me.dgrListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrListe
        '
        Me.dgrListe.AllowUserToAddRows = False
        Me.dgrListe.AllowUserToDeleteRows = False
        Me.dgrListe.AllowUserToOrderColumns = True
        Me.dgrListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kitapid, Me.kitapad, Me.yazar, Me.yayinevi, Me.miktar})
        Me.dgrListe.Location = New System.Drawing.Point(12, 12)
        Me.dgrListe.Name = "dgrListe"
        Me.dgrListe.Size = New System.Drawing.Size(681, 374)
        Me.dgrListe.TabIndex = 11
        '
        'kitapid
        '
        Me.kitapid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.kitapid.DataPropertyName = "kitapid"
        Me.kitapid.HeaderText = "kitapid"
        Me.kitapid.Name = "kitapid"
        Me.kitapid.Visible = False
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
        'miktar
        '
        Me.miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.miktar.DataPropertyName = "miktar"
        Me.miktar.HeaderText = "Miktar"
        Me.miktar.Name = "miktar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtArama)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 393)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(680, 78)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bilgiler"
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
        'txtArama
        '
        Me.txtArama.Location = New System.Drawing.Point(125, 24)
        Me.txtArama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArama.MaxLength = 50
        Me.txtArama.Name = "txtArama"
        Me.txtArama.Size = New System.Drawing.Size(192, 20)
        Me.txtArama.TabIndex = 0
        '
        'frmKitapStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 482)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgrListe)
        Me.Name = "frmKitapStok"
        Me.Text = "frmKitapStok"
        CType(Me.dgrListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgrListe As DataGridView
    Friend WithEvents kitapid As DataGridViewTextBoxColumn
    Friend WithEvents kitapad As DataGridViewTextBoxColumn
    Friend WithEvents yazar As DataGridViewTextBoxColumn
    Friend WithEvents yayinevi As DataGridViewTextBoxColumn
    Friend WithEvents miktar As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtArama As TextBox
End Class
