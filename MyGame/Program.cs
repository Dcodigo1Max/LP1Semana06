using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            args = new string[10];

            Enemy loki = new Enemy("Loki");
            Enemy DarthVader = new Enemy("Darth Vader");
            Enemy Yami = new Enemy("Yugi");
            Enemy Nolan = new Enemy("Omni-man");

            loki.SetName(" Grindalokki");
            DarthVader.SetName("Vader");
            Yami.SetName("King of Games");
            Nolan.SetName("Space invader");
             
            //string loki = sore[2];
            

        }
    }
}
