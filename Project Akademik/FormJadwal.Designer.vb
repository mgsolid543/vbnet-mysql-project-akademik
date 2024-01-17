<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJadwal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxKode = New System.Windows.Forms.TextBox()
        Me.ComboBoxMataKuliah = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDosen = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRuangan = New System.Windows.Forms.ComboBox()
        Me.TextBoxWaktu = New System.Windows.Forms.TextBox()
        Me.TextBoxMataKuliah = New System.Windows.Forms.TextBox()
        Me.TextBoxDosen = New System.Windows.Forms.TextBox()
        Me.TextBoxRuangan = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mata Kuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dosen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ruangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Waktu"
        '
        'TextBoxKode
        '
        Me.TextBoxKode.Location = New System.Drawing.Point(191, 35)
        Me.TextBoxKode.Name = "TextBoxKode"
        Me.TextBoxKode.Size = New System.Drawing.Size(144, 31)
        Me.TextBoxKode.TabIndex = 5
        '
        'ComboBoxMataKuliah
        '
        Me.ComboBoxMataKuliah.FormattingEnabled = True
        Me.ComboBoxMataKuliah.Location = New System.Drawing.Point(191, 75)
        Me.ComboBoxMataKuliah.Name = "ComboBoxMataKuliah"
        Me.ComboBoxMataKuliah.Size = New System.Drawing.Size(144, 33)
        Me.ComboBoxMataKuliah.TabIndex = 6
        '
        'ComboBoxDosen
        '
        Me.ComboBoxDosen.FormattingEnabled = True
        Me.ComboBoxDosen.Location = New System.Drawing.Point(191, 125)
        Me.ComboBoxDosen.Name = "ComboBoxDosen"
        Me.ComboBoxDosen.Size = New System.Drawing.Size(144, 33)
        Me.ComboBoxDosen.TabIndex = 7
        '
        'ComboBoxRuangan
        '
        Me.ComboBoxRuangan.FormattingEnabled = True
        Me.ComboBoxRuangan.Location = New System.Drawing.Point(191, 183)
        Me.ComboBoxRuangan.Name = "ComboBoxRuangan"
        Me.ComboBoxRuangan.Size = New System.Drawing.Size(144, 33)
        Me.ComboBoxRuangan.TabIndex = 8
        '
        'TextBoxWaktu
        '
        Me.TextBoxWaktu.Location = New System.Drawing.Point(191, 227)
        Me.TextBoxWaktu.Name = "TextBoxWaktu"
        Me.TextBoxWaktu.Size = New System.Drawing.Size(144, 31)
        Me.TextBoxWaktu.TabIndex = 9
        '
        'TextBoxMataKuliah
        '
        Me.TextBoxMataKuliah.Location = New System.Drawing.Point(351, 75)
        Me.TextBoxMataKuliah.Name = "TextBoxMataKuliah"
        Me.TextBoxMataKuliah.Size = New System.Drawing.Size(467, 31)
        Me.TextBoxMataKuliah.TabIndex = 10
        '
        'TextBoxDosen
        '
        Me.TextBoxDosen.Location = New System.Drawing.Point(351, 127)
        Me.TextBoxDosen.Name = "TextBoxDosen"
        Me.TextBoxDosen.Size = New System.Drawing.Size(467, 31)
        Me.TextBoxDosen.TabIndex = 11
        '
        'TextBoxRuangan
        '
        Me.TextBoxRuangan.Location = New System.Drawing.Point(351, 185)
        Me.TextBoxRuangan.Name = "TextBoxRuangan"
        Me.TextBoxRuangan.Size = New System.Drawing.Size(467, 31)
        Me.TextBoxRuangan.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 275)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(976, 296)
        Me.DataGridView1.TabIndex = 13
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(321, 597)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(104, 43)
        Me.ButtonSimpan.TabIndex = 14
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(444, 597)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(104, 43)
        Me.ButtonTambah.TabIndex = 15
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(564, 597)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(104, 43)
        Me.ButtonUbah.TabIndex = 16
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(686, 597)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(104, 43)
        Me.ButtonHapus.TabIndex = 17
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(808, 597)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(104, 43)
        Me.ButtonBatal.TabIndex = 18
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(918, 597)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(104, 43)
        Me.ButtonKeluar.TabIndex = 19
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'FormJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 668)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxRuangan)
        Me.Controls.Add(Me.TextBoxDosen)
        Me.Controls.Add(Me.TextBoxMataKuliah)
        Me.Controls.Add(Me.TextBoxWaktu)
        Me.Controls.Add(Me.ComboBoxRuangan)
        Me.Controls.Add(Me.ComboBoxDosen)
        Me.Controls.Add(Me.ComboBoxMataKuliah)
        Me.Controls.Add(Me.TextBoxKode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormJadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Jadwal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKode As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxMataKuliah As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDosen As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxWaktu As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMataKuliah As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDosen As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRuangan As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
End Class
