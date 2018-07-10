Imports MySql.Data.MySqlClient

Public Class frmSelectRound
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub frmSelectRound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset1 As New DataTable
        Dim dbDataset2 As New DataTable
        Dim bSource1 As New BindingSource
        Dim bSource2 As New BindingSource

        Try
            conn.Open()
            Dim Query1 As String
            Dim Query2 As String
            Query1 = "SELECT instance_no AS 'Flight number', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', l2.airport AS 'Airport', aircraft_cd AS 'Aircraft Code', price * " & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & " AS 'Price' FROM flight f, flightinstance fi, location l1, location l2 WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' AND orgn = l1.loc_cd AND destination = l2.loc_cd AND l1.name = '" & frmSearchRoundTrip.cmbbxOrigin.SelectedItem.ToString & "' AND l2.name = '" & frmSearchRoundTrip.cmbbxDestination.SelectedItem.ToString & "' AND dep_date >= '" & frmSearchRoundTrip.dtpDeptDate.Text & "' AND fi.available >= " & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & " Order by 6"
            Query2 = "Select instance_no As 'Flight number', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', l1.airport AS 'Airport', aircraft_cd AS 'Aircraft Code', price * " & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & " AS 'Price' FROM flight f, flightinstance fi, location l1, location l2 WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' AND orgn = l1.loc_cd AND destination = l2.loc_cd AND l2.name = '" & frmSearchRoundTrip.cmbbxOrigin.SelectedItem.ToString & "' AND l1.name = '" & frmSearchRoundTrip.cmbbxDestination.SelectedItem.ToString & "' AND dep_date >= '" & frmSearchRoundTrip.dtpRetDate.Text & "' AND fi.available >= " & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & " Order by 6"
            Cmd = New MySqlCommand(Query1, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset1)
            bSource1.DataSource = dbDataset1
            dgvDept.DataSource = bSource1
            SDA.Update(dbDataset1)
            Cmd = New MySqlCommand(Query2, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset2)
            bSource2.DataSource = dbDataset2
            dgvRet.DataSource = bSource2
            SDA.Update(dbDataset2)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmSummary.Show()
        Me.Hide()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmSearchRoundTrip.Show()
        Me.Close()


    End Sub

    Private Sub dgvDept_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDept.CellContentClick

    End Sub
End Class