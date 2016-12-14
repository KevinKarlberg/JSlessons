using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string hahaintename = Console.ReadLine();
            int[] pelle = new int[10];
            int[] kalle = new int[9];
            int[] fuckingstooor = new int[100000];
            WriteOutArrays(fuckingstooor, hahaintename);
            WriteOutArrays(pelle, "käften på dig kaffe");
           
        }

        static void WriteOutArrays(int[] a, string kaffe)
        {
            Console.WriteLine($"Här har du din array {kaffe} din lille fuling");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a);
            }
        }
        static void SkrivUtArray(decimal[] minArray)
        {
            for (int i = 0; i < minArray.Length; i++)
            {
                Console.WriteLine($"Värde nummer {i + 1} är: {minArray[i]}");
            }
        }
    }
}
