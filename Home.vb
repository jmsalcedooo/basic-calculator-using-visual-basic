Imports System.Media

Public Class Home
    Dim buttonSound As New SoundPlayer(My.Resources.button_sfx)

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub calculatorIcon_Click(sender As Object, e As EventArgs) Handles calculatorIcon.Click
        ShowCalculatorPanel()
    End Sub

    Private Sub calculatorButton_Click(sender As Object, e As EventArgs) Handles calculatorButton.Click
        ShowCalculatorPanel()
    End Sub

    Private Sub calculatorLabel_Click(sender As Object, e As EventArgs) Handles calculatorLabel.Click
        ShowCalculatorPanel()
    End Sub

    Private Sub ShowCalculatorPanel()
        buttonSound.Play()

        Dim calculatorForm As New Calculator()
        calculatorForm.TopLevel = False
        calculatorForm.FormBorderStyle = FormBorderStyle.None
        calculatorForm.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(calculatorForm)
        calculatorForm.Show()
        Me.Text = "Calculator"
    End Sub


    Private Sub creditsButton_Click(sender As Object, e As EventArgs) Handles creditsButton.Click
        ShowCreditsPanel()
    End Sub

    Private Sub creditsLabel_Click(sender As Object, e As EventArgs) Handles creditsLabel.Click
        ShowCreditsPanel()
    End Sub

    Private Sub creditsIcon_Click(sender As Object, e As EventArgs) Handles creditsIcon.Click
        ShowCreditsPanel()
    End Sub

    Private Sub ShowCreditsPanel()
        buttonSound.Play()

        Dim creditsForm As New Credits()
        creditsForm.TopLevel = False
        creditsForm.FormBorderStyle = FormBorderStyle.None
        creditsForm.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(creditsForm)
        creditsForm.Show()
        Me.Text = "Credits"
    End Sub


    Private Sub logoutIcon_Click(sender As Object, e As EventArgs) Handles logoutIcon.Click
        Logout()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Logout()
    End Sub

    Private Sub logoutLabel_Click(sender As Object, e As EventArgs) Handles logoutLabel.Click
        Logout()
    End Sub

    Private Sub Logout()
        buttonSound.Play()

        Dim logout As Integer
        logout = MessageBox.Show("Log out this user?", "Please Confirm",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logout = DialogResult.Yes Then
            SplitContainer1.Panel2.Controls.Clear()
            Me.Hide()
            Form1.Show()
        End If
    End Sub

End Class
