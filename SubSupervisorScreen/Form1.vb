Imports System.ComponentModel
Imports WHLClasses
Imports WHLClasses.Linnworks.Orders
Imports WHLClasses.NetCom
Imports WHLClasses.Orders

Public Class Form1
    Private Sub LoadTheProgram() Handles Me.Load

        Dim newwin As New wpfMainWindow
        newwin.Show()
        newwin.WindowToClose = Me
        Me.Hide()
    End Sub

    Public Sub CloseWinProper()
        Me.Close()
    End Sub
End Class
