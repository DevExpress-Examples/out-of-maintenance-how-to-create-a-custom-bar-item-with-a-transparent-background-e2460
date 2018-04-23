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
Imports DevExpress.XtraBars

Namespace CustomTransparentBarItem
    Public Class MyBarManager
        Inherits BarManager

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
        End Sub
        Public Sub New()
            MyBase.New()
            BarTransparentButtonItem.Register()
        End Sub
    End Class
End Namespace
