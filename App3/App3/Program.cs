using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimasA;
            double skaiciusA;
            bool skaiciaustikrinimasB;
            double skaiciusB;
            string atsakymas;
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

            for (; ; )
            {
                Console.WriteLine("Iveskite antra kintamaji: ");
                String intLaik = Console.ReadLine();
                skaiciaustikrinimasB = double.TryParse(intLaik, out skaiciusB);
                if (skaiciaustikrinimasB == true)
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
                Console.WriteLine("Iveskite operacija(+,-,*,/):");
                String operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", skaiciusA, skaiciusB, skaiciusA + skaiciusB);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}",skaiciusA,skaiciusB,skaiciusA - skaiciusB);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", skaiciusA, skaiciusB, skaiciusA * skaiciusB);
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", skaiciusA, skaiciusB, skaiciusA / skaiciusB);
                        break;
                }
                Console.WriteLine("Ar noresite atlikti dar viena veiksma?");
                atsakymas = Console.ReadLine();
                if(atsakymas == "ne")
                {
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
