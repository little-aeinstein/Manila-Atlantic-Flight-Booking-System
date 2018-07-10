Imports MySql.Data.MySqlClient
Public Class frmRegister
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim thisDate As Date
        thisDate = Today
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            If cmbbxTitle.Text = "" Or txtbxUsername.Text = "" Or txtbxPassword.Text = "" Or txtbxFirstName.Text = "" Or txtbxFamName.Text = "" Or
            txtbxMobNum.Text = "" Or txtbxEmail.Text = "" Or IsInputNumeric(txtbxMobNum.Text) = False Then
                If txtbxAltMobNum.Text IsNot "" And IsInputNumeric(txtbxAltMobNum.Text) = False Then
                    MessageBox.Show("Error")
                End If

            ElseIf txtbxPassword.Text = txtbxRePassword.Text Then
                cmd.CommandText = "INSERT INTO customer (username, password, title, gvn_name, fam_name, mob_no, alt_mob, email, date_reg)" &
                               "VALUES(@username, @password, @title, @gvn_name, @fam_name, @mob_no, @alt_mob, @email, @date_reg)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@username", txtbxUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtbxPassword.Text)
                cmd.Parameters.AddWithValue("@title", cmbbxTitle.Text)
                cmd.Parameters.AddWithValue("@gvn_name", txtbxFirstName.Text)
                cmd.Parameters.AddWithValue("@fam_name", txtbxFamName.Text)
                cmd.Parameters.AddWithValue("@mob_no", txtbxMobNum.Text)
                cmd.Parameters.AddWithValue("@alt_mob", txtbxAltMobNum.Text)
                cmd.Parameters.AddWithValue("@email", txtbxEmail.Text)
                cmd.Parameters.AddWithValue("@date_reg", thisDate)

                cmd.ExecuteNonQuery()

                MessageBox.Show("You have successfully registered for an account")

                Dim a As Control

                For Each a In Me.Controls

                    If TypeOf a Is TextBox Then

                        a.Text = Nothing

                    End If

                Next

                frmLoginForm.Show()
                conn.Close()
                Me.Hide()

            Else
                MessageBox.Show("asdasdError")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmLoginForm.Show()
        Me.Close()

        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next
    End Sub

    Private Sub cmbbxTitle_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbbxTitle.Items.Add("Mr.")
        cmbbxTitle.Items.Add("Ms.")
        cmbbxTitle.Items.Add("Mrs.")

        cmbbxTitle.Text = "Mr."

        txtbxAltMobNum.Text = ""

    End Sub

    Private Sub txtbxMobNum_TextChanged(sender As Object, e As EventArgs) Handles txtbxMobNum.TextChanged

    End Sub

    Private Sub txtbxEmail_TextChanged(sender As Object, e As EventArgs) Handles txtbxEmail.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Function IsInputNumeric(input As String) As Boolean
        If String.IsNullOrWhiteSpace(input) Then Return False
        If IsNumeric(input) Then Return True
        Dim parts() As String = input.Split("/"c)
        If parts.Length <> 2 Then Return False
        Return IsNumeric(parts(0)) AndAlso IsNumeric(parts(1))
    End Function
End Class