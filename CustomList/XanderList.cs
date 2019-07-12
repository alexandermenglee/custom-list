using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
  public class XanderList<T>
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
      get => list[i];
      set => list[i] = value;
    }

    // Constructor
    public XanderList()
    {
      IntitializeNewArray();
    }

    // Member methods
    private void IntitializeNewArray()
    {
      capacity = 4;
      list = new T[capacity];
      count = 0;
    }
    

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

    public bool Remove(T value)
    {
      // loop through array (list)
      // check if element at i equals value
      // if true 
      // set the value of i to the value of i+1

      /*for(int i = 0; i < count; i++)
      {
        if(list[i].Equals(value))
        {
          if(count == 1)
          {
            IntitializeNewArray();
            return true;
          }
          else
          {
            for (int j = i; j < count - 1; j++)
            {
              list[j] = list[j + 1];
            }
            count--;
            return true;
          }
        }
      }
      return false;*/

      T[] results = new T[capacity];
      bool valueExists;
      int resultsIndexer;

      valueExists = true;
      resultsIndexer = 0;

      for (int i = 0; i < count; i++)
      {
        if (!list[i].Equals(value))
        {
          results[resultsIndexer] = list[i];
          resultsIndexer++;
        }
      }

      if(resultsIndexer == count)
      {
        valueExists = false;
        return valueExists;
      }

      count--;
      list = results;
      return valueExists;
    }

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
    public static XanderList<T> operator -(XanderList<T> modifiedList, XanderList<T> checkList)
    {
      for(int i = 0; i < checkList.Count; i++)
      {
        for(int j = 0; j < modifiedList.Count; j++)
        {
          if (checkList[i].Equals(modifiedList[j]))
          {
            modifiedList.Remove(modifiedList[j]);
          }
        }
      }
      return modifiedList;
    }
  }
}
