Imports MySql.Data.MySqlClient
Public Class frmSelectMultiCity
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub frmSelectMultiCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset1 As New DataTable
        Dim dbDataset2 As New DataTable
        Dim dbDataset3 As New DataTable
        Dim bSource1 As New BindingSource
        Dim bSource2 As New BindingSource
        Dim bSource3 As New BindingSource

        Try
            conn.Open()
            Dim Query1 As String
            Dim Query2 As String
            Dim Query3 As String
            Query1 = "SELECT instance_no AS 'Flight number', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', l2.Airport As 'Airport', aircraft_cd AS 'Aircraft Code', price * " & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & " As 'Price' FROM flight f, flightinstance fi, location l1, location l2 WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' AND orgn = l1.loc_cd AND destination = l2.loc_cd AND l1.name = '" & frmSearchMultiCity.cmbbxOrigin1.SelectedItem.ToString & "' AND l2.name = '" & frmSearchMultiCity.cmbbxDestination1.SelectedItem.ToString & "' AND dep_date >= '" & frmSearchMultiCity.dtpDeptDate.Text & "' AND fi.available >= " & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & " Order by 6"
            Query2 = "SELECT instance_no AS 'Flight number', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', l2.Airport As 'Airport', aircraft_cd AS 'Aircraft Code', price * " & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & " As 'Price' FROM flight f, flightinstance fi, location l1, location l2 WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' AND orgn = l1.loc_cd AND destination = l2.loc_cd AND l1.name = '" & frmSearchMultiCity.cmbbxOrigin2.SelectedItem.ToString & "' AND l2.name = '" & frmSearchMultiCity.cmbbxDestination2.SelectedItem.ToString & "' AND dep_date >= '" & frmSearchMultiCity.dtpRetDate1.Text & "' AND fi.available >= " & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & " Order by 6"
            Query3 = "SELECT instance_no AS 'Flight number', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', l2.Airport As 'Airport', aircraft_cd AS 'Aircraft Code', price * " & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & " As 'Price' FROM flight f, flightinstance fi, location l1, location l2 WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' AND orgn = l1.loc_cd AND destination = l2.loc_cd AND l1.name = '" & frmSearchMultiCity.cmbbxOrigin3.SelectedItem.ToString & "' AND l2.name = '" & frmSearchMultiCity.cmbbxDestination3.SelectedItem.ToString & "' AND dep_date >= '" & frmSearchMultiCity.dtpRetDate2.Text & "' AND fi.available >= " & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & " Order by 6"
            Cmd = New MySqlCommand(Query1, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset1)
            bSource1.DataSource = dbDataset1
            dgvFlgt1.DataSource = bSource1
            SDA.Update(dbDataset1)
            Cmd = New MySqlCommand(Query2, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset2)
            bSource2.DataSource = dbDataset2
            dgvFlgt2.DataSource = bSource2
            SDA.Update(dbDataset2)
            Cmd = New MySqlCommand(Query3, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset3)
            bSource3.DataSource = dbDataset3
            dgvFlgt3.DataSource = bSource3
            SDA.Update(dbDataset3)
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
        frmSearchMultiCity.Show()
        Me.Close()


    End Sub

    Private Sub dgvFlgt3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlgt3.CellContentClick

    End Sub

    Private Sub dgvFlgt1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlgt1.CellContentClick

    End Sub
End Class