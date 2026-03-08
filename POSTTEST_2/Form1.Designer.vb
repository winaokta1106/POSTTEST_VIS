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
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        DataGridView1 = New DataGridView()
        Judul_Buku = New DataGridViewTextBoxColumn()
        genre_buku = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 2
        Label3.Text = "Judul Buku"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudul)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(326, 193)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(204, 148)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(153, 89)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 8
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(153, 41)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(150, 31)
        txtJudul.TabIndex = 7
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(369, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(353, 193)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(233, 147)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(185, 64)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(150, 31)
        txtHapus.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Judul_Buku, genre_buku})
        DataGridView1.GridColor = SystemColors.Window
        DataGridView1.Location = New Point(165, 241)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(360, 225)
        DataGridView1.TabIndex = 7
        ' 
        ' Judul_Buku
        ' 
        Judul_Buku.HeaderText = "Judul Buku"
        Judul_Buku.MinimumWidth = 8
        Judul_Buku.Name = "Judul_Buku"
        Judul_Buku.Width = 150
        ' 
        ' genre_buku
        ' 
        genre_buku.HeaderText = "Genre"
        genre_buku.MinimumWidth = 8
        genre_buku.Name = "genre_buku"
        genre_buku.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(731, 478)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Judul_Buku As DataGridViewTextBoxColumn
    Friend WithEvents genre_buku As DataGridViewTextBoxColumn

End Class
