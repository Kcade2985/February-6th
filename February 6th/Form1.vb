Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            PictureBox1.Image = My.Resources.Cookies_n_cream
        End If
        If ListBox1.SelectedIndex = 1 Then
            PictureBox1.Image = My.Resources.Strawberry
        End If
        If ListBox1.SelectedIndex = 2 Then
            PictureBox1.Image = My.Resources.Vanilla
        End If
        If ListBox1.SelectedIndex = 3 Then
            PictureBox1.Image = My.Resources.Chocolate
        End If
        If ListBox1.SelectedIndex = 4 Then
            PictureBox1.Image = My.Resources.Rocky_road
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False

    End Sub
End Class
