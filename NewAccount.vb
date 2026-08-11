Imports System.Media

Public Class NewAccount
    Dim buttonSound As New SoundPlayer(My.Resources.button_sfx)
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub createAccountPicture_MouseEnter(sender As Object, e As EventArgs) Handles createAccountPicture.MouseEnter
        createAccountPicture.Image = My.Resources.CreateAccount_Hover
    End Sub

    Private Sub createAccountPicture_MouseLeave(sender As Object, e As EventArgs) Handles createAccountPicture.MouseLeave
        createAccountPicture.Image = My.Resources.CreateAccount_Unclicked
    End Sub

    Private Sub createAccountPicture_Click(sender As Object, e As EventArgs) Handles createAccountPicture.Click
        buttonSound.Play()
        If String.IsNullOrEmpty(username.Text) OrElse String.IsNullOrEmpty(password.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim enteredUsername As String = username.Text

        If TemporaryStorage.RegisteredUsers.ContainsKey(enteredUsername) Then
            MessageBox.Show("Username already taken. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            TemporaryStorage.RegisteredUsers.Add(enteredUsername, password.Text)

            MessageBox.Show("Account Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            username.Text = ""
            password.Text = ""
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error occurred while creating the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        username.Text = ""
        password.Text = ""
        Me.Hide()
    End Sub

    Private Sub NewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class