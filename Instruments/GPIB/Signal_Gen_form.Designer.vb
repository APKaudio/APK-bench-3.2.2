<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signal_Gen_form
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.QuickFreq = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SigGen_FrequencyTrackBar = New System.Windows.Forms.TrackBar()
        Me.SigGen_DutyCycle = New System.Windows.Forms.TrackBar()
        Me.SigGen_Signal_Type = New System.Windows.Forms.ComboBox()
        Me.SigGen_Update = New System.Windows.Forms.Button()
        Me.SigGen_Amp_unit = New System.Windows.Forms.ComboBox()
        Me.SigGen_amp = New System.Windows.Forms.TextBox()
        Me.SigGen_Sine_freq = New System.Windows.Forms.TextBox()
        Me.SignalGenLabel = New System.Windows.Forms.Label()
        Me.QuickFreq.SuspendLayout()
        CType(Me.SigGen_FrequencyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SigGen_DutyCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(363, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 135
        Me.Label16.Text = "Units"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(301, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "Ampl"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(234, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "DC"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(159, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(88, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Frequency"
        '
        'QuickFreq
        '
        Me.QuickFreq.Controls.Add(Me.RadioButton9)
        Me.QuickFreq.Controls.Add(Me.RadioButton8)
        Me.QuickFreq.Controls.Add(Me.RadioButton7)
        Me.QuickFreq.Controls.Add(Me.RadioButton6)
        Me.QuickFreq.Controls.Add(Me.RadioButton5)
        Me.QuickFreq.Controls.Add(Me.RadioButton4)
        Me.QuickFreq.Controls.Add(Me.RadioButton3)
        Me.QuickFreq.Controls.Add(Me.RadioButton2)
        Me.QuickFreq.Controls.Add(Me.RadioButton1)
        Me.QuickFreq.Location = New System.Drawing.Point(7, 74)
        Me.QuickFreq.Name = "QuickFreq"
        Me.QuickFreq.Size = New System.Drawing.Size(507, 36)
        Me.QuickFreq.TabIndex = 130
        Me.QuickFreq.TabStop = False
        Me.QuickFreq.Text = "Quick Freq"
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(210, 13)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton9.TabIndex = 8
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "5kHz"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(159, 13)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "2kHz"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(379, 13)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "50kHz"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(319, 13)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "20kHz"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(5, 13)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "10Hz"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(437, 13)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "100kHz"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(260, 13)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "10kHz"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(110, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1kHz"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(55, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "100Hz"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'SigGen_FrequencyTrackBar
        '
        Me.SigGen_FrequencyTrackBar.BackColor = System.Drawing.SystemColors.Window
        Me.SigGen_FrequencyTrackBar.Location = New System.Drawing.Point(30, 51)
        Me.SigGen_FrequencyTrackBar.Maximum = 100000
        Me.SigGen_FrequencyTrackBar.Name = "SigGen_FrequencyTrackBar"
        Me.SigGen_FrequencyTrackBar.Size = New System.Drawing.Size(473, 45)
        Me.SigGen_FrequencyTrackBar.SmallChange = 100
        Me.SigGen_FrequencyTrackBar.TabIndex = 129
        Me.SigGen_FrequencyTrackBar.TickFrequency = 1000
        Me.SigGen_FrequencyTrackBar.Value = 50
        '
        'SigGen_DutyCycle
        '
        Me.SigGen_DutyCycle.BackColor = System.Drawing.SystemColors.Window
        Me.SigGen_DutyCycle.Location = New System.Drawing.Point(232, 21)
        Me.SigGen_DutyCycle.Maximum = 100
        Me.SigGen_DutyCycle.Name = "SigGen_DutyCycle"
        Me.SigGen_DutyCycle.Size = New System.Drawing.Size(63, 45)
        Me.SigGen_DutyCycle.TabIndex = 128
        Me.SigGen_DutyCycle.Value = 50
        '
        'SigGen_Signal_Type
        '
        Me.SigGen_Signal_Type.FormattingEnabled = True
        Me.SigGen_Signal_Type.Items.AddRange(New Object() {"SIN", "SQU", "RAMP", "PULS", "NOISE"})
        Me.SigGen_Signal_Type.Location = New System.Drawing.Point(156, 21)
        Me.SigGen_Signal_Type.Name = "SigGen_Signal_Type"
        Me.SigGen_Signal_Type.Size = New System.Drawing.Size(70, 21)
        Me.SigGen_Signal_Type.TabIndex = 127
        '
        'SigGen_Update
        '
        Me.SigGen_Update.Location = New System.Drawing.Point(414, 22)
        Me.SigGen_Update.Name = "SigGen_Update"
        Me.SigGen_Update.Size = New System.Drawing.Size(75, 23)
        Me.SigGen_Update.TabIndex = 126
        Me.SigGen_Update.Text = "UPDATE"
        Me.SigGen_Update.UseVisualStyleBackColor = True
        '
        'SigGen_Amp_unit
        '
        Me.SigGen_Amp_unit.FormattingEnabled = True
        Me.SigGen_Amp_unit.Items.AddRange(New Object() {"Vpp", "Vrms", "dBm"})
        Me.SigGen_Amp_unit.Location = New System.Drawing.Point(361, 24)
        Me.SigGen_Amp_unit.Name = "SigGen_Amp_unit"
        Me.SigGen_Amp_unit.Size = New System.Drawing.Size(47, 21)
        Me.SigGen_Amp_unit.TabIndex = 125
        '
        'SigGen_amp
        '
        Me.SigGen_amp.Location = New System.Drawing.Point(301, 24)
        Me.SigGen_amp.Name = "SigGen_amp"
        Me.SigGen_amp.Size = New System.Drawing.Size(54, 20)
        Me.SigGen_amp.TabIndex = 124
        Me.SigGen_amp.Text = "1"
        '
        'SigGen_Sine_freq
        '
        Me.SigGen_Sine_freq.Location = New System.Drawing.Point(92, 22)
        Me.SigGen_Sine_freq.Name = "SigGen_Sine_freq"
        Me.SigGen_Sine_freq.Size = New System.Drawing.Size(55, 20)
        Me.SigGen_Sine_freq.TabIndex = 123
        Me.SigGen_Sine_freq.Text = "1000"
        '
        'SignalGenLabel
        '
        Me.SignalGenLabel.AutoSize = True
        Me.SignalGenLabel.Location = New System.Drawing.Point(27, 24)
        Me.SignalGenLabel.Name = "SignalGenLabel"
        Me.SignalGenLabel.Size = New System.Drawing.Size(59, 13)
        Me.SignalGenLabel.TabIndex = 122
        Me.SignalGenLabel.Text = "Signal Gen"
        '
        'Signal_Gen_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 124)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.QuickFreq)
        Me.Controls.Add(Me.SigGen_FrequencyTrackBar)
        Me.Controls.Add(Me.SigGen_DutyCycle)
        Me.Controls.Add(Me.SigGen_Signal_Type)
        Me.Controls.Add(Me.SigGen_Update)
        Me.Controls.Add(Me.SigGen_Amp_unit)
        Me.Controls.Add(Me.SigGen_amp)
        Me.Controls.Add(Me.SigGen_Sine_freq)
        Me.Controls.Add(Me.SignalGenLabel)
        Me.Name = "Signal_Gen_form"
        Me.Text = "Signal_Gen_form"
        Me.QuickFreq.ResumeLayout(False)
        Me.QuickFreq.PerformLayout()
        CType(Me.SigGen_FrequencyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SigGen_DutyCycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents QuickFreq As GroupBox
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents SigGen_FrequencyTrackBar As TrackBar
    Friend WithEvents SigGen_DutyCycle As TrackBar
    Friend WithEvents SigGen_Signal_Type As ComboBox
    Friend WithEvents SigGen_Update As Button
    Friend WithEvents SigGen_Amp_unit As ComboBox
    Friend WithEvents SigGen_amp As TextBox
    Friend WithEvents SigGen_Sine_freq As TextBox
    Friend WithEvents SignalGenLabel As Label
End Class
