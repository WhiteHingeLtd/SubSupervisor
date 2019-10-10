Imports System.ComponentModel
Imports System.ServiceModel
Imports System.Windows.Media
Imports WHLClasses
Imports WHLClasses.Orders
Imports WHLClasses.Services
Imports WHLClasses.Services.OrderServer

Public Class wpfMainWindow
    Dim Loader As New GenericDataController
    Dim CurrentOrddef As OrderDefinition
    Dim fiveminticker As Integer = 0
    Public WindowToClose As New Form1
    Dim LoadOrders As New BackgroundWorker
    Dim RefreshTimer As New Timer

    Dim SaturdayPacked As Integer = 0
    Dim saturdaysaved As Boolean = False
    Dim SundayPacked As Integer = 0
    Dim sundaysaved As Boolean = False

    Private Sub LoadTheProgram() Handles Me.Loaded

        LoadOrders.WorkerReportsProgress = True
        AddHandler LoadOrders.DoWork, AddressOf LoadOrders_DoWork
        AddHandler LoadOrders.ProgressChanged, AddressOf LoadOrders_ProgressChanged

        fiveminticker = 16
        RefreshTimer.Enabled = True
        RefreshTimer.Interval = 1000
        AddHandler RefreshTimer.Tick, AddressOf TickTime
    End Sub

    Private Sub ToDoWhenClosing() Handles Me.Closed
        Try
            WindowToClose.CloseWinProper()
        Catch ex As Exception
            MsgBox("The sub supervisor screen failed to close program correctly. Please end the program from the task manager!" + vbNewLine + vbNewLine + ex.ToString)
            Me.Close()
        End Try
    End Sub

    Dim newDay As Boolean = False
    Dim previousDay As New Date
    Dim totalforavgsales As Integer = 0
    Dim today As Date = Now.Date
    Dim ClockTotal As Boolean = True
    Dim newCalculator As New DayAverageCalculator

    Private Sub TickTime()
        If Not workbusy Then

            fiveminticker += 1 'Increment timer.

            If fiveminticker Mod 5 = 0 Then
                If Now.Hour < 19 And Now.Hour >= 7 Then

                    newCalculator = Loader.LoadAnything(of DayAverageCalculator)("T:\AppData\Analytics\Average.SPAS", False).Value

                    PickingExpected.Text = Math.Round(newCalculator.WorkOutAveragePicking).ToString
                    PackingExpected.Text = Math.Round(newCalculator.WorkOutAveragePacking).ToString

                    TickerText.Text = "          " + newCalculator.MessageText.PadRight(45, " ") + "          "

                    SetActual()

                    Dim pickTarget As Integer = Convert.ToInt32(PickingActual.Text) - Convert.ToInt32(PickingExpected.Text)
                    If pickTarget > 100 Then
                        PickLamp.Background = (New SolidColorBrush(Color.FromRgb(0, 255, 0)))
                    ElseIf pickTarget < -100 Then
                        PickLamp.Background = (New SolidColorBrush(Color.FromRgb(255, 0, 0)))
                    Else
                        PickLamp.Background = (New SolidColorBrush(Color.FromRgb(255, 255, 0)))
                    End If
                    PickingTarget.Text = Math.Round(pickTarget, 0).ToString

                    Dim packTarget As Integer = Convert.ToInt32(PackingActual.Text) - Convert.ToInt32(PackingExpected.Text)
                    If packTarget > 100 Then
                        PackLamp.Background = (New SolidColorBrush(Color.FromRgb(0, 255, 0)))
                    ElseIf packTarget < -100 Then
                        PackLamp.Background = (New SolidColorBrush(Color.FromRgb(255, 0, 0)))
                    Else
                        PackLamp.Background = (New SolidColorBrush(Color.FromRgb(255, 255, 0)))
                    End If
                    PackingTarget.Text = Math.Round(packTarget, 0).ToString

                    ClockTotal = Not ClockTotal
                Else
                    If Now.DayOfWeek = DayOfWeek.Saturday And Now.Hour = 19 And Not saturdaysaved Then
                        SaturdayPacked = Convert.ToInt32(PackedCount.Text)
                        Loader.SaveDataToFile("SaturdayPackedItems.IntFile", SaturdayPacked, "T:\AppData\Analytics")
                        saturdaysaved = True
                    ElseIf Now.DayOfWeek = DayOfWeek.Sunday And Now.Hour = 19 And Not sundaysaved Then
                        SundayPacked = Convert.ToInt32(PackedCount.Text)
                        Loader.SaveDataToFile("SundayPackedItems.IntFile", SundayPacked, "T:\AppData\Analytics")
                        sundaysaved = True
                    End If

                    Dim tempMessage As String = "Will refresh data at 8am."
                    TickerText.Text = "          " + tempMessage.PadRight(45, " ") + "          "
                End If
            End If

            If fiveminticker >= 20 Then '10 seconds
                Try
                    If My.Application.Deployment.CheckForUpdate Then
                        My.Application.Deployment.Update()
                        Application.Restart()
                    End If
                Catch ex As Deployment.Application.InvalidDeploymentException

                End Try
                ReloadingOrddefLabel.Text = "Refreshing order data"

                Dim refreshingOrdersNow As Boolean = True
                While refreshingOrdersNow
                    If Not LoadOrders.IsBusy Then
                        LoadOrders.RunWorkerAsync()
                        refreshingOrdersNow = False
                    End If
                End While

                If today > previousDay Then
                    newDay = True
                    saturdaysaved = False
                    sundaysaved = False
                    previousDay = today
                End If

            ElseIf fiveminticker >= 3 Then '3 seconds
                ReloadingOrddefLabel.Text = "Refresh in " + (20 - fiveminticker).ToString + " seconds" 'Time to next refresh.
            End If
        End If

        If newDay Then
            Try
                Dim saletotalcollection = MySQL.SelectDataDictionary("SELECT SUM(totalValue) as Total, TotalDate FROM whldata.newsales_dailysourcetotals WHERE totalDate='" + Now.AddDays(-7).ToString("yyyy-MM-dd") + "' OR totalDate='" + Now.AddDays(-14).ToString("yyyy-MM-dd") + "' OR totalDate='" + Now.AddDays(-21).ToString("yyyy-MM-dd") + "' OR totalDate='" + Now.AddDays(-28).ToString("yyyy-MM-dd") + "'  GROUP BY totalDate;")
                totalforavgsales = 0
                For Each selection In saletotalcollection
                    totalforavgsales += selection("Total")
                Next
                totalforavgsales = totalforavgsales / saletotalcollection.Count
                newDay = False
            Catch ex As Exception
            End Try
        End If

        If ClockTotal Then
            ClockTxt.Text = Now.ToString("HH:mm:ss")
        Else
            If Not newCalculator Is Nothing Then
                ClockTxt.Text = "End:" + Convert.ToInt32(newCalculator.expectedTotal).ToString
            Else
                ClockTxt.Text = Now.ToString("HH:mm:ss")
            End If
        End If

    End Sub

    Dim OrddefClient As iOSClientChannel = Nothing

    Private Sub RefreshOrddef()
        fiveminticker = 0 'Reset timer


        'Stream orddef
        If IsNothing(OrddefClient) orelse not OrddefClient.State = CommunicationState.Faulted Then
            OrddefClient = OrderServer.ConnectChannel("net.tcp://orderserver.ad.whitehinge.com:801/OrderServer/1")
        End If
        CurrentOrddef = OrddefClient.StreamOrderDefinition()


        'Other Stuff
        workersCalculator.NewTotal = CurrentOrddef.GetByStatus(OrderStatus._New).Count.ToString
        workersCalculator.PickTotal = CurrentOrddef.GetByStatus(OrderStatus._Picking).Count.ToString
        workersCalculator.PickedTotal = CurrentOrddef.GetByStatus(OrderStatus._Picked).Count.ToString
        workersCalculator.PackTotal = CurrentOrddef.GetByStatus(OrderStatus._Packing).Count.ToString
        workersCalculator.PackedTotal = CurrentOrddef.GetByStatus(OrderStatus._Packed).Count.ToString

        'Getting the completed posted amount
        Dim totalCount As Integer = CurrentOrddef.GetByStatus(OrderStatus._New).Count + CurrentOrddef.GetByStatus(OrderStatus._Picking).Count + CurrentOrddef.GetByStatus(OrderStatus._Picked).Count + CurrentOrddef.GetByStatus(OrderStatus._Packing).Count + CurrentOrddef.GetByStatus(OrderStatus._Packed).Count
        If totalCount > 0 Then
            Dim theCompletedCount As Single = CurrentOrddef.GetByStatus(OrderStatus._Packed).Count / totalCount
            workersCalculator.PostedTotal = FormatPercent(theCompletedCount, 1)
        Else
            workersCalculator.PostedTotal = "-"
        End If

        workersCalculator.PrepTotal = CurrentOrddef.GetByStatus(OrderStatus._Prepack).Count.ToString
        workersCalculator.IssueTotal = CurrentOrddef.GetByStatus(OrderStatus._Cantfind).Count.ToString
        workersCalculator.OverTotal = CurrentOrddef.GetByStatus(OrderStatus._Oversold).Count.ToString

        workersCalculator.Total = (CurrentOrddef.GetByStatus(OrderStatus._New).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Picking).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Picked).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Packing).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Packed).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Prepack).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Cantfind).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Oversold).Count).ToString

        LoadOrders.ReportProgress(1) 'Recalculate our totals.
    End Sub

    Dim workersCalculator As New CalculateEverything

    Private Sub StartFlashingIssues()
        Try
            Dim myStoryboard As System.Windows.Media.Animation.Storyboard = FindResource("IssuesLight")
            myStoryboard.Stop()
            myStoryboard.Begin()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub StartFlashingPrepack()
        Try
            Dim myStoryboard As System.Windows.Media.Animation.Storyboard = FindResource("PrepackLight")
            myStoryboard.Stop()
            myStoryboard.Begin()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub StopFlashingIssues()
        Try
            Dim myStoryboard As System.Windows.Media.Animation.Storyboard = FindResource("IssuesLight")
            myStoryboard.Stop()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub StopFlashingPrepack()
        Try
            Dim myStoryboard As System.Windows.Media.Animation.Storyboard = FindResource("PrepackLight")
            myStoryboard.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Dim workbusy As Boolean = False

    'STUFF TO WORK FROM
    Private Sub RecalcTotals()

        NewCount.Text = workersCalculator.NewTotal
        PickingCount.Text = workersCalculator.PickTotal
        PickedCount.Text = workersCalculator.PickedTotal
        PackingCount.Text = workersCalculator.PackTotal
        PackedCount.Text = workersCalculator.PackedTotal
        PostedCount.Text = workersCalculator.PostedTotal
        PrepackCount.Text = workersCalculator.PrepTotal
        IssueCount.Text = workersCalculator.IssueTotal
        OversoldCount.Text = workersCalculator.OverTotal
        totalsCount.Text = workersCalculator.Total

        If Convert.ToInt32(workersCalculator.PrepTotal) > 10 Then
            StartFlashingPrepack()
        Else
            StopFlashingPrepack()
        End If

        If Convert.ToInt32(workersCalculator.IssueTotal) > 0 Then
            StartFlashingIssues()
        Else
            StopFlashingIssues()
        End If

    End Sub

    Private Sub LoadOrders_DoWork(sender As Object, e As DoWorkEventArgs)
        If Now.Hour < 19 And Now.Hour >= 7 Then
            RefreshOrddef()
        End If
    End Sub

    Private Sub LoadOrders_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        If e.ProgressPercentage = 1 Then

            RecalcTotals()
        End If
    End Sub

    Public Class CalculateEverything
        Public NewTotal As String = ""
        Public PickTotal As String = ""
        Public PickedTotal As String = ""
        Public PackTotal As String = ""
        Public PackedTotal As String = ""
        Public PostedTotal As String = ""
        Public PrepTotal As String = ""
        Public IssueTotal As String = ""
        Public OverTotal As String = ""
        Public Total As String = ""

    End Class

    Private Sub SetActual()
        PickingActual.Text = (Convert.ToInt32(PickedCount.Text) + Convert.ToInt32(PackingCount.Text) + Convert.ToInt32(PackedCount.Text)).ToString
        PackingActual.Text = PackedCount.Text.ToString
    End Sub
End Class
