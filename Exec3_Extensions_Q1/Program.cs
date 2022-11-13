using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Extensions_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random(Guid.NewGuid().GetHashCode());
			int number = random.Next();

			if (number.isOdd()) Console.WriteLine($"{number} 是奇數");
			if (number.isEven()) Console.WriteLine($"{number} 是偶數");

		}
	}

	public static class ExtensionUtility
	{
		public static bool isOdd(this int source) => (source % 2 != 0);

		public static bool isEven (this int source) => (source % 2 == 0);
	}
}
