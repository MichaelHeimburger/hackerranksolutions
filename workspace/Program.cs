using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workspace
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; n > i; i++)
            {
                for (int a = 0; n - i > a; a++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; i > z; z++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
