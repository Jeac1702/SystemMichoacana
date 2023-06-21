Public Class f13_actsto
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f13_actsto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim stock As Integer
        stock = txtStock.Text
        Me.ProductoTableAdapter.actStock(stock, cprod)
        MessageBox.Show("El Stock se actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtStock.Text = ""
        f9_inventario.Show()
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f9_inventario.Show()
        Me.Close()
    End Sub
End Class