Imports Telerik.WinControls.UI

Public Class CustomDragDropService
    Inherits RadGridViewDragDropService
    Public Sub New(gridViewElement As RadGridViewElement)
        MyBase.New(gridViewElement)
    End Sub
    Public Overrides ReadOnly Property Name() As String
        Get
            Return GetType(RadGridViewDragDropService).Name
        End Get
    End Property
End Class