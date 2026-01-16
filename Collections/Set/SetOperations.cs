/* Union and Intersection of Two Sets Compute the union and intersection of two sets.
Example:
Set1: {1, 2, 3}, Set2: {3, 4, 5}
Output:
Union: {1, 2, 3, 4, 5}
Intersection: {3} */

using System;
using System.Collections;
namespace Set
{
public class SetOperations
{
    public static HashSet<int> union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>(set1);
        foreach(var i in set2)
            result.Add(i);
        return result;
    }
    public static HashSet<int> intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>(set1);
        foreach(var i in set1)
        {
            if (set2.Contains(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
}
}