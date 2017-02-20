<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class installerForm
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
        Me.closeButton = New System.Windows.Forms.Button()
        Me.installButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.introInstallAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.showProgress = New System.Windows.Forms.Timer(Me.components)
        Me.progressAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.doInstall = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.progressBoxAlt = New System.Windows.Forms.PictureBox()
        Me.progressBox = New System.Windows.Forms.PictureBox()
        Me.openAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.finishAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.closeAnimation = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressBoxAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeButton.FlatAppearance.BorderSize = 0
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(358, 13)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(30, 30)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "X"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'installButton
        '
        Me.installButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.installButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.installButton.FlatAppearance.BorderSize = 0
        Me.installButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.installButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installButton.Location = New System.Drawing.Point(318, 111)
        Me.installButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.installButton.Name = "installButton"
        Me.installButton.Size = New System.Drawing.Size(70, 30)
        Me.installButton.TabIndex = 2
        Me.installButton.Text = "Install"
        Me.installButton.UseMnemonic = False
        Me.installButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 47)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "iSTTS Helper"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(143, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Edge"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(211, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Installer"
        '
        'introInstallAnimation
        '
        Me.introInstallAnimation.Interval = 15
        '
        'showProgress
        '
        Me.showProgress.Interval = 15
        '
        'progressAnimation
        '
        Me.progressAnimation.Interval = 15
        '
        'doInstall
        '
        Me.doInstall.WorkerReportsProgress = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Location = New System.Drawing.Point(388, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.iSTTSHelper_EdgeInstaller.My.Resources.Resources.logo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(9, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-9, 111)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 50)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'progressBoxAlt
        '
        Me.progressBoxAlt.BackColor = System.Drawing.Color.Red
        Me.progressBoxAlt.Location = New System.Drawing.Point(-88, 138)
        Me.progressBoxAlt.Name = "progressBoxAlt"
        Me.progressBoxAlt.Size = New System.Drawing.Size(50, 3)
        Me.progressBoxAlt.TabIndex = 9
        Me.progressBoxAlt.TabStop = False
        '
        'progressBox
        '
        Me.progressBox.BackColor = System.Drawing.Color.Red
        Me.progressBox.Location = New System.Drawing.Point(150, 138)
        Me.progressBox.Name = "progressBox"
        Me.progressBox.Size = New System.Drawing.Size(50, 3)
        Me.progressBox.TabIndex = 6
        Me.progressBox.TabStop = False
        '
        'openAnimation
        '
        Me.openAnimation.Enabled = True
        Me.openAnimation.Interval = 15
        '
        'finishAnimation
        '
        Me.finishAnimation.Interval = 15
        '
        'closeAnimation
        '
        Me.closeAnimation.Interval = 15
        '
        'installerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 155)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.progressBoxAlt)
        Me.Controls.Add(Me.progressBox)
        Me.Controls.Add(Me.installButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "installerForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iSTTS Helper | Edge Installer"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressBoxAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeButton As Button
    Friend WithEvents installButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents introInstallAnimation As Timer
    Friend WithEvents showProgress As Timer
    Friend WithEvents progressBox As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents progressAnimation As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents progressBoxAlt As PictureBox
    Friend WithEvents doInstall As System.ComponentModel.BackgroundWorker
    Friend WithEvents openAnimation As Timer
    Friend WithEvents finishAnimation As Timer
    Friend WithEvents closeAnimation As Timer
End Class
