using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skaiciaustikrinimas;
            int savaitesDiena;
            String intLaik;

            for (; ; )
            {
                Console.WriteLine("Iveskite savaites dienos skaiciu: ");
                intLaik = Console.ReadLine();
                skaiciaustikrinimas = int.TryParse(intLaik, out savaitesDiena);
                if (skaiciaustikrinimas == true && savaitesDiena > 0 && savaitesDiena < 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neteisingai ivestas savaies dienos skaiciaus formatas, teisingas ( 1 - 7 )");
                }
            }
            switch(savaitesDiena)
            {
                case 1:
                    Console.WriteLine("{0} savaites diena yra Pirmadienis",savaitesDiena);
                    break;
                case 2:
                    Console.WriteLine("{0} savaites diena yra Antradienis", savaitesDiena);
                    break;
                case 3:
                    Console.WriteLine("{0} savaites diena yra Treciadienis", savaitesDiena);
                    break;
                case 4:
                    Console.WriteLine("{0} savaites diena yra Ketvirtadienis", savaitesDiena);
                    break;
                case 5:
                    Console.WriteLine("{0} savaites diena yra Penktadienis", savaitesDiena);
                    break;
                case 6:
                    Console.WriteLine("{0} savaites diena yra Sestadienis", savaitesDiena);
                    break;
                case 7:
                    Console.WriteLine("{0} savaites diena yra Sekmadienis", savaitesDiena);
                    break;
            }

            Console.Read();
        }
    }
}
