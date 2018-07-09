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
	}
}
