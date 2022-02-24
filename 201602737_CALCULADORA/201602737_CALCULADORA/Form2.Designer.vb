<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmops
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Rbtnsuma = New System.Windows.Forms.RadioButton()
        Me.Rbtnresta = New System.Windows.Forms.RadioButton()
        Me.Rbtnmulti = New System.Windows.Forms.RadioButton()
        Me.Rbtndivi = New System.Windows.Forms.RadioButton()
        Me.Txtnum1 = New System.Windows.Forms.TextBox()
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btncalcular1 = New System.Windows.Forms.Button()
        Me.Btnlimpiar2 = New System.Windows.Forms.Button()
        Me.Btnsalir2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OPERACIONES SIMPLES"
        '
        'Rbtnsuma
        '
        Me.Rbtnsuma.AutoSize = True
        Me.Rbtnsuma.Location = New System.Drawing.Point(117, 103)
        Me.Rbtnsuma.Name = "Rbtnsuma"
        Me.Rbtnsuma.Size = New System.Drawing.Size(65, 21)
        Me.Rbtnsuma.TabIndex = 1
        Me.Rbtnsuma.TabStop = True
        Me.Rbtnsuma.Text = "Suma"
        Me.Rbtnsuma.UseVisualStyleBackColor = True
        '
        'Rbtnresta
        '
        Me.Rbtnresta.AutoSize = True
        Me.Rbtnresta.Location = New System.Drawing.Point(117, 159)
        Me.Rbtnresta.Name = "Rbtnresta"
        Me.Rbtnresta.Size = New System.Drawing.Size(66, 21)
        Me.Rbtnresta.TabIndex = 2
        Me.Rbtnresta.TabStop = True
        Me.Rbtnresta.Text = "Resta"
        Me.Rbtnresta.UseVisualStyleBackColor = True
        '
        'Rbtnmulti
        '
        Me.Rbtnmulti.AutoSize = True
        Me.Rbtnmulti.Location = New System.Drawing.Point(117, 217)
        Me.Rbtnmulti.Name = "Rbtnmulti"
        Me.Rbtnmulti.Size = New System.Drawing.Size(113, 21)
        Me.Rbtnmulti.TabIndex = 3
        Me.Rbtnmulti.TabStop = True
        Me.Rbtnmulti.Text = "Multiplicacion"
        Me.Rbtnmulti.UseVisualStyleBackColor = True
        '
        'Rbtndivi
        '
        Me.Rbtndivi.AutoSize = True
        Me.Rbtndivi.Location = New System.Drawing.Point(117, 268)
        Me.Rbtndivi.Name = "Rbtndivi"
        Me.Rbtndivi.Size = New System.Drawing.Size(78, 21)
        Me.Rbtndivi.TabIndex = 4
        Me.Rbtndivi.TabStop = True
        Me.Rbtndivi.Text = "Division"
        Me.Rbtndivi.UseVisualStyleBackColor = True
        '
        'Txtnum1
        '
        Me.Txtnum1.Location = New System.Drawing.Point(466, 115)
        Me.Txtnum1.Name = "Txtnum1"
        Me.Txtnum1.Size = New System.Drawing.Size(100, 22)
        Me.Txtnum1.TabIndex = 5
        '
        'Txtnum2
        '
        Me.Txtnum2.Location = New System.Drawing.Point(466, 195)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(100, 22)
        Me.Txtnum2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Numero 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Numero 2"
        '
        'Btncalcular1
        '
        Me.Btncalcular1.Location = New System.Drawing.Point(659, 193)
        Me.Btncalcular1.Name = "Btncalcular1"
        Me.Btncalcular1.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular1.TabIndex = 9
        Me.Btncalcular1.Text = "Calcular"
        Me.Btncalcular1.UseVisualStyleBackColor = True
        '
        'Btnlimpiar2
        '
        Me.Btnlimpiar2.Location = New System.Drawing.Point(659, 246)
        Me.Btnlimpiar2.Name = "Btnlimpiar2"
        Me.Btnlimpiar2.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar2.TabIndex = 10
        Me.Btnlimpiar2.Text = "Limpiar"
        Me.Btnlimpiar2.UseVisualStyleBackColor = True
        '
        'Btnsalir2
        '
        Me.Btnsalir2.Location = New System.Drawing.Point(659, 304)
        Me.Btnsalir2.Name = "Btnsalir2"
        Me.Btnsalir2.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir2.TabIndex = 11
        Me.Btnsalir2.Text = "Salir"
        Me.Btnsalir2.UseVisualStyleBackColor = True
        '
        'Frmops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnsalir2)
        Me.Controls.Add(Me.Btnlimpiar2)
        Me.Controls.Add(Me.Btncalcular1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtnum2)
        Me.Controls.Add(Me.Txtnum1)
        Me.Controls.Add(Me.Rbtndivi)
        Me.Controls.Add(Me.Rbtnmulti)
        Me.Controls.Add(Me.Rbtnresta)
        Me.Controls.Add(Me.Rbtnsuma)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmops"
        Me.Text = "Operaciones Simples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Rbtnsuma As RadioButton
    Friend WithEvents Rbtnresta As RadioButton
    Friend WithEvents Rbtnmulti As RadioButton
    Friend WithEvents Rbtndivi As RadioButton
    Friend WithEvents Txtnum1 As TextBox
    Friend WithEvents Txtnum2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btncalcular1 As Button
    Friend WithEvents Btnlimpiar2 As Button
    Friend WithEvents Btnsalir2 As Button
End Class
