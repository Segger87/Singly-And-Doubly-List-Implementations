using System;

namespace ListImplementations.Lists
{
	public class DoublyLinkedList
	{
		public DoubleNode headNode;

		public DoublyLinkedList()
		{
			headNode = null;
		}

		public void PrintList()
		{
			if (headNode != null)
			{
				headNode.PrintNodes();
			}
		}
		public void AddToBeginning(string data)
		{
			var newNode = new DoubleNode(data);

			newNode.next = headNode;
			newNode.previous = null;

			if (headNode != null)
			{
				headNode.previous = headNode;
			}

			headNode = newNode;
		}

		public DoubleNode GetLastNode(DoubleNode doublyList)
		{
			DoubleNode temp = headNode;
			while (temp.next != null)
			{
				temp = temp.next;
			}
			return temp;
		}
		public void AddToEnd(string data)
		{
			var newNode = new DoubleNode(data);

			if (headNode == null)
			{
				headNode = newNode;
				return;
			}
			var lastNode = GetLastNode(this.headNode);
			lastNode.next = newNode;
			newNode.previous = lastNode;
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
		public DoubleNode NodeAt(int index)
		{
			var node = this.headNode;
			while (index > 0)
			{
				index--;
				node = node.next;
			}
			return node;
		}

		public void FindNode(string search)
		{
			for (int i = 0; i < this.Length(); i++)
			{
				if (this.NodeAt(i).data == search)
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

		public bool Equals(DoublyLinkedList other)
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
			DoubleNode temp = this.headNode;
			if (temp != null && temp.data == key)
			{
				this.headNode = temp.next;
				this.headNode.previous = null;
				return;
			}
			while (temp != null && temp.data != key)
			{
				temp = temp.next;
			}
			if (temp == null)
			{
				return;
			}
			if (temp.next != null)
			{
				temp.next.previous = temp.previous;
			}
			if(temp.previous != null)
			{
				temp.previous.next = temp.next;
			}
		}
	}
}
