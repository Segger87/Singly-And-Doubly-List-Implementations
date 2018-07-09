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
			var list = new MyList();

			//Assert
			Assert.IsNull(list.headNode);
		}

		[TestMethod]
		public void List_AddToBeginning_HeadNode_IsEqual()
		{
			//Arrange
			var list = new MyList();
			var list2 = new MyList();

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
		public void List_AddToBeginning_HeadNode_IsNotEqual()
		{
			//Arrange
			var list = new MyList();
			var list2 = new MyList();

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
	}
}
