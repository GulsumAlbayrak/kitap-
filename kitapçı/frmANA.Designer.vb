<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmANA
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTarihSaat = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnKitapListesi = New System.Windows.Forms.Button()
        Me.btnKitapStok = New System.Windows.Forms.Button()
        Me.btnKitapAlis = New System.Windows.Forms.Button()
        Me.btnKitapSatis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KİTAPÇI v1.00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTarihSaat
        '
        Me.lblTarihSaat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTarihSaat.Location = New System.Drawing.Point(12, 361)
        Me.lblTarihSaat.Name = "lblTarihSaat"
        Me.lblTarihSaat.Size = New System.Drawing.Size(263, 25)
        Me.lblTarihSaat.TabIndex = 1
        Me.lblTarihSaat.Text = "XX-XX-XXXX XX:XX:XX"
        Me.lblTarihSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnKitapListesi
        '
        Me.btnKitapListesi.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnKitapListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapListesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapListesi.Location = New System.Drawing.Point(12, 48)
        Me.btnKitapListesi.Name = "btnKitapListesi"
        Me.btnKitapListesi.Size = New System.Drawing.Size(263, 55)
        Me.btnKitapListesi.TabIndex = 2
        Me.btnKitapListesi.Text = "Kitap Listesi"
        Me.btnKitapListesi.UseVisualStyleBackColor = False
        '
        'btnKitapStok
        '
        Me.btnKitapStok.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnKitapStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapStok.Location = New System.Drawing.Point(12, 109)
        Me.btnKitapStok.Name = "btnKitapStok"
        Me.btnKitapStok.Size = New System.Drawing.Size(263, 55)
        Me.btnKitapStok.TabIndex = 3
        Me.btnKitapStok.Text = "Kitap Stok"
        Me.btnKitapStok.UseVisualStyleBackColor = False
        '
        'btnKitapAlis
        '
        Me.btnKitapAlis.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnKitapAlis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapAlis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapAlis.Location = New System.Drawing.Point(12, 170)
        Me.btnKitapAlis.Name = "btnKitapAlis"
        Me.btnKitapAlis.Size = New System.Drawing.Size(263, 55)
        Me.btnKitapAlis.TabIndex = 4
        Me.btnKitapAlis.Text = "Alış İşlemleri"
        Me.btnKitapAlis.UseVisualStyleBackColor = False
        '
        'btnKitapSatis
        '
        Me.btnKitapSatis.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnKitapSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapSatis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapSatis.Location = New System.Drawing.Point(12, 231)
        Me.btnKitapSatis.Name = "btnKitapSatis"
        Me.btnKitapSatis.Size = New System.Drawing.Size(263, 55)
        Me.btnKitapSatis.TabIndex = 5
        Me.btnKitapSatis.Text = "Satış İşlemleri"
        Me.btnKitapSatis.UseVisualStyleBackColor = False
        '
        'frmANA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(287, 395)
        Me.Controls.Add(Me.btnKitapSatis)
        Me.Controls.Add(Me.btnKitapAlis)
        Me.Controls.Add(Me.btnKitapStok)
        Me.Controls.Add(Me.btnKitapListesi)
        Me.Controls.Add(Me.lblTarihSaat)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmANA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kitapçı v1.00"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTarihSaat As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnKitapListesi As Button
    Friend WithEvents btnKitapStok As Button
    Friend WithEvents btnKitapAlis As Button
    Friend WithEvents btnKitapSatis As Button
End Class
