﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f16_creemp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MichoacanaDataSet = New michoacan_base.MichoacanaDataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.EmpleadoTableAdapter()
        Me.TableAdapterManager = New michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(341, 288)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(118, 42)
        Me.btnAtras.TabIndex = 40
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(156, 288)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAgregar.TabIndex = 39
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(95, 107)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(439, 20)
        Me.txtTelefono.TabIndex = 38
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(95, 76)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(439, 20)
        Me.txtSexo.TabIndex = 37
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(95, 45)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(439, 20)
        Me.txtApellido.TabIndex = 36
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(95, 13)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(439, 20)
        Me.txtNom.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Sexo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nombre(s):"
        '
        'MichoacanaDataSet
        '
        Me.MichoacanaDataSet.DataSetName = "MichoacanaDataSet"
        Me.MichoacanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.detallefacturaTableAdapter = Nothing
        Me.TableAdapterManager.detalleticketTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "RFC:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Direccion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Contraseña:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(335, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 46
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(95, 141)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(439, 20)
        Me.txtRfc.TabIndex = 47
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(95, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(439, 20)
        Me.txtEmail.TabIndex = 48
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(95, 206)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(439, 20)
        Me.txtDireccion.TabIndex = 49
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(95, 235)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(439, 20)
        Me.txtContra.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(565, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'f16_creemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 343)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f16_creemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Empleado"
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MichoacanaDataSet As MichoacanaDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As MichoacanaDataSetTableAdapters.EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As MichoacanaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtContra As TextBox
End Class
