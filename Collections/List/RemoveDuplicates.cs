/* Remove Duplicates While Preserving Order
Remove duplicate elements from a list while maintaining the original order.
Example:
Input: [3, 1, 2, 2, 3, 4]
Output: [3, 1, 2, 4] */

using System;
using System.Collections;
using System.Collections.Generic;
namespace List
{   

public class RemoveDuplicates
{
    public static ArrayList Remove(ArrayList list)
    {
        HashSet<object> hs = new HashSet<object>();
        ArrayList result = new ArrayList();
        foreach(var i in list)
        {
            if (!hs.Contains(i))
            {
                hs.Add(i);
                result.Add(i);
            }
        }
        return result;
    }
}
}