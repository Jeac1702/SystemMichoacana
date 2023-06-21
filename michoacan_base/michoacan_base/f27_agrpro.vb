Public Class f27_agrpro
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f27_agrpro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.detallefactura' Puede moverla o quitarla según sea necesario.
        Me.DetallefacturaTableAdapter.Fill(Me.MichoacanaDataSet.detallefactura)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.MichoacanaDataSet.Factura)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtcanpro.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtpreuni.TextChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nomb As String
        Dim numfac, codpro, cant, preuni As Integer
        Dim pretot, pretio, igv, toto As Double
        numfac = numfa
        codpro = txtcodpro.Text
        nomb = txtnompro.Text
        cant = txtcanpro.Text
        preuni = txtpreuni.Text
        pretot = txtpretot.Text
        pretio = txtpretot.Text + subtot
        igv = pretio * 0.16
        toto = pretio + igv
        Try
            Me.DetallefacturaTableAdapter.insertarproducto(numfac, codpro, nomb, cant, preuni, pretot)
            Me.FacturaTableAdapter.subtotal(pretio, igv, toto, numfa)
            MsgBox("REGISTRO ACTUALIZADO")
            f23_facturas.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("OCURRIO UN ERROR INESPERADO")
            f23_facturas.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f23_facturas.Show()
        Me.Close()
    End Sub
End Class