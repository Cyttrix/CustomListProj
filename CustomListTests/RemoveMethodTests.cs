using System;
using CustomList;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveOneItem_IndexZeroNull() 
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("A");
            
            
            //Act
            myList.Remove("A");
            //Assert
            Assert.AreEqual(null, myList[0]);
        }

        [TestMethod]

        public void RemoveMethod_RemoveOneItem_MethodReturnsTrue()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("A");
            //Act
            bool returnValue = myList.Remove("A");

            //Assert
            Assert.AreEqual(true, returnValue);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneItem_CountDoesNotDecrement()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("A");
            //Act
            myList.Remove("C");
            //Assert
            Assert.AreEqual(myList.Count, 0);
        }
        [TestMethod]
        
        public void RemoveMethod_RemoveItemInIndexZero_ItemFromIndexOneShiftsToIndexZero()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("A");
            myList.Add("B");
            //Act
            myList.Remove("A");
            //Assert
            Assert.AreEqual("B", myList[0]);

        }
        [TestMethod]

        public void RemoveMethod_RemoveOneItemThatDuplicatesTwice_OnlyFirstInstanceOfItemInListRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("A");
            myList.Add("A");
            //Act
            myList.Remove("A");
            //Assert
            Assert.AreEqual(myList[0], "A");
        }
    }
}
