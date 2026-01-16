/* Find Subsets
Check if one set is a subset of another.
Example:
Input: {2, 3}, {1, 2, 3, 4}
Output: true */


using System;
using System.Collections;
namespace Set
{
public class FindSubsets
{
    public static Boolean Subset(HashSet<int> set1, HashSet<int> set2)
    {
        foreach(var i in set1)
        {
            if (!set2.Contains(i))
            {
                return false;
            }
        }
        return true;
    }
}
}