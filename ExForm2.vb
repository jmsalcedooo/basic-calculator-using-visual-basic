Imports MySql.Data.MySqlClient
Public Class Form2

    Dim myconn As New MySqlConnection("server=localhost; userid=root; password=password; database=studrec")
    Dim command As MySqlCommand


    '📌SIGN-OUT BUTTON
    Private Sub signout_Click(sender As Object, e As EventArgs) Handles signout.Click
        Me.Hide()
        Form1.Show()

        stud_id.Clear()
        lname.Clear()
        fname.Clear()
        course.Clear()
        year.Clear()
        block.Clear()
        age.Clear()
        gender.Clear()
        username.Clear()
        pass.Clear()
    End Sub


    '📌SAVE BUTTON
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"

        Try
            myconn.Open()
            Dim query As String
            query = "INSERT INTO studrec.studinfo (student_id, last_name, first_name, course, school_year, section_block, age, Gender, username, user_password) 
            VALUES ('" & stud_id.Text & "','" & lname.Text & "','" & fname.Text & "','" & course.Text & "','" & year.Text & "','" & block.Text & "','" & age.Text & "','" & gender.Text & "','" & username.Text & "','" & pass.Text & "')"

            command = New MySqlCommand(query, myconn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try

    End Sub


    '📌UPDATE BUTTON
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"
        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim query As String
            query = "UPDATE studrec.studinfo SET last_name = '" & lname.Text & "', first_name = '" & fname.Text & "', course = '" & course.Text & "', school_year = '" & year.Text & "', section_block = '" & block.Text & "', age = '" & age.Text & "', Gender = '" & gender.Text & "', username = '" & username.Text & "', user_password = '" & pass.Text & "' WHERE student_id = " & stud_id.Text

            command = New MySqlCommand(query, myconn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Finally
            myconn.Dispose()
        End Try

    End Sub


    '📌DELETE BUTTON
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"
        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim query As String
            query = "DELETE FROM studrec.studinfo WHERE student_id = '" & stud_id.Text & "'"

            command = New MySqlCommand(query, myconn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Finally
            myconn.Dispose()
        End Try

    End Sub


    '📌FORM 2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"

        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim query As String
            query = "SELECT * FROM studrec.studinfo "

            command = New MySqlCommand(query, myconn)
            reader = command.ExecuteReader

            While reader.Read
                Dim lname = reader.GetString("last_name")
                ComboBox1.Items.Add(lname)
                ListBox1.Items.Add(lname)
            End While

            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Finally
            myconn.Dispose()
        End Try

    End Sub


    '📌COMBOBOX1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"

        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim query As String
            query = "SELECT * FROM studrec.studinfo WHERE last_name = '" & ComboBox1.Text & "'"

            command = New MySqlCommand(query, myconn)
            reader = command.ExecuteReader

            While reader.Read
                stud_id.Text = reader.GetInt32("student_id")
                lname.Text = reader.GetString("last_name")
                fname.Text = reader.GetString("first_name")
                course.Text = reader.GetString("course")
                year.Text = reader.GetInt32("school_year")
                block.Text = reader.GetInt32("section_block")
                age.Text = reader.GetInt32("age")
                gender.Text = reader.GetString("Gender")
                username.Text = reader.GetString("username")
                pass.Text = reader.GetString("user_password")
            End While

            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            myconn.Dispose()
        End Try

    End Sub


    '📌LISTBOX1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root; password=password; database=studrec"

        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim query As String
            query = "SELECT * FROM studrec.studinfo WHERE last_name = '" & ListBox1.Text & "'"

            command = New MySqlCommand(query, myconn)
            reader = command.ExecuteReader

            While reader.Read
                stud_id.Text = reader.GetInt32("student_id")
                lname.Text = reader.GetString("last_name")
                fname.Text = reader.GetString("first_name")
                course.Text = reader.GetString("course")
                year.Text = reader.GetInt32("school_year")
                block.Text = reader.GetInt32("section_block")
                age.Text = reader.GetInt32("age")
                gender.Text = reader.GetString("Gender")
                username.Text = reader.GetString("username")
                pass.Text = reader.GetString("user_password")
            End While

            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            myconn.Dispose()
        End Try
    End Sub

End Class