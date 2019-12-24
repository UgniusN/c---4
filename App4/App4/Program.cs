using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimas;
            double skaiciusA, skaiciusB, skaiciusC;
            String intLaik;

            for (; ; )
            {
                Console.WriteLine("Iveskite pirma kintamaji: ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out skaiciusA);
                if (skaiciaustikrinimas== true)
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
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out skaiciusB);
                if (skaiciaustikrinimas == true)
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
                Console.WriteLine("Iveskite trecia kintamaji: ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out skaiciusC);
                if (skaiciaustikrinimas == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingas ivesto skaiciaus formatas");
                }
            }

            double maxSkaicius = Math.Max(Math.Max(skaiciusA, skaiciusB), skaiciusC);

            Console.WriteLine("Didziausias is siu ivestu skaiciu yra: {0}", maxSkaicius);

            Console.Read();
        }
    }
}
