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

Namespace CustomBarTransparentButton
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.myBarManager1 = New CustomTransparentBarItem.MyBarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.barTransparentButtonItem1 = New CustomTransparentBarItem.BarTransparentButtonItem()
            Me.barTransparentButtonItem2 = New CustomTransparentBarItem.BarTransparentButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            DirectCast(Me.myBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myBarManager1
            ' 
            Me.myBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
            Me.myBarManager1.DockControls.Add(Me.barDockControlTop)
            Me.myBarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.myBarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.myBarManager1.DockControls.Add(Me.barDockControlRight)
            Me.myBarManager1.Form = Me
            Me.myBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barTransparentButtonItem1, Me.barTransparentButtonItem2})
            Me.myBarManager1.MaxItemId = 3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barTransparentButtonItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barTransparentButtonItem2) _
            })
            Me.bar1.Text = "Tools"
            ' 
            ' barTransparentButtonItem1
            ' 
            Me.barTransparentButtonItem1.Caption = "barTransparentButtonItem1"
            Me.barTransparentButtonItem1.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
            Me.barTransparentButtonItem1.Id = 0
            Me.barTransparentButtonItem1.LargeGlyph = My.Resources.normal
            Me.barTransparentButtonItem1.LargeGlyphHot = My.Resources.hot
            Me.barTransparentButtonItem1.LargeGlyphPressed = My.Resources.pressed
            Me.barTransparentButtonItem1.Name = "barTransparentButtonItem1"
            ' 
            ' barTransparentButtonItem2
            ' 
            Me.barTransparentButtonItem2.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Left
            Me.barTransparentButtonItem2.Id = 1
            Me.barTransparentButtonItem2.LargeGlyph = My.Resources.normal
            Me.barTransparentButtonItem2.LargeGlyphHot = My.Resources.hot
            Me.barTransparentButtonItem2.LargeGlyphPressed = My.Resources.pressed
            Me.barTransparentButtonItem2.Name = "barTransparentButtonItem2"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(444, 48)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 262)
            Me.barDockControlBottom.Size = New System.Drawing.Size(444, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 48)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 214)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(444, 48)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 214)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(444, 262)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myBarManager1 As CustomTransparentBarItem.MyBarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private barTransparentButtonItem1 As CustomTransparentBarItem.BarTransparentButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barTransparentButtonItem2 As CustomTransparentBarItem.BarTransparentButtonItem

    End Class
End Namespace

