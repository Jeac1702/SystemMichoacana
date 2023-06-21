Public Class f20_actcli
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f20_actcli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MichoacanaDataSet.Cliente)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nom, ape, sex, tele, rfc, email, dir As String
        nom = txtNom.Text
        ape = txtApellido.Text
        sex = txtSexo.Text
        tele = txtTelefono.Text
        rfc = txtRfc.Text
        email = txtEmail.Text
        dir = txtDireccion.Text
        Me.ClienteTableAdapter.actualizarcliente(nom, ape, sex, tele, email, dir, rfc, cemp)
        MessageBox.Show("El registro se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNom.Text = ""
        txtApellido.Text = ""
        txtSexo.Text = ""
        txtTelefono.Text = ""
        txtRfc.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        f18_clientes.Show()
        Me.Close()
    End Sub
End Class