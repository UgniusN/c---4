using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma kintamaji: ");
            String intLaik = Console.ReadLine();
            int firstInteger = Convert.ToInt32(intLaik);

            Console.WriteLine("Iveskite antra kintamaji: ");
            String intLaikAntr = Console.ReadLine();
            int secondInteger = Convert.ToInt32(intLaikAntr);

            var tikrinimas = (firstInteger == secondInteger);

            Console.WriteLine("Ar vienodi? {0}", tikrinimas);

            Console.ReadLine();

        }
    }
}
