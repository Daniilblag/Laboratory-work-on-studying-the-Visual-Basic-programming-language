Option Strict On
Imports System.Math
Public Class Form1
    Function func1(ByVal x As Double) As Double
        Return 4 * (x * 2 + 1) * Log(x) - 1
    End Function

    Function func2(ByVal x As Double) As Double
        Return 8 * Log(x) + 1 / x * (8 * x + 4)
    End Function

    Function func3(ByVal x As Double) As Double
        Return 16 / x - 1 / x ^ 2 * (8 * x + 4)
    End Function

    Sub niuton(ByVal a As Double, ByVal b As Double, ByVal ex As Double)
        Dim n As Integer = 0, xn, m1 As Double
        Dim x As Double = a
        m1 = func2(a)
        If func1(a) * func3(a) < 0 Then x = b
        If func2(b) < m1 Then m1 = func2(b)
        xn = x
        Do
            n = n + 1
            x = xn
            xn = x - func1(x) / func2(x)
            Txt4.Text = Txt4.Text + vbCrLf + String.Format("{0,0}", n) +
            String.Format("{0,10:F6}", xn) + String.Format("{0,14:F10}", func1(xn))
        Loop Until abs(xn - x) < ex
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Txt4.Text = "n" + Space(6) + "E" + Space(9) + "f(E)" + Space(4)
        Dim a, b, ex As Double
        a = CDbl(Txt1.Text) : b = CDbl(Txt2.Text)
        ex = CDbl(Txt3.Text)
        niuton(a, b, ex)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Txt1.Text = "" : Txt2.Text = ""
        Txt3.Text = "" : Txt4.Text = ""
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        End
    End Sub
End Class
