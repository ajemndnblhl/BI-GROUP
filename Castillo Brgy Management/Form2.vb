Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel4.BackColor = Color.FromArgb(200, 255, 255, 255)
        Panel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Panel5.BackColor = Color.FromArgb(200, 255, 255, 255)
        Panel6.BackColor = Color.FromArgb(200, 255, 255, 255)
        Panel7.BackColor = Color.FromArgb(220, 255, 255, 255)

        Form1.SetPanelRadius(Panel3, 30)
        Form1.SetPanelRadius(Panel5, 30)
        Form1.SetPanelRadius(Panel6, 30)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class