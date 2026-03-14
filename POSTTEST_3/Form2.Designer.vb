<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        LblAlamat = New Label()
        LblNoTlp = New Label()
        LblTanggallhr = New Label()
        LblUmur = New Label()
        LblNama = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        LblJenisKlmn = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.Location = New Point(288, 314)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(68, 25)
        LblAlamat.TabIndex = 19
        LblAlamat.Text = "Alamat"
        ' 
        ' LblNoTlp
        ' 
        LblNoTlp.AutoSize = True
        LblNoTlp.Location = New Point(288, 232)
        LblNoTlp.Name = "LblNoTlp"
        LblNoTlp.Size = New Size(102, 25)
        LblNoTlp.TabIndex = 18
        LblNoTlp.Text = "No Telepon"
        ' 
        ' LblTanggallhr
        ' 
        LblTanggallhr.AutoSize = True
        LblTanggallhr.Location = New Point(288, 149)
        LblTanggallhr.Name = "LblTanggallhr"
        LblTanggallhr.Size = New Size(115, 25)
        LblTanggallhr.TabIndex = 17
        LblTanggallhr.Text = "Tanggal Lahir"
        ' 
        ' LblUmur
        ' 
        LblUmur.AutoSize = True
        LblUmur.Location = New Point(288, 106)
        LblUmur.Name = "LblUmur"
        LblUmur.Size = New Size(56, 25)
        LblUmur.TabIndex = 16
        LblUmur.Text = "Umur"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(288, 64)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(59, 25)
        LblNama.TabIndex = 15
        LblNama.Text = "Nama"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(257, 320)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.WhatsApp_Image_2026_03_15_at_05_321
        PictureBox2.Location = New Point(482, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(255, 260)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 27
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(288, 273)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 25)
        Label1.TabIndex = 28
        Label1.Text = "Hobby"
        ' 
        ' LblJenisKlmn
        ' 
        LblJenisKlmn.AutoSize = True
        LblJenisKlmn.Location = New Point(286, 189)
        LblJenisKlmn.Name = "LblJenisKlmn"
        LblJenisKlmn.Size = New Size(116, 25)
        LblJenisKlmn.TabIndex = 30
        LblJenisKlmn.Text = "Jenis Kelamin"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.HotPink
        ClientSize = New Size(761, 417)
        Controls.Add(LblJenisKlmn)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(LblAlamat)
        Controls.Add(LblNoTlp)
        Controls.Add(LblTanggallhr)
        Controls.Add(LblUmur)
        Controls.Add(LblNama)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblNoTlp As Label
    Friend WithEvents LblTanggallhr As Label
    Friend WithEvents LblUmur As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblJenisKlmn As Label
End Class
