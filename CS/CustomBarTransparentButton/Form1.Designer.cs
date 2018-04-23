namespace CustomBarTransparentButton
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.myBarManager1 = new CustomTransparentBarItem.MyBarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.barTransparentButtonItem1 = new CustomTransparentBarItem.BarTransparentButtonItem();
			this.barTransparentButtonItem2 = new CustomTransparentBarItem.BarTransparentButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)(this.myBarManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// myBarManager1
			// 
			this.myBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
			this.myBarManager1.DockControls.Add(this.barDockControlTop);
			this.myBarManager1.DockControls.Add(this.barDockControlBottom);
			this.myBarManager1.DockControls.Add(this.barDockControlLeft);
			this.myBarManager1.DockControls.Add(this.barDockControlRight);
			this.myBarManager1.Form = this;
			this.myBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barTransparentButtonItem1,
            this.barTransparentButtonItem2});
			this.myBarManager1.MaxItemId = 3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTransparentButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barTransparentButtonItem2)});
			this.bar1.Text = "Tools";
			// 
			// barTransparentButtonItem1
			// 
			this.barTransparentButtonItem1.Caption = "barTransparentButtonItem1";
			this.barTransparentButtonItem1.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
			this.barTransparentButtonItem1.Id = 0;
			this.barTransparentButtonItem1.LargeGlyph = global::CustomBarTransparentButton.Properties.Resources.normal;
			this.barTransparentButtonItem1.LargeGlyphHot = global::CustomBarTransparentButton.Properties.Resources.hot;
			this.barTransparentButtonItem1.LargeGlyphPressed = global::CustomBarTransparentButton.Properties.Resources.pressed;
			this.barTransparentButtonItem1.Name = "barTransparentButtonItem1";
			// 
			// barTransparentButtonItem2
			// 
			this.barTransparentButtonItem2.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Left;
			this.barTransparentButtonItem2.Id = 1;
			this.barTransparentButtonItem2.LargeGlyph = global::CustomBarTransparentButton.Properties.Resources.normal;
			this.barTransparentButtonItem2.LargeGlyphHot = global::CustomBarTransparentButton.Properties.Resources.hot;
			this.barTransparentButtonItem2.LargeGlyphPressed = global::CustomBarTransparentButton.Properties.Resources.pressed;
			this.barTransparentButtonItem2.Name = "barTransparentButtonItem2";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(444, 48);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 262);
			this.barDockControlBottom.Size = new System.Drawing.Size(444, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 214);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(444, 48);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 214);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 262);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.myBarManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomTransparentBarItem.MyBarManager myBarManager1;
		private DevExpress.XtraBars.Bar bar1;
		private CustomTransparentBarItem.BarTransparentButtonItem barTransparentButtonItem1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private CustomTransparentBarItem.BarTransparentButtonItem barTransparentButtonItem2;

	}
}

