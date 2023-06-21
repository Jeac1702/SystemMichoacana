Public Class f23_facturas
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f23_facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.MichoacanaDataSet.Factura)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.FacturaTableAdapter.Fill(Me.MichoacanaDataSet.Factura)
            chbMostrar.Checked = False
        Else
            If chbNtic.Checked = True Then
                Me.FacturaTableAdapter.codcli(Me.MichoacanaDataSet.Factura, valor)
                chbNtic.Checked = False
            Else
                If chbFecha.Checked = True Then
                    Me.FacturaTableAdapter.numfac(Me.MichoacanaDataSet.Factura, valor)
                    chbFecha.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f25_dtick.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        f26tick.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f24_crearfactura.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numfa = Label2.Text
        subtot = Label7.Text
        f27_agrpro.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lbl2 = Label2.Text
        lbl3 = Label3.Text
        lbl4 = Label4.Text
        lbl7 = Label7.Text
        lbl6 = Label6.Text
        lbl5 = Label5.Text
        f28_impfac.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub
End Class