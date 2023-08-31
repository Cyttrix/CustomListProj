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
            Assert.AreEqual(myList[0], "");
        }
    }
}
