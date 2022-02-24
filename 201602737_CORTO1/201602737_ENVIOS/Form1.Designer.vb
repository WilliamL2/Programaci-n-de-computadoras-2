<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtmensajero = New System.Windows.Forms.TextBox()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rbtnnorte = New System.Windows.Forms.RadioButton()
        Me.Rbtnsur = New System.Windows.Forms.RadioButton()
        Me.Rbtnoriente = New System.Windows.Forms.RadioButton()
        Me.Rbtnoccidente = New System.Windows.Forms.RadioButton()
        Me.Rbtnvehiculo = New System.Windows.Forms.RadioButton()
        Me.Rbtnaccidente = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtmonto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mensajeria de Envios S.A."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del mensajero"
        '
        'Txtmensajero
        '
        Me.Txtmensajero.Location = New System.Drawing.Point(43, 135)
        Me.Txtmensajero.Name = "Txtmensajero"
        Me.Txtmensajero.Size = New System.Drawing.Size(144, 22)
        Me.Txtmensajero.TabIndex = 2
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(551, 268)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 6
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(551, 317)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 7
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(551, 366)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir.TabIndex = 8
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rbtnoccidente)
        Me.GroupBox1.Controls.Add(Me.Rbtnoriente)
        Me.GroupBox1.Controls.Add(Me.Rbtnsur)
        Me.GroupBox1.Controls.Add(Me.Rbtnnorte)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 143)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zona"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rbtnaccidente)
        Me.GroupBox2.Controls.Add(Me.Rbtnvehiculo)
        Me.GroupBox2.Location = New System.Drawing.Point(619, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 97)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seguro"
        '
        'Rbtnnorte
        '
        Me.Rbtnnorte.AutoSize = True
        Me.Rbtnnorte.Location = New System.Drawing.Point(18, 22)
        Me.Rbtnnorte.Name = "Rbtnnorte"
        Me.Rbtnnorte.Size = New System.Drawing.Size(64, 21)
        Me.Rbtnnorte.TabIndex = 0
        Me.Rbtnnorte.TabStop = True
        Me.Rbtnnorte.Text = "Norte"
        Me.Rbtnnorte.UseVisualStyleBackColor = True
        '
        'Rbtnsur
        '
        Me.Rbtnsur.AutoSize = True
        Me.Rbtnsur.Location = New System.Drawing.Point(18, 49)
        Me.Rbtnsur.Name = "Rbtnsur"
        Me.Rbtnsur.Size = New System.Drawing.Size(51, 21)
        Me.Rbtnsur.TabIndex = 1
        Me.Rbtnsur.TabStop = True
        Me.Rbtnsur.Text = "Sur"
        Me.Rbtnsur.UseVisualStyleBackColor = True
        '
        'Rbtnoriente
        '
        Me.Rbtnoriente.AutoSize = True
        Me.Rbtnoriente.Location = New System.Drawing.Point(18, 78)
        Me.Rbtnoriente.Name = "Rbtnoriente"
        Me.Rbtnoriente.Size = New System.Drawing.Size(76, 21)
        Me.Rbtnoriente.TabIndex = 2
        Me.Rbtnoriente.TabStop = True
        Me.Rbtnoriente.Text = "Oriente"
        Me.Rbtnoriente.UseVisualStyleBackColor = True
        '
        'Rbtnoccidente
        '
        Me.Rbtnoccidente.AutoSize = True
        Me.Rbtnoccidente.Location = New System.Drawing.Point(18, 105)
        Me.Rbtnoccidente.Name = "Rbtnoccidente"
        Me.Rbtnoccidente.Size = New System.Drawing.Size(93, 21)
        Me.Rbtnoccidente.TabIndex = 3
        Me.Rbtnoccidente.TabStop = True
        Me.Rbtnoccidente.Text = "Occidente"
        Me.Rbtnoccidente.UseVisualStyleBackColor = True
        '
        'Rbtnvehiculo
        '
        Me.Rbtnvehiculo.AutoSize = True
        Me.Rbtnvehiculo.Location = New System.Drawing.Point(0, 21)
        Me.Rbtnvehiculo.Name = "Rbtnvehiculo"
        Me.Rbtnvehiculo.Size = New System.Drawing.Size(83, 21)
        Me.Rbtnvehiculo.TabIndex = 0
        Me.Rbtnvehiculo.TabStop = True
        Me.Rbtnvehiculo.Text = "Vehiculo"
        Me.Rbtnvehiculo.UseVisualStyleBackColor = True
        '
        'Rbtnaccidente
        '
        Me.Rbtnaccidente.AutoSize = True
        Me.Rbtnaccidente.Location = New System.Drawing.Point(0, 61)
        Me.Rbtnaccidente.Name = "Rbtnaccidente"
        Me.Rbtnaccidente.Size = New System.Drawing.Size(91, 21)
        Me.Rbtnaccidente.TabIndex = 1
        Me.Rbtnaccidente.TabStop = True
        Me.Rbtnaccidente.Text = "Accidente"
        Me.Rbtnaccidente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Monto del envio"
        '
        'Txtmonto
        '
        Me.Txtmonto.Location = New System.Drawing.Point(200, 135)
        Me.Txtmonto.Name = "Txtmonto"
        Me.Txtmonto.Size = New System.Drawing.Size(144, 22)
        Me.Txtmonto.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txtmonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.Txtmensajero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtmensajero As TextBox
    Friend WithEvents Btncalcular As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rbtnoccidente As RadioButton
    Friend WithEvents Rbtnoriente As RadioButton
    Friend WithEvents Rbtnsur As RadioButton
    Friend WithEvents Rbtnnorte As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rbtnaccidente As RadioButton
    Friend WithEvents Rbtnvehiculo As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtmonto As TextBox
End Class
