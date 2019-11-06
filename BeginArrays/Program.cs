using System;
using static System.Console;

namespace BeginArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "AJ", "Alex", "Ben", "Jaco", "Tyler", "Zed" };
            int[] mp = {33, 44, 23, 12, 54, 24};

            WriteLine("First positon of each array is {0} and {1}", name[0], mp[0]);

            WriteLine("List everyones MP");
            for(int i = 0; i < 6; ++i)
            {
                WriteLine("{0} is {1} MP long", name[i], mp[i]);
            }

            int[] facts = new int[10];
            int[] hasd; //intializes the array but it has no values or length, so it can't be called upon
            hasd = new int[]{ 3, 4, 90}; // gives it values and length(3)
            int fct = 4;

            for(int i = 0; i < 10; ++i)
            {
                fct = fct * 2;

                facts[i] = fct;
            }

            for (int i = 0; i < facts.Length; ++i)
            {
                WriteLine(facts[i]);
            }

            WriteLine("First position {0} and Fith position {1} and last position {2}", facts[0], facts[4], facts[9]);

        }
    }
}
