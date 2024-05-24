<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        PictureBox9 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Panel3 = New Panel()
        Label16 = New Label()
        TextBox12 = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        TextBox11 = New TextBox()
        TextBox10 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button6 = New Button()
        Label10 = New Label()
        TextBox9 = New TextBox()
        Label9 = New Label()
        TextBox8 = New TextBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Panel4 = New Panel()
        Label11 = New Label()
        Button7 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(176, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(660, 38)
        Label1.TabIndex = 2
        Label1.Text = "BARANGAY CASTILLO MANAGEMENT SYSTEM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(106, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 59)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Info
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(928, 62)
        Panel2.TabIndex = 3
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.Control
        Button5.Location = New Point(0, 267)
        Button5.Name = "Button5"
        Button5.Size = New Size(233, 69)
        Button5.TabIndex = 7
        Button5.Text = "              About Castillo"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Control
        Button4.Location = New Point(0, 200)
        Button4.Name = "Button4"
        Button4.Size = New Size(233, 69)
        Button4.TabIndex = 6
        Button4.Text = "           Castillo Map"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = SystemColors.ActiveBorder
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(29, 145)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(51, 44)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 5
        PictureBox9.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Control
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(29, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(51, 44)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveBorder
        Button3.Location = New Point(0, 135)
        Button3.Name = "Button3"
        Button3.Size = New Size(233, 69)
        Button3.TabIndex = 2
        Button3.Text = "              Add Resident"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.Location = New Point(0, 67)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 72)
        Button2.TabIndex = 1
        Button2.Text = "            View Record"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(0, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 71)
        Button1.TabIndex = 0
        Button1.Text = "          Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(PictureBox9)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 577)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Control
        PictureBox4.ErrorImage = Nothing
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(29, 278)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(51, 44)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Control
        PictureBox3.ErrorImage = Nothing
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(29, 214)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Control
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(29, 78)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(51, 44)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 4
        PictureBox8.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(23, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 0
        Label2.Text = "Last name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(23, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(23, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 25)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(196, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 25)
        Label4.TabIndex = 4
        Label4.Text = "Sex"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(261, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 25)
        Label5.TabIndex = 6
        Label5.Text = "First name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(499, 50)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(144, 31)
        TextBox4.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(499, 81)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 25)
        Label6.TabIndex = 8
        Label6.Text = "Middle initial"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(TextBox12)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(TextBox11)
        Panel3.Controls.Add(TextBox10)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(TextBox9)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(TextBox8)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox1)
        Panel3.Location = New Point(251, 142)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(661, 488)
        Panel3.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Location = New Point(23, 400)
        Label16.Name = "Label16"
        Label16.Size = New Size(147, 25)
        Label16.TabIndex = 29
        Label16.Text = "Landline Number"
        ' 
        ' TextBox12
        ' 
        TextBox12.BorderStyle = BorderStyle.FixedSingle
        TextBox12.Location = New Point(23, 366)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(257, 31)
        TextBox12.TabIndex = 28
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Location = New Point(286, 339)
        Label15.Name = "Label15"
        Label15.Size = New Size(54, 25)
        Label15.TabIndex = 27
        Label15.Text = "Email"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Location = New Point(23, 338)
        Label14.Name = "Label14"
        Label14.Size = New Size(143, 25)
        Label14.TabIndex = 26
        Label14.Text = "Contact Number"
        ' 
        ' TextBox11
        ' 
        TextBox11.BorderStyle = BorderStyle.FixedSingle
        TextBox11.Location = New Point(286, 305)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(357, 31)
        TextBox11.TabIndex = 25
        ' 
        ' TextBox10
        ' 
        TextBox10.BorderStyle = BorderStyle.FixedSingle
        TextBox10.Location = New Point(23, 305)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(257, 31)
        TextBox10.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(23, 261)
        Label13.Name = "Label13"
        Label13.Size = New Size(195, 28)
        Label13.TabIndex = 23
        Label13.Text = "Contact Information"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(23, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(203, 28)
        Label12.TabIndex = 22
        Label12.Text = "Personal Information"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(612, 118)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(31, 31)
        DateTimePicker1.TabIndex = 21
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.Info
        Button6.Location = New Point(488, 413)
        Button6.Name = "Button6"
        Button6.Size = New Size(152, 52)
        Button6.TabIndex = 20
        Button6.Text = "Add Record"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Location = New Point(377, 215)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 25)
        Label10.TabIndex = 19
        Label10.Text = "Occupation"
        ' 
        ' TextBox9
        ' 
        TextBox9.BorderStyle = BorderStyle.FixedSingle
        TextBox9.Location = New Point(377, 183)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(266, 31)
        TextBox9.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(196, 214)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 25)
        Label9.TabIndex = 17
        Label9.Text = "Marital status"
        ' 
        ' TextBox8
        ' 
        TextBox8.BorderStyle = BorderStyle.FixedSingle
        TextBox8.Location = New Point(196, 183)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(175, 31)
        TextBox8.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Location = New Point(23, 216)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 25)
        Label8.TabIndex = 15
        Label8.Text = "Religion"
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Location = New Point(23, 183)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(167, 31)
        TextBox7.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(377, 152)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 25)
        Label7.TabIndex = 13
        Label7.Text = "Date of birth"
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Location = New Point(377, 118)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(235, 31)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(196, 117)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(175, 31)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(23, 118)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(167, 31)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(261, 50)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 31)
        TextBox2.TabIndex = 9
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Info
        Panel4.Controls.Add(Label11)
        Panel4.Location = New Point(251, 79)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(661, 63)
        Panel4.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(211, 16)
        Label11.Name = "Label11"
        Label11.Size = New Size(249, 38)
        Label11.TabIndex = 0
        Label11.Text = "Registration form"
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.Control
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Zoom
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(-92, 527)
        Button7.Name = "Button7"
        Button7.Size = New Size(245, 50)
        Button7.TabIndex = 12
        Button7.Text = "Log out"
        Button7.TextAlign = ContentAlignment.MiddleRight
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(930, 639)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button7 As Button
End Class
