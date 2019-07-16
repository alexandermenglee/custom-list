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
      XanderList<int> test = new XanderList<int>();
      test.Add(1);
      test.Add(2);
      test.Add(3);
      test.Add(3);
      test.Add(4);

      test.Remove(3);

      Console.WriteLine($"Test array: {test}");
      Console.WriteLine($"\nCount: {test.Count}");

      /*****************************************************************/
      Console.ReadLine();
    }
  }
}