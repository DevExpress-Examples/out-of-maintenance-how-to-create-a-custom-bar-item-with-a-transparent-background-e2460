// Developer Express Code Central Example:
// How to create a custom bar item with a transparent background
// 
// This sample demonstrates how to create a custom bar item with a transparent
// background. As an ancestor of a custom bar item the BarLargeButtonItem control
// has been chosen. This approach can be used to create items with a custom shape
// by adding images to the LargeGlyph, LargeGlyphHot and LargeGlyphPressed
// properties.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2460

using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ViewInfo;

namespace CustomTransparentBarItem
{
	public class BarTransparentButtonLinkViewInfo : BarLargeButtonLinkViewInfo
	{
		public BarTransparentButtonLinkViewInfo(BarDrawParameters parameters, BarItemLink link)
			: base(parameters, link)
		{
			AllowDrawBackground = false;
		}

		protected override void CalcLinkLargeImage(BarLinkState state, ref int index, ref Image image)
		{
			if ( state == BarLinkState.Pressed )
			{
				image = ((BarTransparentButtonItem)Link.Item).LargeGlyphPressed;
				index = ((BarTransparentButtonItem)Link.Item).LargeImageIndexPressed;
				return;
			}

			base.CalcLinkLargeImage(state, ref index, ref image);
		}
	}
}
