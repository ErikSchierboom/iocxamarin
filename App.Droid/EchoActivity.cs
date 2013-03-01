using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TinyIoC;

namespace App.Droid
{
	[Activity (Label = "App.Droid", MainLauncher = true)]
	public class EchoActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "echo" layout resource
			SetContentView (Resource.Layout.Echo);

			// As we already registered the components/services in the AppDelegate's FinishedLaunching
			// method, we can now resolve components/services
			var echoService = TinyIoCContainer.Current.Resolve<EchoService>();

			var echoTextView = FindViewById<TextView> (Resource.Id.echoTextView);
			echoTextView.Text = echoService.Echo();
		}
	}
}


