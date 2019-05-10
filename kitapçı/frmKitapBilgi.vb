Imports System.Data.SQLite

Public Class frmKitapBilgi

    Dim tConnection As New SQLiteConnection("Data Source=data.db;Version=3;Pooling=True;Synchronous=Full;")
    Dim tCommand As New SQLiteCommand()
    Private Sub frmKitapBilgi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmANA.Show()
    End Sub

    Private Sub chkSatistami_CheckedChanged(sender As Object, e As EventArgs) Handles chkSatistami.CheckedChanged
        If chkSatistami.Checked = True Then
            chkSatistami.Text = "Kitap Satışta"
            chkSatistami.ForeColor = Color.Green
        Else
            chkSatistami.Text = "Satış Dışı"
            chkSatistami.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        txtKitapAd.Clear()
        txtYayinevi.Clear()
        txtYazar.Clear()
        nudBaski.Value = 1
        nudSayfa.Value = 1
        chkSatistami.Checked = True
        txtKitapAd.Focus()
    End Sub

    Private Sub frmKitapBilgi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgrListe_Yenile()
        dgrListe_Click(sender, EventArgs.Empty)
    End Sub

    Sub dgrListe_Yenile()
        Dim tDataset As New DataSet
        Dim tDataAdapter As SQLiteDataAdapter
        If txtArama.Text.Trim.Length > 0 Then
            tDataAdapter = New SQLiteDataAdapter("Select * from kitap_bilgi Where kitapad LIKE '%" & txtArama.Text.Trim & "%' or yayinevi LIKE '%" & txtArama.Text.Trim & "%' or yazar LIKE '%" & txtArama.Text.Trim & "%'", tConnection)
        Else
            tDataAdapter = New SQLiteDataAdapter("Select * from kitap_bilgi", tConnection)
        End If
        tDataAdapter.Fill(tDataset, "kitap_bilgi")
        dgrListe.DataSource = tDataset.Tables("kitap_bilgi")
        If dgrListe.RowCount > 0 Then
            lblListeToplam.Text = dgrListe.RowCount & " kayıt listelendi."
        Else
            lblListeToplam.Text = "Listelenecek bir kayıt bulunmamaktadır."
        End If
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtKitapAd.Text.Trim.Length <= 0 Then
            MsgBox("Lütfen kitabın adını giriniz...")
            txtKitapAd.Focus()
            Exit Sub
        End If

        Dim tGeriDonenDeger As Integer

        tCommand.Connection = tConnection
        tCommand.CommandType = CommandType.Text

        tCommand.CommandText = "Select Count(*) from kitap_bilgi Where kitapad='" & txtKitapAd.Text.Trim & "' and yayinevi='" & txtYayinevi.Text.Trim & "' and yazar='" & txtYazar.Text.Trim & "'"
        tConnection.Open()
        tGeriDonenDeger = tCommand.ExecuteScalar()
        tConnection.Close()
        If tGeriDonenDeger > 0 Then
            MsgBox("Aynı bilgilere sahip bir kitap kaydı bulundu. Kaydetmek istediğiniz kitabın daha önce kaydedilip edilmediğini lütfen kontrol ediniz...")
            Exit Sub
        End If

        tCommand.CommandText = "INSERT INTO kitap_bilgi(kitapad, yayinevi, yazar, baski, sayfa, satistami) VALUES('" & txtKitapAd.Text.Trim & "', '" & txtYayinevi.Text.Trim & "', '" & txtYazar.Text.Trim & "', " & nudBaski.Value & ", " & nudSayfa.Value & ", " & IIf(chkSatistami.Checked = True, 1, 0) & ");"
        tCommand.CommandText &= "INSERT INTO kitap_stok(kitapid, miktar) VALUES((Select MAX(kitapid) from kitap_bilgi), 0)"
        tConnection.Open()
        tCommand.ExecuteNonQuery()
        tConnection.Close()
        MsgBox("Kaydedildi")
        dgrListe_Yenile()
        dgrListe_Click(sender, EventArgs.Empty)
    End Sub

    Private Sub dgrListe_Click(sender As Object, e As EventArgs) Handles dgrListe.Click
        txtKitapAd.Clear()
        txtYayinevi.Clear()
        txtYazar.Clear()
        nudBaski.Value = 1
        nudSayfa.Value = 1
        chkSatistami.Checked = True
        If dgrListe.RowCount > 0 Then
            If dgrListe.CurrentRow.Index > -1 Then
                txtKitapAd.Text = dgrListe.Item(1, dgrListe.CurrentRow.Index).Value.ToString
                txtYazar.Text = dgrListe.Item(2, dgrListe.CurrentRow.Index).Value.ToString
                txtYayinevi.Text = dgrListe.Item(5, dgrListe.CurrentRow.Index).Value.ToString
                nudSayfa.Value = dgrListe.Item(3, dgrListe.CurrentRow.Index).Value
                nudBaski.Value = dgrListe.Item(4, dgrListe.CurrentRow.Index).Value
                If dgrListe.Item(6, dgrListe.CurrentRow.Index).Value = 1 Then
                    chkSatistami.Checked = True
                Else
                    chkSatistami.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub btnDuzelt_Click(sender As Object, e As EventArgs) Handles btnDuzelt.Click
        If dgrListe.RowCount > 0 Then
            If dgrListe.CurrentRow.Index > -1 Then
                If txtKitapAd.Text.Trim.Length <= 0 Then
                    MsgBox("Lütfen kitabın adını giriniz...")
                    txtKitapAd.Focus()
                    Exit Sub
                End If

                Dim tGeriDonenDeger As Integer

                tCommand.Connection = tConnection
                tCommand.CommandType = CommandType.Text

                tCommand.CommandText = "Select Count(*) from kitap_bilgi Where kitapad='" & txtKitapAd.Text.Trim & "' and yayinevi='" & txtYayinevi.Text.Trim & "' and yazar='" & txtYazar.Text.Trim & "' and kitapid<>" & dgrListe.Item(0, dgrListe.CurrentRow.Index).Value
                tConnection.Open()
                tGeriDonenDeger = tCommand.ExecuteScalar()
                tConnection.Close()
                If tGeriDonenDeger > 0 Then
                    MsgBox("Aynı bilgilere sahip bir kitap kaydı bulundu. Düzeltmek istediğiniz kitabın daha önce kaydedilip edilmediğini lütfen kontrol ediniz...")
                    Exit Sub
                End If

                tCommand.CommandText = "UPDATE kitap_bilgi Set kitapad='" & txtKitapAd.Text.Trim & "', yayinevi='" & txtYayinevi.Text.Trim & "', yazar='" & txtYazar.Text.Trim & "', baski=" & nudBaski.Value & ", sayfa=" & nudSayfa.Value & ", satistami=" & IIf(chkSatistami.Checked = True, 1, 0) & " Where kitapid=" & dgrListe.Item(0, dgrListe.CurrentRow.Index).Value
                tConnection.Open()
                tCommand.ExecuteNonQuery()
                tConnection.Close()
                MsgBox("Düzeltildi")
                dgrListe_Yenile()
                dgrListe_Click(sender, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If dgrListe.RowCount > 0 Then
            If dgrListe.CurrentRow.Index > -1 Then
                If MsgBox("Seçmiş olduğunuz kayıt silinecek. Bu işlem geri alınamaz!!! Emin misiniz?", MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                    tCommand.Connection = tConnection
                    tCommand.CommandType = CommandType.Text
                    tCommand.CommandText = "Delete from kitap_bilgi Where kitapid=" & dgrListe.Item(0, dgrListe.CurrentRow.Index).Value
                    tConnection.Open()
                    tCommand.ExecuteNonQuery()
                    tConnection.Close()
                    MsgBox("Silindi")
                    dgrListe_Yenile()
                    dgrListe_Click(sender, EventArgs.Empty)
                End If
            End If
        End If
    End Sub

    Private Sub txtArama_TextChanged(sender As Object, e As EventArgs) Handles txtArama.TextChanged
        dgrListe_Yenile()
        dgrListe_Click(sender, EventArgs.Empty)
    End Sub
End Class