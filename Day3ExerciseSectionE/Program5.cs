using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program5
    {
        static void Main(string[] args)
        {            
            int i;

            for (int j = 5; j <= 10000; j++)
            {
                for (i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        break;
                    }                    
                }
                
                if (j % i != 0)
                    Console.Write("{0} ", j);
            }

            Console.WriteLine();
        }
    }
}
