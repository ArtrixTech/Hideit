<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.promptLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.lockIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lockIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'promptLabel
        '
        Me.promptLabel.AutoSize = True
        Me.promptLabel.BackColor = System.Drawing.Color.Transparent
        Me.promptLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.promptLabel.Font = New System.Drawing.Font("Flexo", 16.0!)
        Me.promptLabel.ForeColor = System.Drawing.Color.White
        Me.promptLabel.Location = New System.Drawing.Point(16, 33)
        Me.promptLabel.Name = "promptLabel"
        Me.promptLabel.Size = New System.Drawing.Size(110, 26)
        Me.promptLabel.TabIndex = 0
        Me.promptLabel.Text = "Click Here"
        '
        'Timer1
        '
        Me.Timer1.Interval = 600
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.BackColor = System.Drawing.Color.Transparent
        Me.timeLabel.Font = New System.Drawing.Font("Flexo", 9.0!)
        Me.timeLabel.ForeColor = System.Drawing.Color.White
        Me.timeLabel.Location = New System.Drawing.Point(104, 7)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(41, 14)
        Me.timeLabel.TabIndex = 7
        Me.timeLabel.Text = "Label1"
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Image = Global.AutoUnlock.My.Resources.Resources.no_bg
        Me.logo.Location = New System.Drawing.Point(4, 4)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(47, 19)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 8
        Me.logo.TabStop = False
        '
        'lockIcon
        '
        Me.lockIcon.BackColor = System.Drawing.Color.Transparent
        Me.lockIcon.Image = Global.AutoUnlock.My.Resources.Resources.lock
        Me.lockIcon.Location = New System.Drawing.Point(18, 27)
        Me.lockIcon.Name = "lockIcon"
        Me.lockIcon.Size = New System.Drawing.Size(109, 42)
        Me.lockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lockIcon.TabIndex = 6
        Me.lockIcon.TabStop = False
        Me.lockIcon.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 85)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(142, 77)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.promptLabel)
        Me.Controls.Add(Me.lockIcon)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "加解密"
        Me.TopMost = True
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lockIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents promptLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lockIcon As PictureBox
    Friend WithEvents timeLabel As Label
    Friend WithEvents logo As PictureBox
End Class
