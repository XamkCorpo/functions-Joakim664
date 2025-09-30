namespace Laskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse laskutoimitus (1: Yhteenlasku 2: Vähennylasku 3: Kertolasku 4: Jakolasku):");
            int laskutoimitus = Console.ReadLine();
            Console.WriteLine(laskutoimitus);


        }
    }
}
