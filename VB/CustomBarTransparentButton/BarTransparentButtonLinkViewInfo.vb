Imports Microsoft.VisualBasic
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
				image = (CType(Link.Item, BarTransparentButtonItem)).LargeGlyphPressed
				index = (CType(Link.Item, BarTransparentButtonItem)).LargeImageIndexPressed
				Return
			End If

			MyBase.CalcLinkLargeImage(state, index, image)
		End Sub
	End Class
End Namespace
