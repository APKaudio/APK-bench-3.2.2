Public Class DMM_Form_4
    Private Sub DMM_Form_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.DMM4ToolStripMenuInstrument.Checked = True
    End Sub

    Private Sub DMM_Form_4_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        UserInterface.DMM4ToolStripMenuInstrument.Checked = False
    End Sub
End Class