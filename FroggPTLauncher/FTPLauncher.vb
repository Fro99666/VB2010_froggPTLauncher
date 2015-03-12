Imports System.IO
Imports System.Net

' TODO LIST
' Resume version download

Public Class FroggPTLauncher

#Region "Default values"

    'create a thread
    Public cThread

    '############Network
    Public webUrl = "http://www.frogg.fr"
    Public forumUrl = "http://forum.frogg.fr"
    Public facebookUrl = "http://facebook.frogg.fr"

    '############Files
    'first update version
    Public firstVersion = "5160"
    'game file
    Public gameFile = "game.exe"
    'game version file
    Public versionFile = "version.txt"
    'game version server file
    Public versionServer = "http://version.frogg.fr/"
    Public versionParam = "?version="
    'Configuration file
    Public configFile = "ptReg.rgx"
    'game news server url
    Public newsServer = "http://news.frogg.fr/"

    '############Configuration
    'check if data are loaded
    Public isLoaded = False
    'Default values
    Public ColorBPP = "32"
    Public WindowMode = "1"
    Public Graphic = "3"
    Public MotionBlur = "true"
    Public ScreenSize = "1"
    'screen values
    Public st = New Dictionary(Of String, String())
    Public sw = New Dictionary(Of String, String)
    Public resMax = 2 'nb max res for window mode
    'init screen values
    Private Sub initValues()
        'Init type values
        st("4:3") = {"800x600", "1024x768", "1280x1024", "1600x1200"}
        st("16:9") = {"800x450", "1024x576", "1280x720", "1600x900"}
        st("16:10") = {"800x500", "1024x640", "1280x800", "1600x1000"}
        'Init screen values
        sw("800x600") = "1"
        sw("1024x768") = "2"
        sw("1280x1024") = "3"
        sw("1600x1200") = "4"
        sw("800x450") = "5"
        sw("1024x576") = "6"
        sw("1280x720") = "7"
        sw("1600x900") = "8"
        sw("800x500") = "9"
        sw("1024x640") = "10"
        sw("1280x800") = "11"
        sw("1600x1000") = "12"
    End Sub
    'Sounds
    Public sndFold = {"wav", "image/Sinimage/sound"}
    Public sndFile = {"Startimage\opening\intro.wav", "Startimage\login\CharacterSelect.wav"}
    Public sndMove = "z"

#End Region


#Region "Form values"

    'set values in form from loaded values
    Private Sub setFormValues()
        Dim resolution = getKeyFromDictionary(sw, ScreenSize), isFound = False, selectedType = ""
        'Motion Blur
        If MotionBlur = "true" Then OptMotion1.Checked = True
        If MotionBlur = "false" Then OptMotion2.Checked = True
        'Color
        If ColorBPP = "16" Then OptColor1.Checked = True
        If ColorBPP = "32" Then OptColor2.Checked = True
        'window mode
        If WindowMode = "0" Then OptFullScreen.Checked = True
        'Graphic
        If Graphic = "1" Then OptGraphic1.Checked = True
        If Graphic = "2" Then OptGraphic2.Checked = True
        If Graphic = "3" Then OptGraphic3.Checked = True
        'sound test
        If Not My.Computer.FileSystem.DirectoryExists(sndFold(0)) Then
            OptNoSound.Checked = True
        End If
        'Screen Size
        For Each kv As KeyValuePair(Of String, String()) In st
            'Display Key and Value.
            OptScreenT.Items.Add(kv.Key)
            'if key is resolution then mean it is selected
            If Not isFound Then
                isFound = setScreenSList(kv.Value, resolution)
                selectedType = kv.Key
            End If
        Next
        'default selected values
        OptScreenT.SelectedItem = selectedType
        OptScreenS.SelectedItem = resolution
        'check resolution validity
        checkResolution()
    End Sub

    'set values from form values
    Private Sub getFormValues()
        'Motion Blur
        If OptMotion1.Checked = True Then MotionBlur = "true"
        If OptMotion2.Checked = True Then MotionBlur = "false"
        'Color
        If OptColor1.Checked = True Then ColorBPP = "16"
        If OptColor2.Checked = True Then ColorBPP = "32"
        'Graphic
        If OptGraphic1.Checked = True Then Graphic = "1"
        If OptGraphic2.Checked = True Then Graphic = "2"
        If OptGraphic3.Checked = True Then Graphic = "3"
        'window mode
        If OptFullScreen.Checked = True Then WindowMode = "0" Else WindowMode = "1"
        'Screen Size
        ScreenSize = sw(OptScreenS.SelectedItem)
    End Sub

#End Region


#Region "File values"

    'set values to config file
    Private Sub setValues()
        Dim lines As New ArrayList, move = "", remove = ""

        'set values
        lines.Add("""ColorBPP"" = """ & ColorBPP & """")
        lines.Add("""Graphic"" = """ & Graphic & """")
        lines.Add("""MotionBlur"" = """ & MotionBlur & """")
        lines.Add("""ScreenSize"" = """ & ScreenSize & """")
        lines.Add("""WindowMode"" = """ & WindowMode & """")
        writeFile(configFile, lines)

        'sound management
        If OptNoSound.Checked = True Then remove = "z" Else move = "z"

        For Each fold In sndFold
            If My.Computer.FileSystem.DirectoryExists(fold & move) Then My.Computer.FileSystem.RenameDirectory(fold & move, fold & remove)
        Next
        For Each file In sndFile
            If My.Computer.FileSystem.FileExists(file & move) Then My.Computer.FileSystem.RenameFile(file & move, file & remove)
        Next

    End Sub

    'get values from config file
    Private Sub getValues()
        Dim config As String, configLine As String(), lineVals As String()
        'check if conf file exist else cannot read info in it
        If My.Computer.FileSystem.FileExists(configFile) Then
            'read file config content
            config = My.Computer.FileSystem.ReadAllText(configFile)
            'get each line
            configLine = config.Split(vbCrLf)
            'for each lines
            For Each line In configLine
                'If Contains char "
                If line.Contains("""") Then
                    'spit char "
                    lineVals = line.Split("""")
                    'if array has at least 3 elements then set values
                    If lineVals.Length > 3 Then
                        Select Case lineVals(1)
                            Case "MotionBlur"
                                MotionBlur = lineVals(3)
                            Case "ColorBPP"
                                ColorBPP = lineVals(3)
                            Case "WindowMode"
                                WindowMode = lineVals(3)
                            Case "Graphic"
                                Graphic = lineVals(3)
                            Case "ScreenSize"
                                ScreenSize = lineVals(3)
                        End Select
                    End If
                End If
            Next
        End If
    End Sub

#End Region


#Region "Menu Actions"

    Private Sub MenuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuHelp.Click
        setRdmBg()
    End Sub

    Private Sub MenuOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOptions.Click
        If MenuOptions.Text = "[ Launcher ]" Then showLauncher() Else showOption()
    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        exitMain()
    End Sub

    Private Sub MenuStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStartGame.Click
        startGame()
    End Sub

    Private Sub MenuUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUpdate.Click
        updateGameVersion()
    End Sub

    Private Sub MenuFroggFr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFroggFr.Click
        Process.Start(webUrl)
    End Sub

    Private Sub MenuForum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuForum.Click
        Process.Start(forumUrl)
    End Sub

    Private Sub MenuFacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFacebook.Click
        Process.Start(facebookUrl)
    End Sub

#End Region


#Region "Form Actions"

    'Form Loading
    Private Sub FroggPTConfigurator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'hide toolbar with code to prevent unknow crash
        ToolBarProgress1.Visible = False
        ToolBarProgress2.Visible = False
        'init news
        setNews()
        'random bg
        setRdmBg()
        'init values
        initValues()
        'get options from config file
        getValues()
        'send values to form
        setFormValues()
        'set as loaded
        isLoaded = True
        'check game version
        cThread = New System.Threading.Thread(AddressOf checkGameVersion)
        cThread.Start()
    End Sub

    'Screen type change load new values
    Private Sub OptScreenT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptScreenT.Click
        If isLoaded Then
            setScreenSList(st(OptScreenT.SelectedItem), st(OptScreenT.SelectedItem)(0))
            OptScreenS.SelectedIndex = 0
            checkResolution()
        End If
    End Sub

    'check input check values
    Private Sub OptFullScreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptFullScreen.Click
        checkResolution()
    End Sub

#End Region


#Region "Main Actions"

    Sub setNews()
        PanelLchNews.Url = New Uri(newsServer)
    End Sub

    Sub exitMain()
        System.Environment.Exit(-1)
        System.Windows.Forms.Application.Exit()
        cThread.abort()
        Close()
    End Sub

    Sub startGame()
        Dim FileName As String = IO.Path.Combine(Application.StartupPath, gameFile)
        Dim BytesToWrite() As Byte = My.Resources.Resources.game
        Dim FileStream As New System.IO.FileStream(FileName, System.IO.FileMode.OpenOrCreate)
        Dim BinaryWriter As New System.IO.BinaryWriter(FileStream)
        BinaryWriter.Write(BytesToWrite)
        BinaryWriter.Close()
        FileStream.Close()
        Process.Start(FileName)
        exitMain()
    End Sub

    Sub setRdmBg()
        Dim random As New Random(), imgNb = random.Next(1, 18)
        While oldRdm = imgNb
            imgNb = random.Next(1, 18)
        End While
        Select Case imgNb
            Case 1
                Me.BackgroundImage = My.Resources.Resources.fond1
            Case 2
                Me.BackgroundImage = My.Resources.Resources.fond2
            Case 3
                Me.BackgroundImage = My.Resources.Resources.fond3
            Case 4
                Me.BackgroundImage = My.Resources.Resources.fond4
            Case 5
                Me.BackgroundImage = My.Resources.Resources.fond5
            Case 6
                Me.BackgroundImage = My.Resources.Resources.fond6
            Case 7
                Me.BackgroundImage = My.Resources.Resources.fond7
            Case 8
                Me.BackgroundImage = My.Resources.Resources.fond8
            Case 9
                Me.BackgroundImage = My.Resources.Resources.fond9
            Case 10
                Me.BackgroundImage = My.Resources.Resources.fond10
            Case 11
                Me.BackgroundImage = My.Resources.Resources.fond11
            Case 12
                Me.BackgroundImage = My.Resources.Resources.fond12
            Case 13
                Me.BackgroundImage = My.Resources.Resources.fond13
            Case 14
                Me.BackgroundImage = My.Resources.Resources.fond14
            Case 15
                Me.BackgroundImage = My.Resources.Resources.fond15
            Case 16
                Me.BackgroundImage = My.Resources.Resources.fond16
            Case 17
                Me.BackgroundImage = My.Resources.Resources.fond17
        End Select
        oldRdm = imgNb
    End Sub

#End Region


#Region "Configurator Functions"

    Public removeditems As New ArrayList
    Public oldRdm = 0

    'change list SreenS values
    Function setScreenSList(ByVal arrStr As String(), ByVal resolution As String)
        Dim isFound = False
        For Each str As String In arrStr
            If str = resolution Then
                'clean Screen items
                OptScreenS.Items.Clear()
                'add Screen items
                For Each res In arrStr
                    OptScreenS.Items.Add(res)
                Next
                isFound = True
            End If
        Next
        setScreenSList = isFound
    End Function

    'check valid values for resolution selected
    Sub checkResolution()
        If OptFullScreen.Checked = True Then
            'restore removed resolutions
            For Each it In removeditems
                OptScreenS.Items.Add(it)
            Next
            'clean removeditem list
            removeditems.Clear()
        Else
            'if full windowed mode only < 1280 resolution are available
            If OptScreenS.SelectedIndex >= resMax Then
                OptScreenS.SelectedIndex = 0
            End If
            'clean removeditem list
            removeditems.Clear()
            'remove incompatible resolution
            While OptScreenS.Items.Count > resMax
                removeditems.Add(OptScreenS.Items(resMax).ToString)
                OptScreenS.Items.Remove(OptScreenS.Items(resMax))
            End While
        End If
    End Sub

    Sub showOption()
        MenuOptions.Text = "[ Launcher ]"
        PanelLauncher.Visible = False
        PanelOption.Visible = True
    End Sub

    Sub showLauncher()
        MenuOptions.Text = "[  Options  ]"
        PanelOption.Visible = False
        PanelLauncher.Visible = True
    End Sub

#End Region


#Region "Version Functions"

    Public clientVersionInt As Integer
    Public versionList As Array
    Public startFrom As Integer = 0

    'check if game version if uptodate
    Sub checkGameVersion()

        Dim clientVersion As String, w As Integer = 0, serverVersion = "", webReq As Net.WebRequest, webRes As Net.WebResponse, inStream As StreamReader, versionUpToDate = False

        Try
            'get request file on version web server
            webReq = WebRequest.Create(versionServer)
            webRes = webReq.GetResponse()
            inStream = New StreamReader(webRes.GetResponseStream())
            versionList = inStream.ReadToEnd().Split(New String() {vbLf}, StringSplitOptions.RemoveEmptyEntries)
            'check if client file exist
            If My.Computer.FileSystem.FileExists(versionFile) Then
                clientVersion = My.Computer.FileSystem.ReadAllText(versionFile)
            Else
                clientVersion = firstVersion
                displayMsg("Version not found", 1)
            End If
            'get last server version
            For Each elem As String In versionList
                serverVersion = elem
                If serverVersion = clientVersion Then startFrom = w
                w = w + 1
            Next
            'convert strings to int
            clientVersionInt = Val(clientVersion)
            'test version
            If clientVersionInt = Val(serverVersion) Then
                versionUpToDate = True
                enablePlay()
                displayMsg("Your Version " & clientVersionInt & " is Up to date ! ", 1)
            Else
                displayMsg("Your Version " & clientVersionInt & " is OutDated ", 1)
            End If

        Catch ex As Exception
            displayMsg("An error occured while contacting Version server : " & vbCrLf & ex.Message, -1)
        End Try

        'version not up to date
        If Not versionUpToDate Then
            enableUpdate()
            If displayMsg("Your Version " & clientVersionInt & " is OutDated " & vbCrLf & "Last version is " & serverVersion & vbCrLf & vbCrLf & "Do you wish to update your FroggPT version to " & serverVersion, 3) Then updateGameVersion()
        End If

    End Sub

    'Add: cannot leave while updating
    Private Sub updateGameVersion()
        Dim nbVersion As Integer, notInit As Boolean, version As String
        'get version length
        nbVersion = (versionList.Length - 1)
        'get last server version
        For j As Integer = startFrom To nbVersion
            version = versionList(j)
            'For Each version As String In versionList
            If Not Trim(version) = "" Then
                If Val(version) > clientVersionInt Then
                    If Not notInit Then
                        initProgressBar(ToolBarProgress1, j, nbVersion + 1)
                        notInit = True
                    End If
                    displayMsg("Updating version to " & version, 1)
                    If Not downloadGameVersion(version) Then
                        ToolBarProgress1.Visible = False
                        Exit Sub
                    End If
                    ToolBarProgress1.Value = j + 1
                    System.Threading.Thread.Sleep(1000)
                End If
            End If
        Next
        'hide progress bar
        ToolBarProgress1.Visible = False
        'check if version has been updated
        checkGameVersion()
    End Sub

    'download file for a game version
    Private Function downloadGameVersion(ByVal version As String)
        Dim inStream As StreamReader, webReq As Net.WebRequest, webRes As Net.WebResponse, versionFileList As Array, nbFile As Integer, File As String
        Try
            'get file list
            webReq = WebRequest.Create(versionServer & versionParam & version)
            webRes = webReq.GetResponse()
            inStream = New StreamReader(webRes.GetResponseStream())
            versionFileList = inStream.ReadToEnd().Split(New String() {vbLf}, StringSplitOptions.RemoveEmptyEntries)
            'nb files in patch folder
            nbFile = versionFileList.Length - 1
            'init progress bar values
            initProgressBar(ToolBarProgress2, 0, nbFile + 1)
            'for each file in version list, download file
            For i As Integer = 0 To nbFile
                File = versionFileList(i)
                'downloading file
                If Not Trim(File) = "" Then
                    'displayMsg("downloading " & file, 1)
                    Dim targetFile = Replace(File, version & "/", "")
                    If My.Computer.FileSystem.FileExists(targetFile) Then My.Computer.FileSystem.DeleteFile(targetFile)
                    My.Computer.Network.DownloadFile(versionServer & version & File, targetFile)
                End If
                ToolBarProgress2.Value = i + 1
            Next
            'update version file
            Dim arrList As New ArrayList
            arrList.Add(version)
            writeFile(versionFile, arrList)
            'hide progress bar
            ToolBarProgress2.Visible = False
            'confirm message
            displayMsg("Version " & version & " installed", 1)
            Return True
        Catch ex As Exception
            displayMsg("An error occured while updating game version : " & vbCrLf & ex.Message, -1)
            Return False
        End Try
    End Function

    'enable play button
    Sub enablePlay()
        MenuStartGame.Enabled = True
        MenuUpdate.Enabled = False
        PanelLchPlay.Image = My.Resources.Resources.play
        PanelLchPlay.Enabled = True
    End Sub

    'enable update button
    Sub enableUpdate()
        MenuStartGame.Enabled = False
        MenuUpdate.Enabled = True
        PanelLchPlay.Enabled = False
    End Sub

#End Region


#Region "Buttons"

    '======[ SAVE BUTTON ]======

    Private Sub PanelOptSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelOptSave.Click
        'get option from form
        getFormValues()
        'send values to config file
        setValues()
        'msg ok
        displayMsg("Settings saved ^_^", 0)
        displayMsg("Settings saved ^_^", 1)
        'Show luancher window
        showLauncher()
    End Sub

    Private Sub SaveImg_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelOptSave.MouseHover
        PanelOptSave.Image = My.Resources.Resources.save_o
    End Sub

    Private Sub PanelOptSave_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelOptSave.MouseLeave
        PanelOptSave.Image = My.Resources.Resources.save
    End Sub

    Private Sub PanelOptSave_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelOptSave.MouseDown
        PanelOptSave.Image = My.Resources.Resources.save_a
    End Sub

    '=====[ OPTION BUTTON ]=====

    Private Sub PanelLchOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchOptions.Click
        showOption()
    End Sub

    Private Sub PanelLchOptions_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchOptions.MouseHover
        PanelLchOptions.Image = My.Resources.Resources.options_o
    End Sub

    Private Sub PanelLchOptions_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchOptions.MouseLeave
        PanelLchOptions.Image = My.Resources.Resources.options
    End Sub

    Private Sub PanelLchOptions_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchOptions.MouseDown
        PanelLchOptions.Image = My.Resources.Resources.options_a
    End Sub

    '======[ PLAY BUTTON ]======

    Private Sub PanelLchPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchPlay.Click
        startGame()
    End Sub

    Private Sub PanelLchPlay_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchPlay.MouseHover
        PanelLchPlay.Image = My.Resources.Resources.play_o
    End Sub

    Private Sub PanelLchPlay_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchPlay.MouseLeave
        PanelLchPlay.Image = My.Resources.Resources.play
    End Sub

    Private Sub PanelLchPlay_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelLchPlay.MouseDown
        PanelLchPlay.Image = My.Resources.Resources.play_a
    End Sub

#End Region


#Region "Functions"

    'get key from a value in dictionary
    Function getKeyFromDictionary(ByVal Dic As Dictionary(Of String, String), ByVal strItem As String) As String
        'Init Loop over entries.
        Dim kv As KeyValuePair(Of String, String)
        'Loop over entries.
        For Each kv In Dic
            'if key is resolution then mean it is selected
            If kv.Value = strItem Then
                getKeyFromDictionary = kv.Key
                Exit Function
            End If
        Next
        getKeyFromDictionary = ""
    End Function

    'Create a file
    Sub writeFile(ByVal fileName As String, ByVal lines As ArrayList)
        'create stream file
        Dim streamFile As New System.IO.StreamWriter(fileName, False)
        'add each line
        For Each line In lines
            streamFile.WriteLine(line)
        Next
        'end file stream
        streamFile.Close()
    End Sub

    'Display msg
    Function displayMsg(ByVal msg As String, ByVal lvl As Integer)
        'lvl -1 = error
        'lvl  0 = ok
        'lvl  1 = info
        'lvl  2 = waring

        Dim msgTitle = "FroggPT launcher message", btn As Integer

        'define msg box title depending in lvl value
        Select Case lvl
            Case -1
                msgTitle = "Error occured"
                btn = Nothing
                ToolBarStatus.Text = msgTitle
                ToolBarProgress1.Visible = False
                ToolBarProgress2.Visible = False
            Case 1
                msgTitle = ""
                btn = Nothing
            Case 2
                msgTitle = "Warning occured"
                btn = Nothing
            Case 3
                msgTitle = "Make a choice"
                btn = MessageBoxButtons.YesNo
        End Select

        'if no title is set then no msg box pop
        If Not msgTitle = "" Then
            If btn = MessageBoxButtons.YesNo Then
                Dim answer As DialogResult
                answer = MsgBox(msg, btn, msgTitle)
                If answer = vbYes Then displayMsg = True Else displayMsg = False
            Else
                MsgBox(msg, btn, msgTitle)
                displayMsg = True
            End If
        Else
            ToolBarStatus.Text = msg
            displayMsg = True
        End If

    End Function

    'init a progress bar
    Sub initProgressBar(ByVal progress As ToolStripProgressBar, ByVal s As Integer, ByVal e As Integer)
        progress.Visible = True
        progress.Minimum = s
        progress.Maximum = e
    End Sub


#End Region

End Class