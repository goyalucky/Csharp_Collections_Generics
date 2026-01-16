/* Generate Binary Numbers Using a Queue
Generate the first N binary numbers using a queue.
Example:
Input: N=5
Output: {"1", "10", "11", "100", "101"} */


using System;
using System.Collections;
namespace Queue
{

public class BinaryGenerator
{
    public static List<string> Generate(int n)
    {
        List<string> result = new List<string>();
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");
        for(int i = 0; i < n; i++)
        {
            string curr = q.Dequeue();
            result.Add(curr);

            q.Enqueue(curr + "0");
            q.Enqueue(curr + "1");
        }
        return result;
    }
}
}