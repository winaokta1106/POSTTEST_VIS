Public Class Form1

    Private Sub BtnCetakkrtu_Click(sender As Object, e As EventArgs) Handles BtnCetakkrtu.Click

        If Not RbLaki.Checked AndAlso Not RbPerempuan.Checked Then
            MessageBox.Show("Jenis Kelamin harus dipilih", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not (CheckBox1.Checked OrElse CheckBox2.Checked OrElse CheckBox3.Checked OrElse
                CheckBox4.Checked OrElse CheckBox5.Checked OrElse CheckBox6.Checked OrElse
                CheckBox7.Checked OrElse CheckBox8.Checked OrElse CheckBox9.Checked OrElse
                CheckBox10.Checked) Then
            MessageBox.Show("Hobby Tidak Boleh Kosong", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxtNama.Text) Then
            MessageBox.Show("Nama Tidak Boleh Kosong")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxtUmur.Text) Then
            MessageBox.Show("Umur Tidak Boleh Kosong")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxtAlamat.Text) Then
            MessageBox.Show("Alamat Tidak Boleh Kosong")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxtNotlp.Text) Then
            MessageBox.Show("No HP Tidak Boleh Kosong")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(PictureBox1.ImageLocation) Then
            MessageBox.Show("Foto harus dipilih")
            Exit Sub
        End If

        Form2.Show()

        Form2.LblNama.Text = TxtNama.Text
        Form2.LblUmur.Text = TxtUmur.Text
        Form2.LblTanggallhr.Text = TxtTanggallhr.Text
        Form2.LblNoTlp.Text = TxtNotlp.Text
        Form2.LblAlamat.Text = TxtAlamat.Text

        If RbLaki.Checked Then
            Form2.LblJenisKlmn.Text = RbLaki.Text
        Else
            Form2.LblJenisKlmn.Text = RbPerempuan.Text
        End If

        Form2.Show()

        Form2.LblNama.Text = TxtNama.Text
        Form2.LblUmur.Text = TxtUmur.Text
        Form2.LblTanggallhr.Text = TxtTanggallhr.Text
        Form2.LblNoTlp.Text = TxtNotlp.Text
        Form2.LblAlamat.Text = TxtAlamat.Text

        Form2.PictureBox1.ImageLocation = PictureBox1.ImageLocation

    End Sub


    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim BukaFile As New OpenFileDialog()

        If BukaFile.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = BukaFile.FileName
        End If

    End Sub



    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress

        Dim keyascii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[a-z,A-Z]" _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If

    End Sub

    Private Sub TxtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUmur.KeyPress

        Dim keyascii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If

    End Sub

    Private Sub TxtNotlp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNotlp.KeyPress

        Dim keyascii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If

    End Sub

End Class
