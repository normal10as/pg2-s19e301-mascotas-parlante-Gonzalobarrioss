Imports Entidades

Public Module CotorraTest
    Sub cotorra()
        Dim cotorra1 As Cotorra
        cotorra1 = New Cotorra()
        cotorra1.escuchar("papita ")
        cotorra1.escuchar("nada")
        cotorra1.escuchar("pa la cotorra")
        Console.WriteLine("Edad cotorra")
        Console.WriteLine(cotorra1.EdadHumana)

        Console.WriteLine(cotorra1.hablar())
        Console.WriteLine(cotorra1.hablar())
        Console.WriteLine(cotorra1.hablar())
        Console.WriteLine(cotorra1.hablar())
    End Sub


End Module
