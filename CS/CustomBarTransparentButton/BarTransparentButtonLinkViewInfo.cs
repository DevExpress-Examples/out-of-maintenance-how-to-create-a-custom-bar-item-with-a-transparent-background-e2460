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
