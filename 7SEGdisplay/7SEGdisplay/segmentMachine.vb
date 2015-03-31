Public Class segmentMachine




    ' Checkbox actions

    Private Sub toggleActiveLow_CheckedChanged(sender As Object, e As System.EventArgs) Handles toggleActiveLow.CheckedChanged
        MsgBox("I'm annoying!")
    End Sub


    Private Sub toggleHex_CheckedChanged(sender As Object, e As System.EventArgs) Handles toggleHex.CheckedChanged
        MsgBox("You did it!")
    End Sub

    ' All the dirty seven-segment work

    Private Sub graphicSevenSeg_Click(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles graphicSevenSeg.Click
        ' Check if segA
        If ((e.X > 27 And e.X < 80) And (e.Y > 10 And e.Y < 20)) Then
            MsgBox("Segment A hit!")
            'Check if segB
        ElseIf ((e.X > 69 And e.X < 82) And (e.Y > 18 And e.Y < 58)) Then
            MsgBox("Segment B hit!")
            'Check if segC
        ElseIf ((e.X > 61 And e.X < 73) And (e.Y > 64 And e.Y < 108)) Then
            MsgBox("Segment C hit!")
            'Check if segD
        ElseIf ((e.X > 11 And e.X < 63) And (e.Y > 100 And e.Y < 111)) Then
            MsgBox("Segment D hit!")
            'Check if segE
        ElseIf ((e.X > 8 And e.X < 22) And (e.Y > 64 And e.Y < 86)) Then
            MsgBox("Segment E hit!")
            'Check if segF
        ElseIf ((e.X > 16 And e.X < 30) And (e.Y > 13 And e.Y < 60)) Then
            MsgBox("Segment F hit!")
            'Check if segG
        ElseIf ((e.X > 19 And e.X < 71) And (e.Y > 55 And e.Y < 66)) Then
            MsgBox("Segment G hit!")
            'Check if DP
        ElseIf ((e.X > 72 And e.X < 84) And (e.Y > 104 And e.Y < 116)) Then
            MsgBox("DP hit!")

        End If

    End Sub


End Class
