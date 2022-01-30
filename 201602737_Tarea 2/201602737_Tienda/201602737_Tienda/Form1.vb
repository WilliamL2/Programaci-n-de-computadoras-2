Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()


    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        Dim arroz As Object
        Dim frijol As Object
        Dim azucar As Object
        Dim subtotal As Object
        Dim iva As Object
        Dim parcial As Object
        Dim Descuento1 As Object
        Dim Descuento2 As Object
        Dim total As Object
        Dim factura As Object


        If (TextBox1.Text = "") Then TextBox1.Text = "0"
        If (TextBox2.Text = "") Then TextBox2.Text = "0"
        If (TextBox3.Text = "") Then TextBox3.Text = "0"

        arroz = Val(TextBox1.Text)
        frijol = Val(TextBox2.Text)
        azucar = Val(TextBox3.Text)

        subtotal = arroz * 2 + frijol * 1.75 + azucar * 2.5
        iva = subtotal * 0.12
        parcial = subtotal + iva
        Descuento1 = subtotal * 0.025
        total = parcial - Descuento1
        factura = "Subtotal: " + String.Concat(subtotal) + vbCr + "IVA: " + String.Concat(iva) + vbCr + "Parcial: " + String.Concat(parcial) + vbCr + "Descuento1: " + String.Concat(Descuento1) + vbCr + "Pago Final: " + String.Concat(total)
        MessageBox.Show(factura, "Factura Cambiaria", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class
