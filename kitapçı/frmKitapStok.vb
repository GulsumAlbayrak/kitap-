Imports System.Data.SQLite

Public Class frmKitapStok

    Dim tConnection As New SQLiteConnection("Data Source=data.db;Version=3;Pooling=True;Synchronous=Full;")
    Private Sub frmKitapStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgrListe_Yenile()
    End Sub

    Sub dgrListe_Yenile()
        Dim tDataset As New DataSet
        Dim tDataAdapter As SQLiteDataAdapter
        If txtArama.Text.Trim.Length > 0 Then
            tDataAdapter = New SQLiteDataAdapter("Select kitap_bilgi.kitapad, kitap_bilgi.yazar, kitap_bilgi.yayinevi, kitap_stok.miktar from kitap_bilgi Inner Join kitap_stok ON kitap_bilgi.kitapid=kitap_stok.kitapid Where kitap_bilgi.kitapad LIKE '%" & txtArama.Text.Trim & "%' or kitap_bilgi.yayinevi LIKE '%" & txtArama.Text.Trim & "%' or kitap_bilgi.yazar LIKE '%" & txtArama.Text.Trim & "%' Order By kitap_bilgi.kitapad", tConnection)
        Else
            tDataAdapter = New SQLiteDataAdapter("Select kitap_bilgi.kitapad, kitap_bilgi.yazar, kitap_bilgi.yayinevi, kitap_stok.miktar from kitap_bilgi Inner Join kitap_stok ON kitap_bilgi.kitapid=kitap_stok.kitapid Order By kitap_bilgi.kitapad", tConnection)
        End If
        tDataAdapter.Fill(tDataset, "kitap_stok")
        dgrListe.DataSource = tDataset.Tables("kitap_stok")
    End Sub

    Private Sub frmKitapStok_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmANA.Show()
    End Sub

    Private Sub txtArama_TextChanged(sender As Object, e As EventArgs) Handles txtArama.TextChanged
        dgrListe_Yenile()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class