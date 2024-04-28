namespace ConsoleApp1
{
	internal class DoublyLinkedList
	{
		//Node class
		public class Node
		{
			//Instance variable
			private Node next = null;
			private Node prev = null;
			private object data = null;

			//Constructor
			public Node(Node prev, Node next, object data)
			{
				this.prev = prev;
				this.next = next;
				this.data = data;
			}

			//Getters 
			public object GetData() {return data;}
			public Node GetNext(){return next;}
			public Node GetPrev(){return prev;}

			//Setters 
			public void SetNext(Node next){this.next = next;}
			public void SetPrev(Node prev){this.prev = prev;}
		}

		//Instance variables
		private Node head = null;
		private Node tail = null;

		public Node GetHead() { return head;}	
		public Node GetTail() { return tail;}

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
				if (ptr.GetData().Equals(data)) //Check if the ptr data is equal to the requested data
				{
					return true; //Return true
				}

				ptr = ptr.GetNext(); //Move the ptr to the next node 
			}

			return false; //Return false if the requested data is not in the list
		}

		//Adds an element at the front of the list 
		public void AddFirst(object o)
		{
			Node newHead = new Node(null, head, o); // Create a new node and set its next, prev, and data
			if (head != null) // If the list is not empty
			{
				head.SetPrev(newHead); // Set the prev of the current head to the newHead
			}
			else // If this is the only node
			{
				tail = newHead; // Set tail to newHead
			}
			head = newHead; // Update head to newHead
		}

		//Adds an element at the end of the list
		public void AddLast(object o)
		{
			Node newTail = new Node(tail, null, o); // Create a new node and set its next, prev, and data
			if (tail != null) // If the list is not empty
			{
				tail.SetNext(newTail); // Set the next of the current tail to the newTail
			}
			else // If this is the only node
			{
				head = newTail; // Set head to newTail
			}
			tail = newTail; // Update tail to newTail
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

		//Insert a new node after the mentioned node  
		public void Insert(Node prev_node, object o)
		{
			//Check if the mentioned exists 
			if(prev_node == null)
			{
				Console.WriteLine("Mentioned node does not exist.");
				return;
			}

			Node next_node = prev_node.GetNext(); //Get the next node of the mentioned node 

			Node insertNode = new Node(prev_node, next_node, o); //Create a new node with prev as the mentioned node and next as the next node of the mentioned node 
			prev_node.SetNext(insertNode); //Set the next of the mentioned node to the new node 
		}

		//Remove a node with specified data
		public void Remove(object o)
		{
			//Check if the data if present in the list
			Node ptr = head;

			//Check if the list is empty
			if(ptr == null)
			{
				Console.WriteLine("The list is empty.");
			}

			//Loop through the list 
			while(ptr != null)
			{
				//Check if the removed data is the head 
				if (head.GetData().Equals(o))
				{
					//If the list has only one element 
					if(tail == head)
					{
						//Set both head and tail to null as it will become an empty list 
						head = null;
						tail = null;
					}
					else
					{
						head = ptr.GetNext(); //Move the head to the next node of the removed node 
						ptr.SetNext(null); //Set the next of removed node to null, thus removing it
					}

					Console.WriteLine("Removed data: " + o);
					return; //Exit the method
				}

				//If the removed data is anywhere but the head and tail
				if (ptr.GetData().Equals(o))
				{
					ptr.GetPrev().SetNext(ptr.GetNext()); //Set the next of the previous node of the removed node to the next node of the removed node 
					ptr.GetNext().SetPrev(ptr.GetPrev()); //Set the prev of the next node of the removed node to the prev of the removed node 
					Console.WriteLine("Removed data: " + o);

					return; //Exit the method
				}

				//If the removed data is in the tail
				if (tail.GetData().Equals(o))
				{
					// If the list contains only one node
					if (head == tail)
					{
						head = null;
						tail = null;
					}
					else
					{
						tail = tail.GetPrev(); // Move the tail to the previous node
						tail.SetNext(null); // Set the next of the new tail to null
					}

					Console.WriteLine("Removed data: " + o);
					return; //Exit the method 
				}

				else
				{
					ptr = ptr.GetNext(); //Move the pointer 
				}
			}
		}

		//Print the list in console in [a, b, c] format
		public string ToString()
		{
			Node ptr = head; //Create a new node and set it to head 
			string list = "["; //Open the list string
			while (ptr != null) //Loop through the loop 
			{
				list += ptr.GetData(); //Add the data of the ptr node in the list string
				if (ptr.GetNext() != null) //If the next data of the ptr node is not null
				{
					list += " <-> "; //Add a ', ' in the list 
				}

				ptr = ptr.GetNext(); //Move the ptr to its next node 
			}

			list += "]\n"; //Close the list string 
						   //string details = "Head: " + head.GetData() + "\nTail: " + tail.GetData(); //Shows the head and tail 
			return list;// + details; //Return the list, head and tail
		}
	}
}
