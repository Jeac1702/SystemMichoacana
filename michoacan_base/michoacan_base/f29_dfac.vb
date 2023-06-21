Public Class f29_dfac
    Private Sub DetalleticketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DetalleticketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f29_dfac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.detallefactura' Puede moverla o quitarla según sea necesario.
        Me.DetallefacturaTableAdapter.Fill(Me.MichoacanaDataSet.detallefactura)
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.detalleticket' Puede moverla o quitarla según sea necesario.
        Me.DetalleticketTableAdapter.Fill(Me.MichoacanaDataSet.detalleticket)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.DetallefacturaTableAdapter.Fill(Me.MichoacanaDataSet.detallefactura)
            chbMostrar.Checked = False
        Else
            If chbNtic.Checked = True Then
                Me.DetallefacturaTableAdapter.numfac(Me.MichoacanaDataSet.detallefactura, valor)
                chbNtic.Checked = False
            Else
                If chbFecha.Checked = True Then
                    Me.DetallefacturaTableAdapter.codpro(Me.MichoacanaDataSet.detallefactura, valor)
                    chbFecha.Checked = False
                End If
            End If
        End If
    End Sub
End Class