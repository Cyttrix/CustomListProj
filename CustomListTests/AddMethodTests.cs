using CustomList;

namespace CustomListTests
    
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddOneItem_FirstItemAtIndexZero()
        {
            //Arrange
            CustomList<string> myList= new CustomList<string>();
            //Act
            myList.Add("Hello");
            //Assert
            Assert.AreEqual("Hello", myList[0]);

        }
        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            //Act
            myList1.Add("Hello");
            myList1.Add("World");
            //Assert
            Assert.AreEqual("World", myList1[1]);
        }
        [TestMethod]
        public void AddMethod_AddThreeItems_CountIncreases()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            
            //Act
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");

            //Assert
            Assert.AreEqual(myList.Count, 3);
        }
        [TestMethod]
        public void AddMethod_AddFiveItems_CapacityIncreases()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.Add("E");
            //Assert
            Assert.AreEqual(myList.Capacity, 8);
        }
        [TestMethod]
        public void AddMethod_AddOneItemCapacityIncreases_OriginalItemRemains()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.Add("E");

            //Assert
           
            Assert.AreEqual(myList[0], "A");
        }
    }
}