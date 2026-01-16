/* Find Frequency of Elements
Given a list of strings, count the frequency of each element and return the results in a Dictionary<string, int>.
Example:
Input: {"apple", "banana", "apple", "orange"}
Output: { "apple": 2, "banana": 1, "orange": 1 } */


using System;
using System.Collections.Generic;
namespace List
{
class FrequencyCounter
{
    public static Dictionary<string, int> CountFrequency(string[] arr)
    {
        Dictionary<string,int> freq = new Dictionary<string, int>();
        foreach(var i in arr)
        {
            if(freq.ContainsKey(i))
                freq[i]++;
            else
                freq[i] = 1;
        }
        return freq;   
    }
}
}