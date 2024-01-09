Option Strict On
Imports System.Math
Public Class Form1

    Function f(ByVal x As Double, ByVal y As Double) As Double
        Return y * Cos(x)
    End Function

    Function r(ByVal x As Double, ByVal y As Double, ByVal h As Double, ByVal m As Double) As Double
        For j = 1 To m
            y = y + h / 6 * (f(x, y) + 2 * f(x + h / 2, y + h * f(x, y) / 2) _
                + 2 * f(x + h / 2, y + h * f(x + h / 2, y + h * f(x, y) / 2) / 2) _
                + f(x + h, y + h * f(x + h / 2, y + h * f(x + h / 2, y + h * f(x, y) / 2) / 2)))
            x = x + h
        Next j
        Return y
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x0 As Double = CDbl(TextBox2.Text), y0 As Double = CDbl(TextBox3.Text)
        Dim h0 As Double = CDbl(TextBox4.Text), Ex As Double = CDbl(TextBox5.Text)
        Dim b As Double = CDbl(TextBox6.Text), n, i As Integer
        Dim x, y, y1, h, m As Double
        n = CInt(Fix((b - x0) / h0) + 1)
        TextBox7.Text = "x0" + Space(5) + "y0" + Space(7) + "h" + Space(4) + "m" + vbCrLf
        TextBox7.Text = TextBox7.Text + String.Format("{0,0:F1}", x0) _
            + String.Format("{0,10:F6}", y0) + String.Format("{0,7:F3}", h0) + Space(3) + vbCrLf
        For i = 1 To n
            h = h0 : m = 1 : y = r(x0, y0, h, m)
            Do
                y1 = y : h = h / 2 : x = x0 : y = y0 : m = 2 * m
                y = r(x, y, h, m)
            Loop Until Abs(y - y1) < Ex
            x0 = x0 + h0 : y0 = y
            TextBox7.Text = TextBox7.Text + String.Format("{0,0:F1}", x0) _
                + String.Format("{0,10:F6}", y0) + String.Format("{0,7:F3}", h) _
                + String.Format("{0,3}", m) + vbCrLf
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = ""
        TextBox5.Text = "" : TextBox6.Text = "" : TextBox7.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
