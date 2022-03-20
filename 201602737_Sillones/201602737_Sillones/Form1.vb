Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Selecciones todos los campos")
            Exit Sub
        End If

        If contador < 8 Then
            numeroVenta(contador) = contador + 1
            tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem



            Select Case tamaño(contador)
                Case "Sofa"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = pSofa
                            precioCosto(contador) = 8 * pCuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = pSofa
                            precioCosto(contador) = 8 * pCuerina + precioManoObra(contador)
                    End Select

                Case "Individual"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = pIndividual
                            precioCosto(contador) = 3.5 * pCuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = pIndividual
                            precioCosto(contador) = 3.5 * pCuerina + precioManoObra(contador)
                    End Select

                Case "Doble"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = pDoble
                            precioCosto(contador) = 6 * pCuero + precioManoObra(contador)
                        Case "Cuerina"
                    precioManoObra(contador) = pDoble
                            precioCosto(contador) = 6 * pCuerina + precioManoObra(contador)
                    End Select

            End Select

            precioVenta(contador) = precioCosto(contador) * 1.65


            ListBox1.Items.Add(numeroVenta(contador))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(precioManoObra(contador))
            ListBox5.Items.Add(precioCosto(contador))
            ListBox6.Items.Add(precioVenta(contador))
            contador = contador + 1
        Else
            MsgBox("Se ha llegado al limite de registros")
        End If

    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()
    End Sub
End Class
