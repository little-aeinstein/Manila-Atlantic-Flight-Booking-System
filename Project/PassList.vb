Imports MySql.Data.MySqlClient

Public Class frmPassList
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmFlightList.Show()
        Me.Close()


    End Sub

    Private Sub frmPassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT DISTINCT c.cust_no as 'Customer No', c.gvn_name as 'Given Name', c.fam_name as 'Family Name', sum(l.quantity) as 'Quantity' FROM customer c, flightinstance i, lineitems l, transaction t WHERE c.cust_no = t.cust_no AND t.trans_no = l.trans_no AND l.instance_no = i.instance_no AND i.instance_no = " & frmFlightList.dgvFlgt.SelectedRows(0).Cells(0).Value & " GROUP BY c.cust_no"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvListPassFlgt.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        txtbxFlgtNum.Text = frmFlightList.dgvFlgt.SelectedRows(0).Cells(0).Value

        Dim total As Integer = 0
        For i As Integer = 0 To dgvListPassFlgt.RowCount - 1
            total += dgvListPassFlgt.Rows(i).Cells(3).Value 'Change the number 2 to your column index number (The first column has a 0 index column) 'In this example the column index of Price is 2 Next TextBox1.Text = total
        Next

        txtbxPass.Text = total
    End Sub

    Private Sub dgvListPassFlgt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListPassFlgt.CellContentClick

    End Sub
End Class