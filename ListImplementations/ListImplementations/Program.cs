using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementations
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList list = new MyList();
			//list.AddToEnd("a");
			//list.AddToEnd("b");
			//list.AddToEnd("c");
			//list.AddToEnd("d");
			list.AddToBegninning("a");
			list.AddToBegninning("b");
			list.AddToBegninning("c");
			list.AddToBegninning("d");
			list.PrintList();
			Console.ReadLine();
		}
	}
}
