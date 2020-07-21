
Option Strict On
''' <summary>
''' Declaring a class named Car for storing the details of the car.
''' </summary>
Public Class Car

#Region "Properties"

    Shared carCount As Integer = 0
    Private carID As Integer = 0
    Private carMake As String = ""
    Private carModel As String = ""
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0
    Private carNewStatus As Boolean = False

#End Region

#Region "Constructors"
    Public Sub New()
        carID = carCount
        carCount += 1
    End Sub

    Public Sub New(make As String, model As String, year As Integer, price As Decimal, status As Boolean)
        carID = carCount
        carCount += 1
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Price = price
        Me.NewStatus = status
    End Sub
#End Region

#Region "Property Value"

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    Public Property NewStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(value As Boolean)
            carNewStatus = value
        End Set
    End Property

    Public ReadOnly Property InternalCount() As Integer
        Get
            Return carID
        End Get

    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

#End Region

#Region "Methods"

    Public Function GetCarInfo() As String
        Return "The car manufactured by " & Me.Make & " and model " & Me.carModel & " is having a price " & Me.Price
    End Function
#End Region
End Class
