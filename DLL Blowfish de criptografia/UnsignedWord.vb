Option Explicit On 
Public Class UnsignedWord

    ' basUnsignedWord: Utilities for unsigned word arithmetic

    ' Version 6. November 2003. Unchanged from Version 5.
    ' Version 5. January 2002. Replaced uw_WordSplit and uw_WordJoin
    ' with more efficient uwSplit and uwJoin.
    ' Version 4. 12 May 2001. Mods to speed up.
    ' Thanks to Doug J Ward for advice and suggestions.
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

    Private Const OFFSET_4 As Double = 4294967296.0#
    Private Const MAXINT_4 As Double = 2147483647

    Public Function Junta(ByRef a As Byte, ByRef b As Byte, ByRef C As Byte, ByRef d As Byte) As Integer
        ' Added Version 5: replacement for uw_WordJoin
        ' Join 4 x 8-bit bytes into one 32-bit word a.b.c.d
        Junta = (CShort(a And &H7FS) * &H1000000) Or (b * &H10000) Or (CInt(C) * &H100S) Or d
        If CBool(a And &H80S) Then
            Return Junta Or &H80000000
        End If
    End Function

    Public Sub Separa(ByVal w As Integer, ByRef a As Byte, ByRef b As Byte, ByRef C As Byte, ByRef d As Byte)
        ' Added Version 5: replacement for uw_WordSplit
        ' Split 32-bit word w into 4 x 8-bit bytes
        a = CByte(((w And &HFF000000) \ &H1000000) And &HFFS)
        b = CByte(((w And &HFF0000) \ &H10000) And &HFFS)
        C = CByte(((w And &HFF00S) \ &H100S) And &HFFS)
        d = CByte((w And &HFFS) And &HFFS)
    End Sub

    ' Function re-written 11 May 2001.
    Public Function uw_ShiftLeftBy8(ByRef wordX As Integer) As Integer
        ' Shift 32-bit long value to left by 8 bits
        ' i.e. VB equivalent of "wordX << 8" in C
        ' Avoiding problem with sign bit
        uw_ShiftLeftBy8 = (wordX And &H7FFFFF) * &H100S
        If (wordX And &H800000) <> 0 Then
            uw_ShiftLeftBy8 = uw_ShiftLeftBy8 Or &H80000000
        End If
    End Function

    Public Function uw_WordAdd(ByRef wordA As Integer, ByRef wordB As Integer) As Integer
        ' Adds words A and B avoiding overflow
        Dim myUnsigned As Double

        myUnsigned = LongParaUnsigned(wordA) + LongParaUnsigned(wordB)
        ' Cope with overflow
        If myUnsigned > OFFSET_4 Then
            myUnsigned = myUnsigned - OFFSET_4
        End If
        uw_WordAdd = UnsignedParaLong(myUnsigned)

    End Function

    Public Function uw_WordSub(ByRef wordA As Integer, ByRef wordB As Integer) As Integer
        ' Subtract words A and B avoiding underflow
        Dim myUnsigned As Double

        myUnsigned = LongParaUnsigned(wordA) - LongParaUnsigned(wordB)
        ' Cope with underflow
        If myUnsigned < 0 Then
            myUnsigned = myUnsigned + OFFSET_4
        End If
        uw_WordSub = UnsignedParaLong(myUnsigned)
    End Function

    '****************************************************
    ' These two functions from Microsoft Article Q189323
    ' "HOWTO: convert between Signed and Unsigned Numbers"

    Function UnsignedParaLong(ByRef Valor As Double) As Integer
        If Valor < 0 Or Valor >= OFFSET_4 Then Error (6) ' Overflow
        If Valor <= MAXINT_4 Then
            Return CInt(Valor)
        Else
            Return CInt(Valor - OFFSET_4)
        End If
    End Function

    Public Function LongParaUnsigned(ByRef Valor As Integer) As Double
        If Valor < 0 Then
            Return Valor + OFFSET_4
        Else
            Return Valor
        End If
    End Function

    ' End of Microsoft-article functions
    '****************************************************
End Class