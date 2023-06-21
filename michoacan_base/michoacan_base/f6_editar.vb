Public Class f6_editar
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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
        pre_tota = txtPrecioT.Text
        Try
            Me.TicketTableAdapter.actualizarTicket(cod_cli, pre_tota, fecha, num)
            MsgBox("REGISTRO ACTUALIZADO")
            f3_venta.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("OCURRIO UN ERROR INESPERADO")
            f3_venta.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub TicketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TicketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f6_editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)

    End Sub
End Class