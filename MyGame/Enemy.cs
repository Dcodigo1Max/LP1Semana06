using System;
using System.Dynamic;
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
        
            this.name = name;
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

        public string SetName()
        {
            return name;
        }




    } 
    



}

