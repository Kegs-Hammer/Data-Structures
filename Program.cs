namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//SLLTest();
			//DLLTest();
			Console.WriteLine("Array Stack: ");
			StackTest();
			Console.WriteLine("\nStack SLL: ");
			StackSLLTest();
		}

		public static void SLLTest()
		{
			SinglyLinkedList list = new();

			list.AddFirst("Alice");
			list.AddFirst("Bob");
			list.AddLast("Jack");
			list.AddFirst("Nami");
			list.AddLast("Lami");
			list.AddFirst("Quaso");
			list.RemoveFirst();

			Console.Write(list.ToString());
			Console.WriteLine("First Element: " + list.GetFirst());
			Console.WriteLine("Last Element: " + list.GetLast());
			Console.WriteLine("Contains Lisa: " + list.Contains("Lisa"));
			Console.WriteLine("Count: " + list.Count()); 
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

			Console.Write(dList.ToString());
			Console.WriteLine("\nContains 3: " + dList.Contains(3));
		}

		public static void StackTest()
		{
			Stack stack = new Stack(100);

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			Console.WriteLine("Popped item: " + stack.Pop());
			stack.Push(5);
			stack.Push(6);
			stack.Push(7);
			Console.WriteLine("Popped item: " + stack.Pop());
			stack.Push(8);
			stack.Push(9);
			stack.Push("Helen");

			Console.WriteLine("Count: " + stack.Count());
			//Console.WriteLine(stack.IsEmpty());
			Console.WriteLine(stack.ToString());
			Console.WriteLine("Top element: " + stack.Peek());
			Console.WriteLine("Contains 4: " + stack.Contains(4));
			Console.WriteLine("Contains 7: " + stack.Contains(7));
			Console.WriteLine("Contains Helen: " + stack.Contains("Helen"));
			stack.Clear();
			Console.WriteLine("Count: " + stack.Count());
			Console.WriteLine("Is Empty: " + stack.IsEmpty());
		}

		public static void StackSLLTest()
		{
			SinglyLinkedListStack stack = new SinglyLinkedListStack();

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			Console.WriteLine("Popped item: " + stack.Pop());
			stack.Push(5);
			stack.Push(6);
			stack.Push(7);
			Console.WriteLine("Popped item: " + stack.Pop());
			stack.Push(8);
			stack.Push(9);
			stack.Push("Helen");

			Console.WriteLine("Count: " + stack.Count());
			//Console.WriteLine(stack.IsEmpty());
			Console.Write(stack.ToString());
			Console.WriteLine("Top element: " + stack.Peek());
			Console.WriteLine("Contains 4: " + stack.Contains(4));
			Console.WriteLine("Contains 7: " + stack.Contains(7));
			Console.WriteLine("Contains Helen: " + stack.Contains("Helen"));
			stack.Clear();
			Console.WriteLine("Count: " + stack.Count());
			Console.WriteLine("Is Empty: " + stack.IsEmpty());
		}
	}
}
