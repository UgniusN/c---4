using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimasA;
            double skaiciusA;
            bool skaiciaustikrinimasB;
            double skaiciusB;
            for (; ; )
            {
                Console.WriteLine("Iveskite pirma kintamaji: ");
                String intLaik = Console.ReadLine();
                skaiciaustikrinimasA = double.TryParse(intLaik, out skaiciusA);
                if(skaiciaustikrinimasA==true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingas ivesto skaiciaus formatas");
                }

            }

            for (; ; )
            {
                Console.WriteLine("Iveskite antra kintamaji: ");
                String intLaikAntr = Console.ReadLine();
                skaiciaustikrinimasB = double.TryParse(intLaikAntr, out skaiciusB);

                if (skaiciaustikrinimasB == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingas ivesto skaiciaus formatas");
                }

            }

        var tikrinimas = (skaiciusA == skaiciusB);

            Console.WriteLine("Ar vienodi? {0}", tikrinimas);

            Console.ReadLine();

        }
    }
}
