Imports MySql.Data.MySqlClient

Public Class frmManageLocation

    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub frmRemLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT loc_cd AS 'Location Code', name AS 'Name', airport AS 'Airport' FROM location order by 1"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvLoc.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminFlight.Show()
        Me.Close()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddLocation.Show()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim msg = "Are you sure you want to remove this Location?"
        Dim title = "Remove Location"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Critical
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim READER As MySqlDataReader
        Dim response = MsgBox(msg, style, title)
        Try
            conn.Open()
            Dim query As String
            query = "delete from Location where loc_cd = '" & dgvLoc.SelectedRows(0).Cells(0).Value & "'"
            Cmd = New MySqlCommand(query, conn)
            If response = MsgBoxResult.Yes Then
                READER = Cmd.ExecuteReader
                MessageBox.Show("You have successfully removed a Location")
                load_window()
                READER.Close()
            End If
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub dgvLoc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoc.CellContentClick

    End Sub

    Public Sub load_window()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT loc_cd AS 'Location Code', name AS 'Name', airport AS 'Airport' FROM location order by 1"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvLoc.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class