using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermOut
{
  public class Permutations
  {
    public Permutations(string ofS)
    {
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      var array = new int[] {8,6,7,5,3,0,9};

      Console.WriteLine(string.Join("", array.Select(i => i.ToString())));
      int j = 0;
      while (array != null)
      {
        array = NextPermutation(array);
        if (array != null)
        {
          Console.WriteLine(string.Join("", array.Select(i => i.ToString())));
          j++;
        }
      }
      Console.WriteLine("There were {0} permutations.", j);

      Console.ReadLine();
    }

    private static int[] NextPermutation(int[] array)
    {
      // Find longest non-increasing suffix
      int i = array.Length - 1;
      while (i > 0 && array[i - 1] >= array[i])
        i--;
      // Now i is the head index of the suffix

      // Are we at the last permutation already?
      if (i == 0)
        return null;

      // Let array[i - 1] be the pivot
      // Find rightmost element that exceeds the pivot
      int j = array.Length - 1;
      while (array[j] <= array[i - 1])
        j--;
      // Now the value array[j] will become the new pivot
      // Assertion: j >= i

      // Swap the pivot with j
      int temp = array[i - 1];
      array[i - 1] = array[j];
      array[j] = temp;

      // Reverse the suffix
      j = array.Length - 1;
      while (i < j)
      {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
      }

      // Successfully computed the next permutation
      return array;
    }
  }
}
