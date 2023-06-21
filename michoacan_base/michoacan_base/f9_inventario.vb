Public Class f9_inventario
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f9_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chbBcod.CheckedChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.ProductoTableAdapter.Fill(Me.MichoacanaDataSet.Producto)
            chbMostrar.Checked = False
        Else
            If chbBnom.Checked = True Then
                Me.ProductoTableAdapter.buscarProducto(Me.MichoacanaDataSet.Producto, valor)
                chbBnom.Checked = False
            Else
                If chbBcod.Checked = True Then
                    Me.ProductoTableAdapter.buscarCodigo(Me.MichoacanaDataSet.Producto, valor)
                Else
                    If chbBdes.Checked = True Then
                        Me.ProductoTableAdapter.buscarDesc(Me.MichoacanaDataSet.Producto, valor)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f10_Crearpro.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cprod = lblCod_pro.Text
        f11_Modtic.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cprod = lblCod_pro.Text
        f12_mpre.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cprod = lblCod_pro.Text
        f13_actsto.Show()
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub chbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrar.CheckedChanged

    End Sub

    Private Sub chbBnom_CheckedChanged(sender As Object, e As EventArgs) Handles chbBnom.CheckedChanged

    End Sub

    Private Sub chbBdes_CheckedChanged(sender As Object, e As EventArgs) Handles chbBdes.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnActnvend_Click(sender As Object, e As EventArgs) Handles btnActnvend.Click
        Numvend = Label2.Text
        cprod = lblCod_pro.Text
        Dim nvend As Integer
        nvend = 0
        Me.ProductoTableAdapter.numvend(nvend, cprod)
    End Sub
End Class