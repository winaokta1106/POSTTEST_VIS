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
        LblNama = New Label()
        PictureBox1 = New PictureBox()
        btnBrowse = New Button()
        LblUmur = New Label()
        Label3 = New Label()
        LblNoTlp = New Label()
        LblAlamat = New Label()
        TxtNama = New TextBox()
        TxtUmur = New TextBox()
        TxtTanggallhr = New TextBox()
        TxtNotlp = New TextBox()
        TxtAlamat = New TextBox()
        GroupBox1 = New GroupBox()
        RbLaki = New RadioButton()
        RbPerempuan = New RadioButton()
        GroupBox2 = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        BtnCetakkrtu = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(313, 61)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(59, 25)
        LblNama.TabIndex = 0
        LblNama.Text = "Nama"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(12, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(295, 467)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DodgerBlue
        btnBrowse.ForeColor = SystemColors.ButtonHighlight
        btnBrowse.Location = New Point(99, 503)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' LblUmur
        ' 
        LblUmur.AutoSize = True
        LblUmur.Location = New Point(313, 108)
        LblUmur.Name = "LblUmur"
        LblUmur.Size = New Size(56, 25)
        LblUmur.TabIndex = 3
        LblUmur.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(315, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' LblNoTlp
        ' 
        LblNoTlp.AutoSize = True
        LblNoTlp.Location = New Point(313, 194)
        LblNoTlp.Name = "LblNoTlp"
        LblNoTlp.Size = New Size(102, 25)
        LblNoTlp.TabIndex = 5
        LblNoTlp.Text = "No Telepon"
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.Location = New Point(313, 234)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(68, 25)
        LblAlamat.TabIndex = 6
        LblAlamat.Text = "Alamat"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(427, 61)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(282, 31)
        TxtNama.TabIndex = 7
        ' 
        ' TxtUmur
        ' 
        TxtUmur.Location = New Point(427, 108)
        TxtUmur.Name = "TxtUmur"
        TxtUmur.Size = New Size(282, 31)
        TxtUmur.TabIndex = 8
        ' 
        ' TxtTanggallhr
        ' 
        TxtTanggallhr.Location = New Point(427, 153)
        TxtTanggallhr.Name = "TxtTanggallhr"
        TxtTanggallhr.Size = New Size(282, 31)
        TxtTanggallhr.TabIndex = 9
        ' 
        ' TxtNotlp
        ' 
        TxtNotlp.Location = New Point(427, 194)
        TxtNotlp.Name = "TxtNotlp"
        TxtNotlp.Size = New Size(282, 31)
        TxtNotlp.TabIndex = 10
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(427, 234)
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(282, 31)
        TxtAlamat.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RbLaki)
        GroupBox1.Controls.Add(RbPerempuan)
        GroupBox1.Location = New Point(313, 288)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 206)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' RbLaki
        ' 
        RbLaki.AutoSize = True
        RbLaki.Location = New Point(6, 39)
        RbLaki.Name = "RbLaki"
        RbLaki.Size = New Size(100, 29)
        RbLaki.TabIndex = 15
        RbLaki.TabStop = True
        RbLaki.Text = "Laki-laki"
        RbLaki.UseVisualStyleBackColor = True
        ' 
        ' RbPerempuan
        ' 
        RbPerempuan.AutoSize = True
        RbPerempuan.Location = New Point(6, 77)
        RbPerempuan.Name = "RbPerempuan"
        RbPerempuan.Size = New Size(126, 29)
        RbPerempuan.TabIndex = 16
        RbPerempuan.TabStop = True
        RbPerempuan.Text = "Perempuan"
        RbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox10)
        GroupBox2.Controls.Add(CheckBox9)
        GroupBox2.Controls.Add(CheckBox8)
        GroupBox2.Controls.Add(CheckBox7)
        GroupBox2.Controls.Add(CheckBox6)
        GroupBox2.Controls.Add(CheckBox5)
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(587, 288)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(356, 206)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(168, 166)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(133, 29)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Photograph"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(168, 131)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(93, 29)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Design"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(168, 96)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(97, 29)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Nail Art"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(168, 62)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(109, 29)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Make Up"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(168, 30)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(102, 29)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Berkuda"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(19, 166)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(110, 29)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Berdansa"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(19, 131)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(108, 29)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Moshing"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(19, 96)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(110, 29)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Bermusik"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(19, 62)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(114, 29)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Bernyanyi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(19, 30)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(92, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Menari"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' BtnCetakkrtu
        ' 
        BtnCetakkrtu.Location = New Point(313, 503)
        BtnCetakkrtu.Name = "BtnCetakkrtu"
        BtnCetakkrtu.Size = New Size(630, 34)
        BtnCetakkrtu.TabIndex = 15
        BtnCetakkrtu.Text = "Cetak Kartu"
        BtnCetakkrtu.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.WhatsApp_Image_2026_03_15_at_05_321
        PictureBox2.Location = New Point(712, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(255, 260)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.HotPink
        ClientSize = New Size(955, 546)
        Controls.Add(PictureBox2)
        Controls.Add(BtnCetakkrtu)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TxtAlamat)
        Controls.Add(TxtNotlp)
        Controls.Add(TxtTanggallhr)
        Controls.Add(TxtUmur)
        Controls.Add(TxtNama)
        Controls.Add(LblAlamat)
        Controls.Add(LblNoTlp)
        Controls.Add(Label3)
        Controls.Add(LblUmur)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Controls.Add(LblNama)
        Name = "Form1"
        Text = "Form Biodata"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNama As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents LblUmur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNoTlp As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtUmur As TextBox
    Friend WithEvents TxtTanggallhr As TextBox
    Friend WithEvents TxtNotlp As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RbLaki As RadioButton
    Friend WithEvents RbPerempuan As RadioButton
    Friend WithEvents BtnCetakkrtu As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
