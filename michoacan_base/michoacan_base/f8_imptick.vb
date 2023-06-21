Public Class f8_imptick
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblPt_Click(sender As Object, e As EventArgs) Handles lblPt.Click

    End Sub

    Private Sub lblNc_Click(sender As Object, e As EventArgs) Handles lblNc.Click

    End Sub

    Private Sub lblcdt_Click(sender As Object, e As EventArgs) Handles lblcdt.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblFc_Click(sender As Object, e As EventArgs) Handles lblFc.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub f8_imptick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcdt.Text = num
        lblNc.Text = cclien
        lblFc.Text = precioT
        lblPt.Text = fecha
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
        Me.Close()
    End Sub
End Class