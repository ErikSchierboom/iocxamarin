using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TinyIoC;

namespace App.iOS
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
			// Register the UppercaseService and EchoService classes with TinyIoC
            TinyIoCContainer.Current.Register<UppercaseService>();
            TinyIoCContainer.Current.Register<EchoService>();

            // Note: it is allo possible to auto-register all types with TinyIoC using:
            // TinyIoCContainer.Current.AutoRegister();
		}
	}
}

