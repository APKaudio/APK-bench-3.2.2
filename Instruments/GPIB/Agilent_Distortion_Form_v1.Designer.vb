<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agilent_Distortion_Form
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
        Me.Dist_measure_Voltage = New System.Windows.Forms.TextBox()
        Me.Dist_measure_DSTN = New System.Windows.Forms.TextBox()
        Me.Dist_measure_SINAD = New System.Windows.Forms.TextBox()
        Me.Dist_Amp = New System.Windows.Forms.TextBox()
        Me.DistortionChange = New System.Windows.Forms.Button()
        Me.Dist_freq = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Dist_measure_Voltage
        '
        Me.Dist_measure_Voltage.Location = New System.Drawing.Point(190, 80)
        Me.Dist_measure_Voltage.Name = "Dist_measure_Voltage"
        Me.Dist_measure_Voltage.Size = New System.Drawing.Size(60, 20)
        Me.Dist_measure_Voltage.TabIndex = 44
        '
        'Dist_measure_DSTN
        '
        Me.Dist_measure_DSTN.Location = New System.Drawing.Point(124, 80)
        Me.Dist_measure_DSTN.Name = "Dist_measure_DSTN"
        Me.Dist_measure_DSTN.Size = New System.Drawing.Size(60, 20)
        Me.Dist_measure_DSTN.TabIndex = 43
        '
        'Dist_measure_SINAD
        '
        Me.Dist_measure_SINAD.Location = New System.Drawing.Point(57, 80)
        Me.Dist_measure_SINAD.Name = "Dist_measure_SINAD"
        Me.Dist_measure_SINAD.Size = New System.Drawing.Size(60, 20)
        Me.Dist_measure_SINAD.TabIndex = 42
        '
        'Dist_Amp
        '
        Me.Dist_Amp.Location = New System.Drawing.Point(155, 12)
        Me.Dist_Amp.Name = "Dist_Amp"
        Me.Dist_Amp.Size = New System.Drawing.Size(54, 20)
        Me.Dist_Amp.TabIndex = 41
        Me.Dist_Amp.Text = "1"
        '
        'DistortionChange
        '
        Me.DistortionChange.Location = New System.Drawing.Point(215, 12)
        Me.DistortionChange.Name = "DistortionChange"
        Me.DistortionChange.Size = New System.Drawing.Size(75, 23)
        Me.DistortionChange.TabIndex = 40
        Me.DistortionChange.Text = "Distortion Update "
        Me.DistortionChange.UseVisualStyleBackColor = True
        '
        'Dist_freq
        '
        Me.Dist_freq.Location = New System.Drawing.Point(94, 12)
        Me.Dist_freq.Name = "Dist_freq"
        Me.Dist_freq.Size = New System.Drawing.Size(55, 20)
        Me.Dist_freq.TabIndex = 39
        Me.Dist_freq.Text = "1000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Distortion"
        '
        'Agilent_Distortion_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 130)
        Me.Controls.Add(Me.Dist_measure_Voltage)
        Me.Controls.Add(Me.Dist_measure_DSTN)
        Me.Controls.Add(Me.Dist_measure_SINAD)
        Me.Controls.Add(Me.Dist_Amp)
        Me.Controls.Add(Me.DistortionChange)
        Me.Controls.Add(Me.Dist_freq)
        Me.Controls.Add(Me.Label17)
        Me.Name = "Agilent_Distortion_Form"
        Me.Text = "Agilent_Distortion_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dist_measure_Voltage As TextBox
    Friend WithEvents Dist_measure_DSTN As TextBox
    Friend WithEvents Dist_measure_SINAD As TextBox
    Friend WithEvents Dist_Amp As TextBox
    Friend WithEvents DistortionChange As Button
    Friend WithEvents Dist_freq As TextBox
    Friend WithEvents Label17 As Label
End Class
