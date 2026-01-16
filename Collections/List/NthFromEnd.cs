/* Find the Nth Element from the End
Given a singly linked list (LinkedList), find the Nth element from the end without calculating its size.
Example:
Input: [A, B, C, D, E], N=2
Output: D */

using System;
using System.Collections.Generic;
namespace List
{
public class NthFromEnd
{
    public static string Find(LinkedList<string> list,int n)
    {
        var fast = list.First;
        var slow = list.First;
        for(int i = 0; i < n; i++)
        {
            if(fast == null)
                return null;
            fast = fast.Next;
        }

        while(fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }
        return slow.Value;
    }
}
}