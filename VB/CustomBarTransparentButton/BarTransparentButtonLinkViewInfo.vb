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

Imports System.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.ViewInfo

Namespace CustomTransparentBarItem
    Public Class BarTransparentButtonLinkViewInfo
        Inherits BarLargeButtonLinkViewInfo

        Public Sub New(ByVal parameters As BarDrawParameters, ByVal link As BarItemLink)
            MyBase.New(parameters, link)
            AllowDrawBackground = False
        End Sub

        Protected Overrides Sub CalcLinkLargeImage(ByVal state As BarLinkState, ByRef index As Integer, ByRef image As Image)
            If state = BarLinkState.Pressed Then
                image = CType(Link.Item, BarTransparentButtonItem).LargeGlyphPressed
                index = CType(Link.Item, BarTransparentButtonItem).LargeImageIndexPressed
                Return
            End If

            MyBase.CalcLinkLargeImage(state, index, image)
        End Sub
    End Class
End Namespace
