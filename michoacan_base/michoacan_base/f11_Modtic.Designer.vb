﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f11_Modtic
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
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPre = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MichoacanaDataSet = New michoacan_base.MichoacanaDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtVen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(354, 177)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(118, 42)
        Me.btnAtras.TabIndex = 40
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(156, 177)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAgregar.TabIndex = 39
        Me.btnAgregar.Text = "Modificar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(119, 105)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(415, 20)
        Me.txtStock.TabIndex = 38
        '
        'txtPre
        '
        Me.txtPre.Location = New System.Drawing.Point(119, 74)
        Me.txtPre.Name = "txtPre"
        Me.txtPre.Size = New System.Drawing.Size(415, 20)
        Me.txtPre.TabIndex = 37
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(119, 43)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(415, 20)
        Me.txtDes.TabIndex = 36
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(119, 11)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(415, 20)
        Me.txtNom.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Descripcion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nombre:"
        '
        'MichoacanaDataSet
        '
        Me.MichoacanaDataSet.DataSetName = "MichoacanaDataSet"
        Me.MichoacanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.detallefacturaTableAdapter = Nothing
        Me.TableAdapterManager.detalleticketTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(565, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'txtVen
        '
        Me.txtVen.Location = New System.Drawing.Point(119, 139)
        Me.txtVen.Name = "txtVen"
        Me.txtVen.Size = New System.Drawing.Size(415, 20)
        Me.txtVen.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Numero de vendidos:"
        '
        'f11_Modtic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 231)
        Me.Controls.Add(Me.txtVen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPre)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f11_Modtic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modiciar Ticket"
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPre As TextBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MichoacanaDataSet As MichoacanaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As MichoacanaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As MichoacanaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtVen As TextBox
    Friend WithEvents Label5 As Label
End Class
