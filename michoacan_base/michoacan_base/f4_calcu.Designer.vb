<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f4_calcu
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.BtnDivision = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(152, 194)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 32
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(291, 144)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(81, 23)
        Me.btnMulti.TabIndex = 31
        Me.btnMulti.Text = "Multiplicacion"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'BtnDivision
        '
        Me.BtnDivision.Location = New System.Drawing.Point(200, 144)
        Me.BtnDivision.Name = "BtnDivision"
        Me.BtnDivision.Size = New System.Drawing.Size(75, 23)
        Me.BtnDivision.TabIndex = 30
        Me.BtnDivision.Text = "Division"
        Me.BtnDivision.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(110, 144)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 23)
        Me.btnResta.TabIndex = 29
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(19, 144)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 23)
        Me.btnSuma.TabIndex = 28
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(97, 98)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(275, 20)
        Me.txtRes.TabIndex = 27
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(97, 58)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(275, 20)
        Me.txtNum2.TabIndex = 26
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(96, 16)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(276, 20)
        Me.txtNum1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Respuesta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Numero 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Numero 1:"
        '
        'f4_calcu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.michoacan_base.My.Resources.Resources.michoacana
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(405, 232)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.BtnDivision)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "f4_calcu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents BtnDivision As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents txtRes As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
