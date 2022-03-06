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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtdias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txthonorarios = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rbtnnopriv = New System.Windows.Forms.RadioButton()
        Me.Rbtnsemi = New System.Windows.Forms.RadioButton()
        Me.Rbtnpriv = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cbxmaternidad = New System.Windows.Forms.CheckBox()
        Me.Cbxoperacion = New System.Windows.Forms.CheckBox()
        Me.Cbxencamamiento = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rbtndebito = New System.Windows.Forms.RadioButton()
        Me.Rbtncredio = New System.Windows.Forms.RadioButton()
        Me.Rbtncheque = New System.Windows.Forms.RadioButton()
        Me.Rbtnefectivo = New System.Windows.Forms.RadioButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem, Me.MostrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1492, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem, Me.VectoresToolStripMenuItem})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'VectoresToolStripMenuItem
        '
        Me.VectoresToolStripMenuItem.Name = "VectoresToolStripMenuItem"
        Me.VectoresToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.VectoresToolStripMenuItem.Text = "Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 201)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1315, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(12, 78)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(100, 22)
        Me.Txtnombre.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nit"
        '
        'Txtnit
        '
        Me.Txtnit.Location = New System.Drawing.Point(118, 78)
        Me.Txtnit.Name = "Txtnit"
        Me.Txtnit.Size = New System.Drawing.Size(100, 22)
        Me.Txtnit.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "D. hospitalizado"
        '
        'Txtdias
        '
        Me.Txtdias.Location = New System.Drawing.Point(224, 78)
        Me.Txtdias.Name = "Txtdias"
        Me.Txtdias.Size = New System.Drawing.Size(100, 22)
        Me.Txtdias.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Honorarios"
        '
        'Txthonorarios
        '
        Me.Txthonorarios.Location = New System.Drawing.Point(330, 78)
        Me.Txthonorarios.Name = "Txthonorarios"
        Me.Txthonorarios.Size = New System.Drawing.Size(100, 22)
        Me.Txthonorarios.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rbtnnopriv)
        Me.GroupBox1.Controls.Add(Me.Rbtnsemi)
        Me.GroupBox1.Controls.Add(Me.Rbtnpriv)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitacion"
        '
        'Rbtnnopriv
        '
        Me.Rbtnnopriv.AutoSize = True
        Me.Rbtnnopriv.Location = New System.Drawing.Point(7, 73)
        Me.Rbtnnopriv.Name = "Rbtnnopriv"
        Me.Rbtnnopriv.Size = New System.Drawing.Size(98, 21)
        Me.Rbtnnopriv.TabIndex = 2
        Me.Rbtnnopriv.TabStop = True
        Me.Rbtnnopriv.Text = "No privada"
        Me.Rbtnnopriv.UseVisualStyleBackColor = True
        '
        'Rbtnsemi
        '
        Me.Rbtnsemi.AutoSize = True
        Me.Rbtnsemi.Location = New System.Drawing.Point(7, 48)
        Me.Rbtnsemi.Name = "Rbtnsemi"
        Me.Rbtnsemi.Size = New System.Drawing.Size(111, 21)
        Me.Rbtnsemi.TabIndex = 1
        Me.Rbtnsemi.TabStop = True
        Me.Rbtnsemi.Text = "Semi privada"
        Me.Rbtnsemi.UseVisualStyleBackColor = True
        '
        'Rbtnpriv
        '
        Me.Rbtnpriv.AutoSize = True
        Me.Rbtnpriv.Location = New System.Drawing.Point(7, 20)
        Me.Rbtnpriv.Name = "Rbtnpriv"
        Me.Rbtnpriv.Size = New System.Drawing.Size(77, 21)
        Me.Rbtnpriv.TabIndex = 0
        Me.Rbtnpriv.TabStop = True
        Me.Rbtnpriv.Text = "Privada"
        Me.Rbtnpriv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cbxmaternidad)
        Me.GroupBox2.Controls.Add(Me.Cbxoperacion)
        Me.GroupBox2.Controls.Add(Me.Cbxencamamiento)
        Me.GroupBox2.Location = New System.Drawing.Point(667, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servicio"
        '
        'Cbxmaternidad
        '
        Me.Cbxmaternidad.AutoSize = True
        Me.Cbxmaternidad.Location = New System.Drawing.Point(7, 73)
        Me.Cbxmaternidad.Name = "Cbxmaternidad"
        Me.Cbxmaternidad.Size = New System.Drawing.Size(101, 21)
        Me.Cbxmaternidad.TabIndex = 2
        Me.Cbxmaternidad.Text = "Maternidad"
        Me.Cbxmaternidad.UseVisualStyleBackColor = True
        '
        'Cbxoperacion
        '
        Me.Cbxoperacion.AutoSize = True
        Me.Cbxoperacion.Location = New System.Drawing.Point(7, 48)
        Me.Cbxoperacion.Name = "Cbxoperacion"
        Me.Cbxoperacion.Size = New System.Drawing.Size(96, 21)
        Me.Cbxoperacion.TabIndex = 1
        Me.Cbxoperacion.Text = "Operacion"
        Me.Cbxoperacion.UseVisualStyleBackColor = True
        '
        'Cbxencamamiento
        '
        Me.Cbxencamamiento.AutoSize = True
        Me.Cbxencamamiento.Location = New System.Drawing.Point(7, 22)
        Me.Cbxencamamiento.Name = "Cbxencamamiento"
        Me.Cbxencamamiento.Size = New System.Drawing.Size(123, 21)
        Me.Cbxencamamiento.TabIndex = 0
        Me.Cbxencamamiento.Text = "Encamamiento"
        Me.Cbxencamamiento.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rbtndebito)
        Me.GroupBox3.Controls.Add(Me.Rbtncredio)
        Me.GroupBox3.Controls.Add(Me.Rbtncheque)
        Me.GroupBox3.Controls.Add(Me.Rbtnefectivo)
        Me.GroupBox3.Location = New System.Drawing.Point(885, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de pago"
        '
        'Rbtndebito
        '
        Me.Rbtndebito.AutoSize = True
        Me.Rbtndebito.Location = New System.Drawing.Point(7, 95)
        Me.Rbtndebito.Name = "Rbtndebito"
        Me.Rbtndebito.Size = New System.Drawing.Size(137, 21)
        Me.Rbtndebito.TabIndex = 3
        Me.Rbtndebito.TabStop = True
        Me.Rbtndebito.Text = "Tarjeta de debito"
        Me.Rbtndebito.UseVisualStyleBackColor = True
        '
        'Rbtncredio
        '
        Me.Rbtncredio.AutoSize = True
        Me.Rbtncredio.Location = New System.Drawing.Point(7, 73)
        Me.Rbtncredio.Name = "Rbtncredio"
        Me.Rbtncredio.Size = New System.Drawing.Size(141, 21)
        Me.Rbtncredio.TabIndex = 2
        Me.Rbtncredio.TabStop = True
        Me.Rbtncredio.Text = "Tarjeta de credito"
        Me.Rbtncredio.UseVisualStyleBackColor = True
        '
        'Rbtncheque
        '
        Me.Rbtncheque.AutoSize = True
        Me.Rbtncheque.Location = New System.Drawing.Point(7, 50)
        Me.Rbtncheque.Name = "Rbtncheque"
        Me.Rbtncheque.Size = New System.Drawing.Size(78, 21)
        Me.Rbtncheque.TabIndex = 1
        Me.Rbtncheque.TabStop = True
        Me.Rbtncheque.Text = "Cheque"
        Me.Rbtncheque.UseVisualStyleBackColor = True
        '
        'Rbtnefectivo
        '
        Me.Rbtnefectivo.AutoSize = True
        Me.Rbtnefectivo.Location = New System.Drawing.Point(7, 22)
        Me.Rbtnefectivo.Name = "Rbtnefectivo"
        Me.Rbtnefectivo.Size = New System.Drawing.Size(79, 21)
        Me.Rbtnefectivo.TabIndex = 0
        Me.Rbtnefectivo.TabStop = True
        Me.Rbtnefectivo.Text = "Efectivo"
        Me.Rbtnefectivo.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nit"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dias"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Honorarios"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Habitacion"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Servicio"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pago Parcial"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Descuento"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Recargo"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "Total"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1492, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txthonorarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtdias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtnit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtnit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtdias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txthonorarios As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rbtnnopriv As RadioButton
    Friend WithEvents Rbtnsemi As RadioButton
    Friend WithEvents Rbtnpriv As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cbxmaternidad As CheckBox
    Friend WithEvents Cbxoperacion As CheckBox
    Friend WithEvents Cbxencamamiento As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Rbtndebito As RadioButton
    Friend WithEvents Rbtncredio As RadioButton
    Friend WithEvents Rbtncheque As RadioButton
    Friend WithEvents Rbtnefectivo As RadioButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
