namespace laskin2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse laskutoimitus (1: Yhteenlasku 2: Vähennyslasku 3: Kertolasku 4: Jakolasku):");
            int laskutoimitus;
            double vastaus = 0;

            laskutoimitus = laskutoimitusvalinta();

            if (laskutoimitus == 1)
                vastaus = yhteenlasku();
            if (laskutoimitus == 2)
                vastaus = vähennyslasku();
            if (laskutoimitus == 3)
                vastaus = kertolasku();
            if (laskutoimitus == 4)
                vastaus = jakolasku();

            Console.WriteLine($"vastaus: {vastaus}");
        }
        private static double kertolasku()
        {
            while (true)
            {
                double luku1;
                double luku2;
                Console.WriteLine("Syötä 1. luku:");
                string syotto1 = Console.ReadLine();
                if (double.TryParse(syotto1, out luku1))
                {
                    while (true)
                    {
                        Console.WriteLine("Syötä 2. luku:");
                        string syotto2 = Console.ReadLine();
                        if (double.TryParse(syotto2, out luku2))
                        {
                            return luku1 * luku2;
                        }
                        else
                        {
                            Console.WriteLine("Virhe.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Virhe.");
                }
            }

            return 0;
        }
        private static double jakolasku()
        {
            double luku1;
            double luku2;
            Console.WriteLine("Syötä 1. luku:");
            string syotto1 = Console.ReadLine();
            if (double.TryParse(syotto1, out luku1))
            {
                while (true)
                {
                    Console.WriteLine("Syötä 2. luku:");
                    string syotto2 = Console.ReadLine();
                    if (double.TryParse(syotto2, out luku2))
                    {
                        return luku1 / luku2;
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Virhe.");
            }

            return 0;
        }
        private static double vähennyslasku()
        {
            double luku1;
            double luku2;
            Console.WriteLine("Syötä 1. luku:");
            string syotto1 = Console.ReadLine();
            if (double.TryParse(syotto1, out luku1))
            {
                while (true)
                {
                    Console.WriteLine("Syötä 2. luku:");
                    string syotto2 = Console.ReadLine();
                    if (double.TryParse(syotto2, out luku2))
                    {
                        return luku1 - luku2;
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Virhe.");
            }

            return 0;
        }

        private static double yhteenlasku()
        {
            double luku1;
            double luku2;
            Console.WriteLine("Syötä 1. luku:");
            string syotto1 = Console.ReadLine();
            if (double.TryParse(syotto1, out luku1))
            {
                while (true)
                {
                    Console.WriteLine("Syötä 2. luku:");
                    string syotto2 = Console.ReadLine();
                    if (double.TryParse(syotto2, out luku2))
                    {
                        return luku1 + luku2;
                    }
                    else
                    {
                        Console.WriteLine("Virhe.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Virhe.");
            }

            return 0;
        }

        private static int laskutoimitusvalinta()
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
                    Console.WriteLine("Virhe. Syötä luku 1-4");
                }
            }

            return laskutoimitus;
        }
    }
}
