Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim target As Double = Rnd()
        Dim guess As Integer
        Do
            Label1.Text = target
            target = CInt(Int((100 * target) + 1))
            Label2.Text = target
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
