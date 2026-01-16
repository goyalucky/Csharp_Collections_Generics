using System;
using System.Collections.Generic;
namespace Map
{
public class MapMain
{
    public static void Run()
    {
        // Invert a Map

        Dictionary<string,int> d = new Dictionary<string, int>()
        {
            {"A",1},
            {"B",2},
            {"C",1}
        };
        Dictionary<int,List<string>> result = InvertMap.Invert(d);
        foreach(var k in result)
        {
            Console.Write(k.Key + " = [");
            for(int i=0; i<k.Value.Count; i++)
            {
                Console.Write(k.Value[i]);
                if(i <k.Value.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        // Word Frequency Counter

      /*   string text = "Hello world, hello Java!";
        Dictionary<string, int> result = WordCounter.CountWords(text);
        foreach (var kv in result)
            Console.WriteLine($"{kv.Key} : {kv.Value}"); */
    }
}
}
