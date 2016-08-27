Option Explicit On 
Imports System.Runtime.InteropServices
Public Class FuncoesComBytes

    ' basBlowfishByteFns: Wrapper functions to call Blowfish algorithms

    ' Version 6. November 2003. Added this module with new Byte functions
    ' Blowfish in Visual Basic first published October 2000.
    '************************* COPYRIGHT NOTICE*************************
    ' This code was originally written in Visual Basic by David Ireland
    ' and is copyright (c) 2000-3 D.I. Management Services Pty Limited,
    ' all rights reserved.

    ' You are free to use this code as part of your own applications
    ' provided you keep this copyright notice intact and acknowledge
    ' its authorship with the words:

    '   "Contains cryptography software by David Ireland of
    '   DI Management Services Pty Ltd <www.di-mgt.com.au>."

    ' If you use it as part of a web site, please include a link
    ' to our site in the form
    ' <A HREF="http://www.di-mgt.com.au/crypto.html">Cryptography
    ' Software Code</a>

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

    Private bf As Blowfish

    Public Function BytesRaw(ByRef Dados() As Byte, ByRef Encriptar As Boolean) As Byte()

        Dim nLen As Integer
        Dim nBlocks As Integer
        Dim iBlock As Integer
        Dim j As Integer
        Dim abOutput() As Byte
        Dim abBlock(7) As Byte
        Dim iIndex As Integer

        nLen = UBound(Dados) - LBound(Dados) + 1
        nBlocks = nLen \ 8

        ReDim abOutput(nBlocks * 8 - 1)

        iIndex = 0
        For iBlock = 1 To nBlocks
            Array.Copy(Dados, iIndex, abBlock, 0, 8)

            If Encriptar Then
                Call bf.EncriptarBytes(abBlock)
            Else
                Call bf.DecriptarBytes(abBlock)
            End If

            Array.Copy(abBlock, 0, abOutput, iIndex, 8)

            iIndex = iIndex + 8
        Next

        Return abOutput
    End Function

    Public Function EncriptarBytes(ByRef Dados() As Byte) As Byte()

        Dim abOutput() As Byte

        abOutput = PadBytes(Dados)
        abOutput = BytesRaw(abOutput, True)

        Return abOutput
    End Function

    Public Function DecriptarBytes(ByRef Dados() As Byte) As Byte()

        Dim abOutput() As Byte

        abOutput = BytesRaw(Dados, False)
        abOutput = UnpadBytes(abOutput)

        Return abOutput
    End Function

    Public Function PadBytes(ByRef Dados() As Byte) As Byte()

        Dim nLen, nPad As Integer
        Dim abPadded() As Byte
        Dim i As Integer

        On Error GoTo ArrayIsEmpty

        nLen = UBound(Dados) - LBound(Dados) + 1
        nPad = ((nLen \ 8) + 1) * 8 - nLen

        ReDim abPadded(nLen + nPad - 1)
        If nLen > 0 Then
            Array.Copy(Dados, 0, abPadded, 0, nLen)
        End If
        For i = nLen To nLen + nPad - 1
            abPadded(i) = CByte(nPad)
        Next

ArrayIsEmpty:
        Return abPadded

    End Function

    Public Function UnpadBytes(ByRef Dados() As Byte) As Byte()

        Dim nLen As Integer
        Dim nPad As Integer
        Dim abUnpadded() As Byte
        Dim i As Integer

        On Error GoTo ArrayIsEmpty

        nLen = UBound(Dados) - LBound(Dados) + 1
        If nLen = 0 Then GoTo ArrayIsEmpty
        nPad = Dados(nLen - 1)
        If nPad > 8 Then nPad = 0
        If nLen - nPad > 0 Then
            ReDim abUnpadded(nLen - nPad - 1)
            Array.Copy(Dados, 0, abUnpadded, 0, nLen - nPad)
        End If

ArrayIsEmpty:
        Return abUnpadded

    End Function

    Public Function TestaPadBytes() As Object
        Dim abData() As Byte

        abData = System.Text.UnicodeEncoding.Unicode.GetBytes("abc")
        abData = PadBytes(abData)
        Stop
        abData = UnpadBytes(abData)
        Stop

    End Function

    Private Sub bXorBytes(ByRef aByt1() As Byte, ByRef aByt2() As Byte, ByRef nBytes As Integer)
        Dim i As Integer
        For i = 0 To nBytes - 1
            aByt1(i) = aByt1(i) Xor aByt2(i)
        Next
    End Sub

    Public Function EncriptarBytesRawCBC(ByRef Dados() As Byte, ByRef abInitV() As Byte) As Byte()
        Dim nLen As Integer
        Dim nBlocks As Integer
        Dim iBlock As Integer
        Dim abBlock(7) As Byte
        Dim iIndex As Integer
        Dim abReg(7) As Byte
        Dim abOutput() As Byte

        ReDim Preserve abInitV(7)

        nLen = UBound(Dados) - LBound(Dados) + 1
        nBlocks = nLen \ 8

        ReDim abOutput(nBlocks * 8 - 1)

        Array.Copy(abInitV, 0, abReg, 0, 8)

        iIndex = 0
        For iBlock = 1 To nBlocks
            Array.Copy(Dados, iIndex, abBlock, 0, 8)

            Call bXorBytes(abBlock, abReg, 8)

            Call bf.EncriptarBytes(abBlock)

            Array.Copy(abBlock, 0, abReg, 0, 8)

            Array.Copy(abBlock, 0, abOutput, iIndex, 8)

            iIndex = iIndex + 8
        Next

        Return abOutput

    End Function

    Public Function DecriptarBytesRawCBC(ByRef Dados() As Byte, ByRef abInitV() As Byte) As Byte()

        Dim strIn As String
        Dim strOut As String
        Dim nLen As Integer
        Dim nBlocks As Integer
        Dim iBlock As Integer
        Dim abBlock(7) As Byte
        Dim iIndex As Integer
        Dim abReg(7) As Byte
        Dim abStore(7) As Byte
        Dim abOutput() As Byte

        ReDim Preserve abInitV(7)

        nLen = UBound(Dados) - LBound(Dados) + 1
        nBlocks = nLen \ 8

        ReDim abOutput(nBlocks * 8 - 1)

        Array.Copy(abInitV, 0, abReg, 0, 8)

        iIndex = 0
        For iBlock = 1 To nBlocks
            Array.Copy(Dados, iIndex, abBlock, 0, 8)
            Array.Copy(abBlock, 0, abStore, 0, 8)
            Call bf.DecriptarBytes(abBlock)

            Call bXorBytes(abBlock, abReg, 8)

            Array.Copy(abStore, 0, abReg, 0, 8)

            Array.Copy(abBlock, 0, abOutput, iIndex, 8)

            iIndex = iIndex + 8
        Next

        Return abOutput

    End Function

    Public Function EncriptarBytesCBC(ByRef Dados() As Byte, ByRef abInitV() As Byte) As Byte()

        Dim abOutput() As Byte

        abOutput = PadBytes(Dados)
        abOutput = EncriptarBytesRawCBC(abOutput, abInitV)

        Return abOutput
    End Function

    Public Function DecriptarBytesCBC(ByRef Dados() As Byte, ByRef abInitV() As Byte) As Byte()

        Dim abOutput() As Byte

        abOutput = DecriptarBytesRawCBC(Dados, abInitV)
        abOutput = UnpadBytes(abOutput)

        Return abOutput
    End Function

    Public Sub New()
        bf = New Blowfish
    End Sub

    Protected Overrides Sub Finalize()
        bf = Nothing
        MyBase.Finalize()
    End Sub
End Class
