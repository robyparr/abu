<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.StartBtn = New System.Windows.Forms.Button
        Me.SettingsGroup = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.IntervalCombo = New System.Windows.Forms.ComboBox
        Me.IntervalNumeric = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.OutputBtn = New System.Windows.Forms.Button
        Me.InputBtn = New System.Windows.Forms.Button
        Me.OutputTxt = New System.Windows.Forms.TextBox
        Me.InputTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DirectoryRadio = New System.Windows.Forms.RadioButton
        Me.DbRadio = New System.Windows.Forms.RadioButton
        Me.AboutBtn = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DescriptionBox = New System.Windows.Forms.RichTextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ChkStartBackup = New System.Windows.Forms.CheckBox
        Me.ChkStartWithWindows = New System.Windows.Forms.CheckBox
        Me.CheckUpdatesChk = New System.Windows.Forms.CheckBox
        Me.MinTrayChk = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.NotifyChk = New System.Windows.Forms.CheckBox
        Me.RememberLastChk = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.LogBox = New System.Windows.Forms.RichTextBox
        Me.LogContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ABUNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.updateLink = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SettingsGroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IntervalNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.LogContextMenu.SuspendLayout()
        Me.NotifyContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 283)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(292, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(277, 17)
        Me.ToolStripStatusLabel1.Text = "Created by: Wovaki                                    Version: 1.3"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(292, 284)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.StartBtn)
        Me.TabPage1.Controls.Add(Me.SettingsGroup)
        Me.TabPage1.Controls.Add(Me.AboutBtn)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(284, 258)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Backup"
        '
        'StartBtn
        '
        Me.StartBtn.Location = New System.Drawing.Point(105, 232)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 3
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'SettingsGroup
        '
        Me.SettingsGroup.Controls.Add(Me.GroupBox2)
        Me.SettingsGroup.Controls.Add(Me.OutputBtn)
        Me.SettingsGroup.Controls.Add(Me.InputBtn)
        Me.SettingsGroup.Controls.Add(Me.OutputTxt)
        Me.SettingsGroup.Controls.Add(Me.InputTxt)
        Me.SettingsGroup.Controls.Add(Me.Label2)
        Me.SettingsGroup.Controls.Add(Me.Label1)
        Me.SettingsGroup.Controls.Add(Me.DirectoryRadio)
        Me.SettingsGroup.Controls.Add(Me.DbRadio)
        Me.SettingsGroup.Location = New System.Drawing.Point(8, 60)
        Me.SettingsGroup.Name = "SettingsGroup"
        Me.SettingsGroup.Size = New System.Drawing.Size(270, 169)
        Me.SettingsGroup.TabIndex = 2
        Me.SettingsGroup.TabStop = False
        Me.SettingsGroup.Text = "Backup Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IntervalCombo)
        Me.GroupBox2.Controls.Add(Me.IntervalNumeric)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 39)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Backup Interval"
        '
        'IntervalCombo
        '
        Me.IntervalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IntervalCombo.FormattingEnabled = True
        Me.IntervalCombo.Items.AddRange(New Object() {"Minute(s)", "Hour(s)", "Day(s)"})
        Me.IntervalCombo.Location = New System.Drawing.Point(166, 13)
        Me.IntervalCombo.Name = "IntervalCombo"
        Me.IntervalCombo.Size = New System.Drawing.Size(74, 21)
        Me.IntervalCombo.TabIndex = 2
        '
        'IntervalNumeric
        '
        Me.IntervalNumeric.Location = New System.Drawing.Point(113, 14)
        Me.IntervalNumeric.Name = "IntervalNumeric"
        Me.IntervalNumeric.Size = New System.Drawing.Size(47, 20)
        Me.IntervalNumeric.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Backup once every"
        '
        'OutputBtn
        '
        Me.OutputBtn.Location = New System.Drawing.Point(239, 94)
        Me.OutputBtn.Name = "OutputBtn"
        Me.OutputBtn.Size = New System.Drawing.Size(25, 23)
        Me.OutputBtn.TabIndex = 4
        Me.OutputBtn.Text = "..."
        Me.OutputBtn.UseVisualStyleBackColor = True
        '
        'InputBtn
        '
        Me.InputBtn.Location = New System.Drawing.Point(239, 54)
        Me.InputBtn.Name = "InputBtn"
        Me.InputBtn.Size = New System.Drawing.Size(25, 23)
        Me.InputBtn.TabIndex = 4
        Me.InputBtn.Text = "..."
        Me.InputBtn.UseVisualStyleBackColor = True
        '
        'OutputTxt
        '
        Me.OutputTxt.Location = New System.Drawing.Point(7, 97)
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.Size = New System.Drawing.Size(226, 20)
        Me.OutputTxt.TabIndex = 3
        '
        'InputTxt
        '
        Me.InputTxt.Location = New System.Drawing.Point(7, 57)
        Me.InputTxt.Name = "InputTxt"
        Me.InputTxt.Size = New System.Drawing.Size(226, 20)
        Me.InputTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Output Directory:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File to Backup:"
        '
        'DirectoryRadio
        '
        Me.DirectoryRadio.AutoSize = True
        Me.DirectoryRadio.Location = New System.Drawing.Point(64, 20)
        Me.DirectoryRadio.Name = "DirectoryRadio"
        Me.DirectoryRadio.Size = New System.Drawing.Size(67, 17)
        Me.DirectoryRadio.TabIndex = 1
        Me.DirectoryRadio.Text = "Directory"
        Me.DirectoryRadio.UseVisualStyleBackColor = True
        '
        'DbRadio
        '
        Me.DbRadio.AutoSize = True
        Me.DbRadio.Checked = True
        Me.DbRadio.Location = New System.Drawing.Point(7, 20)
        Me.DbRadio.Name = "DbRadio"
        Me.DbRadio.Size = New System.Drawing.Size(41, 17)
        Me.DbRadio.TabIndex = 0
        Me.DbRadio.TabStop = True
        Me.DbRadio.Text = "File"
        Me.DbRadio.UseVisualStyleBackColor = True
        '
        'AboutBtn
        '
        Me.AboutBtn.Location = New System.Drawing.Point(203, 6)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(75, 23)
        Me.AboutBtn.TabIndex = 1
        Me.AboutBtn.Text = "About"
        Me.AboutBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(6, 16)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(93, 31)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Offline"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(284, 258)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DescriptionBox)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 158)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(268, 94)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Description"
        '
        'DescriptionBox
        '
        Me.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.DescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionBox.Location = New System.Drawing.Point(3, 16)
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.ReadOnly = True
        Me.DescriptionBox.Size = New System.Drawing.Size(262, 75)
        Me.DescriptionBox.TabIndex = 0
        Me.DescriptionBox.Text = "Hover your mouse over any of the Checkbox's to get a description on what they do." & _
            ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ChkStartBackup)
        Me.GroupBox4.Controls.Add(Me.ChkStartWithWindows)
        Me.GroupBox4.Controls.Add(Me.CheckUpdatesChk)
        Me.GroupBox4.Controls.Add(Me.MinTrayChk)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(268, 73)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Program Options"
        '
        'ChkStartBackup
        '
        Me.ChkStartBackup.AutoSize = True
        Me.ChkStartBackup.Enabled = False
        Me.ChkStartBackup.Location = New System.Drawing.Point(131, 44)
        Me.ChkStartBackup.Name = "ChkStartBackup"
        Me.ChkStartBackup.Size = New System.Drawing.Size(129, 17)
        Me.ChkStartBackup.TabIndex = 3
        Me.ChkStartBackup.Text = "Start Backup Process"
        Me.ChkStartBackup.UseVisualStyleBackColor = True
        '
        'ChkStartWithWindows
        '
        Me.ChkStartWithWindows.AutoSize = True
        Me.ChkStartWithWindows.Location = New System.Drawing.Point(131, 20)
        Me.ChkStartWithWindows.Name = "ChkStartWithWindows"
        Me.ChkStartWithWindows.Size = New System.Drawing.Size(120, 17)
        Me.ChkStartWithWindows.TabIndex = 2
        Me.ChkStartWithWindows.Text = "Start With Windows"
        Me.ChkStartWithWindows.UseVisualStyleBackColor = True
        '
        'CheckUpdatesChk
        '
        Me.CheckUpdatesChk.AutoSize = True
        Me.CheckUpdatesChk.Location = New System.Drawing.Point(7, 44)
        Me.CheckUpdatesChk.Name = "CheckUpdatesChk"
        Me.CheckUpdatesChk.Size = New System.Drawing.Size(115, 17)
        Me.CheckUpdatesChk.TabIndex = 1
        Me.CheckUpdatesChk.Text = "Check for Updates"
        Me.CheckUpdatesChk.UseVisualStyleBackColor = True
        '
        'MinTrayChk
        '
        Me.MinTrayChk.AutoSize = True
        Me.MinTrayChk.Location = New System.Drawing.Point(7, 20)
        Me.MinTrayChk.Name = "MinTrayChk"
        Me.MinTrayChk.Size = New System.Drawing.Size(106, 17)
        Me.MinTrayChk.TabIndex = 0
        Me.MinTrayChk.Text = "Minimize To Tray"
        Me.MinTrayChk.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NotifyChk)
        Me.GroupBox3.Controls.Add(Me.RememberLastChk)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 67)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Backup Options"
        '
        'NotifyChk
        '
        Me.NotifyChk.AutoSize = True
        Me.NotifyChk.Location = New System.Drawing.Point(7, 44)
        Me.NotifyChk.Name = "NotifyChk"
        Me.NotifyChk.Size = New System.Drawing.Size(181, 17)
        Me.NotifyChk.TabIndex = 1
        Me.NotifyChk.Text = "Notify Me of Completed Backups"
        Me.NotifyChk.UseVisualStyleBackColor = True
        '
        'RememberLastChk
        '
        Me.RememberLastChk.AutoSize = True
        Me.RememberLastChk.Location = New System.Drawing.Point(7, 20)
        Me.RememberLastChk.Name = "RememberLastChk"
        Me.RememberLastChk.Size = New System.Drawing.Size(158, 17)
        Me.RememberLastChk.TabIndex = 0
        Me.RememberLastChk.Text = "Remember Backup Settings"
        Me.RememberLastChk.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.LogBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(284, 258)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Log"
        '
        'LogBox
        '
        Me.LogBox.ContextMenuStrip = Me.LogContextMenu
        Me.LogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogBox.Location = New System.Drawing.Point(0, 0)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.Size = New System.Drawing.Size(284, 258)
        Me.LogBox.TabIndex = 0
        Me.LogBox.Text = ""
        '
        'LogContextMenu
        '
        Me.LogContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveLogToolStripMenuItem, Me.ClearLogToolStripMenuItem})
        Me.LogContextMenu.Name = "LogContextMenu"
        Me.LogContextMenu.Size = New System.Drawing.Size(131, 48)
        '
        'SaveLogToolStripMenuItem
        '
        Me.SaveLogToolStripMenuItem.Name = "SaveLogToolStripMenuItem"
        Me.SaveLogToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SaveLogToolStripMenuItem.Text = "Save Log..."
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ClearLogToolStripMenuItem.Text = "Clear Log"
        '
        'BackupTimer
        '
        '
        'ABUNotify
        '
        Me.ABUNotify.ContextMenuStrip = Me.NotifyContextMenu
        Me.ABUNotify.Icon = CType(resources.GetObject("ABUNotify.Icon"), System.Drawing.Icon)
        Me.ABUNotify.Text = "Auto Backup Utility v1.3"
        '
        'NotifyContextMenu
        '
        Me.NotifyContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowProgramToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NotifyContextMenu.Name = "NotifyContextMenu"
        Me.NotifyContextMenu.Size = New System.Drawing.Size(153, 48)
        '
        'ShowProgramToolStripMenuItem
        '
        Me.ShowProgramToolStripMenuItem.Name = "ShowProgramToolStripMenuItem"
        Me.ShowProgramToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowProgramToolStripMenuItem.Text = "Show Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'updateLink
        '
        Me.updateLink.AutoSize = True
        Me.updateLink.Enabled = False
        Me.updateLink.Location = New System.Drawing.Point(138, 287)
        Me.updateLink.Name = "updateLink"
        Me.updateLink.Size = New System.Drawing.Size(81, 13)
        Me.updateLink.TabIndex = 2
        Me.updateLink.TabStop = True
        Me.updateLink.Text = "Download Here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(1, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "A new update is available!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 305)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.updateLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Backup Utility"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SettingsGroup.ResumeLayout(False)
        Me.SettingsGroup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.IntervalNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.LogContextMenu.ResumeLayout(False)
        Me.NotifyContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SettingsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents DirectoryRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DbRadio As System.Windows.Forms.RadioButton
    Friend WithEvents AboutBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents InputBtn As System.Windows.Forms.Button
    Friend WithEvents InputTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OutputBtn As System.Windows.Forms.Button
    Friend WithEvents OutputTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IntervalCombo As System.Windows.Forms.ComboBox
    Friend WithEvents IntervalNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StartBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NotifyChk As System.Windows.Forms.CheckBox
    Friend WithEvents RememberLastChk As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DescriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckUpdatesChk As System.Windows.Forms.CheckBox
    Friend WithEvents MinTrayChk As System.Windows.Forms.CheckBox
    Friend WithEvents LogBox As System.Windows.Forms.RichTextBox
    Friend WithEvents BackupTimer As System.Windows.Forms.Timer
    Friend WithEvents ABUNotify As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotifyContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents updateLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkStartWithWindows As System.Windows.Forms.CheckBox
    Friend WithEvents ChkStartBackup As System.Windows.Forms.CheckBox

End Class
