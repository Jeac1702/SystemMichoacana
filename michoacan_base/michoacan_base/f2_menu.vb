Public Class f2_menu
    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        f3_venta.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnInv.Click
        f9_inventario.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        f14_veradmin.Show()
        Me.Close()
    End Sub

    Private Sub btnCli_Click(sender As Object, e As EventArgs) Handles btnCli.Click
        f18_clientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f21_tickets.show()
        Me.Hide()
    End Sub

    Private Sub btnDtic_Click(sender As Object, e As EventArgs) Handles btnDtic.Click
        f22_dticket.show()
        Me.Close()
    End Sub

    Private Sub btnFac_Click(sender As Object, e As EventArgs) Handles btnFac.Click
        f23_facturas.Show()
        Me.Hide()
    End Sub

    Private Sub btnDfac_Click(sender As Object, e As EventArgs) Handles btnDfac.Click
        f29_dfac.Show()
        Me.Hide()
    End Sub
End Class