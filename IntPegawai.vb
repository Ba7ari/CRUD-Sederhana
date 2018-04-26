Public Interface IntPegawai
    Function addDataPegawai() As ArrayList
    Function cariDataPegawai(ByVal nik As String) As EntPegawai
    Function hapusPegawai(ByVal NIK As String) As Boolean
    Function simpanData(ByVal entity As EntPegawai) As Boolean
    Sub updatePegawai(ByVal entity As EntPegawai)
    Function autoNumber() As String
End Interface
