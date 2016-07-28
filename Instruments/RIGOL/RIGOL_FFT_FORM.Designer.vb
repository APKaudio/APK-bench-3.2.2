<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RIGOL_FFT_FORM
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.FFT_MouseOver_XValue = New System.Windows.Forms.Label()
        Me.FFT_H_Display_scale_f = New System.Windows.Forms.Label()
        Me.FFT_H_Display_Center_f_value = New System.Windows.Forms.Label()
        Me.FFT_WINDOWTYPE = New System.Windows.Forms.Label()
        Me.FFT_CH_SOURCE = New System.Windows.Forms.Label()
        Me.FFT_Resolution = New System.Windows.Forms.ComboBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.FFT_H_Display_Center_f = New System.Windows.Forms.TextBox()
        Me.FFT_Channel_Select = New System.Windows.Forms.ComboBox()
        Me.FFT_Window_Type = New System.Windows.Forms.ComboBox()
        Me.FFT_GET_DATA = New System.Windows.Forms.Button()
        Me.Rigol_FFT_Data = New System.Windows.Forms.DataGridView()
        Me.Rigol_FFT_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_FFT_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_FFT_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FFT_MouseOver_XValue
        '
        Me.FFT_MouseOver_XValue.AutoSize = True
        Me.FFT_MouseOver_XValue.Location = New System.Drawing.Point(43, 298)
        Me.FFT_MouseOver_XValue.Name = "FFT_MouseOver_XValue"
        Me.FFT_MouseOver_XValue.Size = New System.Drawing.Size(45, 13)
        Me.FFT_MouseOver_XValue.TabIndex = 39
        Me.FFT_MouseOver_XValue.Text = "Label20"
        '
        'FFT_H_Display_scale_f
        '
        Me.FFT_H_Display_scale_f.AutoSize = True
        Me.FFT_H_Display_scale_f.Location = New System.Drawing.Point(484, 91)
        Me.FFT_H_Display_scale_f.Name = "FFT_H_Display_scale_f"
        Me.FFT_H_Display_scale_f.Size = New System.Drawing.Size(120, 13)
        Me.FFT_H_Display_scale_f.TabIndex = 38
        Me.FFT_H_Display_scale_f.Text = "FFT_H_Display_scale_f"
        '
        'FFT_H_Display_Center_f_value
        '
        Me.FFT_H_Display_Center_f_value.AutoSize = True
        Me.FFT_H_Display_Center_f_value.Location = New System.Drawing.Point(481, 65)
        Me.FFT_H_Display_Center_f_value.Name = "FFT_H_Display_Center_f_value"
        Me.FFT_H_Display_Center_f_value.Size = New System.Drawing.Size(126, 13)
        Me.FFT_H_Display_Center_f_value.TabIndex = 37
        Me.FFT_H_Display_Center_f_value.Text = "FFT_H_Display_Center_f"
        '
        'FFT_WINDOWTYPE
        '
        Me.FFT_WINDOWTYPE.AutoSize = True
        Me.FFT_WINDOWTYPE.Location = New System.Drawing.Point(481, 43)
        Me.FFT_WINDOWTYPE.Name = "FFT_WINDOWTYPE"
        Me.FFT_WINDOWTYPE.Size = New System.Drawing.Size(109, 13)
        Me.FFT_WINDOWTYPE.TabIndex = 35
        Me.FFT_WINDOWTYPE.Text = "FFT_WINDOWTYPE"
        '
        'FFT_CH_SOURCE
        '
        Me.FFT_CH_SOURCE.AutoSize = True
        Me.FFT_CH_SOURCE.Location = New System.Drawing.Point(481, 15)
        Me.FFT_CH_SOURCE.Name = "FFT_CH_SOURCE"
        Me.FFT_CH_SOURCE.Size = New System.Drawing.Size(98, 13)
        Me.FFT_CH_SOURCE.TabIndex = 34
        Me.FFT_CH_SOURCE.Text = "FFT_CH_SOURCE"
        '
        'FFT_Resolution
        '
        Me.FFT_Resolution.FormattingEnabled = True
        Me.FFT_Resolution.Items.AddRange(New Object() {"2500", "5000", "12500", "25000"})
        Me.FFT_Resolution.Location = New System.Drawing.Point(373, 87)
        Me.FFT_Resolution.Name = "FFT_Resolution"
        Me.FFT_Resolution.Size = New System.Drawing.Size(102, 21)
        Me.FFT_Resolution.TabIndex = 33
        Me.FFT_Resolution.Text = "FFT_Resolution"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(130, 317)
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(200, 42)
        Me.TrackBar1.TabIndex = 32
        Me.TrackBar1.Value = 1
        '
        'FFT_H_Display_Center_f
        '
        Me.FFT_H_Display_Center_f.Location = New System.Drawing.Point(373, 61)
        Me.FFT_H_Display_Center_f.Name = "FFT_H_Display_Center_f"
        Me.FFT_H_Display_Center_f.Size = New System.Drawing.Size(102, 20)
        Me.FFT_H_Display_Center_f.TabIndex = 31
        Me.FFT_H_Display_Center_f.Text = "20000"
        '
        'FFT_Channel_Select
        '
        Me.FFT_Channel_Select.FormattingEnabled = True
        Me.FFT_Channel_Select.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.FFT_Channel_Select.Location = New System.Drawing.Point(373, 7)
        Me.FFT_Channel_Select.Name = "FFT_Channel_Select"
        Me.FFT_Channel_Select.Size = New System.Drawing.Size(102, 21)
        Me.FFT_Channel_Select.TabIndex = 30
        Me.FFT_Channel_Select.Text = "FFT Channel"
        '
        'FFT_Window_Type
        '
        Me.FFT_Window_Type.FormattingEnabled = True
        Me.FFT_Window_Type.Items.AddRange(New Object() {"RECTangle", "BLACkman", "HANNing", "HAMMing", "FLATtop", "TRIangle"})
        Me.FFT_Window_Type.Location = New System.Drawing.Point(373, 34)
        Me.FFT_Window_Type.Name = "FFT_Window_Type"
        Me.FFT_Window_Type.Size = New System.Drawing.Size(102, 21)
        Me.FFT_Window_Type.TabIndex = 29
        Me.FFT_Window_Type.Text = "Window Type"
        '
        'FFT_GET_DATA
        '
        Me.FFT_GET_DATA.Location = New System.Drawing.Point(247, 288)
        Me.FFT_GET_DATA.Name = "FFT_GET_DATA"
        Me.FFT_GET_DATA.Size = New System.Drawing.Size(200, 23)
        Me.FFT_GET_DATA.TabIndex = 28
        Me.FFT_GET_DATA.Text = "Get FFT Data"
        Me.FFT_GET_DATA.UseVisualStyleBackColor = True
        '
        'Rigol_FFT_Data
        '
        Me.Rigol_FFT_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_FFT_Data.Location = New System.Drawing.Point(421, 107)
        Me.Rigol_FFT_Data.Name = "Rigol_FFT_Data"
        Me.Rigol_FFT_Data.Size = New System.Drawing.Size(121, 231)
        Me.Rigol_FFT_Data.TabIndex = 27
        '
        'Rigol_FFT_Chart
        '
        ChartArea1.Name = "ChartArea1"
        Me.Rigol_FFT_Chart.ChartAreas.Add(ChartArea1)
        Me.Rigol_FFT_Chart.Location = New System.Drawing.Point(10, 5)
        Me.Rigol_FFT_Chart.Name = "Rigol_FFT_Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.Rigol_FFT_Chart.Series.Add(Series1)
        Me.Rigol_FFT_Chart.Size = New System.Drawing.Size(424, 306)
        Me.Rigol_FFT_Chart.TabIndex = 26
        Me.Rigol_FFT_Chart.Text = "Chart1"
        '
        'RIGOL_FFT_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 350)
        Me.Controls.Add(Me.FFT_MouseOver_XValue)
        Me.Controls.Add(Me.FFT_H_Display_scale_f)
        Me.Controls.Add(Me.FFT_H_Display_Center_f_value)
        Me.Controls.Add(Me.FFT_WINDOWTYPE)
        Me.Controls.Add(Me.FFT_CH_SOURCE)
        Me.Controls.Add(Me.FFT_Resolution)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.FFT_H_Display_Center_f)
        Me.Controls.Add(Me.FFT_Channel_Select)
        Me.Controls.Add(Me.FFT_Window_Type)
        Me.Controls.Add(Me.FFT_GET_DATA)
        Me.Controls.Add(Me.Rigol_FFT_Data)
        Me.Controls.Add(Me.Rigol_FFT_Chart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RIGOL_FFT_FORM"
        Me.Text = "RIGOL_FFT_FORM"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_FFT_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_FFT_Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FFT_MouseOver_XValue As Label
    Friend WithEvents FFT_H_Display_scale_f As Label
    Friend WithEvents FFT_H_Display_Center_f_value As Label
    Friend WithEvents FFT_WINDOWTYPE As Label
    Friend WithEvents FFT_CH_SOURCE As Label
    Friend WithEvents FFT_Resolution As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents FFT_H_Display_Center_f As TextBox
    Friend WithEvents FFT_Channel_Select As ComboBox
    Friend WithEvents FFT_Window_Type As ComboBox
    Friend WithEvents FFT_GET_DATA As Button
    Friend WithEvents Rigol_FFT_Data As DataGridView
    Friend WithEvents Rigol_FFT_Chart As DataVisualization.Charting.Chart
End Class
