<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hr_up = New System.Windows.Forms.Button()
        Me.min_up = New System.Windows.Forms.Button()
        Me.sec_up = New System.Windows.Forms.Button()
        Me.hr_down = New System.Windows.Forms.Button()
        Me.min_down = New System.Windows.Forms.Button()
        Me.sec_down = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_alarm = New System.Windows.Forms.Button()
        Me.btn_instruction = New System.Windows.Forms.Button()
        Me.btn_mode = New System.Windows.Forms.Button()
        Me.btn_set = New System.Windows.Forms.Button()
        Me.lbl_done = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Courier New", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(266, 287)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(787, 159)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'hr_up
        '
        Me.hr_up.BackColor = System.Drawing.Color.Transparent
        Me.hr_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hr_up.FlatAppearance.BorderSize = 0
        Me.hr_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hr_up.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hr_up.ForeColor = System.Drawing.Color.Black
        Me.hr_up.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hr_up.Location = New System.Drawing.Point(337, 220)
        Me.hr_up.Name = "hr_up"
        Me.hr_up.Size = New System.Drawing.Size(47, 60)
        Me.hr_up.TabIndex = 11
        Me.hr_up.Text = "▲"
        Me.hr_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hr_up.UseVisualStyleBackColor = False
        '
        'min_up
        '
        Me.min_up.BackColor = System.Drawing.Color.Transparent
        Me.min_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.min_up.FlatAppearance.BorderSize = 0
        Me.min_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_up.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_up.ForeColor = System.Drawing.Color.Black
        Me.min_up.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.min_up.Location = New System.Drawing.Point(553, 221)
        Me.min_up.Name = "min_up"
        Me.min_up.Size = New System.Drawing.Size(47, 60)
        Me.min_up.TabIndex = 16
        Me.min_up.Text = "▲"
        Me.min_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.min_up.UseVisualStyleBackColor = False
        '
        'sec_up
        '
        Me.sec_up.BackColor = System.Drawing.Color.Transparent
        Me.sec_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sec_up.FlatAppearance.BorderSize = 0
        Me.sec_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sec_up.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec_up.ForeColor = System.Drawing.Color.Black
        Me.sec_up.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sec_up.Location = New System.Drawing.Point(769, 220)
        Me.sec_up.Name = "sec_up"
        Me.sec_up.Size = New System.Drawing.Size(47, 60)
        Me.sec_up.TabIndex = 17
        Me.sec_up.Text = "▲"
        Me.sec_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sec_up.UseVisualStyleBackColor = False
        '
        'hr_down
        '
        Me.hr_down.BackColor = System.Drawing.Color.Transparent
        Me.hr_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hr_down.FlatAppearance.BorderSize = 0
        Me.hr_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hr_down.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hr_down.ForeColor = System.Drawing.Color.Black
        Me.hr_down.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hr_down.Location = New System.Drawing.Point(339, 406)
        Me.hr_down.Name = "hr_down"
        Me.hr_down.Size = New System.Drawing.Size(47, 60)
        Me.hr_down.TabIndex = 18
        Me.hr_down.Text = "▼"
        Me.hr_down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hr_down.UseVisualStyleBackColor = False
        '
        'min_down
        '
        Me.min_down.BackColor = System.Drawing.Color.Transparent
        Me.min_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.min_down.FlatAppearance.BorderSize = 0
        Me.min_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_down.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_down.ForeColor = System.Drawing.Color.Black
        Me.min_down.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.min_down.Location = New System.Drawing.Point(555, 408)
        Me.min_down.Name = "min_down"
        Me.min_down.Size = New System.Drawing.Size(47, 60)
        Me.min_down.TabIndex = 19
        Me.min_down.Text = "▼"
        Me.min_down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.min_down.UseVisualStyleBackColor = False
        '
        'sec_down
        '
        Me.sec_down.BackColor = System.Drawing.Color.Transparent
        Me.sec_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sec_down.FlatAppearance.BorderSize = 0
        Me.sec_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sec_down.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec_down.ForeColor = System.Drawing.Color.Black
        Me.sec_down.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sec_down.Location = New System.Drawing.Point(771, 408)
        Me.sec_down.Name = "sec_down"
        Me.sec_down.Size = New System.Drawing.Size(47, 60)
        Me.sec_down.TabIndex = 20
        Me.sec_down.Text = "▼"
        Me.sec_down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sec_down.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(940, 622)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(184, 60)
        Me.btn_exit.TabIndex = 21
        Me.btn_exit.Text = "┌── Exit ──┐"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_alarm
        '
        Me.btn_alarm.BackColor = System.Drawing.Color.Transparent
        Me.btn_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alarm.FlatAppearance.BorderSize = 0
        Me.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alarm.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alarm.ForeColor = System.Drawing.Color.Black
        Me.btn_alarm.Location = New System.Drawing.Point(725, 622)
        Me.btn_alarm.Name = "btn_alarm"
        Me.btn_alarm.Size = New System.Drawing.Size(204, 60)
        Me.btn_alarm.TabIndex = 22
        Me.btn_alarm.Text = "┌── Alarm ──┐"
        Me.btn_alarm.UseVisualStyleBackColor = False
        '
        'btn_instruction
        '
        Me.btn_instruction.BackColor = System.Drawing.Color.Transparent
        Me.btn_instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_instruction.FlatAppearance.BorderSize = 0
        Me.btn_instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_instruction.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_instruction.ForeColor = System.Drawing.Color.Black
        Me.btn_instruction.Location = New System.Drawing.Point(12, 622)
        Me.btn_instruction.Name = "btn_instruction"
        Me.btn_instruction.Size = New System.Drawing.Size(292, 60)
        Me.btn_instruction.TabIndex = 23
        Me.btn_instruction.Text = "┌── How-To-Use ──┐"
        Me.btn_instruction.UseVisualStyleBackColor = False
        '
        'btn_mode
        '
        Me.btn_mode.BackColor = System.Drawing.Color.Transparent
        Me.btn_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mode.FlatAppearance.BorderSize = 0
        Me.btn_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mode.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mode.ForeColor = System.Drawing.Color.Black
        Me.btn_mode.Location = New System.Drawing.Point(12, 12)
        Me.btn_mode.Name = "btn_mode"
        Me.btn_mode.Size = New System.Drawing.Size(41, 57)
        Me.btn_mode.TabIndex = 24
        Me.btn_mode.Text = "☼"
        Me.btn_mode.UseVisualStyleBackColor = False
        '
        'btn_set
        '
        Me.btn_set.BackColor = System.Drawing.Color.Transparent
        Me.btn_set.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_set.FlatAppearance.BorderSize = 0
        Me.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_set.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set.ForeColor = System.Drawing.Color.Black
        Me.btn_set.Location = New System.Drawing.Point(546, 622)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(166, 60)
        Me.btn_set.TabIndex = 25
        Me.btn_set.Text = "┌── Set ──┐"
        Me.btn_set.UseVisualStyleBackColor = False
        '
        'lbl_done
        '
        Me.lbl_done.AutoSize = True
        Me.lbl_done.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.lbl_done.Font = New System.Drawing.Font("Courier New", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_done.ForeColor = System.Drawing.Color.White
        Me.lbl_done.Location = New System.Drawing.Point(214, 283)
        Me.lbl_done.Name = "lbl_done"
        Me.lbl_done.Size = New System.Drawing.Size(0, 159)
        Me.lbl_done.TabIndex = 26
        Me.lbl_done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_done.Visible = False
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1141, 694)
        Me.Controls.Add(Me.lbl_done)
        Me.Controls.Add(Me.btn_set)
        Me.Controls.Add(Me.btn_mode)
        Me.Controls.Add(Me.btn_instruction)
        Me.Controls.Add(Me.btn_alarm)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.sec_down)
        Me.Controls.Add(Me.min_down)
        Me.Controls.Add(Me.hr_down)
        Me.Controls.Add(Me.sec_up)
        Me.Controls.Add(Me.min_up)
        Me.Controls.Add(Me.hr_up)
        Me.Controls.Add(Me.lblTime)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Futura-Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer by Kim"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents hr_up As Button
    Friend WithEvents min_up As Button
    Friend WithEvents sec_up As Button
    Friend WithEvents hr_down As Button
    Friend WithEvents min_down As Button
    Friend WithEvents sec_down As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_alarm As Button
    Friend WithEvents btn_instruction As Button
    Friend WithEvents btn_mode As Button
    Friend WithEvents btn_set As Button
    Friend WithEvents lbl_done As Label
End Class
