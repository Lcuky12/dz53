using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 28;
            int threeDigitNumber = 999;
            int numberRandom;

            numberRandom = random.Next(minNumber, maxNumber);

            for ( int i = 0; i <= threeDigitNumber; i+=numberRandom)
            {
                Console.WriteLine(i);
            }
        }
    }
}
