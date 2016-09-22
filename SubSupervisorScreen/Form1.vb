Imports System.ComponentModel
Imports WHLClasses
Imports WHLClasses.Linnworks.Orders
Imports WHLClasses.NetCom
Imports WHLClasses.Orders

Public Class Form1
    Dim Loader As New GenericDataController
    Dim CurrentOrddef As OrderDefinition
    Dim fiveminticker As Integer = 0
    'Dim bw As BackgroundWorker = New BackgroundWorker  'Dead worker. Currently occupying a large section of comment hell.

    Private Sub LoadTheProgram() Handles Me.Load
        'Worker stuff
        'bw.WorkerSupportsCancellation = True
        'bw.WorkerReportsProgress = True
        'AddHandler bw.DoWork, AddressOf bw_DoWork      'Dead worker's work address. We don't deliver here anymore.

        fiveminticker = 16
        RefreshTimer.Enabled = True

        TodaysProgress.Minimum = 0
        TodaysProgress.Value = 0
        TodaysProgress.Maximum = 100
    End Sub

    Dim newDay As Boolean = False
    Dim targetTotal As Integer = 0
    Dim totalforavgsales As Integer = 0

    'THIS STUFF WORKS. That's the only reason it's used. A worker would be nice but it decided it was going on a permanent holiday to comment hell. RIP.
    Private Sub TickTime() Handles RefreshTimer.Tick
        If Not workbusy Then

            fiveminticker += 1 'Increment timer.

            If fiveminticker >= 20 Then '10 seconds
                Try
                    If My.Application.Deployment.CheckForUpdate Then
                        My.Application.Deployment.Update()
                        Application.Restart()
                    End If
                Catch ex As Deployment.Application.InvalidDeploymentException

                End Try
                ReloadingOrddefLabel.Text = "Refreshing order data"
                LoadOrders.RunWorkerAsync()
                If Not SevenDaysAgoTitleLbl.Text.Replace("Orders Last ", "") = Today.DayOfWeek.ToString Then
                    SevenDaysAgoTitleLbl.Text = "Orders Last " + Today.DayOfWeek.ToString 'Why do people leave this on overnight? Now we gotta refresh it every day.
                    newDay = True
                    empcollection = New EmployeeCollection() 'Lets make sure we add new people to our employee list! :D
                    GetAllEmployeeStats() 'Let's refresh this too, I mean, this has to be dynamic.
                End If

            ElseIf fiveminticker >= 3 Then '3 seconds
                ReloadingOrddefLabel.Text = "Refresh in " + (20 - fiveminticker).ToString + " seconds" 'Time to next refresh.
            End If
        End If

        If newDay Then
            Try
                Dim saletotalcollection As ArrayList = MySql.SelectData("SELECT subsourceText, totalDate, totalValue, TLSource FROM whldata.newsales_dailysourcetotals;")
                Dim totalESalesLastWeek As Integer = 0
                Dim totalASalesLastWeek As Integer = 0
                Dim totalWSalesLastWeek As Integer = 0
                totalforavgsales = 0
                For Each selection In saletotalcollection
                    If selection(1) = Today.AddDays(-7).ToString("yyyy-MM-dd") Then 'Get the day
                        If selection(3) = "EBAY" Then
                            totalESalesLastWeek += selection(2)
                        ElseIf selection(3) = "AMAZON" Then
                            totalASalesLastWeek += selection(2)
                        ElseIf selection(3) = "MAGENTO" Then
                            totalWSalesLastWeek += selection(2)
                        ElseIf selection(0) = "" And selection(3) = "DIRECT" Then
                            totalWSalesLastWeek += selection(2)
                        End If
                        totalforavgsales += selection(2)
                    ElseIf selection(1) = Today.AddDays(-14).ToString("yyyy-MM-dd") Then 'Get the day
                        totalforavgsales += selection(2)
                    ElseIf selection(1) = Today.AddDays(-21).ToString("yyyy-MM-dd") Then 'Get the day
                        totalforavgsales += selection(2)
                    ElseIf selection(1) = Today.AddDays(-28).ToString("yyyy-MM-dd") Then 'Get the day
                        totalforavgsales += selection(2)
                    End If
                Next
                SevenDaysAgoEbayLbl.Text = totalESalesLastWeek.ToString
                SevenDaysAgoAmazonLbl.Text = totalASalesLastWeek.ToString
                SevenDaysAgoWebsiteLbl.Text = totalWSalesLastWeek.ToString
                newDay = False
                targetTotal = totalESalesLastWeek + totalASalesLastWeek + totalWSalesLastWeek
                TodaysProgress.Minimum = 0
                TodaysProgress.Value = 0
                TodaysProgress.Maximum = targetTotal
            Catch ex As Exception
            End Try
        End If

        ClockTxt.Text = Now.ToString("HH:mm:ss")

    End Sub

    Private Sub RefreshOrddef()
        'UGH, SCREW BACKGROUNDWORKER THINGS, I'm done. While loop.

        fiveminticker = 0 'Reset timer
        'RefreshTimer.Enabled = False 'Turn timer off during refresh attempts...

        Dim refresh As Boolean = False 'Set the while dependancy
        Dim elipsesString As String = "" 'During while
        'ReloadingOrddefLabel.Text = "Reloading Orders" 'Show that we're actively refreshing.

        While Not refresh
            Application.DoEvents()
            Try
                '... Actually, I'm not sure how an Application.DoEvents would affect a while loop. Would it try to loop insanely?
                Threading.Thread.Sleep(2000) 'Sleep before checking.
                CurrentOrddef = Loader.LoadOrddef("T:\AppData\Orders\.orddef") 'Load the file! Please. Why won't you load?
                refresh = True 'Success? Exit while loop.
            Catch ex As Exception
                elipsesString += "." 'Add a dot to our actively changing elipses - show the program hasn't frozen
                If elipsesString.Length > 3 Then
                    elipsesString = "" 'If we have 4 dots or more, kill it.
                End If
                'ReloadingOrddefLabel.Text = "Reloading Orders" + elipsesString 'Add dots to string.
            End Try
        End While

        'ReloadingOrddefLabel.Text = "Reload Complete" 'Display that we've exited the loop.
        LoadOrders.ReportProgress(1) 'Recalculate our totals.

        'RefreshTimer.Enabled = True 'Turn refresh timer back on. The time amount was reset earlier.
    End Sub

    Dim workbusy As Boolean = False

    'STUFF TO WORK FROM
    Private Sub RecalcTotals()

        NewCount.Text = CurrentOrddef.GetByStatus(OrderStatus._New).Count.ToString
        PickingCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Picking).Count.ToString
        PickedCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Picked).Count.ToString
        PackingCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Packing).Count.ToString
        PackedCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Packed).Count.ToString

        'Getting the completed posted amount
        Dim totalCount As Integer = CurrentOrddef.GetByStatus(OrderStatus._New).Count + CurrentOrddef.GetByStatus(OrderStatus._Picking).Count + CurrentOrddef.GetByStatus(OrderStatus._Picked).Count + CurrentOrddef.GetByStatus(OrderStatus._Packing).Count + CurrentOrddef.GetByStatus(OrderStatus._Packed).Count
        If totalCount > 0 Then
            Dim theCompletedCount As Single = CurrentOrddef.GetByStatus(OrderStatus._Packed).Count / totalCount
            PostedCount.Text = FormatPercent(theCompletedCount, 1)
        Else PostedCount.Text = "-"
        End If

        PrepackCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Prepack).Count.ToString
        NotFoundCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Cantfind).Count.ToString
        MissingItemCount.Text = CurrentOrddef.GetByStatus(OrderStatus._Oversold).Count.ToString

        totalsCount.Text = (CurrentOrddef.GetByStatus(OrderStatus._New).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Picking).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Picked).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Packing).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Packed).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Prepack).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Cantfind).Count) + (CurrentOrddef.GetByStatus(OrderStatus._Oversold).Count).ToString
        If PackedCount.Text = "0" Or totalsCount.Text = "-" Then
            TodaysProgress.Value = TodaysProgress.Maximum
            TodaysProgress.ForeColor = Color.Blue
        ElseIf TodaysProgress.Maximum > totalsCount.Text Then
            TodaysProgress.Value = PackedCount.Text
            If (targetTotal / 5) > PackedCount.Text Then
                TodaysProgress.ForeColor = Color.Red
            ElseIf ((targetTotal / 5) * 3) < PackedCount.Text Then
                TodaysProgress.ForeColor = Color.Green
            Else
                TodaysProgress.ForeColor = Color.Yellow
            End If
        Else
            TodaysProgress.Value = TodaysProgress.Maximum
            TodaysProgress.ForeColor = Color.Green
        End If

        If totalsCount.Text < totalforavgsales / 4 Then
            AvgDownPanel.Visible = True
            AvgUpPanel.Visible = False
            CompareToAvgLbl.Text = "Lower than average"
        ElseIf totalsCount.Text > totalforavgsales / 4 Then
            AvgDownPanel.Visible = False
            AvgUpPanel.Visible = True
            CompareToAvgLbl.Text = "Higher than average"
        Else
            AvgDownPanel.Visible = False
            AvgUpPanel.Visible = False
            CompareToAvgLbl.Text = "Average"

        End If

        'Traffic lights
        CheckCurrentAverageSpeed()

        'Loop through and set 0s to hyphens
        For Each control As Object In Me.Controls
            Try
                Dim tb As Label = control
                If tb.Text = "0" Then
                    tb.Text = "-"
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private LookForVersionUpdate As Boolean = False
    Private UpdateCount As Integer = 0

    Private Sub PopulateMinitables(label1 As Label, label2 As Label, label3 As Label, label4 As Label, label5 As Label, label6 As Label, label7 As Label, label8 As Label, label9 As Label, totallabel As Label, pick As ItemPicklistType, SinglesBool As Boolean, Optional BoxedBool As Boolean = False)

        If SinglesBool Then
            'So is it boxed or not?
            If BoxedBool Then
                'Boxed
                label1.Text = OrderDefCalculationBoxed(OrderStatus._New, pick, False)
                label2.Text = OrderDefCalculationBoxed(OrderStatus._Picking, pick, False)
                label3.Text = OrderDefCalculationBoxed(OrderStatus._Picked, pick, False)
                label4.Text = OrderDefCalculationBoxed(OrderStatus._Packing, pick, False)
                label5.Text = OrderDefCalculationBoxed(OrderStatus._Packed, pick, False)
                label6.Text = OrderDefCalculationBoxed(OrderStatus._Packed, pick, True)
                label7.Text = OrderDefCalculationBoxed(OrderStatus._Prepack, pick, False)
                label8.Text = OrderDefCalculationBoxed(OrderStatus._Cantfind, pick, False)
                label9.Text = OrderDefCalculationBoxed(OrderStatus._Oversold, pick, False)
                totallabel.Text = OrderDefCalculationTotalBoxed(pick)
            Else
                'Single
                label1.Text = OrderDefCalculationSingle(OrderStatus._New, pick, False)
                label2.Text = OrderDefCalculationSingle(OrderStatus._Picking, pick, False)
                label3.Text = OrderDefCalculationSingle(OrderStatus._Picked, pick, False)
                label4.Text = OrderDefCalculationSingle(OrderStatus._Packing, pick, False)
                label5.Text = OrderDefCalculationSingle(OrderStatus._Packed, pick, False)
                label6.Text = OrderDefCalculationSingle(OrderStatus._Packed, pick, True)
                label7.Text = OrderDefCalculationSingle(OrderStatus._Prepack, pick, False)
                label8.Text = OrderDefCalculationSingle(OrderStatus._Cantfind, pick, False)
                label9.Text = OrderDefCalculationSingle(OrderStatus._Oversold, pick, False)
                totallabel.Text = OrderDefCalculationTotal(pick)
            End If
        Else
            'Multi
            label1.Text = OrderDefCalculationMulti(OrderStatus._New, pick, False)
            label2.Text = OrderDefCalculationMulti(OrderStatus._Picking, pick, False)
            label3.Text = OrderDefCalculationMulti(OrderStatus._Picked, pick, False)
            label4.Text = OrderDefCalculationMulti(OrderStatus._Packing, pick, False)
            label5.Text = OrderDefCalculationMulti(OrderStatus._Packed, pick, False)
            label6.Text = OrderDefCalculationMulti(OrderStatus._Packed, pick, True)
            label7.Text = OrderDefCalculationMulti(OrderStatus._Prepack, pick, False)
            label8.Text = OrderDefCalculationMulti(OrderStatus._Cantfind, pick, False)
            label9.Text = OrderDefCalculationMulti(OrderStatus._Oversold, pick, False)
            totallabel.Text = OrderDefCalculationTotalMulti(pick)
        End If
    End Sub

    Private Function OrderDefCalculationTotal(Pick As ItemPicklistType)
        Return (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._New).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picking).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picked).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packing).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packed).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Prepack).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Cantfind).GetBoxedOrders(False).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._MissingItem).GetBoxedOrders(False).Count).ToString
    End Function
    Private Function OrderDefCalculationTotalBoxed(Pick As ItemPicklistType)
        Return (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._New).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picking).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picked).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packing).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packed).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Prepack).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Cantfind).GetBoxedOrders(True).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._MissingItem).GetBoxedOrders(True).Count).ToString
    End Function
    Private Function OrderDefCalculationTotalMulti(Pick As ItemPicklistType)
        Return (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._New).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picking).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picked).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packing).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packed).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Prepack).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Cantfind).Count) + (CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._MissingItem).Count).ToString
    End Function

    Private Function OrderDefCalculationMulti(Ord1 As OrderStatus, Pick As ItemPicklistType, Div As Boolean)
        If Div Then
            Dim CollectedInt As Integer = CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._New).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picking).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picked).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packing).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packed).Count
            'Check for 0
            If CollectedInt > 0 Then
                Dim DividedInt As Single = CurrentOrddef.GetByStatus(OrderStatus._Packed).GetByPickType(Pick).Count / CollectedInt
                Return FormatPercent(DividedInt, 1).ToString
            End If
            Return "0"
        Else
            Return CurrentOrddef.GetByPickType(Pick).GetByStatus(Ord1).Count.ToString
        End If
    End Function

    Private Function OrderDefCalculationBoxed(Ord1 As OrderStatus, Pick As ItemPicklistType, Div As Boolean)
        If Div Then
            Dim CollectedInt As Integer = CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._New).GetBoxedOrders(True).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picking).GetBoxedOrders(True).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picked).GetBoxedOrders(True).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packing).GetBoxedOrders(True).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packed).GetBoxedOrders(True).Count
            'Check for 0
            If CollectedInt > 0 Then
                Dim DividedInt As Single = CurrentOrddef.GetByStatus(OrderStatus._Packed).GetByPickType(Pick).GetBoxedOrders(True).Count / CollectedInt
                Return FormatPercent(DividedInt, 1).ToString
            End If
            Return "0"
        Else
            Return CurrentOrddef.GetByPickType(Pick).GetByStatus(Ord1).GetBoxedOrders(True).Count.ToString
        End If
    End Function

    Private Function OrderDefCalculationSingle(Ord1 As OrderStatus, Pick As ItemPicklistType, Div As Boolean)
        If Div Then
            Dim CollectedInt As Integer = CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._New).GetBoxedOrders(False).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picking).GetBoxedOrders(False).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Picked).GetBoxedOrders(False).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packing).GetBoxedOrders(False).Count + CurrentOrddef.GetByPickType(Pick).GetByStatus(OrderStatus._Packed).GetBoxedOrders(False).Count
            'Check for 0
            If CollectedInt > 0 Then
                Dim DividedInt As Single = CurrentOrddef.GetByStatus(OrderStatus._Packed).GetByPickType(Pick).GetBoxedOrders(False).Count / CollectedInt
                Return FormatPercent(DividedInt, 1).ToString
            End If
            Return "0"
        Else
            Return CurrentOrddef.GetByPickType(Pick).GetByStatus(Ord1).GetBoxedOrders(False).Count.ToString
        End If
    End Function

    Private Sub LoadOrders_DoWork(sender As Object, e As DoWorkEventArgs) Handles LoadOrders.DoWork
        If Not workbusy Then
            workbusy = True
            RefreshOrddef()
            workbusy = False
        End If

    End Sub

    Private Sub LoadOrders_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles LoadOrders.ProgressChanged
        If e.ProgressPercentage = 1 Then

            RecalcTotals()
        End If
    End Sub

    'THANK GOD THIS ONLY RUNS ONCE A DAY
    Dim empcollection As EmployeeCollection
    Private Sub GetAllEmployeeStats()
        Dim statslist1Wk As New List(Of EmpStats)
        Dim emps1Wk As Integer = 0
        Dim statslist2Wk As New List(Of EmpStats)
        Dim emps2Wk As Integer = 0
        Dim statslist3Wk As New List(Of EmpStats)
        Dim emps3Wk As Integer = 0
        Dim statslist4Wk As New List(Of EmpStats)
        Dim emps4Wk As Integer = 0
        For Each emp As Employee In empcollection.Employees
            Dim templist1Wk As EmpStats = LoadAnalyticsFile(emp.PayrollId, Today.AddDays(-7), Today.AddDays(-6))
            If Not templist1Wk Is Nothing Then
                statslist1Wk.Add(templist1Wk)
                emps1Wk += 1
            End If
            Dim templist2Wk As EmpStats = LoadAnalyticsFile(emp.PayrollId, Today.AddDays(-14), Today.AddDays(-13))
            If Not templist2Wk Is Nothing Then
                statslist2Wk.Add(templist2Wk)
                emps2Wk += 1
            End If
            Dim templist3Wk As EmpStats = LoadAnalyticsFile(emp.PayrollId, Today.AddDays(-21), Today.AddDays(-20))
            If Not templist3Wk Is Nothing Then
                statslist3Wk.Add(templist3Wk)
                emps3Wk += 1
            End If
            Dim templist4Wk As EmpStats = LoadAnalyticsFile(emp.PayrollId, Today.AddDays(-28), Today.AddDays(-27))
            If Not templist4Wk Is Nothing Then
                statslist4Wk.Add(templist4Wk)
                emps4Wk += 1
            End If
        Next

        'So now we have 4 days of packing data, one from the past 4 weeks.
        'For each week, we need to get the total time spent and orders complete.
        'We need to divide each of those by the amount of employees that were involved in packing that day.
        'This is how we get each day's proper order / time spent ratio.
        'Then, when we have that info, add the four days together and divide by 4 to get a proper average.

        Dim Wk1Time As New TimeSpan
        Dim Wk2Time As New TimeSpan
        Dim Wk3Time As New TimeSpan
        Dim Wk4Time As New TimeSpan
        Dim Wk1Orders As Integer = 0
        Dim Wk2Orders As Integer = 0
        Dim Wk3Orders As Integer = 0
        Dim Wk4Orders As Integer = 0

        'WEEK; THE FIRST
        If Not statslist1Wk.Count = 0 Then
            For Each statlist In statslist1Wk 'Each employee
                For Each sessionlist As List(Of WarehouseAnalytics.SessionAnalytic) In statlist.allSessions.Values 'Each employee's list of sessions
                    For Each session In sessionlist 'Each session individually- oh my gosh, 3 for loops. I gotta do this 3 more times too.
                        Wk1Time = TimeSpan.FromSeconds(Wk1Time.TotalSeconds + session.TimeSpan.TotalSeconds)
                        Wk1Orders += session.OrderCount
                    Next
                Next
            Next

            Wk1Time = TimeSpan.FromSeconds(Wk1Time.TotalSeconds / emps1Wk)
            Wk1Orders = Wk1Orders / emps1Wk
        End If

        'WEEK; THE SECN0D
        If Not statslist2Wk.Count = 0 Then
            For Each statlist In statslist2Wk 'Each employee
                For Each sessionlist As List(Of WarehouseAnalytics.SessionAnalytic) In statlist.allSessions.Values 'Each employee's list of sessions
                    For Each session In sessionlist 'Each session individually
                        Wk2Time = TimeSpan.FromSeconds(Wk2Time.TotalSeconds + session.TimeSpan.TotalSeconds)
                        Wk2Orders += session.OrderCount
                    Next
                Next
            Next

            Wk2Time = TimeSpan.FromSeconds(Wk2Time.TotalSeconds / emps2Wk)
            Wk2Orders = Wk2Orders / emps2Wk
        End If

        'WEEK; THE ThRD1
        If Not statslist3Wk.Count = 0 Then
            For Each statlist In statslist3Wk 'Each employee
                For Each sessionlist As List(Of WarehouseAnalytics.SessionAnalytic) In statlist.allSessions.Values 'Each employee's list of sessions
                    For Each session In sessionlist 'Each session individually
                        Wk3Time = TimeSpan.FromSeconds(Wk3Time.TotalSeconds + session.TimeSpan.TotalSeconds)
                        Wk3Orders += session.OrderCount
                    Next
                Next
            Next

            Wk3Time = TimeSpan.FromSeconds(Wk3Time.TotalSeconds / emps3Wk)
            Wk3Orders = Wk3Orders / emps3Wk
        End If

        'WEEK; THE FOUUUWWWWWWWWW-
        If Not statslist4Wk.Count = 0 Then
            For Each statlist In statslist4Wk 'Each employee
                For Each sessionlist As List(Of WarehouseAnalytics.SessionAnalytic) In statlist.allSessions.Values 'Each employee's list of sessions
                    For Each session In sessionlist 'Each session individually
                        Wk4Time = TimeSpan.FromSeconds(Wk4Time.TotalSeconds + session.TimeSpan.TotalSeconds)
                        Wk4Orders += session.OrderCount
                    Next
                Next
            Next

            Wk4Time = TimeSpan.FromSeconds(Wk4Time.TotalSeconds / emps4Wk)
            Wk4Orders = Wk4Orders / emps4Wk
        End If

        Dim masterTimespan As TimeSpan = TimeSpan.FromSeconds((Wk1Time.TotalSeconds + Wk2Time.TotalSeconds + Wk3Time.TotalSeconds + Wk4Time.TotalSeconds) / 4)
        Dim masterOrders As Integer = (Wk1Orders + Wk2Orders + Wk3Orders + Wk4Orders) / 4

        'AND THE RESULT IS...
        masterAverage = masterOrders / masterTimespan.TotalSeconds

    End Sub
    Dim masterAverage As Double = 0 'Absolutely necessary

    Private Sub CheckCurrentAverageSpeed()
        'We need to check that it's worth checking.
        If totalsCount.Text = 0 Or totalsCount.Text = "-" Then
            GreenLightPanel.Visible = True 'Sure. We have nothing to do. Nobody needs to pack anything
            OrangeLightPanel.Visible = False
            RedLightPanel.Visible = False
        ElseIf PostedCount.Text = "100.0%" Then
            GreenLightPanel.Visible = True 'Nobody needs to pack anything if we're done.
            OrangeLightPanel.Visible = False
            RedLightPanel.Visible = False
        ElseIf PackedCount.Text = "0" Or PackedCount.Text = "-" Then
            GreenLightPanel.Visible = False
            OrangeLightPanel.Visible = False
            RedLightPanel.Visible = True
        Else

            Dim eightamToday As DateTime = Today.Date
            eightamToday = eightamToday.AddHours(8)
            Dim todaysTimespan As TimeSpan = Now - eightamToday
            Dim currentAverage As Double = PackedCount.Text / todaysTimespan.TotalSeconds

            'Now here's where lights go on
            If currentAverage > (masterAverage * 1.3) Then 'bigger than the average + 1 third
                GreenLightPanel.Visible = True
                OrangeLightPanel.Visible = False
                RedLightPanel.Visible = False
            ElseIf currentAverage < ((masterAverage / 3) * 2) Then 'smaller than the average - 1 third
                GreenLightPanel.Visible = False
                OrangeLightPanel.Visible = False
                RedLightPanel.Visible = True
            Else 'Between 1 third above and 1 third below average
                GreenLightPanel.Visible = False
                OrangeLightPanel.Visible = True
                RedLightPanel.Visible = False
            End If
        End If

        'If GreenLightPanel.Visible = True Then
        'GreenLightPanel.BackgroundImage = Image.FromFile("..\Resources\GreenLightIcon.png")
        'Else

        'End If
    End Sub


    Private Function LoadAnalyticsFile(empID As Integer, FirstDate As DateTime, SecondDate As DateTime) As EmpStats
        'Dim theAnalytic As WarehouseAnalytics.DailyAnalytic = Loader.LoadAnything

        Try
            If IsNumeric(empID) Then
                If My.Computer.FileSystem.FileExists("T:\AppData\Analytics\" + empID.ToString + ".anal") Then
                    Dim analyticsfile As WHLClasses.WarehouseAnalytics.AnalyticBase = Loader.LoadAnything("T:\AppData\Analytics\" + empID.ToString + ".anal", False).Value
                    Dim date1str As String = FirstDate.ToString("yyyy/MM/dd")
                    Dim date2str As String = SecondDate.ToString("yyyy/MM/dd")
                    Dim Date1 As Date = date1str
                    Dim Date2 As Date = date2str
                    Dim workCounted As Boolean = False
                    Dim allSessions As New Dictionary(Of Date, List(Of WarehouseAnalytics.SessionAnalytic))
                    Dim dayCount As Integer = 0
                    While Date1 < Date2
                        Dim sessionDone As Integer
                        'Dim timeToPass As TimeSpan = TimeSpan.FromMinutes(1)
                        Try
                            Dim sessionList As New List(Of WarehouseAnalytics.SessionAnalytic)
                            For Each session As WarehouseAnalytics.SessionAnalytic In analyticsfile.Data(Date1).Sessions
                                sessionDone = session.OrderCount
                                If sessionDone > 2 And session.SessionType = WarehouseAnalytics.SessionType.Packing Then
                                    sessionList.Add(session)
                                    workCounted = True
                                End If
                            Next
                            allSessions.Add(Date1, sessionList)
                            dayCount += 1
                        Catch ex As System.Collections.Generic.KeyNotFoundException
                            'This is fine, don't let this get caught by the OTHER try, it'll override the result.
                        End Try
                        Date1 = Date1.AddDays(1)
                    End While

                    If workCounted Then
                        Dim employeeStats As New EmpStats(empID, allSessions)
                        Return employeeStats
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    Public Class EmpStats
        Public EmpID As String
        Public allSessions As New Dictionary(Of Date, List(Of WarehouseAnalytics.SessionAnalytic))

        Public Sub New(ID As String, sessions As Dictionary(Of Date, List(Of WarehouseAnalytics.SessionAnalytic)))
            EmpID = ID
            allSessions = sessions
        End Sub
        Public Sub New() 'And I guess a way to make new empty ones.

        End Sub
    End Class

    'Private Sub UpdatedTxt_Click(sender As Object, e As EventArgs) Handles UpdatedTxt.Click
    '    UpdateCount = 0
    '    UpdatedTxt.Visible = False
    'End Sub




    'Comment hell - A special place reserved for non-compliant workers and their affiliated work. They will spend eternity doing sweet fuck all. Just like they wanted.


    'Dim WorkerWorkPlease As Boolean
    'Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
    '    Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

    '    If WorkerWorkPlease Then
    '        bw.ReportProgress(0)
    '        RefreshOrddef() 'Refresh
    '    End If
    'End Sub

    'Private Sub TickTime() Handles RefreshTimer.Tick
    '    fiveminticker += 1 'Increment timer.

    '    If fiveminticker >= 300 Then '5 mins
    '        fiveminticker = 0 'Reset timer
    '        RefreshTimer.Enabled = False 'Turn timer off during refresh attempts...
    '        ReloadingOrddefLabel.Text = "Reloading Orders" 'Show that we're actively refreshing.
    '        WorkerWorkPlease = True

    '        If Not bw.IsBusy = True Then
    '            bw.RunWorkerAsync()
    '            bw_DoWork(Nothing, Nothing)
    '        End If
    '    ElseIf fiveminticker >= 10 Then '10 seconds
    '        ReloadingOrddefLabel.Text = (300 - fiveminticker).ToString 'Time to next refresh.
    '    End If
    'End Sub

    'Dim elipsesString As String = ""    'During worker ... work :l Yep. Worker work. Thanks brain, you're a genie ass.
    'Private Sub RefreshOrddef()

    '    Application.DoEvents()
    '    Try
    '        '... Actually, I'm not sure how an Application.DoEvents would affect a while loop. Would it try to loop insanely?
    '        Threading.Thread.Sleep(2000) 'Sleep before checking.
    '        CurrentOrddef = Loader.LoadOrddef("T:\AppData\Orders\.orddef") 'Load the file! Please. Why won't you load?
    '        elipsesString = ""
    '    Catch ex As Exception
    '        elipsesString += "." 'Add a dot to our actively changing elipses - show the program hasn't frozen
    '        If elipsesString.Length > 3 Then
    '            elipsesString = "." 'If we have 4 dots or more, set to 1.
    '        End If
    '    End Try

    '    If elipsesString.Length > 0 Then
    '        bw.ReportProgress(elipsesString.Length) 'Number is actually pretty pointless. It's ONE function.
    '    Else
    '        bw.ReportProgress(100) 'If elipsesString is empty, we finished.
    '        RefreshTimer.Enabled = True 'Turn refresh timer back on. The time amount was reset earlier.
    '        WorkerWorkPlease = False
    '    End If
    'End Sub

    'Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
    '    If e.ProgressPercentage = 100 Then
    '        ReloadingOrddefLabel.Text = "Reload Complete" 'Display that we've exited the loop.
    '        RecalcTotals() 'Recalculate our totals.
    '    Else
    '        ReloadingOrddefLabel.Text = "Reloading Orders" + elipsesString 'Add dots to string.
    '    End If
    'End Sub

End Class
