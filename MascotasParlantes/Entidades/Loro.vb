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
    End Function
End Class
