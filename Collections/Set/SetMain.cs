using System;
using System.Collections;
namespace Set
{
public class SetMain
{
   public static void Run()
    {
        // Find Subsets

        HashSet<int> set1 = new HashSet<int>{2,3};
        HashSet<int> set2 = new HashSet<int>{1,2,3,4};
        bool result = FindSubsets.Subset(set1,set2);
        Console.WriteLine(result); 

        // Convert a Set to a Sorted List

       /*  HashSet<int> set = new HashSet<int>(){5,3,9,1};
        List<int> res = SetToSortedList.Convert(set);
        Console.Write('[');
        foreach(var i in res)
            Console.Write(i + " ");
        Console.WriteLine(']'); */


        // Symmetric Difference

       /*  HashSet<int> set1 = new HashSet<int>{1,2,3};
        HashSet<int> set2 = new HashSet<int>{3,4,5};
        HashSet<int> res = SymmetricDifference.Find(set1,set2);
        Console.Write('{');
        foreach(var i in res)
            Console.Write(i + " ");
        Console.WriteLine('}'); */


            //    Symmetric Difference

       /*  HashSet<int> set1 = new HashSet<int>{1,2,3};
        HashSet<int> set2 = new HashSet<int>{3,4,5};
        HashSet<int> union = SetOperations.union(set1,set2);
        HashSet<int> intersection = SetOperations.intersection(set1,set2);
        Console.Write("Union: {");
        foreach(var i in union)
            Console.Write(i + " ");
        Console.WriteLine("}");

        Console.Write("Intersection: {");
        foreach(var i in intersection)
            Console.Write(i + " ");
        Console.WriteLine("}");  */


        // Check if Two Sets Are Equal

       /*  HashSet<int> set1 = new HashSet<int>{1,2,3};
        HashSet<int> set2 = new HashSet<int>{3,2,1};
        bool result = CompareSet.Check(set1,set2);
        Console.WriteLine(result); */
    }
}
}