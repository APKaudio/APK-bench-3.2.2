<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Command_List_Form
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
        Me.Command_List_Box = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Command_List_Box
        '
        Me.Command_List_Box.FormattingEnabled = True
        Me.Command_List_Box.Location = New System.Drawing.Point(0, 0)
        Me.Command_List_Box.Name = "Command_List_Box"
        Me.Command_List_Box.Size = New System.Drawing.Size(339, 472)
        Me.Command_List_Box.TabIndex = 0
        '
        'Command_List_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 488)
        Me.Controls.Add(Me.Command_List_Box)
        Me.Name = "Command_List_Form"
        Me.Text = "Command_List_Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Command_List_Box As ListBox
End Class
