<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f9_inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MichoacanaDataSet = New michoacan_base.MichoacanaDataSet()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCod_pro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chbMostrar = New System.Windows.Forms.CheckBox()
        Me.chbBnom = New System.Windows.Forms.CheckBox()
        Me.chbBcod = New System.Windows.Forms.CheckBox()
        Me.chbBdes = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductoTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActnvend = New System.Windows.Forms.Button()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'MichoacanaDataSet
        '
        Me.MichoacanaDataSet.DataSetName = "MichoacanaDataSet"
        Me.MichoacanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "stock", True))
        Me.lblStock.Location = New System.Drawing.Point(685, 328)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(39, 13)
        Me.lblStock.TabIndex = 26
        Me.lblStock.Text = "Label6"
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.lbl_Precio.Location = New System.Drawing.Point(685, 296)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Precio.TabIndex = 25
        Me.lbl_Precio.Text = "Label5"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcion", True))
        Me.lblDesc.Location = New System.Drawing.Point(685, 262)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(39, 13)
        Me.lblDesc.TabIndex = 24
        Me.lblDesc.Text = "Label4"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.lblNombre.Location = New System.Drawing.Point(685, 228)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Label3"
        '
        'lblCod_pro
        '
        Me.lblCod_pro.AutoSize = True
        Me.lblCod_pro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cod_pro", True))
        Me.lblCod_pro.Location = New System.Drawing.Point(685, 195)
        Me.lblCod_pro.Name = "lblCod_pro"
        Me.lblCod_pro.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_pro.TabIndex = 22
        Me.lblCod_pro.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(112, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(218, 20)
        Me.txtBuscar.TabIndex = 20
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(358, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(218, 20)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'chbMostrar
        '
        Me.chbMostrar.AutoSize = True
        Me.chbMostrar.Location = New System.Drawing.Point(10, 44)
        Me.chbMostrar.Name = "chbMostrar"
        Me.chbMostrar.Size = New System.Drawing.Size(70, 17)
        Me.chbMostrar.TabIndex = 17
        Me.chbMostrar.Text = "Ver Todo"
        Me.chbMostrar.UseVisualStyleBackColor = True
        '
        'chbBnom
        '
        Me.chbBnom.AutoSize = True
        Me.chbBnom.Location = New System.Drawing.Point(10, 67)
        Me.chbBnom.Name = "chbBnom"
        Me.chbBnom.Size = New System.Drawing.Size(117, 17)
        Me.chbBnom.TabIndex = 31
        Me.chbBnom.Text = "Buscar por Nombre"
        Me.chbBnom.UseVisualStyleBackColor = True
        '
        'chbBcod
        '
        Me.chbBcod.AutoSize = True
        Me.chbBcod.Location = New System.Drawing.Point(10, 90)
        Me.chbBcod.Name = "chbBcod"
        Me.chbBcod.Size = New System.Drawing.Size(173, 17)
        Me.chbBcod.TabIndex = 32
        Me.chbBcod.Text = "Buscar por Codigo de producto"
        Me.chbBcod.UseVisualStyleBackColor = True
        '
        'chbBdes
        '
        Me.chbBdes.AutoSize = True
        Me.chbBdes.Location = New System.Drawing.Point(10, 113)
        Me.chbBdes.Name = "chbBdes"
        Me.chbBdes.Size = New System.Drawing.Size(136, 17)
        Me.chbBdes.TabIndex = 33
        Me.chbBdes.Text = "Buscar por Descripcion"
        Me.chbBdes.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(735, 375)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 55)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Actualizar Precio de producto"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(735, 436)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 53)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Actualizar Stock de producto"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 44)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 91)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Modificar Producto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(224, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 91)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Crear Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.michoacan_base.My.Resources.Resources.home
        Me.PictureBox2.Location = New System.Drawing.Point(888, 580)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(819, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Num_vend", True))
        Me.Label2.Location = New System.Drawing.Point(685, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Label6"
        '
        'btnActnvend
        '
        Me.btnActnvend.Location = New System.Drawing.Point(735, 495)
        Me.btnActnvend.Name = "btnActnvend"
        Me.btnActnvend.Size = New System.Drawing.Size(144, 53)
        Me.btnActnvend.TabIndex = 40
        Me.btnActnvend.Text = "Reiniciar Numero de Articulos Vendidos"
        Me.btnActnvend.UseVisualStyleBackColor = True
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(10, 149)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(669, 476)
        Me.ProductoDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_pro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cod_pro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "stock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "stock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Num_vend"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Num_vend"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'f9_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 637)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.btnActnvend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chbBdes)
        Me.Controls.Add(Me.chbBcod)
        Me.Controls.Add(Me.chbBnom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lbl_Precio)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCod_pro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.chbMostrar)
        Me.Name = "f9_inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MichoacanaDataSet As MichoacanaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As MichoacanaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As MichoacanaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblStock As Label
    Friend WithEvents lbl_Precio As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCod_pro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chbMostrar As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chbBnom As CheckBox
    Friend WithEvents chbBcod As CheckBox
    Friend WithEvents chbBdes As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnActnvend As Button
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
