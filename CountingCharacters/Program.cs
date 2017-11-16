using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingStudioCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            String testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charactersInString = testString.ToCharArray();

            foreach (char character in charactersInString)
            {
                if (characterCounts.ContainsKey(character))
                {
                    characterCounts[character] = characterCounts[character] + 1;
                }
                else
                {
                    characterCounts.Add(character, 1);
                }
            }
            foreach (KeyValuePair<char, int> oneChar in characterCounts)
            {
                Console.WriteLine(oneChar.Key + ": " + oneChar.Value);
            }
            Console.ReadLine();

        }
    }
}