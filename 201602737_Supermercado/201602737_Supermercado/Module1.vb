Module Module1
    Public Const pJugo = 8.5
    Public Const pFritura = 11.2
    Public Const pGalleta = 4.25
    Public Const pBaterias = 15
    Public contador = 0


    Public numeropack(6)
    Public nombrepack(6)
    Public producto(6)
    Public cantidadinventario(6)
    Public cantidadpack(6)

    Public packstotal(6)
    Public sobrante(6)
    Public precioVenta(6)
    Public subtotal(6)



    Sub limpiar()

        Form1.DataGridView1.Rows.Clear()
        contador = 0


    End Sub



End Module
