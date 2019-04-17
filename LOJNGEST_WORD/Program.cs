
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJNGEST_WORD
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest world is :");
            Console.WriteLine(a.MyFunctionA("ada lovelace wrote the first algorith desingned for processing bt an Analytical Engine."));
        }

        public MyFunctionA(string input)
        {
            // Write a C# prograam to find the longest word in a string.
            string[] words = input.Split('');

            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;
        }
    }
}
