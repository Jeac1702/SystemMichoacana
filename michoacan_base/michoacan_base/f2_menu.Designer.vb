<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f2_menu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnDfac = New System.Windows.Forms.Button()
        Me.btnFac = New System.Windows.Forms.Button()
        Me.btnDtic = New System.Windows.Forms.Button()
        Me.btnInv = New System.Windows.Forms.Button()
        Me.btnCli = New System.Windows.Forms.Button()
        Me.btnEmp = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Tickets"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(369, 417)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 36
        Me.btnLogout.Text = "Cerrar Sesion"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnDfac
        '
        Me.btnDfac.Location = New System.Drawing.Point(140, 340)
        Me.btnDfac.Name = "btnDfac"
        Me.btnDfac.Size = New System.Drawing.Size(135, 23)
        Me.btnDfac.TabIndex = 35
        Me.btnDfac.Text = "Datos de Facturas"
        Me.btnDfac.UseVisualStyleBackColor = True
        '
        'btnFac
        '
        Me.btnFac.Location = New System.Drawing.Point(140, 282)
        Me.btnFac.Name = "btnFac"
        Me.btnFac.Size = New System.Drawing.Size(135, 23)
        Me.btnFac.TabIndex = 34
        Me.btnFac.Text = "Facturar"
        Me.btnFac.UseVisualStyleBackColor = True
        '
        'btnDtic
        '
        Me.btnDtic.Location = New System.Drawing.Point(526, 340)
        Me.btnDtic.Name = "btnDtic"
        Me.btnDtic.Size = New System.Drawing.Size(135, 23)
        Me.btnDtic.TabIndex = 33
        Me.btnDtic.Text = "Datos de Tickets"
        Me.btnDtic.UseVisualStyleBackColor = True
        '
        'btnInv
        '
        Me.btnInv.Location = New System.Drawing.Point(140, 224)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(135, 23)
        Me.btnInv.TabIndex = 32
        Me.btnInv.Text = "Inventario"
        Me.btnInv.UseVisualStyleBackColor = True
        '
        'btnCli
        '
        Me.btnCli.Location = New System.Drawing.Point(334, 308)
        Me.btnCli.Name = "btnCli"
        Me.btnCli.Size = New System.Drawing.Size(139, 55)
        Me.btnCli.TabIndex = 31
        Me.btnCli.Text = "Registro de Clientes"
        Me.btnCli.UseVisualStyleBackColor = True
        '
        'btnEmp
        '
        Me.btnEmp.Location = New System.Drawing.Point(526, 224)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Size = New System.Drawing.Size(135, 23)
        Me.btnEmp.TabIndex = 30
        Me.btnEmp.Text = "Registro de Empleados"
        Me.btnEmp.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(334, 224)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(139, 55)
        Me.btnVenta.TabIndex = 29
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.HotPink
        Me.Label1.Location = New System.Drawing.Point(157, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 46)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Paleteria La Michoacana"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.PictureBox1.Location = New System.Drawing.Point(334, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'f2_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnDfac)
        Me.Controls.Add(Me.btnFac)
        Me.Controls.Add(Me.btnDtic)
        Me.Controls.Add(Me.btnInv)
        Me.Controls.Add(Me.btnCli)
        Me.Controls.Add(Me.btnEmp)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f2_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDfac As Button
    Friend WithEvents btnFac As Button
    Friend WithEvents btnDtic As Button
    Friend WithEvents btnInv As Button
    Friend WithEvents btnCli As Button
    Friend WithEvents btnEmp As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
