using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimeter = "\n-------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine($"- bool is {sizeof(bool)} bytes, class Wrapper: {typeof(bool)}");
			Console.WriteLine(delimeter);
			Console.WriteLine($"- char is {sizeof(char)} bytes, range values: {(int)char.MinValue} - {(int)char.MaxValue}, class Wrapper: {typeof(char)}");
			Console.WriteLine(delimeter);
			Console.WriteLine($"- byte is {sizeof(byte)} bytes, range values: {byte.MinValue} - {byte.MaxValue}, class Wrapper: {typeof(byte)}");
			Console.WriteLine(delimeter);
			Console.WriteLine($"- sbyte is {sizeof(sbyte)} bytes, range values: {sbyte.MinValue} - {sbyte.MaxValue}, class Wrapper: {typeof(sbyte)}");
			Console.WriteLine(delimeter);

			bool rain = true;
			Console.WriteLine($"Rain go? - {rain}");
		}
	}
}
