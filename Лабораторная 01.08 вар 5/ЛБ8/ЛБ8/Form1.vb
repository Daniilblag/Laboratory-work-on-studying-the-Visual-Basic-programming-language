Option Strict On
Imports System.Math
Public Class Form1

    Function f(ByVal x As Double, ByVal y As Double, ByVal alf As Double) As Double
        Return 2 * (x - alf * (4 * x + 2)) ^ 2 + 3 * (y - alf * (6 * y - 3)) ^ 2 _
            + 2 * (x - alf * (4 * x + 2)) - 3 * (y - alf * (6 * y - 3))
    End Function

    Function nc(ByVal x As Double, ByVal y As Double, ByVal a As Double,
                ByVal b As Double, ByVal ex As Double) As Double
        Dim alf, k1, k2, f1, f2, alf1, alf2 As Double
        k1 = (3 - Sqrt(5)) / 2 : k2 = (Sqrt(5) - 1) / 2
        alf1 = a + k1 * (b - a) : alf2 = a + k2 * (b - a)
        f1 = f(x, y, alf1) : f2 = f(x, y, alf2)
        Do
            If f1 < f2 Then
                b = alf2 : alf2 = alf1 : f2 = f1
                alf1 = a + k1 * (b - a)
                f1 = f(x, y, alf1)
            Else
                a = alf1 : alf1 = alf2 : f1 = f2
                alf2 = a + k2 * (b - a)
                f2 = f(x, y, alf2)
            End If
        Loop Until (b - a) < ex
        alf = (a + b) / 2
        Return alf
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, ex, x, y, alf, g1, g2, fxy As Double, k As Integer
        a = 0 : b = 1 : ex = CDbl(TextBox4.Text) : k = 1
        x = CDbl(TextBox2.Text) : y = CDbl(TextBox3.Text)
        TextBox6.Text = "n" + Space(8) + "x" + Space(11) + "y" + Space(10) + "alf" + Space(9) + "g1" _
            + Space(10) + "g2" + Space(8) + "f(x, y)" + Space(1) + vbCrLf
        Do
            alf = nc(x, y, a, b, ex)
            g1 = 4 * x + 2 : g2 = 6 * y - 3
            fxy = 2 * x ^ 2 + 3 * y ^ 2 + 2 * x - 3 * y
            TextBox6.Text = TextBox6.Text + String.Format("{0,0}", k) _
                + String.Format("{0,12:F6}", x) + String.Format("{0,12:F6}", y) _
                + String.Format("{0,12:F6}", alf) + String.Format("{0,12:F6}", g1) _
                + String.Format("{0,12:F6}", g2) + String.Format("{0,12:F6}", fxy) + vbCrLf
            x = x - alf * (g1) : y = y - alf * (g2) : k = k + 1
        Loop Until Abs(g1) <= ex And Abs(g2) <= ex
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "" : TextBox3.Text = ""
        TextBox4.Text = "" : TextBox6.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
