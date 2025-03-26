using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net;
using System.Runtime.CompilerServices;

namespace MyGame
{    
   public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
        
            SetName(name);
            health = 100;
            shield =0;
        }

        public string GetName()
        {
            return name;
        }

        public string GetHealth()
        {
            return Convert.ToString(health);
        }

         public string GetShield()
        {
            return Convert.ToString(shield);
        }

        public void TakeDamaje(float damage)
        {
            shield -= damage;
            if (shield<0)
            {
                float damageStillToinflict =-shield;
                shield = 0;
                health -= damageStillToinflict;
                if (health<0) health = 0;
            }
        }

        public void SetName(string name)
        {
            this.name=name;
            if ( name.Length >8)
            {
                Console.WriteLine(name.Remove(9));
            }
            else
                {
                    Console.WriteLine(name);
                }

        }


    } 
    

}

