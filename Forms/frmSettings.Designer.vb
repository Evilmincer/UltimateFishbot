<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtFishWait = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLootingDelay = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCastDelay = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtRetries = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDelay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtScanSteps = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblAudioLevel = New System.Windows.Forms.Label()
        Me.pgbSoundLevel = New System.Windows.Forms.ProgressBar()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbAudio = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSplash = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBaitKey7 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtBaitKey6 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtBaitKey5 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBaitKey4 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtBaitKey3 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBaitKey2 = New System.Windows.Forms.TextBox()
        Me.cbShiftLoot = New System.Windows.Forms.CheckBox()
        Me.cbApplyCharm = New System.Windows.Forms.CheckBox()
        Me.cbApplyRaft = New System.Windows.Forms.CheckBox()
        Me.txtCharmKey = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtRaftKey = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtHearthTime = New System.Windows.Forms.TextBox()
        Me.cbAlt = New System.Windows.Forms.CheckBox()
        Me.cbHearth = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtProcName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbAutoLure = New System.Windows.Forms.CheckBox()
        Me.txtHearthKey = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLureKey = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFishKey = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBaitKey1 = New System.Windows.Forms.TextBox()
        Me.cbAutoBait = New System.Windows.Forms.CheckBox()
        Me.tmeAudio = New System.Windows.Forms.Timer(Me.components)
        Me.cbRandomBait = New System.Windows.Forms.CheckBox()
        Me.tabSettings.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(130, 341)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(228, 341)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.TabPage2)
        Me.tabSettings.Controls.Add(Me.TabPage1)
        Me.tabSettings.Controls.Add(Me.TabPage3)
        Me.tabSettings.Controls.Add(Me.TabPage4)
        Me.tabSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabSettings.Location = New System.Drawing.Point(0, 0)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(460, 335)
        Me.tabSettings.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtFishWait)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtLootingDelay)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtCastDelay)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 357)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General Fishing"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtFishWait
        '
        Me.txtFishWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFishWait.Location = New System.Drawing.Point(131, 77)
        Me.txtFishWait.Name = "txtFishWait"
        Me.txtFishWait.Size = New System.Drawing.Size(53, 20)
        Me.txtFishWait.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(423, 31)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "The number of milliseconds to listen for a fish before giving up. Too long decrea" & _
    "se bots effectiveness, too short and you miss fish."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Delay After Looting:"
        '
        'txtLootingDelay
        '
        Me.txtLootingDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLootingDelay.Location = New System.Drawing.Point(131, 141)
        Me.txtLootingDelay.Name = "txtLootingDelay"
        Me.txtLootingDelay.Size = New System.Drawing.Size(53, 20)
        Me.txtLootingDelay.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(423, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "The number of milliseconds to wait after looting a fish."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Fish Wait Limit:"
        '
        'txtCastDelay
        '
        Me.txtCastDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCastDelay.Location = New System.Drawing.Point(131, 12)
        Me.txtCastDelay.Name = "txtCastDelay"
        Me.txtCastDelay.Size = New System.Drawing.Size(53, 20)
        Me.txtCastDelay.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(423, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "The number of milliseconds to wait after the cast before searching. Too short and" & _
    " you'll skip the bobber, too long and you'll waste time."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Delay After Cast:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtRetries)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtDelay)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtScanSteps)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Finding The Cursor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtRetries
        '
        Me.txtRetries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetries.Location = New System.Drawing.Point(112, 131)
        Me.txtRetries.Name = "txtRetries"
        Me.txtRetries.Size = New System.Drawing.Size(32, 20)
        Me.txtRetries.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "How many times to run the search pattern."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Scanning Retries:"
        '
        'txtDelay
        '
        Me.txtDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay.Location = New System.Drawing.Point(112, 70)
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(32, 20)
        Me.txtDelay.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(423, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "The number of milliseconds to wait before checking if the cursor has changed.  To" & _
    " slow and you might not detect the bobber; but a bigger number goes slower."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Scanning Delay:"
        '
        'txtScanSteps
        '
        Me.txtScanSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScanSteps.Location = New System.Drawing.Point(112, 7)
        Me.txtScanSteps.Name = "txtScanSteps"
        Me.txtScanSteps.Size = New System.Drawing.Size(32, 20)
        Me.txtScanSteps.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 31)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "The greater number of steps, the less likely you are to miss the cursor; but the " & _
    "slower your scan will be."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Scanning Steps:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblAudioLevel)
        Me.TabPage3.Controls.Add(Me.pgbSoundLevel)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.cmbAudio)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.txtSplash)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(452, 357)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hearing The Fish"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblAudioLevel
        '
        Me.lblAudioLevel.AutoSize = True
        Me.lblAudioLevel.Location = New System.Drawing.Point(421, 76)
        Me.lblAudioLevel.Name = "lblAudioLevel"
        Me.lblAudioLevel.Size = New System.Drawing.Size(13, 13)
        Me.lblAudioLevel.TabIndex = 19
        Me.lblAudioLevel.Text = "0"
        '
        'pgbSoundLevel
        '
        Me.pgbSoundLevel.Location = New System.Drawing.Point(219, 73)
        Me.pgbSoundLevel.Name = "pgbSoundLevel"
        Me.pgbSoundLevel.Size = New System.Drawing.Size(182, 21)
        Me.pgbSoundLevel.TabIndex = 18
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 97)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(423, 46)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Select the audio device that WoW is Using.  If the bot cannot 'hear' the game, it" & _
    " will never catch any fish.  If you are unsure, play some music and select each " & _
    "device until you find the right one." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbAudio
        '
        Me.cmbAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAudio.FormattingEnabled = True
        Me.cmbAudio.Items.AddRange(New Object() {"Default"})
        Me.cmbAudio.Location = New System.Drawing.Point(102, 73)
        Me.cmbAudio.Name = "cmbAudio"
        Me.cmbAudio.Size = New System.Drawing.Size(99, 21)
        Me.cmbAudio.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 13)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Audio Device:"
        '
        'txtSplash
        '
        Me.txtSplash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSplash.Location = New System.Drawing.Point(117, 6)
        Me.txtSplash.Name = "txtSplash"
        Me.txtSplash.Size = New System.Drawing.Size(32, 20)
        Me.txtSplash.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(423, 31)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Determines if a given sound is loud enough to be a fish or not.  Too low and the " & _
    "bot will mistake non-fish for fish.  Too high and the bot will ignore the real f" & _
    "ish."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Splash Threshold:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cbRandomBait)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.txtBaitKey7)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.txtBaitKey6)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Controls.Add(Me.txtBaitKey5)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.txtBaitKey4)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.txtBaitKey3)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.txtBaitKey2)
        Me.TabPage4.Controls.Add(Me.cbShiftLoot)
        Me.TabPage4.Controls.Add(Me.cbApplyCharm)
        Me.TabPage4.Controls.Add(Me.cbApplyRaft)
        Me.TabPage4.Controls.Add(Me.txtCharmKey)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.txtRaftKey)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.txtHearthTime)
        Me.TabPage4.Controls.Add(Me.cbAlt)
        Me.TabPage4.Controls.Add(Me.cbHearth)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.txtProcName)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.cbAutoLure)
        Me.TabPage4.Controls.Add(Me.txtHearthKey)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.txtLureKey)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.txtFishKey)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.txtBaitKey1)
        Me.TabPage4.Controls.Add(Me.cbAutoBait)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(452, 309)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Premium Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(144, 115)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 13)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "WoD Bait Key 7:"
        '
        'txtBaitKey7
        '
        Me.txtBaitKey7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey7.Location = New System.Drawing.Point(244, 112)
        Me.txtBaitKey7.Name = "txtBaitKey7"
        Me.txtBaitKey7.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey7.TabIndex = 46
        Me.txtBaitKey7.Text = "="
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(144, 93)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(101, 13)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "WoD Bait Key 6:"
        '
        'txtBaitKey6
        '
        Me.txtBaitKey6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey6.Location = New System.Drawing.Point(244, 90)
        Me.txtBaitKey6.Name = "txtBaitKey6"
        Me.txtBaitKey6.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey6.TabIndex = 44
        Me.txtBaitKey6.Text = ")"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(144, 71)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(101, 13)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "WoD Bait Key 5:"
        '
        'txtBaitKey5
        '
        Me.txtBaitKey5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey5.Location = New System.Drawing.Point(244, 68)
        Me.txtBaitKey5.Name = "txtBaitKey5"
        Me.txtBaitKey5.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey5.TabIndex = 42
        Me.txtBaitKey5.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 115)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(101, 13)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "WoD Bait Key 4:"
        '
        'txtBaitKey4
        '
        Me.txtBaitKey4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey4.Location = New System.Drawing.Point(108, 112)
        Me.txtBaitKey4.Name = "txtBaitKey4"
        Me.txtBaitKey4.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey4.TabIndex = 40
        Me.txtBaitKey4.Text = "9"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 93)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(101, 13)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "WoD Bait Key 3:"
        '
        'txtBaitKey3
        '
        Me.txtBaitKey3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey3.Location = New System.Drawing.Point(108, 90)
        Me.txtBaitKey3.Name = "txtBaitKey3"
        Me.txtBaitKey3.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey3.TabIndex = 38
        Me.txtBaitKey3.Text = "8"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 71)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "WoD Bait Key 2:"
        '
        'txtBaitKey2
        '
        Me.txtBaitKey2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey2.Location = New System.Drawing.Point(108, 68)
        Me.txtBaitKey2.Name = "txtBaitKey2"
        Me.txtBaitKey2.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey2.TabIndex = 36
        Me.txtBaitKey2.Text = "7"
        '
        'cbShiftLoot
        '
        Me.cbShiftLoot.AutoSize = True
        Me.cbShiftLoot.Location = New System.Drawing.Point(11, 229)
        Me.cbShiftLoot.Name = "cbShiftLoot"
        Me.cbShiftLoot.Size = New System.Drawing.Size(254, 17)
        Me.cbShiftLoot.TabIndex = 34
        Me.cbShiftLoot.Text = "Shift-Loot? (If AutoLoot is Disabled, Enable This)"
        Me.cbShiftLoot.UseVisualStyleBackColor = True
        '
        'cbApplyCharm
        '
        Me.cbApplyCharm.AutoSize = True
        Me.cbApplyCharm.Location = New System.Drawing.Point(201, 185)
        Me.cbApplyCharm.Name = "cbApplyCharm"
        Me.cbApplyCharm.Size = New System.Drawing.Size(180, 17)
        Me.cbApplyCharm.TabIndex = 33
        Me.cbApplyCharm.Text = "Refresh Charm Every 60 minutes"
        Me.cbApplyCharm.UseVisualStyleBackColor = True
        '
        'cbApplyRaft
        '
        Me.cbApplyRaft.AutoSize = True
        Me.cbApplyRaft.Location = New System.Drawing.Point(11, 185)
        Me.cbApplyRaft.Name = "cbApplyRaft"
        Me.cbApplyRaft.Size = New System.Drawing.Size(164, 17)
        Me.cbApplyRaft.TabIndex = 32
        Me.cbApplyRaft.Text = "Refresh Raft Every 8 minutes"
        Me.cbApplyRaft.UseVisualStyleBackColor = True
        '
        'txtCharmKey
        '
        Me.txtCharmKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharmKey.Location = New System.Drawing.Point(240, 38)
        Me.txtCharmKey.Name = "txtCharmKey"
        Me.txtCharmKey.Size = New System.Drawing.Size(22, 20)
        Me.txtCharmKey.TabIndex = 31
        Me.txtCharmKey.Text = "5"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(134, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 13)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "MoP Charm Key:"
        '
        'txtRaftKey
        '
        Me.txtRaftKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaftKey.Location = New System.Drawing.Point(100, 38)
        Me.txtRaftKey.Name = "txtRaftKey"
        Me.txtRaftKey.Size = New System.Drawing.Size(22, 20)
        Me.txtRaftKey.TabIndex = 29
        Me.txtRaftKey.Text = "4"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "MoP Raft Key:"
        '
        'txtHearthTime
        '
        Me.txtHearthTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHearthTime.Location = New System.Drawing.Point(377, 160)
        Me.txtHearthTime.Name = "txtHearthTime"
        Me.txtHearthTime.Size = New System.Drawing.Size(30, 20)
        Me.txtHearthTime.TabIndex = 27
        Me.txtHearthTime.Text = "3"
        '
        'cbAlt
        '
        Me.cbAlt.AutoSize = True
        Me.cbAlt.Location = New System.Drawing.Point(325, 18)
        Me.cbAlt.Name = "cbAlt"
        Me.cbAlt.Size = New System.Drawing.Size(119, 17)
        Me.cbAlt.TabIndex = 6
        Me.cbAlt.Text = "Use Alt-Key Modifer"
        Me.cbAlt.UseVisualStyleBackColor = True
        '
        'cbHearth
        '
        Me.cbHearth.AutoSize = True
        Me.cbHearth.Location = New System.Drawing.Point(201, 163)
        Me.cbHearth.Name = "cbHearth"
        Me.cbHearth.Size = New System.Drawing.Size(170, 17)
        Me.cbHearth.TabIndex = 8
        Me.cbHearth.Text = "Hearth To Inn After X Minutes:"
        Me.cbHearth.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 135)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(423, 17)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Customize shortkeys to avoid rearranging your bars before/after fishing."
        '
        'txtProcName
        '
        Me.txtProcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcName.Location = New System.Drawing.Point(141, 256)
        Me.txtProcName.Name = "txtProcName"
        Me.txtProcName.Size = New System.Drawing.Size(255, 20)
        Me.txtProcName.TabIndex = 9
        Me.txtProcName.Text = "Wow-64"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 278)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(423, 31)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "The name of the process to activate (this rarely changes) but has been updated wi" & _
    "th new expansions in the past."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 259)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "WoW Process Name:"
        '
        'cbAutoLure
        '
        Me.cbAutoLure.AutoSize = True
        Me.cbAutoLure.Location = New System.Drawing.Point(11, 163)
        Me.cbAutoLure.Name = "cbAutoLure"
        Me.cbAutoLure.Size = New System.Drawing.Size(160, 17)
        Me.cbAutoLure.TabIndex = 7
        Me.cbAutoLure.Text = "Apply Lure Every 10 minutes"
        Me.cbAutoLure.UseVisualStyleBackColor = True
        '
        'txtHearthKey
        '
        Me.txtHearthKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHearthKey.Location = New System.Drawing.Point(275, 16)
        Me.txtHearthKey.Name = "txtHearthKey"
        Me.txtHearthKey.Size = New System.Drawing.Size(22, 20)
        Me.txtHearthKey.TabIndex = 3
        Me.txtHearthKey.Text = "3"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(195, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Hearth Key:"
        '
        'txtLureKey
        '
        Me.txtLureKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLureKey.Location = New System.Drawing.Point(167, 16)
        Me.txtLureKey.Name = "txtLureKey"
        Me.txtLureKey.Size = New System.Drawing.Size(22, 20)
        Me.txtLureKey.TabIndex = 2
        Me.txtLureKey.Text = "2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(100, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Lure Key:"
        '
        'txtFishKey
        '
        Me.txtFishKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFishKey.Location = New System.Drawing.Point(72, 16)
        Me.txtFishKey.Name = "txtFishKey"
        Me.txtFishKey.Size = New System.Drawing.Size(22, 20)
        Me.txtFishKey.TabIndex = 1
        Me.txtFishKey.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Cast Key:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(270, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 13)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "WoD Bait Key 1:"
        '
        'txtBaitKey1
        '
        Me.txtBaitKey1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaitKey1.Location = New System.Drawing.Point(370, 38)
        Me.txtBaitKey1.Name = "txtBaitKey1"
        Me.txtBaitKey1.Size = New System.Drawing.Size(22, 20)
        Me.txtBaitKey1.TabIndex = 29
        Me.txtBaitKey1.Text = "6"
        '
        'cbAutoBait
        '
        Me.cbAutoBait.AutoSize = True
        Me.cbAutoBait.Location = New System.Drawing.Point(11, 207)
        Me.cbAutoBait.Name = "cbAutoBait"
        Me.cbAutoBait.Size = New System.Drawing.Size(151, 17)
        Me.cbAutoBait.TabIndex = 32
        Me.cbAutoBait.Text = "Apply Bait Every 5 minutes"
        Me.cbAutoBait.UseVisualStyleBackColor = True
        '
        'tmeAudio
        '
        Me.tmeAudio.Interval = 250
        '
        'cbRandomBait
        '
        Me.cbRandomBait.AutoSize = True
        Me.cbRandomBait.Location = New System.Drawing.Point(201, 206)
        Me.cbRandomBait.Name = "cbRandomBait"
        Me.cbRandomBait.Size = New System.Drawing.Size(203, 17)
        Me.cbRandomBait.TabIndex = 48
        Me.cbRandomBait.Text = "Random bait between the 7 possibles"
        Me.cbRandomBait.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 370)
        Me.Controls.Add(Me.tabSettings)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Customize Settings"
        Me.TopMost = True
        Me.tabSettings.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tabSettings As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtCastDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtRetries As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScanSteps As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLootingDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFishWait As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtSplash As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtHearthKey As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLureKey As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFishKey As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbAutoLure As System.Windows.Forms.CheckBox
    Friend WithEvents cbAlt As System.Windows.Forms.CheckBox
    Friend WithEvents cbHearth As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtProcName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtHearthTime As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRaftKey As System.Windows.Forms.TextBox
    Friend WithEvents txtCharmKey As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbApplyCharm As System.Windows.Forms.CheckBox
    Friend WithEvents cbApplyRaft As System.Windows.Forms.CheckBox
    Friend WithEvents cbShiftLoot As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey1 As System.Windows.Forms.TextBox
    Friend WithEvents cbAutoBait As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbAudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblAudioLevel As System.Windows.Forms.Label
    Friend WithEvents pgbSoundLevel As System.Windows.Forms.ProgressBar
    Friend WithEvents tmeAudio As System.Windows.Forms.Timer
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey3 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey2 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey7 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey6 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey5 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtBaitKey4 As System.Windows.Forms.TextBox
    Friend WithEvents cbRandomBait As System.Windows.Forms.CheckBox
End Class
