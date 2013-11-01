using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Permutations
{
  [TestFixture]
  public class PermutationTests
  {
    [Test]
    public void smoke()
    {
      var p = new Permutation();
      var result = p.GetPermutations("ABC");
    }
  }

  public class Permutation
  {
    private List<string> _result = new List<string>();
    private int _level = 0;
    private string _value;

    public List<string> GetPermutations(string s)
    {
      _value = s;
      Permutation(0);
      return _result;
    }

    private void Permuation(int k)
    {
      _level ++;
      _value[k] = _level;

    }
  }
}
