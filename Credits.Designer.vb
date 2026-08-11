<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Credits))
        Me.creditsBook = New System.Windows.Forms.PictureBox()
        CType(Me.creditsBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'creditsBook
        '
        Me.creditsBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.creditsBook.BackColor = System.Drawing.Color.Transparent
        Me.creditsBook.ErrorImage = CType(resources.GetObject("creditsBook.ErrorImage"), System.Drawing.Image)
        Me.creditsBook.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Credits
        Me.creditsBook.Location = New System.Drawing.Point(85, 44)
        Me.creditsBook.Name = "creditsBook"
        Me.creditsBook.Size = New System.Drawing.Size(520, 618)
        Me.creditsBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.creditsBook.TabIndex = 15
        Me.creditsBook.TabStop = False
        '
        'Credits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.CalcuBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(682, 711)
        Me.Controls.Add(Me.creditsBook)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Credits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credits"
        CType(Me.creditsBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents creditsBook As PictureBox
End Class
