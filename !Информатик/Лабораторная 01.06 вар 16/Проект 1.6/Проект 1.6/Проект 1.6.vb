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
      ByVal e As KeyPressEventArgs)
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

    Function vvod(ByVal T As TextBox) As Double
        Return CDbl(T.Text)
    End Function

    Function vvodcmb(ByVal T As ComboBox) As Double
        Return CDbl(T.Text)
    End Function

    Sub vivod(ByVal Z As Double, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    Sub vivodstoch(ByVal Z As Double, ByVal index As Integer, ByVal T As TextBox)
        Select index
            Case 0
                T.Text = Format("{0,0:F2}", Z)
            Case 1
                T.Text = Format("{0,0:F3}", Z)
            Case 2
                T.Text = Format("{0,0:F4}", Z)
            Case 3
                T.Text = Format("{0,0:F5}", Z)
            Case 4
                T.Text = Format("{0,0:F6}", Z)
            Case 5
                T.Text = Format("{0,0:F7}", Z)
            Case 6
                T.Text = Format("{0,0:F8}", Z)
            Case 7
                T.Text = Format("{0,0:F9}", Z)
            Case 8
                T.Text = Format("{0,0:F10}", Z)
        End Select
    End Sub

    Sub vivodtxbs(ByVal n As Integer, ByVal a As Double, _
                     ByVal Sum As Double, ByVal T As TextBox)
        Dim fs As String = String.Format("{0,0}", n) + _
            String.Format("{0,19:F12}", a) + String.Format("{0,19:F12}", Sum)
        T.Text = T.Text + fs + vbCrLf
    End Sub

    Function func(ByVal x As Double, ByVal n As Double) As Double
        Return 2 * (x - 1) ^ (2 * n + 1) / ((2 * n + 1) * (x + 1) ^ (2 * n + 1))
    End Function

    Private Sub Rad(ByVal x As Double, ByVal Eps As Double, _
                           ByRef Sum As Double)
        Dim n As Integer, a As Double
        n = 0 : a = 2 * (x - 1) / (x + 1) : Sum = 0
        Do While Abs(a) > Eps And n < 100
            Sum = Sum + a
            vivodtxbs(n, a, Sum, TextBox3)
            n = n + 1
            a = func(x, n)
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal _
                              e As System.EventArgs) Handles Button1.Click
        Dim x, Eps, Sum, Sumet As Double, index As Integer
        index = ComboBox1.SelectedIndex
        x = vvod(TextBox1) : Eps = vvodcmb(ComboBox1)
        If x <= 0 Then MsgBox("Значение x для функций" + _
            "y=ln(x) может быть только больше нуля")
        Rad(x, Eps, Sum)
        vivodstoch(Sum, index, TextBox4)
        Sumet = Log(x)
        vivodstoch(Sumet, index, TextBox2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal _
                              e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal _
                              e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal _
                              e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = "1,5"
    End Sub
End Class
