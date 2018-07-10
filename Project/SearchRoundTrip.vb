Imports MySql.Data.MySqlClient


Public Class frmSearchRoundTrip
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub SearchRoundTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim query As String = "Select name From location"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim orgcd As String = ""

            While reader.Read()
                orgcd = reader.GetString(0)
                cmbbxOrigin.Items.Add(orgcd)
                cmbbxDestination.Items.Add(orgcd)
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

        cmbbxNumPass.Text = 1
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmFlightType.Show()
        Me.Close()


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If cmbbxOrigin.SelectedIndex = -1 Or cmbbxDestination.SelectedIndex = -1 Then
            MessageBox.Show("Please select an origin and destination.")
        ElseIf cmbbxNumPass.SelectedIndex = -1 Then
            MessageBox.Show("Please select the number of passengers.")
        Else
            frmSelectRound.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxOrigin.SelectedIndexChanged

    End Sub
End Class