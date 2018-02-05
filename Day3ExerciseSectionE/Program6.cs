using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program6
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int j = 1; j <= 1000; j++)
            {
                sum = 0;
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == j)
                    Console.WriteLine("{0}", j);                
            }
        }
    }
}
