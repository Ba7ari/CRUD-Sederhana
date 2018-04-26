Public Class EntPegawai
    Private Nik_, Nama_, Alamat_, Telp_ As String
    Public Property NIK() As String
        Get
            Return Nik_
        End Get
        Set(ByVal value As String)
            Nik_ = value
        End Set
    End Property
    Public Property Nama() As String
        Get
            Return Nama_
        End Get
        Set(ByVal value As String)
            Nama_ = value
        End Set
    End Property
    Public Property Alamat() As String
        Get
            Return Alamat_
        End Get
        Set(ByVal value As String)
            Alamat_ = value
        End Set
    End Property
    Public Property Telp() As String
        Get
            Return Telp_
        End Get
        Set(ByVal value As String)
            Telp_ = value
        End Set
    End Property
End Class
