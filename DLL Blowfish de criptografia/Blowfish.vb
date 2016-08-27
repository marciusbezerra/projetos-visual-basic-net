Option Explicit On 
Public Class Blowfish

    ' basBlowfish: Bruce Schneier's Blowfish algorithm in VB
    ' Core routines.

    ' Version 6. November 2003. Removed redundant functions blf_Enc()
    ' and blf_Dec().
    ' Version 5: January 2002. Speed improvements.
    ' Version 4: 12 May 2001. Fixed maxkeylen size from bits to bytes.
    ' First published October 2000.
    '************************* COPYRIGHT NOTICE*************************
    ' This code was originally written in Visual Basic by David Ireland
    ' and is copyright (c) 2000-2 D.I. Management Services Pty Limited,
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

    Private Const ncROUNDS As Short = 16
    Private Const ncMAXKEYLEN As Short = 56
    Private uw As UnsignedWord

    Private Function blf_F(ByRef x As Integer) As Integer
        Dim C, a, b, d As Byte
        Dim y As Integer

        Call uw.Separa(x, a, b, C, d)

        y = uw.uw_WordAdd(blf_S(0, a), blf_S(1, b))
        y = y Xor blf_S(2, C)
        y = uw.uw_WordAdd(y, blf_S(3, d))
        blf_F = y

    End Function

    Public Sub EncriptarBloco(ByRef xL As Integer, ByRef xR As Integer)
        Dim i As Short
        Dim temp As Integer

        For i = 0 To ncROUNDS - 1
            xL = xL Xor blf_P(i)
            xR = blf_F(xL) Xor xR
            temp = xL
            xL = xR
            xR = temp
        Next

        temp = xL
        xL = xR
        xR = temp

        xR = xR Xor blf_P(ncROUNDS)
        xL = xL Xor blf_P(ncROUNDS + 1)

    End Sub

    Public Sub DecriptarBloco(ByRef xL As Integer, ByRef xR As Integer)
        Dim i As Short
        Dim temp As Integer

        For i = ncROUNDS + 1 To 2 Step -1
            xL = xL Xor blf_P(i)
            xR = blf_F(xL) Xor xR
            temp = xL
            xL = xR
            xR = temp
        Next

        temp = xL
        xL = xR
        xR = temp

        xR = xR Xor blf_P(1)
        xL = xL Xor blf_P(0)

    End Sub

    Public Sub Inicializar(ByRef Chave() As Byte, ByRef ChaveBytes As Integer)
        Dim j, i, K As Integer
        Dim wDataL, wData, wDataR As Integer

        blf_LoadArrays()

        j = 0
        For i = 0 To (ncROUNDS + 2 - 1)
            wData = &H0S
            For K = 0 To 3
                wData = uw.uw_ShiftLeftBy8(wData) Or Chave(j)
                j = j + 1
                If j >= ChaveBytes Then j = 0
            Next K
            blf_P(i) = blf_P(i) Xor wData
        Next i

        wDataL = &H0S
        wDataR = &H0S

        For i = 0 To (ncROUNDS + 2 - 1) Step 2
            Call EncriptarBloco(wDataL, wDataR)

            blf_P(i) = wDataL
            blf_P(i + 1) = wDataR
        Next i

        For i = 0 To 3
            For j = 0 To 255 Step 2
                Call EncriptarBloco(wDataL, wDataR)

                blf_S(i, j) = wDataL
                blf_S(i, j + 1) = wDataR
            Next j
        Next i

    End Sub

    Public Function Chave(ByRef aChave() As Byte, ByRef TamanhoChave As Integer) As Boolean
        Chave = False
        If TamanhoChave < 0 Or TamanhoChave > ncMAXKEYLEN Then
            Exit Function
        End If

        Call Inicializar(aChave, TamanhoChave)

        Return True
    End Function

    Public Function InicializaChave(ByRef Chave() As Byte) As Boolean

        Dim nKeyLen As Integer

        InicializaChave = False

        On Error GoTo ArrayIsEmpty

        nKeyLen = UBound(Chave) - LBound(Chave) + 1
        If nKeyLen < 0 Or nKeyLen > ncMAXKEYLEN Then
            Exit Function
        End If

        Call Inicializar(Chave, nKeyLen)

        Return True

ArrayIsEmpty:

    End Function

    Public Sub EncriptarBytes(ByRef aBytes() As Byte)
        Dim wordL, wordR As Integer

        wordL = uw.Junta(aBytes(0), aBytes(1), aBytes(2), aBytes(3))
        wordR = uw.Junta(aBytes(4), aBytes(5), aBytes(6), aBytes(7))

        Call EncriptarBloco(wordL, wordR)

        Call uw.Separa(wordL, aBytes(0), aBytes(1), aBytes(2), aBytes(3))
        Call uw.Separa(wordR, aBytes(4), aBytes(5), aBytes(6), aBytes(7))

    End Sub

    Public Sub DecriptarBytes(ByRef aBytes() As Byte)

        Dim wordL, wordR As Integer

        wordL = uw.Junta(aBytes(0), aBytes(1), aBytes(2), aBytes(3))
        wordR = uw.Junta(aBytes(4), aBytes(5), aBytes(6), aBytes(7))

        Call DecriptarBloco(wordL, wordR)

        Call uw.Separa(wordL, aBytes(0), aBytes(1), aBytes(2), aBytes(3))
        Call uw.Separa(wordR, aBytes(4), aBytes(5), aBytes(6), aBytes(7))

    End Sub

    Public Sub New()
        uw = New UnsignedWord
    End Sub

    Protected Overrides Sub Finalize()
        uw = Nothing
        MyBase.Finalize()
    End Sub
End Class
