Module Module1
    Public Const pSofa = 250.99
    Public Const pIndividual = 150.99
    Public Const pDoble = 200.99

    Public Const pCuero = 75.0
    Public Const pCuerina = 45.99

    Public tamaño(8)
    Public material(8)
    Public contador = 0
    Public precio(8)
    Public numeroVenta(8)
    Public precioCosto(8)
    Public precioManoObra(8)
    Public precioVenta(8)

    Public Sub limpiar()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        contador = 0


    End Sub


End Module
