using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public int length()
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
		public Node nodeAt(int index)
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
			if (this.length() != other.length())
			{
				return false;
			}

			for (var i = 0; i < this.length(); i++)
			{
				if (this.nodeAt(i).data != other.nodeAt(i).data)
				{
					return false;
				}
			}

			return true;
		}
		//public override bool Equals(object obj)
		//{
		//	if (obj is null) return false;
		//	if (ReferenceEquals(this, obj)) return true;
		//	if (obj.GetType() != GetType()) return false;
		//	return Equals((MyList)obj);
		//}

		//public bool Equals(MyList other)
		//{
		//	if (this.headNode == null || other.headNode == null)
		//		return false;

		//	return this.headNode.data == other.headNode.data
		//		&& this.headNode.next.data == other.headNode.next.data;
		//}
		
		public override int GetHashCode()
		{
			var rnd = new Random();
			rnd.Next(0, 99);
			int hash = headNode.GetHashCode();
			hash = (hash * 31) + rnd.GetHashCode();
			return hash;
		}
	}
}
