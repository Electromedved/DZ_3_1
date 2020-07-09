using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            for (int i = 1; i <= 9; i++)
            {
                result = 7 * i;
                Console.WriteLine($"7 * {i} = {result}");
            }

            Console.ReadLine();
        }
    }
}