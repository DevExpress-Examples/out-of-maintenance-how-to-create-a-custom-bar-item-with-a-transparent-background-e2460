using System.ComponentModel;
using DevExpress.XtraBars;

namespace CustomTransparentBarItem
{
	public class MyBarManager : BarManager
	{
		public MyBarManager(IContainer container)
			: base(container)
		{
		}
		public MyBarManager()
			: base()
		{
			BarTransparentButtonItem.Register();
		}
	}
}
