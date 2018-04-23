Imports Microsoft.VisualBasic
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
