Imports System.Globalization

Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double
        Dim ipk As Double

        Dim inputText As String = txtIPSemester.Text.Replace(",", ".")

        If Double.TryParse(inputText, NumberStyles.Any, CultureInfo.InvariantCulture, ipSemester) Then

            If ipSemester >= 0 And ipSemester <= 4 Then

                totalIP += ipSemester
                jumlahSemester += 1

                ipk = totalIP / jumlahSemester

                txtIPK.Text = ipk.ToString("0.00")

                If ipk >= 2.0 And ipk <= 2.75 Then
                    lblPredikat.Text = "Cukup"

                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"

                ElseIf ipk >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"

                Else
                    lblPredikat.Text = "-"
                End If

                txtIPSemester.Clear()
                txtIPSemester.Focus()

            Else
                MessageBox.Show("IP Semester harus antara 0 - 4")
            End If

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPSemester.Clear()
        txtIPK.Clear()
        lblPredikat.Text = ""

    End Sub

End Class