using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmierung_grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testausdrücke auswerten
            int e = 5; 
            int f = 7; 
            int g = 2;

            // Testausdruck wahr?
            if (!(g != e)) 
            {
                Console.WriteLine("!(g != e) ist wahr");
            }

            // Testausdruck nicht wahr?
            else
            {
                Console.WriteLine("!(g != e) ist falsch");
            }

            // Testausdruck wahr?
            if (e / f > 0)
            {
                Console.WriteLine("e / f > 0 ist wahr");
            }

            // Testausdruck nicht wahr?
            else
            {
                Console.WriteLine("e / f > 0 ist falsch");
            }

            // Testausdruck wahr?
            if ((double)e / f > 0)
            {
                Console.WriteLine("(double)e / f > 0 ist wahr");
            }

            // Testausdruck nicht wahr?
            else
            {
                Console.WriteLine("(double)e / f > 0 ist falsch");
            }

            // Testausdruck wahr?
            if (e - f - g * 5 < f + g)
            {
                Console.WriteLine("e - f - g * 5 < f + g ist wahr");
            }

            // Testausdruck nicht wahr?
            else
            {
                Console.WriteLine("e - f - g * 5 < f + g ist falsch");
            }

            // Testausdruck wahr?
            if (f > e || g > e)
            {
                Console.WriteLine("f > e || g > e ist wahr");
            }

            // Testausdruck nicht wahr?
            else
            {
                Console.WriteLine("f > e || g > e ist falsch");
            }

            // Schleifen

        }
    }
}
