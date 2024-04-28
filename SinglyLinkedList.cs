namespace ConsoleApp1
{
	internal class SinglyLinkedList
	{
		//Node class
		class Node
		{
			//Instance variables
			public Node next = null; 
			public object data = null;
		}
		
		//Instance variable
		private Node head;
		private Node tail;
		private int count;

		public SinglyLinkedList() 
		{
			head = null;
			tail = null;
			count = 0;
		}

		//Add an element at the front of the list 
		public void	AddFirst(object o)
		{
			Node newHead = new Node(); //Create a new node
			newHead.data = o; //Insert data in the node
			newHead.next = head; //Set the next of the newHead to the previous head
			head = newHead; //Set head to the newHead 

			if(tail == null) //If the tail is null
			{
				tail = newHead; //Set tail to the newHead 
			}
		}

		//Add element to the tail of the list
		public void AddLast(object o)
		{
			Node newTail = new Node(); //Create a new node
			newTail.data = o; //Insert data in the node
			newTail.next = null; //Set the next of the new tail as null as it is the last entry in the list
			
			if(tail == null) //Check if there is no tail
			{
				head = newTail; //If so, set head to newTail
			}
			else
			{
				tail.next = newTail; //Else, set the next of the previous tail to newTail
			}

			tail = newTail; //Set tail to the newTail
		}

		//Retrieve the object present in the head
		public object GetFirst()
		{
			if(head != null) //Check if it is an empty list 
			{
				return head.data; //Return the data present in the head
			}

			return null; //If the list is empty, return null
		}

		//Retrieve the object present in the tail
		public object GetLast()
		{ 
			if(tail != null) //Check if it is an empty list 
			{
				return tail.data; //Return the data present in the tail
			}

			return null; //If the list is empty, return null
		}
		
		//Remove the first element (head) of the list 
		public object RemoveFirst()
		{
			Node removedHead = head; //Create a new node and set it to head 
			if(removedHead != null) //Check if the removeHead has data in it
			{
				head = removedHead.next; //Set head to the next node of removedHead 
				removedHead.next = null; //Set the next of the removedHead to null 
				if(head == null) //Check if the new head (the node after the removedHead) is null
				{
					tail = null; //Set tail to null
				}

				return removedHead.data; //Return the data removed 
			}

			return null; //Return null
		}

		//Check if a certain data is present in the list 
		public bool Contains(object data)
		{
			Node ptr = head; //Create a node and set it to head 
			while (ptr != null) //Loop till reaching tail
			{
				if (ptr.data.Equals(data)) //Check if the ptr data is equal to the requested data
				{
					return true; //Return true
				}

				ptr = ptr.next; //Move the ptr to the next node 
			}

			return false; //Return false if the requested data is not in the list
		}

		//Counts the length of the list
		public int Count()
		{
			count = 0;

			Node ptr = head; //Set a pointer node to head
			while (ptr != null)  //Iterate through the list
			{
				if(ptr.data != null) //Check if the current node's data is not null
				{
					count++; //Increment count
				}

				ptr = ptr.next; //Move the pointer to the next node 
			}

			return count; //Return count
		}

		//Print the list in console in [a, b, c] format
		public string ToString()
		{
			Node ptr = head; //Create a new node and set it to head 
			string list = "["; //Open the list string
			while(ptr != null) //Loop through the loop 
			{
				list += ptr.data; //Add the data of the ptr node in the list string
				if(ptr.next != null ) //If the next data of the ptr node is not null
				{
					list += " -> "; //Add a ', ' in the list 
				}

				ptr = ptr.next; //Move the ptr to its next node 
			}

			list += "]\n"; //Close the list string 
			return list; //Return the list 
		}
	}
} 