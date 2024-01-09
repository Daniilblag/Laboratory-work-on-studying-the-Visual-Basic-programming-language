Option Strict On
Imports System.Math
Public Class Form1
    Dim x As Double, y As Double, b As Double
    Sub proc2()
        If Log((1 - x) ^ 2) = 0 Then MsgBox("Вывод невозможен") Else _
            b = (Log10(x) - Sin(x * y) ^ 2) / (0.8 * Log((1 - x) ^ 2))
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button1.Click
        Dim j, n As Double, p As Single, i As Integer
        Dim s1, s2 As String
        x = CDbl(TextBox1.Text)
        y = CDbl(TextBox2.Text)
        proc2()
        p = CSng(b)
        i = CInt(b)
        j = Fix(b)
        n = Int(b)
        s1 = CStr(b)
        s2 = CStr(p)
        TextBox3.Text = CStr(b)
        TextBox4.Text = CStr(i)
        TextBox5.Text = CStr(j)
        TextBox6.Text = CStr(n)
        TextBox7.Text = CStr(p)
        TextBox8.Text = CStr(b + p)
        TextBox9.Text = s1 + s2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class

