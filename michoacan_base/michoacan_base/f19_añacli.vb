Public Class f19_añacli
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MichoacanaDataSet)

    End Sub

    Private Sub f19_añacli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MichoacanaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MichoacanaDataSet.Cliente)

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
        Me.ClienteTableAdapter.nuevocliente(nom, ape, sex, tele, email, dir, rfc)
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtSexo_TextChanged(sender As Object, e As EventArgs) Handles txtSexo.TextChanged

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtRfc_TextChanged(sender As Object, e As EventArgs) Handles txtRfc.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class