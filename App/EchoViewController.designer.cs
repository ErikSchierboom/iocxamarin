// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace App
{
	[Register ("EchoViewController")]
	partial class EchoViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel EchoLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (EchoLabel != null) {
				EchoLabel.Dispose ();
				EchoLabel = null;
			}
		}
	}
}
