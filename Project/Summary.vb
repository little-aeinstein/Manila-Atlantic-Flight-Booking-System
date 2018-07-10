Imports System
Imports MySql.Data.MySqlClient
Public Class frmSummary
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If (frmFlightType.rdbtnOneWay.Checked = True) Then
            frmSelectOneWay.Show()
            Me.Close()
        ElseIf (frmFlightType.rdbtnRoundTrip.Checked = True) Then
            frmSelectRound.Show()
            Me.Close()
        ElseIf (frmFlightType.rdbtnMultiCity.Checked = True) Then
            frmSelectMultiCity.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim currentcust As String = ""
        Dim currenttrans As String = ""
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            If frmLoginForm.txtbxUsername.Text = "" Then
                query = "Select max(cust_no) from customer"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    currentcust = READER.GetInt32(0)
                End While
                READER.Close()

            Else
                query = "Select cust_no from customer Where username = '" & frmLoginForm.txtbxUsername.Text & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    currentcust = READER.GetInt32(0)
                End While
                READER.Close()
            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            Dim query As String

            query = "Insert into transaction (cust_no, date, total) VALUES('" & currentcust & "', curdate(), '" & lblTotalFee.Text & "')"
            Cmd = New MySqlCommand(query, conn)
            READER = Cmd.ExecuteReader

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            Dim query As String
            query = "Select max(trans_no) from transaction"
            Cmd = New MySqlCommand(query, conn)
            READER = Cmd.ExecuteReader
            While READER.Read()
                currenttrans = READER.GetInt32(0)
            End While
            READER.Close()

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            Dim query As String
            Dim query1 As String
            Dim query2 As String
            If (frmFlightType.rdbtnOneWay.Checked = True) Then
                query = "Insert into lineitems (quantity, instance_no, subtotal, trans_no) VALUES('" & Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString) & "',' " & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(0).Value & "', '" & Format(Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString) * frmSelectOneWay.dgvDept.SelectedRows(0).Cells(8).Value) & "', '" & currenttrans & "')"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

            ElseIf (frmFlightType.rdbtnRoundTrip.Checked = True) Then
                query = "Insert into lineitems (quantity, instance_no, subtotal, trans_no) VALUES('" & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & "', '" & frmSelectRound.dgvDept.SelectedRows(0).Cells(0).Value & "', '" & Format(Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) * frmSelectRound.dgvDept.SelectedRows(0).Cells(8).Value) & "', '" & currenttrans & "')"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

                query1 = "Insert into lineitems (quantity, instance_no, subtotal, trans_no) VALUES('" & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & "', '" & frmSelectRound.dgvRet.SelectedRows(0).Cells(0).Value & "', '" & Format(Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) * frmSelectRound.dgvRet.SelectedRows(0).Cells(8).Value) & "', '" & currenttrans & "')"
                Cmd = New MySqlCommand(query1, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

            ElseIf (frmFlightType.rdbtnMultiCity.Checked = True) Then
                query = "Insert into lineitems (quantity, instance_no, subtotal, trans_no) VALUES('" & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & "', '" & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(0).Value & "', '" & Format(Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(8).Value) & "', '" & currenttrans & "')"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

                query1 = "Insert into lineitems (quantity, instance_no, subtotal, trans_no) VALUES('" & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & "', '" & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(0).Value & "', '" & Format(Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(8).Value) & "', '" & currenttrans & "')"
                Cmd = New MySqlCommand(query1, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

                query2 = "Insert into lineitems (quantity, instance_no, subtotal, trans_no) VALUES('" & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & "', '" & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(0).Value & "', '" & Format(Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(8).Value) & "', '" & currenttrans & "')"
                Cmd = New MySqlCommand(query2, conn)
                READER = Cmd.ExecuteReader
                READER.Close()
            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            Dim query As String
            Dim query2 As String
            Dim query3 As String

            If (frmFlightType.rdbtnOneWay.Checked = True) Then
                query = "Update flightinstance set available = available - '" & Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString) & "' where instance_no = '" & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                READER.Close()
            ElseIf (frmFlightType.rdbtnRoundTrip.Checked = True) Then
                query = "Update flightinstance set available = available - '" & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & "' where instance_no = '" & frmSelectRound.dgvDept.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

                query2 = "Update flightinstance set available = available - '" & Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) & "' where instance_no = '" & frmSelectRound.dgvRet.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query2, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

            ElseIf (frmFlightType.rdbtnMultiCity.Checked = True) Then
                query = "Update flightinstance set available = available - '" & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & "' where instance_no = '" & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

                query2 = "Update flightinstance set available = available - '" & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & "' where instance_no = '" & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query2, conn)
                READER = Cmd.ExecuteReader
                READER.Close()

                query3 = "Update flightinstance set available = available - '" & Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) & "' where instance_no = '" & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query3, conn)
                READER = Cmd.ExecuteReader
                READER.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            Dim query As String
            Dim query1 As String
            Dim query2 As String
            Dim available As Int32
            If (frmFlightType.rdbtnOneWay.Checked = True) Then
                query = "Select available from flightinstance where instance_no = '" & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    available = READER.GetInt32(0)
                End While
                READER.Close()
                If available = 0 Then
                    query = "Update flightinstance set status= 'O' where instance_no = '" & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(query, conn)
                    READER = Cmd.ExecuteReader
                    READER.Close()
                End If

            ElseIf (frmFlightType.rdbtnRoundTrip.Checked = True) Then
                query = "Select available from flightinstance where instance_no = '" & frmSelectRound.dgvDept.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    available = READER.GetInt32(0)
                End While
                READER.Close()
                If available = 0 Then
                    query = "Update flightinstance set status= 'O' where instance_no = '" & frmSelectRound.dgvDept.SelectedRows(0).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(query, conn)
                    READER = Cmd.ExecuteReader
                    READER.Close()
                End If

                query1 = "Select available from flightinstance where instance_no = '" & frmSelectRound.dgvRet.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query1, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    available = READER.GetInt32(0)
                End While
                READER.Close()
                If available = 0 Then
                    query1 = "Update flightinstance set status= 'O' where instance_no = '" & frmSelectRound.dgvRet.SelectedRows(0).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(query1, conn)
                    READER = Cmd.ExecuteReader
                    READER.Close()
                End If

            ElseIf (frmFlightType.rdbtnMultiCity.Checked = True) Then
                query = "Select available from flightinstance where instance_no = '" & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    available = READER.GetInt32(0)
                End While
                READER.Close()
                If available = 0 Then
                    query = "Update flightinstance set status= 'O' where instance_no = '" & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(query, conn)
                    READER = Cmd.ExecuteReader
                    READER.Close()
                End If

                query1 = "Select available from flightinstance where instance_no = '" & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query1, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    available = READER.GetInt32(0)
                End While
                READER.Close()
                If available = 0 Then
                    query1 = "Update flightinstance set status= 'O' where instance_no = '" & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(query1, conn)
                    READER = Cmd.ExecuteReader
                    READER.Close()
                End If

                query2 = "Select available from flightinstance where instance_no = '" & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(0).Value & "'"
                Cmd = New MySqlCommand(query2, conn)
                READER = Cmd.ExecuteReader
                While READER.Read()
                    available = READER.GetInt32(0)
                End While
                READER.Close()
                If available = 0 Then
                    query2 = "Update flightinstance set status= 'O' where instance_no = '" & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(query2, conn)
                    READER = Cmd.ExecuteReader
                    READER.Close()
                End If

            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Me.Close()
        frmSearchMultiCity.Close()
        frmSearchOneWay.Close()
        frmSearchRoundTrip.Close()
        frmSelectMultiCity.Close()
        frmSelectOneWay.Close()
        frmSelectRound.Close()
        MessageBox.Show("You have successfully booked a flight.", "Manila Atlantic Flight Booking System",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        frmBookOrView.Show()
    End Sub

    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (frmFlightType.rdbtnOneWay.Checked = True) Then
            txtbxDetails.Text = "One Way Trip" & Environment.NewLine & "Flight Details:" & Environment.NewLine & "Flight Number: " & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(0).Value & Environment.NewLine & "Origin: " & frmSearchOneWay.cmbbxOrigin.SelectedItem.ToString & Environment.NewLine & "Destination: " & frmSearchOneWay.cmbbxDestination.SelectedItem.ToString & Environment.NewLine & "ETD: " & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(3).Value & Environment.NewLine & "ETA: " & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(4).Value & Environment.NewLine & "Departure Date: " & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(5).Value & Environment.NewLine & "Airport: " & frmSelectOneWay.dgvDept.SelectedRows(0).Cells(6).Value & Environment.NewLine & "Price: " & Format(Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString) * frmSelectOneWay.dgvDept.SelectedRows(0).Cells(8).Value, "c")
            lblTotalFee.Text = frmSelectOneWay.dgvDept.SelectedRows(0).Cells(8).Value * Integer.Parse(frmSearchOneWay.cmbbxNumPass.SelectedItem.ToString)

        ElseIf (frmFlightType.rdbtnRoundTrip.Checked = True) Then
            Dim RoundPrice As Double = 0
            txtbxDetails.Text = "Round Trip" & Environment.NewLine & "Flight Details:" & Environment.NewLine & "Departure Trip" & Environment.NewLine &
            "Flight Number: " & frmSelectRound.dgvDept.SelectedRows(0).Cells(0).Value & Environment.NewLine & "Origin: " & frmSearchRoundTrip.cmbbxOrigin.SelectedItem.ToString & Environment.NewLine & "Destination: " &
            frmSearchRoundTrip.cmbbxDestination.SelectedItem.ToString & Environment.NewLine & "ETD: " & frmSelectRound.dgvDept.SelectedRows(0).Cells(3).Value & Environment.NewLine & "ETA: " & frmSelectRound.dgvDept.SelectedRows(0).Cells(4).Value &
            Environment.NewLine & "Departure Date: " & frmSelectRound.dgvDept.SelectedRows(0).Cells(5).Value & Environment.NewLine & "Airport: " & frmSelectRound.dgvDept.SelectedRows(0).Cells(6).Value & Environment.NewLine & "Price: " &
            Format(Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) * frmSelectRound.dgvDept.SelectedRows(0).Cells(8).Value, "c") & Environment.NewLine & Environment.NewLine & "Return Trip" & Environment.NewLine &
            "Flight Number: " & frmSelectRound.dgvRet.SelectedRows(0).Cells(0).Value & Environment.NewLine & "Origin: " & frmSearchRoundTrip.cmbbxDestination.SelectedItem.ToString & Environment.NewLine & "Destination: " & frmSearchRoundTrip.cmbbxOrigin.SelectedItem.ToString & Environment.NewLine & "ETD: " & frmSelectRound.dgvRet.SelectedRows(0).Cells(3).Value & Environment.NewLine & "ETA: " & frmSelectRound.dgvRet.SelectedRows(0).Cells(4).Value & Environment.NewLine & "Departure Date: " & frmSelectRound.dgvRet.SelectedRows(0).Cells(5).Value & Environment.NewLine & "Airport: " & frmSelectRound.dgvRet.SelectedRows(0).Cells(6).Value & Environment.NewLine & "Price: " & Format(Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) * frmSelectRound.dgvRet.SelectedRows(0).Cells(8).Value, "c")

            RoundPrice = RoundPrice + Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) * frmSelectRound.dgvDept.SelectedRows(0).Cells(8).Value + Integer.Parse(frmSearchRoundTrip.cmbbxNumPass.SelectedItem.ToString) * frmSelectRound.dgvRet.SelectedRows(0).Cells(8).Value
            lblTotalFee.Text = RoundPrice


        ElseIf (frmFlightType.rdbtnMultiCity.Checked = True) Then
            Dim MultiPrice As Double = 0
            txtbxDetails.Text = "Multi City Trip" & Environment.NewLine & "Flight Details:" & Environment.NewLine & "Flight #1 Trip" & Environment.NewLine &
            "Flight Number: " & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(0).Value & Environment.NewLine & "Origin: " & frmSearchMultiCity.cmbbxOrigin1.SelectedItem.ToString & Environment.NewLine & "Destination: " &
            frmSearchMultiCity.cmbbxDestination1.SelectedItem.ToString & Environment.NewLine & "ETD: " & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(3).Value & Environment.NewLine & "ETA: " & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(4).Value &
            Environment.NewLine & "Departure Date: " & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(5).Value & Environment.NewLine & "Airport: " & frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(6).Value & Environment.NewLine & "Price: " &
            Format(Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(8).Value, "c") & Environment.NewLine & Environment.NewLine &
            "Flight #2 Trip" & Environment.NewLine &
            "Flight Number: " & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(0).Value & Environment.NewLine & "Origin: " & frmSearchMultiCity.cmbbxOrigin2.SelectedItem.ToString & Environment.NewLine & "Destination: " &
            frmSearchMultiCity.cmbbxDestination2.SelectedItem.ToString & Environment.NewLine & "ETD: " & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(3).Value & Environment.NewLine & "ETA: " & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(4).Value &
            Environment.NewLine & "Departure Date: " & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(5).Value & Environment.NewLine & "Airport: " & frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(6).Value & Environment.NewLine & "Price: " &
            Format(Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(8).Value, "c") & Environment.NewLine & Environment.NewLine &
            "Flight #3 Trip" & Environment.NewLine &
            "Flight Number: " & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(0).Value & Environment.NewLine & "Origin: " & frmSearchMultiCity.cmbbxOrigin3.SelectedItem.ToString & Environment.NewLine & "Destination: " &
            frmSearchMultiCity.cmbbxDestination3.SelectedItem.ToString & Environment.NewLine & "ETD: " & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(3).Value & Environment.NewLine & "ETA: " & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(4).Value &
            Environment.NewLine & "Departure Date: " & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(5).Value & Environment.NewLine & "Airport: " & frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(6).Value & Environment.NewLine & "Price: " &
            Format(Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(8).Value, "c")

            MultiPrice = MultiPrice + Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt3.SelectedRows(0).Cells(8).Value + Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt2.SelectedRows(0).Cells(8).Value + Integer.Parse(frmSearchMultiCity.cmbbxNumPass.SelectedItem.ToString) * frmSelectMultiCity.dgvFlgt1.SelectedRows(0).Cells(8).Value
            lblTotalFee.Text = MultiPrice

        End If
    End Sub

    Private Sub txtbxDetails_TextChanged(sender As Object, e As EventArgs) Handles txtbxDetails.TextChanged

    End Sub
End Class