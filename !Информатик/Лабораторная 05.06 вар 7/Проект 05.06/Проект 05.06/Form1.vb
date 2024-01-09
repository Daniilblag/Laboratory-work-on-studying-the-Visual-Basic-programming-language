Public Class Frm1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim sotr As DataRowCollection, n As Integer
        Dim rez As String = ""
        sotr = Сотрудники1DataSet1.СОТРУДНИКИ.Rows
        n = Сотрудники1DataSet1.СОТРУДНИКИ.Rows().Count() - 1
        Txt1.Text = ""
        osnproc(n, sotr, rez)
        vivod(rez, Txt1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        End
    End Sub

    Private Sub Frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.СОТРУДНИКИTableAdapter.Fill(Me.Сотрудники1DataSet1.СОТРУДНИКИ)
    End Sub
End Class
