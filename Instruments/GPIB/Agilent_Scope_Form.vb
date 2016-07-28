Public Class Agilent_Scope_Form
    Public ScopeioMgr As Ivi.Visa.Interop.ResourceManager
    Public Ocilliscope As Ivi.Visa.Interop.FormattedIO488



    Private Sub Agilent_Scope_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommandList("Agilent_Scope_Form_Load")
        UserInterface.AgilentScopeToolStripMenuInstrument.Checked = True
        ScopeioMgr = New Ivi.Visa.Interop.ResourceManager
        Ocilliscope = New Ivi.Visa.Interop.FormattedIO488


        Ocilliscope.IO = ScopeioMgr.Open(("TCPIP0::" & UserInterface.GPIB_IP.Text & "::" & UserInterface.GPIB_BUSS.Text & "," & UserInterface.AgilentScopeGPIBaddress.Text & "::INSTR"))    ' 10 is the instr. address 


    End Sub

    Private Sub Agilent_Scope_Form_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        CommandList("Agilent_Scope_Form_Close")
        UserInterface.AgilentScopeToolStripMenuInstrument.Checked = False

    End Sub

    Private Sub Scope_Autoscale_Click(sender As Object, e As EventArgs) Handles Scope_Data.Click


        Ocilliscope.WriteString(":MEAS:VPP? CHAN1")
        SCOPE_Vpp_1.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:VRMS? CHAN1")
        SCOPE_Vrms_1.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:FREQ? CHAN1")
        SCOPE_FREQ_1.Text = CDbl(Ocilliscope.ReadString)
        SCOPE_dBm_1.Text = CDbl(10 * Math.Log10((CDbl(SCOPE_Vrms_1.Text) ^ 2) / CDbl(UserInterface.Reff_Imp.Text) / (0.001)))



        Ocilliscope.WriteString(":MEAS:VPP? CHAN2")
        SCOPE_Vpp_2.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:VRMS? CHAN2")
        SCOPE_Vrms_2.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:FREQ? CHAN2")
        SCOPE_FREQ_2.Text = CDbl(Ocilliscope.ReadString)
        SCOPE_dBm_2.Text = CDbl(10 * Math.Log10((CDbl(SCOPE_Vrms_2.Text) ^ 2) / CDbl(UserInterface.Reff_Imp.Text) / (0.001)))


        SCOPE_dBm_diff.Text = CDbl(SCOPE_dBm_2.Text) - CDbl(SCOPE_dBm_1.Text)
        Ocilliscope.WriteString(":MEAS:PHAS? CHAN1, CHAN2")
        SCOPE_Phase.Text = CDbl(Ocilliscope.ReadString)


    End Sub

    Private Sub scope_Autoscale_Click_1(sender As Object, e As EventArgs) Handles scope_Autoscale.Click
        Try
            Ocilliscope.WriteString("AUToscale")
        Catch ex As Exception

        End Try






    End Sub
End Class