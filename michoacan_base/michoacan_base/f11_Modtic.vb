Public Class f11_Modtic
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nom, des As String
        Dim pre, stock, vend As Integer
        nom = txtNom.Text
        des = txtDes.Text
        pre = txtPre.Text
        stock = txtStock.Text
        vend = txtVen.Text
        Me.ProductoTableAdapter.actpro(nom, des, pre, stock, vend, cprod)
        MessageBox.Show("El registro se actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNom.Text = ""
        txtDes.Text = ""
        txtPre.Text = ""
        txtStock.Text = ""
        f9_inventario.Show()
        Me.Close()
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f11_Modtic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f9_inventario.Show()
        Me.Close()
    End Sub
End Class