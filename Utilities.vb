Module Utilities

    'This function Adds the commands listed to the command list box form
    Public Sub CommandList(WhatToAdd As String)
        Command_List_Form.Command_List_Box.Items.Add(WhatToAdd)
    End Sub



    Public Function CEngNotation(doubleValue As Double) As String
        Dim x As Double    ' --- Original Double (Floating-point)
        Dim y As Double    ' --- Mantissa
        Dim n As Long      ' --- Exponent
        Dim str As String
        Dim sign As String
        'On Error GoTo error_hander   ' --- uncomment for debug; disable when bug-free!
        x = doubleValue
        If x <> 0 Then
            If x < 0 Then
                ' --- x *must* be positive for log function to work
                x = x * -1
                sign = "-"    ' --- we need to preserve the sign for output string
            End If
            n = 3 * CLng((Math.Log(x) / Math.Log(1000)))   ' --- calculate Exponent...
            '     (Converts: log-base-e to log-base-10)
            y = x / (10 ^ n)                     ' --- calculate Mantissa.
            If y < 1 Then                        ' --- if Mantissa <1 then...
                n = n - 3                        ' --- ...adjust Exponent and...
                y = x / (10 ^ n)                 ' --- ...recalculate Mantissa.
            End If
            ' --- Create output string (special treatment when Exponent of zero; don't append "e")
            str = sign & y & IIf(n <> 0, "e" & IIf(n > 0, "+", "") & n, "")
        Else
            ' --- if the value is zero, well, return zero...
            str = "0"
        End If
        CEngNotation = str
        Exit Function
error_hander:
        ' --- this is really just for debugging suspected problems
        Resume Next
    End Function
End Module
