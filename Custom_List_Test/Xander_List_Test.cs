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
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
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
    public void Indexer_IndexExists_ReturnFalse()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      int actual;

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
      testList.Add(7);
      actual = testList[testList.Count - 1];

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_AddToEndOfList_IndexOfElementEqualsCount()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      testList.Add(6);
      testList.Add(7);
      testList.Add(8);
      testList.Add(9);
      testList.Add(10);
      testList.Add(11);
      testList.Add(12);
      testList.Add(13);
      testList.Add(14);
      testList.Add(15);
      testList.Add(16);
      testList.Add(17);
      testList.Add(18);
      int expected = 100;
      int actual;

      // Act 
      testList.Add(100);
      actual = testList[testList.Count - 1];

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_RemoveElementFromEndOfList_CountIsDecremented()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(10);
      int expected = testList.Count - 1;
      int actual;

      // Act
      testList.Remove();
      actual = testList.Count;

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Remove_CannotRemoveElement_ReturnFalse()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      bool expected = false;
      bool actual;

      // Act
      actual = testList.Remove();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    public void Remove_RemoveElemendFromEndOfList_ReturnTrue()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      bool expected = true;
      bool actual;

      // Act
      actual = testList.Remove();

      // Assert
      Assert.AreEqual(expected, actual);
    }

  }
}
