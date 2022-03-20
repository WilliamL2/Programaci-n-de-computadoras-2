Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Selecciones todos los campos")
            Exit Sub
        End If
        If contador < 6 Then
            numeropack(contador) = contador + 1
            producto(contador) = ComboBox1.SelectedItem
            If (TextBox1.Text = "") Then TextBox1.Text = "Sin nombre"
            If (TextBox2.Text = "") Then TextBox2.Text = "0"
            If (TextBox3.Text = "") Then TextBox3.Text = "0"

            nombrepack(contador) = TextBox1.Text
            cantidadinventario(contador) = TextBox2.Text
            packstotal(contador) = TextBox3.Text
            If cantidadinventario(contador) >= packstotal(contador) Then
                Dim division As Integer
                division = cantidadinventario(contador) / packstotal(contador)
                sobrante(contador) = cantidadinventario(contador) Mod packstotal(contador)

                Select Case producto(contador)
                    Case "Jugos"
                        subtotal(contador) = pJugo * packstotal(contador) * division
                    Case "Frituras"
                        subtotal(contador) = pJugo * packstotal(contador) * division
                    Case "Galletas"
                        subtotal(contador) = pJugo * packstotal(contador) * division
                    Case "Baterias"
                        subtotal(contador) = pJugo * packstotal(contador) * division

                End Select
                Dim total As Object

                If packstotal(contador) >= 10 Then
                    total = subtotal(contador) * 0.9
                End If
                If packstotal(contador) >= 3 Then
                    total = subtotal(contador) * 0.95
                End If
                If packstotal(contador) < 3 Then
                    total = subtotal(contador)
                End If
                DataGridView1.Rows.Add(numeropack(contador), nombrepack(contador), producto(contador), cantidadinventario(contador), packstotal(contador), division, sobrante(contador), total)
                contador = contador + 1
            End If
            If cantidadinventario(contador) < packstotal(contador) Then
                MsgBox("No se puede tener mas unidades que inventario")
            End If
        Else

            MsgBox("Se ha llegado al limite de registros")

        End If


            TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
