<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f22_dticket
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
        Me.MichoacanaDataSet = New michoacan_base.MichoacanaDataSet()
        Me.DetalleticketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleticketTableAdapter = New michoacan_base.MichoacanaDataSetTableAdapters.detalleticketTableAdapter()
        Me.TableAdapterManager = New michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager()
        Me.DetalleticketDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbFecha = New System.Windows.Forms.CheckBox()
        Me.chbNtic = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chbMostrar = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleticketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleticketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MichoacanaDataSet
        '
        Me.MichoacanaDataSet.DataSetName = "MichoacanaDataSet"
        Me.MichoacanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleticketBindingSource
        '
        Me.DetalleticketBindingSource.DataMember = "detalleticket"
        Me.DetalleticketBindingSource.DataSource = Me.MichoacanaDataSet
        '
        'DetalleticketTableAdapter
        '
        Me.DetalleticketTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.detallefacturaTableAdapter = Nothing
        Me.TableAdapterManager.detalleticketTableAdapter = Me.DetalleticketTableAdapter
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = michoacan_base.MichoacanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetalleticketDataGridView
        '
        Me.DetalleticketDataGridView.AutoGenerateColumns = False
        Me.DetalleticketDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DetalleticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleticketDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DetalleticketDataGridView.DataSource = Me.DetalleticketBindingSource
        Me.DetalleticketDataGridView.Location = New System.Drawing.Point(12, 138)
        Me.DetalleticketDataGridView.Name = "DetalleticketDataGridView"
        Me.DetalleticketDataGridView.Size = New System.Drawing.Size(650, 422)
        Me.DetalleticketDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "num_tic"
        Me.DataGridViewTextBoxColumn1.HeaderText = "num_tic"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_pro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_pro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "des_pro"
        Me.DataGridViewTextBoxColumn3.HeaderText = "des_pro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cant_pro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cant_pro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pre_unit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pre_unit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pre_venta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pre_venta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleticketBindingSource, "des_pro", True))
        Me.Label4.Location = New System.Drawing.Point(682, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleticketBindingSource, "cod_pro", True))
        Me.Label3.Location = New System.Drawing.Point(682, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleticketBindingSource, "num_tic", True))
        Me.Label2.Location = New System.Drawing.Point(682, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Label2"
        '
        'chbFecha
        '
        Me.chbFecha.AutoSize = True
        Me.chbFecha.Location = New System.Drawing.Point(12, 115)
        Me.chbFecha.Name = "chbFecha"
        Me.chbFecha.Size = New System.Drawing.Size(178, 17)
        Me.chbFecha.TabIndex = 75
        Me.chbFecha.Text = "Mostrar por Codigo del Producto"
        Me.chbFecha.UseVisualStyleBackColor = True
        '
        'chbNtic
        '
        Me.chbNtic.AutoSize = True
        Me.chbNtic.Location = New System.Drawing.Point(12, 79)
        Me.chbNtic.Name = "chbNtic"
        Me.chbNtic.Size = New System.Drawing.Size(165, 17)
        Me.chbNtic.TabIndex = 74
        Me.chbNtic.Text = "Buscar por Numero de Ticket"
        Me.chbNtic.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(114, 7)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(284, 20)
        Me.txtBuscar.TabIndex = 72
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(444, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(218, 117)
        Me.btnBuscar.TabIndex = 71
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'chbMostrar
        '
        Me.chbMostrar.AutoSize = True
        Me.chbMostrar.Location = New System.Drawing.Point(12, 46)
        Me.chbMostrar.Name = "chbMostrar"
        Me.chbMostrar.Size = New System.Drawing.Size(70, 17)
        Me.chbMostrar.TabIndex = 70
        Me.chbMostrar.Text = "Ver Todo"
        Me.chbMostrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleticketBindingSource, "pre_venta", True))
        Me.Label5.Location = New System.Drawing.Point(682, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleticketBindingSource, "pre_unit", True))
        Me.Label6.Location = New System.Drawing.Point(682, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleticketBindingSource, "cant_pro", True))
        Me.Label7.Location = New System.Drawing.Point(682, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Label7"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.michoacan_base.My.Resources.Resources.home
        Me.PictureBox2.Location = New System.Drawing.Point(819, 527)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(737, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'f22_dticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 572)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chbFecha)
        Me.Controls.Add(Me.chbNtic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.chbMostrar)
        Me.Controls.Add(Me.DetalleticketDataGridView)
        Me.Name = "f22_dticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles del Ticket"
        CType(Me.MichoacanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleticketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleticketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MichoacanaDataSet As MichoacanaDataSet
    Friend WithEvents DetalleticketBindingSource As BindingSource
    Friend WithEvents DetalleticketTableAdapter As MichoacanaDataSetTableAdapters.detalleticketTableAdapter
    Friend WithEvents TableAdapterManager As MichoacanaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetalleticketDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chbFecha As CheckBox
    Friend WithEvents chbNtic As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chbMostrar As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
