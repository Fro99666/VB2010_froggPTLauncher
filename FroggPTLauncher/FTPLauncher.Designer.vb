﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggPTLauncher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggPTLauncher))
        Me.OptGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptScreenS = New System.Windows.Forms.ComboBox()
        Me.OptScreenT = New System.Windows.Forms.ComboBox()
        Me.OptGroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptGraphic3 = New System.Windows.Forms.RadioButton()
        Me.OptGraphic2 = New System.Windows.Forms.RadioButton()
        Me.OptGraphic1 = New System.Windows.Forms.RadioButton()
        Me.OptGroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptColor2 = New System.Windows.Forms.RadioButton()
        Me.OptColor1 = New System.Windows.Forms.RadioButton()
        Me.OptGroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OptMotion2 = New System.Windows.Forms.RadioButton()
        Me.OptMotion1 = New System.Windows.Forms.RadioButton()
        Me.OptFullScreen = New System.Windows.Forms.CheckBox()
        Me.OptNoSound = New System.Windows.Forms.CheckBox()
        Me.PanelOption = New System.Windows.Forms.Panel()
        Me.PanelOptSave = New System.Windows.Forms.PictureBox()
        Me.PanelOptTitle = New System.Windows.Forms.PictureBox()
        Me.PanelLauncher = New System.Windows.Forms.Panel()
        Me.PanelLchNews = New System.Windows.Forms.WebBrowser()
        Me.PanelLchPlay = New System.Windows.Forms.PictureBox()
        Me.PanelLchOptions = New System.Windows.Forms.PictureBox()
        Me.PanelLchTitle = New System.Windows.Forms.PictureBox()
        Me.MenuMain = New System.Windows.Forms.MenuStrip()
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStartGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.FroggPTNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFroggFr = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuForum = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFacebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBar = New System.Windows.Forms.StatusStrip()
        Me.ToolBarStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolBarProgress1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolBarProgress2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.OptGroupBox1.SuspendLayout()
        Me.OptGroupBox2.SuspendLayout()
        Me.OptGroupBox3.SuspendLayout()
        Me.OptGroupBox4.SuspendLayout()
        Me.PanelOption.SuspendLayout()
        CType(Me.PanelOptSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelOptTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLauncher.SuspendLayout()
        CType(Me.PanelLchPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelLchOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelLchTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuMain.SuspendLayout()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptGroupBox1
        '
        Me.OptGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptGroupBox1.Controls.Add(Me.OptScreenS)
        Me.OptGroupBox1.Controls.Add(Me.OptScreenT)
        Me.OptGroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptGroupBox1.Location = New System.Drawing.Point(7, 42)
        Me.OptGroupBox1.Name = "OptGroupBox1"
        Me.OptGroupBox1.Size = New System.Drawing.Size(269, 46)
        Me.OptGroupBox1.TabIndex = 0
        Me.OptGroupBox1.TabStop = False
        Me.OptGroupBox1.Text = "Screen Size"
        '
        'OptScreenS
        '
        Me.OptScreenS.FormattingEnabled = True
        Me.OptScreenS.Location = New System.Drawing.Point(112, 19)
        Me.OptScreenS.Name = "OptScreenS"
        Me.OptScreenS.Size = New System.Drawing.Size(142, 21)
        Me.OptScreenS.TabIndex = 1
        '
        'OptScreenT
        '
        Me.OptScreenT.FormattingEnabled = True
        Me.OptScreenT.Location = New System.Drawing.Point(14, 19)
        Me.OptScreenT.Name = "OptScreenT"
        Me.OptScreenT.Size = New System.Drawing.Size(87, 21)
        Me.OptScreenT.TabIndex = 0
        '
        'OptGroupBox2
        '
        Me.OptGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.OptGroupBox2.Controls.Add(Me.OptGraphic3)
        Me.OptGroupBox2.Controls.Add(Me.OptGraphic2)
        Me.OptGroupBox2.Controls.Add(Me.OptGraphic1)
        Me.OptGroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptGroupBox2.Location = New System.Drawing.Point(7, 94)
        Me.OptGroupBox2.Name = "OptGroupBox2"
        Me.OptGroupBox2.Size = New System.Drawing.Size(269, 46)
        Me.OptGroupBox2.TabIndex = 2
        Me.OptGroupBox2.TabStop = False
        Me.OptGroupBox2.Text = "Graphic Quality"
        '
        'OptGraphic3
        '
        Me.OptGraphic3.AutoSize = True
        Me.OptGraphic3.Location = New System.Drawing.Point(207, 19)
        Me.OptGraphic3.Name = "OptGraphic3"
        Me.OptGraphic3.Size = New System.Drawing.Size(47, 17)
        Me.OptGraphic3.TabIndex = 2
        Me.OptGraphic3.TabStop = True
        Me.OptGraphic3.Text = "High"
        Me.OptGraphic3.UseVisualStyleBackColor = True
        '
        'OptGraphic2
        '
        Me.OptGraphic2.AutoSize = True
        Me.OptGraphic2.Location = New System.Drawing.Point(112, 19)
        Me.OptGraphic2.Name = "OptGraphic2"
        Me.OptGraphic2.Size = New System.Drawing.Size(62, 17)
        Me.OptGraphic2.TabIndex = 1
        Me.OptGraphic2.TabStop = True
        Me.OptGraphic2.Text = "Medium"
        Me.OptGraphic2.UseVisualStyleBackColor = True
        '
        'OptGraphic1
        '
        Me.OptGraphic1.AutoSize = True
        Me.OptGraphic1.Location = New System.Drawing.Point(14, 19)
        Me.OptGraphic1.Name = "OptGraphic1"
        Me.OptGraphic1.Size = New System.Drawing.Size(45, 17)
        Me.OptGraphic1.TabIndex = 0
        Me.OptGraphic1.TabStop = True
        Me.OptGraphic1.Text = "Low"
        Me.OptGraphic1.UseVisualStyleBackColor = True
        '
        'OptGroupBox3
        '
        Me.OptGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.OptGroupBox3.Controls.Add(Me.OptColor2)
        Me.OptGroupBox3.Controls.Add(Me.OptColor1)
        Me.OptGroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptGroupBox3.Location = New System.Drawing.Point(7, 146)
        Me.OptGroupBox3.Name = "OptGroupBox3"
        Me.OptGroupBox3.Size = New System.Drawing.Size(132, 46)
        Me.OptGroupBox3.TabIndex = 3
        Me.OptGroupBox3.TabStop = False
        Me.OptGroupBox3.Text = "Color Depth"
        '
        'OptColor2
        '
        Me.OptColor2.AutoSize = True
        Me.OptColor2.Location = New System.Drawing.Point(71, 19)
        Me.OptColor2.Name = "OptColor2"
        Me.OptColor2.Size = New System.Drawing.Size(51, 17)
        Me.OptColor2.TabIndex = 1
        Me.OptColor2.TabStop = True
        Me.OptColor2.Text = "32 bit"
        Me.OptColor2.UseVisualStyleBackColor = True
        '
        'OptColor1
        '
        Me.OptColor1.AutoSize = True
        Me.OptColor1.Location = New System.Drawing.Point(14, 19)
        Me.OptColor1.Name = "OptColor1"
        Me.OptColor1.Size = New System.Drawing.Size(51, 17)
        Me.OptColor1.TabIndex = 0
        Me.OptColor1.TabStop = True
        Me.OptColor1.Text = "16 bit"
        Me.OptColor1.UseVisualStyleBackColor = True
        '
        'OptGroupBox4
        '
        Me.OptGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.OptGroupBox4.Controls.Add(Me.OptMotion2)
        Me.OptGroupBox4.Controls.Add(Me.OptMotion1)
        Me.OptGroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptGroupBox4.Location = New System.Drawing.Point(145, 146)
        Me.OptGroupBox4.Name = "OptGroupBox4"
        Me.OptGroupBox4.Size = New System.Drawing.Size(131, 46)
        Me.OptGroupBox4.TabIndex = 4
        Me.OptGroupBox4.TabStop = False
        Me.OptGroupBox4.Text = "Motion Blur"
        '
        'OptMotion2
        '
        Me.OptMotion2.AutoSize = True
        Me.OptMotion2.Location = New System.Drawing.Point(70, 19)
        Me.OptMotion2.Name = "OptMotion2"
        Me.OptMotion2.Size = New System.Drawing.Size(39, 17)
        Me.OptMotion2.TabIndex = 1
        Me.OptMotion2.TabStop = True
        Me.OptMotion2.Text = "No"
        Me.OptMotion2.UseVisualStyleBackColor = True
        '
        'OptMotion1
        '
        Me.OptMotion1.AutoSize = True
        Me.OptMotion1.Location = New System.Drawing.Point(14, 19)
        Me.OptMotion1.Name = "OptMotion1"
        Me.OptMotion1.Size = New System.Drawing.Size(43, 17)
        Me.OptMotion1.TabIndex = 0
        Me.OptMotion1.TabStop = True
        Me.OptMotion1.Text = "Yes"
        Me.OptMotion1.UseVisualStyleBackColor = True
        '
        'OptFullScreen
        '
        Me.OptFullScreen.AutoSize = True
        Me.OptFullScreen.BackColor = System.Drawing.Color.Transparent
        Me.OptFullScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptFullScreen.Location = New System.Drawing.Point(21, 221)
        Me.OptFullScreen.Name = "OptFullScreen"
        Me.OptFullScreen.Size = New System.Drawing.Size(79, 17)
        Me.OptFullScreen.TabIndex = 6
        Me.OptFullScreen.Text = "Full Screen"
        Me.OptFullScreen.UseVisualStyleBackColor = False
        '
        'OptNoSound
        '
        Me.OptNoSound.AutoSize = True
        Me.OptNoSound.BackColor = System.Drawing.Color.Transparent
        Me.OptNoSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptNoSound.Location = New System.Drawing.Point(21, 198)
        Me.OptNoSound.Name = "OptNoSound"
        Me.OptNoSound.Size = New System.Drawing.Size(74, 17)
        Me.OptNoSound.TabIndex = 7
        Me.OptNoSound.Text = "No Sound"
        Me.OptNoSound.UseVisualStyleBackColor = False
        '
        'PanelOption
        '
        Me.PanelOption.BackColor = System.Drawing.Color.Transparent
        Me.PanelOption.Controls.Add(Me.PanelOptSave)
        Me.PanelOption.Controls.Add(Me.PanelOptTitle)
        Me.PanelOption.Controls.Add(Me.OptGroupBox1)
        Me.PanelOption.Controls.Add(Me.OptFullScreen)
        Me.PanelOption.Controls.Add(Me.OptNoSound)
        Me.PanelOption.Controls.Add(Me.OptGroupBox2)
        Me.PanelOption.Controls.Add(Me.OptGroupBox3)
        Me.PanelOption.Controls.Add(Me.OptGroupBox4)
        Me.PanelOption.Location = New System.Drawing.Point(174, 30)
        Me.PanelOption.Name = "PanelOption"
        Me.PanelOption.Size = New System.Drawing.Size(283, 244)
        Me.PanelOption.TabIndex = 9
        Me.PanelOption.Visible = False
        '
        'PanelOptSave
        '
        Me.PanelOptSave.Image = Global.FroggPTLauncher.My.Resources.Resources.save
        Me.PanelOptSave.Location = New System.Drawing.Point(145, 198)
        Me.PanelOptSave.Name = "PanelOptSave"
        Me.PanelOptSave.Size = New System.Drawing.Size(131, 39)
        Me.PanelOptSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PanelOptSave.TabIndex = 8
        Me.PanelOptSave.TabStop = False
        '
        'PanelOptTitle
        '
        Me.PanelOptTitle.Image = Global.FroggPTLauncher.My.Resources.Resources.gameoption
        Me.PanelOptTitle.Location = New System.Drawing.Point(7, 3)
        Me.PanelOptTitle.Name = "PanelOptTitle"
        Me.PanelOptTitle.Size = New System.Drawing.Size(152, 33)
        Me.PanelOptTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PanelOptTitle.TabIndex = 0
        Me.PanelOptTitle.TabStop = False
        '
        'PanelLauncher
        '
        Me.PanelLauncher.BackColor = System.Drawing.Color.Transparent
        Me.PanelLauncher.Controls.Add(Me.PanelLchNews)
        Me.PanelLauncher.Controls.Add(Me.PanelLchPlay)
        Me.PanelLauncher.Controls.Add(Me.PanelLchOptions)
        Me.PanelLauncher.Controls.Add(Me.PanelLchTitle)
        Me.PanelLauncher.Location = New System.Drawing.Point(174, 30)
        Me.PanelLauncher.Name = "PanelLauncher"
        Me.PanelLauncher.Size = New System.Drawing.Size(283, 244)
        Me.PanelLauncher.TabIndex = 10
        '
        'PanelLchNews
        '
        Me.PanelLchNews.Location = New System.Drawing.Point(7, 42)
        Me.PanelLchNews.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PanelLchNews.Name = "PanelLchNews"
        Me.PanelLchNews.ScrollBarsEnabled = False
        Me.PanelLchNews.Size = New System.Drawing.Size(268, 149)
        Me.PanelLchNews.TabIndex = 12
        '
        'PanelLchPlay
        '
        Me.PanelLchPlay.Enabled = False
        Me.PanelLchPlay.Image = Global.FroggPTLauncher.My.Resources.Resources.play_d
        Me.PanelLchPlay.Location = New System.Drawing.Point(144, 198)
        Me.PanelLchPlay.Name = "PanelLchPlay"
        Me.PanelLchPlay.Size = New System.Drawing.Size(131, 40)
        Me.PanelLchPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PanelLchPlay.TabIndex = 11
        Me.PanelLchPlay.TabStop = False
        '
        'PanelLchOptions
        '
        Me.PanelLchOptions.Image = CType(resources.GetObject("PanelLchOptions.Image"), System.Drawing.Image)
        Me.PanelLchOptions.Location = New System.Drawing.Point(7, 198)
        Me.PanelLchOptions.Name = "PanelLchOptions"
        Me.PanelLchOptions.Size = New System.Drawing.Size(131, 40)
        Me.PanelLchOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PanelLchOptions.TabIndex = 10
        Me.PanelLchOptions.TabStop = False
        '
        'PanelLchTitle
        '
        Me.PanelLchTitle.Image = Global.FroggPTLauncher.My.Resources.Resources.gamelauncher
        Me.PanelLchTitle.Location = New System.Drawing.Point(7, 3)
        Me.PanelLchTitle.Name = "PanelLchTitle"
        Me.PanelLchTitle.Size = New System.Drawing.Size(200, 33)
        Me.PanelLchTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PanelLchTitle.TabIndex = 9
        Me.PanelLchTitle.TabStop = False
        '
        'MenuMain
        '
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.FroggPTNetworkToolStripMenuItem, Me.MenuOptions, Me.MenuHelp})
        Me.MenuMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Size = New System.Drawing.Size(458, 24)
        Me.MenuMain.TabIndex = 11
        Me.MenuMain.Text = "Main Menu"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStartGame, Me.MenuUpdate, Me.MenuExit})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(51, 20)
        Me.MenuFile.Text = "[ File ]"
        '
        'MenuStartGame
        '
        Me.MenuStartGame.Enabled = False
        Me.MenuStartGame.Name = "MenuStartGame"
        Me.MenuStartGame.Size = New System.Drawing.Size(146, 22)
        Me.MenuStartGame.Text = "Start Game"
        '
        'MenuUpdate
        '
        Me.MenuUpdate.Enabled = False
        Me.MenuUpdate.Name = "MenuUpdate"
        Me.MenuUpdate.Size = New System.Drawing.Size(146, 22)
        Me.MenuUpdate.Text = "Update Game"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(146, 22)
        Me.MenuExit.Text = "Exit"
        '
        'FroggPTNetworkToolStripMenuItem
        '
        Me.FroggPTNetworkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFroggFr, Me.MenuForum, Me.MenuFacebook})
        Me.FroggPTNetworkToolStripMenuItem.Name = "FroggPTNetworkToolStripMenuItem"
        Me.FroggPTNetworkToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.FroggPTNetworkToolStripMenuItem.Text = "[ FroggPT Network ]"
        '
        'MenuFroggFr
        '
        Me.MenuFroggFr.Name = "MenuFroggFr"
        Me.MenuFroggFr.Size = New System.Drawing.Size(152, 22)
        Me.MenuFroggFr.Text = "frogg.fr"
        '
        'MenuForum
        '
        Me.MenuForum.Name = "MenuForum"
        Me.MenuForum.Size = New System.Drawing.Size(152, 22)
        Me.MenuForum.Text = "Forum"
        '
        'MenuFacebook
        '
        Me.MenuFacebook.Name = "MenuFacebook"
        Me.MenuFacebook.Size = New System.Drawing.Size(152, 22)
        Me.MenuFacebook.Text = "Facebook"
        '
        'MenuOptions
        '
        Me.MenuOptions.Name = "MenuOptions"
        Me.MenuOptions.Size = New System.Drawing.Size(81, 20)
        Me.MenuOptions.Text = "[  Options  ]"
        '
        'MenuHelp
        '
        Me.MenuHelp.Name = "MenuHelp"
        Me.MenuHelp.Size = New System.Drawing.Size(38, 20)
        Me.MenuHelp.Text = "[ ? ]"
        '
        'ToolBar
        '
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarStatus, Me.ToolBarProgress1, Me.ToolBarProgress2})
        Me.ToolBar.Location = New System.Drawing.Point(0, 274)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(458, 22)
        Me.ToolBar.SizingGrip = False
        Me.ToolBar.TabIndex = 12
        Me.ToolBar.Text = "StatusStrip1"
        '
        'ToolBarStatus
        '
        Me.ToolBarStatus.Name = "ToolBarStatus"
        Me.ToolBarStatus.Size = New System.Drawing.Size(59, 17)
        Me.ToolBarStatus.Text = "Loading..."
        '
        'ToolBarProgress1
        '
        Me.ToolBarProgress1.Name = "ToolBarProgress1"
        Me.ToolBarProgress1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolBarProgress2
        '
        Me.ToolBarProgress2.Name = "ToolBarProgress2"
        Me.ToolBarProgress2.Size = New System.Drawing.Size(100, 16)
        '
        'FroggPTLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FroggPTLauncher.My.Resources.Resources.fond1
        Me.ClientSize = New System.Drawing.Size(458, 296)
        Me.Controls.Add(Me.MenuMain)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.PanelLauncher)
        Me.Controls.Add(Me.PanelOption)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FroggPTLauncher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FroggPT Launcher"
        Me.OptGroupBox1.ResumeLayout(False)
        Me.OptGroupBox2.ResumeLayout(False)
        Me.OptGroupBox2.PerformLayout()
        Me.OptGroupBox3.ResumeLayout(False)
        Me.OptGroupBox3.PerformLayout()
        Me.OptGroupBox4.ResumeLayout(False)
        Me.OptGroupBox4.PerformLayout()
        Me.PanelOption.ResumeLayout(False)
        Me.PanelOption.PerformLayout()
        CType(Me.PanelOptSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelOptTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLauncher.ResumeLayout(False)
        Me.PanelLauncher.PerformLayout()
        CType(Me.PanelLchPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelLchOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelLchTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuMain.ResumeLayout(False)
        Me.MenuMain.PerformLayout()
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OptGroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptGroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptGraphic3 As System.Windows.Forms.RadioButton
    Friend WithEvents OptGraphic2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptGraphic1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptGroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptColor2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptColor1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptGroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OptMotion2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptMotion1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptFullScreen As System.Windows.Forms.CheckBox
    Friend WithEvents OptNoSound As System.Windows.Forms.CheckBox
    Friend WithEvents OptScreenS As System.Windows.Forms.ComboBox
    Friend WithEvents OptScreenT As System.Windows.Forms.ComboBox
    Friend WithEvents PanelOption As System.Windows.Forms.Panel
    Friend WithEvents PanelOptTitle As System.Windows.Forms.PictureBox
    Friend WithEvents PanelOptSave As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLauncher As System.Windows.Forms.Panel
    Friend WithEvents PanelLchPlay As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLchOptions As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLchTitle As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLchNews As System.Windows.Forms.WebBrowser
    Friend WithEvents MenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStartGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolBarStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolBarProgress1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolBarProgress2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents FroggPTNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFroggFr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuForum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFacebook As System.Windows.Forms.ToolStripMenuItem

End Class
