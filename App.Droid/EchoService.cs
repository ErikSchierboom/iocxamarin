namespace App.Droid
{
    public class EchoService
    {
        private readonly UppercaseService uppercaseService;

        public EchoService(UppercaseService uppercaseService)
        {
            this.uppercaseService = uppercaseService;
        }

        public string Echo()
        {
            return this.uppercaseService.Uppercase("Hello World!");
        }
    }
}