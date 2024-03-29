﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
  public class XanderList<T> : IEnumerable
  {
    // Member variables
    private int count;
    private int capacity;
    // access level type [ ] < Name_Array > = new < datatype > [size];
    public T[] list;

    // Properties
    public int Count
    {
      get => count;
    }
    public int Capacity
    {
      get => capacity;
    }
    // indexer, allows user to use bracket notation
    public T this[int i]
    {
      get
      {
        if (i >= count)
        {
          throw new System.IndexOutOfRangeException();
        }
        return list[i];
      }
        
      set => list[i] = value;
    }

    // Constructor
    public XanderList()
    {
      capacity = 4;
      list = new T[capacity];
      count = 0;
    }

    // Member methods
    
    // Add method
    public void Add(T input)
    {
      // if count does not equal capacity add it into the list
      // else create a temporary array with capacity = capacity * 2
        // copy everything from list to the temporary array
        // reassign list to the temporary array
        // add input into list[count]
      // increment count

      if(count != capacity)
      {
        list[count] = input;
      }
      else
      {
        capacity *= 2;
        T[] temporaryList = new T[capacity];

        // copies everything from list to temporaryList
        for(int i = 0; i < list.Length; i++)
        {
          temporaryList[i] = list[i];
        }

        list = temporaryList;
        list[count] = input;
      }
      count++;
    }

    // Remove method
    public bool Remove(T value)
    {
      T[] results = new T[capacity];
      int resultsIndexer;
      int indexOfFoundValue;
      indexOfFoundValue = -1;

      resultsIndexer = 0;

      // find index of value
      for (int i = 0; i < count; i++)
      {
        if(list[i].Equals(value))
        {
          indexOfFoundValue = i;
        }
      }

      // Check if no value was found
      if (indexOfFoundValue == -1)
      {
        return false;
      }

      // add a all elements into new array except at the index found
      for (int i = 0; i < count; i++)
      {
        if(i == indexOfFoundValue)
        {
          continue;
        }

        results[resultsIndexer] = list[i];
        resultsIndexer++;
      }

      list = results;
      count--;
      return true;
    }
    
    // ToString method
    public override string ToString()
    {
      // instantiate empty string variable
      // loop through array(list)
      // concatenate each element to the empty string

      string arrayValuesToString = "";

      for(int i = 0; i < count; i++)
      {
        if(i == count - 1)
        {
          arrayValuesToString += list[i];
        }
        else
        {
          // need to cast type to string
          arrayValuesToString += list[i] + " ";
        }
      }

      return arrayValuesToString;
    }

    // + operator overload method
    public static XanderList<T> operator +(XanderList<T> list1, XanderList<T> list2)
    {
      XanderList<T> joinedList = new XanderList<T>();

      for(int i = 0; i < list1.Count; i++)
      {
        joinedList.Add(list1[i]);
      }

      for (int i = 0; i < list2.Count; i++)
      {
        joinedList.Add(list2[i]);
      }

      return joinedList;
    }

    // - operator overload method
    public static XanderList<T> operator -(XanderList<T> list1, XanderList<T> list2)
    {
      XanderList<T> results = new XanderList<T>();

      // creates a new list so list1 is not modified
      for (int i = 0; i < list1.Count; i++)
      {
        results.Add(list1[i]);
      }

      for (int i = 0; i < list2.Count; i++)
      {
        for (int j = 0; j < results.Count; j++)
        {
          if (list2[i].Equals(results[j]))
          {
            results.Remove(results[j]);
            j--;
          }
        }
      }

      return results;
    }

    // Zip method
    public XanderList<T> Zip(XanderList<T> zipperList)
    {
      // initialize longerList variable
      // check if list or zipperlist has a bigger count and assign it to longerList
      // for loop where i is less than longerList
      // if i < list.Count, add list[i] to results
      // if i < zipperList.Count add zipperList[i] to results

      int loopLength;
      XanderList<T> results = new XanderList<T>();

      loopLength = count;

      if(zipperList.Count > count)
      {
        loopLength = zipperList.Count;
      }

      for(int i = 0; i < loopLength; i++)
      {
        if(i < count)
        {
          results.Add(list[i]);
        }

        if(i < zipperList.Count)
        {
          results.Add(zipperList[i]);
        }
      }

      return results;
    }

    // Implementing IEnumerable
    public IEnumerator GetEnumerator()
    {
      for (int i = 0; i < count; i++)
      {
        yield return list[i];
      }
    }

    // Selection Sort algorithm
    public void SortList()
    {
      // 
    }
  }
}
