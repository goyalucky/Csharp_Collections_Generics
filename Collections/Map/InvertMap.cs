/* Invert a Map
Invert a Dictionary<K, V> to produce a Dictionary<V, List<K>>.
Example:
Input: { A=1, B=2, C=1 }
Output: { 1=[A, C], 2=[B] } */

using System;
using System.Collections;
namespace Map
{
class InvertMap
{
    public static Dictionary<int,List<string>> Invert(Dictionary<string,int> map)
    {
        Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();
        foreach(var i in map)
        {
           if(!result.ContainsKey(i.Value))
           {
                result[i.Value] = new List<string>();
           }
            result[i.Value].Add(i.Key);
        }
        return result;
    }
}
}