Imports System.Runtime.Remoting.Channels
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim myconn As New MySqlConnection("server=localhost; userid=root; password=password; database=studrec")
    Dim command As MySqlCommand

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            myconn.Open()
            MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"

        Dim Reader As MySqlDataReader
        Dim count As Integer = 0

        Try
            myconn.Open()
            Dim query As String
            query = "SELECT * FROM studrec.studinfo WHERE username = '" & TextBox1.Text & "' AND user_password = '" & TextBox2.Text & "';"

            command = New MySqlCommand(query, myconn)
            Reader = command.ExecuteReader

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form2.Show()

            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Else
                MessageBox.Show("Username and password are incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Finally
            myconn.Dispose()

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class