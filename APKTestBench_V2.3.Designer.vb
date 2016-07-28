<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BUT_READ_DMM = New System.Windows.Forms.Button()
        Me.ReadValues = New System.Windows.Forms.Timer(Me.components)
        Me.TMRENA = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Measurement = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RIGOL_FFT_TOOLTIP = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstrumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RigolScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rigol_Channel1ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rigol_Channel2ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rigol_Channel3ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rigol_Channel4ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.I2CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.RigolFFTToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DMM1ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM2ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM3ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM4ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.PSU12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PSU34ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.AudioAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignalGeneratorToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgilentScopeToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgilentFFTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgilentNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPIBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPIB_IP = New System.Windows.Forms.ToolStripTextBox()
        Me.GPIB_BUSS = New System.Windows.Forms.ToolStripTextBox()
        Me.RIGOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIGOL_IP = New System.Windows.Forms.ToolStripTextBox()
        Me.ImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reff_Imp = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GPIBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPIBAddressToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgilentScopeGPIBaddress = New System.Windows.Forms.ToolStripTextBox()
        Me.AgilentFFTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DMM1ToolStripMenuItemConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM1_NAME = New System.Windows.Forms.ToolStripTextBox()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM_gpibaddress_1 = New System.Windows.Forms.ToolStripTextBox()
        Me.DMM2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM2_NAME = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM_gpibaddress_2 = New System.Windows.Forms.ToolStripTextBox()
        Me.DMM3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM3_NAME = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM_gpibaddress_3 = New System.Windows.Forms.ToolStripTextBox()
        Me.DMM4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM4_NAME = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMM_gpibaddress_4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PSUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPIBADDRESSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PSU_GPIB_ADDRESS = New System.Windows.Forms.ToolStripTextBox()
        Me.SignalGenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPIBAddressToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignalGen_GPIB_address = New System.Windows.Forms.ToolStripTextBox()
        Me.CommandBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(940, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 21)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "PSU OFF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(780, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "PSU READ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BUT_READ_DMM
        '
        Me.BUT_READ_DMM.Location = New System.Drawing.Point(721, 1)
        Me.BUT_READ_DMM.Name = "BUT_READ_DMM"
        Me.BUT_READ_DMM.Size = New System.Drawing.Size(53, 23)
        Me.BUT_READ_DMM.TabIndex = 3
        Me.BUT_READ_DMM.Text = "READ DMM"
        Me.BUT_READ_DMM.UseVisualStyleBackColor = True
        '
        'ReadValues
        '
        Me.ReadValues.Interval = 1000
        '
        'TMRENA
        '
        Me.TMRENA.Location = New System.Drawing.Point(585, 0)
        Me.TMRENA.Name = "TMRENA"
        Me.TMRENA.Size = New System.Drawing.Size(105, 23)
        Me.TMRENA.TabIndex = 3
        Me.TMRENA.Text = "START"
        Me.TMRENA.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(504, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Collect Data"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Measurement
        '
        Me.Measurement.Location = New System.Drawing.Point(315, 0)
        Me.Measurement.Name = "Measurement"
        Me.Measurement.Size = New System.Drawing.Size(183, 20)
        Me.Measurement.TabIndex = 10
        Me.Measurement.Text = "Measurement Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeviceToolStripMenuItem, Me.DataToolStripMenuItem, Me.InstrumentToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.CommandBoxToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1042, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DeviceToolStripMenuItem
        '
        Me.DeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveConfigToolStripMenuItem, Me.LoadConfigToolStripMenuItem, Me.ToolStripSeparator1})
        Me.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem"
        Me.DeviceToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.DeviceToolStripMenuItem.Text = "&File"
        '
        'SaveConfigToolStripMenuItem
        '
        Me.SaveConfigToolStripMenuItem.Name = "SaveConfigToolStripMenuItem"
        Me.SaveConfigToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveConfigToolStripMenuItem.Text = "Save Config"
        '
        'LoadConfigToolStripMenuItem
        '
        Me.LoadConfigToolStripMenuItem.Name = "LoadConfigToolStripMenuItem"
        Me.LoadConfigToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.LoadConfigToolStripMenuItem.Text = "Load Config"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'InstrumentToolStripMenuItem
        '
        Me.InstrumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RigolScopeToolStripMenuItem, Me.Rigol_Channel1ToolStripMenuInstrument, Me.Rigol_Channel2ToolStripMenuInstrument, Me.Rigol_Channel3ToolStripMenuInstrument, Me.Rigol_Channel4ToolStripMenuInstrument, Me.DecodeToolStripMenuItem, Me.ToolStripSeparator8, Me.RigolFFTToolStripMenuInstrument, Me.ToolStripSeparator9, Me.DMM1ToolStripMenuInstrument, Me.DMM2ToolStripMenuInstrument, Me.DMM3ToolStripMenuInstrument, Me.DMM4ToolStripMenuInstrument, Me.ToolStripSeparator10, Me.PSU12ToolStripMenuItem, Me.PSU34ToolStripMenuItem, Me.ToolStripSeparator11, Me.AudioAnalyzerToolStripMenuItem, Me.SignalGeneratorToolStripMenuInstrument, Me.ToolStripSeparator12, Me.AgilentScopeToolStripMenuInstrument, Me.AgilentFFTToolStripMenuItem1, Me.ToolStripSeparator13, Me.AgilentNetworkToolStripMenuItem})
        Me.InstrumentToolStripMenuItem.Name = "InstrumentToolStripMenuItem"
        Me.InstrumentToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.InstrumentToolStripMenuItem.Text = "&Instrument"
        '
        'RigolScopeToolStripMenuItem
        '
        Me.RigolScopeToolStripMenuItem.Name = "RigolScopeToolStripMenuItem"
        Me.RigolScopeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RigolScopeToolStripMenuItem.Text = "Rigol Scope"
        '
        'Rigol_Channel1ToolStripMenuInstrument
        '
        Me.Rigol_Channel1ToolStripMenuInstrument.Name = "Rigol_Channel1ToolStripMenuInstrument"
        Me.Rigol_Channel1ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.Rigol_Channel1ToolStripMenuInstrument.Text = "Channel 1"
        '
        'Rigol_Channel2ToolStripMenuInstrument
        '
        Me.Rigol_Channel2ToolStripMenuInstrument.Name = "Rigol_Channel2ToolStripMenuInstrument"
        Me.Rigol_Channel2ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.Rigol_Channel2ToolStripMenuInstrument.Text = "Channel 2"
        '
        'Rigol_Channel3ToolStripMenuInstrument
        '
        Me.Rigol_Channel3ToolStripMenuInstrument.Name = "Rigol_Channel3ToolStripMenuInstrument"
        Me.Rigol_Channel3ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.Rigol_Channel3ToolStripMenuInstrument.Text = "Channel 3"
        '
        'Rigol_Channel4ToolStripMenuInstrument
        '
        Me.Rigol_Channel4ToolStripMenuInstrument.Name = "Rigol_Channel4ToolStripMenuInstrument"
        Me.Rigol_Channel4ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.Rigol_Channel4ToolStripMenuInstrument.Text = "Channel 4"
        '
        'DecodeToolStripMenuItem
        '
        Me.DecodeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialToolStripMenuItem, Me.I2CToolStripMenuItem})
        Me.DecodeToolStripMenuItem.Name = "DecodeToolStripMenuItem"
        Me.DecodeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DecodeToolStripMenuItem.Text = "Decode"
        '
        'SerialToolStripMenuItem
        '
        Me.SerialToolStripMenuItem.Name = "SerialToolStripMenuItem"
        Me.SerialToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.SerialToolStripMenuItem.Text = "Serial"
        '
        'I2CToolStripMenuItem
        '
        Me.I2CToolStripMenuItem.Name = "I2CToolStripMenuItem"
        Me.I2CToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.I2CToolStripMenuItem.Text = "I2C"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(158, 6)
        '
        'RigolFFTToolStripMenuInstrument
        '
        Me.RigolFFTToolStripMenuInstrument.Name = "RigolFFTToolStripMenuInstrument"
        Me.RigolFFTToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.RigolFFTToolStripMenuInstrument.Text = "Rigol FFT"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(158, 6)
        '
        'DMM1ToolStripMenuInstrument
        '
        Me.DMM1ToolStripMenuInstrument.Name = "DMM1ToolStripMenuInstrument"
        Me.DMM1ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.DMM1ToolStripMenuInstrument.Text = "DMM 1"
        '
        'DMM2ToolStripMenuInstrument
        '
        Me.DMM2ToolStripMenuInstrument.Name = "DMM2ToolStripMenuInstrument"
        Me.DMM2ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.DMM2ToolStripMenuInstrument.Text = "DMM 2"
        '
        'DMM3ToolStripMenuInstrument
        '
        Me.DMM3ToolStripMenuInstrument.Name = "DMM3ToolStripMenuInstrument"
        Me.DMM3ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.DMM3ToolStripMenuInstrument.Text = "DMM 3"
        '
        'DMM4ToolStripMenuInstrument
        '
        Me.DMM4ToolStripMenuInstrument.Name = "DMM4ToolStripMenuInstrument"
        Me.DMM4ToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.DMM4ToolStripMenuInstrument.Text = "DMM 4"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(158, 6)
        '
        'PSU12ToolStripMenuItem
        '
        Me.PSU12ToolStripMenuItem.Name = "PSU12ToolStripMenuItem"
        Me.PSU12ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PSU12ToolStripMenuItem.Text = "PSU 1-2"
        '
        'PSU34ToolStripMenuItem
        '
        Me.PSU34ToolStripMenuItem.Name = "PSU34ToolStripMenuItem"
        Me.PSU34ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PSU34ToolStripMenuItem.Text = "PSU 3-4"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(158, 6)
        '
        'AudioAnalyzerToolStripMenuItem
        '
        Me.AudioAnalyzerToolStripMenuItem.Name = "AudioAnalyzerToolStripMenuItem"
        Me.AudioAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AudioAnalyzerToolStripMenuItem.Text = "Audio Analyzer"
        '
        'SignalGeneratorToolStripMenuInstrument
        '
        Me.SignalGeneratorToolStripMenuInstrument.Name = "SignalGeneratorToolStripMenuInstrument"
        Me.SignalGeneratorToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.SignalGeneratorToolStripMenuInstrument.Text = "Signal Generator"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(158, 6)
        '
        'AgilentScopeToolStripMenuInstrument
        '
        Me.AgilentScopeToolStripMenuInstrument.Name = "AgilentScopeToolStripMenuInstrument"
        Me.AgilentScopeToolStripMenuInstrument.Size = New System.Drawing.Size(161, 22)
        Me.AgilentScopeToolStripMenuInstrument.Text = "Agilent Scope"
        '
        'AgilentFFTToolStripMenuItem1
        '
        Me.AgilentFFTToolStripMenuItem1.Name = "AgilentFFTToolStripMenuItem1"
        Me.AgilentFFTToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.AgilentFFTToolStripMenuItem1.Text = "Agilent FFT"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(158, 6)
        '
        'AgilentNetworkToolStripMenuItem
        '
        Me.AgilentNetworkToolStripMenuItem.Name = "AgilentNetworkToolStripMenuItem"
        Me.AgilentNetworkToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AgilentNetworkToolStripMenuItem.Text = "Agilent Network"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IPAddressToolStripMenuItem, Me.ImpedanceToolStripMenuItem, Me.ToolStripSeparator7, Me.ToolStripSeparator2, Me.GPIBToolStripMenuItem, Me.AgilentFFTToolStripMenuItem, Me.ToolStripSeparator4, Me.DMM1ToolStripMenuItemConfig, Me.DMM2ToolStripMenuItem, Me.DMM3ToolStripMenuItem, Me.DMM4ToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.PSUToolStripMenuItem, Me.SignalGenToolStripMenuItem})
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.DevicesToolStripMenuItem.Text = "Config"
        '
        'IPAddressToolStripMenuItem
        '
        Me.IPAddressToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBToolStripMenuItem1, Me.GPIB_IP, Me.GPIB_BUSS, Me.RIGOLToolStripMenuItem, Me.RIGOL_IP})
        Me.IPAddressToolStripMenuItem.Name = "IPAddressToolStripMenuItem"
        Me.IPAddressToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IPAddressToolStripMenuItem.Text = "IP address"
        '
        'GPIBToolStripMenuItem1
        '
        Me.GPIBToolStripMenuItem1.Name = "GPIBToolStripMenuItem1"
        Me.GPIBToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.GPIBToolStripMenuItem1.Text = "GPIB:"
        '
        'GPIB_IP
        '
        Me.GPIB_IP.Name = "GPIB_IP"
        Me.GPIB_IP.Size = New System.Drawing.Size(100, 23)
        Me.GPIB_IP.Text = "169.254.58.10"
        '
        'GPIB_BUSS
        '
        Me.GPIB_BUSS.Name = "GPIB_BUSS"
        Me.GPIB_BUSS.Size = New System.Drawing.Size(100, 23)
        Me.GPIB_BUSS.Text = "gpib10"
        '
        'RIGOLToolStripMenuItem
        '
        Me.RIGOLToolStripMenuItem.Name = "RIGOLToolStripMenuItem"
        Me.RIGOLToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RIGOLToolStripMenuItem.Text = "RIGOL:"
        '
        'RIGOL_IP
        '
        Me.RIGOL_IP.Name = "RIGOL_IP"
        Me.RIGOL_IP.Size = New System.Drawing.Size(100, 23)
        Me.RIGOL_IP.Text = "192.168.11.76"
        '
        'ImpedanceToolStripMenuItem
        '
        Me.ImpedanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputImpedanceToolStripMenuItem, Me.OutputImpedanceToolStripMenuItem, Me.RefferenceToolStripMenuItem, Me.Reff_Imp})
        Me.ImpedanceToolStripMenuItem.Name = "ImpedanceToolStripMenuItem"
        Me.ImpedanceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImpedanceToolStripMenuItem.Text = "Impedance"
        '
        'InputImpedanceToolStripMenuItem
        '
        Me.InputImpedanceToolStripMenuItem.Name = "InputImpedanceToolStripMenuItem"
        Me.InputImpedanceToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.InputImpedanceToolStripMenuItem.Text = "Input Impedance"
        '
        'OutputImpedanceToolStripMenuItem
        '
        Me.OutputImpedanceToolStripMenuItem.Name = "OutputImpedanceToolStripMenuItem"
        Me.OutputImpedanceToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OutputImpedanceToolStripMenuItem.Text = "Output Impedance"
        '
        'RefferenceToolStripMenuItem
        '
        Me.RefferenceToolStripMenuItem.Name = "RefferenceToolStripMenuItem"
        Me.RefferenceToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.RefferenceToolStripMenuItem.Text = "Refference:"
        '
        'Reff_Imp
        '
        Me.Reff_Imp.Name = "Reff_Imp"
        Me.Reff_Imp.Size = New System.Drawing.Size(100, 23)
        Me.Reff_Imp.Text = "600"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'GPIBToolStripMenuItem
        '
        Me.GPIBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBAddressToolStripMenuItem1})
        Me.GPIBToolStripMenuItem.Name = "GPIBToolStripMenuItem"
        Me.GPIBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GPIBToolStripMenuItem.Text = "Agilent Scope"
        '
        'GPIBAddressToolStripMenuItem1
        '
        Me.GPIBAddressToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilentScopeGPIBaddress})
        Me.GPIBAddressToolStripMenuItem1.Name = "GPIBAddressToolStripMenuItem1"
        Me.GPIBAddressToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.GPIBAddressToolStripMenuItem1.Text = "GPIB Address"
        '
        'AgilentScopeGPIBaddress
        '
        Me.AgilentScopeGPIBaddress.Name = "AgilentScopeGPIBaddress"
        Me.AgilentScopeGPIBaddress.Size = New System.Drawing.Size(100, 23)
        Me.AgilentScopeGPIBaddress.Text = "7"
        '
        'AgilentFFTToolStripMenuItem
        '
        Me.AgilentFFTToolStripMenuItem.Name = "AgilentFFTToolStripMenuItem"
        Me.AgilentFFTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgilentFFTToolStripMenuItem.Text = "Agilent FFT"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'DMM1ToolStripMenuItemConfig
        '
        Me.DMM1ToolStripMenuItemConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM1_NAME, Me.NameToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.DMM1ToolStripMenuItemConfig.Name = "DMM1ToolStripMenuItemConfig"
        Me.DMM1ToolStripMenuItemConfig.Size = New System.Drawing.Size(152, 22)
        Me.DMM1ToolStripMenuItemConfig.Text = "DMM 1"
        '
        'DMM1_NAME
        '
        Me.DMM1_NAME.Name = "DMM1_NAME"
        Me.DMM1_NAME.Size = New System.Drawing.Size(100, 23)
        Me.DMM1_NAME.Text = "DMM1"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NameToolStripMenuItem.Text = "Name:"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "GPIB Address:"
        '
        'DMM_gpibaddress_1
        '
        Me.DMM_gpibaddress_1.Name = "DMM_gpibaddress_1"
        Me.DMM_gpibaddress_1.Size = New System.Drawing.Size(100, 23)
        Me.DMM_gpibaddress_1.Text = "1"
        '
        'DMM2ToolStripMenuItem
        '
        Me.DMM2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM2_NAME, Me.ToolStripMenuItem2})
        Me.DMM2ToolStripMenuItem.Name = "DMM2ToolStripMenuItem"
        Me.DMM2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DMM2ToolStripMenuItem.Text = "DMM2"
        '
        'DMM2_NAME
        '
        Me.DMM2_NAME.Name = "DMM2_NAME"
        Me.DMM2_NAME.Size = New System.Drawing.Size(100, 23)
        Me.DMM2_NAME.Text = "DMM2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_2})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem2.Text = "GPIB Address"
        '
        'DMM_gpibaddress_2
        '
        Me.DMM_gpibaddress_2.Name = "DMM_gpibaddress_2"
        Me.DMM_gpibaddress_2.Size = New System.Drawing.Size(100, 23)
        Me.DMM_gpibaddress_2.Text = "2"
        '
        'DMM3ToolStripMenuItem
        '
        Me.DMM3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM3_NAME, Me.ToolStripMenuItem3})
        Me.DMM3ToolStripMenuItem.Name = "DMM3ToolStripMenuItem"
        Me.DMM3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DMM3ToolStripMenuItem.Text = "DMM3"
        '
        'DMM3_NAME
        '
        Me.DMM3_NAME.Name = "DMM3_NAME"
        Me.DMM3_NAME.Size = New System.Drawing.Size(100, 23)
        Me.DMM3_NAME.Text = "DMM 3"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_3})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem3.Text = "GPIB Address"
        '
        'DMM_gpibaddress_3
        '
        Me.DMM_gpibaddress_3.Name = "DMM_gpibaddress_3"
        Me.DMM_gpibaddress_3.Size = New System.Drawing.Size(100, 23)
        Me.DMM_gpibaddress_3.Text = "3"
        '
        'DMM4ToolStripMenuItem
        '
        Me.DMM4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM4_NAME, Me.ToolStripMenuItem4})
        Me.DMM4ToolStripMenuItem.Name = "DMM4ToolStripMenuItem"
        Me.DMM4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DMM4ToolStripMenuItem.Text = "DMM4"
        '
        'DMM4_NAME
        '
        Me.DMM4_NAME.Name = "DMM4_NAME"
        Me.DMM4_NAME.Size = New System.Drawing.Size(100, 23)
        Me.DMM4_NAME.Text = "DMM 4"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_4})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem4.Text = "GPIB Address"
        '
        'DMM_gpibaddress_4
        '
        Me.DMM_gpibaddress_4.Name = "DMM_gpibaddress_4"
        Me.DMM_gpibaddress_4.Size = New System.Drawing.Size(100, 23)
        Me.DMM_gpibaddress_4.Text = "4"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(149, 6)
        '
        'PSUToolStripMenuItem
        '
        Me.PSUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBADDRESSToolStripMenuItem})
        Me.PSUToolStripMenuItem.Name = "PSUToolStripMenuItem"
        Me.PSUToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PSUToolStripMenuItem.Text = "PSU"
        '
        'GPIBADDRESSToolStripMenuItem
        '
        Me.GPIBADDRESSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PSU_GPIB_ADDRESS})
        Me.GPIBADDRESSToolStripMenuItem.Name = "GPIBADDRESSToolStripMenuItem"
        Me.GPIBADDRESSToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.GPIBADDRESSToolStripMenuItem.Text = "GPIB ADDRESS"
        '
        'PSU_GPIB_ADDRESS
        '
        Me.PSU_GPIB_ADDRESS.Name = "PSU_GPIB_ADDRESS"
        Me.PSU_GPIB_ADDRESS.Size = New System.Drawing.Size(100, 23)
        Me.PSU_GPIB_ADDRESS.Text = "6"
        '
        'SignalGenToolStripMenuItem
        '
        Me.SignalGenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBAddressToolStripMenuItem2})
        Me.SignalGenToolStripMenuItem.Name = "SignalGenToolStripMenuItem"
        Me.SignalGenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SignalGenToolStripMenuItem.Text = "Signal Gen"
        '
        'GPIBAddressToolStripMenuItem2
        '
        Me.GPIBAddressToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignalGen_GPIB_address})
        Me.GPIBAddressToolStripMenuItem2.Name = "GPIBAddressToolStripMenuItem2"
        Me.GPIBAddressToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.GPIBAddressToolStripMenuItem2.Text = "GPIB address"
        '
        'SignalGen_GPIB_address
        '
        Me.SignalGen_GPIB_address.Name = "SignalGen_GPIB_address"
        Me.SignalGen_GPIB_address.Size = New System.Drawing.Size(100, 23)
        Me.SignalGen_GPIB_address.Text = "8"
        '
        'CommandBoxToolStripMenuItem
        '
        Me.CommandBoxToolStripMenuItem.Name = "CommandBoxToolStripMenuItem"
        Me.CommandBoxToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.CommandBoxToolStripMenuItem.Text = "Command Box"
        '
        'UserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 873)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BUT_READ_DMM)
        Me.Controls.Add(Me.Measurement)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TMRENA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "UserInterface"
        Me.Text = "APKaudio Measurement System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BUT_READ_DMM As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ReadValues As Timer
    Friend WithEvents TMRENA As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button6 As Button
    Friend WithEvents Measurement As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RIGOL_FFT_TOOLTIP As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DMM1ToolStripMenuItemConfig As ToolStripMenuItem
    Friend WithEvents DMM2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DMM3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DMM4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPIBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AgilentFFTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DMM1_NAME As ToolStripTextBox
    Friend WithEvents DMM2_NAME As ToolStripTextBox
    Friend WithEvents DMM3_NAME As ToolStripTextBox
    Friend WithEvents DMM4_NAME As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents DMM_gpibaddress_2 As ToolStripTextBox
    Friend WithEvents DMM_gpibaddress_3 As ToolStripTextBox
    Friend WithEvents DMM_gpibaddress_4 As ToolStripTextBox
    Friend WithEvents IPAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPIBToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GPIB_IP As ToolStripTextBox
    Friend WithEvents GPIB_BUSS As ToolStripTextBox
    Friend WithEvents RIGOLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RIGOL_IP As ToolStripTextBox
    Friend WithEvents ImpedanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputImpedanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutputImpedanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Reff_Imp As ToolStripTextBox
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents NameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstrumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RigolScopeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Rigol_Channel1ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents Rigol_Channel2ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents Rigol_Channel3ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents Rigol_Channel4ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents DecodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents I2CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents RigolFFTToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents DMM1ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents DMM2ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents DMM3ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents DMM4ToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents PSU12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PSU34ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents AudioAnalyzerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignalGeneratorToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents AgilentScopeToolStripMenuInstrument As ToolStripMenuItem
    Friend WithEvents AgilentFFTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgilentNetworkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents CommandBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DMM_gpibaddress_1 As ToolStripTextBox
    Friend WithEvents PSUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPIBADDRESSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PSU_GPIB_ADDRESS As ToolStripTextBox
    Friend WithEvents GPIBAddressToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgilentScopeGPIBaddress As ToolStripTextBox
    Friend WithEvents SignalGenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPIBAddressToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SignalGen_GPIB_address As ToolStripTextBox
End Class
