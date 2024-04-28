/* Stack is data structures that uses the LIFO 
 * (Last In, First Out) principle. This mean the 
 * element that is entered at the end will be the 
 * first one to be removed. Stack is used to create 
 * a dynamic collection that grows according to the 
 * programs need.
 */

using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
	//Stack using an array
	internal class Stack
	{
		//Instance variables
		private object[] stackArr;
		private int top;

		//Constructor
		public Stack(int MAX_STACK_SIZE)
		{
			stackArr = new object[MAX_STACK_SIZE];
			top = -1; //Top is -1 as arrays start from index 0. So setting top as -1 means an empty stack, as top being 0 means it has an element at index 0
		}

		//Add an element at the top of the stack
		public void Push(object data)
		{
			//Check if it is an empty stack
			if (top == stackArr.Length - 1)
			{
				throw new StackOverflowException("Stack is full.");
			}
			else
			{
				top++; //Increment top to the proper index 
				stackArr[top] = data; //Store the data in that index
			}
		}

		//Remove an element from the top
		public object Pop()
		{
			//Check if it is an empty stack
			if (top == -1)
			{
				throw new Exception("Stack is empty.");
			}
			else
			{
				object popedItem = stackArr[top]; //Store the top element in a variable 
				top--; //Decrement the top by 1, removing the top element from the stack
				return popedItem; //Return the removed element 
			}
		}

		//Shows the element at the top of the stack
		public object Peek()
		{
			//Check if it is an empty stack
			if (top == -1)
			{
				throw new Exception("Stack is empty.");
			}
			else
			{
				return stackArr[Count() - 1]; //Return the top element 
			}
		}

		//Method to check if the stack is empty
		public bool IsEmpty()
		{
			return top == -1; //As an empty stack means the top is set to -1, comparing our top with -1 will return the appropriate value 
		}

		//Method to return the total amount of element present in the stack
		public int Count()
		{
			return top + 1; //As top is equivalent to an array index, meaning it starts from 0 (unless it's an empty stack, then it will be -1) we need to add 1 to show to proper number of element(s) present 
		}

		//Removes all element form the stack 
		public void Clear()
		{
			top = -1; //Just setting top to -1 clears the stack
			Console.WriteLine("Cleared stack.");
		}

		//Check if a certain data is present in the stack 
		public bool Contains(object item)
		{
			//Iterate through the stack 
			for (int i = 0; i < Count(); i++)
			{
				//Checck if the data is present is the stack 
				if (stackArr[i].Equals(item))
				{
					return true;
				}
			}

			return false;
		}

		//Print the stack in console in [a, b, c] format
		public string ToString()
		{
			string array = "["; //Start of the stack string 

			//Iterate through the stack
			/*for(int i = 0; i < Count(); i++)
			{
				array += stackArr[i].ToString(); //Store the elements  in the string 
				if(i < Count() - 1)
				{
					array += ", "; //Seperate each elements 
				}
			}*/

			int count = top;

			while(count != -1)
			{
				array += stackArr[count].ToString();

				if (count != 0)
				{
					array += ", ";
				}

				count--;	 
			}

			array += "]"; //End of the string
			return array; //Output
		}
	}
}