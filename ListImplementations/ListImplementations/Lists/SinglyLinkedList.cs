using System;

namespace ListImplementations.Lists
{
	public class SinglyLinkedList
	{
		public Node headNode;

		public SinglyLinkedList()
		{
			//defaults to null when you first create a list.
			headNode = null;
		}

		public void AddToEnd(string data)
		{
			if(headNode == null)
			{
				headNode = new Node(data);
			}
			else
			{
				//headnode is valid as it !=null
				headNode.AddToEnd(data);
			}
		}

		public void AddToBeginning(string data)
		{
			if(headNode == null)
			{
				headNode = new Node(data);
			}
			else
			{
				Node temp = new Node(data);
				temp.next = headNode;
				headNode = temp;
			}
		}

		public void PrintList()
		{
			if(headNode != null)
			{
				headNode.PrintNodes();
			}
		}
		public int Length()
		{
			var length = 0;
			var node = this.headNode;
			while (node != null)
			{
				length++;
				node = node.next;
			}
			return length;
		}

		// warning negative index will return head
		public Node NodeAt(int index)
		{
			var node = this.headNode;
			while (index > 0)
			{
				index--;
				node = node.next;
			}
			return node;
		}
		
		public bool Equals(SinglyLinkedList other)
		{
			if (this.Length() != other.Length())
			{
				return false;
			}

			for (var i = 0; i < this.Length(); i++)
			{
				if (this.NodeAt(i).data != other.NodeAt(i).data)
				{
					return false;
				}
			}

			return true;
		}
		
		public void FindNode(string search)
		{
			for (int i = 0; i < this.Length(); i++)
			{
				if(this.NodeAt(i).data == search)
				{
					Console.WriteLine($"There is a node that matches your search criteria of {search}");
				}
				else
				{
					Console.WriteLine("Sorry there is no match");
					return;
				}
			}
		}
		public override int GetHashCode()
		{
			var rnd = new Random();
			rnd.Next(0, 99);
			int hash = headNode.GetHashCode();
			hash = (hash * 31) + rnd.GetHashCode();
			return hash;
		}

		public void DeleteNode(string key)
		{
			Node temp = this.headNode;
			Node previous = null;
			if(temp != null && temp.data == key)
			{
				this.headNode = temp.next;
				return;
			}
			while(temp != null && temp.data != key)
			{
				previous = temp;
				temp = temp.next;
			}
			if(temp == null)
			{
				return;
			}
			previous.next = temp.next;
		}
	}
}
