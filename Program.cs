using System;
using Sphinx.Models;

namespace Sphinx 
{
	public class Program 
	{
		public static void Main()
		{
		Console.WriteLine("Riddles of the Sphinx. Enter the answer below to defeat the Sphinx:");
		int riddleNumber = Riddles.GetRandomNumber();
		Riddles.Question(riddleNumber);
		}
	}
}