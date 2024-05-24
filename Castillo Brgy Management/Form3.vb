Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.BackColor = Color.FromArgb(255, 200, 200, 200)
        PictureBox8.BackColor = Color.FromArgb(255, 200, 200, 200)

        Panel1.BackColor = Color.FromArgb(200, 255, 255, 255)

        addData()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub addData()

        DataGridView1.Rows.Add(
            "01", "Ajemher M. Balahula", 19, "Male"
        )

        DataGridView1.Rows.Add(
            "02", "Ranier Gargoles", 20, "Male"
        )

        DataGridView1.Rows.Add(
            "03", "kaye N. Rellama", 19, "Female"
        )

        DataGridView1.Rows.Add(
            "04", "Arianne E. Gupa", 23, "Female"
        )

        DataGridView1.Rows.Add(
            "05", "Ramil Gonzales", 20, "Male"
        )

        DataGridView1.Rows.Add(
            "06", "Clythem Onato", 22, "Male"
        )

        DataGridView1.Rows.Add(
            "07", "Cammille Padulina", 19, "Female"
        )

        DataGridView1.Rows.Add(
            "08", "Mark Vence Dunca", 26, "Male"
        )

        DataGridView1.Rows.Add(
            "09", "Steph Lucero", 19, "Female"
        )

        DataGridView1.Rows.Add(
            "10", "Aileen Mundin", 47, "Female"
        )

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class