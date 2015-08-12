Public Class calle
    Private varlongitud As String
    Public Property longitud() As String
        Get
            Return varlongitud
        End Get
        Set(ByVal value As String)
            varlongitud = value
        End Set
    End Property
    Private varangulo As String
    Public Property angulo() As String
        Get
            Return varangulo
        End Get
        Set(ByVal value As String)
            varangulo = value
        End Set
    End Property

    Sub New(ByVal vlong As Int16, ByVal vangulo As Int16)
        varlongitud = vlong
        varangulo = vangulo
    End Sub
End Class
