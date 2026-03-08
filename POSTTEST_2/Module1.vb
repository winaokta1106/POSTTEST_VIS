Module ModulBuku
    Public listJudulBuku(99) As String
    Public listGenreBuku(99) As String
    Public totalBuku As Integer = 0
    Public Sub TambahBuku(ByRef judul As String, ByRef genre As String)
        If totalBuku < listJudulBuku.Length Then
            listJudulBuku(totalBuku) = judul
            listGenreBuku(totalBuku) = genre
            totalBuku += 1
        Else
            MsgBox("Kapasitas daftar buku sudah penuh!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub HapusBuku(ByVal judul As String)
        Dim posisiBuku As Integer = CariBuku(judul)

        If posisiBuku >= 0 Then
            For i As Integer = posisiBuku To totalBuku - 2
                listJudulBuku(i) = listJudulBuku(i + 1)
                listGenreBuku(i) = listGenreBuku(i + 1)
            Next
            listJudulBuku(totalBuku - 1) = ""
            listGenreBuku(totalBuku - 1) = ""
            totalBuku -= 1
        Else
            MsgBox("Judul buku tidak ditemukan!", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To totalBuku - 1
            If listJudulBuku(i).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module