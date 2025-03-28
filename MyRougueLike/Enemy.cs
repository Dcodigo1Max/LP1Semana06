using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net;
using System.Runtime.CompilerServices;

namespace MyRougueLike
{    

    public enum PowerUp
        {
            Health,
            Shield
        }

    public enum Thoughness
        {
            VeryEasy,
            Easy,
            Normal,
            Though,
            Nightmare

        }

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

        

        public void TakeDamage(float damage)
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

        public static int GetPowerUps()
        {
            return powerUpsCollected;
        }
        
        static Enemy()
        {
            powerUpsCollected = 0;
        }



        public void PickupPowerUp(PowerUp powerUp ,float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health = health + value;
                if (health > 100)
                {
                    health = 100;
                }
            }
        

            if (powerUp == PowerUp.Shield)
            {
                shield = shield + value;
                if (shield > 100)
                {
                    shield = 100;
                }
                
                
            
            }
           
           powerUpsCollected++; 
            
            
        } 


        public class Level
        {
            public void SetEnmyInRoom()
            {


            }


        }


    } 




}

