Imports MySql.Data.MySqlClient
Public Class frmGuestInfo
    Dim conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next
        frmLoginForm.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid = root; password = root; database = manila_atlantic_booking_system; Convert Zero Datetime=True"
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            If cmbbxTitle.Text = "" Or txtbxFirstName.Text = "" Or txtbxFamilyName.Text = "" Or
            txtbxMobNum.Text = "" Or txtbxEmail.Text = "" Or IsInputNumeric(txtbxMobNum.Text) = False Then
                If txtbxAltMobNum.Text IsNot "" And IsInputNumeric(txtbxAltMobNum.Text) = False Then
                    MessageBox.Show("Error")
                End If
            Else
                cmd.CommandText = "INSERT INTO customer (title, gvn_name, fam_name, mob_no, alt_mob, email)" &
                               "VALUES(@title, @gvn_name, @fam_name, @mob_no, @alt_mob, @email)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@title", cmbbxTitle.Text)
                cmd.Parameters.AddWithValue("@gvn_name", txtbxFirstName.Text)
                cmd.Parameters.AddWithValue("@fam_name", txtbxFamilyName.Text)
                cmd.Parameters.AddWithValue("@mob_no", txtbxMobNum.Text)
                cmd.Parameters.AddWithValue("@alt_mob", txtbxAltMobNum.Text)
                cmd.Parameters.AddWithValue("@email", txtbxEmail.Text)

                cmd.ExecuteNonQuery()

                Dim a As Control

                For Each a In Me.Controls

                    If TypeOf a Is TextBox Then

                        a.Text = Nothing

                    End If

                Next

                frmBookOrView.Show()
                conn.Close()
                Me.Hide()

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmGuestInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbbxTitle.Items.Add("Mr.")
        cmbbxTitle.Items.Add("Ms.")
        cmbbxTitle.Items.Add("Mrs.")
        cmbbxTitle.Text = "Mr."
    End Sub

    Private Sub cmbbxTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTitle.SelectedIndexChanged

    End Sub
    Private Function IsInputNumeric(input As String) As Boolean
        If String.IsNullOrWhiteSpace(input) Then Return False
        If IsNumeric(input) Then Return True
        Dim parts() As String = input.Split("/"c)
        If parts.Length <> 2 Then Return False
        Return IsNumeric(parts(0)) AndAlso IsNumeric(parts(1))
    End Function
End Class