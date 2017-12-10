Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices


Public Class Form1

    Dim directoryName = "hideFiles"
    Dim click As Integer = 0
    Dim normalColor = Color.DodgerBlue, clickColor = Color.SlateBlue, failedColor = Color.Firebrick, successColor = Color.DarkTurquoise

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles promptLabel.Click
        Me.BackColor = clickColor
        Timer1.Enabled = False
        click += 1
        Timer1.Enabled = True
        Refresh()
        Threading.Thread.Sleep(200)
        Me.BackColor = normalColor
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If click = 8 Then

            Timer1.Enabled = False
            Shell("cmd.exe /c " & "attrib +s +a +h +r " & System.IO.Directory.GetCurrentDirectory() & "\" & directoryName, AppWinStyle.Hide)
            lockIcon.Image = My.Resources.lock
            lockIcon.Show()
            promptLabel.Hide()
            Me.BackColor = successColor
            Refresh()

            Threading.Thread.Sleep(1000)
            Me.BackColor = normalColor
            promptLabel.Show()
            lockIcon.Hide()

        ElseIf click = 10 Then

            Timer1.Enabled = False
            Shell("cmd.exe /c " & "attrib -s -a -h -r " & System.IO.Directory.GetCurrentDirectory() & "\" & directoryName, AppWinStyle.Hide)
            promptLabel.Hide()
            lockIcon.Image = My.Resources.unlock
            lockIcon.Show()
            Me.BackColor = successColor
            Refresh()

            Threading.Thread.Sleep(1000)
            Me.BackColor = normalColor
            promptLabel.Show()
            lockIcon.Hide()
        Else
            Me.BackColor = failedColor
            Refresh()
            Threading.Thread.Sleep(1000)
            Me.BackColor = normalColor
        End If

        click = 0
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timeLabel.Text = Now.Hour & ":" & Now.Minute
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub

End Class

