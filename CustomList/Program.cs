using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
  class Program
  {
    static void Main(string[] args)
    {
      XanderList<int> expected = new XanderList<int>();
      XanderList<int> actual = new XanderList<int>();
      XanderList<int> testList1 = new XanderList<int>();
      XanderList<int> testList2 = new XanderList<int>();

      // adding to expected list
      expected.Add(1);

      // adding to testList1
      testList1.Add(1);
      testList1.Add(2);
      testList1.Add(2);
      testList1.Add(3);

      // adding to testList2
      testList2.Add(2);
      testList2.Add(3);

      // Act
      testList1 = testList1 - testList2;

      foreach(int element in testList1)
      {
        Console.WriteLine(element);
      }

      /* Used to keep console  open */
      Console.ReadLine();
    }
  }
}