using System;
using ListImplementations.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListImplementations.UnitTest
{
	[TestClass]
	public class DoublyLinkedListTest
	{
		[TestMethod]
		public void Empty_List_HeadNode_Returns_Null()
		{
			//Arrange
			var list = new DoublyLinkedList();

			//Assert
			Assert.IsNull(list.headNode);
		}

		[TestMethod]
		public void List_AddToBeginning_IsEqual()
		{
			//Arrange
			var list = new DoublyLinkedList();
			var list2 = new DoublyLinkedList();

			//Act 
			list.AddToBeginning("a");
			list.AddToBeginning("b");
			list.AddToBeginning("c");

			list2.AddToBeginning("a");
			list2.AddToBeginning("b");
			list2.AddToBeginning("c");

			//Assert

			Assert.IsTrue(list.Equals(list2));
		}
		[TestMethod]
		public void List_AddToBeginning_IsNotEqual()
		{
			//Arrange
			var list = new DoublyLinkedList();
			var list2 = new DoublyLinkedList();

			//Act 
			list.AddToBeginning("a");
			list.AddToBeginning("b");
			list.AddToBeginning("c");

			list2.AddToBeginning("a");
			list2.AddToBeginning("b");
			list2.AddToBeginning("a");

			//Assert

			Assert.IsFalse(list.Equals(list2));
		}
		[TestMethod]
		public void List_AddToEnd_IsNotEqual()
		{
			//Arrange
			var list = new DoublyLinkedList();
			var list2 = new DoublyLinkedList();

			//Act 
			list.AddToEnd("a");
			list.AddToEnd("b");
			list.AddToEnd("c");

			list2.AddToEnd("a");
			list2.AddToEnd("b");
			list2.AddToEnd("a");

			//Assert

			Assert.IsFalse(list.Equals(list2));
		}
		[TestMethod]
		public void List_AddToEnd_IsEqual()
		{
			//Arrange
			var list = new DoublyLinkedList();
			var list2 = new DoublyLinkedList();

			//Act 
			list.AddToEnd("a");
			list.AddToEnd("b");
			list.AddToEnd("c");

			list2.AddToEnd("a");
			list2.AddToEnd("b");
			list2.AddToEnd("c");

			//Assert

			Assert.IsTrue(list.Equals(list2));
		}
		[TestMethod]
		public void Doubly_List_Delete_Specified_Node_IsTrue()
		{
			//Arrange
			var list = new DoublyLinkedList();
			var list2 = new DoublyLinkedList();

			//Act 
			list.AddToBeginning("beastmodeBarry");
			list.AddToBeginning("BarryModeBeast");
			list.AddToBeginning("jesus");
			list.DeleteNode("jesus");

			list2.AddToBeginning("beastmodeBarry");
			list2.AddToBeginning("BarryModeBeast");

			//Assert
			Assert.IsTrue(list.Equals(list2));
		}
	}
}
