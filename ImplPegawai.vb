Option Strict On
Imports System.Data.OleDb
Imports System.Data
Public Class ImplPegawai
    Implements IntPegawai
    Private koneksi As New koneksiData
    Private dataRead As OleDbDataReader
    Private cmd As OleDbCommand
    Private strSQL As String

    Protected Function addData() As System.Collections.ArrayList Implements IntPegawai.addDataPegawai
        Dim arr As New ArrayList
        strSQL = "SELECT Nik,Nama_Karyawan,Alamat,Telp FROM pegawai ORDER BY Nik"
        Try
            cmd = New OleDbCommand(strSQL, koneksi.konek)
            dataRead = cmd.ExecuteReader
            If Not dataRead Is Nothing Then
                While dataRead.Read
                    Dim pegawai As New EntPegawai
                    With pegawai
                        .NIK = dataRead.GetString(0)
                        .Nama = dataRead.GetString(1)
                        .Alamat = dataRead.GetString(2)
                        .Telp = dataRead.GetString(3)
                    End With
                    arr.Add(pegawai)
                End While
                Return arr
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    Protected Function cariDataPegawai(ByVal nik As String) As EntPegawai Implements IntPegawai.cariDataPegawai
        Try
            cmd = New OleDbCommand("QueryKaryawan", koneksi.konek)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NikKaryawan", nik)
            cmd.Parameters("NikKaryawan").Direction = ParameterDirection.Input
            dataRead = cmd.ExecuteReader
            If dataRead.Read Then
                Dim obj As New EntPegawai
                With obj
                    .Nama = dataRead.GetString(1)
                    .Alamat = dataRead.GetString(2)
                    .Telp = dataRead.GetString(3)
                End With
                Return obj
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    Protected Function hapusPegawai(ByVal NIK As String) As Boolean Implements IntPegawai.hapusPegawai
        Try
            cmd = New OleDbCommand("QueryDelPeg", koneksi.konek)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NIK_", NIK)
            cmd.Parameters("NIK_").Direction = ParameterDirection.Input
            If cmd.ExecuteNonQuery = 1 Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Protected Function simpanData(ByVal entity As EntPegawai) As Boolean Implements IntPegawai.simpanData
        Try
            cmd = New OleDbCommand("tambahPegawai", koneksi.konek)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NIK_", entity.NIK) : cmd.Parameters("NIK_").Direction = ParameterDirection.Input
            cmd.Parameters.AddWithValue("Nama_", entity.Nama) : cmd.Parameters("Nama_").Direction = ParameterDirection.Input
            cmd.Parameters.AddWithValue("Alamat_", entity.Alamat) : cmd.Parameters("Alamat_").Direction = ParameterDirection.Input
            cmd.Parameters.AddWithValue("Telp_", entity.Telp) : cmd.Parameters("Telp_").Direction = ParameterDirection.Input
            If cmd.ExecuteNonQuery = 1 Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Protected Function autoNumber() As String Implements IntPegawai.autoNumber
        Dim formatNIK As String
        Try
            cmd = New OleDbCommand("NomorIndukPegawai", koneksi.konek)
            cmd.CommandType = CommandType.StoredProcedure
            dataRead = cmd.ExecuteReader
            If dataRead.Read Then
                formatNIK = Format(Val(Mid(dataRead.GetString(0), 3, 3)) + 1, "NI00#")
                Return formatNIK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return "NI001"
    End Function
    Protected Sub updatePegawai(ByVal entity As EntPegawai) Implements IntPegawai.updatePegawai
        Try
            cmd = New OleDbCommand("update_Pegawai", koneksi.konek)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NamaPegawai", entity.Nama)
            cmd.Parameters.AddWithValue("AlamatPegawai", entity.Alamat)
            cmd.Parameters.AddWithValue("TelpPegawai", entity.Telp)
            cmd.Parameters.AddWithValue("NIKPegawai", entity.NIK)
            If cmd.ExecuteNonQuery = 1 Then
                MessageBox.Show("Data berhasil diupdate")
            Else
                MessageBox.Show("gagal update")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
