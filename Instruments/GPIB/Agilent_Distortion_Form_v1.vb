Public Class Agilent_Distortion_Form
    Private Sub Agilent_Distortion_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CommandList("Agilent_Distortion_Form_Load")
        UserInterface.AudioAnalyzerToolStripMenuItem.Checked = True
    End Sub

    Private Sub Agilent_Distortion_Form_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        CommandList("Agilent_Distortion_Form_close")
        UserInterface.AudioAnalyzerToolStripMenuItem.Checked = False
    End Sub
End Class