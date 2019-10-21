Public Class Cotorra
    Inherits Loro

    Public Sub New()
        MyBase.New()
        memoria = New Queue(Of String)
    End Sub

    Public ReadOnly Property edadHumana As UShort
        Get
            Return 2 * Edad
        End Get
    End Property

    Dim TrueFalse As Integer = 0
    Public Overrides Sub escuchar(frase As String)
        If TrueFalse Mod 2 = 0 Then
            memoria.Enqueue(frase)
        End If
        TrueFalse += 1
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
