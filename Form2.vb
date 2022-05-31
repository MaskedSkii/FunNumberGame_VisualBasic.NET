Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If UsernameTextBox.Text = "Test123" And PasswordTextBox.Text = "123Test" Or UsernameTextBox.Text = "Test321" And PasswordTextBox.Text = "321Test" Then

            Form1.Visible() = True
            Me.Visible() = False
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        Else

            UsernameTextBox.Text = "Incorrect!"
            PasswordTextBox.Text = "Incorrect!"


        End If


    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        End
    End Sub

    Private Async Sub signup_Click(sender As Object, e As EventArgs) Handles GrabPasswordAndUsername.Click
        Me.Visible() = False
        Form3.Visible() = True

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class