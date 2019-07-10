using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace Custom_List_Test
{
  [TestClass]
  public class Xander_List_Test
  {
    [TestMethod]
    // return element at index asked for
    public void Indexer_GetIndexOfArray_GetElementAtIndex()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(0);
      testList.Add(2);
      testList.Add(4);
      int expected = 2;
      int actual;

      // Act
      actual = testList[1];

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    // Return false bc index does not exist
    public void Indexer_IndexExists_ReturnFalse()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      bool actual;

      // Act
      actual = testList[9];

      // Assert
        // ExpectedException attribute is expecting an IndexOutOfRangeException to be thrown
    }

    [TestMethod]
    public void Add_AddToList_ListContainsElement()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      int expected = 7;
      int actual;

      // Act

      actual = testList[0];
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_AddToEndOfList_IndexOfElementEqualsCount()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      int expected = 99;
      int actual;

      // Act 
      testList.Add(99);
      actual = testList[testList.Count - 1];

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
