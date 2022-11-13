using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Extensions_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入您想要轉換型別的值: ");
			string value = Console.ReadLine();

			//失敗傳回-1
			Console.WriteLine(value.ToInt(-1));

			
		}
	}

	public static class ExtensionUtility
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isInt = int.TryParse(value, out int number);
			return isInt ? number : defaultValue;
		}
	}
}
