Public Class car
    Private vartipo As Int16
    Public Property tipo() As Int16
        Get
            Return vartipo
        End Get
        Set(ByVal value As Int16)
            vartipo = value
        End Set
    End Property
    Private varpeso As Int16
    Public Property peso() As Int16
        Get
            Return varpeso
        End Get
        Set(ByVal value As Int16)
            varpeso = value
        End Set
    End Property
    Private varvelmax As Int16
    Public Property velmax() As Int16
        Get
            Return varvelmax
        End Get
        Set(ByVal value As Int16)
            varvelmax = value
        End Set
    End Property
    Private varmaxacel As Int16
    Public Property NewProperty() As Int16
        Get
            Return varmaxacel
        End Get
        Set(ByVal value As Int16)
            varmaxacel = value
        End Set
    End Property
    Private vargasolina As Int16
    Public Property gasolina() As Int16
        Get
            Return vargasolina
        End Get
        Set(ByVal value As Int16)
            vargasolina = value
        End Set
    End Property
    Private varvelact As Int16
    Public Property velact() As Int16
        Get
            Return varvelact
        End Get
        Set(ByVal value As Int16)
            varvelact = value
        End Set
    End Property
    Private varacelact As Int16
    Public Property acelact() As Int16
        Get
            Return varacelact
        End Get
        Set(ByVal value As Int16)
            varacelact = value
        End Set
    End Property


    Sub New(ByVal vtipo As Int16, ByVal vpeso As Int16, ByVal vgasolina As Int16)
        vartipo = vtipo
        varpeso = vpeso
        vargasolina = vgasolina
    End Sub


End Class
