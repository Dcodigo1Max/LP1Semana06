using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //Inicialize cronometors
            Stopwatch crono1 = new Stopwatch();

            Stopwatch crono2 = new Stopwatch();


            //Start and pause cronometor1
            crono1.Start();
            Thread.Sleep(500);
            
            //Start and pause cronometor2
            crono2.Start();
            Thread.Sleep(250);
            
            //Stop conometors
            crono1.Stop();
            crono2.Stop();

            //Get the elapsed time as timespan value
            TimeSpan ts1 = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;



            //Format and display the timespan value
            string elapsedTime1 = string.Format("{0.0000}: {1.0000}: {2.0000}: {3.0000}",
            ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10 );

            string elapsedTime2 = string.Format("{0.0000}: {1.0000}: {2.0000}: {3.0000}",
            ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10 );
            

            Console.WriteLine("Crono1: " + elapsedTime1);
            Console.WriteLine("Crono2: " + elapsedTime2);


        }



        
    
    
    
    
    
    }


    

}
