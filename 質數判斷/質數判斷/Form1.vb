Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Flag As Integer = 1
        Dim i As Integer = 2
        Do While ((Flag = 1) And (i < Val(TextBox1.Text)))
            If ((Val(TextBox1.Text) Mod i) = 0) Then
                Flag = 0
            End If
            i = i + 1
        Loop
        If (Flag = 1) Then
            TextBox2.Text = TextBox1.Text & "為質數"
        Else
            TextBox2.Text = TextBox1.Text & "不為質數"
        End If
    End Sub
End Class
