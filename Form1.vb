Public Class frmMain
    Private ctrlPegawai As IntPegawai
    Private strNik As String = ""
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        addPegawai()
    End Sub
    Private Sub addPegawai()
        ctrlPegawai = New ImplPegawai
        Dim p As New EntPegawai
        Dim arr As New ArrayList
        Dim i As Integer
        tvData.Nodes.Clear()
        With tvData.Nodes.Add("NIK")
            For i = 0 To ctrlPegawai.addDataPegawai.Count - 1
                Dim obj As EntPegawai = CType(ctrlPegawai.addDataPegawai(i), EntPegawai)
                .Nodes.Add(obj.NIK)
            Next
        End With
    End Sub
    Private Sub tvData_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvData.AfterSelect
        ctrlPegawai = New ImplPegawai
        With tvData.Nodes.Item(0)
            Dim i As Integer
            For i = 0 To .Nodes.Count - 1
                If .Nodes(i).IsSelected Then
                    strNik = .Nodes(i).Text
                    Console.WriteLine(strNik)
                End If
            Next
        End With
        With ctrlPegawai.cariDataPegawai(strNik)
            txtNama.Text = .Nama
            txtAlamat.Text = .Alamat
            txtTelp.Text = .Telp
        End With
        enabledTeks(False)
        cmdTambah.Text = "Tambah"
    End Sub

    Private Sub tvData_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvData.NodeMouseClick
        e.Node.SelectedImageIndex = 0
    End Sub
 
    Private Sub HapusNIK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HapusNIK.Click
        If MessageBox.Show("Yakin ingin menghapus nik " & strNik, "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If ctrlPegawai.hapusPegawai(strNik) Then
                MessageBox.Show("Data sudah dihapus", "Success") : addPegawai()
                tvData.ExpandAll()
            End If
        End If
    End Sub

    Private Sub cmdTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambah.Click
        If cmdTambah.Text = "Tambah" Then
            enabledTeks(True)
            Reset()
            cmdTambah.Text = "Simpan" : cmdUpdate.Enabled = False
        ElseIf cmdTambah.Text = "Simpan" Then
            If txtNama.Text = String.Empty Or txtAlamat.Text = String.Empty Or txtTelp.Text = String.Empty Then
                MessageBox.Show("Mohon isi data Pegawai", "Informasi")
                enabledTeks(False)
                buttonRes()
            ElseIf MessageBox.Show("Ingin Menyimpan Data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim entitas As New EntPegawai
                With entitas
                    .NIK = ctrlPegawai.autoNumber
                    .Nama = txtNama.Text
                    .Alamat = txtAlamat.Text
                    .Telp = txtTelp.Text
                End With
                If ctrlPegawai.simpanData(entitas) Then
                    MessageBox.Show("Data berhasil disimpan", "Informasi")
                    Reset()
                    enabledTeks(False)
                    cmdTambah.Text = "Tambah"
                    addPegawai()
                    tvData.ExpandAll()
                End If
            End If
            End If
    End Sub
    Private Sub enabledTeks(ByVal b As Boolean)
        If b = True Then
            txtNama.Enabled = True
            txtAlamat.Enabled = True
            txtTelp.Enabled = True
            txtNama.Focus()
        Else
            txtNama.Enabled = False
            txtAlamat.Enabled = False
            txtTelp.Enabled = False
        End If
    End Sub
    Private Sub Reset()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub UpdateNIK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateNIK.Click
        cmdUpdate.Enabled = True
        enabledTeks(True)
        cmdTambah.Enabled = False
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim entitas As New EntPegawai
        ctrlPegawai = New ImplPegawai
        With entitas
            .NIK = strNik
            .Nama = txtNama.Text
            .Alamat = txtAlamat.Text
            .Telp = txtTelp.Text
        End With
        If MessageBox.Show("Yakin ingin update data '" & strNik & "'?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ctrlPegawai.updatePegawai(entitas)
        End If
        enabledTeks(False)
        cmdTambah.Enabled = True
        cmdUpdate.Enabled = False
    End Sub

   
    Private Sub buttonRes()
        cmdTambah.Enabled = True
        cmdTambah.Text = "Tambah"
        cmdUpdate.Enabled = False

    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        Reset()
        buttonRes()
        enabledTeks(False)
    End Sub
End Class
