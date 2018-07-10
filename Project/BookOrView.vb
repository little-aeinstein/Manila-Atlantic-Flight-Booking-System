Public Class frmBookOrView
    Private Sub BookOrView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBookFlgt_Click(sender As Object, e As EventArgs) Handles btnBookFlgt.Click
        frmFlightType.Show()
        Me.Hide()


    End Sub

    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        frmCart.Show()
        Me.Hide()


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLoginForm.txtbxUsername.Text = Nothing
        frmLoginForm.txtbxPassword.Text = Nothing

        frmLoginForm.Show()
        Me.Close()


    End Sub
End Class