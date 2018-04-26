Imports System.Data.OleDb
Imports System.Data
Public Class koneksiData
    Private koneksi As New OleDbConnection
    Public Sub New()
        'koneksi = New OleDbConnection("PROVIDER=MICROSOFT.Jet.Oledb.4.0;Data Source =" & Application.StartupPath & "\database5.mdb")
        koneksi = New OleDbConnection("PROVIDER=MICROSOFT.Jet.Oledb.4.0;Data Source =" & Application.StartupPath & "\Database5.mdb")
    End Sub
    Public Function konek() As OleDbConnection
        Try
            If koneksi.State <> ConnectionState.Closed Then koneksi.Close()
            koneksi.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
        Return koneksi
    End Function

End Class
