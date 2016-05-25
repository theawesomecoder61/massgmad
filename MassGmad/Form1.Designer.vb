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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GmasLocateBtn = New System.Windows.Forms.Button()
        Me.GmadPathTB = New System.Windows.Forms.TextBox()
        Me.ExtractBtn = New System.Windows.Forms.Button()
        Me.GmasFBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.GmasList = New System.Windows.Forms.ListBox()
        Me.GmadLocateBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GmasPathTB = New System.Windows.Forms.TextBox()
        Me.LogTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChooseFolderTB = New System.Windows.Forms.TextBox()
        Me.NewFolderTB = New System.Windows.Forms.TextBox()
        Me.ExtractLocateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitHubRepoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GmadExtractFBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GmasLocateBtn
        '
        Me.GmasLocateBtn.Location = New System.Drawing.Point(233, 20)
        Me.GmasLocateBtn.Name = "GmasLocateBtn"
        Me.GmasLocateBtn.Size = New System.Drawing.Size(75, 23)
        Me.GmasLocateBtn.TabIndex = 2
        Me.GmasLocateBtn.Text = "Locate"
        Me.GmasLocateBtn.UseVisualStyleBackColor = True
        '
        'GmadPathTB
        '
        Me.GmadPathTB.Location = New System.Drawing.Point(6, 22)
        Me.GmadPathTB.Name = "GmadPathTB"
        Me.GmadPathTB.ReadOnly = True
        Me.GmadPathTB.Size = New System.Drawing.Size(221, 20)
        Me.GmadPathTB.TabIndex = 0
        Me.GmadPathTB.Text = "Select a folder first - - - - >"
        '
        'ExtractBtn
        '
        Me.ExtractBtn.Location = New System.Drawing.Point(6, 107)
        Me.ExtractBtn.Name = "ExtractBtn"
        Me.ExtractBtn.Size = New System.Drawing.Size(373, 72)
        Me.ExtractBtn.TabIndex = 3
        Me.ExtractBtn.Text = "massgmad dump!"
        Me.ExtractBtn.UseVisualStyleBackColor = True
        '
        'GmasList
        '
        Me.GmasList.FormattingEnabled = True
        Me.GmasList.Location = New System.Drawing.Point(140, 56)
        Me.GmasList.Name = "GmasList"
        Me.GmasList.Size = New System.Drawing.Size(168, 173)
        Me.GmasList.TabIndex = 0
        '
        'GmadLocateBtn
        '
        Me.GmadLocateBtn.Location = New System.Drawing.Point(233, 16)
        Me.GmadLocateBtn.Name = "GmadLocateBtn"
        Me.GmadLocateBtn.Size = New System.Drawing.Size(75, 23)
        Me.GmadLocateBtn.TabIndex = 1
        Me.GmadLocateBtn.Text = "Locate"
        Me.GmadLocateBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\bin"
        '
        'GmasPathTB
        '
        Me.GmasPathTB.Location = New System.Drawing.Point(6, 18)
        Me.GmasPathTB.Name = "GmasPathTB"
        Me.GmasPathTB.ReadOnly = True
        Me.GmasPathTB.Size = New System.Drawing.Size(221, 20)
        Me.GmasPathTB.TabIndex = 0
        Me.GmasPathTB.Text = "Select gmad.exe first - - - - >"
        '
        'LogTextBox
        '
        Me.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogTextBox.Location = New System.Drawing.Point(335, 218)
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.Size = New System.Drawing.Size(385, 220)
        Me.LogTextBox.TabIndex = 0
        Me.LogTextBox.Text = "This is the log. Useful information will print here." & Global.Microsoft.VisualBasic.ChrW(10) & "- - - - - - - - - - - - - - " & _
    "- - - - - - - - - - - - - - - - - - - - - - - -" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GmadLocateBtn)
        Me.GroupBox1.Controls.Add(Me.GmasPathTB)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(15, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1. Where is gmad.exe located?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GmasLocateBtn)
        Me.GroupBox2.Controls.Add(Me.GmadPathTB)
        Me.GroupBox2.Controls.Add(Me.GmasList)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(15, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 239)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 2. Where is the folder of gmas that you want to extract?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "All the gmas in the folder:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ExtractBtn)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(335, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 185)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 3. Lastly..."
        '
        'ChooseFolderTB
        '
        Me.ChooseFolderTB.Location = New System.Drawing.Point(5, 5)
        Me.ChooseFolderTB.Name = "ChooseFolderTB"
        Me.ChooseFolderTB.ReadOnly = True
        Me.ChooseFolderTB.Size = New System.Drawing.Size(202, 20)
        Me.ChooseFolderTB.TabIndex = 0
        Me.ChooseFolderTB.Text = "Select a folder first - - - - >"
        '
        'NewFolderTB
        '
        Me.NewFolderTB.Location = New System.Drawing.Point(5, 5)
        Me.NewFolderTB.Name = "NewFolderTB"
        Me.NewFolderTB.Size = New System.Drawing.Size(292, 20)
        Me.NewFolderTB.TabIndex = 0
        Me.NewFolderTB.Text = "massgmad"
        '
        'ExtractLocateBtn
        '
        Me.ExtractLocateBtn.Location = New System.Drawing.Point(213, 3)
        Me.ExtractLocateBtn.Name = "ExtractLocateBtn"
        Me.ExtractLocateBtn.Size = New System.Drawing.Size(87, 23)
        Me.ExtractLocateBtn.TabIndex = 0
        Me.ExtractLocateBtn.Text = "Locate"
        Me.ExtractLocateBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Extract to (select a tab and fill in inputs if necessary):"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MoreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'MoreToolStripMenuItem
        '
        Me.MoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GitHubRepoToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MoreToolStripMenuItem.Name = "MoreToolStripMenuItem"
        Me.MoreToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.MoreToolStripMenuItem.Text = "More"
        '
        'GitHubRepoToolStripMenuItem
        '
        Me.GitHubRepoToolStripMenuItem.Name = "GitHubRepoToolStripMenuItem"
        Me.GitHubRepoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.GitHubRepoToolStripMenuItem.Text = "GitHub repo"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 43)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "massgmad"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.MassGmad.My.Resources.Resources.icon
        Me.PictureBox1.Image = Global.MassGmad.My.Resources.Resources.icon
        Me.PictureBox1.InitialImage = Global.MassGmad.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(24, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.Location = New System.Drawing.Point(134, 77)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(189, 51)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "massgmad is a utility that extracts all Garry's Mod addons (.gma) in a user-speci" & _
    "fied folder."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(68, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(311, 65)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(303, 39)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Same as gmas (input)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NewFolderTB)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(303, 39)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Create a folder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ChooseFolderTB)
        Me.TabPage3.Controls.Add(Me.ExtractLocateBtn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(303, 39)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Let me choose"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Move along, no input is necessary here!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 451)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LogTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "massgmad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GmasLocateBtn As System.Windows.Forms.Button
    Friend WithEvents GmadPathTB As System.Windows.Forms.TextBox
    Friend WithEvents ExtractBtn As System.Windows.Forms.Button
    Friend WithEvents GmasFBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GmasList As System.Windows.Forms.ListBox
    Friend WithEvents GmadLocateBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GmasPathTB As System.Windows.Forms.TextBox
    Friend WithEvents LogTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ExtractLocateBtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFolderTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChooseFolderTB As System.Windows.Forms.TextBox
    Friend WithEvents GmadExtractFBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GitHubRepoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage

End Class
