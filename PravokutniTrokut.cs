using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PravokutniTrokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upsisi vrijednost a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Upsisi vrijednost b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Upsisi vrijednost c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                {
                    Console.WriteLine("Trokut je pravokutan.");
                }
                else
                {
                    Console.WriteLine("Trokut nije pravokutan.");
                }
            }
            else
            {
                Console.WriteLine("Stranica ne moze biti 0!");
            }

            Console.ReadKey();
        }
    }
}
