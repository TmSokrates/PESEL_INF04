using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL_INF04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Pesel = "00000000000";
            Console.WriteLine("Podaj PESEL");
            Pesel = Console.ReadLine();
            if (Plec(Pesel) == 'K')
            {
                Console.WriteLine("Płeć: Kobieta");
            }
            else
            {
                Console.WriteLine("Płeć: Mężczyzna");
            }
            if (Poprawnosc(Pesel))
            {
                Console.WriteLine("Suma kontrolna poprawna");
            }
            else
            {
                Console.WriteLine("Suma kontrolna niepoprawna");
            }
            Console.WriteLine("KONIEC PROGRAMU");
            Console.ReadKey();
        }

        static char Plec(string Pesel)
        {
            if (int.Parse(Pesel[9].ToString()) % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        static bool Poprawnosc(string Pesel)
        {
            int[] Wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int S = 0;
            for (int i = 0; i < Wagi.Length; i++)
            {
                S += int.Parse(Pesel[i].ToString()) * Wagi[i];
            }
            int M = S % 10;
            int R;
            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }
            if (R == int.Parse(Pesel[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
