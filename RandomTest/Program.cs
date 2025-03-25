using System;

namespace RandomTest
{
    public class Program
    {

        /// <summary>
        /// Este codigo faz o random das variaveis pela seed e apresenta o seu resultado
        /// Anotações:
        /// 1:
        /// 2:
        /// 3:Os numeros são sempre os mesmos, em todos os testes do codigo 
        /// 4: Alterar o numero altera a sequencia
        /// 5: Sim, mudar um seed não muda o resultado da outra
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Random r1 = new Random(22);
            Random r2 = new Random(22);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next());



        }
    }
}
