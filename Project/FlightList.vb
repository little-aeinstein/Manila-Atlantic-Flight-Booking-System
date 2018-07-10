Imports MySql.Data.MySqlClient
Public Class frmFlightList
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Dim dbDataset As New DataTable

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnShowPassList_Click(sender As Object, e As EventArgs) Handles btnShowPassList.Click
        frmPassRep.Show()
        Me.Hide()


    End Sub

    Private Sub btnShowPassRep_Click(sender As Object, e As EventArgs) Handles btnShowPassRep.Click
        frmPassList.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminFlight.Show()
        Me.Close()

    End Sub

    Private Sub cmbbxSort_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvFlgt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlgt.CellContentClick

    End Sub

    Private Sub frmFlightList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT fi.instance_no AS 'Flight No.', aircraft_cd AS 'Aircraft', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', available AS 'Available Seats', fi.status AS 'Status' FROM flight f, flightinstance fi WHERE f.flight_no = fi.flgt_no ORDER BY 1"
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

        cmbbxStatus.Items.Add("")
        cmbbxStatus.Items.Add("A")
        cmbbxStatus.Items.Add("O")
        cmbbxStatus.Items.Add("F")
        cmbbxStatus.Items.Add("R")

    End Sub

    Private Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxOrigin.SelectedIndexChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("Origin Like '{0}**' AND Destination Like '{1}**' AND Status Like '{2}**' AND '{3}' Like '##?{4}?####'", (cmbbxOrigin.Text), (cmbbxDestination.Text), (cmbbxStatus.Text), dgvFlgt.Columns(6).ToString, (cmbbxDay.Text))
        dgvFlgt.DataSource = DV
    End Sub

    Private Sub cmbbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDestination.SelectedIndexChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("Origin Like '{0}**' AND Destination Like '{1}**' AND Status Like '{2}**'", (cmbbxOrigin.Text), (cmbbxDestination.Text), (cmbbxStatus.Text))
        dgvFlgt.DataSource = DV
    End Sub

    Private Sub cmbbxStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxStatus.SelectedIndexChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("Origin Like '{0}**' AND Destination Like '{1}**' AND Status Like '{2}**'", (cmbbxOrigin.Text), (cmbbxDestination.Text), (cmbbxStatus.Text))
        dgvFlgt.DataSource = DV
    End Sub

    Private Sub cmbbxDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDay.SelectedIndexChanged

    End Sub
End Class