Imports MySql.Data.MySqlClient
Public Class frmPassRep
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmFlightList.Show()
        Me.Close()


    End Sub

    Private Sub frmPassRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim query As String = "Select loc_cd From location order by 1"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
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

        cmbbxYear.Items.Add("2015")
        cmbbxYear.Items.Add("2016")
        cmbbxYear.Text = "2015"

    End Sub

    Private Sub chrtReport_Click(sender As Object, e As EventArgs) Handles chrtReport.Click

    End Sub

    Private Sub cmbbxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxOrigin.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        chrtReport.Series("Passengers Per Month").Points.Clear()
        txtbxTotalPass.Text = 0

        Dim total As Int32 = 0
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            If cmbbxOrigin.Text = "" And cmbbxDestination.Text = "" Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND " &
                    "YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by Month(fi.dep_date)"
            ElseIf (cmbbxDestination.Text = "") Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.orgn = '" & cmbbxOrigin.Text & "'" &
                    " AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.orgn, Month(fi.dep_date)"
            ElseIf (cmbbxOrigin.Text = "") Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.destination = '" & cmbbxDestination.Text & "'" &
                    " AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.destination, Month(fi.dep_date)"
            Else
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.orgn = '" & cmbbxOrigin.Text & "'" &
                    " AND f.destination = '" & cmbbxDestination.Text & "' AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.orgn, f.destination, Month(fi.dep_date)"
            End If
            Cmd = New MySqlCommand(Query, conn)
            READER = Cmd.ExecuteReader
            While READER.Read()
                chrtReport.Series("Passengers Per Month").Points.AddXY(READER.GetString(0), READER.GetInt32(1))
                total += READER.GetInt32(1)
            End While
            READER.Close()
            conn.Close()

            txtbxTotalPass.Text = total
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub cmbbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDestination.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        chrtReport.Series("Passengers Per Month").Points.Clear()
        txtbxTotalPass.Text = 0

        Dim READER As MySqlDataReader
        Dim total As Int32 = 0
        Try
            conn.Open()
            Dim Query As String
            If cmbbxOrigin.Text = "" And cmbbxDestination.Text = "" Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND " &
                    "YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by Month(fi.dep_date)"
            ElseIf (cmbbxDestination.Text = "") Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.orgn = '" & cmbbxOrigin.Text & "'" &
                    " AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.orgn, Month(fi.dep_date)"
            ElseIf (cmbbxOrigin.Text = "") Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.destination = '" & cmbbxDestination.Text & "'" &
                    " AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.destination, Month(fi.dep_date)"
            Else
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.orgn = '" & cmbbxOrigin.Text & "'" &
                    " AND f.destination = '" & cmbbxDestination.Text & "' AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.orgn, f.destination, Month(fi.dep_date)"
            End If
            Cmd = New MySqlCommand(Query, conn)
            READER = Cmd.ExecuteReader
            While READER.Read()
                chrtReport.Series("Passengers Per Month").Points.AddXY(READER.GetString(0), READER.GetInt32(1))
                total += READER.GetInt32(1)
            End While
            READER.Close()
            conn.Close()

            txtbxTotalPass.Text = total
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub cmbbxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxYear.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        chrtReport.Series("Passengers Per Month").Points.Clear()
        txtbxTotalPass.Text = 0

        Dim READER As MySqlDataReader
        Dim total As Int32 = 0
        Try
            conn.Open()
            Dim Query As String
            If cmbbxOrigin.Text = "" And cmbbxDestination.Text = "" Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND " &
                    "YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by Month(fi.dep_date)"
            ElseIf (cmbbxDestination.Text = "") Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.orgn = '" & cmbbxOrigin.Text & "'" &
                    " AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.orgn, Month(fi.dep_date)"
            ElseIf (cmbbxOrigin.Text = "") Then
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.destination = '" & cmbbxDestination.Text & "'" &
                    " AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.destination, Month(fi.dep_date)"
            Else
                Query = "Select Month(fi.dep_date), Sum(l.quantity) From flightinstance fi, flight f, lineitems l, transaction t " &
                    "Where fi.flgt_no = f.flight_no AND l.instance_no = fi.instance_no AND t.trans_no = l.trans_no AND f.orgn = '" & cmbbxOrigin.Text & "'" &
                    " AND f.destination = '" & cmbbxDestination.Text & "' AND YEAR(fi.dep_date) = '" & cmbbxYear.Text & "' Group by f.orgn, f.destination, Month(fi.dep_date)"
            End If
            Cmd = New MySqlCommand(Query, conn)
            READER = Cmd.ExecuteReader
            While READER.Read()
                chrtReport.Series("Passengers Per Month").Points.AddXY(READER.GetString(0), READER.GetInt32(1))
                total += READER.GetInt32(1)
            End While
            READER.Close()
            conn.Close()

            txtbxTotalPass.Text = total
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class