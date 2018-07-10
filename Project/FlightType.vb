Public Class frmFlightType
    Private Sub frmFlightType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If rdbtnOneWay.Checked Then
            frmSearchOneWay.Show()
            Me.Hide()
        End If
        If rdbtnRoundTrip.Checked Then
            frmSearchRoundTrip.Show()
            Me.Hide()
        End If
        If rdbtnMultiCity.Checked Then
            frmSearchMultiCity.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmBookOrView.Show()
        Me.Hide()


    End Sub
End Class