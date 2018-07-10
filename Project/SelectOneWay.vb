Imports MySql.Data.MySqlClient
Public Class frmSelectOneWay
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub frmSelectOneWay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT instance_no AS 'Flight number', orgn AS 'Origin', destination AS 'Destination', etd AS 'ETD', etd AS 'ETA', dep_date AS 'Departure', l2.airport AS 'Airport', aircraft_cd AS 'Aircraft Code' , price * " & Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString) & " As 'Price' FROM flight f, flightinstance fi, location l1, location l2 WHERE f.flight_no = fi.flgt_no AND fi.status = 'A' AND orgn = l1.loc_cd AND destination = l2.loc_cd AND l1.name = '" & frmSearchOneWay.cmbbxOrigin.SelectedItem.ToString & "' AND l2.name = '" & frmSearchOneWay.cmbbxDestination.SelectedItem.ToString & "' AND dep_date >= '" & frmSearchOneWay.dtpDeptDate.Text & "' AND fi.available >= " & Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString) & " Order by 6"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvDept.DataSource = bSource
            SDA.Update(dbDataset)
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
        frmSearchOneWay.Show()
        Me.Close()

    End Sub

    Private Sub dgvDept_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDept.CellContentClick
        Dim flgtno As String
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvDept.Rows(e.RowIndex)

            flgtno = row.Cells("Flight number").Value.ToString

        End If

    End Sub
End Class