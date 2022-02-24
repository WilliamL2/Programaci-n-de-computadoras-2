Public Class Frmva
    Private Sub Btnlimpiar3_Click(sender As Object, e As EventArgs) Handles Btnlimpiar3.Click
        Rbtncoseno.Checked = False
        Rbtncuadrado.Checked = False
        Rbtnraiz.Checked = False
        Rbtnseno.Checked = False
        Txtvar.Text = ""
    End Sub

    Private Sub Btnsalir3_Click(sender As Object, e As EventArgs) Handles Btnsalir3.Click
        Frm1.Show()
        Me.Hide()

    End Sub

    Private Sub Txtvar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtvar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Btncalcular2_Click(sender As Object, e As EventArgs) Handles Btncalcular2.Click
        Dim dato1 As Object
        Dim resultado1 As Object
        Dim informacion As Object
        dato1 = 0
        resultado1 = 0
        dato1 = Val(Txtvar.Text)

        If (Txtvar.Text = "") Then Txtvar.Text = "0"

        If Rbtncoseno.Checked Then
            resultado1 = Math.Cos(dato1 * Math.PI / 180)
        End If
        If Rbtncuadrado.Checked Then
            resultado1 = dato1 * dato1
        End If
        If Rbtnraiz.Checked Then
            resultado1 = Math.Sqrt(dato1)
        End If
        If Rbtnseno.Checked Then
            resultado1 = Math.Sin(dato1 * Math.PI / 180)
        End If
        resultado1 = Math.Round(resultado1, 2)
        informacion = "Resultado:" + vbCr + String.Concat(resultado1)

        MessageBox.Show(informacion, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class