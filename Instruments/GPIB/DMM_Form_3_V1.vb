Public Class DMM_Form_3
    Private Sub DMM_Form_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.DMM3ToolStripMenuInstrument.Checked = True
    End Sub

    Private Sub DMM_Form_3_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        UserInterface.DMM3ToolStripMenuInstrument.Checked = False
    End Sub
End Class