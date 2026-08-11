<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginPicture = New System.Windows.Forms.PictureBox()
        Me.createAccount = New System.Windows.Forms.LinkLabel()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.LoginUsername = New System.Windows.Forms.TextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.loginPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.loginPicture)
        Me.Panel1.Controls.Add(Me.createAccount)
        Me.Panel1.Controls.Add(Me.passwordLabel)
        Me.Panel1.Controls.Add(Me.usernameLabel)
        Me.Panel1.Controls.Add(Me.LoginPassword)
        Me.Panel1.Controls.Add(Me.LoginUsername)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(316, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 433)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(89, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Don't have an account?"
        '
        'loginPicture
        '
        Me.loginPicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginPicture.BackColor = System.Drawing.Color.Transparent
        Me.loginPicture.BackgroundImage = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Login_Unclicked
        Me.loginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loginPicture.Location = New System.Drawing.Point(65, 244)
        Me.loginPicture.Name = "loginPicture"
        Me.loginPicture.Size = New System.Drawing.Size(460, 90)
        Me.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginPicture.TabIndex = 9
        Me.loginPicture.TabStop = False
        '
        'createAccount
        '
        Me.createAccount.AutoSize = True
        Me.createAccount.BackColor = System.Drawing.Color.Transparent
        Me.createAccount.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createAccount.ForeColor = System.Drawing.Color.Transparent
        Me.createAccount.LinkColor = System.Drawing.Color.White
        Me.createAccount.Location = New System.Drawing.Point(399, 361)
        Me.createAccount.Name = "createAccount"
        Me.createAccount.Size = New System.Drawing.Size(98, 29)
        Me.createAccount.TabIndex = 7
        Me.createAccount.TabStop = True
        Me.createAccount.Text = "Sign up"
        Me.createAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.passwordLabel.ForeColor = System.Drawing.Color.White
        Me.passwordLabel.Location = New System.Drawing.Point(60, 141)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(110, 27)
        Me.passwordLabel.TabIndex = 6
        Me.passwordLabel.Text = "PASSWORD"
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usernameLabel.Location = New System.Drawing.Point(60, 50)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(112, 27)
        Me.usernameLabel.TabIndex = 5
        Me.usernameLabel.Text = "USERNAME"
        '
        'LoginPassword
        '
        Me.LoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPassword.Location = New System.Drawing.Point(67, 171)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassword.Size = New System.Drawing.Size(458, 30)
        Me.LoginPassword.TabIndex = 1
        '
        'LoginUsername
        '
        Me.LoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginUsername.Location = New System.Drawing.Point(65, 80)
        Me.LoginUsername.Name = "LoginUsername"
        Me.LoginUsername.Size = New System.Drawing.Size(460, 30)
        Me.LoginUsername.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitButton.BackColor = System.Drawing.Color.Green
        Me.exitButton.BackgroundImage = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.white_cross
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.White
        Me.exitButton.Location = New System.Drawing.Point(1153, 22)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(52, 47)
        Me.exitButton.TabIndex = 4
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(284, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(627, 137)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Login_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1224, 729)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exitButton)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.loginPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents LoginUsername As TextBox
    Friend WithEvents exitButton As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents createAccount As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents loginPicture As PictureBox
    Friend WithEvents Label1 As Label
End Class
