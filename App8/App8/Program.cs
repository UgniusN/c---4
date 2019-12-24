using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimas;
            String intLaik;
            int pasirinkimas;
            double apskritimoSpindulys;
            double staciakampioIlgis, staciakampioPlotis;
            double trikampioKrastine, trikampioAukstine;
            double apskritimoPlotas, staciakampioPlotas, trikampioPlotas;
            for (; ; )
            {
                for (; ; )
            {
                Console.WriteLine("Pasirinkite kokios figuros plota noresite skaiciuoti ( 1 - apskritimas, 2 - staciakampis, 3 - trikampis):");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = int.TryParse(intLaik, out pasirinkimas);
                if (skaiciaustikrinimas == true && pasirinkimas > 0 && pasirinkimas < 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingai ivestas figuros skaiciaus formatas ( 1 - 3 )");
                }
            }

                switch (pasirinkimas)
                {
                    case 1: // apskritimo ploto skaiciavimas ir isvedimas
                        for (; ; ) // tikrinima ar ivedamo apskritimo spindulys yra teisingo formato
                        {
                            Console.WriteLine("Iveskite apskritimo spinduli: ");
                            intLaik = Console.ReadLine();
                            skaiciaustikrinimas = double.TryParse(intLaik, out apskritimoSpindulys);
                            if (skaiciaustikrinimas == true && pasirinkimas > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neteisingai ivestas apskritimo spindulys");
                            }
                        }
                        apskritimoPlotas = Math.PI * Math.Pow(apskritimoSpindulys, 2);
                        Console.WriteLine("Apskritimo plotas = {0};", apskritimoPlotas);
                        break;


                    case 2: // staciakampio ploto skaiciavimas ir isvedimas
                        for (; ; ) // tikrinima ar ivedamos staciakampio krastines ilgis yra teisingo formato
                        {
                            Console.WriteLine("Iveskite staciakampio ilgi: ");
                            intLaik = Console.ReadLine();
                            skaiciaustikrinimas = double.TryParse(intLaik, out staciakampioIlgis);
                            if (skaiciaustikrinimas == true && pasirinkimas > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neteisingai ivestas staciakampio ilgis");
                            }
                        }

                        for (; ; ) // tikrinima ar ivedamos staciakampio krastines plotis yra teisingo formato
                        {
                            Console.WriteLine("Iveskite apskritimo ploti: ");
                            intLaik = Console.ReadLine();
                            skaiciaustikrinimas = double.TryParse(intLaik, out staciakampioPlotis);
                            if (skaiciaustikrinimas == true && pasirinkimas > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neteisingai ivestas staciakampio plotis");
                            }
                        }
                        staciakampioPlotas = staciakampioIlgis * staciakampioPlotis;
                        Console.WriteLine("Staciakampio plotas = {0};", staciakampioPlotas);
                        break;


                    case 3: // trikampio ploto skaiciavimas ir isvedimas
                        for (; ; ) // tikrinima ar ivedamos trikampio krastines ilgis yra teisingo formato
                        {
                            Console.WriteLine("Iveskite trikampio krastines ilgi: ");
                            intLaik = Console.ReadLine();
                            skaiciaustikrinimas = double.TryParse(intLaik, out trikampioKrastine);
                            if (skaiciaustikrinimas == true && pasirinkimas > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neteisingai ivestas trikampio krastines ilgis");
                            }
                        }
                        for (; ; ) // tikrinima ar ivedamos trikampio aukstines ilgis yra teisingo formato
                        {
                            Console.WriteLine("Iveskite trikampio aukstines ilgi: ");
                            intLaik = Console.ReadLine();
                            skaiciaustikrinimas = double.TryParse(intLaik, out trikampioAukstine);
                            if (skaiciaustikrinimas == true && pasirinkimas > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neteisingai ivestas trikampio aukstines ilgis");
                            }
                        }
                        trikampioPlotas = 0.5 * trikampioAukstine * trikampioKrastine;
                        Console.WriteLine("Trikampio plotas = {0};", trikampioPlotas);
                        break;
                }
                Console.WriteLine("Ar noresite skaiciuoti dar vienos figuros plota? ( Taip / Ne )");
                String pratesimoPasirinkimas = Console.ReadLine();
                if (pratesimoPasirinkimas == "Ne")
                {
                    break;
                }
            }
        }
    }
}
