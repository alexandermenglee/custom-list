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
      /* As a developer, I want to create a C# indexer so that I can make the objects in my list accessible via index. I want to properly ensure that a user cannot access an out-of-bounds index. */

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
    // Return false bc index does not exist
    public void Indexer_IndexExists_ReturnFalse()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      bool expected = false;
      bool actual;
      // Act
      actual = testList[9];

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    // 
  }
}
