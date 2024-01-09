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
          ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
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
      ByVal e As KeyPressEventArgs) Handles TextBox2.KeyPress
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
      ByVal e As KeyPressEventArgs) Handles TextBox3.KeyPress
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
        Return CDbl(T.Text)
    End Function

    Sub vivod(ByVal Z As Double, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    Sub vivodtextbox(ByVal X As Double, ByVal Y As Double, _
                     ByVal LB As TextBox)
        Dim fs As String = String.Format("{0,0:F1}", X) + _
            String.Format("{0,18:F5}", Y)
        LB.Text = LB.Text + fs + vbCrLf
    End Sub

    Public Function Fun(ByVal x As Double) As Double
        Return x ^ 5 + 5 * x ^ 4 - 2 * x ^ 3 - 4 * x ^ 2 + 7 * x - 3
    End Function

    Public Sub Cikl(ByVal a As Double, ByVal b As Double, _
                    ByVal h As Double, ByRef p As Double)
        Dim i, n As Integer, x, y As Double
        If h = 0 Then
            MsgBox("Значение 'Шаг' не может равняться нулю", _
                   MsgBoxStyle.Critical)
        Else
            n = CInt((b - a) / h) + 1
            x = a : p = 1
            For i = 1 To n
                y = Fun(x)
                If y > 0 Then p = p * y
                vivodtextbox(x, y, TextBox5)
                x = x + h
            Next
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e _
                              As System.EventArgs) Handles Button1.Click
        Dim a, b, h, p As Double
        a = vvod(TextBox1) : b = vvod(TextBox2) : h = vvod(TextBox3)
        Cikl(a, b, h, p)
        vivod(p, TextBox4)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e _
                              As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e _
                              As System.EventArgs) Handles Button3.Click
        TextBox5.Text = ""
        TextBox1.Text = "" : TextBox2.Text = ""
        TextBox3.Text = "" : TextBox4.Text = ""
    End Sub
End Class
