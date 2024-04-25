using System.Collections;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");

			SinglyLinkedList list = new();

			list.AddFirst("Alice");
			list.AddFirst("Bob");
			list.AddLast("Jack");
			list.AddFirst("Nami");
			list.RemoveFirst();

			Console.Write(list.ShowList());
			Console.WriteLine("First Element: " + list.GetFirst());
			Console.WriteLine("Last Element: " + list.GetLast());
			Console.WriteLine("Contains Lisa: " + list.Contains("Lisa"));
		}
	}
}
