using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimasA;
            double skaiciusA;
            for (; ; )
            {
                Console.WriteLine("Iveskite pirma kintamaji: ");
                String intLaik = Console.ReadLine();
                skaiciaustikrinimasA = double.TryParse(intLaik, out skaiciusA);
                if (skaiciaustikrinimasA == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingas ivesto skaiciaus formatas");
                }

            }

            var teigiamasTikrinimas = (skaiciusA > 0);
            var lyginisTikrinimas = (skaiciusA % 2  == 0);


            Console.WriteLine("Ar skaicius {0} yra teigimas? {1}", skaiciusA, teigiamasTikrinimas);
            Console.WriteLine("Ar skaicius {0} yra lyginis? {1}", skaiciusA, lyginisTikrinimas);


            Console.ReadLine();

        }
    }
}
