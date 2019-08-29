Public Class Cotorra
    Inherits Loro

    Private _edadHumana As UShort
    Public ReadOnly Property EdadHumana As UShort
        Get
            Return (2 * Edad)
        End Get
    End Property

    Private On_Off As Integer = 0
    Shadows Sub escuchar(frase As String)
        If On_Off Mod 2 = 0 Then
            Memoria.Enqueue(frase)
        End If
        On_Off += 1
    End Sub
End Class
