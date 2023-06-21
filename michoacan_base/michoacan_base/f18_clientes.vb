Public Class f18_clientes
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f18_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MichoacanaDataSet.Cliente)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.ClienteTableAdapter.Fill(Me.MichoacanaDataSet.Cliente)
            chbMostrar.Checked = False
        Else
            If chbBnom.Checked = True Then
                Me.ClienteTableAdapter.nomcli(Me.MichoacanaDataSet.Cliente, valor)
                chbBnom.Checked = False
            Else
                If chbBcod.Checked = True Then
                    Me.ClienteTableAdapter.sexcli(Me.MichoacanaDataSet.Cliente, valor)
                Else
                    If chbBdes.Checked = True Then
                        Me.ClienteTableAdapter.codcli(Me.MichoacanaDataSet.Cliente, valor)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f19_añacli.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cemp = Label2.Text
        f20_actcli.Show()
        Me.Close()
    End Sub

    Private Sub ClienteDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteDataGridView.CellContentClick

    End Sub
End Class