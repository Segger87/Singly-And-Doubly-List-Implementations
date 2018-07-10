using System;

namespace ListImplementations.Lists
{
	public class Node
	{
		public string data;
		public Node next;

		public Node(string a)
		{
			data = a;
			next = null;
		}

		public void PrintNodes()
		{
			Console.WriteLine(data);
			//if the next node is not null continue to print out the node values (this works becaue next is a node itself)
			if(next != null)
			{
				next.PrintNodes();
			}
		}

		public void AddToEnd(string data)
		{
			//if next is null we know that is the end of the list
			if(next == null)
			{
				next = new Node(data);
			}
			else
			{
				next.AddToEnd(data);
			}
		}
	}
}
