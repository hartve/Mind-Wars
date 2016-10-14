﻿Public Class StartScreen

    Dim ButtonLabList As New List(Of Label)
    Dim ButtonSettingsList As New List(Of PictureBox)
    Dim ButtonPvEList As New List(Of PictureBox)
    Dim PvEColorList As New List(Of PictureBox)

    Dim PvEHoles As Integer = 4
    Dim PvEColors As Integer = 6
    Dim PvEAttempts As Integer = 10

    Dim SelectedButtonListIndex As Integer = 0
    Dim SelectedSettingsListIndex As Integer = 0

    Dim VisiblePanel As Integer = 0

    Dim CursorX As Integer, CursorY As Integer
    Dim DragForm As Boolean = False

    Dim FocusedLabelAddColor As Integer = 0
    Dim FocusedLabelColorIncreasing As Boolean = True
    Dim FocusedLabel As Label

    Dim DifficultyDrawRect As New Rectangle
    Dim ThemeDrawRect As New Rectangle
    Dim SoundDrawRect As New Rectangle

    Dim PvEFocusedCategory As Integer = 0
    Dim SelectedPvEListIndex As Integer = 0
    Dim FocusedPvEColorListIndex As Integer = 2
    Dim SelectedPvEDifficulty As Integer = 1

    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitializeGUI()
        Call SelectButton(False)
    End Sub

    Private Sub InitializeGUI()

        With LabSettings
            .Parent = PicStartButton_Settings
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With LabPvE
            .Parent = PicStartButton_PvE
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With LabPvPLan
            .Parent = PicStartButton_PvPLan
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With LabPvPHTTP
            .Parent = PicStartButton_PvPHTTP
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With LabTutorial
            .Parent = PicStartButton_Tutorial
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With LabSettingsTheme
            .Parent = PicSettingsTheme
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With LabSettingsSound
            .Parent = PicSettingSound
            .Height = .Parent.Height
            .Width = .Parent.Width
            .Left = 0
            .Top = 0
        End With
        With ButtonLabList
            .Add(LabSettings)
            .Add(LabPvE)
            .Add(LabPvPLan)
            .Add(LabPvPHTTP)
            .Add(LabTutorial)
        End With
        With ButtonSettingsList
            .Add(PicCloseSettings)
        End With

        With LabPvEColors
            .Parent = PicPvEChooseColors
            .Height = .Parent.Height
            .Width = .Parent.Width
        End With
        With LabPvENumberOfHolesButton
            .Parent = PicPvEChooseHoles
            .Height = .Parent.Height
        End With
        With LabPvENumberOfHoles
            .Parent = PicPvEChooseHoles
            .Height = .Parent.Height
        End With
        With LabPvENumberOfAttemptsButton
            .Parent = PicPvEChooseAttempts
            .Height = .Parent.Height
        End With
        With LabPvENumberOfAttempts
            .Parent = PicPvEChooseAttempts
            .Height = .Parent.Height
        End With

        With ButtonPvEList
            .Add(PicClosePvE)
            .Add(PicDifficulty1)
            .Add(PicDifficulty2)
            .Add(PicDifficulty3)
            .Add(PicPvEChooseColors)
            .Add(PicPvEChooseHoles)
            .Add(PicPvEChooseAttempts)
            .Add(PicPvEStartGame)
        End With


        With PicCloseForm
            .Parent = PicFormHeader
        End With
        With PicMinimizeForm
            .Parent = PicFormHeader
        End With

        PicSettingsButton2.Dock = DockStyle.Fill
        PicSettingsButton2.BringToFront()
        PanelPvE.Dock = DockStyle.Fill
        PanelPvE.BringToFront()
        PanelPvPLan.Dock = DockStyle.Fill
        PanelPvPLan.BringToFront()
        PanelPvPHTTP.Dock = DockStyle.Fill
        PanelPvPHTTP.BringToFront()
        PanelTutorial.Dock = DockStyle.Fill
        PanelTutorial.BringToFront()
        PicFormHeader.Dock = DockStyle.Top
        ButtonsPanel.SendToBack()

        With PvEColorList
            .Add(PicPvEColor1)
            .Add(PicPvEColor2)
            .Add(PicPvEColor3)
            .Add(PicPvEColor4)
            .Add(PicPvEColor5)
            .Add(PicPvEColor6)
            .Add(PicPvEColor7)
            .Add(PicPvEColor8)
        End With

    End Sub

    Sub SelectButton(ByVal deselect As Boolean)
        Select Case VisiblePanel
            Case 0
                Dim Selection As Label = ButtonLabList.Item(SelectedButtonListIndex)
                If deselect = True Then
                    With Selection
                        .Parent.BackgroundImage = My.Resources.ButtonBorderInactive
                        .ForeColor = Color.SteelBlue
                    End With
                Else
                    With Selection
                        .Parent.BackgroundImage = My.Resources.ButtonBorderActive1
                        .ForeColor = Color.LightCyan
                    End With
                End If
            Case 1
                Dim Selection As PictureBox = ButtonSettingsList.Item(SelectedSettingsListIndex)
                If deselect = True Then
                    With Selection
                        If SelectedSettingsListIndex = 0 Then
                            .BackgroundImage = My.Resources.ButtonBackInactive
                        Else
                            .BackgroundImage = My.Resources.ButtonBorderInactive
                            .ForeColor = Color.SteelBlue
                        End If
                    End With
                Else
                    With Selection
                        If SelectedSettingsListIndex = 0 Then
                            .BackgroundImage = My.Resources.ButtonBackActive
                        Else
                            .ForeColor = Color.LightCyan
                        End If
                    End With
                End If
            Case 1
            Case 2
                Dim Selection As PictureBox = ButtonPvEList.Item(SelectedPvEListIndex)
                If SelectedPvEListIndex = 1 OrElse SelectedPvEListIndex = 2 OrElse SelectedPvEListIndex = 3 Then
                    If deselect = True Then
                        Selection.Invalidate()
                        'Selection.BackColor = Color.Red
                    Else
                        Selection.Invalidate()
                        'Selection.BackColor = Color.Green
                    End If
                ElseIf SelectedPvEListIndex = 0 Then
                    If deselect = True Then
                        Selection.BackgroundImage = My.Resources.ButtonBackInactive
                    Else
                        Selection.BackgroundImage = My.Resources.ButtonBackActive1
                    End If
                ElseIf SelectedPvEListIndex = 4 OrElse SelectedPvEListIndex = 7 Then
                    If deselect = True Then
                        Selection.BackgroundImage = My.Resources.SettingsButtonInactive
                    Else
                        Selection.BackgroundImage = My.Resources.SettingsButtonActive
                    End If
                ElseIf SelectedPvEListIndex = 5 OrElse SelectedPvEListIndex = 6 Then
                    If deselect = True Then
                        Selection.BackgroundImage = My.Resources.NumberSettings00
                    Else
                        Selection.BackgroundImage = My.Resources.NumberSettings10
                    End If
                End If
        End Select
    End Sub

    Sub ButtonMouseEnter(sender As Object, e As EventArgs) Handles LabSettings.MouseEnter, LabPvE.MouseEnter, LabPvPLan.MouseEnter, LabPvPHTTP.MouseEnter, PicCloseSettings.MouseEnter
        Select Case VisiblePanel
            Case 0
                If Not sender.TabIndex = SelectedButtonListIndex Then
                    Call SelectButton(True)
                    SelectedButtonListIndex = sender.TabIndex
                    Call SelectButton(False)
                End If
            Case 1
                If Not sender.Tag = SelectedSettingsListIndex Then
                    Call SelectButton(True)
                    SelectedSettingsListIndex = sender.Tag
                    Call SelectButton(False)
                End If
        End Select
    End Sub

    Private Sub StartScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Not VisiblePanel = 0 Then
                PicSettingsButton2.Hide()
                PanelPvE.Hide()
                PanelPvPLan.Hide()
                PanelPvPHTTP.Hide()
                PanelTutorial.Hide()
                VisiblePanel = 0
                e.Handled = True
            Else
                Close()
            End If
        End If

        Select Case VisiblePanel
            Case 0
                Select Case e.KeyCode
                    Case Keys.Up
                        If Not SelectedButtonListIndex = 0 Then
                            Call SelectButton(True)
                            SelectedButtonListIndex -= 1
                            Call SelectButton(False)
                        End If

                    Case Keys.Down
                        If Not SelectedButtonListIndex = ButtonLabList.Count - 1 Then
                            Call SelectButton(True)
                            SelectedButtonListIndex += 1
                            Call SelectButton(False)
                        End If
                    Case Keys.Tab
                        Call SelectButton(True)
                        If Not SelectedButtonListIndex = ButtonLabList.Count - 1 Then
                            SelectedButtonListIndex += 1
                        Else
                            SelectedButtonListIndex = 0
                        End If
                        Call SelectButton(False)
                    Case Keys.Space, Keys.Enter
                        Call EnterSelected()
                End Select
            Case 1
            Case 2
                Select Case e.KeyCode
                    Case Keys.Down
                        If PvEFocusedCategory = 0 Then
                            If Not SelectedPvEListIndex = ButtonPvEList.Count - 1 Then
                                Call SelectButton(True)
                                If SelectedPvEListIndex = 1 Then
                                    SelectedPvEListIndex += 3
                                ElseIf SelectedPvEListIndex = 2 Then
                                    SelectedPvEListIndex += 2
                                ElseIf SelectedPvEListIndex = 0 Then
                                    SelectedPvEListIndex = SelectedPvEDifficulty
                                Else
                                    SelectedPvEListIndex += 1
                                End If
                                Call SelectButton(False)
                            End If
                        ElseIf PvEFocusedCategory = 1 Then
                            ' This category contains the collection of colors. The down key should be ignored.
                        ElseIf PvEFocusedCategory = 2 Then
                            If PvEHoles > 3 Then
                                PvEHoles -= 1
                                LabPvENumberOfHoles.Text = PvEHoles
                            End If
                        ElseIf PvEFocusedCategory = 3 Then
                            If PvEAttempts > 4 Then
                                PvEAttempts -= 1
                                LabPvENumberOfAttempts.Text = PvEAttempts
                            End If
                        End If
                    Case Keys.Up
                        If PvEFocusedCategory = 0 Then
                            If Not SelectedPvEListIndex = 0 Then
                                Call SelectButton(True)
                                If SelectedPvEListIndex = 2 Then
                                    SelectedPvEListIndex -= 2
                                ElseIf SelectedPvEListIndex = 3 Then
                                    SelectedPvEListIndex -= 3
                                ElseIf SelectedPvEListIndex = 4 Then
                                    SelectedPvEListIndex = SelectedPvEDifficulty
                                Else
                                    SelectedPvEListIndex -= 1
                                End If
                                Call SelectButton(False)
                            End If
                        ElseIf PvEFocusedCategory = 1 Then
                            ' This category contains the collection of colors. The down up should be ignored.
                        ElseIf PvEFocusedCategory = 2 Then
                            If PvEHoles < 8 Then
                                PvEHoles += 1
                                LabPvENumberOfHoles.Text = PvEHoles
                            End If
                        ElseIf PvEFocusedCategory = 3 Then
                            If PvEAttempts < 14 Then
                                PvEAttempts += 1
                                LabPvENumberOfAttempts.Text = PvEAttempts
                            End If
                        End If
                    Case Keys.Left
                        If PvEFocusedCategory = 1 Then
                            If FocusedPvEColorListIndex > 2 Then
                                Call SelectColor(True)
                                FocusedPvEColorListIndex -= 1
                                Call SelectColor(False)
                            End If
                        ElseIf SelectedPvEListIndex = 2 OrElse SelectedPvEListIndex = 3 Then
                            If SelectedPvEDifficulty > 1 Then
                                Call SelectButton(True)
                                SelectedPvEDifficulty -= 1
                                SelectedPvEListIndex -= 1
                                Call SelectButton(False)
                            End If
                        End If
                    Case Keys.Right
                        If PvEFocusedCategory = 1 Then
                            If FocusedPvEColorListIndex < 8 Then
                                Call SelectColor(True)
                                FocusedPvEColorListIndex += 1
                                Call SelectColor(False)
                            End If
                        ElseIf SelectedPvEListIndex = 1 OrElse SelectedPvEListIndex = 2 Then
                            If SelectedPvEDifficulty < 3 Then
                                Call SelectButton(True)
                                SelectedPvEDifficulty += 1
                                SelectedPvEListIndex += 1
                                Call SelectButton(False)
                            End If
                        End If
                End Select
        End Select
    End Sub

    Sub SelectColor(ByVal deselect As Boolean)
        Dim SelectedColor As PictureBox = PvEColorList.Item(FocusedPvEColorListIndex)
        If deselect = True Then
            SelectedColor.BackColor = Color.FromArgb(50, SelectedColor.BackColor)
        Else
            SelectedColor.BackColor = Color.FromArgb(255, SelectedColor.BackColor)
        End If
    End Sub

    Sub EnterSelected()
        Select Case VisiblePanel
            Case 0
                Select Case SelectedButtonListIndex
                    Case 0
                        VisiblePanel = 1
                        PicSettingsButton2.Show()
                    Case 1
                        VisiblePanel = 2
                        PanelPvE.Show()
                    Case 2
                        VisiblePanel = 3
                        PanelPvPLan.Show()
                    Case 3
                        VisiblePanel = 4
                        PanelPvPHTTP.Show()
                    Case 4
                        VisiblePanel = 5
                        PanelTutorial.Show()
                End Select
            Case 1
                Select Case SelectedSettingsListIndex
                    Case 0
                        PicSettingsButton2.Hide()
                        VisiblePanel = 0
                End Select
        End Select
    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles LabSettings.Click, LabPvE.Click, LabPvPLan.Click, LabPvPHTTP.Click
        Call EnterSelected()
    End Sub

    Private Sub ClosePanel(sender As Object, e As EventArgs) Handles PicClosePvE.Click, PicClosePvPLAN.Click, PicClosePvPHTTP.Click, PicCloseTutorial.Click
        VisiblePanel = 0
        sender.Parent.Hide()
    End Sub

    Private Sub PicFormHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PicFormHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            DragForm = True
            CursorX = Cursor.Position.X - Me.Left
            CursorY = Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub PicFormHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PicFormHeader.MouseMove
        If DragForm = True Then
            Me.Left = Cursor.Position.X - CursorX
            Me.Top = Cursor.Position.Y - CursorY
        End If
    End Sub

    Private Sub GUITimer_Tick(sender As Object, e As EventArgs) Handles GUITimer.Tick
        FocusedLabel = ButtonLabList.Item(SelectedButtonListIndex)
        FocusedLabel.ForeColor = Color.FromArgb(255, 150 + (FocusedLabelAddColor / 1.5), 230 + (FocusedLabelAddColor / 4), 255)
        If FocusedLabelColorIncreasing = True Then
            If FocusedLabelAddColor >= 100 Then
                FocusedLabelColorIncreasing = False
            Else
                FocusedLabelAddColor += 5
            End If
        Else
            If FocusedLabelAddColor <= 0 Then
                FocusedLabelAddColor = 0
                FocusedLabelColorIncreasing = True
            Else
                FocusedLabelAddColor -= 5
            End If
        End If
    End Sub

    Private Sub PicCloseForm_Click(sender As Object, e As EventArgs) Handles PicCloseForm.Click
        Me.Close()
    End Sub

    Private Sub PicFormHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PicFormHeader.MouseUp
        DragForm = False
    End Sub

    Private Sub PicMinimizeForm_MouseEnter(sender As Object, e As EventArgs) Handles PicMinimizeForm.MouseEnter
        PicMinimizeForm.BackgroundImage = My.Resources.MinimizeHover
    End Sub

    Private Sub PicMinimizeForm_MouseLeave(sender As Object, e As EventArgs) Handles PicMinimizeForm.MouseLeave
        PicMinimizeForm.BackgroundImage = My.Resources.Minimize
    End Sub

    Private Sub PicCloseForm_MouseEnter(sender As Object, e As EventArgs) Handles PicCloseForm.MouseEnter
        PicCloseForm.BackgroundImage = My.Resources.ExitHover
    End Sub

    Private Sub PicDifficulty1_Click(sender As Object, e As EventArgs) Handles PicDifficulty1.Click
        MsgBox(PicDifficulty1.ClientRectangle.Width)
    End Sub

    Private Sub PicCloseForm_MouseLeave(sender As Object, e As EventArgs) Handles PicCloseForm.MouseLeave
        PicCloseForm.BackgroundImage = My.Resources.Exit1
    End Sub

    Private Sub PanelPvE_Paint(sender As Object, e As PaintEventArgs) Handles PanelPvE.Paint

    End Sub

    Private Sub PanelSettings_Paint(sender As Object, e As PaintEventArgs) Handles PicSettingsButton2.Paint

    End Sub

    Private Sub PicDifficulty1_Paint(sender As Object, e As PaintEventArgs) Handles PicDifficulty1.Paint, PicDifficulty2.Paint, PicDifficulty3.Paint
        DifficultyDrawRect = sender.DisplayRectangle
        DifficultyDrawRect.Inflate(-1, -1)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        If sender.Tag = SelectedPvEDifficulty Then
            e.Graphics.DrawRectangle(Pens.LightCyan, DifficultyDrawRect)
        Else
            e.Graphics.DrawEllipse(Pens.Cyan, DifficultyDrawRect)
        End If
    End Sub

    Private Sub PicTheme_Paint(sender As Object, e As PaintEventArgs) Handles PicTheme1.Paint, PicTheme2.Paint, PicTheme3.Paint
        ThemeDrawRect = sender.DisplayRectangle
        ThemeDrawRect.Inflate(-1, -1)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        If sender.Tag = "test" Then
            e.Graphics.DrawEllipse(Pens.Red, ThemeDrawRect)
        Else
            e.Graphics.DrawEllipse(Pens.LightCyan, ThemeDrawRect)
        End If
    End Sub

    Private Sub PicSound_Paint(sender As Object, e As PaintEventArgs) Handles PicSound1.Paint, PicSound2.Paint, PicSound3.Paint
        SoundDrawRect = sender.DisplayRectangle
        SoundDrawRect.Inflate(-1, -1)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        If sender.Tag = "test" Then
            e.Graphics.DrawEllipse(Pens.Red, SoundDrawRect)
        Else
            e.Graphics.DrawEllipse(Pens.LightCyan, SoundDrawRect)
        End If
    End Sub

    Private Sub PanelPvE_KeyDown(sender As Object, e As KeyEventArgs) Handles PanelPvE.KeyDown
        MsgBox("Test")
    End Sub
End Class
