using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimas;
            String intLaik;
            double pajamos;
            double mokesciai;
            for (; ; ) // tikrinima ar ivedamu metiniu pajamu formatas yra teisingas
            {
                Console.WriteLine("Iveskite savo metines pajamas: ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = double.TryParse(intLaik, out pajamos);
                if (skaiciaustikrinimas == true && pajamos > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingas ivestu pajamu formatas");
                }
            }
            if (pajamos >= 100000) {
                mokesciai = pajamos * 0.35;
                Console.WriteLine("Sumoketi mokesciu reikes 35%({0}$), nes {1}$ virsija 100000$",mokesciai, pajamos);
            }
            else if(pajamos < 100000 && pajamos >= 75000) {
                mokesciai = pajamos * 0.2;
                Console.WriteLine("Sumoketi mokesciu reikes 20%({0}$), nes {1}$ virsija 75000$",mokesciai, pajamos);
            }
            else if (pajamos < 75000 && pajamos >=40000)
            {
                mokesciai = pajamos * 0.15;
                Console.WriteLine("Sumoketi mokesciu reikes 15%({0}$), nes {1}$ virsija 40000$",mokesciai, pajamos);
            }
            else {
                mokesciai = 0;
                Console.WriteLine("Sumoketi mokesciu reikes 0%({0}$), nes {1}$ nevirsija 40000$", mokesciai, pajamos);
            }
            Console.Read();
        }
    }
}
