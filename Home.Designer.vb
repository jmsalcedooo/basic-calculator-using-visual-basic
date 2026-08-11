<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.creditsIcon = New System.Windows.Forms.PictureBox()
        Me.creditsLabel = New System.Windows.Forms.Label()
        Me.creditsButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.calculatorIcon = New System.Windows.Forms.PictureBox()
        Me.calculatorLabel = New System.Windows.Forms.Label()
        Me.calculatorButton = New System.Windows.Forms.Button()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoutLabel = New System.Windows.Forms.Label()
        Me.logoutIcon = New System.Windows.Forms.PictureBox()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.creditsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        CType(Me.calculatorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.logoutIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.labelTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.CalcuBG
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Size = New System.Drawing.Size(1009, 711)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.Controls.Add(Me.creditsIcon)
        Me.Panel2.Controls.Add(Me.creditsLabel)
        Me.Panel2.Controls.Add(Me.creditsButton)
        Me.Panel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(28, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 141)
        Me.Panel2.TabIndex = 14
        '
        'creditsIcon
        '
        Me.creditsIcon.BackColor = System.Drawing.Color.Transparent
        Me.creditsIcon.ErrorImage = CType(resources.GetObject("creditsIcon.ErrorImage"), System.Drawing.Image)
        Me.creditsIcon.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.bookwithquill
        Me.creditsIcon.Location = New System.Drawing.Point(48, 19)
        Me.creditsIcon.Name = "creditsIcon"
        Me.creditsIcon.Size = New System.Drawing.Size(79, 71)
        Me.creditsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.creditsIcon.TabIndex = 2
        Me.creditsIcon.TabStop = False
        '
        'creditsLabel
        '
        Me.creditsLabel.AutoSize = True
        Me.creditsLabel.BackColor = System.Drawing.Color.Transparent
        Me.creditsLabel.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditsLabel.ForeColor = System.Drawing.Color.Black
        Me.creditsLabel.Location = New System.Drawing.Point(42, 99)
        Me.creditsLabel.Name = "creditsLabel"
        Me.creditsLabel.Size = New System.Drawing.Size(98, 29)
        Me.creditsLabel.TabIndex = 1
        Me.creditsLabel.Text = "Credits"
        Me.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'creditsButton
        '
        Me.creditsButton.BackColor = System.Drawing.Color.Transparent
        Me.creditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.creditsButton.ForeColor = System.Drawing.Color.Black
        Me.creditsButton.Location = New System.Drawing.Point(3, 3)
        Me.creditsButton.Name = "creditsButton"
        Me.creditsButton.Size = New System.Drawing.Size(170, 135)
        Me.creditsButton.TabIndex = 13
        Me.creditsButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(24, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "___________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(34, 615)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "_________________"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.OldLace
        Me.Panel19.Controls.Add(Me.calculatorIcon)
        Me.Panel19.Controls.Add(Me.calculatorLabel)
        Me.Panel19.Controls.Add(Me.calculatorButton)
        Me.Panel19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel19.Location = New System.Drawing.Point(28, 152)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(176, 141)
        Me.Panel19.TabIndex = 10
        '
        'calculatorIcon
        '
        Me.calculatorIcon.BackColor = System.Drawing.Color.Transparent
        Me.calculatorIcon.ErrorImage = CType(resources.GetObject("calculatorIcon.ErrorImage"), System.Drawing.Image)
        Me.calculatorIcon.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.table
        Me.calculatorIcon.Location = New System.Drawing.Point(48, 19)
        Me.calculatorIcon.Name = "calculatorIcon"
        Me.calculatorIcon.Size = New System.Drawing.Size(79, 71)
        Me.calculatorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.calculatorIcon.TabIndex = 2
        Me.calculatorIcon.TabStop = False
        '
        'calculatorLabel
        '
        Me.calculatorLabel.AutoSize = True
        Me.calculatorLabel.BackColor = System.Drawing.Color.Transparent
        Me.calculatorLabel.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatorLabel.ForeColor = System.Drawing.Color.Black
        Me.calculatorLabel.Location = New System.Drawing.Point(22, 98)
        Me.calculatorLabel.Name = "calculatorLabel"
        Me.calculatorLabel.Size = New System.Drawing.Size(135, 29)
        Me.calculatorLabel.TabIndex = 1
        Me.calculatorLabel.Text = "Calculator"
        Me.calculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calculatorButton
        '
        Me.calculatorButton.BackColor = System.Drawing.Color.Transparent
        Me.calculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculatorButton.ForeColor = System.Drawing.Color.Black
        Me.calculatorButton.Location = New System.Drawing.Point(3, 3)
        Me.calculatorButton.Name = "calculatorButton"
        Me.calculatorButton.Size = New System.Drawing.Size(170, 135)
        Me.calculatorButton.TabIndex = 13
        Me.calculatorButton.UseVisualStyleBackColor = False
        '
        'labelTitle
        '
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Minecraft Ten", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelTitle.Location = New System.Drawing.Point(1, 20)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(233, 91)
        Me.labelTitle.TabIndex = 22
        Me.labelTitle.Text = "Menu"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.ForeColor = System.Drawing.Color.DarkGray
        Me.Label.Location = New System.Drawing.Point(34, 116)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(162, 20)
        Me.Label.TabIndex = 24
        Me.Label.Text = "_________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(24, 628)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "___________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(34, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "_________________"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.logoutLabel)
        Me.Panel1.Controls.Add(Me.logoutIcon)
        Me.Panel1.Controls.Add(Me.logoutButton)
        Me.Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(28, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 141)
        Me.Panel1.TabIndex = 23
        '
        'logoutLabel
        '
        Me.logoutLabel.AutoSize = True
        Me.logoutLabel.BackColor = System.Drawing.Color.Transparent
        Me.logoutLabel.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLabel.ForeColor = System.Drawing.Color.Black
        Me.logoutLabel.Location = New System.Drawing.Point(36, 99)
        Me.logoutLabel.Name = "logoutLabel"
        Me.logoutLabel.Size = New System.Drawing.Size(103, 29)
        Me.logoutLabel.TabIndex = 1
        Me.logoutLabel.Text = "Log Out"
        Me.logoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logoutIcon
        '
        Me.logoutIcon.BackColor = System.Drawing.Color.Transparent
        Me.logoutIcon.ErrorImage = Nothing
        Me.logoutIcon.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.door
        Me.logoutIcon.Location = New System.Drawing.Point(52, 21)
        Me.logoutIcon.Name = "logoutIcon"
        Me.logoutIcon.Size = New System.Drawing.Size(69, 70)
        Me.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoutIcon.TabIndex = 22
        Me.logoutIcon.TabStop = False
        '
        'logoutButton
        '
        Me.logoutButton.BackColor = System.Drawing.Color.Transparent
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.ForeColor = System.Drawing.Color.Black
        Me.logoutButton.Location = New System.Drawing.Point(3, 3)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(170, 135)
        Me.logoutButton.TabIndex = 18
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 683)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 711)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.creditsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.calculatorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logoutIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents calculatorIcon As PictureBox
    Friend WithEvents calculatorLabel As Label
    Friend WithEvents calculatorButton As Button
    Friend WithEvents labelTitle As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutLabel As Label
    Friend WithEvents logoutIcon As PictureBox
    Friend WithEvents logoutButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents creditsIcon As PictureBox
    Friend WithEvents creditsLabel As Label
    Friend WithEvents creditsButton As Button
    Friend WithEvents Button1 As Button
End Class
