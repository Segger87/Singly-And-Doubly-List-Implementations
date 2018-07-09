using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementations
{
	public class MyList
	{
		public Node headNode;

		public MyList()
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
				//headnode is valid as it is !=null
				headNode.AddToEnd(data);
			}
		}

		public void AddToBegninning(string data)
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
	}
}
