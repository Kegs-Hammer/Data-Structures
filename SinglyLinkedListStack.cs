namespace ConsoleApp1
{
	//Stack implementation with Sinhly linked list
	internal class SinglyLinkedListStack
	{
		//Instance variable
		SinglyLinkedList stack;

		//Constructor
		public SinglyLinkedListStack()
		{
			stack = new SinglyLinkedList();
		}

		//Add an element at the top of the stack
		public void Push(object data)
		{
			stack.AddFirst(data);
		}

		//Remove an element from the top
		public object Pop()
		{
			if (stack.Count() != 0)
			{
				return stack.RemoveFirst();
				
			}
			else
			{
				throw new Exception("The stack is empty.");
			}
		}

		//Shows the element at the top of the stack
		public object Peek()
		{
			return stack.GetFirst();
		}

		//Method to check if the stack is empty
		public bool IsEmpty()
		{
			return stack.Count() == 0;
		}

		//Method to return the total amount of element present in the stack
		public int Count()
		{
			return stack.Count();
		}

		//Removes all element form the stack 
		public void Clear()
		{
			if(stack.Count() == 0)
			{
				throw new Exception("Stack is empty.");
			}

			while(stack.Count() > 0)
			{
				stack.RemoveFirst();
			}

			Console.WriteLine("Cleared stack.");
		}

		//Check if a certain data is present in the stack
		public bool Contains(object data)
		{
			return stack.Contains(data);
		}

		//Print the stack in console in [a, b, c] format
		public string ToString()
		{
			return stack.ToString();
		}
	}
}
