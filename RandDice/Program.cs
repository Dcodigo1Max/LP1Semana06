using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int roll =0;
                       
            int start = int.Parse(args[0]);
            int seed = int.Parse(args[1]);

            Random dice = new Random(seed);

            for (int i = 0; i <= start; i++)
            {
                roll += dice.Next(1, 7); 
            }
            Console.WriteLine(roll);
             
           

        }
    }
}
