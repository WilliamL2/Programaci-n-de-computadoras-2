Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()
    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Txtmensajero.Text = ""
        Txtmonto.Text = ""
        Rbtnnorte.Checked = False
        Rbtnsur.Checked = False
        Rbtnoccidente.Checked = False
        Rbtnoriente.Checked = False
        Rbtnaccidente.Checked = False
        Rbtnvehiculo.Checked = False

    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Dim Sueldo As Object
        Dim vehiculo As Object
        Dim accidente As Object
        Dim norte As Object
        Dim sur As Object
        Dim occidente As Object
        Dim oriente As Object
        Dim total As Object
        Dim factura As Object
        Dim seguro As Object
        Dim monto As Object

        Sueldo = 3800
        norte = 0
        sur = 0
        oriente = 0
        occidente = 0
        vehiculo = 0
        accidente = 0
        monto = Txtmonto.Text
        If (Txtmensajero.Text = "") Then Txtmensajero.Text = "Sin datos"
        If (Txtmonto.Text = "") Then Txtmonto.Text = "0"

        If Rbtnnorte.Checked Then
            norte = 150
        End If
            If Rbtnsur.Checked Then
            sur = 200
        End If
                If Rbtnoccidente.Checked Then
            occidente = 225
        End If
                    If Rbtnoriente.Checked Then
            oriente = 175
        End If
        If Rbtnaccidente.Checked Then
            accidente = 3800 * 0.05
        End If
        If Rbtnvehiculo.Checked Then
            vehiculo = 3800 * 0.03
        End If
        total = Sueldo + norte + sur + oriente + occidente - accidente - vehiculo
        total = Math.Round(total, 2)
        seguro = vehiculo + accidente
        seguro = Math.Round(seguro, 2)


        factura = "Mensajero: " + String.Concat(Txtmensajero.Text) + vbCr + "Monto del envio: Q" + String.Concat(monto) + vbCr + "Sueldo final: Q" + String.Concat(total) + vbCr + "Seguro: Q" + String.Concat(seguro) + vbCr + "Sueldo base: Q3,800.00"
        MessageBox.Show(factura, "Costo de envio", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class
