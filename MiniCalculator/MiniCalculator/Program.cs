using System;

namespace MiniCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Mini Calculator!");

			Console.Write("Enter the 1st number: ");
			double number1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter the 2nd number: ");
			double number2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Choose an operation (+, -, *, /):");
			string operation = Console.ReadLine();

			double result = 0;
			bool validOperation = true;

			switch (operation)
			{
				case "+":
					result = number1 + number2;
					break;
				case "-":
					result = number1 - number2;
					break;
				case "*":
					result = number1 * number2;
					break;
				case "/":
					if (number2 != 0)
						result = number1 / number2;
					else
					{
						Console.WriteLine("Division by zero error!");
						validOperation = false;
					}
					break;
				default:
					Console.WriteLine("Invalid operation selected!");
					validOperation = false;
					break;
			}

			if (validOperation)
			{
				Console.WriteLine($"Result: {result}");
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}