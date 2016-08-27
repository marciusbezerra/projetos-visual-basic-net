Module Seguranca
    Public Const MS_DEF_PROV As String = "Microsoft Base Cryptographic Provider v1.0"
    Public Const PROV_RSA_FULL As Int32 = 1
    Public Const CRYPT_NEWKEYSET As Int32 = &H8
    Public Const HP_HASHSIZE As Int32 = &H4
    Public Const HP_HASHVAL As Int32 = &H2
    'Public Const ALG_CLASS_HASH As Int32 = (4 * 2 ^ 13)
    'Public Const ALG_SID_MD5 As Int32 = 3
    'Public Const ALG_TYPE_ANY As Int32 = 0
    Public Const CALG_MD5 As Int32 = &H8003&
    Public Declare Function CryptAcquireContext Lib "advapi32.dll" Alias "CryptAcquireContextA" (ByRef phProv As Int32, ByVal pszContainer As String, ByVal pszProvider As String, ByVal dwProvType As Int32, ByVal dwFlags As Int32) As Int32
    Public Declare Function CryptCreateHash Lib "advapi32.dll" (ByRef hProv As Int32, ByRef Algid As Int32, ByRef hKey As Int32, ByVal dwFlags As Int32, ByRef phHash As Int32) As Int32
    Public Declare Function CryptHashData Lib "advapi32.dll" (ByRef hHash As Int32, ByVal pbData As String, ByVal dwDataLen As Int32, ByVal dwFlags As Int32) As Int32
    Public Declare Function CryptGetHashParam Lib "advapi32.dll" (ByVal hHash As Int32, ByVal dwParam As Int32, ByVal pByte As String, ByRef pdwDataLen As Int32, ByVal dwFlags As Int32) As Int32
    Public Declare Function CryptDestroyHash Lib "advapi32.dll" (ByRef hHash As Int32) As Int32
    Public Declare Function CryptReleaseContext Lib "advapi32.dll" (ByRef hProv As Int32, ByRef dwFlags As Int32) As Int32
End Module
