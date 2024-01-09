Imports System.Math
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button1.Click
        Dim x, y, b, j, n As Double, p As Single, i As Integer
        Dim s1, s2 As String
        x = TextBox1.Text
        y = TextBox2.Text
        If Log((1 - x) ^ 2) = 0 Then
            MsgBox("Вывод невозможен")
        Else
            b = (Log10(x) - Sin(x * y) ^ 2) / (0.8 * Log((1 - x) ^ 2))
        End If
        p = b
        i = b
        j = Fix(b)
        n = Int(b)
        s1 = b
        s2 = p
        TextBox3.Text = b
        TextBox4.Text = i
        TextBox5.Text = j
        TextBox6.Text = n
        TextBox7.Text = p
        TextBox8.Text = b + p
        TextBox9.Text = s1 + s2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button2.Click
        End
    End Sub

End Class
