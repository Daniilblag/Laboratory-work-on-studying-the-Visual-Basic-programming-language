Option Strict On
Imports System.Math
Public Class Form1

    Function f(ByVal x As Double) As Double
        Return -2 * (1 + x) * Exp(-x) - 2 * Cos(x)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, ex, d, x1, x2, n As Double
        a = CDbl(TextBox2.Text) : b = CDbl(TextBox3.Text)
        ex = CDbl(TextBox4.Text) : d = CDbl(TextBox5.Text)
        n = 0
        TextBox6.Text = "n" + Space(6) + "a" + Space(9) + "b" + Space(8) + "x1" + Space(8) + "x2" _
            + Space(6) + "f(x1)" + Space(5) + "f(x2)" + Space(7) + "e" + Space(4) + vbCrLf
        Do
            x1 = (a + b - d) / 2 : x2 = (a + b + d) / 2
            n = n + 1
            TextBox6.Text = TextBox6.Text + String.Format("{0,0}", n) _
                + String.Format("{0,10:F6}", a) + String.Format("{0,10:F6}", b) _
                + String.Format("{0,10:F6}", x1) + String.Format("{0,10:F6}", x2) _
                + String.Format("{0,10:F6}", f(x1)) + String.Format("{0,10:F6}", f(x2)) _
                + String.Format("{0,10:F6}", b - a) + vbCrLf
            If f(x1) > f(x2) Then
                a = x1
            Else
                b = x2
            End If
        Loop Until (b - a) <= ex
        TextBox7.Text = CStr((a + b) / 2)
        TextBox8.Text = CStr(f((a + b) / 2))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "" : TextBox3.Text = "" : TextBox7.Text = "" : TextBox8.Text = ""
        TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
