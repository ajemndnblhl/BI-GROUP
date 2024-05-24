Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = Color.FromArgb(220, 255, 255, 255)
        SetTboxRadius(TextBox1, 35)
        SetTboxRadius(TextBox2, 35)

    End Sub
    Public Shared Sub SetPanelRadius(ByVal panel As Panel, ByVal radius As Integer)
        Dim path As New GraphicsPath()
        ' Create a rounded rectangle path
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Set the panel's region to the rounded rectangle path
        panel.Region = New Region(path)

    End Sub

    Public Shared Sub SetTboxRadius(ByVal tbox As TextBox, ByVal radius As Integer)
        Dim path As New GraphicsPath()
        ' Create a rounded rectangle path
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(tbox.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(tbox.Width - radius, tbox.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, tbox.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Set the panel's region to the rounded rectangle path
        tbox.Region = New Region(path)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()
        Me.Hide()

    End Sub
End Class
