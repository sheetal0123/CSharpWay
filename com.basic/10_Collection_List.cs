using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class List
    {
        static void main(String[] args)
        {
            var wordList = new List<string> { "apple", "ball", "cat" };
            Console.WriteLine(">>" + wordList[1]);

            foreach (var word in wordList)
            {
                Console.WriteLine (word);
            }
        }
    }
}
