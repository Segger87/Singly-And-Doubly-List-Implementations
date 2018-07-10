using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementations.Lists
{
	public class DoubleNode
	{
		public string data;
		public DoubleNode next;
		public DoubleNode previous;

		public DoubleNode(string a)
		{
			data = a;
			next = null;
			previous = null;
		}
		public void PrintNodes()
		{
			Console.WriteLine(data);
			//if the next node is not null continue to print out the node values (this works becaue next is a node itself)
			if (next != null)
			{
				next.PrintNodes();
			}
		}

	}
}
