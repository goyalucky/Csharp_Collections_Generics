/* Convert a Set to a Sorted List
Convert a HashSet<int> into a sorted list in ascending order.
Example:
Input: {5, 3, 9, 1}
Output: [1, 3, 5, 9] */

using System;
using System.Collections;
namespace Set
{
public class SetToSortedList
{
    public static List<int> Convert(HashSet<int> set)
    {
        List<int> ls = new List<int>(set);
        for(int i=0; i < ls.Count-1; i++)
        {
            for(int j=i+1; j<ls.Count; j++)
            {
                if (ls[i] > ls[j])
                {
                    int temp = ls[i];
                    ls[i] = ls[j];
                    ls[j] = temp;
                }
            }
        }
        return ls;
    }
}
}