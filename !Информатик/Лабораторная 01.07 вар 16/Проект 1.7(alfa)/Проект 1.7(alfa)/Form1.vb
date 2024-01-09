Option Strict On
Option Explicit On
Imports System
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Math
Class frm1
    Dim x(), xb(), c() As Single
    Private x1 As Integer
    Private x3 As Double
    Private nfi As NumberFormatInfo = NumberFormatInfo.CurrentInfo
    Private ds As Char = CChar(nfi.NumberDecimalSeparator)

    Private Sub txt1_KeyPress(ByVal sender As System.Object, _
         ByVal e As KeyPressEventArgs) Handles txt1.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = txt1
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

    Private Sub txt2_KeyPress(ByVal sender As System.Object, _
     ByVal e As KeyPressEventArgs) Handles txt2.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = txt2
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

    Private Sub txt3_KeyPress(ByVal sender As System.Object, _
     ByVal e As KeyPressEventArgs) Handles txt3.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = txt3
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

    Private Sub txt4_KeyPress(ByVal sender As System.Object, _
     ByVal e As KeyPressEventArgs) Handles txt4.KeyPress
        Dim c As Char, t As TextBox
        c = e.KeyChar
        t = txt4
        If Not Char.IsDigit(e.KeyChar) Then
            If e.KeyChar <> Convert.ToChar(Keys.Back) Then
                If e.KeyChar <> Convert.ToChar(Keys.Space) Then
                    If e.KeyChar <> "-" Then
                        If e.KeyChar <> "," Then
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub vivod(ByRef x() As Single, ByRef TB As TextBox)
        Dim i As Integer
        Dim y As String = ""
        For i = 0 To UBound(x)
            y = y + Format(x(i), "0.00") + Space(3)
        Next i
        TB.Text = y
    End Sub

    Public Sub proizv(ByVal x() As Single, ByRef x1() As Single, _
                  ByRef przv As Double, ByRef osh As Integer)
        Dim max, min As Double, i, j, cmx, cmn As Integer
        max = Single.MinValue : min = Single.MaxValue : przv = 1
        For i = 0 To UBound(x)
            If x(i) > max Then max = x(i) : cmx = i
            If x(i) < min Then min = x(i) : cmn = i
        Next i
        If (cmn > cmx And cmn - 1 = cmx) Or _
            (cmn < cmx And cmx - 1 = cmn) Then
            MsgBox("Между максимальным и минимальным значением нету чисел", _
                   MsgBoxStyle.Critical)
            osh = 1
        ElseIf cmn < cmx Then
            cmx = cmx - 1 : cmn = cmn + 1
            Do While cmx >= cmn
                przv = przv * x(cmn)
                ReDim Preserve x1(j)
                x1(j) = x(cmn) : j = j + 1
                cmn = cmn + 1
            Loop
        ElseIf cmn > cmx Then
            cmx = cmx + 1 : cmn = cmn - 1
            Do While cmn >= cmx
                przv = przv * x(cmx)
                ReDim Preserve x1(j)
                x1(j) = x(cmx) : j = j + 1
                cmx = cmx + 1
            Loop
        End If
    End Sub

    Private Sub cmb2_SelectedIndexChanged _
                        (ByVal sender As System.Object, _
                         ByVal e As System.EventArgs) Handles _
                            cmb2.SelectedIndexChanged
        Dim ind, oshibka As Integer, przv As Double
        prvrk()
        ind = cmb2.SelectedIndex
        txt5.Text = ""
        Select Case ind
            Case 0
                proizv(c, xb, przv, oshibka)
        End Select
        If oshibka = 1 Then Exit Sub
        vivod(xb, txt5)
        txt6.Text = Format(przv, "00.0000")
    End Sub

    Sub prvrk()
        Dim i As Integer, t As String
        Dim n As Integer = Integer.Parse(txt1.Text)
        t = txt4.Text : t = Trim(t) : i = 0
        While InStr(t, "  ") > 0
            t = Replace(t, "  ", " ")
        End While
        While InStr(t, "--") > 0
            t = Replace(t, "--", "-")
        End While
        Dim x() As String = t.Split(" "c)
        If n > x.Length Then
            MsgBox("Длина массива не соответствует введенному!")
            Return
        End If
        c = New Single(n - 1) {}
        While i < n
            c(i) = Single.Parse(x(i))
            i = i + 1
        End While
        txt4.Text = ""
        vivod(c, txt4)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal _
                           e As System.EventArgs) Handles btn1.Click
        End
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal _
                           e As System.EventArgs) Handles btn2.Click
        Dim i, xi As Integer, a, b As Single
        xi = CInt(txt1.Text)
        a = CSng(txt2.Text)
        b = CSng(txt3.Text)
        xi = xi - 1
        ReDim Preserve x(xi)
        Randomize()
        For i = 0 To xi
            x(i) = a + Rnd() * (b - a)
        Next i
        vivod(x, txt4)
    End Sub
End Class
