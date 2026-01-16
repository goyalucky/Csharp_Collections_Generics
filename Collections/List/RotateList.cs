/* Rotate Elements in a List
Rotate the elements of a list by a given number of positions.
Example:
Input: [10, 20, 30, 40, 50], rotate by 2
Output: [30, 40, 50, 10, 20] */

using System;
using System.Collections;
namespace List
{
public class RotateList
{
    public static void Rotate(ArrayList list,int k)
    {
        int n = list.Count-1;
        k = k % n;
        for(int r=0; r<k; r++)
        {
            object first = list[0];
            for(int i=0;i < n-1;i++)
                list[i] = list[i+1];
            list[n-1] = first;
        }
    }
}
}