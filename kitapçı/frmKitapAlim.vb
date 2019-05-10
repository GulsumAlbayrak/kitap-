Imports System.Data.SQLite

Public Class frmKitapAlim

    Dim tConnection As New SQLiteConnection("Data Source=data.db;Version=3;Pooling=True;Synchronous=Full;")

    Dim cmbKitapAdID() As Integer

    Private Sub frmKitapAlim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        ReDim cmbKitapAdID(0)

        Dim tDataReader As SQLiteDataReader

        Dim tCommand As New SQLiteCommand
        tCommand.Connection = tConnection
        tCommand.CommandType = CommandType.Text

        tCommand.CommandText = "Select * from kitap_bilgi"
        tConnection.Open()
        tDataReader = tCommand.ExecuteReader
        Do While tDataReader.Read
            ReDim Preserve cmbKitapAdID(i)
            cmbKitapAd.Items.Add(tDataReader("kitapad").ToString.Trim)
            cmbKitapAdID(i) = tDataReader("kitapid")
            i += 1
        Loop
        tConnection.Close()
        dgrListe_Yenile()
    End Sub

    Private Sub cmbKitapAd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKitapAd.SelectedIndexChanged
        lblYazarX.Text = ""
        lblYayineviX.Text = ""
        If cmbKitapAd.SelectedIndex > -1 Then
            Dim tDataReader As SQLiteDataReader

            Dim tCommand As New SQLiteCommand
            tCommand.Connection = tConnection
            tCommand.CommandType = CommandType.Text

            tCommand.CommandText = "Select * from kitap_bilgi Where kitapid=" & cmbKitapAdID(cmbKitapAd.SelectedIndex)
            tConnection.Open()
            tDataReader = tCommand.ExecuteReader
            Do While tDataReader.Read
                lblYazarX.Text = tDataReader("yazar").ToString.Trim
                lblYayineviX.Text = tDataReader("yayinevi").ToString.Trim
                Exit Do
            Loop
            tConnection.Close()
        End If
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nudAlisFiyati.ValueChanged, nudMiktar.ValueChanged
        lblToplamTutarX.Text = nudAlisFiyati.Value * nudMiktar.Value
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If Not cmbKitapAd.SelectedIndex > -1 Then
            MsgBox("Lütfen alımı yapılacak kitabı seçiniz...")
            cmbKitapAd.Focus()
            Exit Sub
        End If

        Dim tCommand As New SQLiteCommand
        tCommand.Connection = tConnection
        tCommand.CommandType = CommandType.Text

        tCommand.CommandText = "INSERT INTO kitap_alim(kitapid, alisfiyati, alimmiktari, alimtarihi) VALUES(" & cmbKitapAdID(cmbKitapAd.SelectedIndex) & ", " & nudAlisFiyati.Value.ToString.Replace(",", ".") & ", " & nudMiktar.Value & ", '" & dtpAlimTarihi.Text.Trim & "');"
        tCommand.CommandText &= "UPDATE kitap_stok SET miktar=miktar+" & nudMiktar.Value & " Where kitapid=" & cmbKitapAdID(cmbKitapAd.SelectedIndex) & ";"
        tConnection.Open()
        tCommand.ExecuteNonQuery()
        tConnection.Close()
        MsgBox("Alım yapıldı...")
        dgrListe_Yenile()
    End Sub

    Sub dgrListe_Yenile()
        Dim tDataset As New DataSet
        Dim tDataAdapter As SQLiteDataAdapter
        'If txtArama.Text.Trim.Length > 0 Then
        '    tDataAdapter = New SQLiteDataAdapter("Select * from kitap_bilgi Where kitapad LIKE '%" & txtArama.Text.Trim & "%' or yayinevi LIKE '%" & txtArama.Text.Trim & "%' or yazar LIKE '%" & txtArama.Text.Trim & "%'", tConnection)
        'Else
        tDataAdapter = New SQLiteDataAdapter("Select kitap_alim.alimid, kitap_bilgi.kitapad, kitap_bilgi.yazar, kitap_bilgi.yayinevi, kitap_alim.alimmiktari, kitap_alim.alisfiyati, (kitap_alim.alimmiktari*kitap_alim.alisfiyati) as toplamtutar,  kitap_alim.alimtarihi from kitap_alim Inner Join kitap_bilgi ON kitap_bilgi.kitapid=kitap_alim.kitapid", tConnection)
        'End If
        tDataAdapter.Fill(tDataset, "kitap_alim")
        dgrListe.DataSource = tDataset.Tables("kitap_alim")
        If dgrListe.RowCount > 0 Then
            lblListeToplam.Text = dgrListe.RowCount & " kayıt listelendi."
        Else
            lblListeToplam.Text = "Listelenecek bir kayıt bulunmamaktadır."
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If dgrListe.RowCount > 0 Then
            If dgrListe.CurrentRow.Index > -1 Then
                If MsgBox("Seçmiş olduğunuz alım işlemi iptal edilecek. Bu işlem geri alınamaz!!! Emin misiniz?", MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                    Dim tCommand As New SQLiteCommand
                    tCommand.Connection = tConnection
                    tCommand.CommandType = CommandType.Text
                    tCommand.CommandText = "UPDATE kitap_stok SET miktar=miktar-(Select alimmiktari from kitap_alim Where alimid=" & dgrListe.Item(0, dgrListe.CurrentRow.Index).Value & ")
                    Where kitapid=(Select kitapid from kitap_alim Where alimid=" & dgrListe.Item(0, dgrListe.CurrentRow.Index).Value & "); "
                    tCommand.CommandText &= "Delete from kitap_alim Where alimid=" & dgrListe.Item(0, dgrListe.CurrentRow.Index).Value & "; "

                    tConnection.Open()
                    tCommand.ExecuteNonQuery()
                    tConnection.Close()
                    MsgBox("Alım işlemi iptal edildi.")
                    dgrListe_Yenile()
                End If
            End If
        End If
    End Sub

    Private Sub frmKitapAlim_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmANA.Show()
    End Sub

    Private Sub dgrListe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrListe.CellContentClick

    End Sub

    Private Sub dtpAlimTarihi_ValueChanged(sender As Object, e As EventArgs) Handles dtpAlimTarihi.ValueChanged

    End Sub
End Class