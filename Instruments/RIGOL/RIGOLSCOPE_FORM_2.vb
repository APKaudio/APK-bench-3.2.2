Public Class RIGOLSCOPE_FORM_2
    Private Sub RIGOLSCOPE_FORM_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.Rigol_Channel2ToolStripMenuInstrument.Checked = True

    End Sub

    Private Sub RIGOLSCOPE_FORM_2_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterface.Rigol_Channel2ToolStripMenuInstrument.Checked = False
    End Sub

    Private Sub Rigol_update_CH2_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH2.Click
        CommandList("=======")
        RIGOL_Connecttoscope(2)
        Rigol_ReadandDisplay_CH2()

    End Sub


End Class