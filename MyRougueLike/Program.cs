using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int size = int.Parse(args[0]);

            Enemy[]array = new Enemy[size];

            for(int i = 0; i<size; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}:");
                string name = Console.ReadLine();
                array[i] = new Enemy(name);
            }

              foreach (Enemy name in array)
            {
                Console.WriteLine($"{name.GetName()} {name.GetHealth()} {name.GetShield()} ");
            }

            array[0].PickupPowerUp(PowerUp.Health, 20);
            array[0].PickupPowerUp(PowerUp.Shield, 30);
            array[1].TakeDamage(40);
            
            foreach (Enemy name in array)
            {

                Console.WriteLine($"{name.GetName()} {name.GetHealth()} {name.GetShield()}");
            }

            Console.WriteLine($"PowerUps Collected : {Enemy.GetPowerUps()}");

            
            

        }
    }
}
