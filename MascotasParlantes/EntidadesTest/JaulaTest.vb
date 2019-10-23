Imports Entidades
Module JaulaTest
    Sub jaula()
        Dim jaula1 As New Jaula()
        jaula1.Nombre = "Jaulita"
        Dim loro1 As New Loro()
        Dim cotorra1 As New Cotorra()
        cotorra1.Nombre = "pepe1"
        Dim cotorra2 As New Cotorra()
        cotorra2.Nombre = "pepe2"
        Dim cotorra3 As New Cotorra()
        cotorra3.Nombre = "pepe3"
        Dim cotorra4 As New Cotorra()
        cotorra4.Nombre = "pepe4"


        jaula1.addCotorra(cotorra1)
        jaula1.addCotorra(cotorra2)
        jaula1.addCotorra(cotorra3)
        jaula1.addCotorra(cotorra4)
        mostrarCotorras(jaula1)

        Console.WriteLine("ToString: " & jaula1.ToString())
    End Sub

    Sub mostrarCotorras(jaula As Jaula)
        For Each cotorra1 In jaula.getAllCotorras()
            Console.WriteLine(cotorra1)
        Next
    End Sub
End Module
