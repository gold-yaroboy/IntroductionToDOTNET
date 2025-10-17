//#define CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Hello .NET");
            Console.WriteLine("Hello .NET");
            Console.WriteLine();
            Console.Title = "Introduction to .NET";
            Console.Beep(50, 2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("Set cursor position");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another position");
            Console.ResetColor();
#endif
			Console.Write("Enter your name: ");
			string firstname = Console.ReadLine();

			Console.Write("Enter your surname: ");
			string lastname = Console.ReadLine();

			Console.Write("Enter your age: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastname + " " + firstname + " " + age); //Конкатенация строк (сложение)
			Console.WriteLine(String.Format("{0} {1} {2}", lastname, firstname, age)); //Форматирование строк
			Console.WriteLine($"{lastname} {firstname} {age}"); //Интерполяция строк
		}
	}
}
