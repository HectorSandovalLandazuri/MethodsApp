using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	public static class SampleMethods
	{
		public static void SayAuthor()
		{
			Console.WriteLine("*************");
			Console.WriteLine("Writen by: Héctor Sandoval");
			Console.WriteLine("for Mr Games");
			Console.WriteLine("*************");

		}

		public static void WelcomeUser(string firstName, string lastName)
		{
			Console.WriteLine($"Hola {firstName} {lastName}.");
		}

		public static string GetUserName(string message)
		{
			Console.Write(message);
			return Console.ReadLine();
		}
		//tuple allows to return several values
		public static (string firstName,string lastName) GetFullName() {
            Console.Write("What is your first name: ");
			string firstName = Console.ReadLine();
			Console.Write("What is your last name: ");
			string lastName = Console.ReadLine();
			return (firstName,lastName);
		}

	}
}
