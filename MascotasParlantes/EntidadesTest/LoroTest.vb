Imports System
Imports Entidades


Module LoroTest
    Sub Main(args As String())
        Dim loro1 As Loro
        loro1 = New Loro()
        loro1.Nombre = "pepe"
        loro1.FechaNacimiento = #01-01-2000#
        Console.WriteLine("Mostrando metodo get")
        Console.WriteLine(loro1.Nombre)
        Console.WriteLine(loro1.FechaNacimiento)
        Console.WriteLine(loro1.Edad)

        Console.WriteLine("Probando sobrecarga ToString():")
        Console.WriteLine(loro1.ToString())

        Console.WriteLine("Calcular edad")
        loro1.calcularEdad(loro1.FechaNacimiento)

        'Cargo a la memoria las frases'
        loro1.escuchar("papita ")
        loro1.escuchar("pa el loro ")
        loro1.escuchar("juan")

        Console.WriteLine("Muestro las frases")
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())

    End Sub
End Module
