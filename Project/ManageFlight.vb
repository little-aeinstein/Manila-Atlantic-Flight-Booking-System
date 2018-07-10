Imports MySql.Data.MySqlClient

Public Class frmManageFlight
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub frmManageFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT flight_no AS 'Flight Number', etd AS 'ETD', eta AS 'ETA', orgn  AS 'Origin', destination AS 'Destination', date_added AS 'Date_Added' FROM flight Where status = 'A' order by 1"
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

        Dim query2 As String = "Select loc_cd From location order by 1"

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddFlight.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminFlight.Show()
        Me.Close()


    End Sub

    Private Sub dgvFlgt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlgt.CellContentClick

    End Sub

    Private Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxOrigin.SelectedIndexChanged
        Dim DV As New DataView(dbDataSet)
        If cmbbxDestination.Text = "" Then
            DV.RowFilter = String.Format("Origin Like '{0}**'", (cmbbxOrigin.Text))
            dgvFlgt.DataSource = DV
        Else
            DV.RowFilter = String.Format("Origin Like '{0}**' AND Destination Like '{1}**'", (cmbbxOrigin.Text), (cmbbxDestination.Text))
            dgvFlgt.DataSource = DV
        End If

    End Sub

    Private Sub cmbbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDestination.SelectedIndexChanged
        Dim DV As New DataView(dbDataSet)
        If cmbbxOrigin.Text = "" Then
            DV.RowFilter = String.Format("Destination Like '{0}**'", (cmbbxDestination.Text))
            dgvFlgt.DataSource = DV
        Else
            DV.RowFilter = String.Format("Destination Like '{0}**' AND Origin Like '{1}**'", (cmbbxDestination.Text), (cmbbxOrigin.Text))
            dgvFlgt.DataSource = DV
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim msg = "Are you sure you want to remove this flight template?"
        Dim title = "Remove Flight Template"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                    MsgBoxStyle.Critical
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim reader As MySqlDataReader

        Dim response = MsgBox(msg, style, title)
        Try
            conn.Open()
            Dim Query As String = " UPDATE flight SET status = 'R' WHERE flight_no = '" & dgvFlgt.SelectedRows(0).Cells(0).Value & "'"
            Cmd = New MySqlCommand(Query, conn)
            If response = MsgBoxResult.Yes Then
                reader = Cmd.ExecuteReader
                MessageBox.Show("You have successfully removed a flight template")
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
        Dim bSource As New BindingSource
        Dim dbDataSet2 As New DataTable

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT flight_no AS 'Flight Number', etd AS 'ETD', eta AS 'ETA', orgn  AS 'Origin', destination AS 'Destination', date_added AS 'Date_Added' FROM flight Where status = 'A' order by 1"
            Cmd = New MySqlCommand(Query, conn)
            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataSet2)
            bSource.DataSource = dbDataSet2
            dgvFlgt.DataSource = bSource
            SDA.Update(dbDataSet2)
            dbDataSet = dbDataSet2
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        cmbbxDestination.SelectedIndex = -1
        cmbbxOrigin.SelectedIndex = -1

        Dim query2 As String = "Select loc_cd From location order by 1"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(query2, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim orgcd As String = ""
            cmbbxOrigin.Items.Add(orgcd)
            cmbbxDestination.Items.Add(orgcd)

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
End Class