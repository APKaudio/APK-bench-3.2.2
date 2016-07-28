Imports System.Windows.Forms.DataVisualization.Charting



Module Rigol_FFT

    Public ioManager As Ivi.Visa.Interop.ResourceManager

    Public RIGOL_MATH_FFT As Ivi.Visa.Interop.FormattedIO488

    Public Rigol_FFT_RAW_Data As String
    Public Rigol_FFT_SPLIT_Data() As String

    Public Rigol_FFT_DATA_TABLE As New DataTable("SCOPECH1")
    Public Rigol_FFT_DATA_SERIES As New Series


    Public Sub Rigol_FFT_Config()
        RIGOL_MATH_FFT = New Ivi.Visa.Interop.FormattedIO488
        ioManager = New Ivi.Visa.Interop.ResourceManager


        'Connecto to the scope
        Try
            RIGOL_MATH_FFT.IO = ioManager.Open("TCPIP0::" & UserInterface.RigolIPAddresFTP.Text & "::INSTR")    ' 10 is the instr. address 
            RIGOL_MATH_FFT.WriteString(":RUN")
            UserInterface.Rigol_FFT_Connect.BackColor = Color.Red
            Rigol_FFT_DATA_TABLE.Columns.Add("FFT DATA")
        Catch ex As Exception
            MsgBox("Could no Connect to " & UserInterface.RigolIPAddresFTP.Text & " Try again")
            UserInterface.Rigol_FFT_Connect.BackColor = Color.Transparent
        End Try






    End Sub

    Public Sub Get_FFT_data()
        FFTConfigure()
        FFTStatus()
        FFTGetDataFrom()
        FFTGraph()

    End Sub


    Public Sub FFTConfigure()
        RIGOL_MATH_FFT.WriteString(":MATH:DISPlay on")
        RIGOL_MATH_FFT.WriteString(":Math:Reset")

        RIGOL_MATH_FFT.WriteString(":MATH:OPERator FFT")

        Dim FFT_Channel_Selected As String = UserInterface.FFT_Channel_Select.SelectedItem.ToString()
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:SOURce CHAN" & FFT_Channel_Selected)

        Dim FFT_Window_type As String = UserInterface.FFT_Window_Type.SelectedItem.ToString()
        RIGOL_MATH_FFT.WriteString((":MATH:FFT:WINDow " & FFT_Window_type))
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:UNIT DB")

        'FFT_Resolution
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:HSCale " & UserInterface.FFT_Resolution.SelectedItem.ToString())
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:HCENter " & UserInterface.FFT_H_Display_Center_f.Text)
    End Sub

    Public Sub FFTStatus()
        '*****************Check values after they have been changed to confirm 

        'check source and display it
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:SOURce?")
        UserInterface.FFT_CH_SOURCE.Text = RIGOL_MATH_FFT.ReadString()


        'check FFT_H_Display_Center_f
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:HCENter?")
        UserInterface.FFT_H_Display_Center_f_value.Text = RIGOL_MATH_FFT.ReadString()

        'check :MATH:FFT:HSCale?

        RIGOL_MATH_FFT.WriteString(":Math:FFT:HSCale?")
        UserInterface.FFT_H_Display_scale_f.Text = RIGOL_MATH_FFT.ReadString()

        'check FFT_WINDOWTYPE
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:WINDow?")
        UserInterface.FFT_WINDOWTYPE.Text = RIGOL_MATH_FFT.ReadString()
    End Sub

    Public Sub FFTGetDataFrom()
        CommandList("FFT Get Data from WAVE")

        'Get data from FFT
        RIGOL_MATH_FFT.WriteString(":WAVeform:SOURce math ")
        RIGOL_MATH_FFT.WriteString(":WAVeform:FORmat ASCii")
        RIGOL_MATH_FFT.WriteString(":WAVeform:Data?")

        'Read the Data from the scope to local memory
        Rigol_FFT_RAW_Data = RIGOL_MATH_FFT.ReadString

        'Split up the Data
        Rigol_FFT_SPLIT_Data = Mid(Rigol_FFT_RAW_Data, 12).Split(",")

        Rigol_FFT_DATA_TABLE.Clear()


        Utilities.CommandList("Data Length " & Rigol_FFT_SPLIT_Data.Length)

        For I = 0 To ((Rigol_FFT_SPLIT_Data.Length) - 1)
            Rigol_FFT_DATA_TABLE.Rows.Add(Rigol_FFT_SPLIT_Data(I))
        Next I
        'Move datasouce to the table
        UserInterface.Rigol_FFT_Data.DataSource = Rigol_FFT_DATA_TABLE

    End Sub

    Public Sub FFTGraph()

        'GRAPH THE FFT OUT

        'Clear the chart
        UserInterface.Rigol_FFT_Chart.Series.Clear()

        'Cleat the series and name it
        Rigol_FFT_DATA_SERIES.Points.Clear()
        Rigol_FFT_DATA_SERIES.Name = "Scope FFT"

        'Change to a line graph.
        Rigol_FFT_DATA_SERIES.ChartType = SeriesChartType.Line
        Rigol_FFT_DATA_SERIES.Color = Color.DarkOrange

        'set the x axis to be a divison of 12 as on the screen
        'Kinda works        UserInterface.Rigol_FFT_Chart.ChartAreas(0).AxisX.Interval = (Rigol_FFT_SPLIT_Data.Length / 12) * (CInt(UserInterface.FFT_Resolution.SelectedItem.ToString()))


        Dim FFT_HZperDiv As Double = (CInt(UserInterface.FFT_Resolution.SelectedItem.ToString()))
        CommandList("FFT_HZperDiv") '& FFT_HZperDiv)

        Dim FFT_center_f As Double = (CInt(UserInterface.FFT_H_Display_Center_f.SelectedItem.ToString()))
        CommandList("FFT_center_f" & FFT_center_f)

        Dim FFT_starting_f As Double = FFT_center_f - (6 * FFT_HZperDiv)
        CommandList("FFT_starting_f" & FFT_starting_f)

        Dim FFT_ending_f As Double = FFT_center_f + (6 * FFT_HZperDiv)
        CommandList("FFT_ending_f" & FFT_ending_f)



        UserInterface.Rigol_FFT_Chart.ChartAreas(0).AxisX.Interval = scale

        Dim IncrimentofScale As Double = (scale * Rigol_FFT_SPLIT_Data.Length Mod 100)
        Dim FFT_starting_f As Integer = UserInterface.FFT_H_Display_Center_f


        'Loop to plot the data points
        For I = 0 To ((Rigol_FFT_SPLIT_Data.Length - 1))
            'Plot X and Y value
            Rigol_FFT_DATA_SERIES.Points.AddXY(
                (I + 1) * scale / 12, Rigol_FFT_SPLIT_Data(I))
        Next


        'Convert Series to a chart
        UserInterface.Rigol_FFT_Chart.Series.Add(Rigol_FFT_DATA_SERIES)


    End Sub


    Public Sub Rigol_FFT_Plot()




    End Sub
End Module
