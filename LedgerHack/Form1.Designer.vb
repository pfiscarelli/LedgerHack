<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LedgerHack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LedgerHack))
        Me.PlainInputTextBox = New System.Windows.Forms.TextBox()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.Key1Label = New System.Windows.Forms.Label()
        Me.Key1TextBox = New System.Windows.Forms.TextBox()
        Me.Key2Label = New System.Windows.Forms.Label()
        Me.Key2TextBox = New System.Windows.Forms.TextBox()
        Me.EncryptButton = New System.Windows.Forms.Button()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.InputHexLabel = New System.Windows.Forms.Label()
        Me.InputHexTextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextLabel = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutputHexTextBox = New System.Windows.Forms.TextBox()
        Me.EncryptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.DecryptRadioButton = New System.Windows.Forms.RadioButton()
        Me.EncryptRadioButton = New System.Windows.Forms.RadioButton()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.HexInputRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextInputRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchWordTextBox = New System.Windows.Forms.TextBox()
        Me.FindKeyButton = New System.Windows.Forms.Button()
        Me.OutputHexTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutputTextBox1 = New System.Windows.Forms.TextBox()
        Me.InputHexTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PlainInputTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OutputHexTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OutputTextBox2 = New System.Windows.Forms.TextBox()
        Me.InputHexTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PlainInputTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OutputHexTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OutputTextBox3 = New System.Windows.Forms.TextBox()
        Me.InputHexTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PlainInputTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.OutputHexTextBox4 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.OutputTextBox4 = New System.Windows.Forms.TextBox()
        Me.InputHexTextBox4 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PlainInputTextBox4 = New System.Windows.Forms.TextBox()
        Me.Work1Button = New System.Windows.Forms.Button()
        Me.Work2Button = New System.Windows.Forms.Button()
        Me.Work3Button = New System.Windows.Forms.Button()
        Me.Work4Button = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.PossibleKeyTextBox = New System.Windows.Forms.TextBox()
        Me.PossibleKeyLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HackProgressBar = New System.Windows.Forms.ProgressBar()
        Me.HackStatusLabel = New System.Windows.Forms.Label()
        Me.EncryptionGroupBox.SuspendLayout()
        Me.InputGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlainInputTextBox
        '
        Me.PlainInputTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PlainInputTextBox.ForeColor = System.Drawing.Color.Chartreuse
        Me.PlainInputTextBox.Location = New System.Drawing.Point(3, 26)
        Me.PlainInputTextBox.Multiline = True
        Me.PlainInputTextBox.Name = "PlainInputTextBox"
        Me.PlainInputTextBox.ReadOnly = True
        Me.PlainInputTextBox.Size = New System.Drawing.Size(460, 59)
        Me.PlainInputTextBox.TabIndex = 0
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Location = New System.Drawing.Point(0, 8)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(77, 15)
        Me.InputLabel.TabIndex = 1
        Me.InputLabel.Text = "Input Text"
        '
        'Key1Label
        '
        Me.Key1Label.AutoSize = True
        Me.Key1Label.Location = New System.Drawing.Point(497, 179)
        Me.Key1Label.Name = "Key1Label"
        Me.Key1Label.Size = New System.Drawing.Size(49, 15)
        Me.Key1Label.TabIndex = 3
        Me.Key1Label.Text = "Key #1"
        '
        'Key1TextBox
        '
        Me.Key1TextBox.Location = New System.Drawing.Point(500, 197)
        Me.Key1TextBox.Name = "Key1TextBox"
        Me.Key1TextBox.Size = New System.Drawing.Size(633, 23)
        Me.Key1TextBox.TabIndex = 2
        Me.Key1TextBox.WordWrap = False
        '
        'Key2Label
        '
        Me.Key2Label.AutoSize = True
        Me.Key2Label.Location = New System.Drawing.Point(497, 230)
        Me.Key2Label.Name = "Key2Label"
        Me.Key2Label.Size = New System.Drawing.Size(49, 15)
        Me.Key2Label.TabIndex = 5
        Me.Key2Label.Text = "Key #2"
        '
        'Key2TextBox
        '
        Me.Key2TextBox.Location = New System.Drawing.Point(500, 246)
        Me.Key2TextBox.Name = "Key2TextBox"
        Me.Key2TextBox.Size = New System.Drawing.Size(633, 23)
        Me.Key2TextBox.TabIndex = 4
        Me.Key2TextBox.WordWrap = False
        '
        'EncryptButton
        '
        Me.EncryptButton.Location = New System.Drawing.Point(828, 75)
        Me.EncryptButton.Name = "EncryptButton"
        Me.EncryptButton.Size = New System.Drawing.Size(75, 23)
        Me.EncryptButton.TabIndex = 6
        Me.EncryptButton.Text = "Encrypt"
        Me.EncryptButton.UseVisualStyleBackColor = True
        '
        'DecryptButton
        '
        Me.DecryptButton.Location = New System.Drawing.Point(909, 75)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(75, 23)
        Me.DecryptButton.TabIndex = 7
        Me.DecryptButton.Text = "Decrypt"
        Me.DecryptButton.UseVisualStyleBackColor = True
        '
        'InputHexLabel
        '
        Me.InputHexLabel.AutoSize = True
        Me.InputHexLabel.Location = New System.Drawing.Point(0, 91)
        Me.InputHexLabel.Name = "InputHexLabel"
        Me.InputHexLabel.Size = New System.Drawing.Size(70, 15)
        Me.InputHexLabel.TabIndex = 9
        Me.InputHexLabel.Text = "Input Hex"
        '
        'InputHexTextBox
        '
        Me.InputHexTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InputHexTextBox.ForeColor = System.Drawing.Color.Chartreuse
        Me.InputHexTextBox.Location = New System.Drawing.Point(3, 109)
        Me.InputHexTextBox.Multiline = True
        Me.InputHexTextBox.Name = "InputHexTextBox"
        Me.InputHexTextBox.Size = New System.Drawing.Size(460, 102)
        Me.InputHexTextBox.TabIndex = 8
        '
        'OutputTextLabel
        '
        Me.OutputTextLabel.AutoSize = True
        Me.OutputTextLabel.Location = New System.Drawing.Point(0, 225)
        Me.OutputTextLabel.Name = "OutputTextLabel"
        Me.OutputTextLabel.Size = New System.Drawing.Size(84, 15)
        Me.OutputTextLabel.TabIndex = 11
        Me.OutputTextLabel.Text = "Output Text"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Cyan
        Me.OutputTextBox.Location = New System.Drawing.Point(3, 243)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(460, 59)
        Me.OutputTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Output Hex"
        '
        'OutputHexTextBox
        '
        Me.OutputHexTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OutputHexTextBox.ForeColor = System.Drawing.Color.Cyan
        Me.OutputHexTextBox.Location = New System.Drawing.Point(3, 338)
        Me.OutputHexTextBox.Multiline = True
        Me.OutputHexTextBox.Name = "OutputHexTextBox"
        Me.OutputHexTextBox.ReadOnly = True
        Me.OutputHexTextBox.Size = New System.Drawing.Size(460, 104)
        Me.OutputHexTextBox.TabIndex = 12
        '
        'EncryptionGroupBox
        '
        Me.EncryptionGroupBox.Controls.Add(Me.DecryptRadioButton)
        Me.EncryptionGroupBox.Controls.Add(Me.EncryptRadioButton)
        Me.EncryptionGroupBox.Location = New System.Drawing.Point(654, 16)
        Me.EncryptionGroupBox.Name = "EncryptionGroupBox"
        Me.EncryptionGroupBox.Size = New System.Drawing.Size(158, 82)
        Me.EncryptionGroupBox.TabIndex = 14
        Me.EncryptionGroupBox.TabStop = False
        Me.EncryptionGroupBox.Text = "Encrypt/Decrypt"
        '
        'DecryptRadioButton
        '
        Me.DecryptRadioButton.AutoSize = True
        Me.DecryptRadioButton.Checked = True
        Me.DecryptRadioButton.Location = New System.Drawing.Point(21, 47)
        Me.DecryptRadioButton.Name = "DecryptRadioButton"
        Me.DecryptRadioButton.Size = New System.Drawing.Size(74, 19)
        Me.DecryptRadioButton.TabIndex = 1
        Me.DecryptRadioButton.TabStop = True
        Me.DecryptRadioButton.Text = "Decrypt"
        Me.DecryptRadioButton.UseVisualStyleBackColor = True
        '
        'EncryptRadioButton
        '
        Me.EncryptRadioButton.AutoSize = True
        Me.EncryptRadioButton.Location = New System.Drawing.Point(21, 22)
        Me.EncryptRadioButton.Name = "EncryptRadioButton"
        Me.EncryptRadioButton.Size = New System.Drawing.Size(74, 19)
        Me.EncryptRadioButton.TabIndex = 0
        Me.EncryptRadioButton.Text = "Encrypt"
        Me.EncryptRadioButton.UseVisualStyleBackColor = True
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.HexInputRadioButton)
        Me.InputGroupBox.Controls.Add(Me.TextInputRadioButton)
        Me.InputGroupBox.Location = New System.Drawing.Point(479, 16)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(158, 82)
        Me.InputGroupBox.TabIndex = 15
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input"
        '
        'HexInputRadioButton
        '
        Me.HexInputRadioButton.AutoSize = True
        Me.HexInputRadioButton.Checked = True
        Me.HexInputRadioButton.Location = New System.Drawing.Point(21, 47)
        Me.HexInputRadioButton.Name = "HexInputRadioButton"
        Me.HexInputRadioButton.Size = New System.Drawing.Size(88, 19)
        Me.HexInputRadioButton.TabIndex = 1
        Me.HexInputRadioButton.TabStop = True
        Me.HexInputRadioButton.Text = "Hex Input"
        Me.HexInputRadioButton.UseVisualStyleBackColor = True
        '
        'TextInputRadioButton
        '
        Me.TextInputRadioButton.AutoSize = True
        Me.TextInputRadioButton.Location = New System.Drawing.Point(21, 22)
        Me.TextInputRadioButton.Name = "TextInputRadioButton"
        Me.TextInputRadioButton.Size = New System.Drawing.Size(95, 19)
        Me.TextInputRadioButton.TabIndex = 0
        Me.TextInputRadioButton.Text = "Text Input"
        Me.TextInputRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search Phrase"
        '
        'SearchWordTextBox
        '
        Me.SearchWordTextBox.Location = New System.Drawing.Point(500, 125)
        Me.SearchWordTextBox.Name = "SearchWordTextBox"
        Me.SearchWordTextBox.Size = New System.Drawing.Size(633, 23)
        Me.SearchWordTextBox.TabIndex = 16
        Me.SearchWordTextBox.WordWrap = False
        '
        'FindKeyButton
        '
        Me.FindKeyButton.Location = New System.Drawing.Point(1139, 125)
        Me.FindKeyButton.Name = "FindKeyButton"
        Me.FindKeyButton.Size = New System.Drawing.Size(75, 23)
        Me.FindKeyButton.TabIndex = 18
        Me.FindKeyButton.Text = "Find Key"
        Me.FindKeyButton.UseVisualStyleBackColor = True
        '
        'OutputHexTextBox1
        '
        Me.OutputHexTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputHexTextBox1.ForeColor = System.Drawing.Color.Cyan
        Me.OutputHexTextBox1.Location = New System.Drawing.Point(3, 343)
        Me.OutputHexTextBox1.Multiline = True
        Me.OutputHexTextBox1.Name = "OutputHexTextBox1"
        Me.OutputHexTextBox1.ReadOnly = True
        Me.OutputHexTextBox1.Size = New System.Drawing.Size(460, 104)
        Me.OutputHexTextBox1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Output Text 1"
        '
        'OutputTextBox1
        '
        Me.OutputTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputTextBox1.ForeColor = System.Drawing.Color.Cyan
        Me.OutputTextBox1.Location = New System.Drawing.Point(3, 248)
        Me.OutputTextBox1.Multiline = True
        Me.OutputTextBox1.Name = "OutputTextBox1"
        Me.OutputTextBox1.ReadOnly = True
        Me.OutputTextBox1.Size = New System.Drawing.Size(460, 59)
        Me.OutputTextBox1.TabIndex = 22
        '
        'InputHexTextBox1
        '
        Me.InputHexTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InputHexTextBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.InputHexTextBox1.Location = New System.Drawing.Point(3, 114)
        Me.InputHexTextBox1.Multiline = True
        Me.InputHexTextBox1.Name = "InputHexTextBox1"
        Me.InputHexTextBox1.ReadOnly = True
        Me.InputHexTextBox1.Size = New System.Drawing.Size(460, 102)
        Me.InputHexTextBox1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Input Text 1"
        '
        'PlainInputTextBox1
        '
        Me.PlainInputTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PlainInputTextBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.PlainInputTextBox1.Location = New System.Drawing.Point(3, 31)
        Me.PlainInputTextBox1.Multiline = True
        Me.PlainInputTextBox1.Name = "PlainInputTextBox1"
        Me.PlainInputTextBox1.ReadOnly = True
        Me.PlainInputTextBox1.Size = New System.Drawing.Size(460, 59)
        Me.PlainInputTextBox1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Input Hex 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Output Hex 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(469, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Output Hex 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(469, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Input Hex 2"
        '
        'OutputHexTextBox2
        '
        Me.OutputHexTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputHexTextBox2.ForeColor = System.Drawing.Color.Cyan
        Me.OutputHexTextBox2.Location = New System.Drawing.Point(472, 343)
        Me.OutputHexTextBox2.Multiline = True
        Me.OutputHexTextBox2.Name = "OutputHexTextBox2"
        Me.OutputHexTextBox2.ReadOnly = True
        Me.OutputHexTextBox2.Size = New System.Drawing.Size(460, 104)
        Me.OutputHexTextBox2.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(469, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Output Text 2"
        '
        'OutputTextBox2
        '
        Me.OutputTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputTextBox2.ForeColor = System.Drawing.Color.Cyan
        Me.OutputTextBox2.Location = New System.Drawing.Point(472, 248)
        Me.OutputTextBox2.Multiline = True
        Me.OutputTextBox2.Name = "OutputTextBox2"
        Me.OutputTextBox2.ReadOnly = True
        Me.OutputTextBox2.Size = New System.Drawing.Size(460, 59)
        Me.OutputTextBox2.TabIndex = 30
        '
        'InputHexTextBox2
        '
        Me.InputHexTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InputHexTextBox2.ForeColor = System.Drawing.Color.LawnGreen
        Me.InputHexTextBox2.Location = New System.Drawing.Point(472, 114)
        Me.InputHexTextBox2.Multiline = True
        Me.InputHexTextBox2.Name = "InputHexTextBox2"
        Me.InputHexTextBox2.ReadOnly = True
        Me.InputHexTextBox2.Size = New System.Drawing.Size(460, 102)
        Me.InputHexTextBox2.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(469, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Input Text 2"
        '
        'PlainInputTextBox2
        '
        Me.PlainInputTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PlainInputTextBox2.ForeColor = System.Drawing.Color.LawnGreen
        Me.PlainInputTextBox2.Location = New System.Drawing.Point(472, 31)
        Me.PlainInputTextBox2.Multiline = True
        Me.PlainInputTextBox2.Name = "PlainInputTextBox2"
        Me.PlainInputTextBox2.ReadOnly = True
        Me.PlainInputTextBox2.Size = New System.Drawing.Size(460, 59)
        Me.PlainInputTextBox2.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(938, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Output Hex 3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(938, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Input Hex 3"
        '
        'OutputHexTextBox3
        '
        Me.OutputHexTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputHexTextBox3.ForeColor = System.Drawing.Color.Cyan
        Me.OutputHexTextBox3.Location = New System.Drawing.Point(941, 343)
        Me.OutputHexTextBox3.Multiline = True
        Me.OutputHexTextBox3.Name = "OutputHexTextBox3"
        Me.OutputHexTextBox3.ReadOnly = True
        Me.OutputHexTextBox3.Size = New System.Drawing.Size(460, 104)
        Me.OutputHexTextBox3.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(938, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Output Text 3"
        '
        'OutputTextBox3
        '
        Me.OutputTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputTextBox3.ForeColor = System.Drawing.Color.Cyan
        Me.OutputTextBox3.Location = New System.Drawing.Point(941, 248)
        Me.OutputTextBox3.Multiline = True
        Me.OutputTextBox3.Name = "OutputTextBox3"
        Me.OutputTextBox3.ReadOnly = True
        Me.OutputTextBox3.Size = New System.Drawing.Size(460, 59)
        Me.OutputTextBox3.TabIndex = 38
        '
        'InputHexTextBox3
        '
        Me.InputHexTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InputHexTextBox3.ForeColor = System.Drawing.Color.LawnGreen
        Me.InputHexTextBox3.Location = New System.Drawing.Point(941, 114)
        Me.InputHexTextBox3.Multiline = True
        Me.InputHexTextBox3.Name = "InputHexTextBox3"
        Me.InputHexTextBox3.ReadOnly = True
        Me.InputHexTextBox3.Size = New System.Drawing.Size(460, 102)
        Me.InputHexTextBox3.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(938, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 15)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Input Text 3"
        '
        'PlainInputTextBox3
        '
        Me.PlainInputTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PlainInputTextBox3.ForeColor = System.Drawing.Color.LawnGreen
        Me.PlainInputTextBox3.Location = New System.Drawing.Point(941, 31)
        Me.PlainInputTextBox3.Multiline = True
        Me.PlainInputTextBox3.Name = "PlainInputTextBox3"
        Me.PlainInputTextBox3.ReadOnly = True
        Me.PlainInputTextBox3.Size = New System.Drawing.Size(460, 59)
        Me.PlainInputTextBox3.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1407, 325)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 15)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Output Hex 4"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1407, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Input Hex 4"
        '
        'OutputHexTextBox4
        '
        Me.OutputHexTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputHexTextBox4.ForeColor = System.Drawing.Color.Cyan
        Me.OutputHexTextBox4.Location = New System.Drawing.Point(1410, 343)
        Me.OutputHexTextBox4.Multiline = True
        Me.OutputHexTextBox4.Name = "OutputHexTextBox4"
        Me.OutputHexTextBox4.ReadOnly = True
        Me.OutputHexTextBox4.Size = New System.Drawing.Size(460, 104)
        Me.OutputHexTextBox4.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1407, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 15)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Output Text 4"
        '
        'OutputTextBox4
        '
        Me.OutputTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OutputTextBox4.ForeColor = System.Drawing.Color.Cyan
        Me.OutputTextBox4.Location = New System.Drawing.Point(1410, 248)
        Me.OutputTextBox4.Multiline = True
        Me.OutputTextBox4.Name = "OutputTextBox4"
        Me.OutputTextBox4.ReadOnly = True
        Me.OutputTextBox4.Size = New System.Drawing.Size(460, 59)
        Me.OutputTextBox4.TabIndex = 46
        '
        'InputHexTextBox4
        '
        Me.InputHexTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InputHexTextBox4.ForeColor = System.Drawing.Color.LawnGreen
        Me.InputHexTextBox4.Location = New System.Drawing.Point(1410, 114)
        Me.InputHexTextBox4.Multiline = True
        Me.InputHexTextBox4.Name = "InputHexTextBox4"
        Me.InputHexTextBox4.ReadOnly = True
        Me.InputHexTextBox4.Size = New System.Drawing.Size(460, 102)
        Me.InputHexTextBox4.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1407, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 15)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Input Text 4"
        '
        'PlainInputTextBox4
        '
        Me.PlainInputTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PlainInputTextBox4.ForeColor = System.Drawing.Color.LawnGreen
        Me.PlainInputTextBox4.Location = New System.Drawing.Point(1410, 31)
        Me.PlainInputTextBox4.Multiline = True
        Me.PlainInputTextBox4.Name = "PlainInputTextBox4"
        Me.PlainInputTextBox4.ReadOnly = True
        Me.PlainInputTextBox4.Size = New System.Drawing.Size(460, 59)
        Me.PlainInputTextBox4.TabIndex = 43
        '
        'Work1Button
        '
        Me.Work1Button.Location = New System.Drawing.Point(388, 5)
        Me.Work1Button.Name = "Work1Button"
        Me.Work1Button.Size = New System.Drawing.Size(75, 23)
        Me.Work1Button.TabIndex = 51
        Me.Work1Button.Text = "Copy 1"
        Me.Work1Button.UseVisualStyleBackColor = True
        '
        'Work2Button
        '
        Me.Work2Button.Location = New System.Drawing.Point(857, 5)
        Me.Work2Button.Name = "Work2Button"
        Me.Work2Button.Size = New System.Drawing.Size(75, 23)
        Me.Work2Button.TabIndex = 52
        Me.Work2Button.Text = "Copy 2"
        Me.Work2Button.UseVisualStyleBackColor = True
        '
        'Work3Button
        '
        Me.Work3Button.Location = New System.Drawing.Point(1326, 5)
        Me.Work3Button.Name = "Work3Button"
        Me.Work3Button.Size = New System.Drawing.Size(75, 23)
        Me.Work3Button.TabIndex = 53
        Me.Work3Button.Text = "Copy 3"
        Me.Work3Button.UseVisualStyleBackColor = True
        '
        'Work4Button
        '
        Me.Work4Button.Location = New System.Drawing.Point(1795, 5)
        Me.Work4Button.Name = "Work4Button"
        Me.Work4Button.Size = New System.Drawing.Size(75, 23)
        Me.Work4Button.TabIndex = 54
        Me.Work4Button.Text = "Copy 4"
        Me.Work4Button.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(1139, 197)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(75, 23)
        Me.CopyButton.TabIndex = 55
        Me.CopyButton.Text = "<<< Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'PossibleKeyTextBox
        '
        Me.PossibleKeyTextBox.Location = New System.Drawing.Point(1220, 197)
        Me.PossibleKeyTextBox.Name = "PossibleKeyTextBox"
        Me.PossibleKeyTextBox.ReadOnly = True
        Me.PossibleKeyTextBox.Size = New System.Drawing.Size(633, 23)
        Me.PossibleKeyTextBox.TabIndex = 56
        Me.PossibleKeyTextBox.WordWrap = False
        '
        'PossibleKeyLabel
        '
        Me.PossibleKeyLabel.AutoSize = True
        Me.PossibleKeyLabel.Location = New System.Drawing.Point(1220, 179)
        Me.PossibleKeyLabel.Name = "PossibleKeyLabel"
        Me.PossibleKeyLabel.Size = New System.Drawing.Size(98, 15)
        Me.PossibleKeyLabel.TabIndex = 57
        Me.PossibleKeyLabel.Text = "Possible Key?"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.OutputHexTextBox)
        Me.Panel1.Controls.Add(Me.OutputTextLabel)
        Me.Panel1.Controls.Add(Me.OutputTextBox)
        Me.Panel1.Controls.Add(Me.InputHexLabel)
        Me.Panel1.Controls.Add(Me.InputHexTextBox)
        Me.Panel1.Controls.Add(Me.InputLabel)
        Me.Panel1.Controls.Add(Me.PlainInputTextBox)
        Me.Panel1.Location = New System.Drawing.Point(5, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 452)
        Me.Panel1.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Work4Button)
        Me.Panel2.Controls.Add(Me.Work3Button)
        Me.Panel2.Controls.Add(Me.Work2Button)
        Me.Panel2.Controls.Add(Me.Work1Button)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.OutputHexTextBox4)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.OutputTextBox4)
        Me.Panel2.Controls.Add(Me.InputHexTextBox4)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.PlainInputTextBox4)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.OutputHexTextBox3)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.OutputTextBox3)
        Me.Panel2.Controls.Add(Me.InputHexTextBox3)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.PlainInputTextBox3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.OutputHexTextBox2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.OutputTextBox2)
        Me.Panel2.Controls.Add(Me.InputHexTextBox2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.PlainInputTextBox2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.OutputHexTextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.OutputTextBox1)
        Me.Panel2.Controls.Add(Me.InputHexTextBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PlainInputTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(5, 469)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1874, 456)
        Me.Panel2.TabIndex = 59
        '
        'HackProgressBar
        '
        Me.HackProgressBar.BackColor = System.Drawing.SystemColors.Control
        Me.HackProgressBar.Location = New System.Drawing.Point(1271, 125)
        Me.HackProgressBar.Name = "HackProgressBar"
        Me.HackProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.HackProgressBar.TabIndex = 60
        Me.HackProgressBar.Visible = False
        '
        'HackStatusLabel
        '
        Me.HackStatusLabel.AutoSize = True
        Me.HackStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.HackStatusLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HackStatusLabel.Location = New System.Drawing.Point(1220, 127)
        Me.HackStatusLabel.Name = "HackStatusLabel"
        Me.HackStatusLabel.Size = New System.Drawing.Size(81, 19)
        Me.HackStatusLabel.TabIndex = 61
        Me.HackStatusLabel.Text = "Ready..."
        Me.HackStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LedgerHack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1882, 938)
        Me.Controls.Add(Me.HackStatusLabel)
        Me.Controls.Add(Me.HackProgressBar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PossibleKeyLabel)
        Me.Controls.Add(Me.PossibleKeyTextBox)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.FindKeyButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchWordTextBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.EncryptionGroupBox)
        Me.Controls.Add(Me.DecryptButton)
        Me.Controls.Add(Me.EncryptButton)
        Me.Controls.Add(Me.Key2Label)
        Me.Controls.Add(Me.Key2TextBox)
        Me.Controls.Add(Me.Key1Label)
        Me.Controls.Add(Me.Key1TextBox)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LedgerHack"
        Me.Text = "Ledger Hack"
        Me.EncryptionGroupBox.ResumeLayout(False)
        Me.EncryptionGroupBox.PerformLayout()
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlainInputTextBox As TextBox
    Friend WithEvents InputLabel As Label
    Friend WithEvents Key1Label As Label
    Friend WithEvents Key1TextBox As TextBox
    Friend WithEvents Key2Label As Label
    Friend WithEvents Key2TextBox As TextBox
    Friend WithEvents EncryptButton As Button
    Friend WithEvents DecryptButton As Button
    Friend WithEvents InputHexLabel As Label
    Friend WithEvents InputHexTextBox As TextBox
    Friend WithEvents OutputTextLabel As Label
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OutputHexTextBox As TextBox
    Friend WithEvents EncryptionGroupBox As GroupBox
    Friend WithEvents DecryptRadioButton As RadioButton
    Friend WithEvents EncryptRadioButton As RadioButton
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents HexInputRadioButton As RadioButton
    Friend WithEvents TextInputRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchWordTextBox As TextBox
    Friend WithEvents FindKeyButton As Button
    Friend WithEvents OutputHexTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OutputTextBox1 As TextBox
    Friend WithEvents InputHexTextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PlainInputTextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents OutputHexTextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OutputTextBox2 As TextBox
    Friend WithEvents InputHexTextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PlainInputTextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents OutputHexTextBox3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents OutputTextBox3 As TextBox
    Friend WithEvents InputHexTextBox3 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PlainInputTextBox3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents OutputHexTextBox4 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents OutputTextBox4 As TextBox
    Friend WithEvents InputHexTextBox4 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents PlainInputTextBox4 As TextBox
    Friend WithEvents Work1Button As Button
    Friend WithEvents Work2Button As Button
    Friend WithEvents Work3Button As Button
    Friend WithEvents Work4Button As Button
    Friend WithEvents CopyButton As Button
    Friend WithEvents PossibleKeyTextBox As TextBox
    Friend WithEvents PossibleKeyLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HackProgressBar As ProgressBar
    Friend WithEvents HackStatusLabel As Label
End Class
