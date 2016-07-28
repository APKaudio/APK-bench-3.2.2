Public Class RIGOL_FFT_FORM
    Private Sub RIGOL_FFT_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.RigolFFTToolStripMenuInstrument.Checked = True

    End Sub

    Private Sub RIGOL_FFT_FORM_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterface.RigolFFTToolStripMenuInstrument.Checked = False


    End Sub
End Class