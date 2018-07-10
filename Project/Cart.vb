Imports MySql.Data.MySqlClient


Public Class frmCart
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvPendTrans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendTrans.CellContentClick

    End Sub

    Private Sub frmCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            If frmLoginForm.txtbxUsername.Text = "" Then
                Query = "SELECT t.trans_no, f.orgn, f.destination, fi.dep_date, li.quantity, t.total FROM lineitems li, transaction t, customer c, flight f, flightinstance fi WHERE f.flight_no = fi.flgt_no AND li.instance_no = fi.instance_no AND (fi.status = 'A' or fi.status = 'O') AND li.trans_no = t.trans_no AND t.cust_no = c.cust_no AND c.cust_no = (select max(cust_no) from customer)"

            Else
                Query = "SELECT t.trans_no, f.orgn, f.destination, fi.dep_date, li.quantity, t.total FROM lineitems li, transaction t, customer c, flight f, flightinstance fi WHERE f.flight_no = fi.flgt_no AND li.instance_no = fi.instance_no AND (fi.status = 'A' or fi.status = 'O') AND li.trans_no = t.trans_no AND t.cust_no = c.cust_no AND c.username =  '" & frmLoginForm.txtbxUsername.Text & "'"
            End If
            Cmd = New MySqlCommand(Query, conn)
                SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvPendTrans.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmBookOrView.Show()
        Me.Close()
    End Sub
End Class