﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("17df3ff5-741c-4d12-a484-d27982680f6d")>

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class TravelModelContainer
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new TravelModelContainer object using the connection string found in the 'TravelModelContainer' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=TravelModelContainer", "TravelModelContainer")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new TravelModelContainer object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "TravelModelContainer")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new TravelModelContainer object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "TravelModelContainer")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property Travels() As ObjectSet(Of Travel)
        Get
            If (_Travels Is Nothing) Then
                _Travels = MyBase.CreateObjectSet(Of Travel)("Travels")
            End If
            Return _Travels
        End Get
    End Property

    Private _Travels As ObjectSet(Of Travel)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the Travels EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToTravels(ByVal travel As Travel)
        MyBase.AddObject("Travels", travel)
    End Sub

    #End Region
    #Region "Function Imports"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    ''' <param name="partitionKey">No Metadata Documentation available.</param>
    ''' <param name="rowKey">No Metadata Documentation available.</param>
    Public Function DeleteFromTravel(partitionKey As Global.System.String, rowKey As Nullable(Of Global.System.Guid)) As Integer
        Dim partitionKeyParameter As ObjectParameter
        If (partitionKey IsNot Nothing)
            partitionKeyParameter = New ObjectParameter("PartitionKey", partitionKey)
        Else
            partitionKeyParameter = New ObjectParameter("PartitionKey", GetType(Global.System.String))
        End If

        Dim rowKeyParameter As ObjectParameter
        If (rowKey.HasValue)
            rowKeyParameter = New ObjectParameter("RowKey", rowKey)
        Else
            rowKeyParameter = New ObjectParameter("RowKey", GetType(Global.System.Guid))
        End If

        Return MyBase.ExecuteFunction("DeleteFromTravel", partitionKeyParameter, rowKeyParameter)

    End Function

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    ''' <param name="partitionKey">No Metadata Documentation available.</param>
    ''' <param name="place">No Metadata Documentation available.</param>
    ''' <param name="geoLocation">No Metadata Documentation available.</param>
    ''' <param name="time">No Metadata Documentation available.</param>
    Public Function InsertIntoTravel(partitionKey As Global.System.String, place As Global.System.String, geoLocation As Global.System.String, time As Nullable(Of Global.System.DateTime)) As Integer
        Dim partitionKeyParameter As ObjectParameter
        If (partitionKey IsNot Nothing)
            partitionKeyParameter = New ObjectParameter("PartitionKey", partitionKey)
        Else
            partitionKeyParameter = New ObjectParameter("PartitionKey", GetType(Global.System.String))
        End If

        Dim placeParameter As ObjectParameter
        If (place IsNot Nothing)
            placeParameter = New ObjectParameter("Place", place)
        Else
            placeParameter = New ObjectParameter("Place", GetType(Global.System.String))
        End If

        Dim geoLocationParameter As ObjectParameter
        If (geoLocation IsNot Nothing)
            geoLocationParameter = New ObjectParameter("GeoLocation", geoLocation)
        Else
            geoLocationParameter = New ObjectParameter("GeoLocation", GetType(Global.System.String))
        End If

        Dim timeParameter As ObjectParameter
        If (time.HasValue)
            timeParameter = New ObjectParameter("Time", time)
        Else
            timeParameter = New ObjectParameter("Time", GetType(Global.System.DateTime))
        End If

        Return MyBase.ExecuteFunction("InsertIntoTravel", partitionKeyParameter, placeParameter, geoLocationParameter, timeParameter)

    End Function

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    ''' <param name="partitionKey">No Metadata Documentation available.</param>
    ''' <param name="rowKey">No Metadata Documentation available.</param>
    ''' <param name="place">No Metadata Documentation available.</param>
    ''' <param name="geoLocation">No Metadata Documentation available.</param>
    ''' <param name="time">No Metadata Documentation available.</param>
    Public Function UpdateTravel(partitionKey As Global.System.String, rowKey As Nullable(Of Global.System.Guid), place As Global.System.String, geoLocation As Global.System.String, time As Nullable(Of Global.System.DateTime)) As Integer
        Dim partitionKeyParameter As ObjectParameter
        If (partitionKey IsNot Nothing)
            partitionKeyParameter = New ObjectParameter("PartitionKey", partitionKey)
        Else
            partitionKeyParameter = New ObjectParameter("PartitionKey", GetType(Global.System.String))
        End If

        Dim rowKeyParameter As ObjectParameter
        If (rowKey.HasValue)
            rowKeyParameter = New ObjectParameter("RowKey", rowKey)
        Else
            rowKeyParameter = New ObjectParameter("RowKey", GetType(Global.System.Guid))
        End If

        Dim placeParameter As ObjectParameter
        If (place IsNot Nothing)
            placeParameter = New ObjectParameter("Place", place)
        Else
            placeParameter = New ObjectParameter("Place", GetType(Global.System.String))
        End If

        Dim geoLocationParameter As ObjectParameter
        If (geoLocation IsNot Nothing)
            geoLocationParameter = New ObjectParameter("GeoLocation", geoLocation)
        Else
            geoLocationParameter = New ObjectParameter("GeoLocation", GetType(Global.System.String))
        End If

        Dim timeParameter As ObjectParameter
        If (time.HasValue)
            timeParameter = New ObjectParameter("Time", time)
        Else
            timeParameter = New ObjectParameter("Time", GetType(Global.System.DateTime))
        End If

        Return MyBase.ExecuteFunction("UpdateTravel", partitionKeyParameter, rowKeyParameter, placeParameter, geoLocationParameter, timeParameter)

    End Function

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="TravelModel", Name:="Travel")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class Travel
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new Travel object.
    ''' </summary>
    ''' <param name="partitionKey">Initial value of the PartitionKey property.</param>
    ''' <param name="rowKey">Initial value of the RowKey property.</param>
    ''' <param name="place">Initial value of the Place property.</param>
    ''' <param name="time">Initial value of the Time property.</param>
    Public Shared Function CreateTravel(partitionKey As Global.System.String, rowKey As Global.System.Guid, place As Global.System.String, time As Global.System.DateTime) As Travel
        Dim travel as Travel = New Travel
        travel.PartitionKey = partitionKey
        travel.RowKey = rowKey
        travel.Place = place
        travel.Time = time
        Return travel
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property PartitionKey() As Global.System.String
        Get
            Return _PartitionKey
        End Get
        Set
            If (_PartitionKey <> Value) Then
                OnPartitionKeyChanging(value)
                ReportPropertyChanging("PartitionKey")
                _PartitionKey = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("PartitionKey")
                OnPartitionKeyChanged()
            End If
        End Set
    End Property

    Private _PartitionKey As Global.System.String
    Private Partial Sub OnPartitionKeyChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnPartitionKeyChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property RowKey() As Global.System.Guid
        Get
            Return _RowKey
        End Get
        Set
            If (_RowKey <> Value) Then
                OnRowKeyChanging(value)
                ReportPropertyChanging("RowKey")
                _RowKey = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("RowKey")
                OnRowKeyChanged()
            End If
        End Set
    End Property

    Private _RowKey As Global.System.Guid
    Private Partial Sub OnRowKeyChanging(value As Global.System.Guid)
    End Sub

    Private Partial Sub OnRowKeyChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Place() As Global.System.String
        Get
            Return _Place
        End Get
        Set
            OnPlaceChanging(value)
            ReportPropertyChanging("Place")
            _Place = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("Place")
            OnPlaceChanged()
        End Set
    End Property

    Private _Place As Global.System.String
    Private Partial Sub OnPlaceChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnPlaceChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Time() As Global.System.DateTime
        Get
            Return _Time
        End Get
        Set
            OnTimeChanging(value)
            ReportPropertyChanging("Time")
            _Time = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("Time")
            OnTimeChanged()
        End Set
    End Property

    Private _Time As Global.System.DateTime
    Private Partial Sub OnTimeChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnTimeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property GeoLocation() As Global.System.Byte()
        Get
                Return StructuralObject.GetValidValue(_GeoLocation)
        End Get
        Set
            OnGeoLocationChanging(value)
            ReportPropertyChanging("GeoLocation")
            _GeoLocation = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("GeoLocation")
            OnGeoLocationChanged()
        End Set
    End Property

    Private _GeoLocation As Global.System.Byte()
    Private Partial Sub OnGeoLocationChanging(value As Global.System.Byte())
    End Sub

    Private Partial Sub OnGeoLocationChanged()
    End Sub

    #End Region
End Class

#End Region