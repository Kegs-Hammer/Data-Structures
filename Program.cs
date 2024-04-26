using System.Collections;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//SLLTest();
			//DLLTest();
		}

		public static void SLLTest()
		{
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

		public static void DLLTest()
		{
			DoublyLinkedList dList = new();
			dList.AddFirst(1); 
			dList.AddFirst(2);
			dList.AddFirst(3);
			dList.AddLast(5); 
			dList.AddLast(6);
			dList.AddLast(7);
			
			DoublyLinkedList.Node prev_node = dList.GetHead();
			dList.Insert(prev_node, 9);
			dList.Insert(prev_node, 10);
			prev_node = dList.GetTail();
			dList.Insert(prev_node, 11);
			dList.AddFirst(12);
			dList.AddLast(13);
			dList.AddLast(14);
			dList.AddLast(15);
			dList.AddLast(16);
			dList.AddLast(17);
			dList.AddLast(18);
			dList.Remove(5);

			Console.Write(dList.ShowList());
			Console.WriteLine("\nContains 3: " + dList.Contains(3));
		}
	}
}
