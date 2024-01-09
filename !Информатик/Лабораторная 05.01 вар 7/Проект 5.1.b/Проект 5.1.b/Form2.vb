Public Class Form2
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim l As Integer
        'ReDim unzak(UBound(zak)), unkol(UBound(zak), 5)
        'unic(zak, kol, unzak, unkol)
        ReDim sum(UBound(zak))
        sort(zak, kol, sum)
        l = zak.Length
        vivodmas(zak, Txt1)
        vivoddvmas(l, kol, Txt2)
        vivodinmas(sum, Txt3)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Form1.Txt1.Text = ""
        Form1.Txt2.Text = ""
        Form1.Btn1.Enabled = True
        Form1.Btn2.Enabled = True
        Form1.Btn3.Enabled = False
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        End
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class