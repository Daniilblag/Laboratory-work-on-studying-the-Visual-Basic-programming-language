Module Module1
    Public sp60() As String
    Public sd() As String
    Public sbksd(,) As String

    Sub formsp(ByVal str As String, ByRef sp60() As String, ByRef sd() As String, ByRef sbksd(,) As String)
        Dim i, j, k As Integer, a(), b() As String
        Dim proverka As String = ""
        k = 0
        sp60 = str.Split(vbNewLine)
        For i = 0 To UBound(sp60)
            ReDim a(3)
            a = sp60(i).Split(",")
            If proverka.Contains(a(0)) = False Then
                sd(k) = a(0) + ":" + vbNewLine
                sd(k) = sd(k) + a(1) + "," + a(2) + "," + a(3) + vbNewLine
                sbksd(k, 0) = a(0) : sbksd(k, 1) = sbksd(k, 1) + 1
                If i = UBound(sp60) Then Exit For
                For j = i + 1 To UBound(sp60)
                    ReDim b(3)
                    b = sp60(j).Split(",")
                    If b(0) = a(0) Then
                        sbksd(k, 1) = sbksd(k, 1) + 1
                        sd(k) = sd(k) + b(1) + "," + b(2) + "," + b(3) + vbNewLine
                    End If
                    Erase b
                Next j
                proverka = proverka + a(0) + Space(1)
                k = k + 1
            End If
            Erase a
        Next i
        ReDim Preserve sd(k)
        vivodmas(sd, Form2.TextBox1)
    End Sub

    Sub maxmikro(ByRef sd() As String, ByRef sbksd(,) As String)
        Dim i, max As Integer, maxr, rez As String
        maxr = sbksd(0, 0) : max = sbksd(0, 1)
        For i = 1 To UBound(sbksd)
            If sbksd(i, 1) > max Then max = sbksd(i, 1) : maxr = sbksd(i, 0)
        Next i
        maxr = maxr + ":" : rez = ""
        For i = 0 To UBound(sd)
            If sd(i).Contains(maxr) = True Then rez = sd(i)
        Next i
        Form2.TextBox2.Text = "Количество сдании " + CStr(max) + vbNewLine + rez
    End Sub

    Function vvod(ByVal T As TextBox) As String
        Return T.Text
    End Function

    Public Sub vivodmas(ByVal a() As String, ByRef TB As TextBox)
        Dim i As Integer
        TB.Text = ""
        For i = 0 To UBound(a)
            TB.Text = TB.Text + a(i) + vbNewLine + vbNewLine
        Next
    End Sub

    Sub vvodfile(ByVal filename As String, ByRef Str As String, ByRef T As TextBox)
        Try
            Str = My.Computer.FileSystem.ReadAllText(filename)
            T.Text = Str
        Catch ex As Exception
            MsgBox("Ошибка при чтении файла")
        End Try
    End Sub

End Module
