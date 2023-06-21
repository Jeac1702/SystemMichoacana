Public Class f21_tickets
    Private Sub TicketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TicketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f21_tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)
            chbMostrar.Checked = False
        Else
            If chbNtic.Checked = True Then
                Me.TicketTableAdapter.codcli(Me.MichoacanaDataSet.ticket, valor)
                chbNtic.Checked = False
            Else
                If chbFecha.Checked = True Then
                    Me.TicketTableAdapter.fecha(Me.MichoacanaDataSet.ticket, valor)
                    chbFecha.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub chbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrar.CheckedChanged

    End Sub

    Private Sub chbNtic_CheckedChanged(sender As Object, e As EventArgs) Handles chbNtic.CheckedChanged

    End Sub

    Private Sub chbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chbFecha.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class