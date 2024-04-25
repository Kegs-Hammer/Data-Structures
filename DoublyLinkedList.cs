namespace ConsoleApp1
{
	internal class DoublyLinkedList
	{
		//Node class
		class Node
		{
			//Instance variable
			public Node next = null;
			public Node prev = null;
			public object data = null;

			//Constructor
			public Node(Node next, Node prev, object data)
			{
				this.next = next;
				this.prev = prev;
				this.data = data;
			}

			//Getters 
			public object GetData() {return this.data;}
			public Node GetNext(){return this.next;}
			public Node GetPrev(){return this.prev;}

			//Setters 
			public void SetNext(Node next){this.next = next;}
			public void SetPrev(Node prev){this.prev = prev;}
		}

		//Instance variables
		private Node head = null;
		private Node tail = null;

		//Retrieve the data of the head 
		public object GetFirst()
		{
			if(head != null) //Check if it is an empty list
			{
				return head.GetData(); //Return data present in the head
			}

			return null;
		}

		//Retrieve the data of the tail
		public object GetLast()
		{
			if(tail != null) //Check if is an empty list
			{
				return tail.GetData(); //Return data present in the tail
			}

			return null;
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

		//Adds an element at the front of the list 
		public void AddFirst(object o)
		{
			Node newHead = new Node(head, null, o); //Create a new node and set its next, prev and data
			if (tail == null) //If this is the only node 
			{
				tail = newHead; //Set tail to newHead
			}
			else
			{
				newHead.GetNext().SetPrev(newHead); //Set the prev of the previous head to the newHead
			}
		}

		//Adds an element at the end of the list
		public void AddLast(object o)
		{
			Node newTail = new Node(null, tail, o); //Create a new node and set its next, prev and data
			if (head == null) //If this is the only node
			{
				head = newTail; //Set head to newTail
			}
			else
			{
				newTail.GetPrev().SetNext(newTail); //Set the next of the previous tail to the newTail
			}
		}

		//Remove the first element of the list
		public object RemoveFirst()
		{
			Node removedHead = head; //Create a node and set it to head
			if(removedHead != null) //If is is not an empty list
			{
				head = removedHead.GetNext(); //Set head to the next node of the removedHead
				if(head == null) //If the new head is null
				{
					tail = null; //Set tail to null
				}
				else
				{
					head.SetPrev(null); //Else set the prev of the new head to null
				}

				return removedHead.GetData(); //Return the data of the removedHead
			}

			return null; //Else return null
		}

		//Remove the last element of the list
		public object RemoveLast()
		{
			Node removedTail = tail; //Create a node and set it to tail
			if (removedTail != null) //If it is not an empty list
			{
				tail = removedTail.GetPrev(); //Set tail to the previous node of the removedTail
				if(tail == null) //If the new tail is null
				{
					head = null; //Set head to null
				}
				else
				{
					tail.SetNext(null); //Else set the next of the new tail to null
				}

				return removedTail.GetData(); //Return the data of the removedTail
			}

			return null; //Else return null
		}


	}
}
