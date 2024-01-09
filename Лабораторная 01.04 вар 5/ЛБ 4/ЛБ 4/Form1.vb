Option Strict On
Imports System.Math
Public Class Form1
    Function f(ByRef x As Double) As Double
        Return Cos(2 * x) + 2 * Sin(x)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, Ex, h, s, s1 As Double, i, n As Integer
        a = CDbl(TextBox2.Text) : b = CDbl(TextBox3.Text) : Ex = CDbl(TextBox4.Text)
        n = 1 : h = (b - a) : s = (f(a) + f(b)) * h / 2
        TextBox5.Text = "h" + Space(8) + "n" + Space(8) + "s1" + Space(14) + "s" + Space(5) + vbCrLf
        Do
            n = 2 * n : h = (b - a) / n : s1 = s : s = f(a) + f(b)
            For i = 1 To n - 1
                s = s + 2 * f(a + i * h)
            Next i
            s = s * h / 2
            TextBox5.Text = TextBox5.Text + String.Format("{0,0}", h) + String.Format("{0,7}", n) _
                + String.Format("{0,15:F9}", s1) + String.Format("{0,15:F9}", s) + vbCrLf
        Loop Until abs(s - s1) / 3 < Ex
        TextBox6.Text = CStr(s)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "" : TextBox3.Text = ""
        TextBox4.Text = "" : TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
