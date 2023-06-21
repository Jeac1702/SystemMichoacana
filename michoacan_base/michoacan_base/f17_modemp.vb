Public Class f17_modemp
    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f17_modemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.MichoacanaDataSet.Empleado)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nom, ape, sex, tele, rfc, email, dir, pass As String
        nom = txtNom.Text
        ape = txtApellido.Text
        sex = txtSexo.Text
        tele = txtTelefono.Text
        rfc = txtRfc.Text
        email = txtEmail.Text
        dir = txtDireccion.Text
        pass = txtContra.Text
        Me.EmpleadoTableAdapter.upadteempleado(nom, ape, sex, tele, rfc, email, dir, pass, cemp)
        MessageBox.Show("El registro se actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNom.Text = ""
        txtApellido.Text = ""
        txtSexo.Text = ""
        txtTelefono.Text = ""
        txtRfc.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""
        txtContra.Text = ""
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f15_Empleados.Show()
        Me.Close()
    End Sub
End Class