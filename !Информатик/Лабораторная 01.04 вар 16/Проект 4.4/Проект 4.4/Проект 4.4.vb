Option Strict On
Imports System
Imports System.Globalization
Imports System.String
Imports System.Windows.Forms
Imports System.Math
Public Class Form1

    Private x1 As Integer
    Private x3 As Double
    Private nfi As NumberFormatInfo = NumberFormatInfo.CurrentInfo
    Private ds As Char = nfi.NumberDecimalSeparator

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, _
                                  ByVal e As KeyPressEventArgs) _
                              Handles TextBox1.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = TextBox1
        If Not Char.IsDigit(c) Then
            If c <> "-" Or t.Text.IndexOf("-") <> -1 Then
                If c <> ds Or t.Text.IndexOf(ds) <> -1 Then
                    If c <> Convert.ToChar(Keys.Back) Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
        If c = Convert.ToChar(Keys.D0) Or _
            c = Convert.ToChar(Keys.NumPad0) Then
            If t.Text.Length >= 1 Then
                If t.Text.Substring(0, 1) = "0" _
                    And t.SelectionStart < 2 Then
                    e.Handled = True
                End If
            End If
        End If
        If c = ds Then
            x1 = 0
            If t.Text <> "" AndAlso _
                t.Text.Substring(0, 1) = "-" Then x1 = 1
            If t.Text.IndexOf(ds) = -1 And _
                t.SelectionStart = x1 Then
                t.Text = t.Text.Insert(x1, "0")
                t.SelectionStart = x1 + 1
            End If
        End If
        If c = "-" And t.Text.IndexOf("-") = -1 Then
            t.SelectionStart = 0
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, _
                                  ByVal e As KeyPressEventArgs) _
                              Handles TextBox2.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = TextBox2
        If Not Char.IsDigit(c) Then
            If c <> "-" Or t.Text.IndexOf("-") <> -1 Then
                If c <> ds Or t.Text.IndexOf(ds) <> -1 Then
                    If c <> Convert.ToChar(Keys.Back) Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
        If c = Convert.ToChar(Keys.D0) Or _
            c = Convert.ToChar(Keys.NumPad0) Then
            If t.Text.Length >= 1 Then
                If t.Text.Substring(0, 1) = "0" _
                    And t.SelectionStart < 2 Then
                    e.Handled = True
                End If
            End If
        End If
        If c = ds Then
            x1 = 0
            If t.Text <> "" AndAlso _
                t.Text.Substring(0, 1) = "-" Then x1 = 1
            If t.Text.IndexOf(ds) = -1 And _
                t.SelectionStart = x1 Then
                t.Text = t.Text.Insert(x1, "0")
                t.SelectionStart = x1 + 1
            End If
        End If
        If c = "-" And t.Text.IndexOf("-") = -1 Then
            t.SelectionStart = 0
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, _
                                  ByVal e As KeyPressEventArgs) _
                              Handles TextBox3.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = TextBox3
        If Not Char.IsDigit(c) Then
            If c <> "-" Or t.Text.IndexOf("-") <> -1 Then
                If c <> ds Or t.Text.IndexOf(ds) <> -1 Then
                    If c <> Convert.ToChar(Keys.Back) Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
        If c = Convert.ToChar(Keys.D0) Or _
            c = Convert.ToChar(Keys.NumPad0) Then
            If t.Text.Length >= 1 Then
                If t.Text.Substring(0, 1) = "0" _
                    And t.SelectionStart < 2 Then
                    e.Handled = True
                End If
            End If
        End If
        If c = ds Then
            x1 = 0
            If t.Text <> "" AndAlso _
                t.Text.Substring(0, 1) = "-" Then x1 = 1
            If t.Text.IndexOf(ds) = -1 And _
                t.SelectionStart = x1 Then
                t.Text = t.Text.Insert(x1, "0")
                t.SelectionStart = x1 + 1
            End If
        End If
        If c = "-" And t.Text.IndexOf("-") = -1 Then
            t.SelectionStart = 0
        End If
    End Sub

    Function vvod(ByVal T As TextBox) As Double
        Return Val(T.Text)
    End Function

    Overloads Sub vivod(ByVal Z As Double, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    Overloads Sub vivod(ByVal Z As Integer, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    Sub Razv(ByVal x As Double, ByVal y As Double, ByVal a As Double, _
             ByRef t As Double, ByRef n As Integer)
        Dim t1, t2 As Double
        If x * y < 0 Then
            If a < 0 And Abs(a) > x ^ 2 Then _
                MsgBox("Данное сочетание входных переменных " + _
                       "не имеет решение, так как a<0 и Abs(a)>x^2")
            t1 = (1 - Sqrt(x ^ 2 + a)) * x
            t2 = (1 - Sqrt(x ^ 2 + a)) * y
            If t1 > t2 Then
                t = t1
            Else
                t = t2
            End If
            n = 1
        ElseIf x * y > 2 Then
            t1 = x ^ 2 : t2 = Sin(y) : t = Cos(a * y)
            If t1 < t Then
                t = t1
            End If
            If t2 < t Then
                t = t2
            End If
            n = 2
        Else
            If y = 0 Then MsgBox("Данное сочетание входных переменных не имеет решение, так как y=0")
            t = a ^ 2 + x / y
            n = 3
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button1.Click
        Dim x, y, a, t As Double
        Dim n As Integer
        x = vvod(TextBox1) : y = vvod(TextBox2) : a = vvod(TextBox3)
        Razv(x, y, a, t, n)
        vivod(t, TextBox4) : vivod(n, TextBox5)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As  _
                              System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class
