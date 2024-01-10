Imports MySql.Data.MySqlClient
Public Class FormDosen
    Public strSQL As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As New DataSet

    Public simpan, hapus As String

    Sub tambah()
        DataGridView1.Enabled = False
        TextBoxNIP.ReadOnly = False

        TextBoxNIP.Clear()
        TextBoxNama.Clear()
        TextBoxAlamat.Clear()

        TextBoxNIP.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxAlamat.Enabled = True

        TextBoxNIP.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Sub ubah()
        TextBoxNIP.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxAlamat.Enabled = True
        TextBoxNIP.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub batal()
        DataGridView1.Enabled = True
        TextBoxNIP.Clear()
        TextBoxNama.Clear()
        TextBoxAlamat.Clear()

        TextBoxNIP.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxAlamat.Enabled = True
        TextBoxNIP.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub bersih()
        TextBoxNIP.Clear()
        TextBoxNama.Clear()
        TextBoxAlamat.Clear()
        TextBoxNIP.Focus()
    End Sub

    Sub isiGrid()
        ModuleKoneksi.bukaDB()
        DA = New MySqlDataAdapter("select * from dosen", Koneksi)

        ds = New DataSet
        DA.Fill(DS, "dosen")

        DataGridView1.DataSource = DS.Tables("dosen")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub


    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Call tambah()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Call batal()
    End Sub

    Private Sub FormDosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiGrid()
        Call ubah()
    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxNIP.ReadOnly = True
        bukaDB()
        CMD = New MySqlCommand("select * from dosen where nip = '" & TextBoxNIP.Text & "'", Koneksi)

        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxNIP.Text = gridbaris.Cells(0).Value.ToString
            TextBoxNama.Text = gridbaris.Cells(1).Value.ToString
            TextBoxAlamat.Text = gridbaris.Cells(2).Value.ToString

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        CMD = New MySqlCommand("select nip from dosen where nip = '" & TextBoxNIP.Text & "'", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()

        If ButtonTambah.Enabled = False Then
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan NIP tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                If (MessageBox.Show("Simpan data dosen baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into dosen (nip, nama, alamat) values ('" & TextBoxNIP.Text & "', '" & TextBoxNama.Text & "', '" & TextBoxAlamat.Text & "')"

                    CMD = New MySqlCommand(simpan, Koneksi)

                    CMD.ExecuteNonQuery()

                    Call isiGrid()
                    Call batal()
                    TextBoxNIP.Focus()

                    MsgBox("Data dosen sudah tersimpan.", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("update dosen set nip=@nip, nama=@nama, alamat=@alamat where nip=@nip", conn)

                With command.Parameters
                    .AddWithValue("@nip", TextBoxNIP.Text)
                    .AddWithValue("@nama", TextBoxNama.Text)
                    .AddWithValue("@alamat", TextBoxAlamat.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("Data dosen sukses tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan dalam ubah data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call isiGrid()
        Call bersih()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If TextBoxNIP.Text = "" Then
            MessageBox.Show("Pilih dahulu data dosen yang akan Anda hapus pada tabel di atas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxNIP.Text <> "" Then
                If MessageBox.Show("Apakah Anda yakin akan mengahapus data dosen ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    hapus = "delete from dosen where nip = '" & TextBoxNIP.Text & "'"
                    CMD = New MySqlCommand(hapus, Koneksi)

                    CMD.ExecuteNonQuery()
                    Call isiGrid()
                    Call bersih()
                    TextBoxNIP.Focus()
                    MessageBox.Show("Data dosen berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
End Class

