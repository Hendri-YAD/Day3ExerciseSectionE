using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Not Prime");
                return;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }

            Console.WriteLine("Prime");

        }
    }
}
