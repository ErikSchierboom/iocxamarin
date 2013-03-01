using System;

namespace App.iOS
{
	public class UppercaseService
	{
		public string Uppercase(string str)
		{
			return str.ToUpperInvariant();
		}
	}
}