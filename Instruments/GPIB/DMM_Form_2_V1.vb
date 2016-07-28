Public Class DMM_Form_2
    Private Sub DMM_Form_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.DMM2ToolStripMenuInstrument.Checked = True
    End Sub

    Private Sub DMM_Form_2_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        UserInterface.DMM2ToolStripMenuInstrument.Checked = False
    End Sub
End Class