using System;
using System.Collections;
namespace Queue
{
public class QueueMain
{
    public static void Run()
    {
        
        // Hospital Triage System

        PriorityQueue<string,int> pq = HospitalTriage.CreateQueue();
        pq.Enqueue("John",-3);
        pq.Enqueue("Alice",-5);
        pq.Enqueue("Bob",-2);
        while(pq.Count > 0)
        {
            Console.Write(pq.Dequeue() + " ");
        }

        // Generate Binary Numbers Using a Queue

        /* int N = 5;
        List<string> binaries = BinaryGenerator.Generate(N);
        Console.Write("{");
        for(int i = 0; i < binaries.Count; i++)
        {
           Console.Write($"\"{binaries[i]}\"");
           if(i < binaries.Count - 1)
                Console.Write(", "); 
        }
        Console.WriteLine("}"); */


        // Reverse a Queue

        /* Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        QueueReverse.Reverse(q);
        Console.Write("[");
        foreach(var x in q)
            Console.Write(x+ " ");
        Console.WriteLine("]"); */
    }   
}
}