<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtFileList = New System.Windows.Forms.TextBox()
        Me.cmbStartLinux = New System.Windows.Forms.ComboBox()
        Me.LLabelStartLinux = New System.Windows.Forms.LinkLabel()
        Me.lblLinuxCommand = New System.Windows.Forms.Label()
        Me.txtLinuxCMD = New System.Windows.Forms.TextBox()
        Me.txtLinuxArguments = New System.Windows.Forms.TextBox()
        Me.lblLinuxArguments = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.chkClearListOnDrag = New System.Windows.Forms.CheckBox()
        Me.chkClearListOnExecute = New System.Windows.Forms.CheckBox()
        Me.btnClearListNow = New System.Windows.Forms.Button()
        Me.LLabelGitHub = New System.Windows.Forms.LinkLabel()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPickEXE = New System.Windows.Forms.Button()
        Me.OpenFileDialogMain = New System.Windows.Forms.OpenFileDialog()
        Me.chkDisableX64FireRedirection = New System.Windows.Forms.CheckBox()
        Me.chkWaitForExit = New System.Windows.Forms.CheckBox()
        Me.chkRunMinimized = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtFileList
        '
        Me.txtFileList.AllowDrop = True
        Me.txtFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileList.Location = New System.Drawing.Point(13, 12)
        Me.txtFileList.Multiline = True
        Me.txtFileList.Name = "txtFileList"
        Me.txtFileList.Size = New System.Drawing.Size(488, 353)
        Me.txtFileList.TabIndex = 0
        '
        'cmbStartLinux
        '
        Me.cmbStartLinux.AllowDrop = True
        Me.cmbStartLinux.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStartLinux.FormattingEnabled = True
        Me.cmbStartLinux.Items.AddRange(New Object() {"C:\windows\system32\wsl.exe", "C:\windows\system32\lxrun.exe", "bash.exe -i"})
        Me.cmbStartLinux.Location = New System.Drawing.Point(147, 417)
        Me.cmbStartLinux.Name = "cmbStartLinux"
        Me.cmbStartLinux.Size = New System.Drawing.Size(176, 21)
        Me.cmbStartLinux.TabIndex = 1
        Me.cmbStartLinux.Text = "C:\windows\system32\wsl.exe"
        '
        'LLabelStartLinux
        '
        Me.LLabelStartLinux.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLabelStartLinux.AutoSize = True
        Me.LLabelStartLinux.Location = New System.Drawing.Point(9, 420)
        Me.LLabelStartLinux.Name = "LLabelStartLinux"
        Me.LLabelStartLinux.Size = New System.Drawing.Size(129, 13)
        Me.LLabelStartLinux.TabIndex = 2
        Me.LLabelStartLinux.TabStop = True
        Me.LLabelStartLinux.Text = "Run Linux commands via:"
        '
        'lblLinuxCommand
        '
        Me.lblLinuxCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLinuxCommand.AutoSize = True
        Me.lblLinuxCommand.Location = New System.Drawing.Point(9, 447)
        Me.lblLinuxCommand.Name = "lblLinuxCommand"
        Me.lblLinuxCommand.Size = New System.Drawing.Size(114, 13)
        Me.lblLinuxCommand.TabIndex = 3
        Me.lblLinuxCommand.Text = "Linux command to run:"
        '
        'txtLinuxCMD
        '
        Me.txtLinuxCMD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLinuxCMD.Location = New System.Drawing.Point(147, 444)
        Me.txtLinuxCMD.Name = "txtLinuxCMD"
        Me.txtLinuxCMD.Size = New System.Drawing.Size(353, 20)
        Me.txtLinuxCMD.TabIndex = 4
        Me.txtLinuxCMD.Text = "analyse-disk"
        '
        'txtLinuxArguments
        '
        Me.txtLinuxArguments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLinuxArguments.Location = New System.Drawing.Point(147, 470)
        Me.txtLinuxArguments.Name = "txtLinuxArguments"
        Me.txtLinuxArguments.Size = New System.Drawing.Size(353, 20)
        Me.txtLinuxArguments.TabIndex = 6
        Me.txtLinuxArguments.Text = "-e79 -fprobe_amiga %FILENAMER %FILENAMER.ipf > %FILENAMER.libdisk.txt"
        '
        'lblLinuxArguments
        '
        Me.lblLinuxArguments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLinuxArguments.AutoSize = True
        Me.lblLinuxArguments.Location = New System.Drawing.Point(9, 473)
        Me.lblLinuxArguments.Name = "lblLinuxArguments"
        Me.lblLinuxArguments.Size = New System.Drawing.Size(110, 13)
        Me.lblLinuxArguments.TabIndex = 5
        Me.lblLinuxArguments.Text = "Command Arguments:"
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(12, 500)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(488, 23)
        Me.btnExecute.TabIndex = 7
        Me.btnExecute.Text = "&Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'chkClearListOnDrag
        '
        Me.chkClearListOnDrag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkClearListOnDrag.AutoSize = True
        Me.chkClearListOnDrag.Location = New System.Drawing.Point(12, 371)
        Me.chkClearListOnDrag.Name = "chkClearListOnDrag"
        Me.chkClearListOnDrag.Size = New System.Drawing.Size(145, 17)
        Me.chkClearListOnDrag.TabIndex = 8
        Me.chkClearListOnDrag.Text = "Clear &List on Drag && Drop"
        Me.chkClearListOnDrag.UseVisualStyleBackColor = True
        '
        'chkClearListOnExecute
        '
        Me.chkClearListOnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkClearListOnExecute.AutoSize = True
        Me.chkClearListOnExecute.Checked = True
        Me.chkClearListOnExecute.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClearListOnExecute.Location = New System.Drawing.Point(163, 371)
        Me.chkClearListOnExecute.Name = "chkClearListOnExecute"
        Me.chkClearListOnExecute.Size = New System.Drawing.Size(126, 17)
        Me.chkClearListOnExecute.TabIndex = 9
        Me.chkClearListOnExecute.Text = "&Clear List on Execute"
        Me.chkClearListOnExecute.UseVisualStyleBackColor = True
        '
        'btnClearListNow
        '
        Me.btnClearListNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearListNow.Location = New System.Drawing.Point(371, 417)
        Me.btnClearListNow.Name = "btnClearListNow"
        Me.btnClearListNow.Size = New System.Drawing.Size(129, 21)
        Me.btnClearListNow.TabIndex = 10
        Me.btnClearListNow.Text = "Clear List &Now"
        Me.btnClearListNow.UseVisualStyleBackColor = True
        '
        'LLabelGitHub
        '
        Me.LLabelGitHub.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LLabelGitHub.AutoSize = True
        Me.LLabelGitHub.Location = New System.Drawing.Point(459, 372)
        Me.LLabelGitHub.Name = "LLabelGitHub"
        Me.LLabelGitHub.Size = New System.Drawing.Size(38, 13)
        Me.LLabelGitHub.TabIndex = 12
        Me.LLabelGitHub.TabStop = True
        Me.LLabelGitHub.Text = "Github"
        '
        'btnPickEXE
        '
        Me.btnPickEXE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPickEXE.Location = New System.Drawing.Point(329, 417)
        Me.btnPickEXE.Name = "btnPickEXE"
        Me.btnPickEXE.Size = New System.Drawing.Size(26, 21)
        Me.btnPickEXE.TabIndex = 13
        Me.btnPickEXE.Text = "..."
        Me.btnPickEXE.UseVisualStyleBackColor = True
        '
        'OpenFileDialogMain
        '
        Me.OpenFileDialogMain.Filter = "Program Files|*.exe|All Files|*.*"
        Me.OpenFileDialogMain.Title = "Select File to launch process with"
        '
        'chkDisableX64FireRedirection
        '
        Me.chkDisableX64FireRedirection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDisableX64FireRedirection.AutoSize = True
        Me.chkDisableX64FireRedirection.Location = New System.Drawing.Point(295, 371)
        Me.chkDisableX64FireRedirection.Name = "chkDisableX64FireRedirection"
        Me.chkDisableX64FireRedirection.Size = New System.Drawing.Size(158, 17)
        Me.chkDisableX64FireRedirection.TabIndex = 14
        Me.chkDisableX64FireRedirection.Text = "Disable 64bit File redirection"
        Me.chkDisableX64FireRedirection.UseVisualStyleBackColor = True
        '
        'chkWaitForExit
        '
        Me.chkWaitForExit.AutoSize = True
        Me.chkWaitForExit.Location = New System.Drawing.Point(12, 394)
        Me.chkWaitForExit.Name = "chkWaitForExit"
        Me.chkWaitForExit.Size = New System.Drawing.Size(86, 17)
        Me.chkWaitForExit.TabIndex = 15
        Me.chkWaitForExit.Text = "Wait For Exit"
        Me.chkWaitForExit.UseVisualStyleBackColor = True
        '
        'chkRunMinimized
        '
        Me.chkRunMinimized.AutoSize = True
        Me.chkRunMinimized.Location = New System.Drawing.Point(163, 394)
        Me.chkRunMinimized.Name = "chkRunMinimized"
        Me.chkRunMinimized.Size = New System.Drawing.Size(145, 17)
        Me.chkRunMinimized.TabIndex = 16
        Me.chkRunMinimized.Text = "Run Command Minimized"
        Me.chkRunMinimized.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 535)
        Me.Controls.Add(Me.chkRunMinimized)
        Me.Controls.Add(Me.chkWaitForExit)
        Me.Controls.Add(Me.btnPickEXE)
        Me.Controls.Add(Me.LLabelGitHub)
        Me.Controls.Add(Me.btnClearListNow)
        Me.Controls.Add(Me.chkClearListOnExecute)
        Me.Controls.Add(Me.chkClearListOnDrag)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtLinuxArguments)
        Me.Controls.Add(Me.lblLinuxArguments)
        Me.Controls.Add(Me.txtLinuxCMD)
        Me.Controls.Add(Me.lblLinuxCommand)
        Me.Controls.Add(Me.LLabelStartLinux)
        Me.Controls.Add(Me.cmbStartLinux)
        Me.Controls.Add(Me.txtFileList)
        Me.Controls.Add(Me.chkDisableX64FireRedirection)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run Linux Commands via Drag & Drop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFileList As TextBox
    Friend WithEvents cmbStartLinux As ComboBox
    Friend WithEvents LLabelStartLinux As LinkLabel
    Friend WithEvents lblLinuxCommand As Label
    Friend WithEvents txtLinuxCMD As TextBox
    Friend WithEvents txtLinuxArguments As TextBox
    Friend WithEvents lblLinuxArguments As Label
    Friend WithEvents btnExecute As Button
    Friend WithEvents chkClearListOnDrag As CheckBox
    Friend WithEvents chkClearListOnExecute As CheckBox
    Friend WithEvents btnClearListNow As Button
    Friend WithEvents LLabelGitHub As LinkLabel
    Friend WithEvents ToolTipMain As ToolTip
    Friend WithEvents btnPickEXE As Button
    Friend WithEvents OpenFileDialogMain As OpenFileDialog
    Friend WithEvents chkDisableX64FireRedirection As CheckBox
    Friend WithEvents chkWaitForExit As CheckBox
    Friend WithEvents chkRunMinimized As CheckBox
End Class
