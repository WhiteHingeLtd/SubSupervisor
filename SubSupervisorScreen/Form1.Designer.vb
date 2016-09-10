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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SurfacePickerVersionTxt = New System.Windows.Forms.Label()
        Me.UpdatedTxt = New System.Windows.Forms.Label()
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
        Me.Label18.Location = New System.Drawing.Point(405, 317)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(360, 60)
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
        Me.Label19.Location = New System.Drawing.Point(771, 317)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(360, 60)
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
        Me.Label20.Location = New System.Drawing.Point(1137, 317)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(360, 60)
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
        Me.Label21.Location = New System.Drawing.Point(1503, 317)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(360, 60)
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
        Me.Label22.Location = New System.Drawing.Point(1137, 577)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(360, 60)
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
        Me.Label23.Location = New System.Drawing.Point(771, 577)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(360, 60)
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
        Me.Label24.Location = New System.Drawing.Point(405, 577)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(360, 60)
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
        Me.Label25.Location = New System.Drawing.Point(39, 577)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(360, 60)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Prepack"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewCount
        '
        Me.NewCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewCount.Location = New System.Drawing.Point(39, 388)
        Me.NewCount.Name = "NewCount"
        Me.NewCount.Size = New System.Drawing.Size(360, 130)
        Me.NewCount.TabIndex = 31
        Me.NewCount.Text = "-"
        Me.NewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PickingCount
        '
        Me.PickingCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PickingCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickingCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PickingCount.Location = New System.Drawing.Point(405, 388)
        Me.PickingCount.Name = "PickingCount"
        Me.PickingCount.Size = New System.Drawing.Size(360, 130)
        Me.PickingCount.TabIndex = 32
        Me.PickingCount.Text = "-"
        Me.PickingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PickedCount
        '
        Me.PickedCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PickedCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickedCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PickedCount.Location = New System.Drawing.Point(771, 388)
        Me.PickedCount.Name = "PickedCount"
        Me.PickedCount.Size = New System.Drawing.Size(360, 130)
        Me.PickedCount.TabIndex = 33
        Me.PickedCount.Text = "-"
        Me.PickedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PackingCount
        '
        Me.PackingCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PackingCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackingCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PackingCount.Location = New System.Drawing.Point(1137, 388)
        Me.PackingCount.Name = "PackingCount"
        Me.PackingCount.Size = New System.Drawing.Size(360, 130)
        Me.PackingCount.TabIndex = 34
        Me.PackingCount.Text = "-"
        Me.PackingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PackedCount
        '
        Me.PackedCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PackedCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackedCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PackedCount.Location = New System.Drawing.Point(1503, 388)
        Me.PackedCount.Name = "PackedCount"
        Me.PackedCount.Size = New System.Drawing.Size(360, 130)
        Me.PackedCount.TabIndex = 35
        Me.PackedCount.Text = "-"
        Me.PackedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PostedCount
        '
        Me.PostedCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PostedCount.Font = New System.Drawing.Font("Segoe UI Semibold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostedCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PostedCount.Location = New System.Drawing.Point(1137, 637)
        Me.PostedCount.Name = "PostedCount"
        Me.PostedCount.Size = New System.Drawing.Size(360, 130)
        Me.PostedCount.TabIndex = 36
        Me.PostedCount.Text = "-"
        Me.PostedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrepackCount
        '
        Me.PrepackCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrepackCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrepackCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrepackCount.Location = New System.Drawing.Point(39, 637)
        Me.PrepackCount.Name = "PrepackCount"
        Me.PrepackCount.Size = New System.Drawing.Size(360, 130)
        Me.PrepackCount.TabIndex = 37
        Me.PrepackCount.Text = "-"
        Me.PrepackCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotFoundCount
        '
        Me.NotFoundCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NotFoundCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotFoundCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NotFoundCount.Location = New System.Drawing.Point(405, 637)
        Me.NotFoundCount.Name = "NotFoundCount"
        Me.NotFoundCount.Size = New System.Drawing.Size(360, 130)
        Me.NotFoundCount.TabIndex = 38
        Me.NotFoundCount.Text = "-"
        Me.NotFoundCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MissingItemCount
        '
        Me.MissingItemCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MissingItemCount.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissingItemCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MissingItemCount.Location = New System.Drawing.Point(771, 637)
        Me.MissingItemCount.Name = "MissingItemCount"
        Me.MissingItemCount.Size = New System.Drawing.Size(360, 130)
        Me.MissingItemCount.TabIndex = 39
        Me.MissingItemCount.Text = "-"
        Me.MissingItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalsCount
        '
        Me.totalsCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totalsCount.Font = New System.Drawing.Font("Segoe UI Semibold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalsCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.totalsCount.Location = New System.Drawing.Point(1503, 637)
        Me.totalsCount.Name = "totalsCount"
        Me.totalsCount.Size = New System.Drawing.Size(360, 130)
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
        Me.Label26.Location = New System.Drawing.Point(1503, 577)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(360, 60)
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
        Me.Label17.Location = New System.Drawing.Point(39, 317)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(360, 60)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "New"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadOrders
        '
        Me.LoadOrders.WorkerReportsProgress = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(46, 900)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1002, 130)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Surface Picker Version:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SurfacePickerVersionTxt
        '
        Me.SurfacePickerVersionTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SurfacePickerVersionTxt.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurfacePickerVersionTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SurfacePickerVersionTxt.Location = New System.Drawing.Point(1054, 900)
        Me.SurfacePickerVersionTxt.Name = "SurfacePickerVersionTxt"
        Me.SurfacePickerVersionTxt.Size = New System.Drawing.Size(809, 130)
        Me.SurfacePickerVersionTxt.TabIndex = 45
        Me.SurfacePickerVersionTxt.Text = "0.0.0.0"
        Me.SurfacePickerVersionTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdatedTxt
        '
        Me.UpdatedTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UpdatedTxt.AutoSize = True
        Me.UpdatedTxt.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatedTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UpdatedTxt.Location = New System.Drawing.Point(39, 772)
        Me.UpdatedTxt.Name = "UpdatedTxt"
        Me.UpdatedTxt.Size = New System.Drawing.Size(450, 128)
        Me.UpdatedTxt.TabIndex = 47
        Me.UpdatedTxt.Text = "Updated!"
        Me.UpdatedTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdatedTxt.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.UpdatedTxt)
        Me.Controls.Add(Me.SurfacePickerVersionTxt)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents SurfacePickerVersionTxt As Label
    Friend WithEvents UpdatedTxt As Label
End Class
