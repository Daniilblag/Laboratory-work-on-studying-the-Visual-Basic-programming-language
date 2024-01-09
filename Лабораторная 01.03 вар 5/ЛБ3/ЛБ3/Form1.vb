Option Strict On
Imports System.Math
Public Class Form1

    Function LX(ByVal k As Integer, ByRef x() As String, ByRef y() As String, ByVal xl As Double) As Double
        Dim L As Double = 0, l1 As Double
        For i = 0 To k
            l1 = 1
            For j = 0 To k
                If i <> j Then l1 = (xl - CDbl(x(j))) / (CDbl(x(i)) - CDbl(x(j))) * l1
            Next j
            L = L + l1 * CDbl(y(i))
        Next i
        Return L
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xl As Double = CDbl(TextBox1.Text)
        Dim n As Integer = CInt(TextBox2.Text) - 1
        Dim Et As Double = CDbl(TextBox3.Text)
        Dim LL, L(n + 1), A, E1 As Double, k As Integer, str, x(n), y(n) As String
        str = TextBox4.Text : x = Split(str, " ")
        str = TextBox5.Text : y = Split(str, " ")
        k = 1 : LL = LX(k, x, y, xl) : L(k) = LL
        TextBox6.Text = CStr(L(k)) + vbCrLf
        Do
            A = LL : k = k + 1
            LL = LX(k, x, y, xl) : L(k) = LL
            E1 = Abs(LL - A)
            TextBox6.Text = TextBox6.Text + CStr(L(k)) + vbCrLf
        Loop While E1 > Et And k < n
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
