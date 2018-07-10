Public Class frmAdminFlight
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnShowLatestTrans_Click(sender As Object, e As EventArgs) Handles btnShowLatestTrans.Click
        frmLatestTrans.Show()
        Me.Hide()

    End Sub

    Private Sub btnManageFlgtIns_Click(sender As Object, e As EventArgs) Handles btnAddFlgtIns.Click
        frmManageFlightInstance.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageLoc_Click(sender As Object, e As EventArgs) Handles btnManageLoc.Click
        frmManageLocation.Show()
        Me.Hide()

    End Sub

    Private Sub btnShowFlgt_Click(sender As Object, e As EventArgs) Handles btnShowFlgt.Click
        frmFlightList.Show()
        Me.Hide()


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLoginForm.Show()
        Me.Close()

    End Sub

    Private Sub btnManageFlgt_Click(sender As Object, e As EventArgs) Handles btnManageFlgt.Click
        frmManageFlight.Show()
        Me.Hide()


    End Sub

    Private Sub btnAir_Click(sender As Object, e As EventArgs) Handles btnAir.Click
        frmManageAircraft.Show()
        Me.Hide()

    End Sub

    Private Sub btnEndFlgt_Click(sender As Object, e As EventArgs) Handles btnEndFlgt.Click
        frmEndFlightList.Show()
        Me.Hide()

    End Sub

    Private Sub frmAdminFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class