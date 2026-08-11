<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.calculatorPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.screw1 = New System.Windows.Forms.PictureBox()
        Me.positiveNegativeConvertButton = New System.Windows.Forms.Button()
        Me.equalsButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.subtractButton = New System.Windows.Forms.Button()
        Me.backspaceButton = New System.Windows.Forms.Button()
        Me.moduloButton = New System.Windows.Forms.Button()
        Me.threeButton = New System.Windows.Forms.Button()
        Me.sixButton = New System.Windows.Forms.Button()
        Me.nineButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.zeroButton = New System.Windows.Forms.Button()
        Me.twoButton = New System.Windows.Forms.Button()
        Me.fiveButton = New System.Windows.Forms.Button()
        Me.eightButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.dotButton = New System.Windows.Forms.Button()
        Me.oneButton = New System.Windows.Forms.Button()
        Me.fourButton = New System.Windows.Forms.Button()
        Me.sevenButton = New System.Windows.Forms.Button()
        Me.textBox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculatorPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.screw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calculatorPanel
        '
        Me.calculatorPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.calculatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.calculatorPanel.Controls.Add(Me.PictureBox3)
        Me.calculatorPanel.Controls.Add(Me.PictureBox2)
        Me.calculatorPanel.Controls.Add(Me.PictureBox1)
        Me.calculatorPanel.Controls.Add(Me.screw1)
        Me.calculatorPanel.Controls.Add(Me.positiveNegativeConvertButton)
        Me.calculatorPanel.Controls.Add(Me.equalsButton)
        Me.calculatorPanel.Controls.Add(Me.addButton)
        Me.calculatorPanel.Controls.Add(Me.subtractButton)
        Me.calculatorPanel.Controls.Add(Me.backspaceButton)
        Me.calculatorPanel.Controls.Add(Me.moduloButton)
        Me.calculatorPanel.Controls.Add(Me.threeButton)
        Me.calculatorPanel.Controls.Add(Me.sixButton)
        Me.calculatorPanel.Controls.Add(Me.nineButton)
        Me.calculatorPanel.Controls.Add(Me.multiplyButton)
        Me.calculatorPanel.Controls.Add(Me.zeroButton)
        Me.calculatorPanel.Controls.Add(Me.twoButton)
        Me.calculatorPanel.Controls.Add(Me.fiveButton)
        Me.calculatorPanel.Controls.Add(Me.eightButton)
        Me.calculatorPanel.Controls.Add(Me.divideButton)
        Me.calculatorPanel.Controls.Add(Me.dotButton)
        Me.calculatorPanel.Controls.Add(Me.oneButton)
        Me.calculatorPanel.Controls.Add(Me.fourButton)
        Me.calculatorPanel.Controls.Add(Me.sevenButton)
        Me.calculatorPanel.Controls.Add(Me.textBox)
        Me.calculatorPanel.Controls.Add(Me.clearButton)
        Me.calculatorPanel.Location = New System.Drawing.Point(79, 61)
        Me.calculatorPanel.Name = "calculatorPanel"
        Me.calculatorPanel.Size = New System.Drawing.Size(525, 588)
        Me.calculatorPanel.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), System.Drawing.Image)
        Me.PictureBox3.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Screw
        Me.PictureBox3.Location = New System.Drawing.Point(487, 554)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Screw
        Me.PictureBox2.Location = New System.Drawing.Point(3, 554)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Screw
        Me.PictureBox1.Location = New System.Drawing.Point(489, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'screw1
        '
        Me.screw1.BackColor = System.Drawing.Color.Transparent
        Me.screw1.ErrorImage = CType(resources.GetObject("screw1.ErrorImage"), System.Drawing.Image)
        Me.screw1.Image = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.Screw
        Me.screw1.Location = New System.Drawing.Point(3, 3)
        Me.screw1.Name = "screw1"
        Me.screw1.Size = New System.Drawing.Size(33, 30)
        Me.screw1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.screw1.TabIndex = 14
        Me.screw1.TabStop = False
        '
        'positiveNegativeConvertButton
        '
        Me.positiveNegativeConvertButton.Font = New System.Drawing.Font("Minecraft", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positiveNegativeConvertButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.positiveNegativeConvertButton.Location = New System.Drawing.Point(54, 469)
        Me.positiveNegativeConvertButton.Name = "positiveNegativeConvertButton"
        Me.positiveNegativeConvertButton.Size = New System.Drawing.Size(83, 59)
        Me.positiveNegativeConvertButton.TabIndex = 26
        Me.positiveNegativeConvertButton.Text = "+/-"
        Me.positiveNegativeConvertButton.UseVisualStyleBackColor = True
        '
        'equalsButton
        '
        Me.equalsButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.equalsButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equalsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.equalsButton.Location = New System.Drawing.Point(394, 469)
        Me.equalsButton.Name = "equalsButton"
        Me.equalsButton.Size = New System.Drawing.Size(83, 59)
        Me.equalsButton.TabIndex = 24
        Me.equalsButton.Text = "="
        Me.equalsButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.addButton.Location = New System.Drawing.Point(394, 389)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(83, 59)
        Me.addButton.TabIndex = 23
        Me.addButton.Text = "+"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtractButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.subtractButton.Location = New System.Drawing.Point(394, 307)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(83, 59)
        Me.subtractButton.TabIndex = 22
        Me.subtractButton.Text = "-"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'backspaceButton
        '
        Me.backspaceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.backspaceButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backspaceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.backspaceButton.Location = New System.Drawing.Point(394, 150)
        Me.backspaceButton.Name = "backspaceButton"
        Me.backspaceButton.Size = New System.Drawing.Size(83, 59)
        Me.backspaceButton.TabIndex = 21
        Me.backspaceButton.Text = "<<"
        Me.backspaceButton.UseVisualStyleBackColor = False
        '
        'moduloButton
        '
        Me.moduloButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moduloButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.moduloButton.Location = New System.Drawing.Point(169, 150)
        Me.moduloButton.Name = "moduloButton"
        Me.moduloButton.Size = New System.Drawing.Size(83, 59)
        Me.moduloButton.TabIndex = 20
        Me.moduloButton.Text = "%"
        Me.moduloButton.UseVisualStyleBackColor = True
        '
        'threeButton
        '
        Me.threeButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.threeButton.Location = New System.Drawing.Point(283, 389)
        Me.threeButton.Name = "threeButton"
        Me.threeButton.Size = New System.Drawing.Size(83, 59)
        Me.threeButton.TabIndex = 19
        Me.threeButton.Text = "3"
        Me.threeButton.UseVisualStyleBackColor = True
        '
        'sixButton
        '
        Me.sixButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sixButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sixButton.Location = New System.Drawing.Point(283, 307)
        Me.sixButton.Name = "sixButton"
        Me.sixButton.Size = New System.Drawing.Size(83, 59)
        Me.sixButton.TabIndex = 18
        Me.sixButton.Text = "6"
        Me.sixButton.UseVisualStyleBackColor = True
        '
        'nineButton
        '
        Me.nineButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nineButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nineButton.Location = New System.Drawing.Point(283, 227)
        Me.nineButton.Name = "nineButton"
        Me.nineButton.Size = New System.Drawing.Size(83, 59)
        Me.nineButton.TabIndex = 17
        Me.nineButton.Text = "9"
        Me.nineButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplyButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.multiplyButton.Location = New System.Drawing.Point(394, 227)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(83, 59)
        Me.multiplyButton.TabIndex = 16
        Me.multiplyButton.Text = "*"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'zeroButton
        '
        Me.zeroButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zeroButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.zeroButton.Location = New System.Drawing.Point(169, 469)
        Me.zeroButton.Name = "zeroButton"
        Me.zeroButton.Size = New System.Drawing.Size(83, 59)
        Me.zeroButton.TabIndex = 15
        Me.zeroButton.Text = "0"
        Me.zeroButton.UseVisualStyleBackColor = True
        '
        'twoButton
        '
        Me.twoButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.twoButton.Location = New System.Drawing.Point(169, 389)
        Me.twoButton.Name = "twoButton"
        Me.twoButton.Size = New System.Drawing.Size(83, 59)
        Me.twoButton.TabIndex = 14
        Me.twoButton.Text = "2"
        Me.twoButton.UseVisualStyleBackColor = True
        '
        'fiveButton
        '
        Me.fiveButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fiveButton.Location = New System.Drawing.Point(169, 307)
        Me.fiveButton.Name = "fiveButton"
        Me.fiveButton.Size = New System.Drawing.Size(83, 59)
        Me.fiveButton.TabIndex = 13
        Me.fiveButton.Text = "5"
        Me.fiveButton.UseVisualStyleBackColor = True
        '
        'eightButton
        '
        Me.eightButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eightButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.eightButton.Location = New System.Drawing.Point(169, 227)
        Me.eightButton.Name = "eightButton"
        Me.eightButton.Size = New System.Drawing.Size(83, 59)
        Me.eightButton.TabIndex = 12
        Me.eightButton.Text = "8"
        Me.eightButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divideButton.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.divideButton.Location = New System.Drawing.Point(280, 150)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(83, 59)
        Me.divideButton.TabIndex = 11
        Me.divideButton.Text = "÷"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'dotButton
        '
        Me.dotButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dotButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dotButton.Location = New System.Drawing.Point(283, 469)
        Me.dotButton.Name = "dotButton"
        Me.dotButton.Size = New System.Drawing.Size(83, 59)
        Me.dotButton.TabIndex = 10
        Me.dotButton.Text = "."
        Me.dotButton.UseVisualStyleBackColor = True
        '
        'oneButton
        '
        Me.oneButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oneButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.oneButton.Location = New System.Drawing.Point(54, 389)
        Me.oneButton.Name = "oneButton"
        Me.oneButton.Size = New System.Drawing.Size(83, 59)
        Me.oneButton.TabIndex = 9
        Me.oneButton.Text = "1"
        Me.oneButton.UseVisualStyleBackColor = True
        '
        'fourButton
        '
        Me.fourButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fourButton.Location = New System.Drawing.Point(54, 307)
        Me.fourButton.Name = "fourButton"
        Me.fourButton.Size = New System.Drawing.Size(83, 59)
        Me.fourButton.TabIndex = 8
        Me.fourButton.Text = "4"
        Me.fourButton.UseVisualStyleBackColor = True
        '
        'sevenButton
        '
        Me.sevenButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sevenButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sevenButton.Location = New System.Drawing.Point(54, 227)
        Me.sevenButton.Name = "sevenButton"
        Me.sevenButton.Size = New System.Drawing.Size(83, 59)
        Me.sevenButton.TabIndex = 7
        Me.sevenButton.Text = "7"
        Me.sevenButton.UseVisualStyleBackColor = True
        '
        'textBox
        '
        Me.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox.Font = New System.Drawing.Font("Minecraft", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox.Location = New System.Drawing.Point(54, 54)
        Me.textBox.Name = "textBox"
        Me.textBox.ReadOnly = True
        Me.textBox.Size = New System.Drawing.Size(423, 60)
        Me.textBox.TabIndex = 6
        Me.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.clearButton.Font = New System.Drawing.Font("Minecraft", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearButton.Location = New System.Drawing.Point(54, 150)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(83, 59)
        Me.clearButton.TabIndex = 0
        Me.clearButton.Text = "C"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROGLLAB_Assignment_1_.My.Resources.Resources.CalcuBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(682, 711)
        Me.Controls.Add(Me.calculatorPanel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.calculatorPanel.ResumeLayout(False)
        Me.calculatorPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.screw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents calculatorPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents screw1 As PictureBox
    Friend WithEvents positiveNegativeConvertButton As Button
    Friend WithEvents equalsButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents subtractButton As Button
    Friend WithEvents backspaceButton As Button
    Friend WithEvents moduloButton As Button
    Friend WithEvents threeButton As Button
    Friend WithEvents sixButton As Button
    Friend WithEvents nineButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents zeroButton As Button
    Friend WithEvents twoButton As Button
    Friend WithEvents fiveButton As Button
    Friend WithEvents eightButton As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents dotButton As Button
    Friend WithEvents oneButton As Button
    Friend WithEvents fourButton As Button
    Friend WithEvents sevenButton As Button
    Friend WithEvents textBox As TextBox
    Friend WithEvents clearButton As Button
End Class
