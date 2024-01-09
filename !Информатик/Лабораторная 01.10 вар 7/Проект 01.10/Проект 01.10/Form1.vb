Imports System.IO
Public Class Frm1

    Function vvod(ByVal T As TextBox) As String
        Return T.Text
    End Function

    Sub vvodfile(ByVal filename As String,
             ByRef Str As String, ByRef T As TextBox)
        Try
            Str = My.Computer.FileSystem.ReadAllText(filename)
            T.Text = Str
        Catch ex As Exception
            MsgBox("Ошибка при чтении файла")
        End Try
    End Sub

    Sub writefile(ByVal filename As String, ByVal p As String)
        If File.Exists(filename) = False Then
            MsgBox("Файл " & filename & " не существует")
        End If
        Dim rezf As New StreamWriter(filename)
        rezf.WriteLine(p)
        rezf.Flush()
        rezf.Close()
    End Sub

    Sub osnproc(ByVal s As String, ByVal fam As String,
                ByRef rez As String)
        Dim i, j As Integer, b, b1 As Char
        For i = 0 To fam.Length - 1
            b = fam.Substring(i, 1)
            For j = 0 To s.Length - 1
                b1 = s.Substring(j, 1)
                If b = b1 Then Exit For
            Next j
            If b <> b1 Then rez = "нельзя" : Exit Sub
        Next i
        rez = "можно"
    End Sub

    Sub globproc(ByVal ishf As String, ByVal fam As String,
                ByRef rezf As String)
        Dim i As Integer, t, ish() As String
        ish = ishf.Split(vbCrLf)
        For i = 0 To UBound(ish)
            t = ""
            osnproc(ish(i), fam, t)
            If t = "можно" Then rezf = rezf + ish(i) + vbCrLf
        Next i
    End Sub

    Private Sub Btn1_Click(sender As Object, e _
                           As EventArgs) Handles Btn1.Click
        Dim fl1 As String = vvod(Txt1), str As String = ""
        vvodfile(fl1, str, Txt4)
    End Sub

    Private Sub Btn2_Click(sender As Object, e _
                           As EventArgs) Handles Btn2.Click
        Dim fl1 As String = vvod(Txt1), fl2 As String = vvod(Txt2)
        Dim fam As String = vvod(Txt3) : fam.ToLower()
        Dim ishf As String = "", rezf As String = ""
        vvodfile(fl1, ishf, Txt4)
        globproc(ishf, fam, rezf)
        writefile(fl2, rezf)
        vvodfile(fl2, rezf, Txt5)
    End Sub

    Private Sub Btn3_Click(sender As Object, e _
                           As EventArgs) Handles Btn3.Click
        End
    End Sub
End Class
