<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm1
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
        Me.Btnseleccionar = New System.Windows.Forms.Button()
        Me.Btnlimpiar1 = New System.Windows.Forms.Button()
        Me.Btnsalir1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rbtnsimple = New System.Windows.Forms.RadioButton()
        Me.Rbtnvarias = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Btnseleccionar
        '
        Me.Btnseleccionar.Location = New System.Drawing.Point(635, 146)
        Me.Btnseleccionar.Name = "Btnseleccionar"
        Me.Btnseleccionar.Size = New System.Drawing.Size(113, 23)
        Me.Btnseleccionar.TabIndex = 0
        Me.Btnseleccionar.Text = "Seleccionar"
        Me.Btnseleccionar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar1
        '
        Me.Btnlimpiar1.Location = New System.Drawing.Point(635, 193)
        Me.Btnlimpiar1.Name = "Btnlimpiar1"
        Me.Btnlimpiar1.Size = New System.Drawing.Size(113, 23)
        Me.Btnlimpiar1.TabIndex = 1
        Me.Btnlimpiar1.Text = "Limpiar"
        Me.Btnlimpiar1.UseVisualStyleBackColor = True
        '
        'Btnsalir1
        '
        Me.Btnsalir1.Location = New System.Drawing.Point(635, 240)
        Me.Btnsalir1.Name = "Btnsalir1"
        Me.Btnsalir1.Size = New System.Drawing.Size(113, 23)
        Me.Btnsalir1.TabIndex = 2
        Me.Btnsalir1.Text = "Salir"
        Me.Btnsalir1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CALCULADORA GAMALIEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccione opcion a realizar"
        '
        'Rbtnsimple
        '
        Me.Rbtnsimple.AutoSize = True
        Me.Rbtnsimple.Location = New System.Drawing.Point(109, 146)
        Me.Rbtnsimple.Name = "Rbtnsimple"
        Me.Rbtnsimple.Size = New System.Drawing.Size(161, 21)
        Me.Rbtnsimple.TabIndex = 5
        Me.Rbtnsimple.TabStop = True
        Me.Rbtnsimple.Text = "Operaciones simples"
        Me.Rbtnsimple.UseVisualStyleBackColor = True
        '
        'Rbtnvarias
        '
        Me.Rbtnvarias.AutoSize = True
        Me.Rbtnvarias.Location = New System.Drawing.Point(109, 208)
        Me.Rbtnvarias.Name = "Rbtnvarias"
        Me.Rbtnvarias.Size = New System.Drawing.Size(152, 21)
        Me.Rbtnvarias.TabIndex = 6
        Me.Rbtnvarias.TabStop = True
        Me.Rbtnvarias.Text = "Operaciones varias"
        Me.Rbtnvarias.UseVisualStyleBackColor = True
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Rbtnvarias)
        Me.Controls.Add(Me.Rbtnsimple)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnsalir1)
        Me.Controls.Add(Me.Btnlimpiar1)
        Me.Controls.Add(Me.Btnseleccionar)
        Me.Name = "Frm1"
        Me.Text = "CALCULADORA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnseleccionar As Button
    Friend WithEvents Btnlimpiar1 As Button
    Friend WithEvents Btnsalir1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Rbtnsimple As RadioButton
    Friend WithEvents Rbtnvarias As RadioButton
End Class
