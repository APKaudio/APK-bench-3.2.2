<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMM_Form_2
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
        Me.UPDATE = New System.Windows.Forms.Button()
        Me.DMM_dbm = New System.Windows.Forms.TextBox()
        Me.DMM_Value = New System.Windows.Forms.TextBox()
        Me.DMM_function = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(448, 6)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(65, 27)
        Me.UPDATE.TabIndex = 121
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'DMM_dbm
        '
        Me.DMM_dbm.Location = New System.Drawing.Point(359, 9)
        Me.DMM_dbm.Name = "DMM_dbm"
        Me.DMM_dbm.Size = New System.Drawing.Size(83, 20)
        Me.DMM_dbm.TabIndex = 120
        Me.DMM_dbm.Text = "DMM_dbm"
        '
        'DMM_Value
        '
        Me.DMM_Value.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMM_Value.Location = New System.Drawing.Point(69, 0)
        Me.DMM_Value.Name = "DMM_Value"
        Me.DMM_Value.Size = New System.Drawing.Size(289, 36)
        Me.DMM_Value.TabIndex = 119
        Me.DMM_Value.Text = "DMM_Value"
        '
        'DMM_function
        '
        Me.DMM_function.FormattingEnabled = True
        Me.DMM_function.Items.AddRange(New Object() {"V DC", "I DC", "V AC", "I AC", "R 2W", "R 4W", "Diode", "Capacitance", "Freq", "Period", "Continuity"})
        Me.DMM_function.Location = New System.Drawing.Point(0, 7)
        Me.DMM_function.Name = "DMM_function"
        Me.DMM_function.Size = New System.Drawing.Size(65, 21)
        Me.DMM_function.TabIndex = 118
        Me.DMM_function.Text = "Function"
        '
        'DMM_Form_2
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
        Me.Name = "DMM_Form_2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "DMM_Form_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UPDATE As Button
    Friend WithEvents DMM_dbm As TextBox
    Friend WithEvents DMM_Value As TextBox
    Friend WithEvents DMM_function As ComboBox
End Class
