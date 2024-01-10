Imports MySql.Data.MySqlClient

Public Class FormMahasiswa
    Public strSQL As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As New DataSet

    Public simpan, hapus As String

    Sub tambah()
        DataGridView1.Enabled = False
        TextBoxNIM.ReadOnly = False

        TextBoxNIM.Clear()
        TextBoxNama.Clear()
        TextBoxAlamat.Clear()

        TextBoxNIM.Enabled = True
        TextBoxNama.Enabled = True
        ComboBoxJenisKelamin.Enabled = True
        TextBoxAlamat.Enabled = True

        TextBoxNIM.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Sub ubah()
        TextBoxNIM.Enabled = True
        TextBoxNama.Enabled = True
        ComboBoxJenisKelamin.Enabled = True
        TextBoxAlamat.Enabled = True
        TextBoxNIM.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub batal()
        DataGridView1.Enabled = True
        TextBoxNIM.Clear()
        TextBoxNama.Clear()
        TextBoxAlamat.Clear()

        TextBoxNIM.Enabled = True
        TextBoxNama.Enabled = True
        ComboBoxJenisKelamin.Enabled = True
        TextBoxAlamat.Enabled = True
        TextBoxNIM.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub bersih()
        TextBoxNIM.Clear()
        TextBoxNama.Clear()
        TextBoxAlamat.Clear()
        TextBoxNIM.Focus()
    End Sub

    Sub isiGrid()
        ModuleKoneksi.bukaDB()
        DA = New MySqlDataAdapter("select * from mahasiswa", Koneksi)

        ds = New DataSet
        DA.Fill(DS, "mahasiswa")

        DataGridView1.DataSource = DS.Tables("mahasiswa")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub FormMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiGrid()
        Call ubah()
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Call tambah()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        CMD = New MySqlCommand("select nim from mahasiswa where nim = '" & TextBoxNIM.Text & "'", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()

        If ButtonTambah.Enabled = False Then
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan NIM tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                If (MessageBox.Show("Simpan data mahasiswa baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into mahasiswa (nim, nama, jeniskelamin, alamat) values ('" & TextBoxNIM.Text & "', '" & TextBoxNama.Text & "', '" & ComboBoxJenisKelamin.Text & "','" & TextBoxAlamat.Text & "')"

                    CMD = New MySqlCommand(simpan, Koneksi)

                    CMD.ExecuteNonQuery()

                    Call isiGrid()
                    Call batal()
                    TextBoxNIM.Focus()

                    MsgBox("Data mahasiswa sudah tersimpan.", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("update mahasiswa set nim=@nim, nama=@nama, jeniskelamin=@jeniskelamin, alamat=@alamat where nim=@nim", conn)

                With command.Parameters
                    .AddWithValue("@nim", TextBoxNIM.Text)
                    .AddWithValue("@nama", TextBoxNama.Text)
                    .AddWithValue("@jeniskelamin", ComboBoxJenisKelamin.Text)
                    .AddWithValue("@alamat", TextBoxAlamat.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("Data mahaiswa sukses tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan dalam ubah data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call isiGrid()
        Call bersih()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Call batal()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If TextBoxNIM.Text = "" Then
            MessageBox.Show("Pilih dahulu data mahasiswa yang akan Anda hapus pada tabel di atas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxNIM.Text <> "" Then
                If MessageBox.Show("Apakah Anda yakin akan mengahapus data mahasiswa ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    hapus = "delete from mahasiswa where nim = '" & TextBoxNIM.Text & "'"
                    CMD = New MySqlCommand(hapus, Koneksi)

                    CMD.ExecuteNonQuery()
                    Call isiGrid()
                    Call bersih()
                    TextBoxNIM.Focus()
                    MessageBox.Show("Data ruangan berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxNIM.ReadOnly = True
        bukaDB()
        CMD = New MySqlCommand("select * from mahasiswa where nim = '" & TextBoxNIM.Text & "'", Koneksi)

        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxNIM.Text = gridbaris.Cells(0).Value.ToString
            TextBoxNama.Text = gridbaris.Cells(1).Value.ToString
            ComboBoxJenisKelamin.Text = gridbaris.Cells(2).Value.ToString
            TextBoxAlamat.Text = gridbaris.Cells(3).Value.ToString

        Catch ex As Exception
            MsgBox("Pilih data mahasiswa yang ada di dalam tabel", MsgBoxStyle.Information, "Info")
        End Try
    End Sub


End Class