using System.ComponentModel.Design;

namespace Laskin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse laskutoimitus (1: Yhteenlasku 2: Vähennyslasku 3: Kertolasku 4: Jakolasku):");
            int laskutoimitus;
            laskutoimitus = syotto1();
            yhteenlasku(laskutoimitus);
            vähennyslasku(laskutoimitus);
            kertolasku(laskutoimitus);
            jakolasku(laskutoimitus);
        }
        static int syotto1()
        {
            int laskutoimitus;
            while (true)
            {
                string valinta1 = Console.ReadLine();
                if (int.TryParse(valinta1, out laskutoimitus) && laskutoimitus >= 1 && laskutoimitus <= 4)
                {
                    break;
                }                
                else
                {
                    Console.WriteLine("Virhe.");
                    Console.WriteLine("Valitse numero (1-4)");
                }
            }
            return laskutoimitus;
        }
        private static void yhteenlasku(int laskutoimitus)
        {
            if (laskutoimitus == 1)
            {
                Console.WriteLine("Syötä 1. luku:");
                double luku1;
                double luku2;
                while (true)
                {
                    string syotto1 = Console.ReadLine();
                    if (double.TryParse(syotto1, out luku1))
                    {
                        Console.WriteLine("Syötä 2. luku:");
                        string syotto2 = Console.ReadLine();
                        if (double.TryParse(syotto2, out luku2))
                        {
                            Console.WriteLine($"Vastaus: {luku1 + luku2}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Virhe.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
         }
        private static void vähennyslasku(int laskutoimitus)
        {
            if (laskutoimitus == 2)
            {
                Console.WriteLine("Syötä 1. luku:");
                double luku1;
                double luku2;
                while (true)
                {
                    string syotto1 = Console.ReadLine();
                    if (double.TryParse(syotto1, out luku1))
                    {
                        Console.WriteLine("Syötä 2. luku:");
                        string syotto2 = Console.ReadLine();
                        if (double.TryParse(syotto2, out luku2))
                        {
                            Console.WriteLine($"Vastaus: {luku1 - luku2}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Virhe.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
        }
        private static void kertolasku(int laskutoimitus)
        {
            if (laskutoimitus == 3)
            {
                Console.WriteLine("Syötä 1. luku:");
                double luku1;
                double luku2;
                while (true)
                {
                    string syotto1 = Console.ReadLine();
                    if (double.TryParse(syotto1, out luku1))
                    {
                        Console.WriteLine("Syötä 2. luku:");
                        string syotto2 = Console.ReadLine();
                        if (double.TryParse(syotto2, out luku2))
                        {
                            Console.WriteLine($"Vastaus: {luku1 * luku2}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Virhe.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
        }
        private static void jakolasku(int laskutoimitus)
        {
            if (laskutoimitus == 4)
            {
                Console.WriteLine("Syötä 1. luku:");
                double luku1;
                double luku2;
                while (true)
                {
                    string syotto1 = Console.ReadLine();
                    if (double.TryParse(syotto1, out luku1))
                    {
                        Console.WriteLine("Syötä 2. luku:");
                        string syotto2 = Console.ReadLine();
                        if (double.TryParse(syotto2, out luku2))
                        {
                            Console.WriteLine($"Vastaus: {luku1 / luku2}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Virhe.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
        }
    }
}
