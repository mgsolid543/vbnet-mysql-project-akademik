Imports MySql.Data.MySqlClient

Public Class FormJadwal
    Public strSQL As String
    Public db As MySqlConnection
    Public cmd As MySqlCommand
    Public dadapter As MySqlDataAdapter
    Public datardr As MySqlDataReader
    Public ds As DataSet
    Dim conn As AksesData.KoneksiDB

    Public display, simpan, ubah, hapus As String

    Private Sub FormJadwal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormUtama.Enabled = True
    End Sub

    Private Sub tambah()
        DataGridView1.Enabled = False
        TextBoxKode.ReadOnly = False

        TextBoxKode.Clear()

        TextBoxMataKuliah.Clear()
        TextBoxDosen.Clear()

        TextBoxWaktu.Clear()

        TextBoxKode.Enabled = True

        TextBoxMataKuliah.Enabled = True
        ComboBoxMataKuliah.Enabled = True

        TextBoxDosen.Enabled = True
        ComboBoxDosen.Enabled = True

        TextBoxKode.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Private Sub comboMataKuliah()
        Call bukaDB()
        cmd = New MySqlCommand("select * from matakuliah", Koneksi)
        datardr = cmd.ExecuteReader
        ComboBoxMataKuliah.Items.Clear()
        Do While datardr.Read
            ComboBoxMataKuliah.Items.Add(datardr("kodemk"))
        Loop
        datardr.Close()
    End Sub

    Private Sub comboDosen()
        Call bukaDB()
        cmd = New MySqlCommand("select * from dosen", Koneksi)
        datardr = cmd.ExecuteReader
        ComboBoxDosen.Items.Clear()
        Do While datardr.Read
            ComboBoxDosen.Items.Add(datardr("nip"))
        Loop
        datardr.Close()
    End Sub

    Private Sub comboRuangan()
        Call bukaDB()
        cmd = New MySqlCommand("select * from ruangan", Koneksi)
        datardr = cmd.ExecuteReader
        ComboBoxRuangan.Items.Clear()
        Do While datardr.Read
            ComboBoxRuangan.Items.Add(datardr("koderuangan"))
        Loop
        datardr.Close()
    End Sub

    Private Sub bersih()
        TextBoxKode.Text = ""
        ComboBoxMataKuliah.Text = ""
        TextBoxMataKuliah.Text = ""
        ComboBoxDosen.Text = ""
        TextBoxDosen.Text = ""
        ComboBoxRuangan.Text = ""
        TextBoxRuangan.Text = ""
        TextBoxWaktu.Text = ""
        TextBoxKode.Focus()
    End Sub

    Private Sub displayData()
        ModuleKoneksi.bukaDB()
        display = "select * from jadwal"
        DA = New MySqlDataAdapter(display, Koneksi)
        ds = New DataSet
        DA.Fill(ds, "jadwal")
        DataGridView1.Refresh()
        DataGridView1.DataSource = ds.Tables("jadwal")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub FormJadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        bersih()
        comboMataKuliah()
        comboDosen()
        comboRuangan()
        DataGridView1.Refresh()
        displayData()
        ButtonSimpan.Enabled = False
    End Sub

    Private Sub ComboBoxMataKuliah_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxMataKuliah.LostFocus
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from matakuliah where kodemk = '" & ComboBoxMataKuliah.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxMataKuliah.Text = datardr("namamk")
                ComboBoxMataKuliah.Focus()
            Else
                ComboBoxMataKuliah.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxMataKuliah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMataKuliah.SelectedIndexChanged
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from matakuliah where kodemk = '" & ComboBoxMataKuliah.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxMataKuliah.Text = datardr("namamk")
                ComboBoxMataKuliah.Focus()
            Else
                ComboBoxMataKuliah.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxDosen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxDosen.LostFocus
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from dosen where nip = '" & ComboBoxDosen.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxDosen.Text = datardr("nama")
                ComboBoxDosen.Focus()
            Else
                ComboBoxDosen.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxDosen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDosen.SelectedIndexChanged
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from dosen where nip = '" & ComboBoxDosen.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxDosen.Text = datardr("nama")
                ComboBoxDosen.Focus()
            Else
                ComboBoxDosen.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        bersih()
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        tambah()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        cmd = New MySqlCommand("select * from jadwal where kodejadwal = '" & TextBoxKode.Text & "'", Koneksi)
        RD = cmd.ExecuteReader
        RD.Read()

        If ButtonSimpan.Enabled = True Then
            If RD.HasRows Then
                MsgBox("Maaf, Data Jadwal dengan Kode Jadwal tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Call bukaDB()
                Call displayData()
            Else
                If MessageBox.Show("Simpan data Jadwal Baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into jadwal(kodejadwal, matakuliah, dosen, ruangan, waktu) values ('" &
                                TextBoxKode.Text & "','" &
                                ComboBoxMataKuliah.Text & "','" &
                                ComboBoxDosen.Text & "','" &
                                ComboBoxRuangan.Text & "','" &
                                TextBoxWaktu.Text & "')"

                    cmd = New MySqlCommand(simpan, Koneksi)
                    cmd.ExecuteNonQuery()
                    Call displayData()
                    TextBoxKode.Focus()
                    MsgBox("Data jadwal sudah tersimpan", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
                Call displayData()
                Call bersih()
            End If
        End If
    End Sub

    Private Sub ComboBoxRuangan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxRuangan.LostFocus
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from ruangan where koderuangan = '" & ComboBoxRuangan.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxRuangan.Text = datardr("namaruangan")
                ComboBoxRuangan.Focus()
            Else
                ComboBoxRuangan.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxRuangan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxRuangan.SelectedIndexChanged
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from ruangan where koderuangan = '" & ComboBoxRuangan.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxRuangan.Text = datardr("namaruangan")
                ComboBoxRuangan.Focus()
            Else
                ComboBoxRuangan.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxKode.ReadOnly = True
        bukaDB()
        cmd = New MySqlCommand("select * from jadwal where kodejadwal = '" & TextBoxKode.Text & "'", Koneksi)

        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxKode.Text = gridbaris.Cells(0).Value.ToString
            ComboBoxMataKuliah.Text = gridbaris.Cells(1).Value.ToString
            ComboBoxDosen.Text = gridbaris.Cells(2).Value.ToString
            ComboBoxRuangan.Text = gridbaris.Cells(3).Value.ToString
            TextBoxWaktu.Text = gridbaris.Cells(4).Value.ToString
        Catch ex As Exception
            MsgBox("Pilih data jadwal yang ada di dalam tabel", MsgBoxStyle.Information, "Info")
        End Try
    End Sub


    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()

                ubah = "update jadwal set kodejadwal = '" & TextBoxKode.Text & "'," &
                                "matakuliah = '" & ComboBoxMataKuliah.Text & "'," &
                                "dosen = '" & ComboBoxDosen.Text & "'," &
                                "ruangan = '" & ComboBoxRuangan.Text & "'," &
                                "waktu = '" & TextBoxWaktu.Text & "'" &
                                "where kodejadwal = '" & TextBoxKode.Text & "'"

                Dim command As New MySqlCommand(ubah, conn)
                command.ExecuteNonQuery()
                MessageBox.Show("Data jadwal sukses tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan dalam ubah data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call displayData()
        Call bersih()
    End Sub


    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If TextBoxKode.Text = "" Then
            MessageBox.Show("Pilih dahulu data jadwal yang akan Anda hapus pada tabel di atas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxKode.Text <> "" Then
                If MessageBox.Show("Apakah Anda yakin akan mengahapus data jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    hapus = "delete from jadwal where kodejadwal = '" & TextBoxKode.Text & "'"
                    cmd = New MySqlCommand(hapus, Koneksi)

                    cmd.ExecuteNonQuery()
                    Call displayData()
                    Call bersih()
                    TextBoxKode.Focus()
                    MessageBox.Show("Data jadwal berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
End Class