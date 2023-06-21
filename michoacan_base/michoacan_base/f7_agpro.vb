Public Class f7_agpro
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim cpro, nstock As String
        Dim PreUini, PreVen, npret, nvend As Integer
        cpro = txtCpro.Text
        PreUini = preuni
        PreVen = preuni * cpro
        npret = precioT + PreVen
        nstock = stock - cpro
        nvend = Numvend + 1
        Try
            Me.ProductoTableAdapter.numvend(nvend, cpro)
            Me.ProductoTableAdapter.actStock(nstock, cprod)
            Me.TicketTableAdapter.actualizarPrecioT(npret, num)
            Me.DetalleticketTableAdapter.datosProducto(num, cprod, nprod, cpro, PreUini, PreVen)
            MsgBox("REGISTRO ACTUALIZADO")
            f3_venta.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("OCURRIO UN ERROR INESPERADO")
            f3_venta.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f7_agpro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.detalleticket' Puede moverla o quitarla según sea necesario.
        Me.DetalleticketTableAdapter.Fill(Me.MichoacanaDataSet.detalleticket)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        f3_venta.Show()
        Me.Close()
    End Sub
End Class