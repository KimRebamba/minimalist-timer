Imports System.Xml

Public Class Main
    Dim hour_num As Byte = 0
    Dim minute_num As Byte = 0
    Dim second_num As Byte = 0
    Dim bool_start As Boolean = False
    Dim remaining As TimeSpan
    Dim bool_mode = False
    Dim alarmPath As String = ""
    Dim player As System.Media.SoundPlayer

    Private Sub UpdateDisplay()
        remaining = New TimeSpan(hour_num, minute_num, second_num)
        lblTime.Text = remaining.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = "00:00:00"
    End Sub

    Private Sub Main_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        If lbl_done.Text = "TIME'S UP" Then

            If player IsNot Nothing Then player.Stop()


            If Me.BackColor = Color.Black Then
                bool_mode = False
                Me.BackColor = Color.White
                btn_mode.Text = "☀"
                btn_mode.ForeColor = Color.Black
                Me.ForeColor = Color.Black
                lblTime.ForeColor = Color.Black
                btn_set.ForeColor = Color.Black
                btn_instruction.ForeColor = Color.Black
                btn_alarm.ForeColor = Color.Black
                btn_exit.ForeColor = Color.Black
                hr_down.ForeColor = Color.Black
                hr_up.ForeColor = Color.Black
                min_down.ForeColor = Color.Black
                min_up.ForeColor = Color.Black
                sec_up.ForeColor = Color.Black
                sec_down.ForeColor = Color.Black
            Else
                lblTime.ForeColor = Color.White
                Me.BackColor = Color.Black
                Me.ForeColor = Color.White
                btn_mode.Text = "☾"
                btn_mode.ForeColor = Color.White

                btn_set.ForeColor = Color.White
                btn_instruction.ForeColor = Color.White
                btn_alarm.ForeColor = Color.White
                btn_exit.ForeColor = Color.White
                hr_down.ForeColor = Color.White
                hr_up.ForeColor = Color.White
                min_down.ForeColor = Color.White
                min_up.ForeColor = Color.White
                sec_up.ForeColor = Color.White
                sec_down.ForeColor = Color.White
            End If

            ' Reset time
            hour_num = 0
            minute_num = 0
            second_num = 0
            UpdateDisplay()
            lblTime.Text = "00:00:00"
            bool_start = False
            lbl_done.Text = ""
            ' Show buttons again
            lbl_done.Hide()
            lblTime.Show()
            btn_set.Show()
            btn_mode.Show()
            btn_instruction.Show()
            btn_alarm.Show()
            btn_exit.Show()
            hr_down.Show()
            hr_up.Show()
            min_down.Show()
            min_up.Show()
            sec_up.Show()
            sec_down.Show()
            Exit Sub
        End If


        If bool_start = False Then
            btn_set.Hide()
            btn_mode.Hide()
            btn_instruction.Hide()
            btn_alarm.Hide()
            btn_exit.Hide()
            hr_down.Hide()
            hr_up.Hide()
            min_down.Hide()
            min_up.Hide()
            sec_up.Hide()
            sec_down.Hide()
            bool_start = True
            remaining = New TimeSpan(hour_num, minute_num, second_num)
            Timer1.Interval = 1000
            Timer1.Start()
        Else
            ' Stop and reset timer
            btn_set.Show()
            btn_mode.Show()
            btn_instruction.Show()
            btn_alarm.Show()
            btn_exit.Show()
            hr_down.Show()
            hr_up.Show()
            min_down.Show()
            min_up.Show()
            sec_up.Show()
            sec_down.Show()
            hour_num = 0
            minute_num = 0
            second_num = 0
            UpdateDisplay()
            bool_start = False
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If remaining.TotalSeconds > 0 Then
            remaining = remaining.Subtract(TimeSpan.FromSeconds(1))
            lblTime.Text = remaining.ToString("hh\:mm\:ss")
        Else
            Timer1.Stop()

            lblTime.Hide()
            lbl_done.Show()
            lbl_done.Text = "TIME'S UP"

            If Me.BackColor = Color.Black Then
                Me.BackColor = Color.White
                lbl_done.ForeColor = Color.Black
            Else
                Me.BackColor = Color.Black
                lbl_done.ForeColor = Color.White
            End If


            Try
                If alarmPath <> "" Then
                    player = New System.Media.SoundPlayer(alarmPath)
                    player.PlayLooping()
                Else
                    Beep()
                End If
            Catch ex As Exception
                Beep()
            End Try

        End If
    End Sub

    Private Sub hr_up_Click(sender As Object, e As EventArgs) Handles hr_up.Click
        If hour_num < 24 Then
            hour_num += 1
            UpdateDisplay()
        Else
            hour_num = 0
            UpdateDisplay()
        End If
    End Sub


    Private Sub hr_down_Click(sender As Object, e As EventArgs) Handles hr_down.Click
        If hour_num > 0 Then
            hour_num -= 1
            UpdateDisplay()
        ElseIf hour_num = 0 Then
            hour_num = 23
            UpdateDisplay()
        End If
    End Sub

    Private Sub min_down_Click(sender As Object, e As EventArgs) Handles min_down.Click
        If minute_num > 0 Then
            minute_num -= 1
            UpdateDisplay()
        ElseIf minute_num = 0 Then
            minute_num = 59
            UpdateDisplay()
        End If
    End Sub

    Private Sub min_up_Click(sender As Object, e As EventArgs) Handles min_up.Click
        If minute_num < 59 Then
            minute_num += 1
            UpdateDisplay()
        Else
            minute_num = 0
            UpdateDisplay()
        End If

    End Sub

    Private Sub sec_up_Click(sender As Object, e As EventArgs) Handles sec_up.Click
        If second_num < 59 Then
            second_num += 1
            UpdateDisplay()
        Else
            second_num = 0
            UpdateDisplay()
        End If
    End Sub

    Private Sub sec_down_Click(sender As Object, e As EventArgs) Handles sec_down.Click
        If second_num > 0 Then
            second_num -= 1
            UpdateDisplay()
        ElseIf second_num = 0 Then
            second_num = 59
            UpdateDisplay()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_alarm_Click(sender As Object, e As EventArgs) Handles btn_alarm.Click


        Dim ofd As New OpenFileDialog()
        ofd.Filter = "WAV files (*.wav)|*.wav"
        ofd.Title = "Select Alarm Sound"

        If ofd.ShowDialog() = DialogResult.OK Then
            alarmPath = ofd.FileName
            MsgBox("Alarm set to: " & alarmPath)
        End If
    End Sub

    Private Sub btn_instruction_Click(sender As Object, e As EventArgs) Handles btn_instruction.Click
        MsgBox("Minimalist Timer Instructions:" & vbCrLf & vbCrLf &
       "1. Click 'Set' to enter the countdown time in hh:mm:ss format (e.g., 00:15:00)." & vbCrLf &
       "2. Click anywhere on the form to start or stop the timer." & vbCrLf &
       "   - When the timer starts, all buttons will hide." & vbCrLf &
       "   - Click again while running to stop and reset." & vbCrLf &
       "3. Use the up/down buttons to adjust hours, minutes, and seconds manually." & vbCrLf &
       "   - Hours: 0-23" & vbCrLf &
       "   - Minutes/Seconds: 0-59" & vbCrLf &
       "4. Click 'Mode' to toggle between Light (☀) and Dark (☾) themes." & vbCrLf &
       "5. Click 'Alarm' to select a custom alarm sound (WAV files)." & vbCrLf &
       "6. When the timer reaches 00:00:00:" & vbCrLf &
       "   - The display will change to 'TIME'S UP'" & vbCrLf &
       "   - Background and text color will switch automatically" & vbCrLf &
       "   - The alarm sound will play continuously until you click the form" & vbCrLf &
       "7. Click anywhere on the form after time is up to stop the alarm and reset the timer." & vbCrLf & vbCrLf &
       "Timer by Kim." & vbCrLf & "-> Thank you so much for trying out the app! :) #NO-ADS-JUST-ART" & vbCrLf &
       vbCrLf & "More projects on my GitHub: https://github.com/KimRebamba",
       vbOKOnly, "How-To-Use:")
    End Sub

    Private Sub btn_mode_Click(sender As Object, e As EventArgs) Handles btn_mode.Click
        If bool_mode = False Then
            bool_mode = True
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            btn_mode.Text = "☾"
            btn_mode.ForeColor = Color.White
            lblTime.ForeColor = Color.White
            btn_set.ForeColor = Color.White
            btn_instruction.ForeColor = Color.White
            btn_alarm.ForeColor = Color.White
            btn_exit.ForeColor = Color.White
            hr_down.ForeColor = Color.White
            hr_up.ForeColor = Color.White
            min_down.ForeColor = Color.White
            min_up.ForeColor = Color.White
            sec_up.ForeColor = Color.White
            sec_down.ForeColor = Color.White
        Else
            bool_mode = False
            Me.BackColor = Color.White
            btn_mode.Text = "☀"
            btn_mode.ForeColor = Color.Black
            Me.ForeColor = Color.Black
            lblTime.ForeColor = Color.Black
            btn_set.ForeColor = Color.Black
            btn_instruction.ForeColor = Color.Black
            btn_alarm.ForeColor = Color.Black
            btn_exit.ForeColor = Color.Black
            hr_down.ForeColor = Color.Black
            hr_up.ForeColor = Color.Black
            min_down.ForeColor = Color.Black
            min_up.ForeColor = Color.Black
            sec_up.ForeColor = Color.Black
            sec_down.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
        Dim userInput As String = InputBox("Enter time (hh:mm:ss):", "Set Timer", "00:15:00")
        Try
            remaining = TimeSpan.Parse(userInput)
            hour_num = CByte(remaining.Hours)
            minute_num = CByte(remaining.Minutes)
            second_num = CByte(remaining.Seconds)
            lblTime.Text = remaining.ToString("hh\:mm\:ss")

        Catch
            MsgBox("Invalid time format.", vbExclamation)
        End Try
    End Sub
End Class
