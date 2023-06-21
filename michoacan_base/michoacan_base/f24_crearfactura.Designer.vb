<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f24_crearfactura
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
        Me.MichoacanaDataSet = New michoacan_base.MichoacanaDataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager = New michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager()
        Me.DetallefacturaTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.detallefacturaTableAdapter()
        Me.DetallefacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.ProductoTableAdapter()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallefacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MichoacanaDataSet
        '
        Me.MichoacanaDataSet.DataSetName = "MichoacanaDataSet"
        Me.MichoacanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.detallefacturaTableAdapter = Me.DetallefacturaTableAdapter
        Me.TableAdapterManager.detalleticketTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetallefacturaTableAdapter
        '
        Me.DetallefacturaTableAdapter.ClearBeforeFill = True
        '
        'DetallefacturaBindingSource
        '
        Me.DetallefacturaBindingSource.DataMember = "detallefactura"
        Me.DetallefacturaBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(571, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(341, 98)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(118, 42)
        Me.btnAtras.TabIndex = 78
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(175, 98)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAgregar.TabIndex = 77
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtrfc
        '
        Me.txtrfc.Location = New System.Drawing.Point(113, 44)
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(439, 20)
        Me.txtrfc.TabIndex = 74
        '
        'txtcodcli
        '
        Me.txtcodcli.Location = New System.Drawing.Point(113, 10)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.Size = New System.Drawing.Size(439, 20)
        Me.txtcodcli.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Rfc del cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Codigo del Cliente:"
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
        'f24_crearfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 152)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtrfc)
        Me.Controls.Add(Me.txtcodcli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f24_crearfactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Factura"
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallefacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MichoacanaDataSet As MichoacanaDataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As MichoacanaDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager As MichoacanaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetallefacturaTableAdapter As MichoacanaDataSetTableAdapters.detallefacturaTableAdapter
    Friend WithEvents DetallefacturaBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents txtcodcli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As MichoacanaDataSetTableAdapters.ProductoTableAdapter
End Class
