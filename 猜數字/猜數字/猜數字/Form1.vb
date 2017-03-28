Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim target As Integer = CInt(Int((100 * Rnd()) + 1))
        Dim guess As Integer
        Do
            guess = Val(InputBox("請輸入一數字"))
            If (target > guess) Then
                MsgBox("猜大一點")
            ElseIf (target < guess) Then
                MsgBox("猜小一點")
            Else
                MsgBox("猜中了")
            End If
        Loop While (target <> guess)
    End Sub
End Class
