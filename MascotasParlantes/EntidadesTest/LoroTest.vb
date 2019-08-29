Imports System
Imports Entidades


Module LoroTest
    Public loro1 As Loro
    Sub Main(args As String())

        loro1 = New Loro()
        loro1.Nombre = "pepe"
        loro1.FechaNacimiento = #08-30-2000#

        Console.WriteLine("Mostrando metodo get")
        Console.WriteLine(loro1.Nombre)
        Console.WriteLine(loro1.FechaNacimiento)
        Console.WriteLine(loro1.Edad)

        Console.WriteLine("Probando sobrecarga ToString():")
        Console.WriteLine(loro1.ToString())

        Console.WriteLine("Calcular edad")
        Console.WriteLine(loro1.calcularEdad(loro1.FechaNacimiento))

        'Cargo a la memoria las frases'
        loro1.escuchar("papita ")
        loro1.escuchar("pa el loro ")
        loro1.escuchar("juan")

        Console.WriteLine("Muestro las frases")
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        cotorra()
    End Sub
End Module
