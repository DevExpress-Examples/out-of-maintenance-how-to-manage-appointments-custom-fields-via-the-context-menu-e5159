Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace DXApplication5
	Public Class CustomResource

		Public Sub New()

		End Sub

		Private _ResourceID As Integer
		Private _Name As String

		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property

		Public Property ResourceID() As Integer
			Get
				Return _ResourceID
			End Get
			Set(ByVal value As Integer)
				_ResourceID = value
			End Set
		End Property




	End Class
End Namespace
