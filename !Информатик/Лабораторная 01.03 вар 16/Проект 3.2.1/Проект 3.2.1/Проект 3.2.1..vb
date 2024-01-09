Option Strict On
Imports System.Math
Public Class Form1
    Function vvod(ByVal T As TextBox) As Double
        Return CSng(Val(T.Text))
    End Function
    Sub vivod(ByVal Z As Double, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub
    Sub TriL(ByVal a As Double, ByVal b As Double, ByVal c As Double, _
             ByRef LA As Double, ByRef LB As Double, ByRef LC As Double)
        Dim p As Double
        If a + b > c And a + c > b And b + c > a And a > 0 And b > 0 And c > 0 Then
            p = (a + b + c) / 2
        Else
            MsgBox("Треугольник не существует")
        End If
        LA = 2 * Atan(Sqrt(((p - b) * (p - c)) / (p * (p - a)))) * 180 / PI
        LB = 2 * Atan(Sqrt(((p - a) * (p - c)) / (p * (p - b)))) * 180 / PI
        LC = 2 * Atan(Sqrt(((p - a) * (p - b)) / (p * (p - c)))) * 180 / PI
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button1.Click
        Dim A, B, C, La, Lb, Lc As Double
        A = vvod(TextBox1)
        B = vvod(TextBox2)
        C = vvod(TextBox3)
        TriL(A, B, C, La, Lb, Lc)
        vivod(La, TextBox4)
        vivod(Lb, TextBox5)
        vivod(Lc, TextBox6)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
