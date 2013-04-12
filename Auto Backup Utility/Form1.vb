Imports Microsoft.Win32

Public Class Form1

    ' Functions
    Private Sub StartBackup()
        ' Error Messages
        If (InputTxt.Text = Nothing) Then
            MessageBox.Show("You need to select a file to backup!", "ABU - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (OutputTxt.Text = Nothing) Then
            MessageBox.Show("You need to select a output directory!", "ABU - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (IntervalNumeric.Value = 0) Or (IntervalCombo.Text = Nothing) Then
            MessageBox.Show("You need to set a backup interval!", "ABU - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Sets up the timer interval for Minutes, Hours, and Days.
            Select Case IntervalCombo.Text
                Case "Minute(s)"
                    BackupTimer.Interval = IntervalNumeric.Value * 60000
                Case "Hour(s)"
                    BackupTimer.Interval = IntervalNumeric.Value * 60000 * 60
                Case "Day(s)"
                    BackupTimer.Interval = IntervalNumeric.Value * 60000 * 60 * 24
            End Select

            'Starts backup and countdown process.
            BackupTimer.Start()

            ' Changes the Status , and the Button text to "Stop".
            StatusLabel.Text = "Online"
            StatusLabel.ForeColor = Color.Lime
            StartBtn.Text = "Stop"

            ' Disables Settings
            SettingsGroup.Enabled = False

            ' Logs 'Backup Process Started.'
            LogBox.AppendText("[" + TimeOfDay + "]" + " Backup Process Started.")
            LogBox.AppendText(vbNewLine)
        End If
    End Sub

    Private Sub Backup()

        ' Full Time
        Dim time As String = TimeOfDay.Hour.ToString + "." + TimeOfDay.Minute.ToString + "." + TimeOfDay.Second.ToString

        ' Splits the Input FileName
        Dim fileName() As String = Split(InputTxt.Text, "\")

        ' gets the files ext
        Dim backupInfo As IO.FileInfo = New IO.FileInfo(InputTxt.Text)

        ' Sets the Output/FileName of the file
        Dim Output As String = OutputTxt.Text + "\" + Date.Today.ToLongDateString + "\" + "Backup of [" + fileName(fileName.Length - 1) + "] at " + time + backupInfo.Extension

        Try
            ' Stops the process.
            BackupTimer.Stop()

            ' Checks to see if its copying a file or directory
            If (DbRadio.Checked) Then
                ' Copies the file.
                My.Computer.FileSystem.CopyFile(InputTxt.Text, Output)
            Else
                ' Copies the directory
                My.Computer.FileSystem.CopyDirectory(InputTxt.Text, Output, True)
            End If

            ' Logs "Backup Complete."
            LogBox.SelectionColor = Color.Green
            LogBox.AppendText("[" + TimeOfDay + "]" + " Backup Complete." + vbNewLine)

            ' If the program is minimized to the tray.
            If (ABUNotify.Visible = True) And (NotifyChk.Checked = True) Then
                ABUNotify.BalloonTipTitle = "Auto Backup Utility"
                ABUNotify.BalloonTipText = "Backup Complete."
                ABUNotify.BalloonTipIcon = ToolTipIcon.Info
                ABUNotify.ShowBalloonTip(5000)
            End If

            ' Restarts the process.
            BackupTimer.Start()

        Catch ex As Exception
            ' Logs 'An Error has occured!'
            LogBox.SelectionColor = Color.Red
            LogBox.AppendText("[" + TimeOfDay + "]" + " An Error has occured!" + vbNewLine)

            ' Stops Backup Process
            StopBackup()

            ' Displays Errors
            MessageBox.Show(ex.ToString + vbNewLine + vbNewLine + "Take a screenshot and post it on the program's thread.", "Auto Backup Utility - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StopBackup()
        ' Stops the Backup Process.
        BackupTimer.Stop()

        ' Logs 'Backup Process Stoped.'
        LogBox.AppendText("[" + TimeOfDay + "]" + " Backup Process Stoped." + vbNewLine)

        ' Changes Button Text, Status label Text and Color.
        StartBtn.Text = "Start"
        StatusLabel.Text = "Offline"
        StatusLabel.ForeColor = Color.Red

        ' Enables Settings
        SettingsGroup.Enabled = True
    End Sub

    Private Sub SaveABUSettings()
        ' Checks the Backup Type
        Dim BackupType As Integer
        If (DbRadio.Checked) Then
            BackupType = 0
        Else
            BackupType = 1
        End If

        ' Sets the settings
        If (RememberLastChk.Checked) Then
            My.Settings.BackupType = BackupType
            My.Settings.InputFile = InputTxt.Text
            My.Settings.OutputDir = OutputTxt.Text
            My.Settings.IntervalNum = IntervalNumeric.Value
            My.Settings.IntervalCombo = IntervalCombo.Text
        End If
        My.Settings.CheckBoxValue1 = RememberLastChk.CheckState
        My.Settings.CheckBoxValue2 = NotifyChk.CheckState
        My.Settings.CheckBoxValue3 = MinTrayChk.CheckState
        My.Settings.CheckBoxValue4 = CheckUpdatesChk.CheckState
        My.Settings.StartWindows = ChkStartWithWindows.CheckState
        My.Settings.StartBackup = ChkStartBackup.CheckState
        My.Settings.Save()
    End Sub

    Private Sub LoadABUSettings()
        ' Loads settings
        RememberLastChk.CheckState = My.Settings.CheckBoxValue1
        NotifyChk.CheckState = My.Settings.CheckBoxValue2
        MinTrayChk.CheckState = My.Settings.CheckBoxValue3
        CheckUpdatesChk.CheckState = My.Settings.CheckBoxValue4
        ChkStartWithWindows.CheckState = My.Settings.StartWindows
        ChkStartBackup.CheckState = My.Settings.StartBackup

        ' Loads Backup Settings
        If (RememberLastChk.Checked) Then
            ' Sets backup type
            If (My.Settings.BackupType = 0) Then
                DbRadio.Checked = True
            Else
                DirectoryRadio.Checked = True
            End If

            InputTxt.Text = My.Settings.InputFile
            OutputTxt.Text = My.Settings.OutputDir
            IntervalNumeric.Value = My.Settings.IntervalNum
            IntervalCombo.Text = My.Settings.IntervalCombo
        End If
    End Sub

    Private Sub CheckForUpdates()
        ' Checks to see if computer is online.
        If (My.Computer.Network.IsAvailable) Then
            Try
                ' Downloads update info
                My.Computer.Network.DownloadFile("http://www.freewebs.com/wovaki/updates/abuInfo.txt", "abuInfo.txt", "", "", False, 100000, True)

                ' Loads update info
                Dim updateInfo As Double = My.Computer.FileSystem.ReadAllText("abuInfo.txt")

                ' Checks if update is newer
                If (updateInfo > Form2.versionLabel.Text) Then

                    ' Increases height
                    Me.Height = 355

                    ' Enables update labels
                    Label4.Enabled = True
                    updateLink.Enabled = True
                End If

                ' Deletes update file
                My.Computer.FileSystem.DeleteFile("abuInfo.txt")

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "ABU - Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Control Functions
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Checks to see if this is the first run
        'If (My.Settings.FirstRun = True) Then
        '    ' Disclaimer
        '    Dim disclaimerText As String = "You agree that:" + vbNewLine + "1. Use of this software is at your sole risk." _
        '    + vbNewLine + "2. In no Event shall wovaki be liable for any damages done to your computer, loss of data, corrupt " _
        '    + "or damaged files, or anything else caused by downloading and/or using this program." + vbNewLine + vbNewLine _
        '    + "If you DO NOT agree to the above terms, usage of this program is to be terminated and all copies are to be deleted." _
        '    + vbNewLine + vbNewLine + "By clicking 'Yes' you agree to the above terms."

        '    ' If the user agrees
        '    If (MessageBox.Show(disclaimerText, "ABU Disclaimer", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes) Then
        '        'My.Settings.FirstRun = False
        '        'My.Settings.Save()
        '    Else
        '        Application.Exit()
        '    End If
        'End If

        ' Logs 'Backup Utility Started'
        LogBox.AppendText("[" + TimeOfDay + "]" + " Auto Backup Utility Started." + vbNewLine)

        ' Loads ABU Settings
        LoadABUSettings()

        ' Updates
        If (CheckUpdatesChk.Checked) Then
            CheckForUpdates()
        End If

        ' Auto Start
        If (ChkStartBackup.Enabled) And (ChkStartBackup.Checked) Then
            StartBackup()
        End If
    End Sub

    Private Sub InputBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputBtn.Click
        Dim ofd As Object

        ' Database only
        If (DbRadio.Checked) Then
            ofd = New OpenFileDialog

            ofd.CheckFileExists = True
            ofd.Title = "Select file to backup."
            ofd.Filter = "All Files |*.*"
            ofd.FilterIndex = 1
            If (ofd.ShowDialog = DialogResult.OK) Then
                InputTxt.Text = ofd.FileName
            End If

        Else ' Whole Server
            ofd = New FolderBrowserDialog

            If (ofd.ShowDialog() = DialogResult.OK) Then
                InputTxt.Text = ofd.SelectedPath
            End If
        End If
    End Sub

    Private Sub OutputBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutputBtn.Click
        Dim sfd As New FolderBrowserDialog()

        sfd.Description = "Select a location to save backups."
        If (sfd.ShowDialog() = DialogResult.OK) Then
            OutputTxt.Text = sfd.SelectedPath
        End If
    End Sub

    Private Sub StartBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBtn.Click
        If StartBtn.Text = "Start" Then
            StartBackup()
        Else
            StopBackup()
        End If
    End Sub

    Private Sub BackupTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupTimer.Tick
        Backup()
    End Sub

    Private Sub ABUNotify_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ABUNotify.MouseDoubleClick
        Me.Show()
        ABUNotify.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ShowProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowProgramToolStripMenuItem.Click
        ' Show the program and removes Tray Icon.
        Me.Show()
        ABUNotify.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ABUNotify.Visible = False
        ' Closes the program.
        Application.Exit()
    End Sub

    Private Sub Form1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If (MinTrayChk.Checked) Then
            If (Me.WindowState = FormWindowState.Minimized) Then
                ' Makes the NotifyIcon Visible
                ABUNotify.Visible = True

                ' Hides the program.
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ABUNotify.Visible = False

        ' Saves ABU Settings
        SaveABUSettings()
    End Sub

    Private Sub SaveLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveLogToolStripMenuItem.Click
        Dim logSave As New SaveFileDialog()

        logSave.Title = "Save ABU Backup Log."
        logSave.DefaultExt = "*.txt"
        logSave.Filter = "Text Files|*.txt"

        If (logSave.ShowDialog() = Windows.Forms.DialogResult.OK) And (logSave.FileName.Length > 0) Then
            LogBox.SaveFile(logSave.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ClearLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to clear the log?", "Auto Backup Utility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LogBox.Clear()
        End If
    End Sub

#Region "Options Descriptions"
    Private Sub RememberLastChk_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RememberLastChk.MouseHover
        DescriptionBox.Text = "ABU will automatically remember all your backup settings." + vbNewLine + vbNewLine + "Including: 'File to Backup', 'Output Directory', and the 'Backup Interval'"
    End Sub

    Private Sub NotifyChk_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyChk.MouseHover
        DescriptionBox.Text = "ABU will notify you with a 'Balloon' message in the bottom right corner of your screen when a backup is complete." + vbNewLine + vbNewLine + "Note: Only when minimized to tray."
    End Sub

    Private Sub MinTrayChk_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinTrayChk.MouseHover
        DescriptionBox.Text = "ABU will Minimize to the System Tray (By the clock) when you minimize the program."
    End Sub

    Private Sub StartWindowsChk_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckUpdatesChk.MouseHover
        DescriptionBox.Text = "ABU will check for updates on startup."
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        DescriptionBox.Text = "Hover your mouse over any of the Checkbox's to get a description on what they do."
    End Sub

    Private Sub ChkStartWithWindows_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkStartWithWindows.MouseHover
        DescriptionBox.Text = "ABU will start up when windows starts."
    End Sub

    Private Sub ChkStartBackup_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkStartBackup.MouseHover
        DescriptionBox.Text = "ABU will automatically start the backup process if all the backup options are filled out."
    End Sub
#End Region

    Private Sub AboutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBtn.Click
        Form2.Show()
    End Sub

    Private Sub updateLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles updateLink.LinkClicked
        Try
            ' Brings up download page
            System.Diagnostics.Process.Start("http://www.freewebs.com/wovaki/downloads.htm")

            ' Decreases height
            Do Until Me.Height = 331
                Me.Height -= 1
            Loop

            ' Disables update labels
            Label4.Enabled = False
            updateLink.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ABU - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RememberLastChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RememberLastChk.CheckedChanged
        If (RememberLastChk.Checked) Then
            ChkStartBackup.Enabled = True
        Else
            ChkStartBackup.Enabled = False
        End If
    End Sub

    Private Sub ChkStartWithWindows_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkStartWithWindows.CheckedChanged
        Dim regKey As RegistryKey

        If (ChkStartWithWindows.Checked) Then
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue("Auto Backup Utility v1.3", Application.ExecutablePath)
            regKey.Close()
        Else
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.DeleteValue("Auto Backup Utility v1.3")
        End If
    End Sub
End Class
