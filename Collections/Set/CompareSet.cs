/* Check if Two Sets Are Equal
Compare two sets and determine if they contain the same elements, regardless of order.
Example:
Set1: {1, 2, 3}, Set2: {3, 2, 1}
Output: true */

using System;
using System.Collections;
namespace Set
{
public class CompareSet
{
    public static Boolean Check(HashSet<int> set1,HashSet<int> set2)
    {
        if(set1.Count != set2.Count)
        {
            return false;
        }
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