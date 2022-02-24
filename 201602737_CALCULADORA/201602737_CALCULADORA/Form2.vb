Public Class Frmops
    Private Sub Btnlimpiar2_Click(sender As Object, e As EventArgs) Handles Btnlimpiar2.Click
        Rbtndivi.Checked = False
        Rbtnmulti.Checked = False
        Rbtnresta.Checked = False
        Rbtnsuma.Checked = False
        Txtnum1.Text = ""
        Txtnum2.Text = ""


    End Sub

    Private Sub Btnsalir2_Click(sender As Object, e As EventArgs) Handles Btnsalir2.Click
        Frm1.Show()
        Me.Hide()

    End Sub

    Private Sub Btncalcular1_Click(sender As Object, e As EventArgs) Handles Btncalcular1.Click
        Dim dato1 As Object
        Dim dato2 As Object
        Dim resultado1 As Object
        Dim informacion As Object

        resultado1 = 0
        dato1 = 0
        dato2 = 0
        dato1 = Val(Txtnum1.Text)
        dato2 = Val(Txtnum2.Text)
        If (Txtnum1.Text = "") Then Txtnum1.Text = "0"
        If (Txtnum2.Text = "") Then Txtnum2.Text = "0"

        If Rbtndivi.Checked Then
            resultado1 = dato1 / dato2
        End If
        If Rbtnmulti.Checked Then
            resultado1 = dato1 * dato2
        End If
        If Rbtnsuma.Checked Then
            resultado1 = dato1 + dato2
        End If
        If Rbtnresta.Checked Then
            resultado1 = dato1 - dato2
        End If

        resultado1 = Math.Round(resultado1, 2)

        informacion = "Resultado:" + vbCr + String.Concat(resultado1)

        MessageBox.Show(informacion, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Txtnum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnum1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Txtnum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnum2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class