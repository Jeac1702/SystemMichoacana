Public Class f14_veradmin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f2_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.EmpleadoTableAdapter.adminP(Me.MichoacanaDataSet.Empleado, txtadmin.Text, txtpas.Text) Then
            f15_Empleados.Show()
            Me.Close()
        Else
            MsgBox("Datos Incorrectos!!!")
        End If
    End Sub

    Private Sub txtpas_TextChanged(sender As Object, e As EventArgs) Handles txtpas.TextChanged

    End Sub

    Private Sub txtcodemp_TextChanged(sender As Object, e As EventArgs) Handles txtadmin.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f14_veradmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.MichoacanaDataSet.Empleado)

    End Sub
End Class