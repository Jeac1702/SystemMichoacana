Public Class f26tick
    Private Sub TicketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TicketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f26tick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.MichoacanaDataSet.ticket)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class