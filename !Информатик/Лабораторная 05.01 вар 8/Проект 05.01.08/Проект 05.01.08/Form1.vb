Option Strict On
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Проверка списков:
        If TextBox1.Text = "" Then MsgBox("Список комнат пуст") : Exit Sub
        If TextBox2.Text = "" Then MsgBox("Список фамилии пуст") : Exit Sub
        If TextBox3.Text = "" Then MsgBox("Список блюд пуст") : Exit Sub
        If TextBox4.Text = "" Then MsgBox("Количество проживающих не указанно") : Exit Sub
        Dim n As Integer = CInt(TextBox4.Text) - 1 'кол-во проживающих
        ReDim nomer(n), fam(n), bludo(n)
        vvodstxt(TextBox1, nomer, TextBox2, fam, TextBox3, bludo)
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
