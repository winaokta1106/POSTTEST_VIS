<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label3 = New Label()
        btnTambah = New Button()
        txtIPSemester = New TextBox()
        btnReset = New Button()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 25)
        Label3.TabIndex = 1
        Label3.Text = "IP Kumulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SteelBlue
        btnTambah.ForeColor = SystemColors.ButtonHighlight
        btnTambah.Location = New Point(316, 144)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(316, 107)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(230, 31)
        txtIPSemester.TabIndex = 4
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.SteelBlue
        btnReset.ForeColor = SystemColors.ButtonHighlight
        btnReset.Location = New Point(434, 144)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(316, 202)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(230, 31)
        txtIPK.TabIndex = 6
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(316, 254)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(76, 25)
        lblPredikat.TabIndex = 7
        lblPredikat.Text = "Predikat"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2026_03_01_at_03_18_06_removebg_preview
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.WhatsApp_Image_2026_03_01_at_03_31_45_removebg_preview
        PictureBox2.Location = New Point(601, 292)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(197, 161)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(btnReset)
        Controls.Add(txtIPSemester)
        Controls.Add(btnTambah)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Kalkulator IP (Coquette Version)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
