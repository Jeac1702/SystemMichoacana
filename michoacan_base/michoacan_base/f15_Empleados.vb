Public Class f15_Empleados
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        f2_menu.Show()
        Me.Close()
    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f15_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.MichoacanaDataSet.Empleado)

    End Sub

    Private Sub chbBcod_CheckedChanged(sender As Object, e As EventArgs) Handles chbBcod.CheckedChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txtBuscar.Text
        If chbMostrar.Checked = True Then
            Me.EmpleadoTableAdapter.Fill(Me.MichoacanaDataSet.Empleado)
            chbMostrar.Checked = False
        Else
            If chbBnom.Checked = True Then
                Me.EmpleadoTableAdapter.nom_emp(Me.MichoacanaDataSet.Empleado, valor)
                chbBnom.Checked = False
            Else
                If chbBcod.Checked = True Then
                    Me.EmpleadoTableAdapter.sex_emp(Me.MichoacanaDataSet.Empleado, valor)
                Else
                    If chbBdes.Checked = True Then
                        Me.EmpleadoTableAdapter.cod_emp(Me.MichoacanaDataSet.Empleado, valor)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cemp = Label2.Text
        f17_modemp.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f16_creemp.Show()
        Me.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'PrintPreviewDialog1.ShowDialog()
    'PrintDocument1.Print()
    'End Sub

    ' Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    'Dim bm As New Bitmap(Me.EmpleadoDataGridView.Width, Me.EmpleadoDataGridView.Height)
    'EmpleadoDataGridView.DrawToBitmap(bm, New Rectangle(3, 0, Me.EmpleadoDataGridView.Width, Me.EmpleadoDataGridView.Height))
    'e.Graphics.DrawImage(bm, 0, 0)
    ' End Sub
End Class