using Microsoft.VisualStudio.TestTools.UnitTesting;

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

			//Act
			Assert.IsNull(list.headNode);
		}
	}
}
