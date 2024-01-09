Option Strict On
Module Module1
    Sub osnproc(ByVal n As Integer, ByRef sotr As DataRowCollection, ByRef rez As String)
        Dim i, j, f As Integer, t As String
        f = 0
        rez = "Фамилия, год рождения, оклад" + vbNewLine
        For i = 0 To n - 1
            For j = i + 1 To n
                If CInt(sotr(i)(3)) < CInt(sotr(j)(3)) Then
                    t = CStr(sotr(i)(2)) : sotr(i)(2) = sotr(j)(2) : sotr(j)(2) = t
                    t = CStr(sotr(i)(3)) : sotr(i)(3) = sotr(j)(3) : sotr(j)(3) = t
                    t = CStr(sotr(i)(4)) : sotr(i)(4) = sotr(j)(4) : sotr(j)(4) = t
                End If
            Next j
        Next i
        For i = 0 To n
            If CInt(sotr(i)(2)) > 1990 And f < 3 Then
                f = f + 1
                rez = rez + CStr(sotr(i)(4)) + ", " +
                    CStr(sotr(i)(2)) + ", " + CStr(sotr(i)(3)) + " рублей" + vbNewLine
            End If
        Next i
    End Sub

    Sub vivod(ByVal z As String, ByVal T As TextBox)
        T.Text = z
    End Sub
End Module
