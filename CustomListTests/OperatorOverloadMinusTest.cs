using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class OperatorOverloadMinusTest
    {
        [TestMethod]
        public void MinusOperator_EqualSizeLists_ListTwoRemovedFromListOne()
        {
            //arrange
            CustomList<int> customListFirst = new CustomList<int>();
            CustomList<int> customListSecond = new CustomList<int>();
            CustomList<int> actual;
            string expected = "13";

            customListFirst.Add(1);
            customListFirst.Add(2);
            customListFirst.Add(3);

            customListSecond.Add(2);
            customListSecond.Add(5);
            customListSecond.Add(6);

            //act
            actual = customListFirst - customListSecond;
            Console.WriteLine(actual.ToString);

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
