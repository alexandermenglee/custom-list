using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace Custom_List_Test
{
  [TestClass]
  public class Xander_List_Test
  {
    // ***********************************************************************
    // INDEXER UNIT TESTS

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
    public void Indexer_IndexExists_ThrowIndexOutOfRangeException()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);
      testList.Add(5);
      int actual;

      // Act
      actual = testList[6];

      // Assert
      // ExpectedException attribute is expecting an IndexOutOfRangeException to be thrown
    }

    // ***********************************************************************
    // ADD UNIT TESTS

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

    // ***********************************************************************
    // REMOVE UNIT TESTS

    [TestMethod]
    public void Remove_RemoveElementWithValue_CountIsDecremented()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(666);
      testList.Add(920);
      testList.Add(777);
      int expected = 2;
      int actual;

      // Act
      testList.Remove(666);
      actual = testList.Count; ;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_ElementNotInList_CountInNotDecremented()
    {
      // Arrange
      int expected;
      int actual;

      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);

      // Act
      testList.Remove(7);
      expected = 3;
      actual = testList.Count;
      // Assert
    }

    [TestMethod]
    public void Remove_ElementDoesNotExist_ReturnFalse()
    {
      // Arrange
      XanderList<int> testList = new XanderList<int>();
      testList.Add(88);
      testList.Add(3);
      testList.Add(99);
      bool expected = false;
      bool actual;

      // Act
      actual = testList.Remove(13);

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Remove_RemoveElementFromList_ReturnTrue()
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
      actual = testList.Remove(3);

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_RemoveFromMiddle_ListRemainsFlush()
    {
      // Assign
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
      int expected = 8;
      int actual;

      // Act
      testList.Remove(7);
      actual = testList[6];

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_RemoveLastIndex_LastIndexIsRemoved()
    {
      // Assign
      int expected;
      int actual;

      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);

      // Act
      expected = 1;
      testList.Remove(2);
      actual = testList[0];

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_RemoveOnlyValue_CountIsZero()
    {
      // Assign
      int expected;
      int actual;

      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);

      // Act
      expected = 0;
      testList.Remove(1);
      actual = testList.Count;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    // ***********************************************************************
    // TOSTRING UNIT TESTS

    [TestMethod]
    public void ToString_Int_ReturnAllIntsWithSpaceBetween()
    {
      // Assign
      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);
      testList.Add(4);

      string expected = "1 2 3 4";
      string actual;

      // Act
      actual = testList.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToString_Double_ReturnAllDoublesWithSpaceBetween()
    {
      // Assign
      string expected;
      string actual;

      XanderList<double> testList = new XanderList<double>();
      testList.Add(3.1);
      testList.Add(3.2);
      testList.Add(3.3);
      testList.Add(90.9876770000);
      testList.Add(56.7891770000);

      // Act
      expected = "3.1 3.2 3.3 90.987677 56.789177";
      actual = testList.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToString_String_ReturnAllStringsWithSpaceBetween()
    {
      // Arrange
      string expected;
      string actual;

      XanderList<string> testList = new XanderList<string>();
      testList.Add("testing");
      testList.Add("the");
      testList.Add("tostring");
      testList.Add("method,");
      testList.Add("did");
      testList.Add("it");
      testList.Add("work?");

      // Act
      expected = "testing the tostring method, did it work?";
      actual = testList.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToString_Object_ReturnObjectToString()
    {
      // Assign
      string expected;
      string actual;

      XanderList<ObjTestClass> testList = new XanderList<ObjTestClass>();
      testList.Add(new ObjTestClass("John"));
      testList.Add(new ObjTestClass("Wick"));
      testList.Add(new ObjTestClass());
      testList.Add(new ObjTestClass());

      // Act
      expected = "CustomList.ObjTestClass CustomList.ObjTestClass CustomList.ObjTestClass CustomList.ObjTestClass";
      actual = testList.ToString();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToString_Boolean_ReturnBooleanValuesWithSpacesBetween()
    {
      // Assign 
      string expected;
      string actual;

      XanderList<bool> testList = new XanderList<bool>();
      testList.Add(true);
      testList.Add(true);
      testList.Add(true);
      testList.Add(false);
      testList.Add(false);
      testList.Add(false);

      // Act 
      expected = "True True True False False False";
      actual = testList.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    // ***********************************************************************
    // ADDITION OPERATOR UNIT TESTS

    [TestMethod]
    public void AdditionOperator_JoinTwoLists_ReturnOneList()
    {
      // Arrange
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();
      testList1.Add(1);
      testList1.Add(2);
      testList2.Add(3);
      testList2.Add(4);
      expected.Add(1);
      expected.Add(2);
      expected.Add(3);
      expected.Add(4);

      // Act
      actual = testList1 + testList2;

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void AdditionOperator_AddCountOfBothLists_CountEqualsBothListCounts()
    {
      // Arrange
      int expected;
      int actual;
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();
      XanderList<int> returnedList = new XanderList<int>();
      testList1.Add(1);
      testList1.Add(2);
      testList2.Add(3);
      testList2.Add(4);

      // Act
      expected = 4;
      returnedList = testList1 + testList2;
      actual = returnedList.Count;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AdditionOperator_DifferentSizedLists_ReturnListContainingAllValues()
    {
      // Arrange
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to testList1
      testList1.Add(1);
      testList1.Add(2);
      testList1.Add(3);

      // add to testList2
      testList2.Add(4);
      testList2.Add(5);

      // add to expected XanderList
      expected.Add(1);
      expected.Add(2);
      expected.Add(3);
      expected.Add(4);
      expected.Add(5);

      // Act
      actual = testList1 + testList2;

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    // ***********************************************************************
    // SUBTRACTION OPERATOR UNIT TESTS

    [TestMethod]
    public void SubtractionOperator_RemoveFromList_ReturnListWithCorrectValues()
    {
      // Assign
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to list1
      testList1.Add(20);
      testList1.Add(33);
      testList1.Add(57);
      testList1.Add(10);

      // add to list2
      testList2.Add(100);
      testList2.Add(57);
      testList2.Add(1009);
      testList2.Add(20);

      // add to expected XanderList
      expected.Add(33);
      expected.Add(10);

      // Act
      actual = testList1 - testList2;

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void SubtractionOperator_DifferentSizedLists_ReturnListWithCorrectValues()
    {
      // Assign
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to list1
      testList1.Add(21);
      testList1.Add(22);
      testList1.Add(23);
      testList1.Add(24);

      // add to list2
      testList2.Add(100);
      testList2.Add(57);
      testList2.Add(1009);
      testList2.Add(21);
      testList2.Add(20);

      // add to expected XanderList
      expected.Add(22);
      expected.Add(23);
      expected.Add(24);

      // Act
      actual = testList1 - testList2;

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void SubtractionOperator_BothListsHaveSameValues_ReturnEmptyList()
    {
      // Assign
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to list1
      testList1.Add(1);
      testList1.Add(2);
      testList1.Add(3);
      testList1.Add(4);

      // add to list2
      testList2.Add(1);
      testList2.Add(2);
      testList2.Add(3);
      testList2.Add(4);

      // Act
      actual = testList1 - testList2;

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    // ***********************************************************************
    // ZIP METHOD UNIT TESTS

    [TestMethod]
    public void Zip_BothListsCountAreEqual_ListCountIsDoubled()
    {
      // Assign
      int expected;
      int actual;

      XanderList<int> oddTestList = new XanderList<int>();
      XanderList<int> evenTestList = new XanderList<int>();

      // add to oddTestList
      oddTestList.Add(1);
      oddTestList.Add(3);
      oddTestList.Add(5);

      // add to evenTestList
      evenTestList.Add(2);
      evenTestList.Add(4);
      evenTestList.Add(6);

      // Act
      oddTestList = oddTestList.Zip(evenTestList);
      expected = 6;
      actual = oddTestList.Count;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Zip_BothListsAreSameSize_ElementsAreInCorrectPosition()
    {
      // Assign
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> oddTestList = new XanderList<int>();
      XanderList<int> evenTestList = new XanderList<int>();

      // add to oddTestList
      oddTestList.Add(1);
      oddTestList.Add(3);
      oddTestList.Add(5);

      // add to evenTestList
      evenTestList.Add(2);
      evenTestList.Add(4);
      evenTestList.Add(6);

      // add to expected list
      expected.Add(1);
      expected.Add(2);
      expected.Add(3);
      expected.Add(4);
      expected.Add(5);
      expected.Add(6);

      // Act
      actual = oddTestList.Zip(evenTestList);

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void Zip_ParameterListIsLonger_ElementsAreAtCorrectPosition()
    {
      // Assign
      XanderList<int> expected  = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to testList1
      testList1.Add(1);
      testList1.Add(2);
      testList1.Add(3);

      // add to testList2
      testList2.Add(1);
      testList2.Add(2);
      testList2.Add(3);
      testList2.Add(4);
      testList2.Add(5);

      // addd to expected list
      expected.Add(1);
      expected.Add(1);
      expected.Add(2);
      expected.Add(2);
      expected.Add(3);
      expected.Add(3);
      expected.Add(4);
      expected.Add(5);

      // Act
      actual = testList1.Zip(testList2);

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void Zip_ParameterListShorter_ElementsAreAtCorrectPosition()
    {
      // Assign
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to testList1
      testList1.Add(1);
      testList1.Add(2);
      testList1.Add(3);
      testList1.Add(4);
      testList1.Add(5);

      // add to testList2
      testList2.Add(1);
      testList2.Add(2);
      testList2.Add(3);

      // addd to expected list
      expected.Add(1);
      expected.Add(1);
      expected.Add(2);
      expected.Add(2);
      expected.Add(3);
      expected.Add(3);
      expected.Add(4);
      expected.Add(5);

      // Act
      actual = testList1.Zip(testList2);

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void Zip_OneListIsEmpty_ReturnSameList()
    {
      // Arrange
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // add to testList1
      testList1.Add(1);
      testList1.Add(2);
      testList1.Add(3);


      // add to expected list
      expected.Add(1);
      expected.Add(2);
      expected.Add(3);

      // Act
      actual = testList1.Zip(testList2);

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void Zip_BothListsAreEmpty_CountIsZero()
    {
      // Arrange
      int expected;
      int actual;
      
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // Act
      testList1 = testList1.Zip(testList2);
      expected = 0;
      actual = testList1.Count;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Zip_IntBothListsAreEmpty_ReturnAnEmptyList()
    {
      // Arrange
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();

      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // Act
      testList1 = testList1.Zip(testList2);

      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    // ***********************************************************************
    // IENUMERATOR METHOD UNIT TESTS

    [TestMethod]
    public void IEnumerator_LoopThroughList_CreatesStringOfAllNumbersInList()
    {
      // Arrange
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();

      XanderList<int> testList = new XanderList<int>();
      testList.Add(1);
      testList.Add(2);
      testList.Add(3);

      // add to expected list
      expected.Add(1);
      expected.Add(2);
      expected.Add(3);

      // Act
      foreach (int number in testList)
      {
        actual.Add(number);
      }
      
      // Assert
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

  }
}
