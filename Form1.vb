Public Class Form1
    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2MouseStateHandler1_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.HoverState
        Guna2Panel9.FillColor = Color.FromArgb(108, 93, 211)


    End Sub

    Private Sub Guna2MouseStateHandler1_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.IdleState

        Guna2Panel9.FillColor = Color.FromArgb(36, 39, 49)


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2MouseStateHandler1.Add(Guna2Panel9)
        Guna2MouseStateHandler2.Add(Guna2Panel10)
        Guna2MouseStateHandler3.Add(Guna2Panel11)
    End Sub

    Private Sub Guna2MouseStateHandler2_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler2.HoverState
        Guna2Panel10.FillColor = Color.FromArgb(108, 93, 211)
    End Sub

    Private Sub Guna2MouseStateHandler2_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler2.IdleState
        Guna2Panel10.FillColor = Color.FromArgb(36, 39, 49)
    End Sub

    Private Sub Guna2MouseStateHandler3_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler3.HoverState
        Guna2Panel11.FillColor = Color.FromArgb(108, 93, 211)
    End Sub

    Private Sub Guna2MouseStateHandler3_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler3.IdleState
        Guna2Panel11.FillColor = Color.FromArgb(36, 39, 49)
    End Sub
End Class
