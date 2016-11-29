using System;

namespace RSA
{
	internal class Program
	{
		public static int ReadIntFromConsole(string text)
		{
			while (true)
			{
				int number;
				Console.Write(text);
				if (int.TryParse(Console.ReadLine(), out number))
				{
					return number;
				}
			}
		}

		private static void Main(string[] args)
		{
			var p = ReadIntFromConsole("Введите параметры системы шифрования:\np = ");
			var q = ReadIntFromConsole("Введите параметры системы шифрования:\nq = ");
			var e = ReadIntFromConsole("Введите параметры системы шифрования:\ne = ");
			var d = ReadIntFromConsole("Введите параметры системы шифрования:\nd = ");
			while (true)
			{
				var m = ReadIntFromConsole("Введите сообщение для шифрования:\nm = ");
				var rsa = new RSA(p, q, e, d);
				var closeText = rsa.Encrypt(m);
				Console.WriteLine("После шифрования: {0}", closeText);
				Console.WriteLine("После расшифрования: {0}", rsa.Decrypt(closeText));
			}
		}
	}
}