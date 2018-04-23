<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MyBarManager1 = New CustomTransparentBarItem.MyBarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.BarTransparentButtonItem1 = New CustomTransparentBarItem.BarTransparentButtonItem
        Me.BarTransparentButtonItem2 = New CustomTransparentBarItem.BarTransparentButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.MyBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyBarManager1
        '
        Me.MyBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.MyBarManager1.DockControls.Add(Me.barDockControlTop)
        Me.MyBarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.MyBarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.MyBarManager1.DockControls.Add(Me.barDockControlRight)
        Me.MyBarManager1.Form = Me
        Me.MyBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarTransparentButtonItem1, Me.BarTransparentButtonItem2})
        Me.MyBarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarTransparentButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarTransparentButtonItem2)})
        Me.Bar1.Text = "Tools"
        '
        'BarTransparentButtonItem1
        '
        Me.BarTransparentButtonItem1.Caption = "BarTransparentButtonItem1"
        Me.BarTransparentButtonItem1.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.BarTransparentButtonItem1.Id = 0
        Me.BarTransparentButtonItem1.LargeGlyph = CType(resources.GetObject("BarTransparentButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarTransparentButtonItem1.LargeGlyphHot = Global.Resources.hot
        Me.BarTransparentButtonItem1.LargeGlyphPressed = Global.Resources.pressed
        Me.BarTransparentButtonItem1.Name = "BarTransparentButtonItem1"
        '
        'BarTransparentButtonItem2
        '
        Me.BarTransparentButtonItem2.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Left
        Me.BarTransparentButtonItem2.Id = 1
        Me.BarTransparentButtonItem2.LargeGlyph = Global.Resources.normal
        Me.BarTransparentButtonItem2.LargeGlyphHot = Global.Resources.hot
        Me.BarTransparentButtonItem2.LargeGlyphPressed = Global.Resources.pressed
        Me.BarTransparentButtonItem2.Name = "BarTransparentButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(423, 48)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 262)
        Me.barDockControlBottom.Size = New System.Drawing.Size(423, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 48)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 214)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(423, 48)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 214)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 262)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MyBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyBarManager1 As CustomTransparentBarItem.MyBarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarTransparentButtonItem1 As CustomTransparentBarItem.BarTransparentButtonItem
    Friend WithEvents BarTransparentButtonItem2 As CustomTransparentBarItem.BarTransparentButtonItem
End Class
