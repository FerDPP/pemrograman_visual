Module MyMod
    Public users_api As String = "http://f0833853.xsph.ru/jasaservis/login/users_api.php"
    Public jasa_api As String = "http://f0833853.xsph.ru/jasaservis/appbengkel/jasa_api.php"
    Public pelanggan_api As String = "http://f0833853.xsph.ru/jasaservis/appbengkel/pelanggan_api.php"
    Public Dashboard As New Form1
    Public DJasaForm As New DJasa
    Public DPelangganForm As New DPelanggan
    Public LoginForm As New Login
    Public admin_role As Boolean = False
    Public dosen_role As Boolean = False
    Public login_valid As Boolean = False
    Public jasa_baru As Boolean
    Public pelanggan_baru As Boolean

End Module
