Public Class Signal_Gen_form


    Public SignalGen As Ivi.Visa.Interop.FormattedIO488
    Public SignalGenMgr As Ivi.Visa.Interop.ResourceManager

    Private Sub Signal_Gen_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInterface.SignalGeneratorToolStripMenuInstrument.Checked = True
        SigGenConfig()
    End Sub


    Private Sub Signal_Gen_form_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterface.SignalGeneratorToolStripMenuInstrument.Checked = False
    End Sub





    Public Sub SigGenConfig()
        SignalGenMgr = New Ivi.Visa.Interop.ResourceManager
        SignalGen = New Ivi.Visa.Interop.FormattedIO488

        'SignalGen_GPIB_address
        SignalGen.IO = SignalGenMgr.Open(("TCPIP0::" & UserInterface.GPIB_IP.Text & "::" & UserInterface.GPIB_BUSS.Text & "," & UserInterface.SignalGen_GPIB_address.Text & "::INSTR"))    ' 10 is the instr. address 


        '    SignalGen.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(SignalGen_gpib.Text) & "::INSTR"))    ' 10 is the instr. address 

    End Sub




    '    Signal Generator
    Private Sub SigGenPSU_ON()
        config_SigGen()
        SignalGen.WriteString("OUTPUT ON")
    End Sub

    Public Sub config_SigGen()
        SignalGen.WriteString("DISPLAY:TEXT:CLEAR")
        SignalGen.WriteString("OUTPUT:LOAD " & UserInterface.Reff_Imp.Text)
        SignalGen.WriteString("FUNC " & SigGen_Signal_Type.Text)
        SignalGen.WriteString("FREQ " & SigGen_Sine_freq.Text)
        SignalGen.WriteString("VOLT:UNIT " & SigGen_Amp_unit.Text)


        SignalGen.WriteString("VOLT " & SigGen_amp.Text)
    End Sub


    Public Sub SGFrequencyUpdate(freq As Integer)
        SignalGen.WriteString("FREQ " & freq)
        SigGen_FrequencyTrackBar.Value = freq
        SigGen_Sine_freq.Text = freq
    End Sub


    '   Duty Cycle Scrolle
    Private Sub SignalGenDutyCycle_Scroll(sender As Object, e As EventArgs) Handles SigGen_DutyCycle.Scroll
        If SigGen_Signal_Type.Text = "SQU" Then
            SignalGen.WriteString("FUNC:SQU:DCYC " & SigGen_DutyCycle.Value)
        ElseIf SigGen_Signal_Type.Text = "RAMP" Then
            SignalGen.WriteString("FUNC:RAMP:SYMM " & SigGen_DutyCycle.Value)
        Else


        End If
    End Sub

    Private Sub Sine_freq_TextChanged(sender As Object, e As EventArgs) Handles SigGen_Sine_freq.TextChanged

        If SigGen_FrequencyTrackBar.Value > 0 Then
            SigGen_FrequencyTrackBar.Value = SigGen_Sine_freq.Text
        End If
    End Sub

    Private Sub FrequencyTrackBar_Scroll(sender As Object, e As EventArgs) Handles SigGen_FrequencyTrackBar.Scroll
        SigGen_Sine_freq.Text = SigGen_FrequencyTrackBar.Value
        SignalGen.WriteString("FREQ " & SigGen_Sine_freq.Text)

    End Sub

    Public Sub FrequencyUpdate(freq As Integer)
        SignalGen.WriteString("FREQ " & freq)
        SigGen_FrequencyTrackBar.Value = freq
        SigGen_Sine_freq.Text = freq
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        FrequencyUpdate(100)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        FrequencyUpdate(1000)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        FrequencyUpdate(10000)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        FrequencyUpdate(100000)
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        FrequencyUpdate(10)
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        FrequencyUpdate(2000)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        FrequencyUpdate(5000)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        FrequencyUpdate(20000)
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        FrequencyUpdate(50000)
    End Sub

    Private Sub SigGen_Update_Click(sender As Object, e As EventArgs) Handles SigGen_Update.Click
        config_SigGen()
        SignalGen.WriteString("OUTPUT ON")
    End Sub
End Class