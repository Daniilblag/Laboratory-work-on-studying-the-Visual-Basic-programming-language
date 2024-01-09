Public Class Frm1

    Function vvod(ByVal T As TextBox) As String
        Return T.Text
    End Function

    Sub vivod(ByVal s As String, ByRef tb As TextBox)
        tb.Text = s
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

    Private Sub Btn1_Click(sender As Object, e _
                           As EventArgs) Handles Btn1.Click
        Dim s, fam, rez, osn As String
        s = vvod(Txt1) : fam = vvod(Txt2) : rez = ""
        osnproc(s, fam, rez)
        osn = "Из данных символов  составить фамилию"
        osn = osn.Insert(19, rez)
        vivod(osn, Txt3)
    End Sub

    Private Sub Btn2_Click(sender As Object, e _
                           As EventArgs) Handles Btn2.Click
        Txt1.Text = "" : Txt2.Text = "" : Txt3.Text = ""
    End Sub

    Private Sub Btn3_Click(sender As Object, e _
                           As EventArgs) Handles Btn3.Click
        End
    End Sub
End Class
