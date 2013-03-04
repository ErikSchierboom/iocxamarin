namespace App.Droid
{
    using Android.App;
    using Android.OS;
    using Android.Widget;

    using TinyIoC;

    [Activity(Label = "IoC Demo", MainLauncher = true)]
    public class EchoActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "echo" layout resource
            this.SetContentView(Resource.Layout.Echo);

            // Register the UppercaseService and EchoService classes with TinyIoC
            TinyIoCContainer.Current.Register<UppercaseService>();
            TinyIoCContainer.Current.Register<EchoService>();

            // Note: it is allo possible to auto-register all types with TinyIoC using:
            // TinyIoCContainer.Current.AutoRegister();

            // As we have registered the EchoService (and its dependent) classes, we can now
            // resolve the class using TinyIoC
            var echoService = TinyIoCContainer.Current.Resolve<EchoService>();

            // Use the resolved EchoService instance to output text to the screen
            var echoTextView = this.FindViewById<TextView>(Resource.Id.echoTextView);
            echoTextView.Text = echoService.Echo();
        }
    }
}