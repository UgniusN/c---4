using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimas;
            double kampasA, kampasB, kampasC;
            String intLaik;

            for (; ; )
            {
                Console.WriteLine("Iveskite trikampio pirma kampo dydi (laipsniai): ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out kampasA);
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
                Console.WriteLine("Iveskite trikampio antro kampo dydi (laipsniai): ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out kampasB);
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
                Console.WriteLine("Iveskite trikampio trecio kampo dydi (laipsniai): ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out kampasC);
                if (skaiciaustikrinimas == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingas ivesto skaiciaus formatas");
                }
            }

            var trikampioTikrinimas = (kampasA + kampasB + kampasC == 180);

            Console.WriteLine("Ar is siu pateiktu trikampiu kampu susidarys taisyklingas trikampis? {0}", trikampioTikrinimas);

            Console.Read();
        }
    }
}