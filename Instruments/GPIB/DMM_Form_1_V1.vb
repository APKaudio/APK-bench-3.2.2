

Public Class DMM_Form_1
    Dim CHANNEL As Integer = 1


    Private Sub FormLoad() Handles Me.Load

        UserInterface.DMM1ToolStripMenuInstrument.Checked = True
        '     Me.Text = DMM_CH(CHANNEL).Name
        DMM_function.SelectedIndex = 0
        Try
            DMMaddress(CHANNEL)
        Catch ex As Exception
            CommandList("ERROR: FormLoad")
        End Try

    End Sub

    Private Sub FormClose() Handles Me.Closing
        UserInterface.DMM1ToolStripMenuInstrument.Checked = False
    End Sub



    Private Sub DMM_function_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function.SelectedIndexChanged
        DMM_CH(CHANNEL).Mode = Me.DMM_function.SelectedIndex
        DMM_Config((CHANNEL))
    End Sub

    Private Sub DMM_Value_1_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value.DoubleClick
        DMM_Read((CHANNEL))
        My.Computer.Clipboard.SetText(DMM_CH(CHANNEL).Value)
    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        DMM_Read((CHANNEL))
        DMM_Value.Text = DMM_CH(CHANNEL).Value
        DMM_dbm.Text = DMM_CH(CHANNEL).dBm
    End Sub

    Private Sub DMM_Value_TextChanged(sender As Object, e As EventArgs) Handles DMM_Value.TextChanged
        '   Me.DMM_Value.Text = DMM_CH(CHANNEL).Value
        '   Me.DMM_dbm.Text = DMM_CH(CHANNEL).dBm
    End Sub
End Class