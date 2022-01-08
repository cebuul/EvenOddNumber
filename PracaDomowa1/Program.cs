using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** Program do ookreślania parzystości liczb. ***\n\n Podaj liczbę do sprawdzenia");

            while (true)
            {
                var checkNumber = GetInput();

                EvenOddNumber(checkNumber);

            }

        }

        private static int GetInput()
        {
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Podaj liczbę całkowitą");
                    continue;
                }

                return inputNumber;
            }
        }
        private static void EvenOddNumber(int inputNumber)
        {
            if(inputNumber%2==0)
                Console.WriteLine($"Liczba {inputNumber} jest parzysta\n\nPodaj kolejną liczbę do sprawdzenia");
            else
                Console.WriteLine($"Liczba {inputNumber} jest nieparzysta\n\nPodaj kolejną liczbę do sprawdzenia");
        }
    }
}
