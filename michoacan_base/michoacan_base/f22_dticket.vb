Public Class f22_dticket
    Private Sub DetalleticketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DetalleticketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f22_dticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.DetalleticketTableAdapter.Fill(Me.MichoacanaDataSet.detalleticket)
            chbMostrar.Checked = False
        Else
            If chbNtic.Checked = True Then
                Me.DetalleticketTableAdapter.numtic(Me.MichoacanaDataSet.detalleticket, valor)
                chbNtic.Checked = False
            Else
                If chbFecha.Checked = True Then
                    Me.DetalleticketTableAdapter.codpro(Me.MichoacanaDataSet.detalleticket, valor)
                    chbFecha.Checked = False
                End If
            End If
        End If
    End Sub
End Class