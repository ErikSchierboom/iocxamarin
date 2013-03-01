using System;

namespace App
{
	public class UppercaseService
	{
		public string Uppercase(string str)
		{
			return str.ToUpperInvariant();
		}
	}
}