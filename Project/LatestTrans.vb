Imports MySql.Data.MySqlClient

Public Class frmLatestTrans
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminFlight.Show()
        Me.Close()


    End Sub

    Private Sub dgvLatestTransCust_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLatestTransCust.CellContentClick

    End Sub

    Private Sub frmLatestTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT DISTINCT  t.trans_no AS 'Transaction No.', c.cust_no AS 'Customer No.', CONCAT(c.gvn_name, ' ', c.fam_name) AS 'Name', MAX(t.date) AS 'Last Transaction Date' FROM customer c, transaction t WHERE c.cust_no = t.cust_no GROUP BY c.cust_no"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvLatestTransCust.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class