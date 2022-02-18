Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Txtcantidad.Text = ""
        Rbtnsmall.Checked = False
        Rbtnmedium.Checked = False
        Rbtnlarge.Checked = False
        Rbtnalgodon.Checked = False
        Rbtnseda.Checked = False
        Rbtnlona.Checked = False


    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Dim resultado As Integer
        resultado = MessageBox.Show("Quiere Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = DialogResult.Yes) Then Close()
    End Sub

    Private Sub Btntotal_Click(sender As Object, e As EventArgs) Handles Btntotal.Click
        Dim subtotalsa As Object
        Dim subtotalss As Object
        Dim subtotalsl As Object
        Dim subtotalma As Object
        Dim subtotalms As Object
        Dim subtotalml As Object
        Dim subtotalla As Object
        Dim subtotalls As Object
        Dim subtotalll As Object
        Dim cantidad As Object
        Dim total As Object
        Dim factura As Object
        Dim venta As Object
        Dim costou As Object
        Dim ventau As Object


        subtotalsa = 0
        subtotalsl = 0
        subtotalss = 0
        subtotalma = 0
        subtotalml = 0
        subtotalms = 0
        subtotalla = 0
        subtotalls = 0
        subtotalll = 0

        cantidad = Val(Txtcantidad.Text)
        If (Txtcantidad.Text = "") Then Txtcantidad.Text = "0"

        If Rbtnsmall.Checked And Rbtnalgodon.Checked Then
            subtotalsa = cantidad * 2 * 15 + cantidad * 65.5
        End If


        If Rbtnsmall.Checked And Rbtnlona.Checked Then
            subtotalsl = cantidad * 2 * 30.99 + cantidad * 65.5
        End If

        If Rbtnsmall.Checked And Rbtnseda.Checked Then
            subtotalss = cantidad * 2 * 23.99 + cantidad * 65.5
        End If



        If Rbtnmedium.Checked And Rbtnalgodon.Checked Then
            subtotalma = cantidad * 2.5 * 15 + cantidad * 85.99
        End If


        If Rbtnmedium.Checked And Rbtnlona.Checked Then
            subtotalml = cantidad * 2.5 * 30.99 + cantidad * 85.99
        End If


        If Rbtnmedium.Checked And Rbtnseda.Checked Then
            subtotalms = cantidad * 2.5 * 23.99 + cantidad * 85.99
        End If


        If Rbtnlarge.Checked And Rbtnalgodon.Checked Then
            subtotalla = cantidad * 3 * 15 + cantidad * 99.99
        End If


        If Rbtnlarge.Checked And Rbtnlona.Checked Then
            subtotalll = cantidad * 3 * 30.99 + cantidad * 99.99
        End If


        If Rbtnlarge.Checked And Rbtnseda.Checked Then
            subtotalls = cantidad * 3 * 23.99 + cantidad * 99.99
        End If


        total = subtotalsa + subtotalss + subtotalsl + subtotalma + subtotalms + subtotalml + subtotalla + subtotalll + subtotalls
        venta = total * 1.65
        costou = total / cantidad
        ventau = venta / cantidad

        total = Math.Round(total, 2)
        venta = Math.Round(venta, 2)
        costou = Math.Round(costou, 2)
        ventau = Math.Round(ventau, 2)

        factura = "Cantidad de unidades:" + String.Concat(Txtcantidad.Text) + vbCr + "Costo total: Q" + String.Concat(total) + vbCr + "Venta total: Q" + String.Concat(venta) + vbCr + "Costo unitario: Q" + String.Concat(costou) + vbCr + "Precio Venta unitaria: Q" + String.Concat(ventau)

        MessageBox.Show(factura, "Factura cambiaria", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
