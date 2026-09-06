Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("1.png")
        ListBox1.Items.Add("2.png")

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem IsNot Nothing Then

            ProgressBar1.Value = 0

            For i As Integer = 0 To 100 Step 10
                ProgressBar1.Value = i
                Application.DoEvents()
                Threading.Thread.Sleep(50)
            Next

            Dim folderPath As String = Application.StartupPath & "\Images\"
            Dim filePath As String = folderPath & ListBox1.SelectedItem.ToString()

            If IO.File.Exists(filePath) Then
                PictureBox1.Image = Image.FromFile(filePath)
            Else
                MessageBox.Show("File gambar tidak ditemukan.")
            End If

            MessageBox.Show("Tanggal kegiatan: " &
                        DateTimePicker1.Value.ToShortDateString())

        Else

            MessageBox.Show("Pilih gambar dari daftar terlebih dahulu.")

        End If
    End Sub
End Class
