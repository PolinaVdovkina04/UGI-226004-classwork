using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "a", "abc", "ab", "a", "aba", "ab", "a", "b" };

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict[word] = 1;
            }
            PrintDictionary(dict);

            Console.ReadKey();
        }
        static void PrintDictionary (Dictionary<string, int> dict)
        {
            foreach (var elem in dict)
                Console.WriteLine($"{elem.Key}\t{elem.Value}");
        }
        static void PrintSortedDictionary(SortedDictionary<string, int> dict)
        {
            foreach (var key in dict.Keys)
                Console.WriteLine($"{key}\t{dict[key]}");
        }
    }
}
