Imports BrightIdeasSoftware
Imports Gecko
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Public Class FrmMain

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddListviewColumns()
        LoadComponents()
    End Sub

    Private Sub LoadComponents()

        Dim importClass As New Import

        folvMain.AddObjects(importClass.AccountAll(Application.StartupPath & "\data\accounts.db"))
        Gecko.GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Windows; U; Windows NT 6.1; pl; rv:1.9.1) Gecko/20090624 Firefox/3.5 (.NET CLR 3.5.30729)"

    End Sub

    Private Sub AddListviewColumns()
        Try
            Dim col(4) As OLVColumn

            col(0) = New OLVColumn("Service", "Service")
            col(0).Width() = 100

            col(1) = New OLVColumn("Username", "Username")
            col(1).Width() = 120

            col(2) = New OLVColumn("Password", "Password")
            col(2).Width() = 80

            'col(3) = New OLVColumn("Proxy", "Proxy")
            'col(3).Width() = 100

            'col(4) = New OLVColumn("Port", "Port")
            'col(4).Width() = 60

            col(3) = New OLVColumn("Credits", "Credits")
            col(3).Width() = 60

            col(4) = New OLVColumn("Status", "Status")
            col(4).Width() = 180
            col(4).FillsFreeSpace = True

            For i = 0 To col.Length - 1
                folvMain.Columns.Add(col(i))
            Next

            'Dim lvItem As List(Of SocialList) = New List(Of SocialList)()

            'With lvItem
            '    .Add(New SocialList() With {
            '    .Status = "Newly Added",
            '    .Password = "3eea818c",
            '    .Username = "g4m3r",
            '    .Port = 0,
            '    .Proxy = "",'txtProxy.Text,
            '    .Service = gbService.Text,
            '    .Credits = "0"})

            'End With

            'folvMain.AddObjects(lvItem)

        Catch ex As Exception
            MsgBox(ex.ToString)
            'Logging.WriteLog(ex.ToString)
            'ExceptionBase.Track(ex, True)
        End Try
    End Sub

    Private Sub TsmiStartEarning_Click(sender As Object, e As EventArgs) Handles tsmiStartEarning.Click
        StartEarning()
    End Sub

    Private Sub StopEarningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopEarningToolStripMenuItem.Click
        StopEarning()
    End Sub


    Private Sub StartEarning()
        Dim selection As SocialList = CType(folvMain.SelectedObject, SocialList)

        If Not selection Is Nothing Then 'Select SEN service

            If Config.Earning Then
                MessageBox.Show("Please first stop the earning process before starting another.", "Only ear on one at a time.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Config.Earning = True
                Config.EarningService = selection.Service

                selection.Status = "Earning started."
                folvMain.UpdateObject(selection)

                If selection.Service = "SocialClerks.com" Then
                    SocialClerksEarn(selection)
                ElseIf selection.Service = "AddMeFast.com" Then
                    AddMeFastEarn(selection)
                Else
                    SocialExchangeScriptEarn(selection)
                End If


            End If
        End If
    End Sub

    Private Sub StopEarning()
        Dim selection As SocialList = CType(folvMain.SelectedObject, SocialList)

        If Not selection Is Nothing Then 'Select SEN service

            If selection.Service = "SocialClerks.com" Then
                Config.Earning = False
                Config.EarningService = ""
                SocialClerks.StopEarningSocialclerks = True
                selection.Status = "Earning stopped."
                folvMain.UpdateObject(selection)
            ElseIf selection.Service = "AddMeFast.com" Then
                Config.Earning = False
                Config.EarningService = ""
                AddMeFast.Logout()
                selection.Status = "Earning stopped."
                folvMain.UpdateObject(selection)
            Else
                Config.Earning = False
                Config.EarningService = ""
                SocialExchangeScript.Logout(selection.Service)
                selection.Status = "Earning stopped."
                folvMain.UpdateObject(selection)
            End If
        End If

    End Sub

    Private Sub SocialClerksEarn(ByVal lvItem As SocialList)
        Try
            SocialClerks.StopEarningSocialclerks = False
            SocialClerks.EarningSocialclerks = True

            lvItem.Status = "Logging in..."
            folvMain.UpdateObject(lvItem)

            Dim loginResponse As String = SocialClerks.SocialClerksLogin(lvItem.Username, lvItem.Password)

            If loginResponse = "Login successful" Then

                lvItem.Status = loginResponse

                lvItem.Credits = SocialClerks.SocialClerksGetCredits(False)
                folvMain.UpdateObject(lvItem)

                For i As Integer = 0 To 1000000

                    If Config.Earning = False Then
                        Exit For
                    End If

                    lvItem.Status = "Earning Credits... " & i.ToString()
                    folvMain.UpdateObject(lvItem)
                    SocialClerks.SocialClerksEarn(True, lvItem)
                    lvItem.Credits = SocialClerks.SocialClerksGetCredits(True)

                    If Config.Earning = False Then
                        Exit For
                    End If
                Next
            Else
                lvItem.Status = loginResponse
                folvMain.UpdateObject(lvItem)
            End If

            SocialClerks.EarningSocialclerks = False

            lvItem.Status = "Earning stopped."
            folvMain.UpdateObject(lvItem)
        Catch ex As Exception

            SocialClerks.EarningSocialclerks = False

            lvItem.Status = "Earning stopped (error)."
            folvMain.UpdateObject(lvItem)
        End Try
    End Sub

    Private Sub SocialExchangeScriptEarn(ByVal lvItem As SocialList)
        Try

            lvItem.Status = "Logging in..."
            folvMain.UpdateObject(lvItem)

            Dim loginResponse As String = SocialExchangeScript.Login(lvItem.Username, lvItem.Password, lvItem.Service)

            If loginResponse = "Login successful" Then

                lvItem.Status = loginResponse

                lvItem.Status = "Earning Credits... "
                folvMain.UpdateObject(lvItem)

                SocialExchangeScript.Earn(lvItem)
            Else
                lvItem.Status = loginResponse
                folvMain.UpdateObject(lvItem)
            End If

            lvItem.Status = "Earning stopped."
            folvMain.UpdateObject(lvItem)

            Config.Earning = False
            Config.EarningService = ""
        Catch ex As Exception
            lvItem.Status = "Earning stopped (error)."
            folvMain.UpdateObject(lvItem)

            Config.Earning = False
            Config.EarningService = ""
        End Try
    End Sub

    'Private Sub MyDailyLikesEarn(ByVal lvItem As SocialList)
    '    Try

    '        lvItem.Status = "Logging in..."
    '        folvMain.UpdateObject(lvItem)

    '        Dim loginResponse As String = MyDailyLikes.Login(lvItem.Username, lvItem.Password)

    '        If loginResponse = "Login successful" Then

    '            lvItem.Status = loginResponse

    '            lvItem.Status = "Earning Credits... "
    '            folvMain.UpdateObject(lvItem)

    '            MyDailyLikes.Earn(lvItem)
    '        Else
    '            lvItem.Status = loginResponse
    '            folvMain.UpdateObject(lvItem)
    '        End If

    '        lvItem.Status = "Earning stopped."
    '        folvMain.UpdateObject(lvItem)

    '        Config.Earning = False
    '        Config.EarningService = ""
    '    Catch ex As Exception
    '        lvItem.Status = "Earning stopped (error)."
    '        folvMain.UpdateObject(lvItem)

    '        Config.Earning = False
    '        Config.EarningService = ""
    '    End Try
    'End Sub

    Private Sub AddMeFastEarn(ByVal lvItem As SocialList)
        Try

            lvItem.Status = "Logging in..."
            folvMain.UpdateObject(lvItem)

            Dim loginResponse As String = AddMeFast.Login(lvItem.Username, lvItem.Password)

            If loginResponse = "Login successful" Then

                lvItem.Status = loginResponse

                lvItem.Status = "Earning Credits... "
                folvMain.UpdateObject(lvItem)

                AddMeFast.Earn(lvItem)
            Else
                lvItem.Status = loginResponse
                folvMain.UpdateObject(lvItem)
            End If

            lvItem.Status = "Earning stopped."
            folvMain.UpdateObject(lvItem)

            Config.Earning = False
            Config.EarningService = ""
        Catch ex As Exception
            lvItem.Status = "Earning stopped (error)."
            folvMain.UpdateObject(lvItem)

            Config.Earning = False
            Config.EarningService = ""
        End Try
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Dim lvItem As List(Of SocialList) = New List(Of SocialList)()

        With lvItem
            .Add(New SocialList() With {
            .Status = "Newly Added",
            .Password = txtPassword.Text,
            .Username = txtUsername.Text,
            .Port = 0,
            .Proxy = "", 'txtProxy.Text,
            .Service = gbService.Text,
            .Credits = "0"})

        End With

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Or gbService.Text = Nothing Then
            MessageBox.Show("Please enter all account details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            folvMain.AddObjects(lvItem)
            SaveAccounts()
        End If
    End Sub

    Private Sub RemoveAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAccountToolStripMenuItem.Click

        If MessageBox.Show("Are you sure to remove the selected account?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Dim selection As SocialList = CType(folvMain.SelectedObject, SocialList)


            If Not selection Is Nothing Then
                folvMain.RemoveObject(selection)
                SaveAccounts()
            End If
        End If
    End Sub

    Private Sub SaveAccounts()
        Dim exportClass As New Export

        Dim allObjects As List(Of SocialList) = New List(Of SocialList)
        exportClass.AccountsAll(folvMain.Objects.Cast(Of SocialList)().ToList())
    End Sub

    Private Sub folvMain_MouseUp(sender As Object, e As MouseEventArgs) Handles folvMain.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            cmMain.Show(MousePosition)
        End If
    End Sub

    Private Sub BtnRegisterAccount_Click(sender As Object, e As EventArgs) Handles BtnRegisterAccount.Click
        Process.Start("http://" & gbService.Text)
    End Sub
    Private Sub BtnShowDebug_Click(sender As Object, e As EventArgs) Handles BtnShowDebug.Click
        If BtnShowDebug.Text = "ndbg" Then
            BtnShowDebug.Text = "dbg"
            Me.Height = 355
            Me.Width = 707
            '570; 355
        Else
            BtnShowDebug.Text = "ndbg"
            Me.Height = 355
            Me.Width = 1655
            '1655; 355
        End If
    End Sub

    Private Sub wbMain_CreateWindow(sender As Object, e As GeckoCreateWindowEventArgs) Handles wbMain.CreateWindow
        e.Cancel = True
    End Sub
End Class
