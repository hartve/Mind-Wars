﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartScreen))
        Me.PicStartButton_Settings = New System.Windows.Forms.PictureBox()
        Me.LabSettings = New System.Windows.Forms.Label()
        Me.LabPvE = New System.Windows.Forms.Label()
        Me.PicStartButton_PvE = New System.Windows.Forms.PictureBox()
        Me.LabPvPLan = New System.Windows.Forms.Label()
        Me.PicStartButton_PvPLan = New System.Windows.Forms.PictureBox()
        Me.LabPvPHTTP = New System.Windows.Forms.Label()
        Me.PicStartButton_PvPHTTP = New System.Windows.Forms.PictureBox()
        Me.LabTutorial = New System.Windows.Forms.Label()
        Me.PicStartButton_Tutorial = New System.Windows.Forms.PictureBox()
        Me.PanelSettings = New System.Windows.Forms.Panel()
        Me.cmdTestTheme = New System.Windows.Forms.Button()
        Me.ThemeComboBox = New System.Windows.Forms.ComboBox()
        Me.PanelSound = New System.Windows.Forms.Panel()
        Me.PicSound3 = New System.Windows.Forms.PictureBox()
        Me.PicSound2 = New System.Windows.Forms.PictureBox()
        Me.PicSound1 = New System.Windows.Forms.PictureBox()
        Me.LabSettingsSound = New System.Windows.Forms.Label()
        Me.PicSettingSound = New System.Windows.Forms.PictureBox()
        Me.PanelTheme = New System.Windows.Forms.Panel()
        Me.PicTheme3 = New System.Windows.Forms.PictureBox()
        Me.PicTheme2 = New System.Windows.Forms.PictureBox()
        Me.PicTheme1 = New System.Windows.Forms.PictureBox()
        Me.LabSettingsTheme = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicSettingsTheme = New System.Windows.Forms.PictureBox()
        Me.PicCloseSettings = New System.Windows.Forms.PictureBox()
        Me.PanelPvE = New System.Windows.Forms.Panel()
        Me.LabPvEStart = New System.Windows.Forms.Label()
        Me.PicPvEStartGame = New System.Windows.Forms.PictureBox()
        Me.LabPvEColors = New System.Windows.Forms.Label()
        Me.LabPvENumberOfAttempts = New System.Windows.Forms.Label()
        Me.LabPvENumberOfAttemptsButton = New System.Windows.Forms.Label()
        Me.LabPvENumberOfHoles = New System.Windows.Forms.Label()
        Me.LabPvENumberOfHolesButton = New System.Windows.Forms.Label()
        Me.PicPvEChooseAttempts = New System.Windows.Forms.PictureBox()
        Me.PicPvEChooseHoles = New System.Windows.Forms.PictureBox()
        Me.PanelPvEColors = New System.Windows.Forms.Panel()
        Me.PicPvEColor8 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor7 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor6 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor5 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor4 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor3 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor2 = New System.Windows.Forms.PictureBox()
        Me.PicPvEColor1 = New System.Windows.Forms.PictureBox()
        Me.PicPvEChooseColors = New System.Windows.Forms.PictureBox()
        Me.PvEDifficultyPanel = New System.Windows.Forms.Panel()
        Me.PicDifficulty2 = New System.Windows.Forms.PictureBox()
        Me.PicDifficulty3 = New System.Windows.Forms.PictureBox()
        Me.PicDifficulty1 = New System.Windows.Forms.PictureBox()
        Me.LabPvEEasy = New System.Windows.Forms.Label()
        Me.LabPvEHard = New System.Windows.Forms.Label()
        Me.LabPvEImpossible = New System.Windows.Forms.Label()
        Me.PicClosePvE = New System.Windows.Forms.PictureBox()
        Me.PanelPvPLan = New System.Windows.Forms.Panel()
        Me.PicClosePvPLAN = New System.Windows.Forms.PictureBox()
        Me.PanelPvPHTTP = New System.Windows.Forms.Panel()
        Me.PicClosePvPHTTP = New System.Windows.Forms.PictureBox()
        Me.LabHTTPCreate = New System.Windows.Forms.Label()
        Me.LabHTTPJoin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.LabHTTPConnect = New System.Windows.Forms.Label()
        Me.LabCode = New System.Windows.Forms.Label()
        Me.cmdNewPublicGame = New System.Windows.Forms.Button()
        Me.cmdNewPrivateGame = New System.Windows.Forms.Button()
        Me.cmdConnectHTTP = New System.Windows.Forms.Button()
        Me.PanelTutorial = New System.Windows.Forms.Panel()
        Me.PicCloseTutorial = New System.Windows.Forms.PictureBox()
        Me.PicFormHeader = New System.Windows.Forms.PictureBox()
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.PicMinimizeForm = New System.Windows.Forms.PictureBox()
        Me.PicCloseForm = New System.Windows.Forms.PictureBox()
        Me.GUITimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HTTPBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.HeaderTransparencyLeft = New System.Windows.Forms.PictureBox()
        Me.HeaderTransparencyRight = New System.Windows.Forms.PictureBox()
        Me.JoinBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelPvP2 = New System.Windows.Forms.Panel()
        Me.HTTPCreateGamePanel = New System.Windows.Forms.Panel()
        Me.LabHTTPCreate2 = New System.Windows.Forms.Label()
        Me.LabHTTPAttempts = New System.Windows.Forms.Label()
        Me.LabHTTPAttemptsCaption = New System.Windows.Forms.Label()
        Me.PicHTTPAttempts = New System.Windows.Forms.PictureBox()
        Me.LabHTTPHoles = New System.Windows.Forms.Label()
        Me.LabHTTPHolesCaption = New System.Windows.Forms.Label()
        Me.PicHTTPHoles = New System.Windows.Forms.PictureBox()
        Me.HTTPColorsPanel = New System.Windows.Forms.Panel()
        Me.HTTPCol8 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol7 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol6 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol5 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol4 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol3 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol2 = New System.Windows.Forms.PictureBox()
        Me.HTTPCol1 = New System.Windows.Forms.PictureBox()
        Me.LabHTTPColors2 = New System.Windows.Forms.Label()
        Me.LabHTTPNewGame = New System.Windows.Forms.Label()
        Me.HTTPJoinPanel = New System.Windows.Forms.Panel()
        Me.LabHTTPConnect2 = New System.Windows.Forms.Label()
        Me.LabCode2 = New System.Windows.Forms.Label()
        Me.LabHTTPJoin2 = New System.Windows.Forms.Label()
        Me.PicHTTPClose = New System.Windows.Forms.PictureBox()
        Me.PicLoading = New System.Windows.Forms.PictureBox()
        Me.LoadingSpinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LabStatusTitle = New System.Windows.Forms.Label()
        CType(Me.PicStartButton_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStartButton_PvE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStartButton_PvPLan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStartButton_PvPHTTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStartButton_Tutorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSettings.SuspendLayout()
        Me.PanelSound.SuspendLayout()
        CType(Me.PicSound3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSound2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSound1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSettingSound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTheme.SuspendLayout()
        CType(Me.PicTheme3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTheme2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTheme1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSettingsTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCloseSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPvE.SuspendLayout()
        CType(Me.PicPvEStartGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEChooseAttempts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEChooseHoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPvEColors.SuspendLayout()
        CType(Me.PicPvEColor8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPvEChooseColors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PvEDifficultyPanel.SuspendLayout()
        CType(Me.PicDifficulty2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDifficulty3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDifficulty1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicClosePvE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPvPLan.SuspendLayout()
        CType(Me.PicClosePvPLAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPvPHTTP.SuspendLayout()
        CType(Me.PicClosePvPHTTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelTutorial.SuspendLayout()
        CType(Me.PicCloseTutorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFormHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsPanel.SuspendLayout()
        CType(Me.PicMinimizeForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCloseForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderTransparencyLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderTransparencyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPvP2.SuspendLayout()
        Me.HTTPCreateGamePanel.SuspendLayout()
        CType(Me.PicHTTPAttempts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHTTPHoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HTTPColorsPanel.SuspendLayout()
        CType(Me.HTTPCol8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPCol1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HTTPJoinPanel.SuspendLayout()
        CType(Me.PicHTTPClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicStartButton_Settings
        '
        Me.PicStartButton_Settings.BackColor = System.Drawing.Color.Transparent
        Me.PicStartButton_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicStartButton_Settings.Location = New System.Drawing.Point(8, 8)
        Me.PicStartButton_Settings.Margin = New System.Windows.Forms.Padding(0)
        Me.PicStartButton_Settings.Name = "PicStartButton_Settings"
        Me.PicStartButton_Settings.Size = New System.Drawing.Size(222, 41)
        Me.PicStartButton_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicStartButton_Settings.TabIndex = 0
        Me.PicStartButton_Settings.TabStop = False
        Me.PicStartButton_Settings.Tag = "0"
        '
        'LabSettings
        '
        Me.LabSettings.BackColor = System.Drawing.Color.Transparent
        Me.LabSettings.ForeColor = System.Drawing.Color.LightCyan
        Me.LabSettings.Location = New System.Drawing.Point(8, 21)
        Me.LabSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.LabSettings.Name = "LabSettings"
        Me.LabSettings.Size = New System.Drawing.Size(222, 28)
        Me.LabSettings.TabIndex = 0
        Me.LabSettings.Text = "Settings..."
        Me.LabSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvE
        '
        Me.LabPvE.BackColor = System.Drawing.Color.Transparent
        Me.LabPvE.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabPvE.Location = New System.Drawing.Point(8, 71)
        Me.LabPvE.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvE.Name = "LabPvE"
        Me.LabPvE.Size = New System.Drawing.Size(222, 28)
        Me.LabPvE.TabIndex = 1
        Me.LabPvE.Text = "Play against AI"
        Me.LabPvE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicStartButton_PvE
        '
        Me.PicStartButton_PvE.BackColor = System.Drawing.Color.Transparent
        Me.PicStartButton_PvE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicStartButton_PvE.Location = New System.Drawing.Point(8, 55)
        Me.PicStartButton_PvE.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.PicStartButton_PvE.Name = "PicStartButton_PvE"
        Me.PicStartButton_PvE.Size = New System.Drawing.Size(222, 41)
        Me.PicStartButton_PvE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicStartButton_PvE.TabIndex = 2
        Me.PicStartButton_PvE.TabStop = False
        Me.PicStartButton_PvE.Tag = "1"
        '
        'LabPvPLan
        '
        Me.LabPvPLan.BackColor = System.Drawing.Color.Transparent
        Me.LabPvPLan.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabPvPLan.Location = New System.Drawing.Point(8, 118)
        Me.LabPvPLan.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvPLan.Name = "LabPvPLan"
        Me.LabPvPLan.Size = New System.Drawing.Size(222, 28)
        Me.LabPvPLan.TabIndex = 2
        Me.LabPvPLan.Text = "PvP (LAN)"
        Me.LabPvPLan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicStartButton_PvPLan
        '
        Me.PicStartButton_PvPLan.BackColor = System.Drawing.Color.Transparent
        Me.PicStartButton_PvPLan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicStartButton_PvPLan.Location = New System.Drawing.Point(8, 102)
        Me.PicStartButton_PvPLan.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.PicStartButton_PvPLan.Name = "PicStartButton_PvPLan"
        Me.PicStartButton_PvPLan.Size = New System.Drawing.Size(222, 41)
        Me.PicStartButton_PvPLan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicStartButton_PvPLan.TabIndex = 4
        Me.PicStartButton_PvPLan.TabStop = False
        Me.PicStartButton_PvPLan.Tag = "2"
        '
        'LabPvPHTTP
        '
        Me.LabPvPHTTP.BackColor = System.Drawing.Color.Transparent
        Me.LabPvPHTTP.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabPvPHTTP.Location = New System.Drawing.Point(8, 165)
        Me.LabPvPHTTP.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvPHTTP.Name = "LabPvPHTTP"
        Me.LabPvPHTTP.Size = New System.Drawing.Size(222, 28)
        Me.LabPvPHTTP.TabIndex = 3
        Me.LabPvPHTTP.Text = "PvP (internet)"
        Me.LabPvPHTTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicStartButton_PvPHTTP
        '
        Me.PicStartButton_PvPHTTP.BackColor = System.Drawing.Color.Transparent
        Me.PicStartButton_PvPHTTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicStartButton_PvPHTTP.Location = New System.Drawing.Point(8, 149)
        Me.PicStartButton_PvPHTTP.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.PicStartButton_PvPHTTP.Name = "PicStartButton_PvPHTTP"
        Me.PicStartButton_PvPHTTP.Size = New System.Drawing.Size(222, 41)
        Me.PicStartButton_PvPHTTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicStartButton_PvPHTTP.TabIndex = 6
        Me.PicStartButton_PvPHTTP.TabStop = False
        Me.PicStartButton_PvPHTTP.Tag = "3"
        '
        'LabTutorial
        '
        Me.LabTutorial.BackColor = System.Drawing.Color.Transparent
        Me.LabTutorial.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabTutorial.Location = New System.Drawing.Point(8, 204)
        Me.LabTutorial.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTutorial.Name = "LabTutorial"
        Me.LabTutorial.Size = New System.Drawing.Size(222, 28)
        Me.LabTutorial.TabIndex = 4
        Me.LabTutorial.Text = "Tutorial"
        Me.LabTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicStartButton_Tutorial
        '
        Me.PicStartButton_Tutorial.BackColor = System.Drawing.Color.Transparent
        Me.PicStartButton_Tutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicStartButton_Tutorial.Location = New System.Drawing.Point(8, 196)
        Me.PicStartButton_Tutorial.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.PicStartButton_Tutorial.Name = "PicStartButton_Tutorial"
        Me.PicStartButton_Tutorial.Size = New System.Drawing.Size(222, 41)
        Me.PicStartButton_Tutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicStartButton_Tutorial.TabIndex = 8
        Me.PicStartButton_Tutorial.TabStop = False
        Me.PicStartButton_Tutorial.Tag = "4"
        '
        'PanelSettings
        '
        Me.PanelSettings.BackColor = System.Drawing.Color.Transparent
        Me.PanelSettings.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.StartScreenBG
        Me.PanelSettings.Controls.Add(Me.cmdTestTheme)
        Me.PanelSettings.Controls.Add(Me.ThemeComboBox)
        Me.PanelSettings.Controls.Add(Me.PanelSound)
        Me.PanelSettings.Controls.Add(Me.LabSettingsSound)
        Me.PanelSettings.Controls.Add(Me.PicSettingSound)
        Me.PanelSettings.Controls.Add(Me.PanelTheme)
        Me.PanelSettings.Controls.Add(Me.LabSettingsTheme)
        Me.PanelSettings.Controls.Add(Me.PictureBox1)
        Me.PanelSettings.Controls.Add(Me.PicSettingsTheme)
        Me.PanelSettings.Controls.Add(Me.PicCloseSettings)
        Me.PanelSettings.Location = New System.Drawing.Point(259, 57)
        Me.PanelSettings.Name = "PanelSettings"
        Me.PanelSettings.Size = New System.Drawing.Size(226, 260)
        Me.PanelSettings.TabIndex = 9
        Me.PanelSettings.Tag = "1"
        Me.PanelSettings.Visible = False
        '
        'cmdTestTheme
        '
        Me.cmdTestTheme.ForeColor = System.Drawing.Color.Black
        Me.cmdTestTheme.Location = New System.Drawing.Point(125, 189)
        Me.cmdTestTheme.Name = "cmdTestTheme"
        Me.cmdTestTheme.Size = New System.Drawing.Size(97, 25)
        Me.cmdTestTheme.TabIndex = 15
        Me.cmdTestTheme.Text = "Test theme"
        Me.cmdTestTheme.UseVisualStyleBackColor = True
        '
        'ThemeComboBox
        '
        Me.ThemeComboBox.FormattingEnabled = True
        Me.ThemeComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ThemeComboBox.Location = New System.Drawing.Point(0, 191)
        Me.ThemeComboBox.Name = "ThemeComboBox"
        Me.ThemeComboBox.Size = New System.Drawing.Size(119, 21)
        Me.ThemeComboBox.TabIndex = 14
        '
        'PanelSound
        '
        Me.PanelSound.BackColor = System.Drawing.Color.Transparent
        Me.PanelSound.Controls.Add(Me.PicSound3)
        Me.PanelSound.Controls.Add(Me.PicSound2)
        Me.PanelSound.Controls.Add(Me.PicSound1)
        Me.PanelSound.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSound.Location = New System.Drawing.Point(0, 152)
        Me.PanelSound.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelSound.Name = "PanelSound"
        Me.PanelSound.Size = New System.Drawing.Size(226, 32)
        Me.PanelSound.TabIndex = 13
        '
        'PicSound3
        '
        Me.PicSound3.BackColor = System.Drawing.Color.Transparent
        Me.PicSound3.Location = New System.Drawing.Point(143, 0)
        Me.PicSound3.Name = "PicSound3"
        Me.PicSound3.Size = New System.Drawing.Size(32, 32)
        Me.PicSound3.TabIndex = 21
        Me.PicSound3.TabStop = False
        '
        'PicSound2
        '
        Me.PicSound2.BackColor = System.Drawing.Color.Transparent
        Me.PicSound2.Location = New System.Drawing.Point(98, 0)
        Me.PicSound2.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.PicSound2.Name = "PicSound2"
        Me.PicSound2.Size = New System.Drawing.Size(32, 32)
        Me.PicSound2.TabIndex = 20
        Me.PicSound2.TabStop = False
        Me.PicSound2.Tag = "test"
        '
        'PicSound1
        '
        Me.PicSound1.BackColor = System.Drawing.Color.Transparent
        Me.PicSound1.Location = New System.Drawing.Point(53, 0)
        Me.PicSound1.Name = "PicSound1"
        Me.PicSound1.Size = New System.Drawing.Size(32, 32)
        Me.PicSound1.TabIndex = 19
        Me.PicSound1.TabStop = False
        '
        'LabSettingsSound
        '
        Me.LabSettingsSound.BackColor = System.Drawing.Color.Transparent
        Me.LabSettingsSound.ForeColor = System.Drawing.Color.LightCyan
        Me.LabSettingsSound.Location = New System.Drawing.Point(0, 137)
        Me.LabSettingsSound.Margin = New System.Windows.Forms.Padding(0)
        Me.LabSettingsSound.Name = "LabSettingsSound"
        Me.LabSettingsSound.Size = New System.Drawing.Size(222, 28)
        Me.LabSettingsSound.TabIndex = 12
        Me.LabSettingsSound.Text = "Sound"
        Me.LabSettingsSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicSettingSound
        '
        Me.PicSettingSound.BackColor = System.Drawing.Color.Transparent
        Me.PicSettingSound.BackgroundImage = CType(resources.GetObject("PicSettingSound.BackgroundImage"), System.Drawing.Image)
        Me.PicSettingSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicSettingSound.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicSettingSound.Location = New System.Drawing.Point(0, 112)
        Me.PicSettingSound.Name = "PicSettingSound"
        Me.PicSettingSound.Size = New System.Drawing.Size(226, 40)
        Me.PicSettingSound.TabIndex = 11
        Me.PicSettingSound.TabStop = False
        Me.PicSettingSound.Tag = "0"
        '
        'PanelTheme
        '
        Me.PanelTheme.BackColor = System.Drawing.Color.Transparent
        Me.PanelTheme.Controls.Add(Me.PicTheme3)
        Me.PanelTheme.Controls.Add(Me.PicTheme2)
        Me.PanelTheme.Controls.Add(Me.PicTheme1)
        Me.PanelTheme.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTheme.Location = New System.Drawing.Point(0, 80)
        Me.PanelTheme.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTheme.Name = "PanelTheme"
        Me.PanelTheme.Size = New System.Drawing.Size(226, 32)
        Me.PanelTheme.TabIndex = 10
        '
        'PicTheme3
        '
        Me.PicTheme3.BackColor = System.Drawing.Color.Transparent
        Me.PicTheme3.Location = New System.Drawing.Point(143, 0)
        Me.PicTheme3.Name = "PicTheme3"
        Me.PicTheme3.Size = New System.Drawing.Size(32, 32)
        Me.PicTheme3.TabIndex = 21
        Me.PicTheme3.TabStop = False
        '
        'PicTheme2
        '
        Me.PicTheme2.BackColor = System.Drawing.Color.Transparent
        Me.PicTheme2.Location = New System.Drawing.Point(98, 0)
        Me.PicTheme2.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.PicTheme2.Name = "PicTheme2"
        Me.PicTheme2.Size = New System.Drawing.Size(32, 32)
        Me.PicTheme2.TabIndex = 20
        Me.PicTheme2.TabStop = False
        Me.PicTheme2.Tag = "test"
        '
        'PicTheme1
        '
        Me.PicTheme1.BackColor = System.Drawing.Color.Transparent
        Me.PicTheme1.Location = New System.Drawing.Point(53, 0)
        Me.PicTheme1.Name = "PicTheme1"
        Me.PicTheme1.Size = New System.Drawing.Size(32, 32)
        Me.PicTheme1.TabIndex = 19
        Me.PicTheme1.TabStop = False
        '
        'LabSettingsTheme
        '
        Me.LabSettingsTheme.BackColor = System.Drawing.Color.Transparent
        Me.LabSettingsTheme.ForeColor = System.Drawing.Color.LightCyan
        Me.LabSettingsTheme.Location = New System.Drawing.Point(4, 65)
        Me.LabSettingsTheme.Margin = New System.Windows.Forms.Padding(0)
        Me.LabSettingsTheme.Name = "LabSettingsTheme"
        Me.LabSettingsTheme.Size = New System.Drawing.Size(222, 28)
        Me.LabSettingsTheme.TabIndex = 9
        Me.LabSettingsTheme.Text = "Theme"
        Me.LabSettingsTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 40)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "0"
        '
        'PicSettingsTheme
        '
        Me.PicSettingsTheme.BackColor = System.Drawing.Color.Transparent
        Me.PicSettingsTheme.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.PicSettingsTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicSettingsTheme.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicSettingsTheme.Location = New System.Drawing.Point(0, 40)
        Me.PicSettingsTheme.Name = "PicSettingsTheme"
        Me.PicSettingsTheme.Size = New System.Drawing.Size(226, 40)
        Me.PicSettingsTheme.TabIndex = 2
        Me.PicSettingsTheme.TabStop = False
        Me.PicSettingsTheme.Tag = "0"
        '
        'PicCloseSettings
        '
        Me.PicCloseSettings.BackColor = System.Drawing.Color.Transparent
        Me.PicCloseSettings.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.ButtonBackActive1
        Me.PicCloseSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicCloseSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCloseSettings.Location = New System.Drawing.Point(0, 0)
        Me.PicCloseSettings.Name = "PicCloseSettings"
        Me.PicCloseSettings.Size = New System.Drawing.Size(226, 40)
        Me.PicCloseSettings.TabIndex = 1
        Me.PicCloseSettings.TabStop = False
        Me.PicCloseSettings.Tag = "0"
        '
        'PanelPvE
        '
        Me.PanelPvE.AutoSize = True
        Me.PanelPvE.BackColor = System.Drawing.Color.Transparent
        Me.PanelPvE.Controls.Add(Me.LabPvEStart)
        Me.PanelPvE.Controls.Add(Me.PicPvEStartGame)
        Me.PanelPvE.Controls.Add(Me.LabPvEColors)
        Me.PanelPvE.Controls.Add(Me.LabPvENumberOfAttempts)
        Me.PanelPvE.Controls.Add(Me.LabPvENumberOfAttemptsButton)
        Me.PanelPvE.Controls.Add(Me.LabPvENumberOfHoles)
        Me.PanelPvE.Controls.Add(Me.LabPvENumberOfHolesButton)
        Me.PanelPvE.Controls.Add(Me.PicPvEChooseAttempts)
        Me.PanelPvE.Controls.Add(Me.PicPvEChooseHoles)
        Me.PanelPvE.Controls.Add(Me.PanelPvEColors)
        Me.PanelPvE.Controls.Add(Me.PicPvEChooseColors)
        Me.PanelPvE.Controls.Add(Me.PvEDifficultyPanel)
        Me.PanelPvE.Controls.Add(Me.PicClosePvE)
        Me.PanelPvE.Location = New System.Drawing.Point(491, 57)
        Me.PanelPvE.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPvE.Name = "PanelPvE"
        Me.PanelPvE.Size = New System.Drawing.Size(226, 259)
        Me.PanelPvE.TabIndex = 10
        Me.PanelPvE.Tag = "2"
        Me.PanelPvE.Visible = False
        '
        'LabPvEStart
        '
        Me.LabPvEStart.BackColor = System.Drawing.Color.Transparent
        Me.LabPvEStart.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabPvEStart.Location = New System.Drawing.Point(28, 221)
        Me.LabPvEStart.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvEStart.Name = "LabPvEStart"
        Me.LabPvEStart.Size = New System.Drawing.Size(175, 37)
        Me.LabPvEStart.TabIndex = 12
        Me.LabPvEStart.Text = "Start game"
        Me.LabPvEStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicPvEStartGame
        '
        Me.PicPvEStartGame.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicPvEStartGame.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicPvEStartGame.Location = New System.Drawing.Point(0, 219)
        Me.PicPvEStartGame.Name = "PicPvEStartGame"
        Me.PicPvEStartGame.Size = New System.Drawing.Size(226, 40)
        Me.PicPvEStartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPvEStartGame.TabIndex = 11
        Me.PicPvEStartGame.TabStop = False
        Me.PicPvEStartGame.Tag = "4"
        '
        'LabPvEColors
        '
        Me.LabPvEColors.BackColor = System.Drawing.Color.Transparent
        Me.LabPvEColors.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabPvEColors.Location = New System.Drawing.Point(31, 80)
        Me.LabPvEColors.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvEColors.Name = "LabPvEColors"
        Me.LabPvEColors.Size = New System.Drawing.Size(159, 21)
        Me.LabPvEColors.TabIndex = 10
        Me.LabPvEColors.Text = "Colors"
        Me.LabPvEColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvENumberOfAttempts
        '
        Me.LabPvENumberOfAttempts.BackColor = System.Drawing.Color.Transparent
        Me.LabPvENumberOfAttempts.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabPvENumberOfAttempts.Location = New System.Drawing.Point(175, 186)
        Me.LabPvENumberOfAttempts.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvENumberOfAttempts.Name = "LabPvENumberOfAttempts"
        Me.LabPvENumberOfAttempts.Size = New System.Drawing.Size(41, 26)
        Me.LabPvENumberOfAttempts.TabIndex = 9
        Me.LabPvENumberOfAttempts.Text = "10"
        Me.LabPvENumberOfAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvENumberOfAttemptsButton
        '
        Me.LabPvENumberOfAttemptsButton.BackColor = System.Drawing.Color.Transparent
        Me.LabPvENumberOfAttemptsButton.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabPvENumberOfAttemptsButton.Location = New System.Drawing.Point(0, 187)
        Me.LabPvENumberOfAttemptsButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvENumberOfAttemptsButton.Name = "LabPvENumberOfAttemptsButton"
        Me.LabPvENumberOfAttemptsButton.Size = New System.Drawing.Size(175, 26)
        Me.LabPvENumberOfAttemptsButton.TabIndex = 8
        Me.LabPvENumberOfAttemptsButton.Text = "Attempts per round"
        Me.LabPvENumberOfAttemptsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvENumberOfHoles
        '
        Me.LabPvENumberOfHoles.BackColor = System.Drawing.Color.Transparent
        Me.LabPvENumberOfHoles.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabPvENumberOfHoles.Location = New System.Drawing.Point(175, 146)
        Me.LabPvENumberOfHoles.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvENumberOfHoles.Name = "LabPvENumberOfHoles"
        Me.LabPvENumberOfHoles.Size = New System.Drawing.Size(48, 26)
        Me.LabPvENumberOfHoles.TabIndex = 7
        Me.LabPvENumberOfHoles.Text = "4"
        Me.LabPvENumberOfHoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvENumberOfHolesButton
        '
        Me.LabPvENumberOfHolesButton.BackColor = System.Drawing.Color.Transparent
        Me.LabPvENumberOfHolesButton.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabPvENumberOfHolesButton.Location = New System.Drawing.Point(0, 147)
        Me.LabPvENumberOfHolesButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvENumberOfHolesButton.Name = "LabPvENumberOfHolesButton"
        Me.LabPvENumberOfHolesButton.Size = New System.Drawing.Size(175, 26)
        Me.LabPvENumberOfHolesButton.TabIndex = 6
        Me.LabPvENumberOfHolesButton.Text = "Number of holes"
        Me.LabPvENumberOfHolesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicPvEChooseAttempts
        '
        Me.PicPvEChooseAttempts.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEChooseAttempts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicPvEChooseAttempts.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicPvEChooseAttempts.Location = New System.Drawing.Point(0, 179)
        Me.PicPvEChooseAttempts.Name = "PicPvEChooseAttempts"
        Me.PicPvEChooseAttempts.Size = New System.Drawing.Size(226, 40)
        Me.PicPvEChooseAttempts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPvEChooseAttempts.TabIndex = 5
        Me.PicPvEChooseAttempts.TabStop = False
        Me.PicPvEChooseAttempts.Tag = "3"
        '
        'PicPvEChooseHoles
        '
        Me.PicPvEChooseHoles.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEChooseHoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicPvEChooseHoles.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicPvEChooseHoles.Location = New System.Drawing.Point(0, 139)
        Me.PicPvEChooseHoles.Name = "PicPvEChooseHoles"
        Me.PicPvEChooseHoles.Size = New System.Drawing.Size(226, 40)
        Me.PicPvEChooseHoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPvEChooseHoles.TabIndex = 4
        Me.PicPvEChooseHoles.TabStop = False
        Me.PicPvEChooseHoles.Tag = "2"
        '
        'PanelPvEColors
        '
        Me.PanelPvEColors.BackColor = System.Drawing.Color.Transparent
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor8)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor7)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor6)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor5)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor4)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor3)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor2)
        Me.PanelPvEColors.Controls.Add(Me.PicPvEColor1)
        Me.PanelPvEColors.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPvEColors.Location = New System.Drawing.Point(0, 112)
        Me.PanelPvEColors.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPvEColors.Name = "PanelPvEColors"
        Me.PanelPvEColors.Size = New System.Drawing.Size(226, 27)
        Me.PanelPvEColors.TabIndex = 3
        '
        'PicPvEColor8
        '
        Me.PicPvEColor8.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor8.Location = New System.Drawing.Point(196, 3)
        Me.PicPvEColor8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor8.Name = "PicPvEColor8"
        Me.PicPvEColor8.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor8.TabIndex = 26
        Me.PicPvEColor8.TabStop = False
        Me.PicPvEColor8.Tag = "8"
        '
        'PicPvEColor7
        '
        Me.PicPvEColor7.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor7.Location = New System.Drawing.Point(170, 3)
        Me.PicPvEColor7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor7.Name = "PicPvEColor7"
        Me.PicPvEColor7.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor7.TabIndex = 25
        Me.PicPvEColor7.TabStop = False
        Me.PicPvEColor7.Tag = "7"
        '
        'PicPvEColor6
        '
        Me.PicPvEColor6.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor6.Location = New System.Drawing.Point(144, 3)
        Me.PicPvEColor6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor6.Name = "PicPvEColor6"
        Me.PicPvEColor6.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor6.TabIndex = 24
        Me.PicPvEColor6.TabStop = False
        Me.PicPvEColor6.Tag = "6"
        '
        'PicPvEColor5
        '
        Me.PicPvEColor5.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor5.Location = New System.Drawing.Point(118, 3)
        Me.PicPvEColor5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor5.Name = "PicPvEColor5"
        Me.PicPvEColor5.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor5.TabIndex = 23
        Me.PicPvEColor5.TabStop = False
        Me.PicPvEColor5.Tag = "5"
        '
        'PicPvEColor4
        '
        Me.PicPvEColor4.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor4.Location = New System.Drawing.Point(92, 3)
        Me.PicPvEColor4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor4.Name = "PicPvEColor4"
        Me.PicPvEColor4.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor4.TabIndex = 22
        Me.PicPvEColor4.TabStop = False
        Me.PicPvEColor4.Tag = "4"
        '
        'PicPvEColor3
        '
        Me.PicPvEColor3.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor3.Location = New System.Drawing.Point(66, 3)
        Me.PicPvEColor3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor3.Name = "PicPvEColor3"
        Me.PicPvEColor3.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor3.TabIndex = 21
        Me.PicPvEColor3.TabStop = False
        Me.PicPvEColor3.Tag = "3"
        '
        'PicPvEColor2
        '
        Me.PicPvEColor2.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor2.Location = New System.Drawing.Point(40, 3)
        Me.PicPvEColor2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PicPvEColor2.Name = "PicPvEColor2"
        Me.PicPvEColor2.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor2.TabIndex = 20
        Me.PicPvEColor2.TabStop = False
        Me.PicPvEColor2.Tag = "2"
        '
        'PicPvEColor1
        '
        Me.PicPvEColor1.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEColor1.Location = New System.Drawing.Point(14, 3)
        Me.PicPvEColor1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PicPvEColor1.Name = "PicPvEColor1"
        Me.PicPvEColor1.Size = New System.Drawing.Size(20, 20)
        Me.PicPvEColor1.TabIndex = 19
        Me.PicPvEColor1.TabStop = False
        Me.PicPvEColor1.Tag = "1"
        '
        'PicPvEChooseColors
        '
        Me.PicPvEChooseColors.BackColor = System.Drawing.Color.Transparent
        Me.PicPvEChooseColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicPvEChooseColors.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicPvEChooseColors.Location = New System.Drawing.Point(0, 72)
        Me.PicPvEChooseColors.Name = "PicPvEChooseColors"
        Me.PicPvEChooseColors.Size = New System.Drawing.Size(226, 40)
        Me.PicPvEChooseColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPvEChooseColors.TabIndex = 3
        Me.PicPvEChooseColors.TabStop = False
        Me.PicPvEChooseColors.Tag = "1"
        '
        'PvEDifficultyPanel
        '
        Me.PvEDifficultyPanel.BackColor = System.Drawing.Color.Transparent
        Me.PvEDifficultyPanel.Controls.Add(Me.PicDifficulty2)
        Me.PvEDifficultyPanel.Controls.Add(Me.PicDifficulty3)
        Me.PvEDifficultyPanel.Controls.Add(Me.PicDifficulty1)
        Me.PvEDifficultyPanel.Controls.Add(Me.LabPvEEasy)
        Me.PvEDifficultyPanel.Controls.Add(Me.LabPvEHard)
        Me.PvEDifficultyPanel.Controls.Add(Me.LabPvEImpossible)
        Me.PvEDifficultyPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PvEDifficultyPanel.Location = New System.Drawing.Point(0, 40)
        Me.PvEDifficultyPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PvEDifficultyPanel.Name = "PvEDifficultyPanel"
        Me.PvEDifficultyPanel.Size = New System.Drawing.Size(226, 32)
        Me.PvEDifficultyPanel.TabIndex = 1
        '
        'PicDifficulty2
        '
        Me.PicDifficulty2.BackColor = System.Drawing.Color.Transparent
        Me.PicDifficulty2.Location = New System.Drawing.Point(81, 3)
        Me.PicDifficulty2.Margin = New System.Windows.Forms.Padding(0)
        Me.PicDifficulty2.Name = "PicDifficulty2"
        Me.PicDifficulty2.Size = New System.Drawing.Size(64, 25)
        Me.PicDifficulty2.TabIndex = 25
        Me.PicDifficulty2.TabStop = False
        Me.PicDifficulty2.Tag = "2"
        '
        'PicDifficulty3
        '
        Me.PicDifficulty3.BackColor = System.Drawing.Color.Transparent
        Me.PicDifficulty3.Location = New System.Drawing.Point(152, 3)
        Me.PicDifficulty3.Margin = New System.Windows.Forms.Padding(0)
        Me.PicDifficulty3.Name = "PicDifficulty3"
        Me.PicDifficulty3.Size = New System.Drawing.Size(64, 25)
        Me.PicDifficulty3.TabIndex = 21
        Me.PicDifficulty3.TabStop = False
        Me.PicDifficulty3.Tag = "3"
        '
        'PicDifficulty1
        '
        Me.PicDifficulty1.BackColor = System.Drawing.Color.Transparent
        Me.PicDifficulty1.Location = New System.Drawing.Point(10, 3)
        Me.PicDifficulty1.Margin = New System.Windows.Forms.Padding(0)
        Me.PicDifficulty1.Name = "PicDifficulty1"
        Me.PicDifficulty1.Size = New System.Drawing.Size(64, 25)
        Me.PicDifficulty1.TabIndex = 19
        Me.PicDifficulty1.TabStop = False
        Me.PicDifficulty1.Tag = "1"
        '
        'LabPvEEasy
        '
        Me.LabPvEEasy.BackColor = System.Drawing.Color.Transparent
        Me.LabPvEEasy.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabPvEEasy.Location = New System.Drawing.Point(10, 6)
        Me.LabPvEEasy.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvEEasy.Name = "LabPvEEasy"
        Me.LabPvEEasy.Size = New System.Drawing.Size(60, 20)
        Me.LabPvEEasy.TabIndex = 12
        Me.LabPvEEasy.Tag = "1"
        Me.LabPvEEasy.Text = "Easy"
        Me.LabPvEEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvEHard
        '
        Me.LabPvEHard.BackColor = System.Drawing.Color.Transparent
        Me.LabPvEHard.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabPvEHard.Location = New System.Drawing.Point(84, 6)
        Me.LabPvEHard.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvEHard.Name = "LabPvEHard"
        Me.LabPvEHard.Size = New System.Drawing.Size(60, 19)
        Me.LabPvEHard.TabIndex = 24
        Me.LabPvEHard.Tag = "2"
        Me.LabPvEHard.Text = "Hard"
        Me.LabPvEHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPvEImpossible
        '
        Me.LabPvEImpossible.BackColor = System.Drawing.Color.Transparent
        Me.LabPvEImpossible.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabPvEImpossible.Location = New System.Drawing.Point(157, 7)
        Me.LabPvEImpossible.Margin = New System.Windows.Forms.Padding(0)
        Me.LabPvEImpossible.Name = "LabPvEImpossible"
        Me.LabPvEImpossible.Size = New System.Drawing.Size(57, 18)
        Me.LabPvEImpossible.TabIndex = 23
        Me.LabPvEImpossible.Tag = "3"
        Me.LabPvEImpossible.Text = "Impossible"
        Me.LabPvEImpossible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicClosePvE
        '
        Me.PicClosePvE.BackColor = System.Drawing.Color.Transparent
        Me.PicClosePvE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicClosePvE.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicClosePvE.Location = New System.Drawing.Point(0, 0)
        Me.PicClosePvE.Name = "PicClosePvE"
        Me.PicClosePvE.Size = New System.Drawing.Size(226, 40)
        Me.PicClosePvE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicClosePvE.TabIndex = 0
        Me.PicClosePvE.TabStop = False
        Me.PicClosePvE.Tag = "0"
        '
        'PanelPvPLan
        '
        Me.PanelPvPLan.BackColor = System.Drawing.Color.Transparent
        Me.PanelPvPLan.Controls.Add(Me.PicClosePvPLAN)
        Me.PanelPvPLan.Location = New System.Drawing.Point(12, 399)
        Me.PanelPvPLan.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPvPLan.Name = "PanelPvPLan"
        Me.PanelPvPLan.Size = New System.Drawing.Size(226, 27)
        Me.PanelPvPLan.TabIndex = 11
        Me.PanelPvPLan.Tag = "3"
        Me.PanelPvPLan.Visible = False
        '
        'PicClosePvPLAN
        '
        Me.PicClosePvPLAN.BackColor = System.Drawing.Color.DarkRed
        Me.PicClosePvPLAN.Location = New System.Drawing.Point(207, 11)
        Me.PicClosePvPLAN.Name = "PicClosePvPLAN"
        Me.PicClosePvPLAN.Size = New System.Drawing.Size(16, 16)
        Me.PicClosePvPLAN.TabIndex = 0
        Me.PicClosePvPLAN.TabStop = False
        '
        'PanelPvPHTTP
        '
        Me.PanelPvPHTTP.BackColor = System.Drawing.Color.Transparent
        Me.PanelPvPHTTP.Controls.Add(Me.PicClosePvPHTTP)
        Me.PanelPvPHTTP.Controls.Add(Me.LabHTTPCreate)
        Me.PanelPvPHTTP.Controls.Add(Me.LabHTTPJoin)
        Me.PanelPvPHTTP.Controls.Add(Me.Panel1)
        Me.PanelPvPHTTP.Location = New System.Drawing.Point(255, 465)
        Me.PanelPvPHTTP.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPvPHTTP.Name = "PanelPvPHTTP"
        Me.PanelPvPHTTP.Size = New System.Drawing.Size(226, 247)
        Me.PanelPvPHTTP.TabIndex = 12
        Me.PanelPvPHTTP.Tag = "4"
        Me.PanelPvPHTTP.Visible = False
        '
        'PicClosePvPHTTP
        '
        Me.PicClosePvPHTTP.BackColor = System.Drawing.Color.DimGray
        Me.PicClosePvPHTTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicClosePvPHTTP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicClosePvPHTTP.Location = New System.Drawing.Point(0, 167)
        Me.PicClosePvPHTTP.Name = "PicClosePvPHTTP"
        Me.PicClosePvPHTTP.Size = New System.Drawing.Size(226, 48)
        Me.PicClosePvPHTTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicClosePvPHTTP.TabIndex = 25
        Me.PicClosePvPHTTP.TabStop = False
        Me.PicClosePvPHTTP.Tag = "0"
        '
        'LabHTTPCreate
        '
        Me.LabHTTPCreate.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPCreate.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHTTPCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPCreate.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabHTTPCreate.Location = New System.Drawing.Point(0, 128)
        Me.LabHTTPCreate.Name = "LabHTTPCreate"
        Me.LabHTTPCreate.Size = New System.Drawing.Size(226, 39)
        Me.LabHTTPCreate.TabIndex = 27
        Me.LabHTTPCreate.Text = "Create new game"
        Me.LabHTTPCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabHTTPJoin
        '
        Me.LabHTTPJoin.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPJoin.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHTTPJoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPJoin.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabHTTPJoin.Location = New System.Drawing.Point(0, 89)
        Me.LabHTTPJoin.Name = "LabHTTPJoin"
        Me.LabHTTPJoin.Size = New System.Drawing.Size(226, 39)
        Me.LabHTTPJoin.TabIndex = 2
        Me.LabHTTPJoin.Text = "Join existing game"
        Me.LabHTTPJoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.LabHTTPConnect)
        Me.Panel1.Controls.Add(Me.LabCode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 89)
        Me.Panel1.TabIndex = 26
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Black
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode.ForeColor = System.Drawing.Color.White
        Me.txtCode.Location = New System.Drawing.Point(10, 3)
        Me.txtCode.MaxLength = 4
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(204, 13)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Text = "1234"
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabHTTPConnect
        '
        Me.LabHTTPConnect.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPConnect.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPConnect.Image = Global.Mind_Wars.My.Resources.Resources.ButtonBorderInactive
        Me.LabHTTPConnect.Location = New System.Drawing.Point(0, 41)
        Me.LabHTTPConnect.Name = "LabHTTPConnect"
        Me.LabHTTPConnect.Size = New System.Drawing.Size(226, 44)
        Me.LabHTTPConnect.TabIndex = 4
        Me.LabHTTPConnect.Text = "Connect"
        Me.LabHTTPConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabCode
        '
        Me.LabCode.BackColor = System.Drawing.Color.Transparent
        Me.LabCode.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabCode.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabCode.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabCode.Location = New System.Drawing.Point(0, 0)
        Me.LabCode.Name = "LabCode"
        Me.LabCode.Size = New System.Drawing.Size(226, 41)
        Me.LabCode.TabIndex = 1
        Me.LabCode.Text = "1234"
        Me.LabCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdNewPublicGame
        '
        Me.cmdNewPublicGame.BackColor = System.Drawing.Color.Transparent
        Me.cmdNewPublicGame.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.ButtonBorderInactive
        Me.cmdNewPublicGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdNewPublicGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNewPublicGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNewPublicGame.Location = New System.Drawing.Point(-15, 648)
        Me.cmdNewPublicGame.Name = "cmdNewPublicGame"
        Me.cmdNewPublicGame.Size = New System.Drawing.Size(226, 46)
        Me.cmdNewPublicGame.TabIndex = 6
        Me.cmdNewPublicGame.Text = "New public game"
        Me.cmdNewPublicGame.UseVisualStyleBackColor = False
        '
        'cmdNewPrivateGame
        '
        Me.cmdNewPrivateGame.BackColor = System.Drawing.Color.Transparent
        Me.cmdNewPrivateGame.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.ButtonBorderInactive
        Me.cmdNewPrivateGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdNewPrivateGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNewPrivateGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNewPrivateGame.Location = New System.Drawing.Point(12, 506)
        Me.cmdNewPrivateGame.Name = "cmdNewPrivateGame"
        Me.cmdNewPrivateGame.Size = New System.Drawing.Size(226, 46)
        Me.cmdNewPrivateGame.TabIndex = 5
        Me.cmdNewPrivateGame.Text = "New private game"
        Me.cmdNewPrivateGame.UseVisualStyleBackColor = False
        '
        'cmdConnectHTTP
        '
        Me.cmdConnectHTTP.BackColor = System.Drawing.Color.Transparent
        Me.cmdConnectHTTP.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.ButtonBorderInactive
        Me.cmdConnectHTTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdConnectHTTP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdConnectHTTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdConnectHTTP.Location = New System.Drawing.Point(0, 558)
        Me.cmdConnectHTTP.Name = "cmdConnectHTTP"
        Me.cmdConnectHTTP.Size = New System.Drawing.Size(226, 46)
        Me.cmdConnectHTTP.TabIndex = 4
        Me.cmdConnectHTTP.Text = "Connect"
        Me.cmdConnectHTTP.UseVisualStyleBackColor = False
        '
        'PanelTutorial
        '
        Me.PanelTutorial.BackColor = System.Drawing.Color.Transparent
        Me.PanelTutorial.Controls.Add(Me.PicCloseTutorial)
        Me.PanelTutorial.Location = New System.Drawing.Point(12, 465)
        Me.PanelTutorial.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTutorial.Name = "PanelTutorial"
        Me.PanelTutorial.Size = New System.Drawing.Size(226, 27)
        Me.PanelTutorial.TabIndex = 13
        Me.PanelTutorial.Tag = "5"
        Me.PanelTutorial.Visible = False
        '
        'PicCloseTutorial
        '
        Me.PicCloseTutorial.BackColor = System.Drawing.Color.DarkRed
        Me.PicCloseTutorial.Location = New System.Drawing.Point(207, 11)
        Me.PicCloseTutorial.Name = "PicCloseTutorial"
        Me.PicCloseTutorial.Size = New System.Drawing.Size(16, 16)
        Me.PicCloseTutorial.TabIndex = 0
        Me.PicCloseTutorial.TabStop = False
        '
        'PicFormHeader
        '
        Me.PicFormHeader.BackColor = System.Drawing.Color.Transparent
        Me.PicFormHeader.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.HeaderBG
        Me.PicFormHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicFormHeader.Location = New System.Drawing.Point(0, 0)
        Me.PicFormHeader.Name = "PicFormHeader"
        Me.PicFormHeader.Size = New System.Drawing.Size(1056, 32)
        Me.PicFormHeader.TabIndex = 14
        Me.PicFormHeader.TabStop = False
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonsPanel.Controls.Add(Me.LabSettings)
        Me.ButtonsPanel.Controls.Add(Me.PicStartButton_Settings)
        Me.ButtonsPanel.Controls.Add(Me.LabPvE)
        Me.ButtonsPanel.Controls.Add(Me.LabPvPLan)
        Me.ButtonsPanel.Controls.Add(Me.LabTutorial)
        Me.ButtonsPanel.Controls.Add(Me.LabPvPHTTP)
        Me.ButtonsPanel.Controls.Add(Me.PicStartButton_Tutorial)
        Me.ButtonsPanel.Controls.Add(Me.PicStartButton_PvE)
        Me.ButtonsPanel.Controls.Add(Me.PicStartButton_PvPHTTP)
        Me.ButtonsPanel.Controls.Add(Me.PicStartButton_PvPLan)
        Me.ButtonsPanel.Location = New System.Drawing.Point(0, 35)
        Me.ButtonsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Padding = New System.Windows.Forms.Padding(8)
        Me.ButtonsPanel.Size = New System.Drawing.Size(238, 249)
        Me.ButtonsPanel.TabIndex = 15
        '
        'PicMinimizeForm
        '
        Me.PicMinimizeForm.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimizeForm.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.Minimize
        Me.PicMinimizeForm.Location = New System.Drawing.Point(195, 8)
        Me.PicMinimizeForm.Margin = New System.Windows.Forms.Padding(0)
        Me.PicMinimizeForm.Name = "PicMinimizeForm"
        Me.PicMinimizeForm.Size = New System.Drawing.Size(16, 16)
        Me.PicMinimizeForm.TabIndex = 17
        Me.PicMinimizeForm.TabStop = False
        '
        'PicCloseForm
        '
        Me.PicCloseForm.BackColor = System.Drawing.Color.Transparent
        Me.PicCloseForm.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.Exit1
        Me.PicCloseForm.Location = New System.Drawing.Point(214, 8)
        Me.PicCloseForm.Name = "PicCloseForm"
        Me.PicCloseForm.Size = New System.Drawing.Size(16, 16)
        Me.PicCloseForm.TabIndex = 18
        Me.PicCloseForm.TabStop = False
        '
        'GUITimer
        '
        Me.GUITimer.Interval = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Mind_Wars.My.Resources.Resources.BGtema2
        Me.PictureBox2.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 16)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'HTTPBackgroundWorker
        '
        Me.HTTPBackgroundWorker.WorkerReportsProgress = True
        Me.HTTPBackgroundWorker.WorkerSupportsCancellation = True
        '
        'HeaderTransparencyLeft
        '
        Me.HeaderTransparencyLeft.BackColor = System.Drawing.Color.Maroon
        Me.HeaderTransparencyLeft.Image = Global.Mind_Wars.My.Resources.Resources.HeaderTransparencyLeft
        Me.HeaderTransparencyLeft.Location = New System.Drawing.Point(815, 183)
        Me.HeaderTransparencyLeft.Name = "HeaderTransparencyLeft"
        Me.HeaderTransparencyLeft.Size = New System.Drawing.Size(36, 59)
        Me.HeaderTransparencyLeft.TabIndex = 22
        Me.HeaderTransparencyLeft.TabStop = False
        '
        'HeaderTransparencyRight
        '
        Me.HeaderTransparencyRight.BackColor = System.Drawing.Color.Maroon
        Me.HeaderTransparencyRight.Image = Global.Mind_Wars.My.Resources.Resources.HeaderTransparencyRight
        Me.HeaderTransparencyRight.Location = New System.Drawing.Point(926, 63)
        Me.HeaderTransparencyRight.Name = "HeaderTransparencyRight"
        Me.HeaderTransparencyRight.Size = New System.Drawing.Size(66, 59)
        Me.HeaderTransparencyRight.TabIndex = 23
        Me.HeaderTransparencyRight.TabStop = False
        '
        'JoinBackgroundWorker
        '
        '
        'PanelPvP2
        '
        Me.PanelPvP2.AutoSize = True
        Me.PanelPvP2.BackColor = System.Drawing.Color.Transparent
        Me.PanelPvP2.Controls.Add(Me.HTTPCreateGamePanel)
        Me.PanelPvP2.Controls.Add(Me.LabHTTPNewGame)
        Me.PanelPvP2.Controls.Add(Me.HTTPJoinPanel)
        Me.PanelPvP2.Controls.Add(Me.LabHTTPJoin2)
        Me.PanelPvP2.Controls.Add(Me.PicHTTPClose)
        Me.PanelPvP2.Location = New System.Drawing.Point(730, 140)
        Me.PanelPvP2.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPvP2.Name = "PanelPvP2"
        Me.PanelPvP2.Size = New System.Drawing.Size(226, 371)
        Me.PanelPvP2.TabIndex = 24
        Me.PanelPvP2.Tag = "4"
        Me.PanelPvP2.Visible = False
        '
        'HTTPCreateGamePanel
        '
        Me.HTTPCreateGamePanel.AutoSize = True
        Me.HTTPCreateGamePanel.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCreateGamePanel.Controls.Add(Me.LabHTTPCreate2)
        Me.HTTPCreateGamePanel.Controls.Add(Me.LabHTTPAttempts)
        Me.HTTPCreateGamePanel.Controls.Add(Me.LabHTTPAttemptsCaption)
        Me.HTTPCreateGamePanel.Controls.Add(Me.PicHTTPAttempts)
        Me.HTTPCreateGamePanel.Controls.Add(Me.LabHTTPHoles)
        Me.HTTPCreateGamePanel.Controls.Add(Me.LabHTTPHolesCaption)
        Me.HTTPCreateGamePanel.Controls.Add(Me.PicHTTPHoles)
        Me.HTTPCreateGamePanel.Controls.Add(Me.HTTPColorsPanel)
        Me.HTTPCreateGamePanel.Controls.Add(Me.LabHTTPColors2)
        Me.HTTPCreateGamePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HTTPCreateGamePanel.Location = New System.Drawing.Point(0, 196)
        Me.HTTPCreateGamePanel.Name = "HTTPCreateGamePanel"
        Me.HTTPCreateGamePanel.Size = New System.Drawing.Size(226, 175)
        Me.HTTPCreateGamePanel.TabIndex = 30
        Me.HTTPCreateGamePanel.Tag = "4"
        Me.HTTPCreateGamePanel.Visible = False
        '
        'LabHTTPCreate2
        '
        Me.LabHTTPCreate2.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPCreate2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPCreate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHTTPCreate2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPCreate2.Image = Global.Mind_Wars.My.Resources.Resources.ButtonBorderInactive
        Me.LabHTTPCreate2.Location = New System.Drawing.Point(0, 138)
        Me.LabHTTPCreate2.Name = "LabHTTPCreate2"
        Me.LabHTTPCreate2.Size = New System.Drawing.Size(226, 37)
        Me.LabHTTPCreate2.TabIndex = 28
        Me.LabHTTPCreate2.Tag = "8"
        Me.LabHTTPCreate2.Text = "&Create new game"
        Me.LabHTTPCreate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabHTTPAttempts
        '
        Me.LabHTTPAttempts.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPAttempts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPAttempts.Location = New System.Drawing.Point(181, 109)
        Me.LabHTTPAttempts.Margin = New System.Windows.Forms.Padding(0)
        Me.LabHTTPAttempts.Name = "LabHTTPAttempts"
        Me.LabHTTPAttempts.Size = New System.Drawing.Size(35, 16)
        Me.LabHTTPAttempts.TabIndex = 13
        Me.LabHTTPAttempts.Tag = "0"
        Me.LabHTTPAttempts.Text = "4"
        Me.LabHTTPAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabHTTPAttemptsCaption
        '
        Me.LabHTTPAttemptsCaption.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPAttemptsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPAttemptsCaption.Location = New System.Drawing.Point(10, 109)
        Me.LabHTTPAttemptsCaption.Margin = New System.Windows.Forms.Padding(0)
        Me.LabHTTPAttemptsCaption.Name = "LabHTTPAttemptsCaption"
        Me.LabHTTPAttemptsCaption.Size = New System.Drawing.Size(154, 15)
        Me.LabHTTPAttemptsCaption.TabIndex = 12
        Me.LabHTTPAttemptsCaption.Tag = "0"
        Me.LabHTTPAttemptsCaption.Text = "Attempts per round"
        Me.LabHTTPAttemptsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicHTTPAttempts
        '
        Me.PicHTTPAttempts.BackColor = System.Drawing.Color.Transparent
        Me.PicHTTPAttempts.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicHTTPAttempts.Image = Global.Mind_Wars.My.Resources.Resources.NumberSettings00
        Me.PicHTTPAttempts.Location = New System.Drawing.Point(0, 101)
        Me.PicHTTPAttempts.Name = "PicHTTPAttempts"
        Me.PicHTTPAttempts.Size = New System.Drawing.Size(226, 37)
        Me.PicHTTPAttempts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicHTTPAttempts.TabIndex = 11
        Me.PicHTTPAttempts.TabStop = False
        Me.PicHTTPAttempts.Tag = "7"
        '
        'LabHTTPHoles
        '
        Me.LabHTTPHoles.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPHoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPHoles.Location = New System.Drawing.Point(175, 70)
        Me.LabHTTPHoles.Margin = New System.Windows.Forms.Padding(0)
        Me.LabHTTPHoles.Name = "LabHTTPHoles"
        Me.LabHTTPHoles.Size = New System.Drawing.Size(50, 19)
        Me.LabHTTPHoles.TabIndex = 10
        Me.LabHTTPHoles.Tag = "0"
        Me.LabHTTPHoles.Text = "4"
        Me.LabHTTPHoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabHTTPHolesCaption
        '
        Me.LabHTTPHolesCaption.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPHolesCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPHolesCaption.Location = New System.Drawing.Point(10, 71)
        Me.LabHTTPHolesCaption.Margin = New System.Windows.Forms.Padding(0)
        Me.LabHTTPHolesCaption.Name = "LabHTTPHolesCaption"
        Me.LabHTTPHolesCaption.Size = New System.Drawing.Size(154, 18)
        Me.LabHTTPHolesCaption.TabIndex = 9
        Me.LabHTTPHolesCaption.Tag = "0"
        Me.LabHTTPHolesCaption.Text = "Number of holes"
        Me.LabHTTPHolesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicHTTPHoles
        '
        Me.PicHTTPHoles.BackColor = System.Drawing.Color.Transparent
        Me.PicHTTPHoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicHTTPHoles.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicHTTPHoles.Image = Global.Mind_Wars.My.Resources.Resources.NumberSettings00
        Me.PicHTTPHoles.Location = New System.Drawing.Point(0, 64)
        Me.PicHTTPHoles.Name = "PicHTTPHoles"
        Me.PicHTTPHoles.Size = New System.Drawing.Size(226, 37)
        Me.PicHTTPHoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicHTTPHoles.TabIndex = 8
        Me.PicHTTPHoles.TabStop = False
        Me.PicHTTPHoles.Tag = "6"
        '
        'HTTPColorsPanel
        '
        Me.HTTPColorsPanel.BackColor = System.Drawing.Color.Transparent
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol8)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol7)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol6)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol5)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol4)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol3)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol2)
        Me.HTTPColorsPanel.Controls.Add(Me.HTTPCol1)
        Me.HTTPColorsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HTTPColorsPanel.Location = New System.Drawing.Point(0, 37)
        Me.HTTPColorsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.HTTPColorsPanel.Name = "HTTPColorsPanel"
        Me.HTTPColorsPanel.Size = New System.Drawing.Size(226, 27)
        Me.HTTPColorsPanel.TabIndex = 6
        '
        'HTTPCol8
        '
        Me.HTTPCol8.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol8.Location = New System.Drawing.Point(196, 3)
        Me.HTTPCol8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol8.Name = "HTTPCol8"
        Me.HTTPCol8.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol8.TabIndex = 26
        Me.HTTPCol8.TabStop = False
        Me.HTTPCol8.Tag = "8"
        '
        'HTTPCol7
        '
        Me.HTTPCol7.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol7.Location = New System.Drawing.Point(170, 3)
        Me.HTTPCol7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol7.Name = "HTTPCol7"
        Me.HTTPCol7.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol7.TabIndex = 25
        Me.HTTPCol7.TabStop = False
        Me.HTTPCol7.Tag = "7"
        '
        'HTTPCol6
        '
        Me.HTTPCol6.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol6.Location = New System.Drawing.Point(144, 3)
        Me.HTTPCol6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol6.Name = "HTTPCol6"
        Me.HTTPCol6.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol6.TabIndex = 24
        Me.HTTPCol6.TabStop = False
        Me.HTTPCol6.Tag = "6"
        '
        'HTTPCol5
        '
        Me.HTTPCol5.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol5.Location = New System.Drawing.Point(118, 3)
        Me.HTTPCol5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol5.Name = "HTTPCol5"
        Me.HTTPCol5.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol5.TabIndex = 23
        Me.HTTPCol5.TabStop = False
        Me.HTTPCol5.Tag = "5"
        '
        'HTTPCol4
        '
        Me.HTTPCol4.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol4.Location = New System.Drawing.Point(92, 3)
        Me.HTTPCol4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol4.Name = "HTTPCol4"
        Me.HTTPCol4.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol4.TabIndex = 22
        Me.HTTPCol4.TabStop = False
        Me.HTTPCol4.Tag = "4"
        '
        'HTTPCol3
        '
        Me.HTTPCol3.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol3.Location = New System.Drawing.Point(66, 3)
        Me.HTTPCol3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol3.Name = "HTTPCol3"
        Me.HTTPCol3.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol3.TabIndex = 21
        Me.HTTPCol3.TabStop = False
        Me.HTTPCol3.Tag = "3"
        '
        'HTTPCol2
        '
        Me.HTTPCol2.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol2.Location = New System.Drawing.Point(40, 3)
        Me.HTTPCol2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HTTPCol2.Name = "HTTPCol2"
        Me.HTTPCol2.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol2.TabIndex = 20
        Me.HTTPCol2.TabStop = False
        Me.HTTPCol2.Tag = "2"
        '
        'HTTPCol1
        '
        Me.HTTPCol1.BackColor = System.Drawing.Color.Transparent
        Me.HTTPCol1.Location = New System.Drawing.Point(14, 3)
        Me.HTTPCol1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.HTTPCol1.Name = "HTTPCol1"
        Me.HTTPCol1.Size = New System.Drawing.Size(20, 20)
        Me.HTTPCol1.TabIndex = 19
        Me.HTTPCol1.TabStop = False
        Me.HTTPCol1.Tag = "1"
        '
        'LabHTTPColors2
        '
        Me.LabHTTPColors2.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPColors2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPColors2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHTTPColors2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPColors2.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabHTTPColors2.Location = New System.Drawing.Point(0, 0)
        Me.LabHTTPColors2.Name = "LabHTTPColors2"
        Me.LabHTTPColors2.Size = New System.Drawing.Size(226, 37)
        Me.LabHTTPColors2.TabIndex = 5
        Me.LabHTTPColors2.Tag = "5"
        Me.LabHTTPColors2.Text = "Colors"
        Me.LabHTTPColors2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabHTTPNewGame
        '
        Me.LabHTTPNewGame.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPNewGame.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHTTPNewGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPNewGame.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabHTTPNewGame.Location = New System.Drawing.Point(0, 155)
        Me.LabHTTPNewGame.Margin = New System.Windows.Forms.Padding(3)
        Me.LabHTTPNewGame.Name = "LabHTTPNewGame"
        Me.LabHTTPNewGame.Size = New System.Drawing.Size(226, 41)
        Me.LabHTTPNewGame.TabIndex = 29
        Me.LabHTTPNewGame.Tag = "4"
        Me.LabHTTPNewGame.Text = "Create new game"
        Me.LabHTTPNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HTTPJoinPanel
        '
        Me.HTTPJoinPanel.AutoSize = True
        Me.HTTPJoinPanel.BackColor = System.Drawing.Color.Transparent
        Me.HTTPJoinPanel.Controls.Add(Me.LabStatusTitle)
        Me.HTTPJoinPanel.Controls.Add(Me.LabHTTPConnect2)
        Me.HTTPJoinPanel.Controls.Add(Me.LabCode2)
        Me.HTTPJoinPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HTTPJoinPanel.Location = New System.Drawing.Point(0, 81)
        Me.HTTPJoinPanel.Name = "HTTPJoinPanel"
        Me.HTTPJoinPanel.Size = New System.Drawing.Size(226, 74)
        Me.HTTPJoinPanel.TabIndex = 28
        Me.HTTPJoinPanel.Visible = False
        '
        'LabHTTPConnect2
        '
        Me.LabHTTPConnect2.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPConnect2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPConnect2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPConnect2.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabHTTPConnect2.Location = New System.Drawing.Point(0, 37)
        Me.LabHTTPConnect2.Name = "LabHTTPConnect2"
        Me.LabHTTPConnect2.Size = New System.Drawing.Size(226, 37)
        Me.LabHTTPConnect2.TabIndex = 4
        Me.LabHTTPConnect2.Tag = "3"
        Me.LabHTTPConnect2.Text = "Connect"
        Me.LabHTTPConnect2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabCode2
        '
        Me.LabCode2.BackColor = System.Drawing.Color.Transparent
        Me.LabCode2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabCode2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabCode2.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabCode2.Location = New System.Drawing.Point(0, 0)
        Me.LabCode2.Name = "LabCode2"
        Me.LabCode2.Size = New System.Drawing.Size(226, 37)
        Me.LabCode2.TabIndex = 1
        Me.LabCode2.Tag = "2"
        Me.LabCode2.Text = "1234"
        Me.LabCode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabHTTPJoin2
        '
        Me.LabHTTPJoin2.BackColor = System.Drawing.Color.Transparent
        Me.LabHTTPJoin2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHTTPJoin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHTTPJoin2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabHTTPJoin2.Image = Global.Mind_Wars.My.Resources.Resources.SettingsButtonInactive
        Me.LabHTTPJoin2.Location = New System.Drawing.Point(0, 40)
        Me.LabHTTPJoin2.Margin = New System.Windows.Forms.Padding(3)
        Me.LabHTTPJoin2.Name = "LabHTTPJoin2"
        Me.LabHTTPJoin2.Size = New System.Drawing.Size(226, 41)
        Me.LabHTTPJoin2.TabIndex = 27
        Me.LabHTTPJoin2.Tag = "1"
        Me.LabHTTPJoin2.Text = "Join existing game"
        Me.LabHTTPJoin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicHTTPClose
        '
        Me.PicHTTPClose.BackColor = System.Drawing.Color.Transparent
        Me.PicHTTPClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicHTTPClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicHTTPClose.Location = New System.Drawing.Point(0, 0)
        Me.PicHTTPClose.Name = "PicHTTPClose"
        Me.PicHTTPClose.Size = New System.Drawing.Size(226, 40)
        Me.PicHTTPClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicHTTPClose.TabIndex = 26
        Me.PicHTTPClose.TabStop = False
        Me.PicHTTPClose.Tag = "0"
        '
        'PicLoading
        '
        Me.PicLoading.Location = New System.Drawing.Point(536, 373)
        Me.PicLoading.Name = "PicLoading"
        Me.PicLoading.Size = New System.Drawing.Size(100, 100)
        Me.PicLoading.TabIndex = 29
        Me.PicLoading.TabStop = False
        Me.PicLoading.Visible = False
        '
        'LoadingSpinTimer
        '
        Me.LoadingSpinTimer.Interval = 20
        '
        'LabStatusTitle
        '
        Me.LabStatusTitle.Location = New System.Drawing.Point(99, 33)
        Me.LabStatusTitle.Name = "LabStatusTitle"
        Me.LabStatusTitle.Size = New System.Drawing.Size(100, 23)
        Me.LabStatusTitle.TabIndex = 30
        Me.LabStatusTitle.Text = "Loading..."
        Me.LabStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Mind_Wars.My.Resources.Resources.StartScreenBG
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1056, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicLoading)
        Me.Controls.Add(Me.PanelPvP2)
        Me.Controls.Add(Me.HeaderTransparencyLeft)
        Me.Controls.Add(Me.HeaderTransparencyRight)
        Me.Controls.Add(Me.cmdConnectHTTP)
        Me.Controls.Add(Me.cmdNewPublicGame)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmdNewPrivateGame)
        Me.Controls.Add(Me.PicCloseForm)
        Me.Controls.Add(Me.PicMinimizeForm)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.PicFormHeader)
        Me.Controls.Add(Me.PanelTutorial)
        Me.Controls.Add(Me.PanelPvPHTTP)
        Me.Controls.Add(Me.PanelPvPLan)
        Me.Controls.Add(Me.PanelPvE)
        Me.Controls.Add(Me.PanelSettings)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(238, 0)
        Me.Name = "StartScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mind Wars"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(2, Byte), Integer))
        CType(Me.PicStartButton_Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStartButton_PvE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStartButton_PvPLan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStartButton_PvPHTTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStartButton_Tutorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSettings.ResumeLayout(False)
        Me.PanelSound.ResumeLayout(False)
        CType(Me.PicSound3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSound2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSound1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSettingSound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTheme.ResumeLayout(False)
        CType(Me.PicTheme3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTheme2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTheme1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSettingsTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCloseSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPvE.ResumeLayout(False)
        CType(Me.PicPvEStartGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEChooseAttempts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEChooseHoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPvEColors.ResumeLayout(False)
        CType(Me.PicPvEColor8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEColor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPvEChooseColors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PvEDifficultyPanel.ResumeLayout(False)
        CType(Me.PicDifficulty2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDifficulty3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDifficulty1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicClosePvE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPvPLan.ResumeLayout(False)
        CType(Me.PicClosePvPLAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPvPHTTP.ResumeLayout(False)
        CType(Me.PicClosePvPHTTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelTutorial.ResumeLayout(False)
        CType(Me.PicCloseTutorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFormHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonsPanel.ResumeLayout(False)
        CType(Me.PicMinimizeForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCloseForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderTransparencyLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderTransparencyRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPvP2.ResumeLayout(False)
        Me.PanelPvP2.PerformLayout()
        Me.HTTPCreateGamePanel.ResumeLayout(False)
        CType(Me.PicHTTPAttempts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHTTPHoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HTTPColorsPanel.ResumeLayout(False)
        CType(Me.HTTPCol8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPCol1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HTTPJoinPanel.ResumeLayout(False)
        CType(Me.PicHTTPClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicStartButton_Settings As PictureBox
    Friend WithEvents LabSettings As Label
    Friend WithEvents LabPvE As Label
    Friend WithEvents PicStartButton_PvE As PictureBox
    Friend WithEvents LabPvPLan As Label
    Friend WithEvents PicStartButton_PvPLan As PictureBox
    Friend WithEvents LabPvPHTTP As Label
    Friend WithEvents PicStartButton_PvPHTTP As PictureBox
    Friend WithEvents LabTutorial As Label
    Friend WithEvents PicStartButton_Tutorial As PictureBox
    Friend WithEvents PanelSettings As Panel
    Friend WithEvents PanelPvE As Panel
    Friend WithEvents PicClosePvE As PictureBox
    Friend WithEvents PanelPvPLan As Panel
    Friend WithEvents PicClosePvPLAN As PictureBox
    Friend WithEvents PanelPvPHTTP As Panel
    Friend WithEvents PanelTutorial As Panel
    Friend WithEvents PicCloseTutorial As PictureBox
    Friend WithEvents PicFormHeader As PictureBox
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents PicMinimizeForm As PictureBox
    Friend WithEvents PicCloseForm As PictureBox
    Friend WithEvents GUITimer As Timer
    Friend WithEvents PicCloseSettings As PictureBox
    Friend WithEvents PvEDifficultyPanel As Panel
    Friend WithEvents PicDifficulty3 As PictureBox
    Friend WithEvents PicDifficulty1 As PictureBox
    Friend WithEvents PicSettingsTheme As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicPvEChooseHoles As PictureBox
    Friend WithEvents PanelPvEColors As Panel
    Friend WithEvents PicPvEColor8 As PictureBox
    Friend WithEvents PicPvEColor7 As PictureBox
    Friend WithEvents PicPvEColor6 As PictureBox
    Friend WithEvents PicPvEColor5 As PictureBox
    Friend WithEvents PicPvEColor4 As PictureBox
    Friend WithEvents PicPvEColor3 As PictureBox
    Friend WithEvents PicPvEColor2 As PictureBox
    Friend WithEvents PicPvEColor1 As PictureBox
    Friend WithEvents PicPvEChooseColors As PictureBox
    Friend WithEvents LabPvENumberOfAttempts As Label
    Friend WithEvents LabPvENumberOfAttemptsButton As Label
    Friend WithEvents LabPvENumberOfHoles As Label
    Friend WithEvents LabPvENumberOfHolesButton As Label
    Friend WithEvents PicPvEChooseAttempts As PictureBox
    Friend WithEvents LabPvEColors As Label
    Friend WithEvents LabPvEImpossible As Label
    Friend WithEvents LabPvEEasy As Label
    Friend WithEvents LabSettingsTheme As Label
    Friend WithEvents PanelTheme As Panel
    Friend WithEvents PicTheme3 As PictureBox
    Friend WithEvents PicTheme2 As PictureBox
    Friend WithEvents PicTheme1 As PictureBox
    Friend WithEvents LabSettingsSound As Label
    Friend WithEvents PicSettingSound As PictureBox
    Friend WithEvents PanelSound As Panel
    Friend WithEvents PicSound3 As PictureBox
    Friend WithEvents PicSound2 As PictureBox
    Friend WithEvents PicSound1 As PictureBox
    Friend WithEvents LabPvEHard As Label
    Friend WithEvents PicDifficulty2 As PictureBox
    Friend WithEvents LabPvEStart As Label
    Friend WithEvents PicPvEStartGame As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdTestTheme As Button
    Friend WithEvents ThemeComboBox As ComboBox
    Friend WithEvents cmdConnectHTTP As Button
    Friend WithEvents txtCode As TextBox
    Friend WithEvents HTTPBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabCode As Label
    Friend WithEvents cmdNewPublicGame As Button
    Friend WithEvents cmdNewPrivateGame As Button
    Friend WithEvents HeaderTransparencyLeft As PictureBox
    Friend WithEvents HeaderTransparencyRight As PictureBox

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Friend WithEvents JoinBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicClosePvPHTTP As PictureBox
    Friend WithEvents LabHTTPCreate As Label
    Friend WithEvents LabHTTPJoin As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabHTTPConnect As Label
    Friend WithEvents PanelPvP2 As Panel
    Friend WithEvents HTTPCreateGamePanel As Panel
    Friend WithEvents LabHTTPCreate2 As Label
    Friend WithEvents LabHTTPAttempts As Label
    Friend WithEvents LabHTTPAttemptsCaption As Label
    Friend WithEvents PicHTTPAttempts As PictureBox
    Friend WithEvents LabHTTPHoles As Label
    Friend WithEvents LabHTTPHolesCaption As Label
    Friend WithEvents PicHTTPHoles As PictureBox
    Friend WithEvents LabHTTPColors2 As Label
    Friend WithEvents LabHTTPNewGame As Label
    Friend WithEvents HTTPJoinPanel As Panel
    Friend WithEvents LabHTTPConnect2 As Label
    Friend WithEvents LabCode2 As Label
    Friend WithEvents LabHTTPJoin2 As Label
    Friend WithEvents PicHTTPClose As PictureBox
    Friend WithEvents HTTPColorsPanel As Panel
    Friend WithEvents HTTPCol8 As PictureBox
    Friend WithEvents HTTPCol7 As PictureBox
    Friend WithEvents HTTPCol6 As PictureBox
    Friend WithEvents HTTPCol5 As PictureBox
    Friend WithEvents HTTPCol4 As PictureBox
    Friend WithEvents HTTPCol3 As PictureBox
    Friend WithEvents HTTPCol2 As PictureBox
    Friend WithEvents HTTPCol1 As PictureBox
    Friend WithEvents PicLoading As PictureBox
    Friend WithEvents LoadingSpinTimer As Timer
    Friend WithEvents LabStatusTitle As Label
End Class
