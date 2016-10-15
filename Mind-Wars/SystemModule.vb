﻿Module SystemModule
    Public holes As Integer = 4 'Leave blank; for testing purposes
    Public colours As Integer = 8 'Leave blank; for testing purposes
    Public tries As Integer
    Public solution() As Integer
    Public guess() As Integer
    Public CurrentBW(1) As Integer

    Public Sub GameSetup(ByVal h As Integer, ByVal c As Integer, ByVal t As Integer)
        holes = h
        colours = c
        tries = t
    End Sub

    Public Sub InitializeGameMode(ByVal GameMode As Integer)
        Select Case GameMode
            Case 1 'PvE
                PvEGame.InitializeBackgroundWorker.RunWorkerAsync()
        End Select
    End Sub

    Public Function IntToArr(ByVal int As Integer)
        Dim str As String = int
        Dim arr(str.Length - 1) As Integer
        Dim l As Integer = str.Length - 1
        For i As Integer = 0 To l
            arr(i) = str.Chars(i).ToString
        Next
        Return arr
    End Function

    Public Function ArrayToInt(ByVal array() As Integer)
        Dim int As Integer
        Dim l As Integer = array.Length - 1
        For i As Integer = 0 To l
            int += array(i) * 10 ^ (l - i)
        Next
        Return int
    End Function

    Public Function CheckArrRange(ByVal int As Integer, ByVal min As Integer, ByVal max As Integer)
        Dim InRange As Boolean = True
        Dim digits() As Integer = IntToArr(int)
        Dim l As Integer = digits.Length - 1
        For m As Integer = 0 To l
            If digits(m) < min OrElse digits(m) > max Then
                InRange = False
            End If
        Next
        Return InRange
    End Function

End Module
