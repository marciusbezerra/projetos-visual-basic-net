Option Explicit On 
Public Class Convertedor

    ' basConvert: Utilities to convert between byte arrays, hex strings,
    ' strings containing binary values, and 32-bit word arrays.

    ' NB: On 32-bit Unicode/CJK systems you may need to do a global
    ' replace of Asc() and Chr() with AscW() and ChrW() respectively.

    ' Version 2. November 2003: removed cv_BytesFromString which can be
    ' done with abBytes = StrConv(strInput, vbFromUnicode).
    ' - Added error handling to catch empty arrays.
    ' - Made HexFromByte public.
    ' Version 1. First published January 2002
    '************************* COPYRIGHT NOTICE*************************
    ' This code was originally written in Visual Basic by David Ireland
    ' and is copyright (c) 2000-2 D.I. Management Services Pty Limited,
    ' all rights reserved.

    ' You are free to use this code as part of your own applications
    ' provided you keep this copyright notice intact.

    ' This code may only be used as part of an application. It may
    ' not be reproduced or distributed separately by any means without
    ' the express written permission of the author.

    ' David Ireland and DI Management Services Pty Limited make no
    ' representations concerning either the merchantability of this
    ' software or the suitability of this software for any particular
    ' purpose. It is provided "as is" without express or implied
    ' warranty of any kind.

    ' Please forward comments or bug reports to <code@di-mgt.com.au>.
    ' The latest version of this source code can be downloaded from
    ' www.di-mgt.com.au/crypto.html.
    '****************** END OF COPYRIGHT NOTICE*************************

    'Converted from VB6 to DoNET by marciusbezerra@aol.com

    Public Function HexParaBytes(ByVal ValorHex As String) As Byte()
        Dim i As Integer
        Dim M As Integer
        Dim aBytes() As Byte
        If Len(ValorHex) Mod 2 <> 0 Then
            ValorHex = "0" & ValorHex
        End If

        M = Len(ValorHex) \ 2
        If M <= 0 Then Return aBytes

        ReDim aBytes(M - 1)

        For i = 0 To M - 1
            aBytes(i) = CByte(Val("&H" & Mid(ValorHex, i * 2 + 1, 2)))
        Next

        Return aBytes

    End Function

    Public Function HexParaWords(ByVal ValorHex As String) As Integer()
        Const ncLEN As Short = 8
        Dim i As Integer
        Dim nWords As Integer
        Dim aWords() As Integer

        nWords = Len(ValorHex) \ ncLEN
        If nWords <= 0 Then Return aWords

        ReDim aWords(nWords - 1)
        For i = 0 To nWords - 1
            aWords(i) = CInt(Val("&H" & Mid(ValorHex, i * ncLEN + 1, ncLEN)))
        Next

        Return aWords

    End Function

    Public Function WordsParaHex(ByRef ValorWords As Integer()) As String

        Const ncLEN As Short = 8
        Dim i As Integer
        Dim nWords As Integer
        Dim sHex As New String(" ", 0, ncLEN - 1)
        Dim iIndex As Integer

        On Error GoTo ArrayIsEmpty
        If Not IsArray(ValorWords) Then
            Exit Function
        End If

        nWords = UBound(ValorWords) - LBound(ValorWords) + 1
        WordsParaHex = New String(CChar(" "), nWords * ncLEN)
        iIndex = 0
        For i = 0 To nWords - 1
            'sHex.Value = Hex(aWords(i))
            sHex = Hex(ValorWords(i))
            'sHex.Value = New String(CChar("0"), ncLEN - Len(sHex.Value)) & sHex.Value
            sHex = New String(CChar("0"), ncLEN - Len(sHex)) & sHex
            'Mid(cv_HexFromWords, iIndex + 1, ncLEN) = sHex.Value
            Mid(WordsParaHex, iIndex + 1, ncLEN) = sHex
            iIndex = iIndex + ncLEN
        Next

ArrayIsEmpty:

    End Function

    Public Function BytesParaHex(ByRef aBytes() As Byte) As String
        Dim i As Integer
        Dim iIndex As Integer
        Dim nLen As Integer

        On Error GoTo ArrayIsEmpty

        nLen = UBound(aBytes) - LBound(aBytes) + 1

        BytesParaHex = New String(CChar(" "), nLen * 2)
        iIndex = 0
        For i = LBound(aBytes) To UBound(aBytes)
            Mid(BytesParaHex, iIndex + 1, 2) = HexFromByte(aBytes(i))
            iIndex = iIndex + 2
        Next

ArrayIsEmpty:

    End Function

    Public Function StringParaHex(ByRef ValorString As String) As String

        Dim byt As Byte
        Dim i As Integer
        Dim n As Integer
        Dim iIndex As Integer
        Dim sHex As String

        n = Len(ValorString)
        sHex = New String(CChar(" "), n * 2)
        iIndex = 0
        For i = 1 To n
            byt = CByte(Asc(Mid(ValorString, i, 1)) And &HFFS)
            Mid(sHex, iIndex + 1, 2) = HexFromByte(byt)
            iIndex = iIndex + 2
        Next
        Return sHex

    End Function

    Public Function HexParaString(ByRef ValorHex As String) As String

        Dim i, nBytes As Integer

        nBytes = Len(ValorHex) \ 2
        HexParaString = New String(CChar(" "), nBytes)
        For i = 0 To nBytes - 1
            Mid(HexParaString, i + 1, 1) = Chr(CInt(Val("&H" & Mid(ValorHex, i * 2 + 1, 2))))
        Next

    End Function

    Public Function PegaByteHex(ByVal ValorHex As String, ByRef Indice As Integer) As Byte

        Dim i As Integer
        i = 2 * Indice
        If i > Len(ValorHex) Or i <= 0 Then
            Return 0
        Else
            Return CByte(Val("&H" & Mid(ValorHex, i - 1, 2)))
        End If

    End Function

    Public Function RandHexByte() As String

        Static stbInit As Boolean
        If Not stbInit Then
            Randomize()
            stbInit = True
        End If

        RandHexByte = HexFromByte(CByte((Rnd() * 256) And &HFFS))
    End Function

    Public Function HexFromByte(ByVal x As Integer) As String
        x = x And &HFFS

        If x < 16 Then
            HexFromByte = "0" & Hex(x)
        Else
            HexFromByte = Hex(x)
        End If
    End Function


    Public Function testWordsHex() As Object
        Dim aWords As Integer()

        aWords = HexParaWords("FEDCBA9876543210")
        System.Diagnostics.Debug.WriteLine(WordsParaHex(aWords))

    End Function
End Class
