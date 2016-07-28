<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMM_Form_1
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
        Me.DMM_dbm = New System.Windows.Forms.TextBox()
        Me.DMM_Value = New System.Windows.Forms.TextBox()
        Me.DMM_function = New System.Windows.Forms.ComboBox()
        Me.UPDATE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DMM_dbm
        '
        Me.DMM_dbm.Location = New System.Drawing.Point(361, 9)
        Me.DMM_dbm.Name = "DMM_dbm"
        Me.DMM_dbm.Size = New System.Drawing.Size(83, 20)
        Me.DMM_dbm.TabIndex = 116
        Me.DMM_dbm.Text = "DMM_dbm"
        '
        'DMM_Value
        '
        Me.DMM_Value.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMM_Value.Location = New System.Drawing.Point(71, 0)
        Me.DMM_Value.Name = "DMM_Value"
        Me.DMM_Value.Size = New System.Drawing.Size(289, 36)
        Me.DMM_Value.TabIndex = 115
        Me.DMM_Value.Text = "DMM_Value"
        '
        'DMM_function
        '
        Me.DMM_function.FormattingEnabled = True
        Me.DMM_function.Items.AddRange(New Object() {"V DC", "I DC", "V AC", "I AC", "R 2W", "R 4W", "Diode", "Capacitance", "Freq", "Period", "Continuity"})
        Me.DMM_function.Location = New System.Drawing.Point(2, 7)
        Me.DMM_function.Name = "DMM_function"
        Me.DMM_function.Size = New System.Drawing.Size(65, 21)
        Me.DMM_function.TabIndex = 114
        Me.DMM_function.Text = "Function"
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(450, 6)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(65, 27)
        Me.UPDATE.TabIndex = 117
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'DMM_Form_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 33)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.DMM_dbm)
        Me.Controls.Add(Me.DMM_Value)
        Me.Controls.Add(Me.DMM_function)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DMM_Form_1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DMM 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DMM_dbm As TextBox
    Friend WithEvents DMM_Value As TextBox
    Friend WithEvents DMM_function As ComboBox
    Friend WithEvents UPDATE As Button
End Class
