Public Class f24_crearfactura
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f24_crearfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.detallefactura' Puede moverla o quitarla según sea necesario.
        Me.DetallefacturaTableAdapter.Fill(Me.MichoacanaDataSet.detallefactura)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.MichoacanaDataSet.Factura)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cod_cli, rfc As String
        Dim subto, igv, total As Double

        cod_cli = txtcodcli.Text
        rfc = txtrfc.Text
        subto = 0
        igv = subto * 0.16
        total = subto + igv

        If cod_cli <> "" And rfc <> "" Then
            Me.FacturaTableAdapter.nuevafactura(cod_cli, rfc, subto, igv, total)
            MessageBox.Show("El registro se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcodcli.Text = ""
            txtrfc.Text = ""
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtcodcli_TextChanged(sender As Object, e As EventArgs) Handles txtcodcli.TextChanged

    End Sub

    Private Sub txtrfc_TextChanged(sender As Object, e As EventArgs) Handles txtrfc.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f23_facturas.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class