Public Class f12_mpre
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f12_mpre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f9_inventario.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim pre As Integer
        pre = txtPre.Text
        Me.ProductoTableAdapter.actpre(pre, cprod)
        MessageBox.Show("El Precio se actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtPre.Text = ""
        f9_inventario.Show()
        Me.Close()
    End Sub

    Private Sub txtPre_TextChanged(sender As Object, e As EventArgs) Handles txtPre.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class