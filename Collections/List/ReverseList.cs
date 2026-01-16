/* Reverse a List
Write a program to reverse the elements of a given list without using built-in reverse methods. Implement it for ArrayList
Example:
Input: [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1] */


using System;
using System.Collections;
namespace List
{
class ReverseList
{
    public static void Reverse(ArrayList list)
    {
        int i=0;
        int j= list.Count -1;
        while (i < j)
        {
            object temp = list[i];
            list[i] = list[j];
            list[j] = temp;
            i++;
            j--;
        }
    }
}
}