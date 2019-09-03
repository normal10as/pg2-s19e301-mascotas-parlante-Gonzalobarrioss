Public Class Cotorra
    Inherits Loro

    Public Sub New()
        _memoria = New Queue(Of String)
    End Sub

    Private _memoria As Queue(Of String)
    Private _edadHumana As UShort
    Public ReadOnly Property edadHumana As UShort
        Get
            Return 2 * Edad
        End Get
    End Property

    Dim OnOff As Integer = 0
    Sub escuchar(frase As String)
        If OnOff Mod 2 = 0 Then
            _memoria.Enqueue(frase)
        End If
        OnOff += 1
    End Sub
End Class
