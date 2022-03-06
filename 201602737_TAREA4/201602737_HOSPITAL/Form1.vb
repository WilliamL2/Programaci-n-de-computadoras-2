Public Class Form1
    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim servicio As Object
        Dim servicio1 As Object
        Dim servicio2 As Object
        Dim servicio3 As Object
        Dim hono As Object
        Dim descuento As Object
        Dim subtotal As Object
        Dim total As Object
        Dim dias As Object
        Dim habitacion As Object
        Dim tipos1 As Object
        Dim tipos2 As Object
        Dim tipos3 As Object
        Dim tipos As Object
        Dim recargo As Object

        recargo = 0
        total = 0
        dias = 0
        subtotal = 0
        descuento = 0
        servicio = 0
        servicio1 = 0
        servicio2 = 0
        servicio3 = 0
        hono = 0
        habitacion = ""
        tipos = ""
        tipos1 = ""
        tipos2 = ""
        tipos3 = ""
        dias = Val(Txtdias.Text)
        If (Txtdias.Text = "") Then Txtdias.Text = 0
        hono = Val(Txthonorarios.Text)
        If (Txthonorarios.Text = "") Then Txthonorarios.Text = 0

        If index < 6 Then
            If Rbtnpriv.Checked Then
                habitacion = "Privada"
                If Cbxencamamiento.Checked Then
                    servicio1 = 350
                End If
                If Cbxmaternidad.Checked Then
                    servicio2 = 450
                End If
                If Cbxoperacion.Checked Then
                    servicio3 = 550
                End If
                servicio = servicio1 + servicio2 + servicio3
            End If
            If Rbtnsemi.Checked Then
                habitacion = "Semi privada"
                If Cbxencamamiento.Checked Then
                    servicio1 = 250
                End If
                If Cbxmaternidad.Checked Then
                    servicio2 = 350
                End If
                If Cbxoperacion.Checked Then
                    servicio3 = 400
                End If
                servicio = servicio1 + servicio2 + servicio3
            End If
            If Rbtnnopriv.Checked Then
                habitacion = "No privada"
                If Cbxencamamiento.Checked Then
                    servicio1 = 150
                End If
                If Cbxmaternidad.Checked Then
                    servicio2 = 250
                End If
                If Cbxoperacion.Checked Then
                    servicio3 = 300
                End If
                servicio = servicio1 + servicio2 + servicio3
            End If

            If Cbxencamamiento.Checked Then
                tipos1 = " Encamamiento "
            End If

            If Cbxmaternidad.Checked Then
                tipos2 = " Maternidad "
            End If

            If Cbxoperacion.Checked Then
                tipos3 = " Operacion "
            End If
            tipos = tipos1 + tipos2 + tipos3


            If Rbtnefectivo.Checked Then
                descuento = -0.15
            End If
            If Rbtncheque.Checked Then
                descuento = -0.15
            End If
            If Rbtndebito.Checked Then
                descuento = -0.08
            End If
            If Rbtncredio.Checked Then
                recargo = 0.05
            End If
            total = dias * servicio + dias * servicio * descuento + hono
            subtotal = dias * servicio

            DataGridView1.Rows.Add(String.Concat(Txtnombre.Text), String.Concat(Txtnit.Text), dias, hono, habitacion, tipos, subtotal, descuento, recargo, total)

            index = index + 1
            End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        Txtnombre.Text = ""
        Txtnit.Text = ""
        Txtdias.Text = ""
        Txthonorarios.Text = ""

        Rbtnpriv.Checked = False
        Rbtnsemi.Checked = False
        Rbtnnopriv.Checked = False
        Rbtnefectivo.Checked = False
        Rbtncheque.Checked = False
        Rbtncredio.Checked = False
        Rbtndebito.Checked = False
        Cbxencamamiento.Checked = False
        Cbxmaternidad.Checked = False
        Cbxoperacion.Checked = False
        limpiar_entradas()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub
    Private Sub Txtdias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdias.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub Txthonorarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txthonorarios.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
