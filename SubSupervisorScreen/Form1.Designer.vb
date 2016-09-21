<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ClockTxt = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.NewCount = New System.Windows.Forms.Label()
        Me.PickingCount = New System.Windows.Forms.Label()
        Me.PickedCount = New System.Windows.Forms.Label()
        Me.PackingCount = New System.Windows.Forms.Label()
        Me.PackedCount = New System.Windows.Forms.Label()
        Me.PostedCount = New System.Windows.Forms.Label()
        Me.PrepackCount = New System.Windows.Forms.Label()
        Me.NotFoundCount = New System.Windows.Forms.Label()
        Me.MissingItemCount = New System.Windows.Forms.Label()
        Me.totalsCount = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ReloadingOrddefLabel = New System.Windows.Forms.Label()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LoadOrders = New System.ComponentModel.BackgroundWorker()
        Me.SevenDaysAgoTitleLbl = New System.Windows.Forms.Label()
        Me.SevenDaysAgoEbayLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SevenDaysAgoAmazonLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SevenDaysAgoWebsiteLbl = New System.Windows.Forms.Label()
        Me.TodaysProgress = New System.Windows.Forms.ProgressBar()
        Me.AvgUpPanel = New System.Windows.Forms.Panel()
        Me.AvgDownPanel = New System.Windows.Forms.Panel()
        Me.CoolButton1 = New WHLClasses.Controls.CoolButton()
        Me.CoolButton2 = New WHLClasses.Controls.CoolButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AvgUpPanel.SuspendLayout()
        Me.AvgDownPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClockTxt
        '
        Me.ClockTxt.AutoSize = True
        Me.ClockTxt.Font = New System.Drawing.Font("Segoe UI", 100.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClockTxt.Location = New System.Drawing.Point(672, 123)
        Me.ClockTxt.Name = "ClockTxt"
        Me.ClockTxt.Size = New System.Drawing.Size(565, 177)
        Me.ClockTxt.TabIndex = 0
        Me.ClockTxt.Text = "00:00:00"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(554, 317)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(254, 60)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Picking"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(814, 317)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(254, 60)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Picked"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(1074, 317)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(254, 60)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Packing"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(1334, 317)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(254, 60)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Packed"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(1074, 509)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(254, 60)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Posted"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(814, 509)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(254, 60)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Oversold"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(554, 509)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(254, 60)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Issues"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(294, 509)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(254, 60)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Prepack"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewCount
        '
        Me.NewCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewCount.Location = New System.Drawing.Point(294, 377)
        Me.NewCount.Name = "NewCount"
        Me.NewCount.Size = New System.Drawing.Size(254, 81)
        Me.NewCount.TabIndex = 31
        Me.NewCount.Text = "-"
        Me.NewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PickingCount
        '
        Me.PickingCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PickingCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickingCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PickingCount.Location = New System.Drawing.Point(554, 377)
        Me.PickingCount.Name = "PickingCount"
        Me.PickingCount.Size = New System.Drawing.Size(254, 81)
        Me.PickingCount.TabIndex = 32
        Me.PickingCount.Text = "-"
        Me.PickingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PickedCount
        '
        Me.PickedCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PickedCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickedCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PickedCount.Location = New System.Drawing.Point(814, 377)
        Me.PickedCount.Name = "PickedCount"
        Me.PickedCount.Size = New System.Drawing.Size(254, 81)
        Me.PickedCount.TabIndex = 33
        Me.PickedCount.Text = "-"
        Me.PickedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PackingCount
        '
        Me.PackingCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PackingCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackingCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PackingCount.Location = New System.Drawing.Point(1074, 377)
        Me.PackingCount.Name = "PackingCount"
        Me.PackingCount.Size = New System.Drawing.Size(254, 81)
        Me.PackingCount.TabIndex = 34
        Me.PackingCount.Text = "-"
        Me.PackingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PackedCount
        '
        Me.PackedCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PackedCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackedCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PackedCount.Location = New System.Drawing.Point(1334, 377)
        Me.PackedCount.Name = "PackedCount"
        Me.PackedCount.Size = New System.Drawing.Size(254, 81)
        Me.PackedCount.TabIndex = 35
        Me.PackedCount.Text = "-"
        Me.PackedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PostedCount
        '
        Me.PostedCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PostedCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostedCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PostedCount.Location = New System.Drawing.Point(1074, 569)
        Me.PostedCount.Name = "PostedCount"
        Me.PostedCount.Size = New System.Drawing.Size(254, 81)
        Me.PostedCount.TabIndex = 36
        Me.PostedCount.Text = "-"
        Me.PostedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrepackCount
        '
        Me.PrepackCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrepackCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrepackCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrepackCount.Location = New System.Drawing.Point(294, 569)
        Me.PrepackCount.Name = "PrepackCount"
        Me.PrepackCount.Size = New System.Drawing.Size(254, 81)
        Me.PrepackCount.TabIndex = 37
        Me.PrepackCount.Text = "-"
        Me.PrepackCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotFoundCount
        '
        Me.NotFoundCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NotFoundCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotFoundCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NotFoundCount.Location = New System.Drawing.Point(554, 569)
        Me.NotFoundCount.Name = "NotFoundCount"
        Me.NotFoundCount.Size = New System.Drawing.Size(254, 81)
        Me.NotFoundCount.TabIndex = 38
        Me.NotFoundCount.Text = "-"
        Me.NotFoundCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MissingItemCount
        '
        Me.MissingItemCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MissingItemCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissingItemCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MissingItemCount.Location = New System.Drawing.Point(814, 569)
        Me.MissingItemCount.Name = "MissingItemCount"
        Me.MissingItemCount.Size = New System.Drawing.Size(254, 81)
        Me.MissingItemCount.TabIndex = 39
        Me.MissingItemCount.Text = "-"
        Me.MissingItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalsCount
        '
        Me.totalsCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totalsCount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalsCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalsCount.Location = New System.Drawing.Point(1334, 569)
        Me.totalsCount.Name = "totalsCount"
        Me.totalsCount.Size = New System.Drawing.Size(254, 81)
        Me.totalsCount.TabIndex = 41
        Me.totalsCount.Text = "-"
        Me.totalsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Location = New System.Drawing.Point(1334, 509)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(254, 60)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Total"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReloadingOrddefLabel
        '
        Me.ReloadingOrddefLabel.AutoSize = True
        Me.ReloadingOrddefLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReloadingOrddefLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReloadingOrddefLabel.Location = New System.Drawing.Point(12, 9)
        Me.ReloadingOrddefLabel.Name = "ReloadingOrddefLabel"
        Me.ReloadingOrddefLabel.Size = New System.Drawing.Size(47, 65)
        Me.ReloadingOrddefLabel.TabIndex = 43
        Me.ReloadingOrddefLabel.Text = "-"
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 1000
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(294, 317)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(254, 60)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "New"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadOrders
        '
        Me.LoadOrders.WorkerReportsProgress = True
        '
        'SevenDaysAgoTitleLbl
        '
        Me.SevenDaysAgoTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SevenDaysAgoTitleLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SevenDaysAgoTitleLbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenDaysAgoTitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SevenDaysAgoTitleLbl.Location = New System.Drawing.Point(760, 662)
        Me.SevenDaysAgoTitleLbl.Name = "SevenDaysAgoTitleLbl"
        Me.SevenDaysAgoTitleLbl.Size = New System.Drawing.Size(360, 60)
        Me.SevenDaysAgoTitleLbl.TabIndex = 44
        Me.SevenDaysAgoTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SevenDaysAgoEbayLbl
        '
        Me.SevenDaysAgoEbayLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SevenDaysAgoEbayLbl.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenDaysAgoEbayLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SevenDaysAgoEbayLbl.Location = New System.Drawing.Point(579, 794)
        Me.SevenDaysAgoEbayLbl.Name = "SevenDaysAgoEbayLbl"
        Me.SevenDaysAgoEbayLbl.Size = New System.Drawing.Size(237, 81)
        Me.SevenDaysAgoEbayLbl.TabIndex = 45
        Me.SevenDaysAgoEbayLbl.Text = "-"
        Me.SevenDaysAgoEbayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(579, 734)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 60)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "EBAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(822, 734)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 60)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "AMAZON"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SevenDaysAgoAmazonLbl
        '
        Me.SevenDaysAgoAmazonLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SevenDaysAgoAmazonLbl.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenDaysAgoAmazonLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SevenDaysAgoAmazonLbl.Location = New System.Drawing.Point(822, 794)
        Me.SevenDaysAgoAmazonLbl.Name = "SevenDaysAgoAmazonLbl"
        Me.SevenDaysAgoAmazonLbl.Size = New System.Drawing.Size(237, 81)
        Me.SevenDaysAgoAmazonLbl.TabIndex = 47
        Me.SevenDaysAgoAmazonLbl.Text = "-"
        Me.SevenDaysAgoAmazonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(1065, 734)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 60)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "OTHER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SevenDaysAgoWebsiteLbl
        '
        Me.SevenDaysAgoWebsiteLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SevenDaysAgoWebsiteLbl.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenDaysAgoWebsiteLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SevenDaysAgoWebsiteLbl.Location = New System.Drawing.Point(1065, 794)
        Me.SevenDaysAgoWebsiteLbl.Name = "SevenDaysAgoWebsiteLbl"
        Me.SevenDaysAgoWebsiteLbl.Size = New System.Drawing.Size(237, 81)
        Me.SevenDaysAgoWebsiteLbl.TabIndex = 49
        Me.SevenDaysAgoWebsiteLbl.Text = "-"
        Me.SevenDaysAgoWebsiteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TodaysProgress
        '
        Me.TodaysProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TodaysProgress.BackColor = System.Drawing.SystemColors.Control
        Me.TodaysProgress.Location = New System.Drawing.Point(4, 889)
        Me.TodaysProgress.Name = "TodaysProgress"
        Me.TodaysProgress.Size = New System.Drawing.Size(1896, 62)
        Me.TodaysProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.TodaysProgress.TabIndex = 51
        '
        'AvgUpPanel
        '
        Me.AvgUpPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvgUpPanel.Controls.Add(Me.CoolButton1)
        Me.AvgUpPanel.Location = New System.Drawing.Point(4, 203)
        Me.AvgUpPanel.Name = "AvgUpPanel"
        Me.AvgUpPanel.Size = New System.Drawing.Size(276, 284)
        Me.AvgUpPanel.TabIndex = 52
        Me.AvgUpPanel.Visible = False
        '
        'AvgDownPanel
        '
        Me.AvgDownPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvgDownPanel.Controls.Add(Me.CoolButton2)
        Me.AvgDownPanel.Location = New System.Drawing.Point(4, 493)
        Me.AvgDownPanel.Name = "AvgDownPanel"
        Me.AvgDownPanel.Size = New System.Drawing.Size(276, 279)
        Me.AvgDownPanel.TabIndex = 53
        Me.AvgDownPanel.Visible = False
        '
        'CoolButton1
        '
        Me.CoolButton1.BackgroundImage = Global.SubSupervisorScreen.My.Resources.Resources.GrnArrowIcon
        Me.CoolButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CoolButton1.Enabled = False
        Me.CoolButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CoolButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CoolButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CoolButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CoolButton1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CoolButton1.Location = New System.Drawing.Point(3, 3)
        Me.CoolButton1.Name = "CoolButton1"
        Me.CoolButton1.Size = New System.Drawing.Size(270, 276)
        Me.CoolButton1.TabIndex = 0
        Me.CoolButton1.Text = "Higher than average"
        Me.CoolButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CoolButton1.UseVisualStyleBackColor = True
        '
        'CoolButton2
        '
        Me.CoolButton2.BackgroundImage = Global.SubSupervisorScreen.My.Resources.Resources.RedArrowIcon
        Me.CoolButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CoolButton2.Enabled = False
        Me.CoolButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CoolButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CoolButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CoolButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CoolButton2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolButton2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CoolButton2.Location = New System.Drawing.Point(3, -9)
        Me.CoolButton2.Name = "CoolButton2"
        Me.CoolButton2.Size = New System.Drawing.Size(270, 276)
        Me.CoolButton2.TabIndex = 1
        Me.CoolButton2.Text = "Lower than average"
        Me.CoolButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CoolButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(4, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 60)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Today's order count"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AvgDownPanel)
        Me.Controls.Add(Me.AvgUpPanel)
        Me.Controls.Add(Me.TodaysProgress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SevenDaysAgoWebsiteLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SevenDaysAgoAmazonLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SevenDaysAgoTitleLbl)
        Me.Controls.Add(Me.SevenDaysAgoEbayLbl)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ReloadingOrddefLabel)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ClockTxt)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.NewCount)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PickingCount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PickedCount)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PackingCount)
        Me.Controls.Add(Me.PackedCount)
        Me.Controls.Add(Me.totalsCount)
        Me.Controls.Add(Me.PostedCount)
        Me.Controls.Add(Me.MissingItemCount)
        Me.Controls.Add(Me.PrepackCount)
        Me.Controls.Add(Me.NotFoundCount)
        Me.Name = "Form1"
        Me.Text = "Warehouse Stats"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AvgUpPanel.ResumeLayout(False)
        Me.AvgDownPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClockTxt As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents NewCount As Label
    Friend WithEvents PickingCount As Label
    Friend WithEvents PickedCount As Label
    Friend WithEvents PackingCount As Label
    Friend WithEvents PackedCount As Label
    Friend WithEvents PostedCount As Label
    Friend WithEvents PrepackCount As Label
    Friend WithEvents NotFoundCount As Label
    Friend WithEvents MissingItemCount As Label
    Friend WithEvents totalsCount As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ReloadingOrddefLabel As Label
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents Label17 As Label
    Friend WithEvents LoadOrders As System.ComponentModel.BackgroundWorker
    Friend WithEvents SevenDaysAgoTitleLbl As Label
    Friend WithEvents SevenDaysAgoEbayLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SevenDaysAgoAmazonLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SevenDaysAgoWebsiteLbl As Label
    Friend WithEvents TodaysProgress As ProgressBar
    Friend WithEvents AvgUpPanel As Panel
    Friend WithEvents AvgDownPanel As Panel
    Friend WithEvents CoolButton1 As WHLClasses.Controls.CoolButton
    Friend WithEvents CoolButton2 As WHLClasses.Controls.CoolButton
    Friend WithEvents Label3 As Label
End Class
