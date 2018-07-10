Imports MySql.Data.MySqlClient
Public Class frmAddAircraft
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim a As Control
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            If txtbxCapacity.Text = "" Or txtbxCode.Text = "" Or txtbxType.Text = "" Then
                MessageBox.Show("Error")

            Else
                cmd.CommandText = "INSERT INTO aircraft (aircraft_cd, aircraft_type, capacity, status)" &
                               "VALUES(@aircraft_cd, @aircraft_type, @capacity, @status)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@aircraft_cd", txtbxCode.Text)
                cmd.Parameters.AddWithValue("@aircraft_type", txtbxType.Text)
                cmd.Parameters.AddWithValue("@capacity", txtbxCapacity.Text)
                cmd.Parameters.AddWithValue("@status", "A")


                cmd.ExecuteNonQuery()

                MessageBox.Show("You have sucessfully added a new aircraft")
                frmManageAircraft.load_window()
                For Each a In Me.Controls

                    If TypeOf a Is TextBox Then

                        a.Text = Nothing

                    End If

                Next
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next

        Me.Close()

    End Sub

    Private Sub txtbxCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxCode.TextChanged

    End Sub

    Private Sub frmAddAircraft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next
    End Sub

    Private Sub txtbxType_TextChanged(sender As Object, e As EventArgs) Handles txtbxType.TextChanged

    End Sub

    Private Sub txtbxCapacity_TextChanged(sender As Object, e As EventArgs) Handles txtbxCapacity.TextChanged

    End Sub
End Class