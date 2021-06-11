Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As New Random
        UserControl11.Elements = (r.Next(1, 25))
        For i = 0 To UserControl11.Elements - 1
            UserControl11.Element(i) = (r.Next(1, 10))
        Next
    End Sub
End Class
