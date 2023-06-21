Public Class f10_Crearpro
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f10_Crearpro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nom, des As String
        Dim pre, stock, Num_vend As Integer
        nom = txtNom.Text
        des = txtDes.Text
        pre = txtPre.Text
        stock = txtStock.Text
        Num_vend = 0
        Me.ProductoTableAdapter.nuevoProducto(nom, des, pre, stock, Num_vend)
        MessageBox.Show("El registro se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNom.Text = ""
        txtDes.Text = ""
        txtPre.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f9_inventario.Show()
        Me.Close()
    End Sub
End Class