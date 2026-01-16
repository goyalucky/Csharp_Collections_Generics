using System;
using System.Collections;
namespace List
{
public class ListMain
{
    public static void  Run()
    {
        // Find the Nth Element from the End

        LinkedList<string> ll = new LinkedList<string>();
        ll.AddLast("A");
        ll.AddLast("B");
        ll.AddLast("C");
        ll.AddLast("D");
        ll.AddLast("E");
        string res = NthFromEnd.Find(ll,2);
        Console.WriteLine(res);


        // Remove Duplicates While Preserving Order

        /* ArrayList list = new ArrayList(){3,1,2,2,3,4};
        ArrayList result = RemoveDuplicates.Remove(list);
        Console.Write('[');
        foreach(var i in result)
            Console.Write(i+ " ");
        Console.WriteLine(']'); */

        // Rotate Elements in a List

        /* ArrayList list = new ArrayList(){10,20,30,40,50};
        RotateList.Rotate(list,2);
        Console.Write('[');
        foreach (var i in list)
            Console.Write(i+ " ");
        Console.WriteLine(']'); */

        // Find Frequency of Elements
        
       /*  string[] a = { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> result = FrequencyCounter.CountFrequency(a);
            Console.Write("{ ");
            int count = 0;
            foreach (var item in result)
            {
                Console.Write($"\"{item.Key}\": {item.Value}");
                if (count < result.Count - 1)
                    Console.Write(" ,");
                count++;
            }
            Console.WriteLine(" }"); */

        // Reverse a list

      /*  ArrayList list = new ArrayList(){1,2,3,4,5};
        ReverseList.Reverse(list);
        foreach(var i in list)
            Console.Write(i +" "); */
    }
}
}
