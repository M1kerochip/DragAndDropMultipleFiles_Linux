Imports System.ComponentModel

Public Class frmMain
    Public Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        chkClearListOnDrag.Checked = My.Settings.ClearListOnDragAndDrop
        chkClearListOnExecute.Checked = My.Settings.ClearListOnExecute
        txtLinuxCMD.Text = My.Settings.LinuxCommand
        txtLinuxArguments.Text = My.Settings.LinuxArguments
        cmbStartLinux.Text = My.Settings.StartLinux
        txtFileList.Text = My.Settings.FileList
        chkDisableX64FireRedirection.Checked = My.Settings.Disable64BitFileRedirects

        ToolTipMain.SetToolTip(txtLinuxArguments, "Place command line arguments here. %FILENAME is the variable for the files in the list above. %FILENAMER is the variable for the filename converted to linux paths")
        ToolTipMain.SetToolTip(cmbStartLinux, "Command to execute. Command line may include spaces etc.")
        ToolTipMain.SetToolTip(btnClearListNow, "Clear the list now.")
        ToolTipMain.SetToolTip(btnExecute, "Execute the command in the command box.")
        ToolTipMain.SetToolTip(chkClearListOnExecute, "Clear the list after execution.")
        ToolTipMain.SetToolTip(chkClearListOnDrag, "Clear the list as you drag and drop in new files. Only useful to batches. Usually leave unticked.")
        ToolTipMain.SetToolTip(chkDisableX64FireRedirection, "Disables windows 64 bit file redirection. Needed for wsl.exe since it is a 32bit only exe, and doesn't exist in SYSWOW64")
        ToolTipMain.SetToolTip(txtFileList, "Drag and drop files here to process. Can also paste in a list of files eg from a text editor etc.")
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.ClearListOnDragAndDrop = chkClearListOnDrag.Checked
        My.Settings.ClearListOnExecute = chkClearListOnExecute.Checked
        My.Settings.LinuxCommand = txtLinuxCMD.Text
        My.Settings.LinuxArguments = txtLinuxArguments.Text
        My.Settings.StartLinux = cmbStartLinux.Text
        My.Settings.FileList = txtFileList.Text
        My.Settings.Disable64BitFileRedirects = chkDisableX64FireRedirection.Checked
    End Sub

    Private Sub BtnClearListNow_Click(sender As Object, e As EventArgs) Handles btnClearListNow.Click
        txtFileList.Clear()
    End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If chkDisableX64FireRedirection.Checked Then    'Needed on x64 systems, since wsl.exe is 32 bit only.
            Wow64DisableWow64FsRedirection(0)
        End If

        For Each s As String In txtFileList.Lines
            If System.IO.File.Exists(s) Then                'Check file exists (or has been created, if reading from GW)
                If cmbStartLinux.Text.Trim <> "" Then       'Check script exists
                    Dim str1 As String
                    Dim ch1 As String = s.Chars(0)
                    Dim fileReplaced As String = s.Replace(ch1 + s.Chars(1), "/mnt/" + ch1.ToLower).Replace("\", "/")
                    str1 = txtLinuxCMD.Text + " " + txtLinuxArguments.Text.Replace("%FILENAMER", fileReplaced).Replace("%FILENAME", s)
                    System.Diagnostics.Process.Start(cmbStartLinux.Text.Trim, str1)
                End If
            End If
        Next
        If chkClearListOnExecute.Checked Then txtFileList.Clear()
    End Sub

    Private Sub txtFileList_DragDrop(sender As Object, e As DragEventArgs) Handles txtFileList.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

        If chkClearListOnDrag.Checked Then txtFileList.Clear()

        For Each path In files
            txtFileList.Text += path + vbNewLine
        Next
    End Sub

    Private Sub txtFileList_DragEnter(sender As Object, e As DragEventArgs) Handles txtFileList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub BtnPickEXE_Click(sender As Object, e As EventArgs) Handles btnPickEXE.Click
        If OpenFileDialogMain.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub LLabelStartLinux_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLabelStartLinux.LinkClicked
        System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/wsl/wsl-config")
    End Sub

    Private Sub LLabelGitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLabelGitHub.LinkClicked
        System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/wsl/wsl-config")
    End Sub
End Class
