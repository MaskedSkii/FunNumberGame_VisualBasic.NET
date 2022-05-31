Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        End
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackToLogin_Click(sender As Object, e As EventArgs) Handles BackToLogin.Click
        Me.Visible() = False
        Form2.Visible() = True
    End Sub
End Class