using CustomList;
using Microsoft.VisualBasic;

namespace CustomListTests2
{
    [TestClass]
    public class ToStringMethodOverrideTest
    {
        [TestMethod]
        public void ToStringMethod_CreateListOfStrings_ReturnsCombinedStringOfList()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.ToString();
            //Assert
            Assert.AreEqual("ABC", myList.ToString());

        }

        [TestMethod]
        public void ToStringMethod_CreateListOfInts_ReturnsCombinedIntOfList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.ToString();
            //Assert
            Assert.AreEqual("1234", myList.ToString());
        }
        [TestMethod]

        public void ToStringMethod_CreateEmptyList_ReturnsEmptyString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.ToString();
            //Assert
            Assert.AreEqual("", myList.ToString());
        }
    }
}