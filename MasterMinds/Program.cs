using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMinds
{
    class Program
    {
        static void Main(string[] args)
        {

            //stuff that we don't need 
            //Console.WriteLine("Enter your numbers");
            //int[] uGen = new int[cGen.Length];
            //for (int i = 0; i < uGen.Length; i++)
            //{
            //    uGen[i] = int.Parse(Console.ReadLine());
            //}

            int[] cGen = new int[4];
            int[] uGen = new int[4];


            UniqueRandom uRand = new UniqueRandom();

            Console.WriteLine("Welcome to Masterminds");
            Console.WriteLine("I have generated 4 numbers. Guess them.");

            for (int i = 0; i < cGen.Length; i++)
            {
                cGen[i] = uRand.NextUnique(0, 10);
                Console.Write(cGen[i]);
            }
            Console.WriteLine();

            int count = 0;

            bool reverb = true;
            while (reverb)
            {
                string userNums;
                Console.WriteLine("like put some numbahs in thanks, like foe");
                userNums = Console.ReadLine();
                for (int i = 0; i < userNums.Length; i++)
                {
                    uGen[i] = int.Parse(userNums[i].ToString());
                }

                reverb = numberCheck(cGen, uGen);
                count++;
            }

            Console.WriteLine($"You win. {count} tries");
            Console.ReadKey();
        }

        static bool numberCheck(int[] cGen, int[] uGen)
        {
            bool equal = true;
            for (int i = 0; i < cGen.Length; i++)
            {
                bool incorrect = true;
                if (cGen[i] == uGen[i])
                {
                    Console.WriteLine(uGen[i] + " Correct");
                    continue;
                }
                for (int j = 0; j < cGen.Length; j++)
                {
                    if (cGen[i] == uGen[j] && i != j)
                    {
                        Console.WriteLine(uGen[i] + " Incorrect position");
                        incorrect = false;
                        equal = false;
                        break;
                    }
                }
                if (incorrect)
                {
                    Console.WriteLine(uGen[i] + " Incorrect");
                    equal = false;
                }

            }

            if (equal)
            {
                return false;
            }
            else
            {
                return true;

            }
        }



    }
}
