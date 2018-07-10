Imports MySql.Data.MySqlClient

Public Class frmManageFlightInstance
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddFlightInstance.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminFlight.Show()
        Me.Close()
    End Sub

    Private Sub dgvFlgtIns_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlgtIns.CellContentClick

    End Sub

    Private Sub frmManageFlightInstance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT fi.instance_no AS 'Flight No.', aircraft_cd AS 'Aircraft', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure' FROM flight f, flightinstance fi WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' ORDER BY 1"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvFlgtIns.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Dim query2 As String = "Select loc_cd From location Order By 1"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(query2, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim orgcd As String = ""
            cmbbxOrigin.Items.Add(orgcd)
            cmbbxDestination.Items.Add(orgcd)
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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim msg = "Are you sure you want to remove this flight instance?"
        Dim title = "Remove Flight Instance"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Critical
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim reader As MySqlDataReader

        Dim response = MsgBox(msg, style, title)
        Try
            conn.Open()
            Dim Query As String = " UPDATE flightinstance SET status = 'C' WHERE instance_no = '" & dgvFlgtIns.SelectedRows(0).Cells(0).Value & "'"
            Cmd = New MySqlCommand(Query, conn)
            If response = MsgBoxResult.Yes Then
                reader = Cmd.ExecuteReader
                MessageBox.Show("You have successfully removed a flight instance")
                load_window()
                reader.Close()
            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
    Public Sub load_window()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset2 As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT fi.instance_no AS 'Flight No.', aircraft_cd AS 'Aircraft', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure' FROM flight f, flightinstance fi WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' ORDER BY 1"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset2)
            bSource.DataSource = dbDataset2
            dgvFlgtIns.DataSource = bSource
            SDA.Update(dbDataset2)
            dbDataSet = dbDataset2
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxOrigin.SelectedIndexChanged
        Dim DV As New DataView(dbDataSet)
        If cmbbxDestination.Text = "" Then
            DV.RowFilter = String.Format("Origin Like '{0}**'", (cmbbxOrigin.Text))
            dgvFlgtIns.DataSource = DV
        Else
            DV.RowFilter = String.Format("Origin Like '{0}**' AND Destination Like '{1}**'", (cmbbxOrigin.Text), (cmbbxDestination.Text))
            dgvFlgtIns.DataSource = DV
        End If
    End Sub

    Private Sub cmbbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDestination.SelectedIndexChanged
        Dim DV As New DataView(dbDataSet)
        If cmbbxOrigin.Text = "" Then
            DV.RowFilter = String.Format("Destination Like '{0}**'", (cmbbxDestination.Text))
            dgvFlgtIns.DataSource = DV
        Else
            DV.RowFilter = String.Format("Destination Like '{0}**' AND Origin Like '{1}**'", (cmbbxDestination.Text), (cmbbxOrigin.Text))
            dgvFlgtIns.DataSource = DV
        End If
    End Sub
End Class