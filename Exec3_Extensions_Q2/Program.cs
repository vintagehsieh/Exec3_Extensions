using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Extensions_Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//空字串
			string value = string.Empty;
			var result = value.Left(1);
			Console.WriteLine($"[Case1: 空字串]\r\n{result} 是空字串");
			Console.WriteLine();

			//輸入長度小於或等於0
			value = "This is a book.";
			result = value.Left(-1);
			Console.WriteLine($"[Case2: 輸入長度<=0]\r\n{result} 是空字串");
			Console.WriteLine();

			//輸入字串小於輸入長度
			value = "This is a book.";
			result = value.Left(100);
			Console.WriteLine($"[Case3: 輸入字串小於輸入長度]\r\n{result}");
			Console.WriteLine();

			//正常情況:擷取前四字
			value = "This is a book.";
			result = value.Left(4);
			Console.WriteLine($"[Case4: 一般擷取]\r\n{result}");
			Console.WriteLine();
		}
	}

	public static class ExtensionUtility
	{
		public static string Left (this string value, int length)
		{
			if (value == null || length <=0) return string.Empty;

			return (value.Length < length) ? value : value.Substring(0, length);
		}
	}
}
