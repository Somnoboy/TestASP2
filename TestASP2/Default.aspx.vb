Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnTry_Click(sender As Object, e As EventArgs) Handles btnTry.Click
        lblTry.Text = "I tried, and it worked."
    End Sub
End Class