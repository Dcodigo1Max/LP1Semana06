using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new Random(6);

            for (int n=0; n<=6; n++)
                Console.WriteLine(dice.Next());
            
             
            /*
            Random r1 = new Random(22);
            Random r2 = new Random(22);
            
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next());
            */

        }
    }
}
