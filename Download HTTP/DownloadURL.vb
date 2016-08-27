Imports System.Net
Imports System.IO
Imports System.Text
Public Class DownloadURL
    Private m_URL As String
    Public Property URL() As String
        Get
            Return m_URL
        End Get
        Set(ByVal Value As String)
            m_URL = Value
        End Set
    End Property
    Public Sub DownloadURL(ByRef Conteudo As String)
        Dim Req As WebRequest = WebRequest.Create(m_URL)
        Dim Res As WebResponse = Req.GetResponse
        Dim TotalBuffer As Int32 = 0
        Dim Buffer(128) As [Byte]
        Dim Stream As Stream = Res.GetResponseStream
        TotalBuffer = Stream.Read(Buffer, 0, 128)
        Dim strRes As New StringBuilder("")
        While TotalBuffer <> 0
            strRes.Append(Encoding.ASCII.GetString(Buffer, 0, 128))
            TotalBuffer = Stream.Read(Buffer, 0, 128)
        End While
        Conteudo = strRes.ToString
    End Sub
End Class
