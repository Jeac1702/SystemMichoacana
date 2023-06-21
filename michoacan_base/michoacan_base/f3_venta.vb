Public Class f3_venta
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f3_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)
            chbMostrar.Checked = False
        Else
            Me.ProductoTableAdapter.buscarProducto(Me.MichoacanaDataSet.Producto, valor)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f4_calcu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Numvend = lblNumvend.Text
        num = lblnum_tic.Text
        cprod = lblCod_pro.Text
        precioT = lblpre_tota.Text
        nprod = lblNombre.Text
        stock = lblStock.Text
        preuni = lbl_Precio.Text
        f7_agpro.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num = lblnum_tic.Text
        cclien = lblcod_cli.Text
        precioT = lblpre_tota.Text
        fecha = lblfecha.Text
        f8_imptick.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num = lblnum_tic.Text
        f6_editar.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f5_crearticket.Show()
        Me.Close()
    End Sub

    Private Sub lblnumtic_Click(sender As Object, e As EventArgs) Handles lblnum_tic.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub
End Class