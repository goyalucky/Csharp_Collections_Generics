/* Symmetric Difference
Find the symmetric difference (elements present in either set but not both).
Example:
Input: {1, 2, 3}, {3, 4, 5}
Output: {1, 2, 4, 5} */

using System;
using System.Collections;
namespace Set
{
public class SymmetricDifference
{
    public static HashSet<int> Find(HashSet<int> set1,HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();
        foreach(var i in set1)
        {
            if(!set2.Contains(i))
            {
                result.Add(i);
            }
        }
        foreach(var i in set2)
        {
            if(!set1.Contains(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
}
}