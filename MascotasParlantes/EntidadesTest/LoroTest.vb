Imports System
Imports Entidades

Module LoroTest
    Sub Main(args As String())
        Dim loro1 As Loro
        loro1 = New Loro()
        loro1.Nombre = "pepe"
        Console.WriteLine(loro1.Nombre)
        Console.WriteLine(loro1.FechaNacimiento)
        Console.WriteLine(loro1.Edad)


    End Sub
End Module
