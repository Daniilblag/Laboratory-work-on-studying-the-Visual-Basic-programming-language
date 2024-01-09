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

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, _
  ByVal e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = TextBox4
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

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, _
  ByVal e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = TextBox5
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

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, _
  ByVal e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = TextBox6
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

    Function vvod(ByVal t As TextBox) As Double
        Return CDbl(CStr(t.Text))
    End Function

    Sub vivodint(ByVal Z As Integer, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    Sub vivod(ByVal Z As Double, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    Sub vivodtextbox(ByVal X As Double, ByVal Y As Double, _
                  ByVal Z As Double, ByVal LB As TextBox)
        Dim fs As String = String.Format("{0,0:F8}", X) + _
            String.Format("{0,19:F8}", Y) + String.Format("{0,19:F8}", Z)
        LB.Text = LB.Text + fs + vbCrLf
    End Sub

    Public Function fun(ByVal x As Double, _
                         ByVal y As Double) As Double
        Return Sin(4 * x * y) + y - 2
    End Function

    Public Sub Cikl(ByVal a As Double, ByVal b As Double, _
                    ByVal c As Double, ByVal d As Double, _
                    ByVal h1 As Double, ByVal h2 As Double, _
                    ByRef kol As Integer, ByRef p As Double)
        Dim i, j, n1, n2 As Integer
        Dim x, y, z As Double
        If h1 = 0 Or h2 = 0 Then
            MsgBox("Значения 'Шаг' не могут равняться нулю", _
                   MsgBoxStyle.Critical)
        Else
            n1 = CInt((b - a) / h1) + 1 : n2 = CInt((d - c) / h2) + 1
            x = a : y = c : kol = 0 : p = 1
            For i = 1 To n1
                For j = 1 To n2
                    z = fun(x, y)
                    If z < 1 Then kol = kol + 1 : p = p * z
                    vivodtextbox(x, y, z, TextBox9)
                    y = y + h2
                Next
                y = c
                x = x + h1
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e _
                              As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, h1, h2, p As Double, kol As Integer
        a = vvod(TextBox1) : b = vvod(TextBox2) : h1 = vvod(TextBox3)
        c = vvod(TextBox4) : d = vvod(TextBox5) : h2 = vvod(TextBox6)
        Cikl(a, b, c, d, h1, h2, kol, p)
        vivodint(kol, TextBox8) : vivod(p, TextBox7)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e _
                              As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e _
                              As System.EventArgs) Handles Button3.Click
        TextBox9.Text = "" : TextBox1.Text = "" : TextBox2.Text = ""
        TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = ""
        TextBox6.Text = "" : TextBox7.Text = "" : TextBox8.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = CStr(-3.14159265) : TextBox4.Text = CStr(-3.14159265)
        TextBox2.Text = CStr(3.14159265) : TextBox5.Text = CStr(3.14159265)
        TextBox3.Text = CStr(0.39269908) : TextBox6.Text = CStr(0.39269908)
    End Sub
End Class
