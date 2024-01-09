Option Strict On
Imports System.Math
Public Class Frm1
    Dim k(,) As Integer

    Function vvod(ByVal T As TextBox) As Integer
        Return CInt(T.Text)
    End Function

    Sub vvodpoprav(ByRef k(,) As Integer, ByVal a _
                   As Integer, ByVal b As Integer)
        Dim i, j As Integer
        Randomize()
        For i = 0 To a
            For j = 0 To b
                k(i, j) = CInt(-10 + 20 * Rnd())
            Next j
        Next i
    End Sub

    Sub vivodmas(ByRef x(,) As Integer, ByRef TB As TextBox)
        Dim i, j, m, n As Integer
        Dim z As String
        m = x.GetLength(0) - 1 : n = x.GetLength(1) - 1
        TB.Text = ""
        For i = 0 To m
            For j = 0 To n
                If Abs(x(i, j)) >= 100 Then
                    z = CStr(x(i, j)) & Space(2)
                ElseIf Abs(x(i, j)) >= 10 Then
                    z = CStr(x(i, j)) & Space(4)
                Else
                    z = CStr(x(i, j)) & Space(6)
                End If
                If x(i, j) >= 0 Then z = Space(1) + z
                TB.Text = TB.Text & z
            Next j
            TB.Text = TB.Text & vbCrLf
        Next i
    End Sub

    Sub pereststr(ByRef k(,) As Integer, ByRef a _
                  As Integer, ByRef b As Integer)
        Dim i, j, rez As Integer
        For i = 0 To (a - 1) \ 2
            For j = 0 To b
                rez = k(i, j) : k(i, j) = k(a - i, j) : k(a - i, j) = rez
            Next j
        Next i
    End Sub

    Private Sub Btn1_Click(sender As Object, e _
                           As EventArgs) Handles Btn1.Click
        Dim a, b As Integer
        a = vvod(Txt1) : b = vvod(Txt2)
        a = a - 1 : b = b - 1
        Dim k(a, b) As Integer
        vvodpoprav(k, a, b)
        vivodmas(k, Txt3)
        pereststr(k, a, b)
        vivodmas(k, Txt4)
    End Sub

    Private Sub Btn2_Click(sender As Object, e _
                           As EventArgs) Handles Btn2.Click
        End
    End Sub
End Class
