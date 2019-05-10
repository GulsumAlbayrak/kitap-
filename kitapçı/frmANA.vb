Public Class frmANA
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTarihSaat.Text = Now.ToString
    End Sub

    Private Sub btnKitapListesi_Click(sender As Object, e As EventArgs) Handles btnKitapListesi.Click
        frmKitapBilgi.Show()
        Me.Hide()
    End Sub

    Private Sub btnKitapStok_Click(sender As Object, e As EventArgs) Handles btnKitapStok.Click
        frmKitapStok.Show()
        Me.Hide()
    End Sub

    Private Sub btnKitapAlis_Click(sender As Object, e As EventArgs) Handles btnKitapAlis.Click
        frmKitapAlim.Show()
        Me.Hide()
    End Sub

    Private Sub btnKitapSatis_Click(sender As Object, e As EventArgs) Handles btnKitapSatis.Click
        frmKitapsatis.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
