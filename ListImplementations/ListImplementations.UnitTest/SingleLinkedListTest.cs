﻿using ListImplementations.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ListImplementations.UnitTest
{
	[TestClass]
	public class SingleLinkedListTest
	{
		[TestMethod]
		public void Empty_List_HeadNode_Returns_Null()
		{
			//Arrange
			var list = new SinglyLinkedList();

			//Assert
			Assert.IsNull(list.headNode);
		}

		[TestMethod]
		public void List_AddToBeginning_IsEqual()
		{
			//Arrange
			var list = new SinglyLinkedList();
			var list2 = new SinglyLinkedList();

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
			var list = new SinglyLinkedList();
			var list2 = new SinglyLinkedList();

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
			var list = new SinglyLinkedList();
			var list2 = new SinglyLinkedList();

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
			var list = new SinglyLinkedList();
			var list2 = new SinglyLinkedList();

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
	}
}
