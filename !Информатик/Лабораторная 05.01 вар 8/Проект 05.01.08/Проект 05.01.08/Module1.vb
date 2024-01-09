Module Module1
    Public nomer() As String 'Массив номеров
    Public fam() As String 'Массив фамилии
    Public bludo() As String 'Массив блюд
    Public spblud() As String 'Массив для списка блюд
    Public popbludo(,) As String 'Массив для попул. блюда
    'Процедура формирования списка блюд и вывода в текстбокс1
    Sub spisokblud(ByVal n As Integer, ByRef nomer() As String,
                   ByRef fam() As String, ByRef bludo() As String,
                   ByRef spblud() As String, ByRef popbludo(,) As String)
        Dim i, j, k As Integer, proverka As String
        k = 0 : proverka = "" 'proverka служит для нахождния уникал. блюда
        For i = 0 To n
            If proverka.Contains(bludo(i)) Then Exit For 'Проверяет есть ли уже в массиве i-ое блюдо 
            proverka = proverka + bludo(i) + Space(1)
            spblud(k) = bludo(i) + ":" + vbNewLine
            spblud(k) = spblud(k) + fam(i) + ", номер " + nomer(i) + vbNewLine
            popbludo(k, 0) = bludo(i) + ":"
            popbludo(k, 1) = popbludo(k, 1) + 1
            For j = i + 1 To n
                If bludo(i) = bludo(j) Then
                    spblud(k) = spblud(k) + fam(j) + ", номер " + nomer(j) + vbNewLine
                    popbludo(k, 1) = popbludo(k, 1) + 1
                End If
            Next j
            k = k + 1
        Next i
        ReDim Preserve spblud(k)
        vivodmas(spblud, Form2.TextBox1)
    End Sub
    'Процедура для нахождения самого популярного блюда
    Sub populbludo(ByRef spblud() As String, ByRef popbludo(,) As String)
        Dim i, max As Integer, maxr, rez As String
        ReDim Preserve spblud(UBound(spblud) - 1)
        maxr = popbludo(0, 0) : max = popbludo(0, 1)
        For i = 1 To UBound(popbludo)
            If popbludo(i, 1) > max Then max = popbludo(i, 1) : maxr = popbludo(i, 0)
        Next i
        rez = ""
        For i = 0 To UBound(spblud)
            If spblud(i).Contains(maxr) = True Then rez = spblud(i)
        Next i
        Form2.TextBox2.Text = "Количество сдании " + CStr(max) + vbNewLine + rez
    End Sub
    'Процедура ввода с тексбокса в массивы
    Sub vvodstxt(ByVal T1 As TextBox, ByRef nomer() As String,
                 ByVal T2 As TextBox, ByRef fam() As String,
                 ByVal T3 As TextBox, ByRef bludo() As String)
        nomer = T1.Text.Split(vbNewLine)
        fam = T2.Text.Split(vbNewLine)
        bludo = T3.Text.Split(vbNewLine)
    End Sub
    'Процедура вывода массива в текстбокс
    Public Sub vivodmas(ByVal a() As String, ByRef TB As TextBox)
        Dim i As Integer
        TB.Text = ""
        For i = 0 To UBound(a)
            TB.Text = TB.Text + a(i) + vbNewLine + vbNewLine
        Next
    End Sub
End Module
