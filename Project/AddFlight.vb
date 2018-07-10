Imports MySql.Data.MySqlClient
Public Class frmAddFlight
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim orgcd As String
    Dim descd As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub dtpETA_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim thisDate As Date
        thisDate = Today

        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim cmd As New MySqlCommand()
        Try
            conn.Open()
            cmd.Connection = conn

            cmd.CommandText = "INSERT INTO flight (etd, eta, orgn, destination, date_added, status)" &
                                "VALUES (@etd, @eta, @orgn, @dest, @date,'A')"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@etd", ETD.Text.ToString)
            cmd.Parameters.AddWithValue("@eta", ETA.Text.ToString)
            cmd.Parameters.AddWithValue("@orgn", cmbbxOrigin.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@dest", cmbbxDestination.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@date", thisDate)

            cmd.ExecuteNonQuery()

            MessageBox.Show("You have sucessfully added a new flight template")
            frmManageFlight.load_window()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
            conn.Dispose()

        End Try
        Me.Close()
    End Sub

    Public Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxOrigin.SelectedIndexChanged
    End Sub

    Private Sub cmbbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDestination.SelectedIndexChanged

    End Sub

    Private Sub dtpETD_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmAddFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim query As String = "Select loc_cd From location order by 1"

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
    End Sub

    Private Sub ETD_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class