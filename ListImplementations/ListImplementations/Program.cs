using System;

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
			list.AddToBeginning("a");
			list.AddToBeginning("b");
			list.AddToBeginning("c");
			//list.AddToBeginning("d");
			list.PrintList();
			MyList list2 = new MyList();
			//list.AddToEnd("a");
			//list.AddToEnd("b");
			//list.AddToEnd("c");
			//list.AddToEnd("d");
			list2.AddToBeginning("a");
			list2.AddToBeginning("b");
			list2.AddToBeginning("c");
			list2.PrintList();

			Console.WriteLine(list.Equals(list2));

			Console.ReadLine();
		}
	}
}
