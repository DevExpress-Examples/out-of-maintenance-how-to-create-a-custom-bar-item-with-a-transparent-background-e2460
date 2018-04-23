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

Imports System
Imports System.Windows.Forms

Namespace CustomBarTransparentButton
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
