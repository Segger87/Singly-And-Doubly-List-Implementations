using ListImplementations.Lists;
using System;

namespace ListImplementations
{
	class Program
	{
		static void Main(string[] args)
		{
			SinglyLinkedList list = new SinglyLinkedList();
			list.AddToEnd("a");
			list.AddToEnd("b");
			list.AddToEnd("w");
			list.AddToEnd("d");
			list.AddToBeginning("a");
			list.AddToBeginning("a");
			list.AddToBeginning("e");
			list.AddToBeginning("d");

			list.PrintList();
			SinglyLinkedList list2 = new SinglyLinkedList();
			list2.AddToEnd("a");
			list2.AddToEnd("b");
			list2.AddToEnd("w");
			list2.AddToEnd("d");
			list2.AddToBeginning("a");
			list2.AddToBeginning("a");
			list2.AddToBeginning("e");
			list2.AddToBeginning("d");
			list2.PrintList();

			var doubly = new DoublyLinkedList();
			doubly.AddToEnd(doubly,"bob");
			doubly.AddToEnd(doubly, "peter");
			doubly.AddToEnd(doubly, "gary");

			var doubly2 = new DoublyLinkedList();
			doubly2.AddToEnd(doubly2,"bob");
			doubly2.AddToEnd(doubly2,"peter");
			doubly2.AddToEnd(doubly2,"gary");

			doubly2.DeleteNode(doubly2, "peter");
			doubly2.PrintList();

			Console.WriteLine(list.Equals(list2));
			Console.WriteLine(doubly.Equals(doubly2));
			Console.ReadLine();
		}
	}
}
