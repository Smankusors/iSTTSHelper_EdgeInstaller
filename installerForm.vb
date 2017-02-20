Imports System.IO

'http://stackoverflow.com/questions/439617/hanging-process-when-run-with-net-process-start-whats-wrong

Public Class installerForm
    Dim cursorX, cursorY, formX, formY, gantiMerah, gantiWarna, ticks As Integer
    Dim changeby As Double
    Dim installClicked As Boolean = False, installSuccess As Boolean = False
    Dim outputMsg As String

    'Mengatur progress bar
    Private Sub setProgress(progress As Integer)
        If progress < 100 Then
            progressBox.Width = 238 * progress / 100
            progressBoxAlt.Width = progressBox.Width
        Else
            finishAnimation.Enabled = True
        End If
    End Sub

    'Untuk handle pesan error
    Private Sub onError(errorMsg As String)
        MsgBox(errorMsg, MsgBoxStyle.Critical, Title:="ERROR")
        progressAnimation.Enabled = False
        installButton.Text = "ERROR"
    End Sub

    'Supaya bisa dipindah pindah formnya
    Private Sub installerForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        formX = Left
        formY = Top
        cursorX = MousePosition.X
        cursorY = MousePosition.Y
    End Sub
    Private Sub installerForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Left = formX - cursorX + MousePosition.X
            Top = formY - cursorY + MousePosition.Y
        End If
    End Sub

    'ANIMATION STUFF
    Private Sub openAnimation_Tick(sender As Object, e As EventArgs) Handles openAnimation.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
        Else
            openAnimation.Enabled = False
        End If
    End Sub
    Private Sub introInstallAnimation_Tick(sender As Object, e As EventArgs) Handles introInstallAnimation.Tick
        If installButton.Left > 150 Then
            installButton.Width += changeby
            installButton.Left -= changeby
            If ticks <= 20 Then
                gantiMerah = 255 - ticks * 0.05 * 68
                gantiWarna = 255 * (20 - ticks) * 0.05
                ticks += 1
                installButton.ForeColor = Color.FromArgb(gantiMerah, gantiWarna, gantiWarna)
            Else
                installButton.Text = "Installing..."
            End If
            changeby /= 1.131
        Else
            ticks = 0
            installButton.Left = 150
            introInstallAnimation.Enabled = False
            showProgress.Enabled = True
        End If
    End Sub
    Private Sub finishAnimation_Tick(sender As Object, e As EventArgs) Handles finishAnimation.Tick
        If (progressBox.Width < 238) Then
            progressBox.Width += 5
            progressBoxAlt.Width = progressBox.Width
        Else
            finishAnimation.Enabled = False
        End If
    End Sub
    Private Sub progressAnimation_Tick(sender As Object, e As EventArgs) Handles progressAnimation.Tick
        If (progressBoxAlt.Left < 150) Then
            progressBox.Left += 5
            progressBoxAlt.Left += 5
        Else
            progressBox.Left = 150
            progressBoxAlt.Left = -88
        End If
    End Sub
    Private Sub showProgress_Tick(sender As Object, e As EventArgs) Handles showProgress.Tick
        If ticks <= 10 Then
            gantiMerah = 255 - (10 - ticks) * 0.1 * 68
            gantiWarna = 255 * ticks * 0.1
            ticks += 1
            installButton.ForeColor = Color.FromArgb(gantiMerah, gantiWarna, gantiWarna)
        Else
            showProgress.Enabled = False
            setProgress(0.1)
            progressAnimation.Enabled = True
            doInstall.RunWorkerAsync()
        End If
    End Sub
    Private Sub closeAnimation_Tick(sender As Object, e As EventArgs) Handles closeAnimation.Tick
        If (Me.Opacity > 0) Then
            Me.Opacity -= 0.1
        Else
            Application.Exit()
        End If
    End Sub

    'Set progress bar menjadi 0 saat LOAD
    Private Sub installerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setProgress(0)
    End Sub

    'InstallClicked buat supaya gak trigger install lagi jika secara tidak sengaja tombolnya di klik lagi
    Private Sub installButton_Click(sender As Object, e As EventArgs) Handles installButton.Click
        If installClicked = False Then
            changeby = 20
            ticks = 0
            installButton.BackColor = Color.FromArgb(187, 0, 0)
            installButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 0, 0)
            introInstallAnimation.Enabled = True
            installClicked = True
        End If
    End Sub

    'Animasi tutup
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        closeAnimation.Enabled = True
    End Sub

    Private Sub doInstall_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles doInstall.DoWork
        'Copy file sementara ke %TEMP%
        Dim SmanKey = My.Computer.FileSystem.GetTempFileName()
        Dim AppxFile = My.Computer.FileSystem.GetTempFileName()
        My.Computer.FileSystem.WriteAllBytes(SmanKey, My.Resources.SmankusorsKey, False)
        My.Computer.FileSystem.WriteAllBytes(AppxFile, My.Resources.iSTTSHelper_edge, False)
        doInstall.ReportProgress(30)

        'Install sertifikat di Windows 10 supaya appx iSTTS Helper bisa diinstall di Windows 10
        Dim CertUtil As ProcessStartInfo = New ProcessStartInfo("Certutil")
        CertUtil.Arguments = "-addStore TrustedPeople " + SmanKey
        CertUtil.RedirectStandardOutput = True
        CertUtil.UseShellExecute = False
        CertUtil.CreateNoWindow = True
        Dim proc As Process = Process.Start(CertUtil)
        proc.WaitForExit()
        Dim output As StreamReader = New StreamReader(proc.StandardOutput.BaseStream)
        outputMsg = output.ReadToEnd.ToString()
        output.Close()

        'Jika output sukses maka lanjut, jika tidak langsung stop
        If outputMsg.Contains("success") Then
            doInstall.ReportProgress(60)

            'Mengaktifkan fitur sideload app via registry
            ' prevValue untuk menyimpan sementara value apakah sudah di aktifkan fitur sideloadnya
            '  karena setelah selesai diinstall, value akan dikembalikan seperti semula
            Dim prevValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock", "AllowAllTrustedApps", "")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock", "AllowAllTrustedApps", 1)

            'Meluncurkan powershell untuk menginstall appx
            Dim AddAppx As ProcessStartInfo = New ProcessStartInfo("powershell")
            AddAppx.Arguments = "Add-AppxPackage " + AppxFile
            AddAppx.RedirectStandardOutput = True
            AddAppx.UseShellExecute = False
            AddAppx.CreateNoWindow = True
            proc = Process.Start(AddAppx)
            proc.WaitForExit()
            output = New StreamReader(proc.StandardOutput.BaseStream)
            outputMsg = output.ReadToEnd.ToString()
            output.Close()

            'Biasanya jika sukses tidak ada output, tapi kalau ada error, outputnya panjang sekali
            ' aku pikir 5 cukup buat trigger kalau ada yang salah :3
            If outputMsg.Length < 5 Then
                doInstall.ReportProgress(100)
                installSuccess = True
            End If
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock", "AllowAllTrustedApps", prevValue)
        End If
    End Sub

    'Setel progress bar jika .ReportProgress dipanggil
    Private Sub doInstall_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles doInstall.ProgressChanged
        setProgress(e.ProgressPercentage)
    End Sub

    'Saat asyncworker selesai, mengecek apakah sukses, kalau tidak luncurkan pesan error
    Private Sub doInstall_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles doInstall.RunWorkerCompleted
        If installSuccess Then
            installButton.Text = "Installed!"
        Else
            onError(outputMsg)
        End If
    End Sub

End Class
