Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fail As String = vvod(Form1.TextBox2)
        Dim str As String = ""
        vvodfile(fail, str, TextBox1)
        ReDim sp60(60), sd(60), sbksd(60, 1)
        formsp(str, sp60, sd, sbksd)
        maxmikro(sd, sbksd)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Form1.TextBox1.Text = ""
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class