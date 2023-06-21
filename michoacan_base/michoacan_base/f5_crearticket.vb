Public Class f5_crearticket
    Private Sub TicketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TicketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f5_crearticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        f3_venta.Show()
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim cod_cli, fecha As String
        Dim pre_tota As Integer

        cod_cli = txtCod_cli.Text
        fecha = txtFecha.Text
        pre_tota = 0

        If cod_cli <> "" And fecha <> "" Then
            Me.TicketTableAdapter.nuevoTicket(cod_cli, pre_tota, fecha)
            MessageBox.Show("El registro se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCod_cli.Text = ""
            txtFecha.Text = ""
        End If
    End Sub
End Class