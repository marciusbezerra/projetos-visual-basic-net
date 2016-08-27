
Imports System.Security.Cryptography
Imports System.Text

Public Class Util
    Public Shared Function GetHash(ByVal Texto As String) As String
        Dim Ue As New UnicodeEncoding
        Dim ByteSourceText() As Byte = Ue.GetBytes(Texto)
        Dim Md5 As New MD5CryptoServiceProvider
        Dim BytesHash() As Byte = Md5.ComputeHash(ByteSourceText)
        Return Convert.ToBase64String(BytesHash)
    End Function
End Class
