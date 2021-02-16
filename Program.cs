using System;
using System.Runtime.InteropServices;

namespace testlibraries
{

	class Program
	{
		static void Main(string[] args)
		{
			var text = "библеотека проверка";
			var checkResult = SpellCheckAPI.SpellCheck(text);
			Console.WriteLine(checkResult);
		}
	}
}