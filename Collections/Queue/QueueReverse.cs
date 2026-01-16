/* Reverse a Queue
Reverse the elements of a queue using only queue operations.
Example:
Input: [10, 20, 30]
Output: [30, 20, 10] */


using System;
using System.Collections;
namespace Queue
{
public class QueueReverse
{
    public static void Reverse(Queue<int> q)
    {
        if(q.Count == 0) return;
        int x = q.Dequeue();
        Reverse(q);
        q.Enqueue(x);
    }
}
}