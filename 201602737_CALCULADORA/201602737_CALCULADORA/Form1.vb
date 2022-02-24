Public Class Frm1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btnsalir1.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()
    End Sub

    Private Sub Btnlimpiar1_Click(sender As Object, e As EventArgs) Handles Btnlimpiar1.Click
        Rbtnsimple.Checked = False
        Rbtnvarias.Checked = False

    End Sub

    Private Sub Btnseleccionar_Click(sender As Object, e As EventArgs) Handles Btnseleccionar.Click
        If Rbtnsimple.Checked Then
            Frmops.Show()
            Me.Hide()

        End If
        If Rbtnvarias.Checked Then
            Frmva.Show()
            Me.Hide()
        End If

    End Sub
End Class
