using System;

namespace App.Droid
{
	public class UppercaseService
	{
		public string Uppercase(string str)
		{
			return str.ToUpperInvariant();
		}
	}
}