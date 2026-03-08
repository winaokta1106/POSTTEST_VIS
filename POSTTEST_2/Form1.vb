Public Class Form1

    Private Sub RefreshList()

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To totalBuku - 1
            DataGridView1.Rows.Add(listJudulBuku(i), listGenreBuku(i))
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judulBuku As String = txtJudul.Text.Trim()
        Dim genreBuku As String = txtGenre.Text.Trim()

        If judulBuku = "" Or genreBuku = "" Then
            MsgBox("Masukkan Judul dan Genre Buku terlebih dahulu.", MsgBoxStyle.Exclamation)
            txtJudul.Focus()
            Exit Sub
        End If

        TambahBuku(judulBuku, genreBuku)

        RefreshList()

        txtJudul.Clear()
        txtGenre.Clear()
        txtJudul.Focus()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judulBuku As String = txtHapus.Text.Trim()

        If String.IsNullOrEmpty(judulBuku) Then
            MsgBox("Masukkan Judul Buku yang ingin dihapus.", MsgBoxStyle.Exclamation)
            txtHapus.Focus()
            Exit Sub
        End If

        HapusBuku(judulBuku)

        RefreshList()

        txtHapus.Clear()
        txtHapus.Focus()

    End Sub

End Class