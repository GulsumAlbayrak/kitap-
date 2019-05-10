Public Class Form1
    'Dim tconnection As New SQLiteConnection("Data Source=data.db;Verision=3;Pooling=True;Synchrounus=Full;")
    'dim tcommand as new SqliteCommand()
    'Dim cmbKitapAdID() As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'lblYazar.text=""
        'lblYayinevi.text=""
        'If cmbKitapAd.SelectedIndex >-1 then
        'dim tdatareader as new SqliteDatareader
        'tcommand.connection=tconnection
        'tcommand.commandtype=commandtype.text
        'tcommand.commandtext="Select * from kitap_bilgi where kitapid="&cmbKitapAdID(cmbKitapAd.SelectedIndex)"
        'tconnection.Open()
        'tDataReader=executeDataReader
        'Do while tDataReader.Read
        'lblYazar.text=tDataReader("yazar").tostring.trim
        'lblYeyinevi.text=tDataReade("yayinevi).toString.trim
        'loop
        'tconnection.close()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dim i as integer=0
        'Redim cmbKitapAdID(0)
        'tDataReader as new SQLiteDataReader
        'tcommand.connection=tconnection
        'tcommand.commandtype=commandtype.text
        'tcommand.commandtext="Select * from kitap_bilgi"
        'tconnection.open()
        'tDataReader=tcommand.executedatareader
        'do while tDataReade.Read
        'ReDim Preverse cmbKitapAdID(i)
        'cmbKitapAd.Items.Add(tDataReader("kitapad").tostring.trim)
        'cmbKitapAdID(i)=DataReader(kitapid)
        'i+=1
        'loop



    End Sub
    Sub kaydet()
        'if kitapad.selectedindex <-1 then


    End Sub
    Sub sil()
        'command.commandtext="update kitap_stok set where miktar=miktar-(select miktar from kitap_alim where kitapid="&dgrliste.item(0,dgrliste.currentrow.index).value&");"
        'where kitapid=(select kitapid from kitap_alim where alimid="&dgrliste.item(0,dgrliste.currentrow.index).value");&"
        ' command.commandtext="delet from kitap_alim where alimid= "&dgrliste.item(0,dgrliste.currentrow.indes).value");&"
        'tconnection.open()
        'tcommand.executenonquery()
        'tconnection.close()
        MsgBox("alim işlemi iptal edildi")
        'dgrliste_yenile
    End Sub
End Class