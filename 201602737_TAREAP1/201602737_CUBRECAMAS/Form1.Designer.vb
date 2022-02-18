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
        Me.Btntotal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rbtnsmall = New System.Windows.Forms.RadioButton()
        Me.Rbtnmedium = New System.Windows.Forms.RadioButton()
        Me.Rbtnlarge = New System.Windows.Forms.RadioButton()
        Me.Rbtnalgodon = New System.Windows.Forms.RadioButton()
        Me.Rbtnseda = New System.Windows.Forms.RadioButton()
        Me.Rbtnlona = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btntotal
        '
        Me.Btntotal.Location = New System.Drawing.Point(574, 229)
        Me.Btntotal.Name = "Btntotal"
        Me.Btntotal.Size = New System.Drawing.Size(75, 23)
        Me.Btntotal.TabIndex = 0
        Me.Btntotal.Text = "Total"
        Me.Btntotal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(388, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CHUMPAS GAMALIEL"
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(574, 173)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(100, 22)
        Me.Txtcantidad.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cantidad"
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(574, 269)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 12
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(574, 311)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir.TabIndex = 13
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rbtnlona)
        Me.GroupBox1.Controls.Add(Me.Rbtnseda)
        Me.GroupBox1.Controls.Add(Me.Rbtnalgodon)
        Me.GroupBox1.Location = New System.Drawing.Point(316, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 176)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rbtnlarge)
        Me.GroupBox2.Controls.Add(Me.Rbtnmedium)
        Me.GroupBox2.Controls.Add(Me.Rbtnsmall)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 176)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tallas"
        '
        'Rbtnsmall
        '
        Me.Rbtnsmall.AutoSize = True
        Me.Rbtnsmall.Location = New System.Drawing.Point(0, 31)
        Me.Rbtnsmall.Name = "Rbtnsmall"
        Me.Rbtnsmall.Size = New System.Drawing.Size(63, 21)
        Me.Rbtnsmall.TabIndex = 16
        Me.Rbtnsmall.TabStop = True
        Me.Rbtnsmall.Text = "Small"
        Me.Rbtnsmall.UseVisualStyleBackColor = True
        '
        'Rbtnmedium
        '
        Me.Rbtnmedium.AutoSize = True
        Me.Rbtnmedium.Location = New System.Drawing.Point(0, 65)
        Me.Rbtnmedium.Name = "Rbtnmedium"
        Me.Rbtnmedium.Size = New System.Drawing.Size(78, 21)
        Me.Rbtnmedium.TabIndex = 17
        Me.Rbtnmedium.TabStop = True
        Me.Rbtnmedium.Text = "Medium"
        Me.Rbtnmedium.UseVisualStyleBackColor = True
        '
        'Rbtnlarge
        '
        Me.Rbtnlarge.AutoSize = True
        Me.Rbtnlarge.Location = New System.Drawing.Point(0, 107)
        Me.Rbtnlarge.Name = "Rbtnlarge"
        Me.Rbtnlarge.Size = New System.Drawing.Size(66, 21)
        Me.Rbtnlarge.TabIndex = 18
        Me.Rbtnlarge.TabStop = True
        Me.Rbtnlarge.Text = "Large"
        Me.Rbtnlarge.UseVisualStyleBackColor = True
        '
        'Rbtnalgodon
        '
        Me.Rbtnalgodon.AutoSize = True
        Me.Rbtnalgodon.Location = New System.Drawing.Point(0, 31)
        Me.Rbtnalgodon.Name = "Rbtnalgodon"
        Me.Rbtnalgodon.Size = New System.Drawing.Size(81, 21)
        Me.Rbtnalgodon.TabIndex = 17
        Me.Rbtnalgodon.TabStop = True
        Me.Rbtnalgodon.Text = "Algodon"
        Me.Rbtnalgodon.UseVisualStyleBackColor = True
        '
        'Rbtnseda
        '
        Me.Rbtnseda.AutoSize = True
        Me.Rbtnseda.Location = New System.Drawing.Point(0, 65)
        Me.Rbtnseda.Name = "Rbtnseda"
        Me.Rbtnseda.Size = New System.Drawing.Size(62, 21)
        Me.Rbtnseda.TabIndex = 18
        Me.Rbtnseda.TabStop = True
        Me.Rbtnseda.Text = "Seda"
        Me.Rbtnseda.UseVisualStyleBackColor = True
        '
        'Rbtnlona
        '
        Me.Rbtnlona.AutoSize = True
        Me.Rbtnlona.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Rbtnlona.Location = New System.Drawing.Point(0, 107)
        Me.Rbtnlona.Name = "Rbtnlona"
        Me.Rbtnlona.Size = New System.Drawing.Size(61, 21)
        Me.Rbtnlona.TabIndex = 19
        Me.Rbtnlona.TabStop = True
        Me.Rbtnlona.Text = "Lona"
        Me.Rbtnlona.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Rbtnlona.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtcantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btntotal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btntotal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rbtnlona As RadioButton
    Friend WithEvents Rbtnseda As RadioButton
    Friend WithEvents Rbtnalgodon As RadioButton
    Friend WithEvents Rbtnlarge As RadioButton
    Friend WithEvents Rbtnmedium As RadioButton
    Friend WithEvents Rbtnsmall As RadioButton
End Class
