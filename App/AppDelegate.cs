using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TinyIoC;

namespace App
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		public override UIWindow Window { get; set; }

		public override void FinishedLaunching(UIApplication application)
		{
			// Auto-register all types with TinyIoC. After this call, we will be able to
			// resolve components/services using TinyIocC
			TinyIoCContainer.Current.AutoRegister();
		}
	}
}

