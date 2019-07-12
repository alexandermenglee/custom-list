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
      IntitializeNewArray();
    }

    // Member methods
    private void IntitializeNewArray()
    {
      capacity = 4;
      list = new T[capacity];
      count = 0;
    }
    
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
      bool valueExists;

      resultsIndexer = 0;
      valueExists = true;

      for (int i = 0; i < count; i++)
      {
        if(!list[i].Equals(value))
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
