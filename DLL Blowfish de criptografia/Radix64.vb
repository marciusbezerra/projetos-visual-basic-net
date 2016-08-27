Option Explicit On 
Public Class Radix64

    ' basRadix64: Radix 64 en/decoding functions
    ' Version 6. 20 November 2003. Added error handling for empty arrays.
    ' Version 5. 10 August 2003. Added EncodeBytes64() and DecodeBytes64()
    '            functions that "do it properly" using a Byte array for
    '            binary data and a String for textual data.
    ' Version 4. 17 August 2002 re-write even faster using Byte arrays
    '            and StrConv function. Thanks to Chris Thompson for this
    '            and for other much appreciated advice incorporated here.
    ' Version 3.1: 13 August 2002 mod to DecodeStr64 function
    '              to cope with invalid characters.
    '              Thanks to Seth Perelman for this.
    ' Version 3. Published January 2002 with even faster SHR/SHL functions
    '            and using Mid$ function instead of appending to strings.
    ' Version 2. Published 12 May 2001
    ' Version 1. Published 28 December 2000
    '************************* COPYRIGHT NOTICE*************************
    ' This code was originally written in Visual Basic by David Ireland
    ' and is copyright (c) 2000-3 D.I. Management Services Pty Limited,
    ' all rights reserved.

    ' You are free to use this code as part of your own applications
    ' provided you keep this copyright notice intact and acknowledge
    ' its authorship with the words:

    '   "Contains cryptography software by David Ireland of
    '   DI Management Services Pty Ltd <www.di-mgt.com.au>."

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

    ' Credit where credit is due:
    ' Some parts of this VB code are based on original C code
    ' by Carl M. Ellison. See "cod64.c" published 1995.
    '****************** END OF COPYRIGHT NOTICE*************************

    'Converted from VB6 to DoNET by marciusbezerra@aol.com

    Private aDecTab(255) As Integer
    Private aEncTab(63) As Byte

    Public Function EncodeBytes64(ByRef abBytes() As Byte) As String

        Dim sOutput As String
        Dim abOutput() As Byte
        Dim sLast As String
        Dim b(3) As Byte
        Dim j As Short
        Dim nLen, i, nQuants As Integer
        Dim iIndex As Integer

        On Error GoTo ArrayIsEmpty
        nLen = UBound(abBytes) - LBound(abBytes) + 1
        nQuants = nLen \ 3
        iIndex = 0
        Call FazerEncTab()
        If (nQuants > 0) Then
            ReDim abOutput(nQuants * 4 - 1)
            For i = 0 To nQuants - 1
                For j = 0 To 2
                    b(j) = abBytes((i * 3) + j)
                Next
                Call EncodeQuantumB(b)
                abOutput(iIndex) = b(0)
                abOutput(iIndex + 1) = b(1)
                abOutput(iIndex + 2) = b(2)
                abOutput(iIndex + 3) = b(3)
                iIndex = iIndex + 4
            Next
            sOutput = System.Text.Encoding.Unicode.Default.GetString(abOutput)
        End If

        Select Case nLen Mod 3
            Case 0
                sLast = ""
            Case 1
                b(0) = abBytes(nLen - 1)
                b(1) = 0
                b(2) = 0
                Call EncodeQuantumB(b)
                sLast = System.Text.Encoding.Unicode.Default.GetString(b)
                sLast = Left(sLast, 2) & "=="
            Case 2
                b(0) = abBytes(nLen - 2)
                b(1) = abBytes(nLen - 1)
                b(2) = 0
                Call EncodeQuantumB(b)
                sLast = System.Text.Encoding.Unicode.Default.GetString(b)
                sLast = Left(sLast, 3) & "="
        End Select

        EncodeBytes64 = sOutput & sLast

ArrayIsEmpty:

    End Function

    Public Function DecodeBytes64(ByRef Codificado As String) As Byte()

        Dim abDecoded() As Byte
        Dim d(3) As Byte
        Dim C, di As Integer
        Dim i As Integer
        Dim nLen As Integer
        Dim iIndex As Integer

        nLen = Len(Codificado)
        If nLen < 4 Then Return abDecoded

        ReDim abDecoded(((nLen \ 4) * 3) - 1)

        iIndex = 0
        di = 0
        Call FazerDecTab()
        For i = 1 To Len(Codificado)
            C = CByte(Asc(Mid(Codificado, i, 1)))
            C = aDecTab(C)
            If C >= 0 Then
                d(di) = CByte(C)
                di = di + 1
                If di = 4 Then
                    abDecoded(iIndex) = CByte(SHL2(d(0)) Or (SHR4(d(1)) And &H3S))
                    iIndex = iIndex + 1
                    abDecoded(iIndex) = CByte(SHL4(CByte(d(1) And &HFS)) Or (SHR2(d(2)) And &HFS))
                    iIndex = iIndex + 1
                    abDecoded(iIndex) = SHL6(CByte(d(2) And &H3S)) Or d(3)
                    iIndex = iIndex + 1
                    If d(3) = 64 Then
                        iIndex = iIndex - 1
                        abDecoded(iIndex) = 0
                    End If
                    If d(2) = 64 Then
                        iIndex = iIndex - 1
                        abDecoded(iIndex) = 0
                    End If
                    di = 0
                End If
            End If
        Next i

        ReDim Preserve abDecoded(iIndex - 1)
        Return abDecoded
    End Function

    Public Function EncodeStr64(ByRef ValorString As String) As String
        Dim abOutput() As Byte
        Dim sLast As String
        Dim b(3) As Byte
        Dim j As Short
        Dim nLen, i, nQuants As Integer
        Dim iIndex As Integer

        EncodeStr64 = ""
        nLen = Len(ValorString)
        nQuants = nLen \ 3
        iIndex = 0
        Call FazerEncTab()
        If (nQuants > 0) Then
            ReDim abOutput(nQuants * 4 - 1)
            For i = 0 To nQuants - 1
                For j = 0 To 2
                    b(j) = CByte(Asc(Mid(ValorString, (i * 3) + j + 1, 1)))
                Next
                Call EncodeQuantumB(b)
                abOutput(iIndex) = b(0)
                abOutput(iIndex + 1) = b(1)
                abOutput(iIndex + 2) = b(2)
                abOutput(iIndex + 3) = b(3)
                iIndex = iIndex + 4
            Next
            EncodeStr64 = System.Text.Encoding.Unicode.Default.GetString(abOutput)
        End If

        Select Case nLen Mod 3
            Case 0
                sLast = ""
            Case 1
                b(0) = CByte(Asc(Mid(ValorString, nLen, 1)))
                b(1) = 0
                b(2) = 0
                Call EncodeQuantumB(b)
                sLast = System.Text.Encoding.Unicode.Default.GetString(b)
                sLast = Left(sLast, 2) & "=="
            Case 2
                b(0) = CByte(Asc(Mid(ValorString, nLen - 1, 1)))
                b(1) = CByte(Asc(Mid(ValorString, nLen, 1)))
                b(2) = 0
                Call EncodeQuantumB(b)
                sLast = System.Text.Encoding.Unicode.Default.GetString(b)
                sLast = Left(sLast, 3) & "="
        End Select

        EncodeStr64 = EncodeStr64 & sLast
    End Function

    Public Function DecodeStr64(ByRef Codificado As String) As String

        Dim abDecoded() As Byte
        Dim d(3) As Byte
        Dim i, di, C As Integer
        Dim nLen As Integer
        Dim iIndex As Integer

        nLen = Len(Codificado)
        If nLen < 4 Then
            Exit Function
        End If
        ReDim abDecoded(((nLen \ 4) * 3) - 1)

        iIndex = 0
        di = 0
        Call FazerDecTab()

        For i = 1 To Len(Codificado)
            C = CByte(Asc(Mid(Codificado, i, 1)))
            C = aDecTab(C)
            If C >= 0 Then
                d(di) = CByte(C)
                di = di + 1
                If di = 4 Then
                    abDecoded(iIndex) = CByte(SHL2(d(0)) Or (SHR4(d(1)) And &H3S))
                    iIndex = iIndex + 1
                    abDecoded(iIndex) = CByte(SHL4(CByte(d(1) And &HFS)) Or (SHR2(d(2)) And &HFS))
                    iIndex = iIndex + 1
                    abDecoded(iIndex) = SHL6(CByte(d(2) And &H3S)) Or d(3)
                    iIndex = iIndex + 1
                    If d(3) = 64 Then
                        iIndex = iIndex - 1
                        abDecoded(iIndex) = 0
                    End If
                    If d(2) = 64 Then
                        iIndex = iIndex - 1
                        abDecoded(iIndex) = 0
                    End If
                    di = 0
                End If
            End If
        Next i

        DecodeStr64 = System.Text.Encoding.Unicode.Default.GetString(abDecoded)
        DecodeStr64 = Left(DecodeStr64, iIndex)
    End Function

    Private Sub EncodeQuantumB(ByRef b() As Byte)

        Dim b2, b0, b1, b3 As Byte

        b0 = CByte(SHR2(b(0)) And &H3FS)
        b1 = CByte(SHL4(CByte(b(0) And &H3S)) Or (SHR4(b(1)) And &HFS))
        b2 = CByte(SHL2(CByte(b(1) And &HFS)) Or (SHR6(b(2)) And &H3S))
        b3 = CByte(b(2) And &H3FS)

        b(0) = aEncTab(b0)
        b(1) = aEncTab(b1)
        b(2) = aEncTab(b2)
        b(3) = aEncTab(b3)

    End Sub


    Private Function FazerDecTab() As Object

        Dim t, C As Integer

        For C = 0 To 255
            aDecTab(C) = -1
        Next

        t = 0
        For C = Asc("A") To Asc("Z")
            aDecTab(C) = t
            t = t + 1
        Next

        For C = Asc("a") To Asc("z")
            aDecTab(C) = t
            t = t + 1
        Next

        For C = Asc("0") To Asc("9")
            aDecTab(C) = t
            t = t + 1
        Next

        C = Asc("+")
        aDecTab(C) = t
        t = t + 1

        C = Asc("/")
        aDecTab(C) = t
        t = t + 1

        C = Asc("=")
        aDecTab(C) = t

    End Function

    Private Function FazerEncTab() As Object

        Dim i As Integer
        Dim C As Byte

        i = 0
        For C = Asc("A") To Asc("Z")
            aEncTab(i) = C
            i = i + 1
        Next

        For C = Asc("a") To Asc("z")
            aEncTab(i) = C
            i = i + 1
        Next

        For C = Asc("0") To Asc("9")
            aEncTab(i) = C
            i = i + 1
        Next

        C = Asc("+")
        aEncTab(i) = C
        i = i + 1

        C = Asc("/")
        aEncTab(i) = C
        i = i + 1

    End Function

    Private Function SHL2(ByVal ValorByte As Byte) As Byte
        SHL2 = CByte((ValorByte * &H4S) And &HFFS)
    End Function

    Private Function SHL4(ByVal ValorByte As Byte) As Byte
        SHL4 = CByte((ValorByte * &H10S) And &HFFS)
    End Function

    Private Function SHL6(ByVal ValorByte As Byte) As Byte
        SHL6 = CByte((ValorByte * &H40S) And &HFFS)
    End Function

    Private Function SHR2(ByVal ValorByte As Byte) As Byte
        SHR2 = CByte(ValorByte \ &H4S)
    End Function

    Private Function SHR4(ByVal ValorByte As Byte) As Byte
        SHR4 = CByte(ValorByte \ &H10S)
    End Function

    Private Function SHR6(ByVal ValorByte As Byte) As Byte
        SHR6 = CByte(ValorByte \ &H40S)
    End Function
End Class