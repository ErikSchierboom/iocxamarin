using System;

namespace App.iOS
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