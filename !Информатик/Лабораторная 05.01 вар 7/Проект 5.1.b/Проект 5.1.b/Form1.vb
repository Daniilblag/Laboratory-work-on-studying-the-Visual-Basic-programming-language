Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        def(svr)
        n = CInt(InputBox("Введите количество заказчиков"))
        ReDim zak(n - 1), kol(n - 1, 5)
        vvodsklav(n, zak, kol)
        vivodmas(zak, Txt1)
        vivoddvmas(n, kol, Txt2)
        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = True
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        def(svr)
        vvodstxt(n, Txt1, Txt2, zak, kol)
        'izm(zak)
        vivodmas(zak, Txt1)
        vivoddvmas(n, kol, Txt2)
        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = True
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        End
    End Sub
End Class
