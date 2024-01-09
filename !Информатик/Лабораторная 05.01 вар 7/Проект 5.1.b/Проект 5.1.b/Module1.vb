Module Module1
    Public svr(5) As Integer ' Сумма вида работы
    Public n As Integer ' Количество заказчиков
    Public zak() As String ' Заказчик
    Public kol(,) As Integer ' Количество работ ведённое
    Public sum() As Integer ' Сумма
    Public unzak() As String
    Public unkol(,) As Integer

    Public Sub def(ByRef svr() As Integer)
        svr(0) = 6000 : svr(1) = 11000 : svr(2) = 5000
        svr(3) = 7000 : svr(4) = 5500 : svr(5) = 10000
    End Sub

    Public Sub unic(ByRef zak() As String, ByRef kol(,) As Integer,
                    ByRef unzak() As String, ByRef unkol(,) As Integer)
        Dim i, j, l, f, m As Integer
        Dim proverka As String = ""
        unzak(0) = zak(0) : m = 0
        For j = 0 To 5
            unkol(0, j) = kol(0, j)
        Next j
        For i = 0 To UBound(zak)
            f = 0
            For j = 0 To m
                If unzak(j) = zak(i) Then f = 1
            Next j
            If f = 0 Then
                m = m + 1
                unzak(m) = zak(i)
                For l = 0 To 5
                    unkol(m, l) = kol(i, l)
                Next l
            Else
                For l = 0 To 5
                    unkol(m, l) = unkol(m, l) + kol(i, l)
                Next l
            End If
        Next i
        ReDim Preserve unzak(m), unkol(m, 5)
    End Sub

    Public Sub sort(ByRef zak() As String, ByRef kol(,) As Integer,
                    ByRef sum() As Integer)
        Dim i, j, k, t, l As Integer, m As String
        For i = 0 To n - 1
            For j = 0 To 5
                sum(i) = sum(i) + svr(j) * kol(i, j)
            Next j
        Next i
        k = zak.Length - 1
        For i = 0 To k - 1
            For j = i + 1 To k
                If sum(i) < sum(j) Then
                    m = zak(i) : zak(i) = zak(j) : zak(j) = m
                    For l = 0 To 5
                        t = kol(i, l) : kol(i, l) = kol(j, l) : kol(j, l) = t
                    Next l
                    t = sum(i) : sum(i) = sum(j) : sum(j) = t
                End If
            Next j
        Next i
    End Sub

    Public Sub vvodsklav(ByVal n As Integer, ByRef zak() As String,
                         kol(,) As Integer)
        Dim i As Integer
        For i = 0 To n - 1
            zak(i) = InputBox("Заказчик")
            kol(i, 0) = CInt(InputBox("Количество демонтажных работ"))
            kol(i, 1) = CInt(InputBox("Количество строительных работ"))
            kol(i, 2) = CInt(InputBox("Количество столярных работ"))
            kol(i, 3) = CInt(InputBox("Количество штукатурных работ"))
            kol(i, 4) = CInt(InputBox("Количество молярных работ"))
            kol(i, 5) = CInt(InputBox("Количество плиточных работ"))
        Next i
    End Sub

    Public Sub vvodstxt(ByRef n As Integer, ByVal T1 As TextBox,
                        ByVal T2 As TextBox, ByRef zak() As String,
                        ByRef kol(,) As Integer)
        Dim i, j As Integer, s, f(), m() As String
        n = T1.Lines.Length
        ReDim zak(n - 1), kol(n - 1, 5)
        zak = T1.Text.Split(vbNewLine)
        s = T2.Text : f = s.Split(vbNewLine)
        For i = 0 To n - 1
            Do While f(i).IndexOf(Space(2)) >= 0
                f(i) = f(i).Replace(Space(2), Space(1))
            Loop
            f(i) = f(i).Trim
            m = f(i).Split(Space(1))
            For j = 0 To 5
                kol(i, j) = m(j)
            Next j
        Next i
    End Sub

    Public Sub izm(ByRef a() As String)
        Dim i As Integer
        For i = 0 To UBound(a)
            Do While a(i).IndexOf(Space(2))
                a(i) = a(i).Replace(Space(2), Space(1))
            Loop
            a(i) = a(i).Trim
        Next i
    End Sub

    Public Sub vivoddvmas(ByVal n As Integer, ByVal a(,) As Integer, ByRef TB As TextBox)
        Dim i, j As Integer
        TB.Text = ""
        For i = 0 To n - 1
            TB.Text = TB.Text + Space(2)
            For j = 0 To 5
                If a(i, j) Mod 10 = 0 Then
                    TB.Text = TB.Text + CStr(a(i, j)) + Space(5)
                Else
                    TB.Text = TB.Text + CStr(a(i, j)) + Space(4)
                End If
            Next j
            TB.Text = TB.Text + vbNewLine
        Next i
    End Sub

    Public Sub vivodmas(ByVal a() As String, ByRef TB As TextBox)
        Dim i As Integer
        TB.Text = ""
        For i = 0 To UBound(a)
            TB.Text = TB.Text + a(i) + vbNewLine + vbNewLine
        Next
    End Sub

    Public Sub vivodinmas(ByVal a() As Integer, ByRef TB As TextBox)
        Dim i As Integer
        TB.Text = ""
        For i = 0 To UBound(a)
            TB.Text = TB.Text + CStr(a(i)) + vbNewLine + vbNewLine
        Next
    End Sub

End Module
