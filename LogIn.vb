Imports System.Media

Public Class Form1
    Dim buttonSound As New SoundPlayer(My.Resources.button_sfx)
    Private Sub loginPicture_MouseEnter(sender As Object, e As EventArgs) Handles loginPicture.MouseEnter
        loginPicture.Image = My.Resources.Login_Hover
    End Sub

    Private Sub loginPicture_MouseLeave(sender As Object, e As EventArgs) Handles loginPicture.MouseLeave
        loginPicture.Image = My.Resources.Login_Unclicked
    End Sub

    Private Sub loginPicture_Click(sender As Object, e As EventArgs) Handles loginPicture.Click
        buttonSound.Play()
        If String.IsNullOrEmpty(LoginUsername.Text) OrElse String.IsNullOrEmpty(LoginPassword.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim enteredUsername As String = LoginUsername.Text
        Dim enteredPassword As String = LoginPassword.Text

        If TemporaryStorage.RegisteredUsers.ContainsKey(enteredUsername) AndAlso
           TemporaryStorage.RegisteredUsers(enteredUsername) = enteredPassword Then
            MessageBox.Show("Welcome to the Calculator!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoginUsername.Clear()
            LoginPassword.Clear()
            LoginUsername.Focus()

            Me.Hide()
            Home.Show()
        Else
            MessageBox.Show("Incorrect username and/or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub createAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles createAccount.LinkClicked
        Dim newAccountForm As New NewAccount()
        newAccountForm.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub


    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HT_CAPTION As Integer = &H2

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        Me.Capture = False
        Dim msg As Message =
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                    New IntPtr(HT_CAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(200, Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
    End Sub

End Class

Public Class TemporaryStorage
    Public Shared RegisteredUsers As New Dictionary(Of String, String)()
End Class


