Imports MySql.Data.MySqlClient
Public Class frmAddLocation
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub frmAddLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxAirport.Text = ""
        txtbxCode.Text = ""
        txtbxName.Text = ""
    End Sub

    Private Sub txtbxCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxCode.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            If txtbxCode.Text = "" Or txtbxName.Text = "" Or txtbxAirport.Text = "" Then
                MessageBox.Show("Error")

            Else
                cmd.CommandText = "INSERT INTO location (loc_cd, name, airport)" &
                               "VALUES(@loc_cd, @name, @airport)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@loc_cd", txtbxCode.Text)
                cmd.Parameters.AddWithValue("@name", txtbxName.Text)
                cmd.Parameters.AddWithValue("@airport", txtbxAirport.Text)


                cmd.ExecuteNonQuery()

                MessageBox.Show("You have successfully added a new location")

                Dim a As Control

                For Each a In Me.Controls

                    If TypeOf a Is TextBox Then

                        a.Text = Nothing

                    End If

                Next
                frmManageLocation.load_window()
                conn.Close()
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub txtbxName_TextChanged(sender As Object, e As EventArgs) Handles txtbxName.TextChanged

    End Sub

    Private Sub txtbxAirport_TextChanged(sender As Object, e As EventArgs) Handles txtbxAirport.TextChanged

    End Sub
End Class