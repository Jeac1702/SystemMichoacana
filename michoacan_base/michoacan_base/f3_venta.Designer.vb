<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f3_venta
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
        Me.TicketDataGridView = New System.Windows.Forms.DataGridView()
        Me.chbMostrar = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCod_pro = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblpre_tota = New System.Windows.Forms.Label()
        Me.lblcod_cli = New System.Windows.Forms.Label()
        Me.lblnum_tic = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductoDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MichoacanaDataSet = New michoacan_base.MichoacanaDataSet()
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager()
        Me.TicketTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.ticketTableAdapter()
        Me.lblNumvend = New System.Windows.Forms.Label()
        CType(Me.TicketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TicketDataGridView
        '
        Me.TicketDataGridView.AutoGenerateColumns = False
        Me.TicketDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TicketDataGridView.DataSource = Me.TicketBindingSource
        Me.TicketDataGridView.Location = New System.Drawing.Point(12, 419)
        Me.TicketDataGridView.Name = "TicketDataGridView"
        Me.TicketDataGridView.Size = New System.Drawing.Size(663, 220)
        Me.TicketDataGridView.TabIndex = 2
        '
        'chbMostrar
        '
        Me.chbMostrar.AutoSize = True
        Me.chbMostrar.Location = New System.Drawing.Point(12, 101)
        Me.chbMostrar.Name = "chbMostrar"
        Me.chbMostrar.Size = New System.Drawing.Size(70, 17)
        Me.chbMostrar.TabIndex = 3
        Me.chbMostrar.Text = "Ver Todo"
        Me.chbMostrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(114, 74)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(218, 44)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 110)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Calculadora"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 663)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 91)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Crear TIcket"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(188, 663)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 91)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Modificar Ticket"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(377, 663)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 91)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Agregar Producto al Carrito"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(559, 663)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 91)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Imprimir ticket"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(114, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(218, 20)
        Me.txtBuscar.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar por nombre:"
        '
        'lblCod_pro
        '
        Me.lblCod_pro.AutoSize = True
        Me.lblCod_pro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cod_pro", True))
        Me.lblCod_pro.Location = New System.Drawing.Point(695, 181)
        Me.lblCod_pro.Name = "lblCod_pro"
        Me.lblCod_pro.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_pro.TabIndex = 12
        Me.lblCod_pro.Text = "Label2"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.lblNombre.Location = New System.Drawing.Point(695, 214)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre.TabIndex = 13
        Me.lblNombre.Text = "Label3"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcion", True))
        Me.lblDesc.Location = New System.Drawing.Point(695, 248)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(39, 13)
        Me.lblDesc.TabIndex = 14
        Me.lblDesc.Text = "Label4"
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.lbl_Precio.Location = New System.Drawing.Point(695, 282)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Precio.TabIndex = 15
        Me.lbl_Precio.Text = "Label5"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "stock", True))
        Me.lblStock.Location = New System.Drawing.Point(695, 314)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(39, 13)
        Me.lblStock.TabIndex = 16
        Me.lblStock.Text = "Label6"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "fecha", True))
        Me.lblfecha.Location = New System.Drawing.Point(695, 578)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(39, 13)
        Me.lblfecha.TabIndex = 20
        Me.lblfecha.Text = "Label7"
        '
        'lblpre_tota
        '
        Me.lblpre_tota.AutoSize = True
        Me.lblpre_tota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "pre_tota", True))
        Me.lblpre_tota.Location = New System.Drawing.Point(695, 544)
        Me.lblpre_tota.Name = "lblpre_tota"
        Me.lblpre_tota.Size = New System.Drawing.Size(39, 13)
        Me.lblpre_tota.TabIndex = 19
        Me.lblpre_tota.Text = "Label8"
        '
        'lblcod_cli
        '
        Me.lblcod_cli.AutoSize = True
        Me.lblcod_cli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "cod_cli", True))
        Me.lblcod_cli.Location = New System.Drawing.Point(695, 510)
        Me.lblcod_cli.Name = "lblcod_cli"
        Me.lblcod_cli.Size = New System.Drawing.Size(39, 13)
        Me.lblcod_cli.TabIndex = 18
        Me.lblcod_cli.Text = "Label9"
        '
        'lblnum_tic
        '
        Me.lblnum_tic.AutoSize = True
        Me.lblnum_tic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "num_tic", True))
        Me.lblnum_tic.Location = New System.Drawing.Point(695, 477)
        Me.lblnum_tic.Name = "lblnum_tic"
        Me.lblnum_tic.Size = New System.Drawing.Size(45, 13)
        Me.lblnum_tic.TabIndex = 17
        Me.lblnum_tic.Text = "Label10"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.michoacan_base.My.Resources.Resources.home
        Me.PictureBox2.Location = New System.Drawing.Point(833, 753)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(739, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ProductoDataGridView1
        '
        Me.ProductoDataGridView1.AutoGenerateColumns = False
        Me.ProductoDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.ProductoDataGridView1.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView1.Location = New System.Drawing.Point(12, 163)
        Me.ProductoDataGridView1.Name = "ProductoDataGridView1"
        Me.ProductoDataGridView1.Size = New System.Drawing.Size(663, 220)
        Me.ProductoDataGridView1.TabIndex = 30
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cod_pro"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cod_pro"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn11.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn13.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "stock"
        Me.DataGridViewTextBoxColumn14.HeaderText = "stock"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Num_vend"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Num_vend"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
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
        'TicketBindingSource
        '
        Me.TicketBindingSource.DataMember = "ticket"
        Me.TicketBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "num_tic"
        Me.DataGridViewTextBoxColumn6.HeaderText = "num_tic"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_cli"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cod_cli"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pre_tota"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pre_tota"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
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
        Me.TableAdapterManager.ticketTableAdapter = Me.TicketTableAdapter
        Me.TableAdapterManager.UpdateOrder = michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TicketTableAdapter
        '
        Me.TicketTableAdapter.ClearBeforeFill = True
        '
        'lblNumvend
        '
        Me.lblNumvend.AutoSize = True
        Me.lblNumvend.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Num_vend", True))
        Me.lblNumvend.Location = New System.Drawing.Point(695, 349)
        Me.lblNumvend.Name = "lblNumvend"
        Me.lblNumvend.Size = New System.Drawing.Size(39, 13)
        Me.lblNumvend.TabIndex = 31
        Me.lblNumvend.Text = "Label6"
        '
        'f3_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 811)
        Me.Controls.Add(Me.lblNumvend)
        Me.Controls.Add(Me.ProductoDataGridView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblpre_tota)
        Me.Controls.Add(Me.lblcod_cli)
        Me.Controls.Add(Me.lblnum_tic)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lbl_Precio)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCod_pro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.chbMostrar)
        Me.Controls.Add(Me.TicketDataGridView)
        Me.Name = "f3_venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.TicketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MichoacanaDataSet As MichoacanaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As MichoacanaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As MichoacanaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TicketTableAdapter As MichoacanaDataSetTableAdapters.ticketTableAdapter
    Friend WithEvents TicketBindingSource As BindingSource
    Friend WithEvents TicketDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents chbMostrar As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCod_pro As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lbl_Precio As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblpre_tota As Label
    Friend WithEvents lblcod_cli As Label
    Friend WithEvents lblnum_tic As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProductoDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents lblNumvend As Label
End Class
