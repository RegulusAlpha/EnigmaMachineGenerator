using System;
using System.Collections.Generic;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int day = 0;
            for (day = 0; day <= 365; day++)
            {


                Console.WriteLine("settings for day " + day);

                var random = new Random();
                //rotor positions and ring position
                var letters = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                //rotor types
                var types = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
                //int indexL = random.Next(letters.Count);
                //int indexT = random.Next(types.Count);
                //Console.WriteLine(letters[indexL]);

                var pos = new List<string> { "b", "c" };
                int i = 1;
                //find initial rotor positions to lock
                for (i = 1; i <= 3; i++)
                {
                    int indexL = random.Next(letters.Count);
                    Console.WriteLine("Rotor " + i + " " + letters[indexL]);
                }
                int j = 1;
                //define rotor types to use
                for (j = 1; j <= 3; j++)
                {
                    int indexT = random.Next(types.Count);
                    Console.WriteLine("Rotor " + j + " type " + types[indexT]);
                }
                int k = 1;
                //define rotor ring positions
                for (k = 1; k <= 3; k++)
                {
                    int indexL = random.Next(letters.Count);
                    Console.WriteLine("Rotor " + k + " Ring Position " + letters[indexL]);
                }

                int indexR = random.Next(pos.Count);
                Console.WriteLine("reflector " + pos[indexR]);



                //pair letters for plugboard
                Random rng = new Random();
                int n = letters.Count;
                while (n > 1)
                {
                    n--;
                    int vk = rng.Next(n + 1);
                    string value = letters[vk];
                    letters[vk] = letters[n];
                    letters[n] = value;
                }
                int vv = 0;
                // Pair the shuffled letters consecutively
                for (vv = 0; vv < letters.Count; vv += 2)
                {
                    string firstLetter = letters[vv];
                    string secondLetter = letters[vv + 1];

                    Console.WriteLine($"{firstLetter} - {secondLetter}");
                }

                Console.WriteLine("");
            }



        }
    }
}
