<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmva
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
        Me.Txtvar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rbtncuadrado = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rbtnraiz = New System.Windows.Forms.RadioButton()
        Me.Rbtnseno = New System.Windows.Forms.RadioButton()
        Me.Rbtncoseno = New System.Windows.Forms.RadioButton()
        Me.Btncalcular2 = New System.Windows.Forms.Button()
        Me.Btnlimpiar3 = New System.Windows.Forms.Button()
        Me.Btnsalir3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtvar
        '
        Me.Txtvar.Location = New System.Drawing.Point(461, 169)
        Me.Txtvar.Name = "Txtvar"
        Me.Txtvar.Size = New System.Drawing.Size(100, 22)
        Me.Txtvar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operaciones varias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese cantidad"
        '
        'Rbtncuadrado
        '
        Me.Rbtncuadrado.AutoSize = True
        Me.Rbtncuadrado.Location = New System.Drawing.Point(133, 156)
        Me.Rbtncuadrado.Name = "Rbtncuadrado"
        Me.Rbtncuadrado.Size = New System.Drawing.Size(150, 21)
        Me.Rbtncuadrado.TabIndex = 3
        Me.Rbtncuadrado.TabStop = True
        Me.Rbtncuadrado.Text = "Potencia Cuadrado"
        Me.Rbtncuadrado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Operacion"
        '
        'Rbtnraiz
        '
        Me.Rbtnraiz.AutoSize = True
        Me.Rbtnraiz.Location = New System.Drawing.Point(133, 200)
        Me.Rbtnraiz.Name = "Rbtnraiz"
        Me.Rbtnraiz.Size = New System.Drawing.Size(121, 21)
        Me.Rbtnraiz.TabIndex = 5
        Me.Rbtnraiz.TabStop = True
        Me.Rbtnraiz.Text = "Raiz cuadrada"
        Me.Rbtnraiz.UseVisualStyleBackColor = True
        '
        'Rbtnseno
        '
        Me.Rbtnseno.AutoSize = True
        Me.Rbtnseno.Location = New System.Drawing.Point(133, 245)
        Me.Rbtnseno.Name = "Rbtnseno"
        Me.Rbtnseno.Size = New System.Drawing.Size(62, 21)
        Me.Rbtnseno.TabIndex = 6
        Me.Rbtnseno.TabStop = True
        Me.Rbtnseno.Text = "Seno"
        Me.Rbtnseno.UseVisualStyleBackColor = True
        '
        'Rbtncoseno
        '
        Me.Rbtncoseno.AutoSize = True
        Me.Rbtncoseno.Location = New System.Drawing.Point(133, 292)
        Me.Rbtncoseno.Name = "Rbtncoseno"
        Me.Rbtncoseno.Size = New System.Drawing.Size(77, 21)
        Me.Rbtncoseno.TabIndex = 7
        Me.Rbtncoseno.TabStop = True
        Me.Rbtncoseno.Text = "Coseno"
        Me.Rbtncoseno.UseVisualStyleBackColor = True
        '
        'Btncalcular2
        '
        Me.Btncalcular2.Location = New System.Drawing.Point(614, 236)
        Me.Btncalcular2.Name = "Btncalcular2"
        Me.Btncalcular2.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular2.TabIndex = 8
        Me.Btncalcular2.Text = "Calcular"
        Me.Btncalcular2.UseVisualStyleBackColor = True
        '
        'Btnlimpiar3
        '
        Me.Btnlimpiar3.Location = New System.Drawing.Point(614, 290)
        Me.Btnlimpiar3.Name = "Btnlimpiar3"
        Me.Btnlimpiar3.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar3.TabIndex = 9
        Me.Btnlimpiar3.Text = "Limpiar"
        Me.Btnlimpiar3.UseVisualStyleBackColor = True
        '
        'Btnsalir3
        '
        Me.Btnsalir3.Location = New System.Drawing.Point(614, 337)
        Me.Btnsalir3.Name = "Btnsalir3"
        Me.Btnsalir3.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir3.TabIndex = 10
        Me.Btnsalir3.Text = "Salir"
        Me.Btnsalir3.UseVisualStyleBackColor = True
        '
        'Frmva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnsalir3)
        Me.Controls.Add(Me.Btnlimpiar3)
        Me.Controls.Add(Me.Btncalcular2)
        Me.Controls.Add(Me.Rbtncoseno)
        Me.Controls.Add(Me.Rbtnseno)
        Me.Controls.Add(Me.Rbtnraiz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rbtncuadrado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtvar)
        Me.Name = "Frmva"
        Me.Text = "Operaciones varias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtvar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Rbtncuadrado As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Rbtnraiz As RadioButton
    Friend WithEvents Rbtnseno As RadioButton
    Friend WithEvents Rbtncoseno As RadioButton
    Friend WithEvents Btncalcular2 As Button
    Friend WithEvents Btnlimpiar3 As Button
    Friend WithEvents Btnsalir3 As Button
End Class
