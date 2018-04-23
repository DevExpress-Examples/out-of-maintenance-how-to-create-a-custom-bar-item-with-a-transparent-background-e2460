' Developer Express Code Central Example:
' How to create a custom bar item with a transparent background
' 
' This sample demonstrates how to create a custom bar item with a transparent
' background. As an ancestor of a custom bar item the BarLargeButtonItem control
' has been chosen. This approach can be used to create items with a custom shape
' by adding images to the LargeGlyph, LargeGlyphHot and LargeGlyphPressed
' properties.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2460

Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles

Namespace CustomTransparentBarItem
    Public Class BarTransparentButtonItem
        Inherits BarLargeButtonItem

        Public Const BaseBarItemName As String = "BarLargeButtonItem"
        Public Const BarItemName As String = "BarTransparentButtonItem"
        Public Const BarItemCaption As String = "Transparent button"


        Private largeGlyphPressed_Renamed As Image

        Private largeImageIndexPressed_Renamed As Integer

        Shared Sub New()
            Register()
        End Sub
        Public Shared Sub Register()
            Register(BarAndDockingController.Default)
        End Sub
        Public Shared Sub Register(ByVal controller As BarAndDockingController)
            Register(controller.PaintStyles)
        End Sub
        Public Shared Sub Register(ByVal styles As BarManagerPaintStyleCollection)
            For i As Integer = 0 To styles.Count - 1
                Dim paintStyle As BarManagerPaintStyle = styles(i)
                Dim list As BarItemInfo = paintStyle.ItemInfoCollection(BaseBarItemName)
                If list IsNot Nothing AndAlso paintStyle.ItemInfoCollection(BarItemName) Is Nothing Then
                    paintStyle.ItemInfoCollection.Add(New BarItemInfo(BarItemName, BarItemCaption, -1, GetType(BarTransparentButtonItem), list.LinkType, GetType(BarTransparentButtonLinkViewInfo), list.LinkPainter, True, False))
                End If
            Next i
        End Sub

        Public Sub New()
            MyBase.New()
            largeGlyphPressed_Renamed = Nothing
            largeImageIndexPressed_Renamed = -1
        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal caption As String)
            MyBase.New(manager, caption)
        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal imageIndex As Integer)
            MyBase.New(manager, caption, imageIndex)
        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal imageIndex As Integer, ByVal shortcut As BarShortcut)
            MyBase.New(manager, caption, imageIndex, shortcut)
        End Sub

        <Description("Gets or sets the large image displayed within associated links when they are pressed."), System.ComponentModel.DefaultValue(CType(Nothing, Object)), Category("Appearance")> _
        Public Overridable Property LargeGlyphPressed() As Image
            Get
                Return largeGlyphPressed_Renamed
            End Get
            Set(ByVal value As Image)
                If LargeGlyphHot Is value Then
                    Return
                End If
                largeGlyphPressed_Renamed = UpdateImage(value)
                OnItemChanged()
            End Set
        End Property

        <Description("Gets or sets the index of the large image displayed within associated links when they are pressed."), DefaultValue(-1), Category("Appearance"), Editor(GetType(DevExpress.Utils.Design.ImageIndexesEditor), GetType(UITypeEditor)), ImageList("LargeImages")> _
        Public Overridable Property LargeImageIndexPressed() As Integer
            Get
                Return largeImageIndexPressed_Renamed
            End Get
            Set(ByVal value As Integer)
                If LargeImageIndexHot = value Then
                    Return
                End If
                largeImageIndexPressed_Renamed = value
                OnItemChanged()
            End Set
        End Property
    End Class
End Namespace
