Public Class Form1
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Try
            Dim a, b As Integer
            a = txtFirstnum.Text
            b = txtSecondnum.Text
            lblResult.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
