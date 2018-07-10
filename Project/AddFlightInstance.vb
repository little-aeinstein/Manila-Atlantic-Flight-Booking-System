Imports MySql.Data.MySqlClient

Public Class frmAddFlightInstance
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub cmbbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim thisDate As Date
        thisDate = Today
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim cmd As New MySqlCommand()

        Dim query2 As String = "Select capacity From aircraft where aircraft_cd = '" & cmbbxAircraft.SelectedItem.ToString & "'"
        Dim cap As Int32
        Try
            conn.Open()
            Dim cmd2 As MySqlCommand = New MySqlCommand(query2, conn)
            Dim reader As MySqlDataReader = cmd2.ExecuteReader()

            While reader.Read()
                cap = reader.GetInt32(0)
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

        Try
            conn.Open()
            cmd.Connection = conn

            cmd.CommandText = "INSERT INTO flightinstance (dep_date, status, price, date_add, aircraft_cd, available, flgt_no)" &
                               "VALUES(@depdate, @status, @price, @add, @air, @avail, @no)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@depdate", dtpFrom.Value)
            cmd.Parameters.AddWithValue("@status", "A")
            cmd.Parameters.AddWithValue("@price", txtbxPrice.Text)
            cmd.Parameters.AddWithValue("@add", thisDate)
            cmd.Parameters.AddWithValue("@air", cmbbxAircraft.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@avail", cap)
            cmd.Parameters.AddWithValue("@no", dgvFlgt.SelectedRows(0).Cells(0).Value)

            cmd.ExecuteNonQuery()

            MessageBox.Show("You have successfully added a new flight instance.")
            frmManageFlightInstance.load_window()
            conn.Close()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()


    End Sub

    Private Sub dgvFlgtIns_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frmCreateFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT flight_no AS 'Template', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', eta AS 'ETA' FROM manila_atlantic_booking_system.flight Where status= 'A' order by 1"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvFlgt.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Dim query2 As String = "Select aircraft_cd From aircraft Where status = 'A' order by 1"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(query2, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbbxAircraft.Items.Add(reader.GetString(0))
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

    End Sub

    Private Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbbxAircraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxAircraft.SelectedIndexChanged

    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged

    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvFlgt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlgt.CellContentClick

    End Sub
End Class