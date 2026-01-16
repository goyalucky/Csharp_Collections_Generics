/* Word Frequency Counter
Read a text file and count the frequency of each word using a
Dictionary<string, int>.
Example:
Input: "Hello world, hello Java!"
Output: { "hello": 2, "world": 1, "java": 1 } */

using System;
using System.Collections.Generic;
namespace Map
{
class WordCounter
{
    public static Dictionary<string, int> CountWords(string text)
    {
        text = text.ToLower();
        Dictionary<string, int> map = new Dictionary<string, int>();
        string word = "";
        for(int i = 0; i < text.Length; i++)
        {
            if(char.IsLetter(text[i]))
            {
                word += text[i];
            }
            else if (word.Length > 0)
            {
                if (map.ContainsKey(word))
                    map[word]++;
                else
                    map[word] = 1;
                word = "";
            }
        }
        if (word.Length > 0)
        {
            if (map.ContainsKey(word))
                map[word]++;
            else
                map[word] = 1;
        }
        return map;
    }
}
}
