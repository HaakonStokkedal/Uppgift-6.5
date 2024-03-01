namespace Uppgift_6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal eller en sträng.");
            var svar1 = Console.ReadLine();
            Console.WriteLine("Skriv in ett till heltal om du gjorde det innan eller en till sträng om du gjorde det innan.");
            var svar2 = Console.ReadLine();
            Console.WriteLine($"Den största heltalet eller längsta strängen är {Längst(svar1, svar2)}");
            Console.ReadKey();
        }

        static string Längst(string s, string t)
        {
            if (t.Length > s.Length)
            {
                return t;
            }
            return s;
        }

        static int Längst(int s, int t)
        {
            if (t > s)
            {
                return t;
            }
            return s;
        }
    }
}