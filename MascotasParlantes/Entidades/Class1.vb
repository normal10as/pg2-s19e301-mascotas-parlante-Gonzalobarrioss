Public Class Loro
    Private _memoria As String
    Public Property Memoria As String
        Get
            Return _memoria
        End Get
        Set(value As String)
            _memoria = value
        End Set
    End Property

    Private _edad As Short
    Public Property Edad As Short
        Get
            Return _edad
        End Get
        Set(value As Short)

        End Set
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

    Public Sub New()

    End Sub
End Class
