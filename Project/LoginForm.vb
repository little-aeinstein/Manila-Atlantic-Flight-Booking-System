Imports MySql.Data.MySqlClient
Public Class frmLoginForm

    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim typedUsername As String
        Dim typedPassword As String
        Dim typedAccount As String
        typedUsername = txtbxUsername.Text
        typedPassword = txtbxPassword.Text
        typedAccount = typedUsername + typedPassword

        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim customerQuery As String = "SELECT username, password FROM customer WHERE  username = '" & txtbxUsername.Text & "' " & "AND password = '" & txtbxPassword.Text & "'"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(customerQuery, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()


            If reader.Read() Then

                If Not reader.IsDBNull(0) Or Not reader.IsDBNull(1) Then

                    frmBookOrView.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Your account Is invalid")

                End If
            Else
                MessageBox.Show("Your account Is invalid")
            End If

            'Catch ex As MySqlException
            'MessageBox.Show(ex.Message)

            'End Try

            'Console.WriteLine(reader.GetInt32(0) & ": " & reader.GetString(1))

            reader.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)


            ' If (txtbxUsername.Text = username) And (txtbxPassword.Text = password) Then
            'frmBookOrView.Show()
            'Me.Hide()
            'conn.Close()
            'Else
            'MessageBox.Show("Your account is invalid.")

            'End If
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next
        frmRegister.Show()
        Me.Hide()


    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next
        frmGuestInfo.Show()
        Me.Hide()


    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim typedUsername As String
        Dim typedPassword As String

        typedUsername = txtbxUsername.Text
        typedPassword = txtbxPassword.Text

        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"

        Dim customerQuery As String = "SELECT username, password FROM admin WHERE  username = '" & txtbxUsername.Text & "' " & "AND password = '" & txtbxPassword.Text & "'"

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(customerQuery, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()


            If reader.Read() Then

                If Not reader.IsDBNull(0) Or Not reader.IsDBNull(1) Then
                    Dim a As Control

                    For Each a In Me.Controls

                        If TypeOf a Is TextBox Then

                            a.Text = Nothing

                        End If

                    Next
                    frmAdminFlight.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Your account Is invalid")

                End If
            Else
                MessageBox.Show("Your account Is invalid")
            End If

            'Catch ex As MySqlException
            'MessageBox.Show(ex.Message)

            'End Try

            'Console.WriteLine(reader.GetInt32(0) & ": " & reader.GetString(1))

            reader.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)


            ' If (txtbxUsername.Text = username) And (txtbxPassword.Text = password) Then
            'frmBookOrView.Show()
            'Me.Hide()

            'Else
            'MessageBox.Show("Your account is invalid.")

            'End If
        Finally
            conn.Close()
            conn.Dispose()
        End Try

    End Sub

    Private Sub frmLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxUsername.Text = ""
        txtbxPassword.Text = ""

    End Sub
End Class
