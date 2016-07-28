


Public Module DMM
    'This module is to control the Agilent 33401 DMM over GPIB bussing

    Public DMMMgr As Ivi.Visa.Interop.ResourceManager



    Public Structure DMMdata
        Dim Name As String ' This is the name of the device or the measurement you are taking
        Dim Mode As Integer  ' what type of measurement are you taking
        Dim ModeSCPI As String ' the string sent to configure the meter
        Dim Value As Double ' the current value being read
        Dim Engineering As String ' the value as engineering notatin
        Dim Units As String   'this could be used for Volts, Amps, Ohms,
        Dim dBm As Double ' displays the dBm refferenced to impedance
        Dim SCIP As Ivi.Visa.Interop.FormattedIO488 ' the format of the ooperationg for control
    End Structure

    Public DMM_CH(4) As DMMdata

    Public Sub DMMaddress(Channel As Integer)
        DMMMgr = New Ivi.Visa.Interop.ResourceManager
        DMM_CH(Channel).SCIP = New Ivi.Visa.Interop.FormattedIO488
        DMM_CH(Channel).SCIP.IO = DMMMgr.Open(("TCPIP0::" & UserInterface.GPIB_IP.Text & "::" & UserInterface.GPIB_BUSS.Text & "," & CDec(UserInterface.DMM_gpibaddress_1.Text) & "::INSTR"))    ' 10 is the instr. address 

    End Sub

    Public Sub DMM_Config(Channel As Integer)
        CommandList("DMM_Config")

        DMM_CH(Channel).ModeSCPI = ""
        '   DMM4.WriteString("*RST")

        If DMM_CH(Channel).Mode = 0 Then
            DMM_CH(Channel).ModeSCPI = "CONF:VOLT:DC"
            ' 1 I DC
        ElseIf DMM_CH(Channel).Mode = 1 Then
            DMM_CH(Channel).ModeSCPI = "CONF:CURR:DC"
            '2 V AC
        ElseIf DMM_CH(Channel).Mode = 2 Then
            DMM_CH(Channel).ModeSCPI = "CONF:VOLT:AC"
            '3 I AC
        ElseIf DMM_CH(Channel).Mode = 3 Then
            DMM_CH(Channel).ModeSCPI = "CONF:CURR:AC"
            '4 R 2W
        ElseIf DMM_CH(Channel).Mode = 4 Then
            DMM_CH(Channel).ModeSCPI = "CONF:RES"
            '5 R 4W
        ElseIf DMM_CH(Channel).Mode = 5 Then
            DMM_CH(Channel).ModeSCPI = "CONF:FRES"
            '6 Diode
        ElseIf DMM_CH(Channel).Mode = 6 Then
            DMM_CH(Channel).ModeSCPI = "CONF:DIODe"
            '7 Capacitance
        ElseIf DMM_CH(Channel).Mode = 7 Then
            DMM_CH(Channel).ModeSCPI = "CONF:FREQuency"
            '8 Freq
        ElseIf DMM_CH(Channel).Mode = 8 Then
            DMM_CH(Channel).ModeSCPI = "CONF:FREQuency"
            '9 Period
        ElseIf DMM_CH(Channel).Mode = 9 Then
            DMM_CH(Channel).ModeSCPI = "CONF:PERiod"
            '10 Continuity
        ElseIf DMM_CH(Channel).Mode = 10 Then
            DMM_CH(Channel).ModeSCPI = "CONF:CONTinuity"
        End If

        Try
            DMM_CH(Channel).SCIP.WriteString(DMM_CH(Channel).ModeSCPI)
        Catch ex As Exception

        End Try


    End Sub
    Public Sub DMM_Read(channel As Integer)

        Try

            DMM_CH(channel).SCIP.WriteString("READ?")
            DMM_CH(channel).Value = DMM_CH(channel).SCIP.ReadNumber()
            DMM_CH(channel).Engineering = CEngNotation(DMM_CH(channel).Value)
            'UPDATE DISPLAY


            'if it's Vac calculate dBm
            If DMM_CH(channel).Mode = 2 Then
                DMM_CH(channel).dBm = 10 * Math.Log10((CDbl((DMM_CH(channel).Value) ^ 2) / CDbl(UserInterface.Reff_Imp.Text)) / (0.001))
            Else
                DMM_CH(channel).dBm = ""
            End If
        Catch ex As Exception
            CommandList("DMM READ OFFLINE")
        End Try



    End Sub



    'Private Sub DMM_Value_1_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_1.DoubleClick
    '    DMM_Read_1()
    '    My.Computer.Clipboard.SetText(DMM_Value_1.Text)
    'End Sub

    'Private Sub DMM_Value_2_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_2.DoubleClick
    '    DMM_Read_2()
    '    My.Computer.Clipboard.SetText(DMM_Value_2.Text)
    'End Sub

    'Private Sub DMM_Value_3_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_3.DoubleClick
    '    DMM_Read_3()
    '    My.Computer.Clipboard.SetText(DMM_Value_3.Text)
    'End Sub

    'Private Sub DMM_Value_4_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_4.DoubleClick
    '    DMM_Read_4()
    '    My.Computer.Clipboard.SetText(DMM_Value_4.Text)
    'End Sub



End Module
