Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        ChangeMe.Text = Num1.Text + ChangeMe.Text
    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        End
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        ChangeMe.Text = Num2.Text + ChangeMe.Text
    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        ChangeMe.Text = Num3.Text + ChangeMe.Text
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        ChangeMe.Text = Num4.Text + ChangeMe.Text
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        ChangeMe.Text = Num5.Text + ChangeMe.Text
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        ChangeMe.Text = Num6.Text + ChangeMe.Text
    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        ChangeMe.Text = Num7.Text + ChangeMe.Text
    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        ChangeMe.Text = Num8.Text + ChangeMe.Text
    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        ChangeMe.Text = Num9.Text + ChangeMe.Text
    End Sub

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click

        ChangeMe.Text = Num0.Text + ChangeMe.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ChangeMe.Text = ""
    End Sub

    Private Sub Process1_Exited(sender As Object, e As EventArgs)

    End Sub

    Private Sub HyperLinkToGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HyperLinkToGithub.LinkClicked

        Process.Start("https://github.com/NyteByteBot")


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCXB2gB1McDTX6Yf9KjWhFcw")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://footballforfools.000webhostapp.com")
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Form2.Visible() = True
        Me.Visible() = False
    End Sub
End Class