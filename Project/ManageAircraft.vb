Imports MySql.Data.MySqlClient

Public Class frmManageAircraft
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddAircraft.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminFlight.Show()
        Me.Close()
    End Sub

    Private Sub dgvAir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAir.CellContentClick

    End Sub

    Private Sub frmManageAircraft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT aircraft_cd AS ' Aircraft Code', aircraft_type AS 'Aircraft Type', capacity AS 'Capacity' FROM aircraft Where status = 'A'"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvAir.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim msg = "Are you sure you want to remove this aircraft?"
        Dim title = "Remove Aircraft"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Critical
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim reader As MySqlDataReader

        Dim response = MsgBox(msg, style, title)
        Try
            conn.Open()
            Dim Query As String = " UPDATE aircraft SET status = 'R' WHERE aircraft_cd = '" & dgvAir.SelectedRows(0).Cells(0).Value & "'"
            Cmd = New MySqlCommand(Query, conn)
            If response = MsgBoxResult.Yes Then
                reader = Cmd.ExecuteReader
                MessageBox.Show("You have successfully removed an aircraft")
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
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT aircraft_cd AS ' Aircraft Code', aircraft_type AS 'Aircraft Type', capacity AS 'Capacity' FROM aircraft Where status = 'A'"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvAir.DataSource = bSource
            SDA.Update(dbDataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class