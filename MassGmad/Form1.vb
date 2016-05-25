Imports System.IO

Public Class Form1

    Dim version As String = "massgmad version 1.0"

    Dim gmadPath As String
    Dim gmasPath As String
    Dim numOfGmas As Integer
    Dim extractFolderPath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableGroupBox(1)
        If Not Directory.Exists("C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\") Then
            NoGmod.ShowDialog()
            Close()
        End If
    End Sub

    '
    ' Step 1
    '
    Private Sub GmadLocateBtn_Click(sender As Object, e As EventArgs) Handles GmadLocateBtn.Click
        OpenFileDialog1.FileName = "gmad.exe"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            GmasPathTB.Text = OpenFileDialog1.FileName
            gmadPath = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)
            WriteToLog("Found gmad.exe at " + gmadPath)
            EnableGroupBox(2)
        End If
    End Sub

    '
    ' Step 2
    '
    Private Sub GmasLocateBtn_Click(sender As Object, e As EventArgs) Handles GmasLocateBtn.Click
        If GmasFBD.ShowDialog() = DialogResult.OK Then
            GmadPathTB.Text = GmasFBD.SelectedPath
            gmasPath = GmasFBD.SelectedPath
            ScanAndExtract(False)
            EnableGroupBox(3)
        End If
    End Sub

    '
    ' Step 3
    '
  Private Sub NewFolderTB_TextChanged(sender As Object, e As EventArgs) Handles NewFolderTB.TextChanged
        extractFolderPath = gmasPath + "\" + NewFolderTB.Text
    End Sub

    Private Sub ExtractLocateBtn_Click(sender As Object, e As EventArgs) Handles ExtractLocateBtn.Click
        If GmadExtractFBD.ShowDialog() = DialogResult.OK Then
            ChooseFolderTB.Text = GmadExtractFBD.SelectedPath
            extractFolderPath = GmadExtractFBD.SelectedPath
        End If
        ExtractBtn.Enabled = Not GmadExtractFBD.SelectedPath = ""
    End Sub

    Private Sub ExtractBtn_Click(sender As Object, e As EventArgs) Handles ExtractBtn.Click
        GroupBox3.Enabled = False
        ScanAndExtract(True)
        GroupBox3.Enabled = True
        WriteToLog("Done!")
    End Sub

    '
    ' Menu
    '
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GitHubRepoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitHubRepoToolStripMenuItem.Click
        Process.Start("https://github.com/theawesomecoder61/massgmad")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox(version + Environment.NewLine + "Created by theawesomecoder61")
    End Sub

    '
    ' Helpers
    '
    ' Scan the folder for gmas and extract them
    Private Sub ScanAndExtract(shouldExtract As Boolean)
        GmasList.Items.Clear()
        numOfGmas = 0
        Dim di As New IO.DirectoryInfo(gmasPath)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        For Each dra In diar1
            If dra.Extension = ".gma" Then
                If Not shouldExtract Then
                    GmasList.Items.Add(dra)
                    numOfGmas = numOfGmas + 1
                End If
                If shouldExtract Then
                    Dim fileName As String = gmasPath + "\" + dra.Name
                    Dim filePath As String = System.IO.Path.GetFileNameWithoutExtension(dra.Name)
                    Dim folderForGma = extractFolderPath + "\" + filePath + "\"
                    WriteToLog("Extracting " + fileName + " to " + folderForGma + "...")
                    RunExtractCmd(fileName, folderForGma)
                End If
            End If
        Next
        If Not shouldExtract Then
            WriteToLog("Found " + Convert.ToString(numOfGmas) + " gmas in " + gmasPath)
        End If
    End Sub

    ' Run commands in cmd
    Private Sub RunExtractCmd(file As String, folder As String)
        Dim cmd As String = String.Format("/c cd {0}&&gmad.exe extract -file {1} -out {2}", gmadPath, file, folder)
        Process.Start("CMD.exe", cmd)
    End Sub

    ' Add to log
    Private Sub WriteToLog(t As String)
        LogTextBox.Text = LogTextBox.Text + Now.ToString("MM/dd/yyyy-hh:mm:ss") + ": " + t + Environment.NewLine
        LogTextBox.Select(LogTextBox.Text.Length - 2, LogTextBox.Text.Length - 1)
        LogTextBox.ScrollToCaret()
    End Sub

    ' Have only 1 groupbox enabled
    Private Sub EnableGroupBox(i As Integer)
        If i = 1 Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
        ElseIf i = 2 Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
        ElseIf i = 3 Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = True
        End If
    End Sub

    ' Update when a tab is switched
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) _
     Handles TabControl1.SelectedIndexChanged
        Dim i As Integer = TabControl1.SelectedIndex
        If i = 0 Then
            NewFolderTB.Enabled = False
            ChooseFolderTB.Enabled = False
            ExtractLocateBtn.Enabled = False
            extractFolderPath = gmasPath
        ElseIf i = 1 Then
            NewFolderTB.Enabled = True
            ChooseFolderTB.Enabled = False
            ExtractLocateBtn.Enabled = False
            extractFolderPath = gmasPath + "\" + NewFolderTB.Text
        ElseIf i = 2 Then
            NewFolderTB.Enabled = False
            ChooseFolderTB.Enabled = True
            ExtractLocateBtn.Enabled = True
            extractFolderPath = GmadExtractFBD.SelectedPath
            ExtractBtn.Enabled = Not GmadExtractFBD.SelectedPath = ""
            WriteToLog("Export path: " + extractFolderPath)
        End If
    End Sub
End Class