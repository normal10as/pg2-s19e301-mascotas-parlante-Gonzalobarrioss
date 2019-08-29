Public Class Loro

    Public Sub New()
        Memoria = New Queue(Of String)
        Nombre = ""
        FechaNacimiento = Date.Today()
    End Sub
    Private _memoria As Queue(Of String)
    Public Property Memoria As Queue(Of String)
        Get
            Return _memoria
        End Get
        Set(value As Queue(Of String))
            _memoria = value
        End Set
    End Property

    Private _edad As Short
    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get
    End Property

    Private _fechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Function calcularEdad(value As Date) As UShort
        Dim hoy As Date = Date.Now()
        Dim edad As Int16
        edad = (hoy.Year) - (value.Year)
        If (hoy.Month < value.Month) Then
            edad -= 1
        ElseIf hoy.Month = value.Month And hoy.Day < value.Day Then
            edad -= 1
        End If
        Return edad
    End Function

    Sub escuchar(frase As String)
        Memoria.Enqueue(frase)
    End Sub

    Function ToString() As String
        Return Nombre
    End Function

    Private frase As String
    Function hablar() As String
        If Memoria.Count <> 0 Then
            frase += Memoria.Dequeue()
            Return frase
        End If
        Return ""
    End Function
End Class
